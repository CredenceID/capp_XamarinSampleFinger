using Android.App;
using Android.Widget;
using Android.OS;
using Android.Graphics;

using Com.Credenceid.Biometrics;
using System;
using Android.Content;

namespace FingerprintTest {
    [Activity(Label = "FingerprintTest", MainLauncher = true, Icon = "@mipmap/icon", Name = "com.biometricstest.mobile.FingerprintTest.MainActivity")]
    public class MainActivity : Activity {

        /* *****************************************************************************
         * Components in layout file.
         * *****************************************************************************
         */
        private static ImageView mFingerprintOneImageView;
        private static ImageView mFingerprintTwoImageView;
        private static Button mOpenCloseButton;
        private static Button mCaptureButton;
        private static Button mMatchButton;
        private static TextView mStatusTextView;
        private static TextView mInfoTextView;

        /* Used for loading resources, binding views, etc. */
        private static Context mContext;

        /* Object to interface with CredenceID biometric APIs. */
        private static BiometricsManager mBioManager;
		/* Stores which specific family of CrdenceID device's application is running on. */
		private static DeviceFamily mDeviceFamily = DeviceFamily.InvalidDevice;
		/* Stores which specific CredenceID device this application is running on. */
		private static DeviceType mDeviceType = DeviceType.InvalidDevice;
        
        /* If true, then "mOpenClose" button text is "Open" meaning we need to open fingerprint.
	     * If false, then "mOpenClose" button text is "Close" meaning we need to close fingerprint.
	     */
        private static bool mOpenFingerprint = true;
        /* We are capturing two fingerprints. If true then capture saves data as first fingerprint; if
	     * false capture saves data as second fingerprint.
	     */
        private static bool mCaptureFingerprintOne = true;

        static byte[] mFingerOneFMDTemplate;
        static byte[] mFingerTwoFMDTemplate;
        
        /* *********************************************************************************
         * Android activity lifecycle methods.
         * *********************************************************************************
         */

        protected override void
        OnCreate(Bundle savedInstanceState) {
            
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);

            /*  Create new biometrics object. */
            mBioManager = new BiometricsManager((mContext = this));
            /* Initialize object, meaning tell CredenceService to bind to this application. */
            mBioManager.InitializeBiometrics(new BiometricsOnInitializedListener());

            this.initializeLayoutComponents();
            this.configureLayoutComponents();
        }

        protected override void
        OnDestroy() {

            base.OnDestroy();

            /* Tell biometrics to cancel current on-going capture. */
            mBioManager.CancelCapture();
            /* Close all open peripherals. */
            mBioManager.CloseFingerprintReader();
            /* If user presses back button then they are exiting application. If this is the case then
		     * tell C-Service to unbind from this application.
		     */
            mBioManager.FinalizeBiometrics(false);
        }

        /* *********************************************************************************
         * Initialization & configuration methods.
         * *********************************************************************************
         */

        private void
        initializeLayoutComponents() {

            mFingerprintOneImageView = FindViewById<ImageView>(Resource.Id.finger_one_imageview);
            mFingerprintTwoImageView = FindViewById<ImageView>(Resource.Id.finger_two_imageview);

            mOpenCloseButton = FindViewById<Button>(Resource.Id.open_close_button);
            mCaptureButton = FindViewById<Button>(Resource.Id.capture_button);
            mMatchButton = FindViewById<Button>(Resource.Id.match_button);

            mStatusTextView = FindViewById<TextView>(Resource.Id.status_textview);
            mInfoTextView = FindViewById<TextView>(Resource.Id.fingeprint_info_textview);
        }

        private void
        configureLayoutComponents() {

            setCaptureMatchButtonEnable(false);

            mFingerprintOneImageView.Click += (object sender, System.EventArgs e) => {
                /* This ImageView should turn green since it was selected. */
                mFingerprintOneImageView.SetBackgroundResource(Resource.Drawable.image_border_on);
                /* Other ImageView should turn black or off. */
                mFingerprintTwoImageView.SetBackgroundResource(Resource.Drawable.image_border_off);
                
                mCaptureFingerprintOne = true;
            };

            mFingerprintTwoImageView.Click += (object sender, System.EventArgs e) => {
                /* This ImageView should turn green since it was selected. */
                mFingerprintTwoImageView.SetBackgroundResource(Resource.Drawable.image_border_on);
                /* Other ImageView should turn black or off. */
                mFingerprintOneImageView.SetBackgroundResource(Resource.Drawable.image_border_off);

                mCaptureFingerprintOne = false;
            };
            
            /* Inside onClickListeners for each button, we disable all buttons until their respective
		     * operation is complete. Once it is done, the appropriate buttons are re-enabled.
		     */
            mOpenCloseButton.Click += (object sender, System.EventArgs e) => {
                setAllComponentEnable(false);

                if (mOpenFingerprint)
                    mBioManager.OpenFingerprintReader(new FingerprintOpenCloseListener());
                else mBioManager.CloseFingerprintReader();
            };

            mCaptureButton.Click += (object sender, System.EventArgs e) => {
                setAllComponentEnable(false);
                mInfoTextView.Text = "";

                if (mCaptureFingerprintOne)
                    this.captureFingerOne();
                else this.captureFingerTwo();
            };

            mMatchButton.Click += (object sender, System.EventArgs e) => {
                setAllComponentEnable(false);
                matchFMDTemplates(mFingerOneFMDTemplate, mFingerTwoFMDTemplate);
            };
        }

        /* *********************************************************************************
         * Methods that edit UI components.
         * *********************************************************************************
         */

        private static void
        setCaptureMatchButtonEnable(bool enable) {

            mCaptureButton.Enabled = enable;
            mMatchButton.Enabled = enable;
        }

        private static void
        setAllComponentEnable(bool enable) {

            setCaptureMatchButtonEnable(enable);

            mOpenCloseButton.Enabled = enable;
            mFingerprintOneImageView.Enabled = enable;
            mFingerprintTwoImageView.Enabled = enable;
        }

        /* *********************************************************************************
         * Private helpers.
         * *********************************************************************************
         */

        /* Make CredenceSDK API calls to capture "first" fingerprint. This is fingerprint image on left
         * side of layout file.
         */
        private void
        captureFingerOne() {

            mFingerOneFMDTemplate = null;
            mBioManager.GrabFingerprint(BiometricsScanType.SingleFinger, new GrabFingerOneListener());
        }

        /* Make CredenceSDK API calls to capture "second" fingerprint. This is fingerprint image on left
         * side of layout file.
         */
        private void
        captureFingerTwo() {

            mFingerTwoFMDTemplate = null;
            mBioManager.GrabFingerprint(BiometricsScanType.SingleFinger, new GrabFingerTwoListener());
        }

        private static void
        createFMDTemplate(Bitmap bitmap) {

            mBioManager.ConvertToFmd(bitmap, BiometricsFmdFormat.Iso1979422005, new ConvertToFMDListener((CovertToFMDResult result) => {

                if (BiometricsResultCode.Ok == result.ResultCode) {
                    mInfoTextView.Text = ("Created FMD template.");

                    if (mCaptureFingerprintOne)
                        mFingerOneFMDTemplate = (byte[]) result.FMD.Clone();
                    else mFingerTwoFMDTemplate = (byte[])result.FMD.Clone();

                    /* If both templates have been created then enable Match button. */
                    if (mFingerOneFMDTemplate != null && mFingerTwoFMDTemplate != null)
                        mMatchButton.Enabled = true;
                } else if (BiometricsResultCode.Fail == result.ResultCode)
                    mStatusTextView.Text = ("Failed to create FMD template.");
            }));
        }

        private void
        matchFMDTemplates(byte[] FMDOne, byte[] FMDTwo) {

            /* Normally one would handle parameter checking, but this API handles it for us. Meaning
		     * that if any FMD is invalid it will return the proper score of 0, etc.
		     */
             
            mBioManager.CompareFmd(FMDOne, FMDTwo, BiometricsFmdFormat.Iso1979422005, new OnCompareFMD());
        }

		private static void
		setDeviceType(String productName) {

			if (productName == "Credence One V1")
				mDeviceType = DeviceType.CredenceOneV1F;
			else if (productName == "Credence One V2")
				mDeviceType = DeviceType.CredenceOneV2FC;
			else if (productName == "Credence One V3")
				mDeviceType = DeviceType.CredenceOneV3FCM;
			else if (productName == "Credence Two V1")
				mDeviceType = DeviceType.CredenceTwoV1F;
			else if (productName == "Credence Two V2")
				mDeviceType = DeviceType.CredenceTwoV2FC;
			else if (productName == "Credence TAB V1")
				mDeviceType = DeviceType.CredenceTabV1F;
			else if (productName == "Credence TAB V2")
				mDeviceType = DeviceType.CredenceTabV2FC;
			else if (productName == "Credence TAB V3")
				mDeviceType = DeviceType.CredenceTabV3FM;
			else if (productName == "Credence TAB V4")
				mDeviceType = DeviceType.CredenceTabV4FCM;
			else if (productName == "Trident-1")
				mDeviceType = DeviceType.Trident1;
			else if (productName == "Trident-2")
				mDeviceType = DeviceType.Trident2;
			else if (productName == "Twizzler")
				mDeviceType = DeviceType.Twizzler;
		}

        /* *********************************************************************************
         * Callback invoked when biometrics initializes.
         * *********************************************************************************
         */
        public class BiometricsOnInitializedListener : Java.Lang.Object, IBiometricsOnInitializedListener {

			public void OnInitialized(BiometricsResultCode p0,
									  string p1,
									  string p2) {

				int strID = Resource.String.bio_init_good;
				if (BiometricsResultCode.Ok == p0) {
					mOpenCloseButton.Enabled = true;
					setDeviceType(mBioManager.ProductName);

				} else if (BiometricsResultCode.Fail == p0)
                    strID = Resource.String.bio_init_failed;

                Toast.MakeText(mContext, strID, ToastLength.Long).Show();
            }
        }

        /* *********************************************************************************
         * Callback invoked when fingerprint sensor either opens or closes.
         * *********************************************************************************
         */
        public class FingerprintOpenCloseListener : Java.Lang.Object, IBiometricsFingerprintReaderStatusListener {

            public void OnOpenFingerprintReader(BiometricsResultCode resultCode,
                                                string hint) {

                /* If hint is valid, display it. */
                if (null != hint && hint.Length != 0)
                    mStatusTextView.Text = hint;

                if (BiometricsResultCode.Ok == resultCode) {
                    /* Now that sensor is open, if user presses "mOpenCloseButton" fingerprint
                     * sensor should now close. To achieve this we change flag which controls
					 * what action mOpenCloseButton takes.
					 */
                    mOpenFingerprint = false;
                    
                    /* If fingerprint opened then we change button to say "Close". */
                    mOpenCloseButton.SetText(Resource.String.close);
                    /* Re-enable button since operation is complete. */
                    setAllComponentEnable(true);
                    /* Disable match since both FMD templates must be created first. */
                    mMatchButton.Enabled = false;
                    
                } else if (BiometricsResultCode.Intermediate == resultCode) {

                } else if (BiometricsResultCode.Fail == resultCode) {
                    /* Re-enable button since operation is complete. */
                    mOpenCloseButton.Enabled = true;
                }
            }

            public void OnCloseFingerprintReader(BiometricsResultCode resultCode,
                                                 BiometricsCloseReasonCode closeReasonCode) {

                if (BiometricsResultCode.Ok == resultCode)
                    mStatusTextView.Text = ("Fingerprint Closed: " + closeReasonCode);

                /* Now that sensor is closed, if user presses "mOpenCloseButton" fingerprint
                 * sensor should now open. To achieve this we change flag which controls
                 * what action mOpenCloseButton takes.
                 */
                mOpenFingerprint = true;

                /* Change text back to "Open" and allow button to be clickable. */
                mOpenCloseButton.SetText(Resource.String.open);
                mOpenCloseButton.Enabled = true;
                /* Since sensor is closed, user should NOT be able to press capture or match. */
                mCaptureButton.Enabled = false;
                mMatchButton.Enabled = false;
            }
        }
        
        /* *********************************************************************************
         * Callback invoked when C-Service returns with fingerprint results.
         * *********************************************************************************
         */
        public class GrabFingerOneListener : Java.Lang.Object, IBiometricsOnFingerprintGrabbedWSQListener {

            public void OnFingerprintGrabbed(BiometricsResultCode resultCode,
                                             Bitmap bitmap,
                                             byte[] bytes,
                                             string filePath,
                                             string WSQFilePath,
                                             string hint,
                                             int NFIQScore) {

                /* If hint is valid, display it. */
                if (null != hint && hint.Length != 0)
                    mStatusTextView.Text = hint;
                
                if (null != bitmap)
                    mFingerprintOneImageView.SetImageBitmap(bitmap);
                
                if (BiometricsResultCode.Ok == resultCode) {
                    mStatusTextView.Text = ("WSQ File: " + WSQFilePath);
                    mInfoTextView.Text = ("Quality: " + NFIQScore);

                    /* Create template from fingerprint image. */
                    createFMDTemplate(bitmap);

                    setAllComponentEnable(true);

                } else if (BiometricsResultCode.Intermediate == resultCode) {
                    /* This case may occur if "cancelCapture()" or "closeFingerprint()" are called while
                     * in middle of capture OR if capture failed.
                     */
                    if (null != hint && hint.Equals("Capture Stopped"))
                        setAllComponentEnable(true);

                } else if (BiometricsResultCode.Fail == resultCode) {
                    mStatusTextView.Text = "Failed to capture fingerprint.";
                    setAllComponentEnable(true);
                }
            }

            public void OnCloseFingerprintReader(BiometricsResultCode resultCode,
                                                 BiometricsCloseReasonCode closeReasonCode) {

                /* This case is already handled by "mFingerprintOpenCloseListener". */
            }

        }

        /* *********************************************************************************
         * Callback invoked when C-Service returns with fingerprint results.
         * *********************************************************************************
         */
        public class GrabFingerTwoListener : Java.Lang.Object, IBiometricsOnFingerprintGrabbedListener {
            
            public void OnFingerprintGrabbed(BiometricsResultCode resultCode,
                                             Bitmap bitmap,
                                             byte[] bytes,
                                             string s,
                                             string hint) {

                /* If hint is valid, display it. */
                if (null != hint && hint.Length != 0)
                    mStatusTextView.Text = hint;

                if (null != bitmap)
                    mFingerprintTwoImageView.SetImageBitmap(bitmap);

                if (BiometricsResultCode.Ok == resultCode) {
                    /* Create template from fingerprint image. */
                    createFMDTemplate(bitmap);

                    setAllComponentEnable(true);

                } else if (BiometricsResultCode.Intermediate == resultCode) {
                    /* This case may occur if "cancelCapture()" or "closeFingerprint()" are called while
                     * in middle of capture OR if capture failed.
                     */
                    if (null != hint && hint.Equals("Capture Stopped"))
                        setAllComponentEnable(true);

                } else if (BiometricsResultCode.Fail == resultCode) {
                    mStatusTextView.Text = "Failed to capture fingerprint.";
                    setAllComponentEnable(true);
                }
            }

            public void OnCloseFingerprintReader(BiometricsResultCode resultCode,
                                                 BiometricsCloseReasonCode closeReasonCode) {

                /* This case is already handled by "mFingerprintOpenCloseListener". */
            }
        }

        /* *********************************************************************************
         * Class containing all data returned back by convertToFMD API call.
         * *********************************************************************************
         */
        public class CovertToFMDResult {
            public BiometricsResultCode ResultCode;
            public byte[] FMD;
        }

        /* *********************************************************************************
         * Callback invoked wehn C-Service returns with FMD creation result.
         * *********************************************************************************
         */
        public class ConvertToFMDListener : Java.Lang.Object, IBiometricsOnConvertToFmdListener {
            public delegate void OnFinishedWithResult(CovertToFMDResult result);

            public ConvertToFMDListener(OnFinishedWithResult onFinishedWithResult) {
                _finishedWithResult = onFinishedWithResult;
            }

            OnFinishedWithResult _finishedWithResult;

            public void OnConvertToFmd(BiometricsResultCode p0, byte[] p1) {
                _finishedWithResult?.Invoke(new CovertToFMDResult { ResultCode = p0, FMD = p1 });
            }
        }

        /* *********************************************************************************
         * Callback invoked wehn C-Service returns with compareFMD result.
         * *********************************************************************************
         */
        public class OnCompareFMD : Java.Lang.Object, IBiometricsOnCompareFmdListener {
            public void OnCompareFmd(BiometricsResultCode resultCode,
                                    float dissimilarity) {

                /* Re-enable all components since operation is now complete. */
                setAllComponentEnable(true);

                if (BiometricsResultCode.Ok == resultCode) {
                    String matchDecision = "No Match";
                    /* This is how to properly determine a match or not. */
                    if (dissimilarity < (int.MaxValue / 1000000))
                        matchDecision = "Match";

                    mStatusTextView.Text = ("Matching complete.");
                    mInfoTextView.Text = ("Match outcome: " + matchDecision);

                } else if  (BiometricsResultCode.Fail == resultCode) {
                    mStatusTextView.Text = "Failed to compare templates.";
                    mInfoTextView.Text = "";
                }
            }
        }
    }
}

