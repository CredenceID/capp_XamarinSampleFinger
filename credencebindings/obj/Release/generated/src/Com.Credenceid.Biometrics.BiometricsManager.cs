using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Credenceid.Biometrics {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']"
	[global::Android.Runtime.Register ("com/credenceid/biometrics/BiometricsManager", DoNotGenerateAcw=true)]
	public partial class BiometricsManager : global::Java.Lang.Object, global::Com.Credenceid.Biometrics.IBiometrics, global::Com.Credenceid.Database.IBiometricDatabase, global::Com.Credenceid.Face.IFaceEngine {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/credenceid/biometrics/BiometricsManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BiometricsManager); }
		}

		protected BiometricsManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_app_Activity_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/constructor[@name='BiometricsManager' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register (".ctor", "(Landroid/app/Activity;)V", "")]
		public unsafe BiometricsManager (global::Android.App.Activity activity)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (activity);
				if (((object) this).GetType () != typeof (BiometricsManager)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/app/Activity;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/app/Activity;)V", __args);
					return;
				}

				if (id_ctor_Landroid_app_Activity_ == IntPtr.Zero)
					id_ctor_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/app/Activity;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_app_Activity_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/constructor[@name='BiometricsManager' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe BiometricsManager (global::Android.Content.Context context)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (context);
				if (((object) this).GetType () != typeof (BiometricsManager)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_getDeviceFamily;
#pragma warning disable 0169
		static Delegate GetGetDeviceFamilyHandler ()
		{
			if (cb_getDeviceFamily == null)
				cb_getDeviceFamily = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeviceFamily);
			return cb_getDeviceFamily;
		}

		static IntPtr n_GetDeviceFamily (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeviceFamily);
		}
#pragma warning restore 0169

		static IntPtr id_getDeviceFamily;
		public virtual unsafe global::Com.Credenceid.Biometrics.DeviceFamily DeviceFamily {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='getDeviceFamily' and count(parameter)=0]"
			[Register ("getDeviceFamily", "()Lcom/credenceid/biometrics/DeviceFamily;", "GetGetDeviceFamilyHandler")]
			get {
				if (id_getDeviceFamily == IntPtr.Zero)
					id_getDeviceFamily = JNIEnv.GetMethodID (class_ref, "getDeviceFamily", "()Lcom/credenceid/biometrics/DeviceFamily;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.DeviceFamily> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeviceFamily), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.DeviceFamily> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDeviceFamily", "()Lcom/credenceid/biometrics/DeviceFamily;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDeviceID;
#pragma warning disable 0169
		static Delegate GetGetDeviceIDHandler ()
		{
			if (cb_getDeviceID == null)
				cb_getDeviceID = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeviceID);
			return cb_getDeviceID;
		}

		static IntPtr n_GetDeviceID (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceID);
		}
#pragma warning restore 0169

		static IntPtr id_getDeviceID;
		public virtual unsafe string DeviceID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='getDeviceID' and count(parameter)=0]"
			[Register ("getDeviceID", "()Ljava/lang/String;", "GetGetDeviceIDHandler")]
			get {
				if (id_getDeviceID == IntPtr.Zero)
					id_getDeviceID = JNIEnv.GetMethodID (class_ref, "getDeviceID", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeviceID), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDeviceID", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDeviceType;
#pragma warning disable 0169
		static Delegate GetGetDeviceTypeHandler ()
		{
			if (cb_getDeviceType == null)
				cb_getDeviceType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeviceType);
			return cb_getDeviceType;
		}

		static IntPtr n_GetDeviceType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeviceType);
		}
#pragma warning restore 0169

		static IntPtr id_getDeviceType;
		public virtual unsafe global::Com.Credenceid.Biometrics.DeviceType DeviceType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='getDeviceType' and count(parameter)=0]"
			[Register ("getDeviceType", "()Lcom/credenceid/biometrics/DeviceType;", "GetGetDeviceTypeHandler")]
			get {
				if (id_getDeviceType == IntPtr.Zero)
					id_getDeviceType = JNIEnv.GetMethodID (class_ref, "getDeviceType", "()Lcom/credenceid/biometrics/DeviceType;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.DeviceType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeviceType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.DeviceType> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDeviceType", "()Lcom/credenceid/biometrics/DeviceType;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFingerprintScannerType;
#pragma warning disable 0169
		static Delegate GetGetFingerprintScannerTypeHandler ()
		{
			if (cb_getFingerprintScannerType == null)
				cb_getFingerprintScannerType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFingerprintScannerType);
			return cb_getFingerprintScannerType;
		}

		static IntPtr n_GetFingerprintScannerType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FingerprintScannerType);
		}
#pragma warning restore 0169

		static IntPtr id_getFingerprintScannerType;
		public virtual unsafe global::Com.Credenceid.Biometrics.BiometricsFingerprintScannerType FingerprintScannerType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='getFingerprintScannerType' and count(parameter)=0]"
			[Register ("getFingerprintScannerType", "()Lcom/credenceid/biometrics/Biometrics$FingerprintScannerType;", "GetGetFingerprintScannerTypeHandler")]
			get {
				if (id_getFingerprintScannerType == IntPtr.Zero)
					id_getFingerprintScannerType = JNIEnv.GetMethodID (class_ref, "getFingerprintScannerType", "()Lcom/credenceid/biometrics/Biometrics$FingerprintScannerType;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsFingerprintScannerType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFingerprintScannerType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsFingerprintScannerType> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFingerprintScannerType", "()Lcom/credenceid/biometrics/Biometrics$FingerprintScannerType;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_hasCardReader;
#pragma warning disable 0169
		static Delegate GetHasCardReaderHandler ()
		{
			if (cb_hasCardReader == null)
				cb_hasCardReader = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasCardReader);
			return cb_hasCardReader;
		}

		static bool n_HasCardReader (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasCardReader;
		}
#pragma warning restore 0169

		static IntPtr id_hasCardReader;
		public virtual unsafe bool HasCardReader {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='hasCardReader' and count(parameter)=0]"
			[Register ("hasCardReader", "()Z", "GetHasCardReaderHandler")]
			get {
				if (id_hasCardReader == IntPtr.Zero)
					id_hasCardReader = JNIEnv.GetMethodID (class_ref, "hasCardReader", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasCardReader);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasCardReader", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_hasFMDMatcher;
#pragma warning disable 0169
		static Delegate GetHasFMDMatcherHandler ()
		{
			if (cb_hasFMDMatcher == null)
				cb_hasFMDMatcher = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasFMDMatcher);
			return cb_hasFMDMatcher;
		}

		static bool n_HasFMDMatcher (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasFMDMatcher;
		}
#pragma warning restore 0169

		static IntPtr id_hasFMDMatcher;
		public virtual unsafe bool HasFMDMatcher {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='hasFMDMatcher' and count(parameter)=0]"
			[Register ("hasFMDMatcher", "()Z", "GetHasFMDMatcherHandler")]
			get {
				if (id_hasFMDMatcher == IntPtr.Zero)
					id_hasFMDMatcher = JNIEnv.GetMethodID (class_ref, "hasFMDMatcher", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasFMDMatcher);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasFMDMatcher", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_hasFingerprintScanner;
#pragma warning disable 0169
		static Delegate GetHasFingerprintScannerHandler ()
		{
			if (cb_hasFingerprintScanner == null)
				cb_hasFingerprintScanner = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasFingerprintScanner);
			return cb_hasFingerprintScanner;
		}

		static bool n_HasFingerprintScanner (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasFingerprintScanner;
		}
#pragma warning restore 0169

		static IntPtr id_hasFingerprintScanner;
		public virtual unsafe bool HasFingerprintScanner {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='hasFingerprintScanner' and count(parameter)=0]"
			[Register ("hasFingerprintScanner", "()Z", "GetHasFingerprintScannerHandler")]
			get {
				if (id_hasFingerprintScanner == IntPtr.Zero)
					id_hasFingerprintScanner = JNIEnv.GetMethodID (class_ref, "hasFingerprintScanner", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasFingerprintScanner);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasFingerprintScanner", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_hasIrisScanner;
#pragma warning disable 0169
		static Delegate GetHasIrisScannerHandler ()
		{
			if (cb_hasIrisScanner == null)
				cb_hasIrisScanner = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasIrisScanner);
			return cb_hasIrisScanner;
		}

		static bool n_HasIrisScanner (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasIrisScanner;
		}
#pragma warning restore 0169

		static IntPtr id_hasIrisScanner;
		public virtual unsafe bool HasIrisScanner {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='hasIrisScanner' and count(parameter)=0]"
			[Register ("hasIrisScanner", "()Z", "GetHasIrisScannerHandler")]
			get {
				if (id_hasIrisScanner == IntPtr.Zero)
					id_hasIrisScanner = JNIEnv.GetMethodID (class_ref, "hasIrisScanner", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasIrisScanner);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasIrisScanner", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_hasMRZReader;
#pragma warning disable 0169
		static Delegate GetHasMRZReaderHandler ()
		{
			if (cb_hasMRZReader == null)
				cb_hasMRZReader = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasMRZReader);
			return cb_hasMRZReader;
		}

		static bool n_HasMRZReader (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasMRZReader;
		}
#pragma warning restore 0169

		static IntPtr id_hasMRZReader;
		public virtual unsafe bool HasMRZReader {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='hasMRZReader' and count(parameter)=0]"
			[Register ("hasMRZReader", "()Z", "GetHasMRZReaderHandler")]
			get {
				if (id_hasMRZReader == IntPtr.Zero)
					id_hasMRZReader = JNIEnv.GetMethodID (class_ref, "hasMRZReader", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasMRZReader);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasMRZReader", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_hasNFCCardReader;
#pragma warning disable 0169
		static Delegate GetHasNFCCardReaderHandler ()
		{
			if (cb_hasNFCCardReader == null)
				cb_hasNFCCardReader = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasNFCCardReader);
			return cb_hasNFCCardReader;
		}

		static bool n_HasNFCCardReader (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasNFCCardReader;
		}
#pragma warning restore 0169

		static IntPtr id_hasNFCCardReader;
		public virtual unsafe bool HasNFCCardReader {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='hasNFCCardReader' and count(parameter)=0]"
			[Register ("hasNFCCardReader", "()Z", "GetHasNFCCardReaderHandler")]
			get {
				if (id_hasNFCCardReader == IntPtr.Zero)
					id_hasNFCCardReader = JNIEnv.GetMethodID (class_ref, "hasNFCCardReader", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasNFCCardReader);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasNFCCardReader", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_hasUSBCamera;
#pragma warning disable 0169
		static Delegate GetHasUSBCameraHandler ()
		{
			if (cb_hasUSBCamera == null)
				cb_hasUSBCamera = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasUSBCamera);
			return cb_hasUSBCamera;
		}

		static bool n_HasUSBCamera (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasUSBCamera;
		}
#pragma warning restore 0169

		static IntPtr id_hasUSBCamera;
		public virtual unsafe bool HasUSBCamera {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='hasUSBCamera' and count(parameter)=0]"
			[Register ("hasUSBCamera", "()Z", "GetHasUSBCameraHandler")]
			get {
				if (id_hasUSBCamera == IntPtr.Zero)
					id_hasUSBCamera = JNIEnv.GetMethodID (class_ref, "hasUSBCamera", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasUSBCamera);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasUSBCamera", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_hasUSBFileAccessEnabling;
#pragma warning disable 0169
		static Delegate GetHasUSBFileAccessEnablingHandler ()
		{
			if (cb_hasUSBFileAccessEnabling == null)
				cb_hasUSBFileAccessEnabling = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasUSBFileAccessEnabling);
			return cb_hasUSBFileAccessEnabling;
		}

		static bool n_HasUSBFileAccessEnabling (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasUSBFileAccessEnabling;
		}
#pragma warning restore 0169

		static IntPtr id_hasUSBFileAccessEnabling;
		public virtual unsafe bool HasUSBFileAccessEnabling {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='hasUSBFileAccessEnabling' and count(parameter)=0]"
			[Register ("hasUSBFileAccessEnabling", "()Z", "GetHasUSBFileAccessEnablingHandler")]
			get {
				if (id_hasUSBFileAccessEnabling == IntPtr.Zero)
					id_hasUSBFileAccessEnabling = JNIEnv.GetMethodID (class_ref, "hasUSBFileAccessEnabling", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasUSBFileAccessEnabling);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasUSBFileAccessEnabling", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getProductName;
#pragma warning disable 0169
		static Delegate GetGetProductNameHandler ()
		{
			if (cb_getProductName == null)
				cb_getProductName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetProductName);
			return cb_getProductName;
		}

		static IntPtr n_GetProductName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ProductName);
		}
#pragma warning restore 0169

		static IntPtr id_getProductName;
		public virtual unsafe string ProductName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='getProductName' and count(parameter)=0]"
			[Register ("getProductName", "()Ljava/lang/String;", "GetGetProductNameHandler")]
			get {
				if (id_getProductName == IntPtr.Zero)
					id_getProductName = JNIEnv.GetMethodID (class_ref, "getProductName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProductName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getProductName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSDKJarVersion;
#pragma warning disable 0169
		static Delegate GetGetSDKJarVersionHandler ()
		{
			if (cb_getSDKJarVersion == null)
				cb_getSDKJarVersion = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSDKJarVersion);
			return cb_getSDKJarVersion;
		}

		static IntPtr n_GetSDKJarVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SDKJarVersion);
		}
#pragma warning restore 0169

		static IntPtr id_getSDKJarVersion;
		public virtual unsafe string SDKJarVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='getSDKJarVersion' and count(parameter)=0]"
			[Register ("getSDKJarVersion", "()Ljava/lang/String;", "GetGetSDKJarVersionHandler")]
			get {
				if (id_getSDKJarVersion == IntPtr.Zero)
					id_getSDKJarVersion = JNIEnv.GetMethodID (class_ref, "getSDKJarVersion", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSDKJarVersion), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSDKJarVersion", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getServiceVersion;
#pragma warning disable 0169
		static Delegate GetGetServiceVersionHandler ()
		{
			if (cb_getServiceVersion == null)
				cb_getServiceVersion = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetServiceVersion);
			return cb_getServiceVersion;
		}

		static IntPtr n_GetServiceVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ServiceVersion);
		}
#pragma warning restore 0169

		static IntPtr id_getServiceVersion;
		public virtual unsafe string ServiceVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='getServiceVersion' and count(parameter)=0]"
			[Register ("getServiceVersion", "()Ljava/lang/String;", "GetGetServiceVersionHandler")]
			get {
				if (id_getServiceVersion == IntPtr.Zero)
					id_getServiceVersion = JNIEnv.GetMethodID (class_ref, "getServiceVersion", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getServiceVersion), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getServiceVersion", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_analyzeFace_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnAnalyzeFaceImageListener_;
#pragma warning disable 0169
		static Delegate GetAnalyzeFace_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnAnalyzeFaceImageListener_Handler ()
		{
			if (cb_analyzeFace_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnAnalyzeFaceImageListener_ == null)
				cb_analyzeFace_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnAnalyzeFaceImageListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_AnalyzeFace_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnAnalyzeFaceImageListener_);
			return cb_analyzeFace_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnAnalyzeFaceImageListener_;
		}

		static void n_AnalyzeFace_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnAnalyzeFaceImageListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_image, IntPtr native_onAnalyzeFaceImageListener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var image = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_image, JniHandleOwnership.DoNotTransfer);
			var onAnalyzeFaceImageListener = (global::Com.Credenceid.Face.IFaceEngineOnAnalyzeFaceImageListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.IFaceEngineOnAnalyzeFaceImageListener> (native_onAnalyzeFaceImageListener, JniHandleOwnership.DoNotTransfer);
			__this.AnalyzeFace (image, onAnalyzeFaceImageListener);
		}
#pragma warning restore 0169

		static IntPtr id_analyzeFace_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnAnalyzeFaceImageListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='analyzeFace' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='com.credenceid.face.FaceEngine.OnAnalyzeFaceImageListener']]"
		[Register ("analyzeFace", "(Landroid/graphics/Bitmap;Lcom/credenceid/face/FaceEngine$OnAnalyzeFaceImageListener;)V", "GetAnalyzeFace_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnAnalyzeFaceImageListener_Handler")]
		public virtual unsafe void AnalyzeFace (global::Android.Graphics.Bitmap image, global::Com.Credenceid.Face.IFaceEngineOnAnalyzeFaceImageListener onAnalyzeFaceImageListener)
		{
			if (id_analyzeFace_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnAnalyzeFaceImageListener_ == IntPtr.Zero)
				id_analyzeFace_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnAnalyzeFaceImageListener_ = JNIEnv.GetMethodID (class_ref, "analyzeFace", "(Landroid/graphics/Bitmap;Lcom/credenceid/face/FaceEngine$OnAnalyzeFaceImageListener;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (image);
				__args [1] = new JValue (onAnalyzeFaceImageListener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_analyzeFace_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnAnalyzeFaceImageListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "analyzeFace", "(Landroid/graphics/Bitmap;Lcom/credenceid/face/FaceEngine$OnAnalyzeFaceImageListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_analyzeFace_arrayBIILcom_credenceid_face_FaceEngine_OnAnalyzeFaceImageListener_;
#pragma warning disable 0169
		static Delegate GetAnalyzeFace_arrayBIILcom_credenceid_face_FaceEngine_OnAnalyzeFaceImageListener_Handler ()
		{
			if (cb_analyzeFace_arrayBIILcom_credenceid_face_FaceEngine_OnAnalyzeFaceImageListener_ == null)
				cb_analyzeFace_arrayBIILcom_credenceid_face_FaceEngine_OnAnalyzeFaceImageListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIL_V) n_AnalyzeFace_arrayBIILcom_credenceid_face_FaceEngine_OnAnalyzeFaceImageListener_);
			return cb_analyzeFace_arrayBIILcom_credenceid_face_FaceEngine_OnAnalyzeFaceImageListener_;
		}

		static void n_AnalyzeFace_arrayBIILcom_credenceid_face_FaceEngine_OnAnalyzeFaceImageListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_imageBytes, int imageWidth, int imageHeight, IntPtr native_onAnalyzeFaceImageListener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var imageBytes = (byte[]) JNIEnv.GetArray (native_imageBytes, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var onAnalyzeFaceImageListener = (global::Com.Credenceid.Face.IFaceEngineOnAnalyzeFaceImageListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.IFaceEngineOnAnalyzeFaceImageListener> (native_onAnalyzeFaceImageListener, JniHandleOwnership.DoNotTransfer);
			__this.AnalyzeFace (imageBytes, imageWidth, imageHeight, onAnalyzeFaceImageListener);
			if (imageBytes != null)
				JNIEnv.CopyArray (imageBytes, native_imageBytes);
		}
#pragma warning restore 0169

		static IntPtr id_analyzeFace_arrayBIILcom_credenceid_face_FaceEngine_OnAnalyzeFaceImageListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='analyzeFace' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='com.credenceid.face.FaceEngine.OnAnalyzeFaceImageListener']]"
		[Register ("analyzeFace", "([BIILcom/credenceid/face/FaceEngine$OnAnalyzeFaceImageListener;)V", "GetAnalyzeFace_arrayBIILcom_credenceid_face_FaceEngine_OnAnalyzeFaceImageListener_Handler")]
		public virtual unsafe void AnalyzeFace (byte[] imageBytes, int imageWidth, int imageHeight, global::Com.Credenceid.Face.IFaceEngineOnAnalyzeFaceImageListener onAnalyzeFaceImageListener)
		{
			if (id_analyzeFace_arrayBIILcom_credenceid_face_FaceEngine_OnAnalyzeFaceImageListener_ == IntPtr.Zero)
				id_analyzeFace_arrayBIILcom_credenceid_face_FaceEngine_OnAnalyzeFaceImageListener_ = JNIEnv.GetMethodID (class_ref, "analyzeFace", "([BIILcom/credenceid/face/FaceEngine$OnAnalyzeFaceImageListener;)V");
			IntPtr native_imageBytes = JNIEnv.NewArray (imageBytes);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_imageBytes);
				__args [1] = new JValue (imageWidth);
				__args [2] = new JValue (imageHeight);
				__args [3] = new JValue (onAnalyzeFaceImageListener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_analyzeFace_arrayBIILcom_credenceid_face_FaceEngine_OnAnalyzeFaceImageListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "analyzeFace", "([BIILcom/credenceid/face/FaceEngine$OnAnalyzeFaceImageListener;)V"), __args);
			} finally {
				if (imageBytes != null) {
					JNIEnv.CopyArray (native_imageBytes, imageBytes);
					JNIEnv.DeleteLocalRef (native_imageBytes);
				}
			}
		}

		static Delegate cb_analyzeFaceSync_Landroid_graphics_Bitmap_I;
#pragma warning disable 0169
		static Delegate GetAnalyzeFaceSync_Landroid_graphics_Bitmap_IHandler ()
		{
			if (cb_analyzeFaceSync_Landroid_graphics_Bitmap_I == null)
				cb_analyzeFaceSync_Landroid_graphics_Bitmap_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_L) n_AnalyzeFaceSync_Landroid_graphics_Bitmap_I);
			return cb_analyzeFaceSync_Landroid_graphics_Bitmap_I;
		}

		static IntPtr n_AnalyzeFaceSync_Landroid_graphics_Bitmap_I (IntPtr jnienv, IntPtr native__this, IntPtr native_image, int timeout)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var image = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_image, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AnalyzeFaceSync (image, timeout));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_analyzeFaceSync_Landroid_graphics_Bitmap_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='analyzeFaceSync' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='int']]"
		[Register ("analyzeFaceSync", "(Landroid/graphics/Bitmap;I)Lcom/credenceid/face/AnalyzeFaceSyncResponse;", "GetAnalyzeFaceSync_Landroid_graphics_Bitmap_IHandler")]
		public virtual unsafe global::Com.Credenceid.Face.AnalyzeFaceSyncResponse AnalyzeFaceSync (global::Android.Graphics.Bitmap image, int timeout)
		{
			if (id_analyzeFaceSync_Landroid_graphics_Bitmap_I == IntPtr.Zero)
				id_analyzeFaceSync_Landroid_graphics_Bitmap_I = JNIEnv.GetMethodID (class_ref, "analyzeFaceSync", "(Landroid/graphics/Bitmap;I)Lcom/credenceid/face/AnalyzeFaceSyncResponse;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (image);
				__args [1] = new JValue (timeout);

				global::Com.Credenceid.Face.AnalyzeFaceSyncResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.AnalyzeFaceSyncResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_analyzeFaceSync_Landroid_graphics_Bitmap_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.AnalyzeFaceSyncResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "analyzeFaceSync", "(Landroid/graphics/Bitmap;I)Lcom/credenceid/face/AnalyzeFaceSyncResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_analyzeFaceSync_arrayBIII;
#pragma warning disable 0169
		static Delegate GetAnalyzeFaceSync_arrayBIIIHandler ()
		{
			if (cb_analyzeFaceSync_arrayBIII == null)
				cb_analyzeFaceSync_arrayBIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIII_L) n_AnalyzeFaceSync_arrayBIII);
			return cb_analyzeFaceSync_arrayBIII;
		}

		static IntPtr n_AnalyzeFaceSync_arrayBIII (IntPtr jnienv, IntPtr native__this, IntPtr native_imageBytes, int imageWidth, int imageHeight, int timeout)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var imageBytes = (byte[]) JNIEnv.GetArray (native_imageBytes, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AnalyzeFaceSync (imageBytes, imageWidth, imageHeight, timeout));
			if (imageBytes != null)
				JNIEnv.CopyArray (imageBytes, native_imageBytes);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_analyzeFaceSync_arrayBIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='analyzeFaceSync' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("analyzeFaceSync", "([BIII)Lcom/credenceid/face/AnalyzeFaceSyncResponse;", "GetAnalyzeFaceSync_arrayBIIIHandler")]
		public virtual unsafe global::Com.Credenceid.Face.AnalyzeFaceSyncResponse AnalyzeFaceSync (byte[] imageBytes, int imageWidth, int imageHeight, int timeout)
		{
			if (id_analyzeFaceSync_arrayBIII == IntPtr.Zero)
				id_analyzeFaceSync_arrayBIII = JNIEnv.GetMethodID (class_ref, "analyzeFaceSync", "([BIII)Lcom/credenceid/face/AnalyzeFaceSyncResponse;");
			IntPtr native_imageBytes = JNIEnv.NewArray (imageBytes);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_imageBytes);
				__args [1] = new JValue (imageWidth);
				__args [2] = new JValue (imageHeight);
				__args [3] = new JValue (timeout);

				global::Com.Credenceid.Face.AnalyzeFaceSyncResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.AnalyzeFaceSyncResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_analyzeFaceSync_arrayBIII, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.AnalyzeFaceSyncResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "analyzeFaceSync", "([BIII)Lcom/credenceid/face/AnalyzeFaceSyncResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (imageBytes != null) {
					JNIEnv.CopyArray (native_imageBytes, imageBytes);
					JNIEnv.DeleteLocalRef (native_imageBytes);
				}
			}
		}

		static Delegate cb_biometricsInitialized;
#pragma warning disable 0169
		static Delegate GetBiometricsInitializedHandler ()
		{
			if (cb_biometricsInitialized == null)
				cb_biometricsInitialized = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_BiometricsInitialized);
			return cb_biometricsInitialized;
		}

		static bool n_BiometricsInitialized (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BiometricsInitialized ();
		}
#pragma warning restore 0169

		static IntPtr id_biometricsInitialized;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='biometricsInitialized' and count(parameter)=0]"
		[Register ("biometricsInitialized", "()Z", "GetBiometricsInitializedHandler")]
		public virtual unsafe bool BiometricsInitialized ()
		{
			if (id_biometricsInitialized == IntPtr.Zero)
				id_biometricsInitialized = JNIEnv.GetMethodID (class_ref, "biometricsInitialized", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_biometricsInitialized);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "biometricsInitialized", "()Z"));
			} finally {
			}
		}

		static Delegate cb_cameraTorchEnable_Z;
#pragma warning disable 0169
		static Delegate GetCameraTorchEnable_ZHandler ()
		{
			if (cb_cameraTorchEnable_Z == null)
				cb_cameraTorchEnable_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_Z) n_CameraTorchEnable_Z);
			return cb_cameraTorchEnable_Z;
		}

		static bool n_CameraTorchEnable_Z (IntPtr jnienv, IntPtr native__this, bool flash_state)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CameraTorchEnable (flash_state);
		}
#pragma warning restore 0169

		static IntPtr id_cameraTorchEnable_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='cameraTorchEnable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("cameraTorchEnable", "(Z)Z", "GetCameraTorchEnable_ZHandler")]
		public virtual unsafe bool CameraTorchEnable (bool flash_state)
		{
			if (id_cameraTorchEnable_Z == IntPtr.Zero)
				id_cameraTorchEnable_Z = JNIEnv.GetMethodID (class_ref, "cameraTorchEnable", "(Z)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (flash_state);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_cameraTorchEnable_Z, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cameraTorchEnable", "(Z)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_cancelCapture;
#pragma warning disable 0169
		static Delegate GetCancelCaptureHandler ()
		{
			if (cb_cancelCapture == null)
				cb_cancelCapture = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_CancelCapture);
			return cb_cancelCapture;
		}

		static void n_CancelCapture (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CancelCapture ();
		}
#pragma warning restore 0169

		static IntPtr id_cancelCapture;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='cancelCapture' and count(parameter)=0]"
		[Register ("cancelCapture", "()V", "GetCancelCaptureHandler")]
		public virtual unsafe void CancelCapture ()
		{
			if (id_cancelCapture == IntPtr.Zero)
				id_cancelCapture = JNIEnv.GetMethodID (class_ref, "cancelCapture", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancelCapture);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cancelCapture", "()V"));
			} finally {
			}
		}

		static Delegate cb_captureIrises_Lcom_credenceid_biometrics_Biometrics_EyeSelection_Lcom_credenceid_biometrics_Biometrics_OnIrisesCapturedListener_;
#pragma warning disable 0169
		static Delegate GetCaptureIrises_Lcom_credenceid_biometrics_Biometrics_EyeSelection_Lcom_credenceid_biometrics_Biometrics_OnIrisesCapturedListener_Handler ()
		{
			if (cb_captureIrises_Lcom_credenceid_biometrics_Biometrics_EyeSelection_Lcom_credenceid_biometrics_Biometrics_OnIrisesCapturedListener_ == null)
				cb_captureIrises_Lcom_credenceid_biometrics_Biometrics_EyeSelection_Lcom_credenceid_biometrics_Biometrics_OnIrisesCapturedListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_CaptureIrises_Lcom_credenceid_biometrics_Biometrics_EyeSelection_Lcom_credenceid_biometrics_Biometrics_OnIrisesCapturedListener_);
			return cb_captureIrises_Lcom_credenceid_biometrics_Biometrics_EyeSelection_Lcom_credenceid_biometrics_Biometrics_OnIrisesCapturedListener_;
		}

		static void n_CaptureIrises_Lcom_credenceid_biometrics_Biometrics_EyeSelection_Lcom_credenceid_biometrics_Biometrics_OnIrisesCapturedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_eyeSelection, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var eyeSelection = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsEyeSelection> (native_eyeSelection, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Credenceid.Biometrics.IBiometricsOnIrisesCapturedListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnIrisesCapturedListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.CaptureIrises (eyeSelection, listener);
		}
#pragma warning restore 0169

		static IntPtr id_captureIrises_Lcom_credenceid_biometrics_Biometrics_EyeSelection_Lcom_credenceid_biometrics_Biometrics_OnIrisesCapturedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='captureIrises' and count(parameter)=2 and parameter[1][@type='com.credenceid.biometrics.Biometrics.EyeSelection'] and parameter[2][@type='com.credenceid.biometrics.Biometrics.OnIrisesCapturedListener']]"
		[Register ("captureIrises", "(Lcom/credenceid/biometrics/Biometrics$EyeSelection;Lcom/credenceid/biometrics/Biometrics$OnIrisesCapturedListener;)V", "GetCaptureIrises_Lcom_credenceid_biometrics_Biometrics_EyeSelection_Lcom_credenceid_biometrics_Biometrics_OnIrisesCapturedListener_Handler")]
		public virtual unsafe void CaptureIrises (global::Com.Credenceid.Biometrics.BiometricsEyeSelection eyeSelection, global::Com.Credenceid.Biometrics.IBiometricsOnIrisesCapturedListener listener)
		{
			if (id_captureIrises_Lcom_credenceid_biometrics_Biometrics_EyeSelection_Lcom_credenceid_biometrics_Biometrics_OnIrisesCapturedListener_ == IntPtr.Zero)
				id_captureIrises_Lcom_credenceid_biometrics_Biometrics_EyeSelection_Lcom_credenceid_biometrics_Biometrics_OnIrisesCapturedListener_ = JNIEnv.GetMethodID (class_ref, "captureIrises", "(Lcom/credenceid/biometrics/Biometrics$EyeSelection;Lcom/credenceid/biometrics/Biometrics$OnIrisesCapturedListener;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (eyeSelection);
				__args [1] = new JValue (listener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_captureIrises_Lcom_credenceid_biometrics_Biometrics_EyeSelection_Lcom_credenceid_biometrics_Biometrics_OnIrisesCapturedListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "captureIrises", "(Lcom/credenceid/biometrics/Biometrics$EyeSelection;Lcom/credenceid/biometrics/Biometrics$OnIrisesCapturedListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_cardCloseCommand;
#pragma warning disable 0169
		static Delegate GetCardCloseCommandHandler ()
		{
			if (cb_cardCloseCommand == null)
				cb_cardCloseCommand = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_CardCloseCommand);
			return cb_cardCloseCommand;
		}

		static void n_CardCloseCommand (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CardCloseCommand ();
		}
#pragma warning restore 0169

		static IntPtr id_cardCloseCommand;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='cardCloseCommand' and count(parameter)=0]"
		[Register ("cardCloseCommand", "()V", "GetCardCloseCommandHandler")]
		public virtual unsafe void CardCloseCommand ()
		{
			if (id_cardCloseCommand == IntPtr.Zero)
				id_cardCloseCommand = JNIEnv.GetMethodID (class_ref, "cardCloseCommand", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cardCloseCommand);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cardCloseCommand", "()V"));
			} finally {
			}
		}

		static Delegate cb_cardCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnCardCommandListener_;
#pragma warning disable 0169
		static Delegate GetCardCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnCardCommandListener_Handler ()
		{
			if (cb_cardCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnCardCommandListener_ == null)
				cb_cardCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnCardCommandListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZL_V) n_CardCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnCardCommandListener_);
			return cb_cardCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnCardCommandListener_;
		}

		static void n_CardCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnCardCommandListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_APDUCommand, bool protocolT0T1, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var APDUCommand = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.ApduCommand> (native_APDUCommand, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Credenceid.Biometrics.IBiometricsOnCardCommandListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnCardCommandListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.CardCommand (APDUCommand, protocolT0T1, listener);
		}
#pragma warning restore 0169

		static IntPtr id_cardCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnCardCommandListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='cardCommand' and count(parameter)=3 and parameter[1][@type='com.credenceid.biometrics.ApduCommand'] and parameter[2][@type='boolean'] and parameter[3][@type='com.credenceid.biometrics.Biometrics.OnCardCommandListener']]"
		[Register ("cardCommand", "(Lcom/credenceid/biometrics/ApduCommand;ZLcom/credenceid/biometrics/Biometrics$OnCardCommandListener;)V", "GetCardCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnCardCommandListener_Handler")]
		public virtual unsafe void CardCommand (global::Com.Credenceid.Biometrics.ApduCommand APDUCommand, bool protocolT0T1, global::Com.Credenceid.Biometrics.IBiometricsOnCardCommandListener listener)
		{
			if (id_cardCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnCardCommandListener_ == IntPtr.Zero)
				id_cardCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnCardCommandListener_ = JNIEnv.GetMethodID (class_ref, "cardCommand", "(Lcom/credenceid/biometrics/ApduCommand;ZLcom/credenceid/biometrics/Biometrics$OnCardCommandListener;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (APDUCommand);
				__args [1] = new JValue (protocolT0T1);
				__args [2] = new JValue (listener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cardCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnCardCommandListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cardCommand", "(Lcom/credenceid/biometrics/ApduCommand;ZLcom/credenceid/biometrics/Biometrics$OnCardCommandListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_cardCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnCardCommandSyncResultListener_;
#pragma warning disable 0169
		static Delegate GetCardCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnCardCommandSyncResultListener_Handler ()
		{
			if (cb_cardCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnCardCommandSyncResultListener_ == null)
				cb_cardCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnCardCommandSyncResultListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZL_V) n_CardCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnCardCommandSyncResultListener_);
			return cb_cardCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnCardCommandSyncResultListener_;
		}

		static void n_CardCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnCardCommandSyncResultListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_APDUCommand, bool protocolT0T1, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var APDUCommand = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.ApduCommand> (native_APDUCommand, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Credenceid.Biometrics.IBiometricsOnCardCommandSyncResultListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnCardCommandSyncResultListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.CardCommand (APDUCommand, protocolT0T1, listener);
		}
#pragma warning restore 0169

		static IntPtr id_cardCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnCardCommandSyncResultListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='cardCommand' and count(parameter)=3 and parameter[1][@type='com.credenceid.biometrics.ApduCommand'] and parameter[2][@type='boolean'] and parameter[3][@type='com.credenceid.biometrics.Biometrics.OnCardCommandSyncResultListener']]"
		[Register ("cardCommand", "(Lcom/credenceid/biometrics/ApduCommand;ZLcom/credenceid/biometrics/Biometrics$OnCardCommandSyncResultListener;)V", "GetCardCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnCardCommandSyncResultListener_Handler")]
		public virtual unsafe void CardCommand (global::Com.Credenceid.Biometrics.ApduCommand APDUCommand, bool protocolT0T1, global::Com.Credenceid.Biometrics.IBiometricsOnCardCommandSyncResultListener listener)
		{
			if (id_cardCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnCardCommandSyncResultListener_ == IntPtr.Zero)
				id_cardCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnCardCommandSyncResultListener_ = JNIEnv.GetMethodID (class_ref, "cardCommand", "(Lcom/credenceid/biometrics/ApduCommand;ZLcom/credenceid/biometrics/Biometrics$OnCardCommandSyncResultListener;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (APDUCommand);
				__args [1] = new JValue (protocolT0T1);
				__args [2] = new JValue (listener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cardCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnCardCommandSyncResultListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cardCommand", "(Lcom/credenceid/biometrics/ApduCommand;ZLcom/credenceid/biometrics/Biometrics$OnCardCommandSyncResultListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_cardCommandSync_Lcom_credenceid_biometrics_ApduCommand_ZI;
#pragma warning disable 0169
		static Delegate GetCardCommandSync_Lcom_credenceid_biometrics_ApduCommand_ZIHandler ()
		{
			if (cb_cardCommandSync_Lcom_credenceid_biometrics_ApduCommand_ZI == null)
				cb_cardCommandSync_Lcom_credenceid_biometrics_ApduCommand_ZI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZI_L) n_CardCommandSync_Lcom_credenceid_biometrics_ApduCommand_ZI);
			return cb_cardCommandSync_Lcom_credenceid_biometrics_ApduCommand_ZI;
		}

		static IntPtr n_CardCommandSync_Lcom_credenceid_biometrics_ApduCommand_ZI (IntPtr jnienv, IntPtr native__this, IntPtr native_APDUCommand, bool protocolT0T1, int timeOut)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var APDUCommand = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.ApduCommand> (native_APDUCommand, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CardCommandSync (APDUCommand, protocolT0T1, timeOut));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_cardCommandSync_Lcom_credenceid_biometrics_ApduCommand_ZI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='cardCommandSync' and count(parameter)=3 and parameter[1][@type='com.credenceid.biometrics.ApduCommand'] and parameter[2][@type='boolean'] and parameter[3][@type='int']]"
		[Register ("cardCommandSync", "(Lcom/credenceid/biometrics/ApduCommand;ZI)Lcom/credenceid/biometrics/CardCommandResponse;", "GetCardCommandSync_Lcom_credenceid_biometrics_ApduCommand_ZIHandler")]
		public virtual unsafe global::Com.Credenceid.Biometrics.CardCommandResponse CardCommandSync (global::Com.Credenceid.Biometrics.ApduCommand APDUCommand, bool protocolT0T1, int timeOut)
		{
			if (id_cardCommandSync_Lcom_credenceid_biometrics_ApduCommand_ZI == IntPtr.Zero)
				id_cardCommandSync_Lcom_credenceid_biometrics_ApduCommand_ZI = JNIEnv.GetMethodID (class_ref, "cardCommandSync", "(Lcom/credenceid/biometrics/ApduCommand;ZI)Lcom/credenceid/biometrics/CardCommandResponse;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (APDUCommand);
				__args [1] = new JValue (protocolT0T1);
				__args [2] = new JValue (timeOut);

				global::Com.Credenceid.Biometrics.CardCommandResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.CardCommandResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_cardCommandSync_Lcom_credenceid_biometrics_ApduCommand_ZI, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.CardCommandResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cardCommandSync", "(Lcom/credenceid/biometrics/ApduCommand;ZI)Lcom/credenceid/biometrics/CardCommandResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_cardConnectSync_I;
#pragma warning disable 0169
		static Delegate GetCardConnectSync_IHandler ()
		{
			if (cb_cardConnectSync_I == null)
				cb_cardConnectSync_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_CardConnectSync_I);
			return cb_cardConnectSync_I;
		}

		static bool n_CardConnectSync_I (IntPtr jnienv, IntPtr native__this, int timeout)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CardConnectSync (timeout);
		}
#pragma warning restore 0169

		static IntPtr id_cardConnectSync_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='cardConnectSync' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("cardConnectSync", "(I)Z", "GetCardConnectSync_IHandler")]
		public virtual unsafe bool CardConnectSync (int timeout)
		{
			if (id_cardConnectSync_I == IntPtr.Zero)
				id_cardConnectSync_I = JNIEnv.GetMethodID (class_ref, "cardConnectSync", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (timeout);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_cardConnectSync_I, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cardConnectSync", "(I)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_cardDisconnectSync_I;
#pragma warning disable 0169
		static Delegate GetCardDisconnectSync_IHandler ()
		{
			if (cb_cardDisconnectSync_I == null)
				cb_cardDisconnectSync_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_CardDisconnectSync_I);
			return cb_cardDisconnectSync_I;
		}

		static bool n_CardDisconnectSync_I (IntPtr jnienv, IntPtr native__this, int timeout)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CardDisconnectSync (timeout);
		}
#pragma warning restore 0169

		static IntPtr id_cardDisconnectSync_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='cardDisconnectSync' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("cardDisconnectSync", "(I)Z", "GetCardDisconnectSync_IHandler")]
		public virtual unsafe bool CardDisconnectSync (int timeout)
		{
			if (id_cardDisconnectSync_I == IntPtr.Zero)
				id_cardDisconnectSync_I = JNIEnv.GetMethodID (class_ref, "cardDisconnectSync", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (timeout);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_cardDisconnectSync_I, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cardDisconnectSync", "(I)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_cardOpenCommand_Lcom_credenceid_biometrics_Biometrics_CardReaderStatusListener_;
#pragma warning disable 0169
		static Delegate GetCardOpenCommand_Lcom_credenceid_biometrics_Biometrics_CardReaderStatusListener_Handler ()
		{
			if (cb_cardOpenCommand_Lcom_credenceid_biometrics_Biometrics_CardReaderStatusListener_ == null)
				cb_cardOpenCommand_Lcom_credenceid_biometrics_Biometrics_CardReaderStatusListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_CardOpenCommand_Lcom_credenceid_biometrics_Biometrics_CardReaderStatusListener_);
			return cb_cardOpenCommand_Lcom_credenceid_biometrics_Biometrics_CardReaderStatusListener_;
		}

		static void n_CardOpenCommand_Lcom_credenceid_biometrics_Biometrics_CardReaderStatusListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cardReaderStatusListener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var cardReaderStatusListener = (global::Com.Credenceid.Biometrics.IBiometricsCardReaderStatusListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsCardReaderStatusListener> (native_cardReaderStatusListener, JniHandleOwnership.DoNotTransfer);
			__this.CardOpenCommand (cardReaderStatusListener);
		}
#pragma warning restore 0169

		static IntPtr id_cardOpenCommand_Lcom_credenceid_biometrics_Biometrics_CardReaderStatusListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='cardOpenCommand' and count(parameter)=1 and parameter[1][@type='com.credenceid.biometrics.Biometrics.CardReaderStatusListener']]"
		[Register ("cardOpenCommand", "(Lcom/credenceid/biometrics/Biometrics$CardReaderStatusListener;)V", "GetCardOpenCommand_Lcom_credenceid_biometrics_Biometrics_CardReaderStatusListener_Handler")]
		public virtual unsafe void CardOpenCommand (global::Com.Credenceid.Biometrics.IBiometricsCardReaderStatusListener cardReaderStatusListener)
		{
			if (id_cardOpenCommand_Lcom_credenceid_biometrics_Biometrics_CardReaderStatusListener_ == IntPtr.Zero)
				id_cardOpenCommand_Lcom_credenceid_biometrics_Biometrics_CardReaderStatusListener_ = JNIEnv.GetMethodID (class_ref, "cardOpenCommand", "(Lcom/credenceid/biometrics/Biometrics$CardReaderStatusListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (cardReaderStatusListener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cardOpenCommand_Lcom_credenceid_biometrics_Biometrics_CardReaderStatusListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cardOpenCommand", "(Lcom/credenceid/biometrics/Biometrics$CardReaderStatusListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_closeFingerprintReader;
#pragma warning disable 0169
		static Delegate GetCloseFingerprintReaderHandler ()
		{
			if (cb_closeFingerprintReader == null)
				cb_closeFingerprintReader = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_CloseFingerprintReader);
			return cb_closeFingerprintReader;
		}

		static void n_CloseFingerprintReader (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CloseFingerprintReader ();
		}
#pragma warning restore 0169

		static IntPtr id_closeFingerprintReader;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='closeFingerprintReader' and count(parameter)=0]"
		[Register ("closeFingerprintReader", "()V", "GetCloseFingerprintReaderHandler")]
		public virtual unsafe void CloseFingerprintReader ()
		{
			if (id_closeFingerprintReader == IntPtr.Zero)
				id_closeFingerprintReader = JNIEnv.GetMethodID (class_ref, "closeFingerprintReader", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_closeFingerprintReader);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "closeFingerprintReader", "()V"));
			} finally {
			}
		}

		static Delegate cb_closeIrisScanner;
#pragma warning disable 0169
		static Delegate GetCloseIrisScannerHandler ()
		{
			if (cb_closeIrisScanner == null)
				cb_closeIrisScanner = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_CloseIrisScanner);
			return cb_closeIrisScanner;
		}

		static void n_CloseIrisScanner (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CloseIrisScanner ();
		}
#pragma warning restore 0169

		static IntPtr id_closeIrisScanner;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='closeIrisScanner' and count(parameter)=0]"
		[Register ("closeIrisScanner", "()V", "GetCloseIrisScannerHandler")]
		public virtual unsafe void CloseIrisScanner ()
		{
			if (id_closeIrisScanner == IntPtr.Zero)
				id_closeIrisScanner = JNIEnv.GetMethodID (class_ref, "closeIrisScanner", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_closeIrisScanner);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "closeIrisScanner", "()V"));
			} finally {
			}
		}

		static Delegate cb_closeMRZ;
#pragma warning disable 0169
		static Delegate GetCloseMRZHandler ()
		{
			if (cb_closeMRZ == null)
				cb_closeMRZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_CloseMRZ);
			return cb_closeMRZ;
		}

		static void n_CloseMRZ (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CloseMRZ ();
		}
#pragma warning restore 0169

		static IntPtr id_closeMRZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='closeMRZ' and count(parameter)=0]"
		[Register ("closeMRZ", "()V", "GetCloseMRZHandler")]
		public virtual unsafe void CloseMRZ ()
		{
			if (id_closeMRZ == IntPtr.Zero)
				id_closeMRZ = JNIEnv.GetMethodID (class_ref, "closeMRZ", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_closeMRZ);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "closeMRZ", "()V"));
			} finally {
			}
		}

		static Delegate cb_compareFMD_arrayBarrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnCompareFMDListener_;
#pragma warning disable 0169
		static Delegate GetCompareFMD_arrayBarrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnCompareFMDListener_Handler ()
		{
			if (cb_compareFMD_arrayBarrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnCompareFMDListener_ == null)
				cb_compareFMD_arrayBarrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnCompareFMDListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_CompareFMD_arrayBarrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnCompareFMDListener_);
			return cb_compareFMD_arrayBarrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnCompareFMDListener_;
		}

		static void n_CompareFMD_arrayBarrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnCompareFMDListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_FMDOne, IntPtr native_FMDTwo, IntPtr native_format, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var FMDOne = (byte[]) JNIEnv.GetArray (native_FMDOne, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var FMDTwo = (byte[]) JNIEnv.GetArray (native_FMDTwo, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var format = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsFMDFormat> (native_format, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Credenceid.Biometrics.IBiometricsOnCompareFMDListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnCompareFMDListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.CompareFMD (FMDOne, FMDTwo, format, listener);
			if (FMDOne != null)
				JNIEnv.CopyArray (FMDOne, native_FMDOne);
			if (FMDTwo != null)
				JNIEnv.CopyArray (FMDTwo, native_FMDTwo);
		}
#pragma warning restore 0169

		static IntPtr id_compareFMD_arrayBarrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnCompareFMDListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='compareFMD' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='com.credenceid.biometrics.Biometrics.FMDFormat'] and parameter[4][@type='com.credenceid.biometrics.Biometrics.OnCompareFMDListener']]"
		[Register ("compareFMD", "([B[BLcom/credenceid/biometrics/Biometrics$FMDFormat;Lcom/credenceid/biometrics/Biometrics$OnCompareFMDListener;)V", "GetCompareFMD_arrayBarrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnCompareFMDListener_Handler")]
		public virtual unsafe void CompareFMD (byte[] FMDOne, byte[] FMDTwo, global::Com.Credenceid.Biometrics.BiometricsFMDFormat format, global::Com.Credenceid.Biometrics.IBiometricsOnCompareFMDListener listener)
		{
			if (id_compareFMD_arrayBarrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnCompareFMDListener_ == IntPtr.Zero)
				id_compareFMD_arrayBarrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnCompareFMDListener_ = JNIEnv.GetMethodID (class_ref, "compareFMD", "([B[BLcom/credenceid/biometrics/Biometrics$FMDFormat;Lcom/credenceid/biometrics/Biometrics$OnCompareFMDListener;)V");
			IntPtr native_FMDOne = JNIEnv.NewArray (FMDOne);
			IntPtr native_FMDTwo = JNIEnv.NewArray (FMDTwo);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_FMDOne);
				__args [1] = new JValue (native_FMDTwo);
				__args [2] = new JValue (format);
				__args [3] = new JValue (listener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_compareFMD_arrayBarrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnCompareFMDListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compareFMD", "([B[BLcom/credenceid/biometrics/Biometrics$FMDFormat;Lcom/credenceid/biometrics/Biometrics$OnCompareFMDListener;)V"), __args);
			} finally {
				if (FMDOne != null) {
					JNIEnv.CopyArray (native_FMDOne, FMDOne);
					JNIEnv.DeleteLocalRef (native_FMDOne);
				}
				if (FMDTwo != null) {
					JNIEnv.CopyArray (native_FMDTwo, FMDTwo);
					JNIEnv.DeleteLocalRef (native_FMDTwo);
				}
			}
		}

		static Delegate cb_compareFMDSync_arrayBarrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_I;
#pragma warning disable 0169
		static Delegate GetCompareFMDSync_arrayBarrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_IHandler ()
		{
			if (cb_compareFMDSync_arrayBarrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_I == null)
				cb_compareFMDSync_arrayBarrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLI_L) n_CompareFMDSync_arrayBarrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_I);
			return cb_compareFMDSync_arrayBarrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_I;
		}

		static IntPtr n_CompareFMDSync_arrayBarrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_I (IntPtr jnienv, IntPtr native__this, IntPtr native_FMDOne, IntPtr native_FMDTwo, IntPtr native_format, int timeout)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var FMDOne = (byte[]) JNIEnv.GetArray (native_FMDOne, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var FMDTwo = (byte[]) JNIEnv.GetArray (native_FMDTwo, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var format = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsFMDFormat> (native_format, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CompareFMDSync (FMDOne, FMDTwo, format, timeout));
			if (FMDOne != null)
				JNIEnv.CopyArray (FMDOne, native_FMDOne);
			if (FMDTwo != null)
				JNIEnv.CopyArray (FMDTwo, native_FMDTwo);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_compareFMDSync_arrayBarrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='compareFMDSync' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='com.credenceid.biometrics.Biometrics.FMDFormat'] and parameter[4][@type='int']]"
		[Register ("compareFMDSync", "([B[BLcom/credenceid/biometrics/Biometrics$FMDFormat;I)Lcom/credenceid/biometrics/CompareFMDSyncResponse;", "GetCompareFMDSync_arrayBarrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_IHandler")]
		public virtual unsafe global::Com.Credenceid.Biometrics.CompareFMDSyncResponse CompareFMDSync (byte[] FMDOne, byte[] FMDTwo, global::Com.Credenceid.Biometrics.BiometricsFMDFormat format, int timeout)
		{
			if (id_compareFMDSync_arrayBarrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_I == IntPtr.Zero)
				id_compareFMDSync_arrayBarrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_I = JNIEnv.GetMethodID (class_ref, "compareFMDSync", "([B[BLcom/credenceid/biometrics/Biometrics$FMDFormat;I)Lcom/credenceid/biometrics/CompareFMDSyncResponse;");
			IntPtr native_FMDOne = JNIEnv.NewArray (FMDOne);
			IntPtr native_FMDTwo = JNIEnv.NewArray (FMDTwo);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_FMDOne);
				__args [1] = new JValue (native_FMDTwo);
				__args [2] = new JValue (format);
				__args [3] = new JValue (timeout);

				global::Com.Credenceid.Biometrics.CompareFMDSyncResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.CompareFMDSyncResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_compareFMDSync_arrayBarrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.CompareFMDSyncResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compareFMDSync", "([B[BLcom/credenceid/biometrics/Biometrics$FMDFormat;I)Lcom/credenceid/biometrics/CompareFMDSyncResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (FMDOne != null) {
					JNIEnv.CopyArray (native_FMDOne, FMDOne);
					JNIEnv.DeleteLocalRef (native_FMDOne);
				}
				if (FMDTwo != null) {
					JNIEnv.CopyArray (native_FMDTwo, FMDTwo);
					JNIEnv.DeleteLocalRef (native_FMDTwo);
				}
			}
		}

		static Delegate cb_compareFace_arrayBarrayBLcom_credenceid_face_FaceEngine_OnMatchFaceTemplatesListener_;
#pragma warning disable 0169
		static Delegate GetCompareFace_arrayBarrayBLcom_credenceid_face_FaceEngine_OnMatchFaceTemplatesListener_Handler ()
		{
			if (cb_compareFace_arrayBarrayBLcom_credenceid_face_FaceEngine_OnMatchFaceTemplatesListener_ == null)
				cb_compareFace_arrayBarrayBLcom_credenceid_face_FaceEngine_OnMatchFaceTemplatesListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_CompareFace_arrayBarrayBLcom_credenceid_face_FaceEngine_OnMatchFaceTemplatesListener_);
			return cb_compareFace_arrayBarrayBLcom_credenceid_face_FaceEngine_OnMatchFaceTemplatesListener_;
		}

		static void n_CompareFace_arrayBarrayBLcom_credenceid_face_FaceEngine_OnMatchFaceTemplatesListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_templateOne, IntPtr native_templateTwo, IntPtr native_onMatchFaceTemplatesListener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var templateOne = (byte[]) JNIEnv.GetArray (native_templateOne, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var templateTwo = (byte[]) JNIEnv.GetArray (native_templateTwo, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var onMatchFaceTemplatesListener = (global::Com.Credenceid.Face.IFaceEngineOnMatchFaceTemplatesListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.IFaceEngineOnMatchFaceTemplatesListener> (native_onMatchFaceTemplatesListener, JniHandleOwnership.DoNotTransfer);
			__this.CompareFace (templateOne, templateTwo, onMatchFaceTemplatesListener);
			if (templateOne != null)
				JNIEnv.CopyArray (templateOne, native_templateOne);
			if (templateTwo != null)
				JNIEnv.CopyArray (templateTwo, native_templateTwo);
		}
#pragma warning restore 0169

		static IntPtr id_compareFace_arrayBarrayBLcom_credenceid_face_FaceEngine_OnMatchFaceTemplatesListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='compareFace' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='com.credenceid.face.FaceEngine.OnMatchFaceTemplatesListener']]"
		[Register ("compareFace", "([B[BLcom/credenceid/face/FaceEngine$OnMatchFaceTemplatesListener;)V", "GetCompareFace_arrayBarrayBLcom_credenceid_face_FaceEngine_OnMatchFaceTemplatesListener_Handler")]
		public virtual unsafe void CompareFace (byte[] templateOne, byte[] templateTwo, global::Com.Credenceid.Face.IFaceEngineOnMatchFaceTemplatesListener onMatchFaceTemplatesListener)
		{
			if (id_compareFace_arrayBarrayBLcom_credenceid_face_FaceEngine_OnMatchFaceTemplatesListener_ == IntPtr.Zero)
				id_compareFace_arrayBarrayBLcom_credenceid_face_FaceEngine_OnMatchFaceTemplatesListener_ = JNIEnv.GetMethodID (class_ref, "compareFace", "([B[BLcom/credenceid/face/FaceEngine$OnMatchFaceTemplatesListener;)V");
			IntPtr native_templateOne = JNIEnv.NewArray (templateOne);
			IntPtr native_templateTwo = JNIEnv.NewArray (templateTwo);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_templateOne);
				__args [1] = new JValue (native_templateTwo);
				__args [2] = new JValue (onMatchFaceTemplatesListener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_compareFace_arrayBarrayBLcom_credenceid_face_FaceEngine_OnMatchFaceTemplatesListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compareFace", "([B[BLcom/credenceid/face/FaceEngine$OnMatchFaceTemplatesListener;)V"), __args);
			} finally {
				if (templateOne != null) {
					JNIEnv.CopyArray (native_templateOne, templateOne);
					JNIEnv.DeleteLocalRef (native_templateOne);
				}
				if (templateTwo != null) {
					JNIEnv.CopyArray (native_templateTwo, templateTwo);
					JNIEnv.DeleteLocalRef (native_templateTwo);
				}
			}
		}

		static Delegate cb_compareFaceSync_arrayBarrayBI;
#pragma warning disable 0169
		static Delegate GetCompareFaceSync_arrayBarrayBIHandler ()
		{
			if (cb_compareFaceSync_arrayBarrayBI == null)
				cb_compareFaceSync_arrayBarrayBI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLI_L) n_CompareFaceSync_arrayBarrayBI);
			return cb_compareFaceSync_arrayBarrayBI;
		}

		static IntPtr n_CompareFaceSync_arrayBarrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_templateOne, IntPtr native_templateTwo, int timeout)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var templateOne = (byte[]) JNIEnv.GetArray (native_templateOne, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var templateTwo = (byte[]) JNIEnv.GetArray (native_templateTwo, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CompareFaceSync (templateOne, templateTwo, timeout));
			if (templateOne != null)
				JNIEnv.CopyArray (templateOne, native_templateOne);
			if (templateTwo != null)
				JNIEnv.CopyArray (templateTwo, native_templateTwo);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_compareFaceSync_arrayBarrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='compareFaceSync' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
		[Register ("compareFaceSync", "([B[BI)Lcom/credenceid/face/CompareFaceSyncResponse;", "GetCompareFaceSync_arrayBarrayBIHandler")]
		public virtual unsafe global::Com.Credenceid.Face.CompareFaceSyncResponse CompareFaceSync (byte[] templateOne, byte[] templateTwo, int timeout)
		{
			if (id_compareFaceSync_arrayBarrayBI == IntPtr.Zero)
				id_compareFaceSync_arrayBarrayBI = JNIEnv.GetMethodID (class_ref, "compareFaceSync", "([B[BI)Lcom/credenceid/face/CompareFaceSyncResponse;");
			IntPtr native_templateOne = JNIEnv.NewArray (templateOne);
			IntPtr native_templateTwo = JNIEnv.NewArray (templateTwo);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_templateOne);
				__args [1] = new JValue (native_templateTwo);
				__args [2] = new JValue (timeout);

				global::Com.Credenceid.Face.CompareFaceSyncResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.CompareFaceSyncResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_compareFaceSync_arrayBarrayBI, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.CompareFaceSyncResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compareFaceSync", "([B[BI)Lcom/credenceid/face/CompareFaceSyncResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (templateOne != null) {
					JNIEnv.CopyArray (native_templateOne, templateOne);
					JNIEnv.DeleteLocalRef (native_templateOne);
				}
				if (templateTwo != null) {
					JNIEnv.CopyArray (native_templateTwo, templateTwo);
					JNIEnv.DeleteLocalRef (native_templateTwo);
				}
			}
		}

		static Delegate cb_compressToWSQ_Ljava_lang_String_FLcom_credenceid_biometrics_Biometrics_OnCompressToWSQListener_;
#pragma warning disable 0169
		static Delegate GetCompressToWSQ_Ljava_lang_String_FLcom_credenceid_biometrics_Biometrics_OnCompressToWSQListener_Handler ()
		{
			if (cb_compressToWSQ_Ljava_lang_String_FLcom_credenceid_biometrics_Biometrics_OnCompressToWSQListener_ == null)
				cb_compressToWSQ_Ljava_lang_String_FLcom_credenceid_biometrics_Biometrics_OnCompressToWSQListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLFL_V) n_CompressToWSQ_Ljava_lang_String_FLcom_credenceid_biometrics_Biometrics_OnCompressToWSQListener_);
			return cb_compressToWSQ_Ljava_lang_String_FLcom_credenceid_biometrics_Biometrics_OnCompressToWSQListener_;
		}

		static void n_CompressToWSQ_Ljava_lang_String_FLcom_credenceid_biometrics_Biometrics_OnCompressToWSQListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_absFilePath, float bitrate, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var absFilePath = JNIEnv.GetString (native_absFilePath, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Credenceid.Biometrics.IBiometricsOnCompressToWSQListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnCompressToWSQListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.CompressToWSQ (absFilePath, bitrate, listener);
		}
#pragma warning restore 0169

		static IntPtr id_compressToWSQ_Ljava_lang_String_FLcom_credenceid_biometrics_Biometrics_OnCompressToWSQListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='compressToWSQ' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='float'] and parameter[3][@type='com.credenceid.biometrics.Biometrics.OnCompressToWSQListener']]"
		[Register ("compressToWSQ", "(Ljava/lang/String;FLcom/credenceid/biometrics/Biometrics$OnCompressToWSQListener;)V", "GetCompressToWSQ_Ljava_lang_String_FLcom_credenceid_biometrics_Biometrics_OnCompressToWSQListener_Handler")]
		public virtual unsafe void CompressToWSQ (string absFilePath, float bitrate, global::Com.Credenceid.Biometrics.IBiometricsOnCompressToWSQListener listener)
		{
			if (id_compressToWSQ_Ljava_lang_String_FLcom_credenceid_biometrics_Biometrics_OnCompressToWSQListener_ == IntPtr.Zero)
				id_compressToWSQ_Ljava_lang_String_FLcom_credenceid_biometrics_Biometrics_OnCompressToWSQListener_ = JNIEnv.GetMethodID (class_ref, "compressToWSQ", "(Ljava/lang/String;FLcom/credenceid/biometrics/Biometrics$OnCompressToWSQListener;)V");
			IntPtr native_absFilePath = JNIEnv.NewString (absFilePath);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_absFilePath);
				__args [1] = new JValue (bitrate);
				__args [2] = new JValue (listener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_compressToWSQ_Ljava_lang_String_FLcom_credenceid_biometrics_Biometrics_OnCompressToWSQListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compressToWSQ", "(Ljava/lang/String;FLcom/credenceid/biometrics/Biometrics$OnCompressToWSQListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_absFilePath);
			}
		}

		static Delegate cb_convertCCFToFMD_arrayBLcom_credenceid_biometrics_Biometrics_OnCCFToFMDConversionListener_;
#pragma warning disable 0169
		static Delegate GetConvertCCFToFMD_arrayBLcom_credenceid_biometrics_Biometrics_OnCCFToFMDConversionListener_Handler ()
		{
			if (cb_convertCCFToFMD_arrayBLcom_credenceid_biometrics_Biometrics_OnCCFToFMDConversionListener_ == null)
				cb_convertCCFToFMD_arrayBLcom_credenceid_biometrics_Biometrics_OnCCFToFMDConversionListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_ConvertCCFToFMD_arrayBLcom_credenceid_biometrics_Biometrics_OnCCFToFMDConversionListener_);
			return cb_convertCCFToFMD_arrayBLcom_credenceid_biometrics_Biometrics_OnCCFToFMDConversionListener_;
		}

		static void n_ConvertCCFToFMD_arrayBLcom_credenceid_biometrics_Biometrics_OnCCFToFMDConversionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_CCFTemplate, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var CCFTemplate = (byte[]) JNIEnv.GetArray (native_CCFTemplate, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var listener = (global::Com.Credenceid.Biometrics.IBiometricsOnCCFToFMDConversionListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnCCFToFMDConversionListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.ConvertCCFToFMD (CCFTemplate, listener);
			if (CCFTemplate != null)
				JNIEnv.CopyArray (CCFTemplate, native_CCFTemplate);
		}
#pragma warning restore 0169

		static IntPtr id_convertCCFToFMD_arrayBLcom_credenceid_biometrics_Biometrics_OnCCFToFMDConversionListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='convertCCFToFMD' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='com.credenceid.biometrics.Biometrics.OnCCFToFMDConversionListener']]"
		[Register ("convertCCFToFMD", "([BLcom/credenceid/biometrics/Biometrics$OnCCFToFMDConversionListener;)V", "GetConvertCCFToFMD_arrayBLcom_credenceid_biometrics_Biometrics_OnCCFToFMDConversionListener_Handler")]
		public virtual unsafe void ConvertCCFToFMD (byte[] CCFTemplate, global::Com.Credenceid.Biometrics.IBiometricsOnCCFToFMDConversionListener listener)
		{
			if (id_convertCCFToFMD_arrayBLcom_credenceid_biometrics_Biometrics_OnCCFToFMDConversionListener_ == IntPtr.Zero)
				id_convertCCFToFMD_arrayBLcom_credenceid_biometrics_Biometrics_OnCCFToFMDConversionListener_ = JNIEnv.GetMethodID (class_ref, "convertCCFToFMD", "([BLcom/credenceid/biometrics/Biometrics$OnCCFToFMDConversionListener;)V");
			IntPtr native_CCFTemplate = JNIEnv.NewArray (CCFTemplate);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_CCFTemplate);
				__args [1] = new JValue (listener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_convertCCFToFMD_arrayBLcom_credenceid_biometrics_Biometrics_OnCCFToFMDConversionListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "convertCCFToFMD", "([BLcom/credenceid/biometrics/Biometrics$OnCCFToFMDConversionListener;)V"), __args);
			} finally {
				if (CCFTemplate != null) {
					JNIEnv.CopyArray (native_CCFTemplate, CCFTemplate);
					JNIEnv.DeleteLocalRef (native_CCFTemplate);
				}
			}
		}

		static Delegate cb_convertCCFToFMD_arrayBSSSSLcom_credenceid_biometrics_Biometrics_OnCCFToFMDConversionListener_;
#pragma warning disable 0169
		static Delegate GetConvertCCFToFMD_arrayBSSSSLcom_credenceid_biometrics_Biometrics_OnCCFToFMDConversionListener_Handler ()
		{
			if (cb_convertCCFToFMD_arrayBSSSSLcom_credenceid_biometrics_Biometrics_OnCCFToFMDConversionListener_ == null)
				cb_convertCCFToFMD_arrayBSSSSLcom_credenceid_biometrics_Biometrics_OnCCFToFMDConversionListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLSSSSL_V) n_ConvertCCFToFMD_arrayBSSSSLcom_credenceid_biometrics_Biometrics_OnCCFToFMDConversionListener_);
			return cb_convertCCFToFMD_arrayBSSSSLcom_credenceid_biometrics_Biometrics_OnCCFToFMDConversionListener_;
		}

		static void n_ConvertCCFToFMD_arrayBSSSSLcom_credenceid_biometrics_Biometrics_OnCCFToFMDConversionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ccfTemplate, short sizeX, short sizeY, short resolutionX, short resolutionY, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var ccfTemplate = (byte[]) JNIEnv.GetArray (native_ccfTemplate, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var listener = (global::Com.Credenceid.Biometrics.IBiometricsOnCCFToFMDConversionListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnCCFToFMDConversionListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.ConvertCCFToFMD (ccfTemplate, sizeX, sizeY, resolutionX, resolutionY, listener);
			if (ccfTemplate != null)
				JNIEnv.CopyArray (ccfTemplate, native_ccfTemplate);
		}
#pragma warning restore 0169

		static IntPtr id_convertCCFToFMD_arrayBSSSSLcom_credenceid_biometrics_Biometrics_OnCCFToFMDConversionListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='convertCCFToFMD' and count(parameter)=6 and parameter[1][@type='byte[]'] and parameter[2][@type='short'] and parameter[3][@type='short'] and parameter[4][@type='short'] and parameter[5][@type='short'] and parameter[6][@type='com.credenceid.biometrics.Biometrics.OnCCFToFMDConversionListener']]"
		[Register ("convertCCFToFMD", "([BSSSSLcom/credenceid/biometrics/Biometrics$OnCCFToFMDConversionListener;)V", "GetConvertCCFToFMD_arrayBSSSSLcom_credenceid_biometrics_Biometrics_OnCCFToFMDConversionListener_Handler")]
		public virtual unsafe void ConvertCCFToFMD (byte[] ccfTemplate, short sizeX, short sizeY, short resolutionX, short resolutionY, global::Com.Credenceid.Biometrics.IBiometricsOnCCFToFMDConversionListener listener)
		{
			if (id_convertCCFToFMD_arrayBSSSSLcom_credenceid_biometrics_Biometrics_OnCCFToFMDConversionListener_ == IntPtr.Zero)
				id_convertCCFToFMD_arrayBSSSSLcom_credenceid_biometrics_Biometrics_OnCCFToFMDConversionListener_ = JNIEnv.GetMethodID (class_ref, "convertCCFToFMD", "([BSSSSLcom/credenceid/biometrics/Biometrics$OnCCFToFMDConversionListener;)V");
			IntPtr native_ccfTemplate = JNIEnv.NewArray (ccfTemplate);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_ccfTemplate);
				__args [1] = new JValue (sizeX);
				__args [2] = new JValue (sizeY);
				__args [3] = new JValue (resolutionX);
				__args [4] = new JValue (resolutionY);
				__args [5] = new JValue (listener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_convertCCFToFMD_arrayBSSSSLcom_credenceid_biometrics_Biometrics_OnCCFToFMDConversionListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "convertCCFToFMD", "([BSSSSLcom/credenceid/biometrics/Biometrics$OnCCFToFMDConversionListener;)V"), __args);
			} finally {
				if (ccfTemplate != null) {
					JNIEnv.CopyArray (native_ccfTemplate, ccfTemplate);
					JNIEnv.DeleteLocalRef (native_ccfTemplate);
				}
			}
		}

		static Delegate cb_convertCCFToFMDSync_arrayBSSSSI;
#pragma warning disable 0169
		static Delegate GetConvertCCFToFMDSync_arrayBSSSSIHandler ()
		{
			if (cb_convertCCFToFMDSync_arrayBSSSSI == null)
				cb_convertCCFToFMDSync_arrayBSSSSI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLSSSSI_L) n_ConvertCCFToFMDSync_arrayBSSSSI);
			return cb_convertCCFToFMDSync_arrayBSSSSI;
		}

		static IntPtr n_ConvertCCFToFMDSync_arrayBSSSSI (IntPtr jnienv, IntPtr native__this, IntPtr native_CCFTemplate, short sizeX, short sizeY, short resolutionX, short resolutionY, int timeout)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var CCFTemplate = (byte[]) JNIEnv.GetArray (native_CCFTemplate, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ConvertCCFToFMDSync (CCFTemplate, sizeX, sizeY, resolutionX, resolutionY, timeout));
			if (CCFTemplate != null)
				JNIEnv.CopyArray (CCFTemplate, native_CCFTemplate);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_convertCCFToFMDSync_arrayBSSSSI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='convertCCFToFMDSync' and count(parameter)=6 and parameter[1][@type='byte[]'] and parameter[2][@type='short'] and parameter[3][@type='short'] and parameter[4][@type='short'] and parameter[5][@type='short'] and parameter[6][@type='int']]"
		[Register ("convertCCFToFMDSync", "([BSSSSI)Lcom/credenceid/biometrics/CCFToFMDSyncResponse;", "GetConvertCCFToFMDSync_arrayBSSSSIHandler")]
		public virtual unsafe global::Com.Credenceid.Biometrics.CCFToFMDSyncResponse ConvertCCFToFMDSync (byte[] CCFTemplate, short sizeX, short sizeY, short resolutionX, short resolutionY, int timeout)
		{
			if (id_convertCCFToFMDSync_arrayBSSSSI == IntPtr.Zero)
				id_convertCCFToFMDSync_arrayBSSSSI = JNIEnv.GetMethodID (class_ref, "convertCCFToFMDSync", "([BSSSSI)Lcom/credenceid/biometrics/CCFToFMDSyncResponse;");
			IntPtr native_CCFTemplate = JNIEnv.NewArray (CCFTemplate);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_CCFTemplate);
				__args [1] = new JValue (sizeX);
				__args [2] = new JValue (sizeY);
				__args [3] = new JValue (resolutionX);
				__args [4] = new JValue (resolutionY);
				__args [5] = new JValue (timeout);

				global::Com.Credenceid.Biometrics.CCFToFMDSyncResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.CCFToFMDSyncResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_convertCCFToFMDSync_arrayBSSSSI, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.CCFToFMDSyncResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "convertCCFToFMDSync", "([BSSSSI)Lcom/credenceid/biometrics/CCFToFMDSyncResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (CCFTemplate != null) {
					JNIEnv.CopyArray (native_CCFTemplate, CCFTemplate);
					JNIEnv.DeleteLocalRef (native_CCFTemplate);
				}
			}
		}

		static Delegate cb_convertFMDToCCF_arrayBLcom_credenceid_biometrics_Biometrics_OnFMDToCCFConversionListener_;
#pragma warning disable 0169
		static Delegate GetConvertFMDToCCF_arrayBLcom_credenceid_biometrics_Biometrics_OnFMDToCCFConversionListener_Handler ()
		{
			if (cb_convertFMDToCCF_arrayBLcom_credenceid_biometrics_Biometrics_OnFMDToCCFConversionListener_ == null)
				cb_convertFMDToCCF_arrayBLcom_credenceid_biometrics_Biometrics_OnFMDToCCFConversionListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_ConvertFMDToCCF_arrayBLcom_credenceid_biometrics_Biometrics_OnFMDToCCFConversionListener_);
			return cb_convertFMDToCCF_arrayBLcom_credenceid_biometrics_Biometrics_OnFMDToCCFConversionListener_;
		}

		static void n_ConvertFMDToCCF_arrayBLcom_credenceid_biometrics_Biometrics_OnFMDToCCFConversionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_FMDTemplate, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var FMDTemplate = (byte[]) JNIEnv.GetArray (native_FMDTemplate, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var listener = (global::Com.Credenceid.Biometrics.IBiometricsOnFMDToCCFConversionListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnFMDToCCFConversionListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.ConvertFMDToCCF (FMDTemplate, listener);
			if (FMDTemplate != null)
				JNIEnv.CopyArray (FMDTemplate, native_FMDTemplate);
		}
#pragma warning restore 0169

		static IntPtr id_convertFMDToCCF_arrayBLcom_credenceid_biometrics_Biometrics_OnFMDToCCFConversionListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='convertFMDToCCF' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='com.credenceid.biometrics.Biometrics.OnFMDToCCFConversionListener']]"
		[Register ("convertFMDToCCF", "([BLcom/credenceid/biometrics/Biometrics$OnFMDToCCFConversionListener;)V", "GetConvertFMDToCCF_arrayBLcom_credenceid_biometrics_Biometrics_OnFMDToCCFConversionListener_Handler")]
		public virtual unsafe void ConvertFMDToCCF (byte[] FMDTemplate, global::Com.Credenceid.Biometrics.IBiometricsOnFMDToCCFConversionListener listener)
		{
			if (id_convertFMDToCCF_arrayBLcom_credenceid_biometrics_Biometrics_OnFMDToCCFConversionListener_ == IntPtr.Zero)
				id_convertFMDToCCF_arrayBLcom_credenceid_biometrics_Biometrics_OnFMDToCCFConversionListener_ = JNIEnv.GetMethodID (class_ref, "convertFMDToCCF", "([BLcom/credenceid/biometrics/Biometrics$OnFMDToCCFConversionListener;)V");
			IntPtr native_FMDTemplate = JNIEnv.NewArray (FMDTemplate);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_FMDTemplate);
				__args [1] = new JValue (listener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_convertFMDToCCF_arrayBLcom_credenceid_biometrics_Biometrics_OnFMDToCCFConversionListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "convertFMDToCCF", "([BLcom/credenceid/biometrics/Biometrics$OnFMDToCCFConversionListener;)V"), __args);
			} finally {
				if (FMDTemplate != null) {
					JNIEnv.CopyArray (native_FMDTemplate, FMDTemplate);
					JNIEnv.DeleteLocalRef (native_FMDTemplate);
				}
			}
		}

		static Delegate cb_convertFMDToCCFSync_arrayBI;
#pragma warning disable 0169
		static Delegate GetConvertFMDToCCFSync_arrayBIHandler ()
		{
			if (cb_convertFMDToCCFSync_arrayBI == null)
				cb_convertFMDToCCFSync_arrayBI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_L) n_ConvertFMDToCCFSync_arrayBI);
			return cb_convertFMDToCCFSync_arrayBI;
		}

		static IntPtr n_ConvertFMDToCCFSync_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_FMDTemplate, int timeout)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var FMDTemplate = (byte[]) JNIEnv.GetArray (native_FMDTemplate, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ConvertFMDToCCFSync (FMDTemplate, timeout));
			if (FMDTemplate != null)
				JNIEnv.CopyArray (FMDTemplate, native_FMDTemplate);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_convertFMDToCCFSync_arrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='convertFMDToCCFSync' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("convertFMDToCCFSync", "([BI)Lcom/credenceid/biometrics/FMDToCCFSyncResponse;", "GetConvertFMDToCCFSync_arrayBIHandler")]
		public virtual unsafe global::Com.Credenceid.Biometrics.FMDToCCFSyncResponse ConvertFMDToCCFSync (byte[] FMDTemplate, int timeout)
		{
			if (id_convertFMDToCCFSync_arrayBI == IntPtr.Zero)
				id_convertFMDToCCFSync_arrayBI = JNIEnv.GetMethodID (class_ref, "convertFMDToCCFSync", "([BI)Lcom/credenceid/biometrics/FMDToCCFSyncResponse;");
			IntPtr native_FMDTemplate = JNIEnv.NewArray (FMDTemplate);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_FMDTemplate);
				__args [1] = new JValue (timeout);

				global::Com.Credenceid.Biometrics.FMDToCCFSyncResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.FMDToCCFSyncResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_convertFMDToCCFSync_arrayBI, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.FMDToCCFSyncResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "convertFMDToCCFSync", "([BI)Lcom/credenceid/biometrics/FMDToCCFSyncResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (FMDTemplate != null) {
					JNIEnv.CopyArray (native_FMDTemplate, FMDTemplate);
					JNIEnv.DeleteLocalRef (native_FMDTemplate);
				}
			}
		}

		static Delegate cb_convertToFMD_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnConvertToFMDListener_;
#pragma warning disable 0169
		static Delegate GetConvertToFMD_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnConvertToFMDListener_Handler ()
		{
			if (cb_convertToFMD_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnConvertToFMDListener_ == null)
				cb_convertToFMD_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnConvertToFMDListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_ConvertToFMD_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnConvertToFMDListener_);
			return cb_convertToFMD_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnConvertToFMDListener_;
		}

		static void n_ConvertToFMD_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnConvertToFMDListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_inputBitmapImage, IntPtr native_format, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var inputBitmapImage = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_inputBitmapImage, JniHandleOwnership.DoNotTransfer);
			var format = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsFMDFormat> (native_format, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Credenceid.Biometrics.IBiometricsOnConvertToFMDListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnConvertToFMDListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.ConvertToFMD (inputBitmapImage, format, listener);
		}
#pragma warning restore 0169

		static IntPtr id_convertToFMD_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnConvertToFMDListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='convertToFMD' and count(parameter)=3 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='com.credenceid.biometrics.Biometrics.FMDFormat'] and parameter[3][@type='com.credenceid.biometrics.Biometrics.OnConvertToFMDListener']]"
		[Register ("convertToFMD", "(Landroid/graphics/Bitmap;Lcom/credenceid/biometrics/Biometrics$FMDFormat;Lcom/credenceid/biometrics/Biometrics$OnConvertToFMDListener;)V", "GetConvertToFMD_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnConvertToFMDListener_Handler")]
		public virtual unsafe void ConvertToFMD (global::Android.Graphics.Bitmap inputBitmapImage, global::Com.Credenceid.Biometrics.BiometricsFMDFormat format, global::Com.Credenceid.Biometrics.IBiometricsOnConvertToFMDListener listener)
		{
			if (id_convertToFMD_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnConvertToFMDListener_ == IntPtr.Zero)
				id_convertToFMD_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnConvertToFMDListener_ = JNIEnv.GetMethodID (class_ref, "convertToFMD", "(Landroid/graphics/Bitmap;Lcom/credenceid/biometrics/Biometrics$FMDFormat;Lcom/credenceid/biometrics/Biometrics$OnConvertToFMDListener;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (inputBitmapImage);
				__args [1] = new JValue (format);
				__args [2] = new JValue (listener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_convertToFMD_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnConvertToFMDListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "convertToFMD", "(Landroid/graphics/Bitmap;Lcom/credenceid/biometrics/Biometrics$FMDFormat;Lcom/credenceid/biometrics/Biometrics$OnConvertToFMDListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_convertToFMD_arrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnConvertToFMDListener_;
#pragma warning disable 0169
		static Delegate GetConvertToFMD_arrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnConvertToFMDListener_Handler ()
		{
			if (cb_convertToFMD_arrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnConvertToFMDListener_ == null)
				cb_convertToFMD_arrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnConvertToFMDListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_ConvertToFMD_arrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnConvertToFMDListener_);
			return cb_convertToFMD_arrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnConvertToFMDListener_;
		}

		static void n_ConvertToFMD_arrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnConvertToFMDListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_wsqArray, IntPtr native_format, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var wsqArray = (byte[]) JNIEnv.GetArray (native_wsqArray, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var format = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsFMDFormat> (native_format, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Credenceid.Biometrics.IBiometricsOnConvertToFMDListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnConvertToFMDListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.ConvertToFMD (wsqArray, format, listener);
			if (wsqArray != null)
				JNIEnv.CopyArray (wsqArray, native_wsqArray);
		}
#pragma warning restore 0169

		static IntPtr id_convertToFMD_arrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnConvertToFMDListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='convertToFMD' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='com.credenceid.biometrics.Biometrics.FMDFormat'] and parameter[3][@type='com.credenceid.biometrics.Biometrics.OnConvertToFMDListener']]"
		[Register ("convertToFMD", "([BLcom/credenceid/biometrics/Biometrics$FMDFormat;Lcom/credenceid/biometrics/Biometrics$OnConvertToFMDListener;)V", "GetConvertToFMD_arrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnConvertToFMDListener_Handler")]
		public virtual unsafe void ConvertToFMD (byte[] wsqArray, global::Com.Credenceid.Biometrics.BiometricsFMDFormat format, global::Com.Credenceid.Biometrics.IBiometricsOnConvertToFMDListener listener)
		{
			if (id_convertToFMD_arrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnConvertToFMDListener_ == IntPtr.Zero)
				id_convertToFMD_arrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnConvertToFMDListener_ = JNIEnv.GetMethodID (class_ref, "convertToFMD", "([BLcom/credenceid/biometrics/Biometrics$FMDFormat;Lcom/credenceid/biometrics/Biometrics$OnConvertToFMDListener;)V");
			IntPtr native_wsqArray = JNIEnv.NewArray (wsqArray);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_wsqArray);
				__args [1] = new JValue (format);
				__args [2] = new JValue (listener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_convertToFMD_arrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnConvertToFMDListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "convertToFMD", "([BLcom/credenceid/biometrics/Biometrics$FMDFormat;Lcom/credenceid/biometrics/Biometrics$OnConvertToFMDListener;)V"), __args);
			} finally {
				if (wsqArray != null) {
					JNIEnv.CopyArray (native_wsqArray, wsqArray);
					JNIEnv.DeleteLocalRef (native_wsqArray);
				}
			}
		}

		static Delegate cb_convertToFMDSync_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_FMDFormat_I;
#pragma warning disable 0169
		static Delegate GetConvertToFMDSync_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_FMDFormat_IHandler ()
		{
			if (cb_convertToFMDSync_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_FMDFormat_I == null)
				cb_convertToFMDSync_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_FMDFormat_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLI_L) n_ConvertToFMDSync_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_FMDFormat_I);
			return cb_convertToFMDSync_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_FMDFormat_I;
		}

		static IntPtr n_ConvertToFMDSync_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_FMDFormat_I (IntPtr jnienv, IntPtr native__this, IntPtr native_inputImage, IntPtr native_format, int timeout)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var inputImage = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_inputImage, JniHandleOwnership.DoNotTransfer);
			var format = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsFMDFormat> (native_format, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ConvertToFMDSync (inputImage, format, timeout));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_convertToFMDSync_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_FMDFormat_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='convertToFMDSync' and count(parameter)=3 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='com.credenceid.biometrics.Biometrics.FMDFormat'] and parameter[3][@type='int']]"
		[Register ("convertToFMDSync", "(Landroid/graphics/Bitmap;Lcom/credenceid/biometrics/Biometrics$FMDFormat;I)Lcom/credenceid/biometrics/ConvertToFMDSyncResponse;", "GetConvertToFMDSync_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_FMDFormat_IHandler")]
		public virtual unsafe global::Com.Credenceid.Biometrics.ConvertToFMDSyncResponse ConvertToFMDSync (global::Android.Graphics.Bitmap inputImage, global::Com.Credenceid.Biometrics.BiometricsFMDFormat format, int timeout)
		{
			if (id_convertToFMDSync_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_FMDFormat_I == IntPtr.Zero)
				id_convertToFMDSync_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_FMDFormat_I = JNIEnv.GetMethodID (class_ref, "convertToFMDSync", "(Landroid/graphics/Bitmap;Lcom/credenceid/biometrics/Biometrics$FMDFormat;I)Lcom/credenceid/biometrics/ConvertToFMDSyncResponse;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (inputImage);
				__args [1] = new JValue (format);
				__args [2] = new JValue (timeout);

				global::Com.Credenceid.Biometrics.ConvertToFMDSyncResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.ConvertToFMDSyncResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_convertToFMDSync_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_FMDFormat_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.ConvertToFMDSyncResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "convertToFMDSync", "(Landroid/graphics/Bitmap;Lcom/credenceid/biometrics/Biometrics$FMDFormat;I)Lcom/credenceid/biometrics/ConvertToFMDSyncResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_convertToFMDSync_arrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_I;
#pragma warning disable 0169
		static Delegate GetConvertToFMDSync_arrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_IHandler ()
		{
			if (cb_convertToFMDSync_arrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_I == null)
				cb_convertToFMDSync_arrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLI_L) n_ConvertToFMDSync_arrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_I);
			return cb_convertToFMDSync_arrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_I;
		}

		static IntPtr n_ConvertToFMDSync_arrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_I (IntPtr jnienv, IntPtr native__this, IntPtr native_wsqArray, IntPtr native_format, int timeout)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var wsqArray = (byte[]) JNIEnv.GetArray (native_wsqArray, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var format = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsFMDFormat> (native_format, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ConvertToFMDSync (wsqArray, format, timeout));
			if (wsqArray != null)
				JNIEnv.CopyArray (wsqArray, native_wsqArray);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_convertToFMDSync_arrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='convertToFMDSync' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='com.credenceid.biometrics.Biometrics.FMDFormat'] and parameter[3][@type='int']]"
		[Register ("convertToFMDSync", "([BLcom/credenceid/biometrics/Biometrics$FMDFormat;I)Lcom/credenceid/biometrics/ConvertToFMDSyncResponse;", "GetConvertToFMDSync_arrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_IHandler")]
		public virtual unsafe global::Com.Credenceid.Biometrics.ConvertToFMDSyncResponse ConvertToFMDSync (byte[] wsqArray, global::Com.Credenceid.Biometrics.BiometricsFMDFormat format, int timeout)
		{
			if (id_convertToFMDSync_arrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_I == IntPtr.Zero)
				id_convertToFMDSync_arrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_I = JNIEnv.GetMethodID (class_ref, "convertToFMDSync", "([BLcom/credenceid/biometrics/Biometrics$FMDFormat;I)Lcom/credenceid/biometrics/ConvertToFMDSyncResponse;");
			IntPtr native_wsqArray = JNIEnv.NewArray (wsqArray);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_wsqArray);
				__args [1] = new JValue (format);
				__args [2] = new JValue (timeout);

				global::Com.Credenceid.Biometrics.ConvertToFMDSyncResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.ConvertToFMDSyncResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_convertToFMDSync_arrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.ConvertToFMDSyncResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "convertToFMDSync", "([BLcom/credenceid/biometrics/Biometrics$FMDFormat;I)Lcom/credenceid/biometrics/ConvertToFMDSyncResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (wsqArray != null) {
					JNIEnv.CopyArray (native_wsqArray, wsqArray);
					JNIEnv.DeleteLocalRef (native_wsqArray);
				}
			}
		}

		static Delegate cb_createFaceTemplate_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnCreateFaceTemplateListener_;
#pragma warning disable 0169
		static Delegate GetCreateFaceTemplate_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnCreateFaceTemplateListener_Handler ()
		{
			if (cb_createFaceTemplate_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnCreateFaceTemplateListener_ == null)
				cb_createFaceTemplate_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnCreateFaceTemplateListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_CreateFaceTemplate_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnCreateFaceTemplateListener_);
			return cb_createFaceTemplate_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnCreateFaceTemplateListener_;
		}

		static void n_CreateFaceTemplate_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnCreateFaceTemplateListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_image, IntPtr native_onCreateFaceTemplateListener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var image = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_image, JniHandleOwnership.DoNotTransfer);
			var onCreateFaceTemplateListener = (global::Com.Credenceid.Face.IFaceEngineOnCreateFaceTemplateListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.IFaceEngineOnCreateFaceTemplateListener> (native_onCreateFaceTemplateListener, JniHandleOwnership.DoNotTransfer);
			__this.CreateFaceTemplate (image, onCreateFaceTemplateListener);
		}
#pragma warning restore 0169

		static IntPtr id_createFaceTemplate_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnCreateFaceTemplateListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='createFaceTemplate' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='com.credenceid.face.FaceEngine.OnCreateFaceTemplateListener']]"
		[Register ("createFaceTemplate", "(Landroid/graphics/Bitmap;Lcom/credenceid/face/FaceEngine$OnCreateFaceTemplateListener;)V", "GetCreateFaceTemplate_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnCreateFaceTemplateListener_Handler")]
		public virtual unsafe void CreateFaceTemplate (global::Android.Graphics.Bitmap image, global::Com.Credenceid.Face.IFaceEngineOnCreateFaceTemplateListener onCreateFaceTemplateListener)
		{
			if (id_createFaceTemplate_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnCreateFaceTemplateListener_ == IntPtr.Zero)
				id_createFaceTemplate_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnCreateFaceTemplateListener_ = JNIEnv.GetMethodID (class_ref, "createFaceTemplate", "(Landroid/graphics/Bitmap;Lcom/credenceid/face/FaceEngine$OnCreateFaceTemplateListener;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (image);
				__args [1] = new JValue (onCreateFaceTemplateListener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_createFaceTemplate_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnCreateFaceTemplateListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createFaceTemplate", "(Landroid/graphics/Bitmap;Lcom/credenceid/face/FaceEngine$OnCreateFaceTemplateListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_createFaceTemplate_arrayBIILcom_credenceid_face_FaceEngine_OnCreateFaceTemplateListener_;
#pragma warning disable 0169
		static Delegate GetCreateFaceTemplate_arrayBIILcom_credenceid_face_FaceEngine_OnCreateFaceTemplateListener_Handler ()
		{
			if (cb_createFaceTemplate_arrayBIILcom_credenceid_face_FaceEngine_OnCreateFaceTemplateListener_ == null)
				cb_createFaceTemplate_arrayBIILcom_credenceid_face_FaceEngine_OnCreateFaceTemplateListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIL_V) n_CreateFaceTemplate_arrayBIILcom_credenceid_face_FaceEngine_OnCreateFaceTemplateListener_);
			return cb_createFaceTemplate_arrayBIILcom_credenceid_face_FaceEngine_OnCreateFaceTemplateListener_;
		}

		static void n_CreateFaceTemplate_arrayBIILcom_credenceid_face_FaceEngine_OnCreateFaceTemplateListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_imageBytes, int imageWidth, int imageHeight, IntPtr native_onCreateFaceTemplateListener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var imageBytes = (byte[]) JNIEnv.GetArray (native_imageBytes, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var onCreateFaceTemplateListener = (global::Com.Credenceid.Face.IFaceEngineOnCreateFaceTemplateListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.IFaceEngineOnCreateFaceTemplateListener> (native_onCreateFaceTemplateListener, JniHandleOwnership.DoNotTransfer);
			__this.CreateFaceTemplate (imageBytes, imageWidth, imageHeight, onCreateFaceTemplateListener);
			if (imageBytes != null)
				JNIEnv.CopyArray (imageBytes, native_imageBytes);
		}
#pragma warning restore 0169

		static IntPtr id_createFaceTemplate_arrayBIILcom_credenceid_face_FaceEngine_OnCreateFaceTemplateListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='createFaceTemplate' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='com.credenceid.face.FaceEngine.OnCreateFaceTemplateListener']]"
		[Register ("createFaceTemplate", "([BIILcom/credenceid/face/FaceEngine$OnCreateFaceTemplateListener;)V", "GetCreateFaceTemplate_arrayBIILcom_credenceid_face_FaceEngine_OnCreateFaceTemplateListener_Handler")]
		public virtual unsafe void CreateFaceTemplate (byte[] imageBytes, int imageWidth, int imageHeight, global::Com.Credenceid.Face.IFaceEngineOnCreateFaceTemplateListener onCreateFaceTemplateListener)
		{
			if (id_createFaceTemplate_arrayBIILcom_credenceid_face_FaceEngine_OnCreateFaceTemplateListener_ == IntPtr.Zero)
				id_createFaceTemplate_arrayBIILcom_credenceid_face_FaceEngine_OnCreateFaceTemplateListener_ = JNIEnv.GetMethodID (class_ref, "createFaceTemplate", "([BIILcom/credenceid/face/FaceEngine$OnCreateFaceTemplateListener;)V");
			IntPtr native_imageBytes = JNIEnv.NewArray (imageBytes);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_imageBytes);
				__args [1] = new JValue (imageWidth);
				__args [2] = new JValue (imageHeight);
				__args [3] = new JValue (onCreateFaceTemplateListener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_createFaceTemplate_arrayBIILcom_credenceid_face_FaceEngine_OnCreateFaceTemplateListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createFaceTemplate", "([BIILcom/credenceid/face/FaceEngine$OnCreateFaceTemplateListener;)V"), __args);
			} finally {
				if (imageBytes != null) {
					JNIEnv.CopyArray (native_imageBytes, imageBytes);
					JNIEnv.DeleteLocalRef (native_imageBytes);
				}
			}
		}

		static Delegate cb_createFaceTemplateSync_Landroid_graphics_Bitmap_I;
#pragma warning disable 0169
		static Delegate GetCreateFaceTemplateSync_Landroid_graphics_Bitmap_IHandler ()
		{
			if (cb_createFaceTemplateSync_Landroid_graphics_Bitmap_I == null)
				cb_createFaceTemplateSync_Landroid_graphics_Bitmap_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_L) n_CreateFaceTemplateSync_Landroid_graphics_Bitmap_I);
			return cb_createFaceTemplateSync_Landroid_graphics_Bitmap_I;
		}

		static IntPtr n_CreateFaceTemplateSync_Landroid_graphics_Bitmap_I (IntPtr jnienv, IntPtr native__this, IntPtr native_image, int timeout)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var image = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_image, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateFaceTemplateSync (image, timeout));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createFaceTemplateSync_Landroid_graphics_Bitmap_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='createFaceTemplateSync' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='int']]"
		[Register ("createFaceTemplateSync", "(Landroid/graphics/Bitmap;I)Lcom/credenceid/face/CreateFaceTemplateSyncResponse;", "GetCreateFaceTemplateSync_Landroid_graphics_Bitmap_IHandler")]
		public virtual unsafe global::Com.Credenceid.Face.CreateFaceTemplateSyncResponse CreateFaceTemplateSync (global::Android.Graphics.Bitmap image, int timeout)
		{
			if (id_createFaceTemplateSync_Landroid_graphics_Bitmap_I == IntPtr.Zero)
				id_createFaceTemplateSync_Landroid_graphics_Bitmap_I = JNIEnv.GetMethodID (class_ref, "createFaceTemplateSync", "(Landroid/graphics/Bitmap;I)Lcom/credenceid/face/CreateFaceTemplateSyncResponse;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (image);
				__args [1] = new JValue (timeout);

				global::Com.Credenceid.Face.CreateFaceTemplateSyncResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.CreateFaceTemplateSyncResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createFaceTemplateSync_Landroid_graphics_Bitmap_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.CreateFaceTemplateSyncResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createFaceTemplateSync", "(Landroid/graphics/Bitmap;I)Lcom/credenceid/face/CreateFaceTemplateSyncResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_createFaceTemplateSync_arrayBIII;
#pragma warning disable 0169
		static Delegate GetCreateFaceTemplateSync_arrayBIIIHandler ()
		{
			if (cb_createFaceTemplateSync_arrayBIII == null)
				cb_createFaceTemplateSync_arrayBIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIII_L) n_CreateFaceTemplateSync_arrayBIII);
			return cb_createFaceTemplateSync_arrayBIII;
		}

		static IntPtr n_CreateFaceTemplateSync_arrayBIII (IntPtr jnienv, IntPtr native__this, IntPtr native_imageBytes, int imageWidth, int imageHeight, int timeout)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var imageBytes = (byte[]) JNIEnv.GetArray (native_imageBytes, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateFaceTemplateSync (imageBytes, imageWidth, imageHeight, timeout));
			if (imageBytes != null)
				JNIEnv.CopyArray (imageBytes, native_imageBytes);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createFaceTemplateSync_arrayBIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='createFaceTemplateSync' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("createFaceTemplateSync", "([BIII)Lcom/credenceid/face/CreateFaceTemplateSyncResponse;", "GetCreateFaceTemplateSync_arrayBIIIHandler")]
		public virtual unsafe global::Com.Credenceid.Face.CreateFaceTemplateSyncResponse CreateFaceTemplateSync (byte[] imageBytes, int imageWidth, int imageHeight, int timeout)
		{
			if (id_createFaceTemplateSync_arrayBIII == IntPtr.Zero)
				id_createFaceTemplateSync_arrayBIII = JNIEnv.GetMethodID (class_ref, "createFaceTemplateSync", "([BIII)Lcom/credenceid/face/CreateFaceTemplateSyncResponse;");
			IntPtr native_imageBytes = JNIEnv.NewArray (imageBytes);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_imageBytes);
				__args [1] = new JValue (imageWidth);
				__args [2] = new JValue (imageHeight);
				__args [3] = new JValue (timeout);

				global::Com.Credenceid.Face.CreateFaceTemplateSyncResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.CreateFaceTemplateSyncResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createFaceTemplateSync_arrayBIII, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.CreateFaceTemplateSyncResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createFaceTemplateSync", "([BIII)Lcom/credenceid/face/CreateFaceTemplateSyncResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (imageBytes != null) {
					JNIEnv.CopyArray (native_imageBytes, imageBytes);
					JNIEnv.DeleteLocalRef (native_imageBytes);
				}
			}
		}

		static Delegate cb_decompressWSQ_arrayBLcom_credenceid_biometrics_Biometrics_OnDecompressWSQListener_;
#pragma warning disable 0169
		static Delegate GetDecompressWSQ_arrayBLcom_credenceid_biometrics_Biometrics_OnDecompressWSQListener_Handler ()
		{
			if (cb_decompressWSQ_arrayBLcom_credenceid_biometrics_Biometrics_OnDecompressWSQListener_ == null)
				cb_decompressWSQ_arrayBLcom_credenceid_biometrics_Biometrics_OnDecompressWSQListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_DecompressWSQ_arrayBLcom_credenceid_biometrics_Biometrics_OnDecompressWSQListener_);
			return cb_decompressWSQ_arrayBLcom_credenceid_biometrics_Biometrics_OnDecompressWSQListener_;
		}

		static void n_DecompressWSQ_arrayBLcom_credenceid_biometrics_Biometrics_OnDecompressWSQListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_WSQArray, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var WSQArray = (byte[]) JNIEnv.GetArray (native_WSQArray, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var listener = (global::Com.Credenceid.Biometrics.IBiometricsOnDecompressWSQListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnDecompressWSQListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.DecompressWSQ (WSQArray, listener);
			if (WSQArray != null)
				JNIEnv.CopyArray (WSQArray, native_WSQArray);
		}
#pragma warning restore 0169

		static IntPtr id_decompressWSQ_arrayBLcom_credenceid_biometrics_Biometrics_OnDecompressWSQListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='decompressWSQ' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='com.credenceid.biometrics.Biometrics.OnDecompressWSQListener']]"
		[Register ("decompressWSQ", "([BLcom/credenceid/biometrics/Biometrics$OnDecompressWSQListener;)V", "GetDecompressWSQ_arrayBLcom_credenceid_biometrics_Biometrics_OnDecompressWSQListener_Handler")]
		public virtual unsafe void DecompressWSQ (byte[] WSQArray, global::Com.Credenceid.Biometrics.IBiometricsOnDecompressWSQListener listener)
		{
			if (id_decompressWSQ_arrayBLcom_credenceid_biometrics_Biometrics_OnDecompressWSQListener_ == IntPtr.Zero)
				id_decompressWSQ_arrayBLcom_credenceid_biometrics_Biometrics_OnDecompressWSQListener_ = JNIEnv.GetMethodID (class_ref, "decompressWSQ", "([BLcom/credenceid/biometrics/Biometrics$OnDecompressWSQListener;)V");
			IntPtr native_WSQArray = JNIEnv.NewArray (WSQArray);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_WSQArray);
				__args [1] = new JValue (listener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_decompressWSQ_arrayBLcom_credenceid_biometrics_Biometrics_OnDecompressWSQListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decompressWSQ", "([BLcom/credenceid/biometrics/Biometrics$OnDecompressWSQListener;)V"), __args);
			} finally {
				if (WSQArray != null) {
					JNIEnv.CopyArray (native_WSQArray, WSQArray);
					JNIEnv.DeleteLocalRef (native_WSQArray);
				}
			}
		}

		static Delegate cb_decompressWSQ_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_OnDecompressWSQListener_;
#pragma warning disable 0169
		static Delegate GetDecompressWSQ_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_OnDecompressWSQListener_Handler ()
		{
			if (cb_decompressWSQ_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_OnDecompressWSQListener_ == null)
				cb_decompressWSQ_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_OnDecompressWSQListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_DecompressWSQ_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_OnDecompressWSQListener_);
			return cb_decompressWSQ_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_OnDecompressWSQListener_;
		}

		static void n_DecompressWSQ_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_OnDecompressWSQListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_absFilePath, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var absFilePath = JNIEnv.GetString (native_absFilePath, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Credenceid.Biometrics.IBiometricsOnDecompressWSQListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnDecompressWSQListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.DecompressWSQ (absFilePath, listener);
		}
#pragma warning restore 0169

		static IntPtr id_decompressWSQ_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_OnDecompressWSQListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='decompressWSQ' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.credenceid.biometrics.Biometrics.OnDecompressWSQListener']]"
		[Register ("decompressWSQ", "(Ljava/lang/String;Lcom/credenceid/biometrics/Biometrics$OnDecompressWSQListener;)V", "GetDecompressWSQ_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_OnDecompressWSQListener_Handler")]
		public virtual unsafe void DecompressWSQ (string absFilePath, global::Com.Credenceid.Biometrics.IBiometricsOnDecompressWSQListener listener)
		{
			if (id_decompressWSQ_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_OnDecompressWSQListener_ == IntPtr.Zero)
				id_decompressWSQ_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_OnDecompressWSQListener_ = JNIEnv.GetMethodID (class_ref, "decompressWSQ", "(Ljava/lang/String;Lcom/credenceid/biometrics/Biometrics$OnDecompressWSQListener;)V");
			IntPtr native_absFilePath = JNIEnv.NewString (absFilePath);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_absFilePath);
				__args [1] = new JValue (listener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_decompressWSQ_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_OnDecompressWSQListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decompressWSQ", "(Ljava/lang/String;Lcom/credenceid/biometrics/Biometrics$OnDecompressWSQListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_absFilePath);
			}
		}

		static Delegate cb_delete_ILcom_credenceid_database_BiometricDatabase_OnDeleteCallback_;
#pragma warning disable 0169
		static Delegate GetDelete_ILcom_credenceid_database_BiometricDatabase_OnDeleteCallback_Handler ()
		{
			if (cb_delete_ILcom_credenceid_database_BiometricDatabase_OnDeleteCallback_ == null)
				cb_delete_ILcom_credenceid_database_BiometricDatabase_OnDeleteCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_Delete_ILcom_credenceid_database_BiometricDatabase_OnDeleteCallback_);
			return cb_delete_ILcom_credenceid_database_BiometricDatabase_OnDeleteCallback_;
		}

		static void n_Delete_ILcom_credenceid_database_BiometricDatabase_OnDeleteCallback_ (IntPtr jnienv, IntPtr native__this, int ID, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Com.Credenceid.Database.IBiometricDatabaseOnDeleteCallback)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.IBiometricDatabaseOnDeleteCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.Delete (ID, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_delete_ILcom_credenceid_database_BiometricDatabase_OnDeleteCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='delete' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.credenceid.database.BiometricDatabase.OnDeleteCallback']]"
		[Register ("delete", "(ILcom/credenceid/database/BiometricDatabase$OnDeleteCallback;)V", "GetDelete_ILcom_credenceid_database_BiometricDatabase_OnDeleteCallback_Handler")]
		public virtual unsafe void Delete (int ID, global::Com.Credenceid.Database.IBiometricDatabaseOnDeleteCallback @callback)
		{
			if (id_delete_ILcom_credenceid_database_BiometricDatabase_OnDeleteCallback_ == IntPtr.Zero)
				id_delete_ILcom_credenceid_database_BiometricDatabase_OnDeleteCallback_ = JNIEnv.GetMethodID (class_ref, "delete", "(ILcom/credenceid/database/BiometricDatabase$OnDeleteCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (ID);
				__args [1] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_delete_ILcom_credenceid_database_BiometricDatabase_OnDeleteCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "delete", "(ILcom/credenceid/database/BiometricDatabase$OnDeleteCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_detectFace_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnDetectFaceListener_;
#pragma warning disable 0169
		static Delegate GetDetectFace_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnDetectFaceListener_Handler ()
		{
			if (cb_detectFace_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnDetectFaceListener_ == null)
				cb_detectFace_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnDetectFaceListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_DetectFace_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnDetectFaceListener_);
			return cb_detectFace_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnDetectFaceListener_;
		}

		static void n_DetectFace_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnDetectFaceListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_image, IntPtr native_onDetectFaceListener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var image = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_image, JniHandleOwnership.DoNotTransfer);
			var onDetectFaceListener = (global::Com.Credenceid.Face.IFaceEngineOnDetectFaceListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.IFaceEngineOnDetectFaceListener> (native_onDetectFaceListener, JniHandleOwnership.DoNotTransfer);
			__this.DetectFace (image, onDetectFaceListener);
		}
#pragma warning restore 0169

		static IntPtr id_detectFace_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnDetectFaceListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='detectFace' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='com.credenceid.face.FaceEngine.OnDetectFaceListener']]"
		[Register ("detectFace", "(Landroid/graphics/Bitmap;Lcom/credenceid/face/FaceEngine$OnDetectFaceListener;)V", "GetDetectFace_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnDetectFaceListener_Handler")]
		public virtual unsafe void DetectFace (global::Android.Graphics.Bitmap image, global::Com.Credenceid.Face.IFaceEngineOnDetectFaceListener onDetectFaceListener)
		{
			if (id_detectFace_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnDetectFaceListener_ == IntPtr.Zero)
				id_detectFace_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnDetectFaceListener_ = JNIEnv.GetMethodID (class_ref, "detectFace", "(Landroid/graphics/Bitmap;Lcom/credenceid/face/FaceEngine$OnDetectFaceListener;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (image);
				__args [1] = new JValue (onDetectFaceListener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_detectFace_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnDetectFaceListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "detectFace", "(Landroid/graphics/Bitmap;Lcom/credenceid/face/FaceEngine$OnDetectFaceListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_detectFace_arrayBIILcom_credenceid_face_FaceEngine_OnDetectFaceListener_;
#pragma warning disable 0169
		static Delegate GetDetectFace_arrayBIILcom_credenceid_face_FaceEngine_OnDetectFaceListener_Handler ()
		{
			if (cb_detectFace_arrayBIILcom_credenceid_face_FaceEngine_OnDetectFaceListener_ == null)
				cb_detectFace_arrayBIILcom_credenceid_face_FaceEngine_OnDetectFaceListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIL_V) n_DetectFace_arrayBIILcom_credenceid_face_FaceEngine_OnDetectFaceListener_);
			return cb_detectFace_arrayBIILcom_credenceid_face_FaceEngine_OnDetectFaceListener_;
		}

		static void n_DetectFace_arrayBIILcom_credenceid_face_FaceEngine_OnDetectFaceListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_imageBytes, int imageWidth, int imageHeight, IntPtr native_onDetectFaceListener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var imageBytes = (byte[]) JNIEnv.GetArray (native_imageBytes, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var onDetectFaceListener = (global::Com.Credenceid.Face.IFaceEngineOnDetectFaceListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.IFaceEngineOnDetectFaceListener> (native_onDetectFaceListener, JniHandleOwnership.DoNotTransfer);
			__this.DetectFace (imageBytes, imageWidth, imageHeight, onDetectFaceListener);
			if (imageBytes != null)
				JNIEnv.CopyArray (imageBytes, native_imageBytes);
		}
#pragma warning restore 0169

		static IntPtr id_detectFace_arrayBIILcom_credenceid_face_FaceEngine_OnDetectFaceListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='detectFace' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='com.credenceid.face.FaceEngine.OnDetectFaceListener']]"
		[Register ("detectFace", "([BIILcom/credenceid/face/FaceEngine$OnDetectFaceListener;)V", "GetDetectFace_arrayBIILcom_credenceid_face_FaceEngine_OnDetectFaceListener_Handler")]
		public virtual unsafe void DetectFace (byte[] imageBytes, int imageWidth, int imageHeight, global::Com.Credenceid.Face.IFaceEngineOnDetectFaceListener onDetectFaceListener)
		{
			if (id_detectFace_arrayBIILcom_credenceid_face_FaceEngine_OnDetectFaceListener_ == IntPtr.Zero)
				id_detectFace_arrayBIILcom_credenceid_face_FaceEngine_OnDetectFaceListener_ = JNIEnv.GetMethodID (class_ref, "detectFace", "([BIILcom/credenceid/face/FaceEngine$OnDetectFaceListener;)V");
			IntPtr native_imageBytes = JNIEnv.NewArray (imageBytes);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_imageBytes);
				__args [1] = new JValue (imageWidth);
				__args [2] = new JValue (imageHeight);
				__args [3] = new JValue (onDetectFaceListener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_detectFace_arrayBIILcom_credenceid_face_FaceEngine_OnDetectFaceListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "detectFace", "([BIILcom/credenceid/face/FaceEngine$OnDetectFaceListener;)V"), __args);
			} finally {
				if (imageBytes != null) {
					JNIEnv.CopyArray (native_imageBytes, imageBytes);
					JNIEnv.DeleteLocalRef (native_imageBytes);
				}
			}
		}

		static Delegate cb_detectFaceSync_Landroid_graphics_Bitmap_I;
#pragma warning disable 0169
		static Delegate GetDetectFaceSync_Landroid_graphics_Bitmap_IHandler ()
		{
			if (cb_detectFaceSync_Landroid_graphics_Bitmap_I == null)
				cb_detectFaceSync_Landroid_graphics_Bitmap_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_L) n_DetectFaceSync_Landroid_graphics_Bitmap_I);
			return cb_detectFaceSync_Landroid_graphics_Bitmap_I;
		}

		static IntPtr n_DetectFaceSync_Landroid_graphics_Bitmap_I (IntPtr jnienv, IntPtr native__this, IntPtr native_image, int timeout)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var image = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_image, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DetectFaceSync (image, timeout));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_detectFaceSync_Landroid_graphics_Bitmap_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='detectFaceSync' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='int']]"
		[Register ("detectFaceSync", "(Landroid/graphics/Bitmap;I)Lcom/credenceid/face/DetectFaceSyncResponse;", "GetDetectFaceSync_Landroid_graphics_Bitmap_IHandler")]
		public virtual unsafe global::Com.Credenceid.Face.DetectFaceSyncResponse DetectFaceSync (global::Android.Graphics.Bitmap image, int timeout)
		{
			if (id_detectFaceSync_Landroid_graphics_Bitmap_I == IntPtr.Zero)
				id_detectFaceSync_Landroid_graphics_Bitmap_I = JNIEnv.GetMethodID (class_ref, "detectFaceSync", "(Landroid/graphics/Bitmap;I)Lcom/credenceid/face/DetectFaceSyncResponse;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (image);
				__args [1] = new JValue (timeout);

				global::Com.Credenceid.Face.DetectFaceSyncResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.DetectFaceSyncResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_detectFaceSync_Landroid_graphics_Bitmap_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.DetectFaceSyncResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "detectFaceSync", "(Landroid/graphics/Bitmap;I)Lcom/credenceid/face/DetectFaceSyncResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_detectFaceSync_arrayBIII;
#pragma warning disable 0169
		static Delegate GetDetectFaceSync_arrayBIIIHandler ()
		{
			if (cb_detectFaceSync_arrayBIII == null)
				cb_detectFaceSync_arrayBIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIII_L) n_DetectFaceSync_arrayBIII);
			return cb_detectFaceSync_arrayBIII;
		}

		static IntPtr n_DetectFaceSync_arrayBIII (IntPtr jnienv, IntPtr native__this, IntPtr native_imageBytes, int imageWidth, int imageHeight, int timeout)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var imageBytes = (byte[]) JNIEnv.GetArray (native_imageBytes, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DetectFaceSync (imageBytes, imageWidth, imageHeight, timeout));
			if (imageBytes != null)
				JNIEnv.CopyArray (imageBytes, native_imageBytes);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_detectFaceSync_arrayBIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='detectFaceSync' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("detectFaceSync", "([BIII)Lcom/credenceid/face/DetectFaceSyncResponse;", "GetDetectFaceSync_arrayBIIIHandler")]
		public virtual unsafe global::Com.Credenceid.Face.DetectFaceSyncResponse DetectFaceSync (byte[] imageBytes, int imageWidth, int imageHeight, int timeout)
		{
			if (id_detectFaceSync_arrayBIII == IntPtr.Zero)
				id_detectFaceSync_arrayBIII = JNIEnv.GetMethodID (class_ref, "detectFaceSync", "([BIII)Lcom/credenceid/face/DetectFaceSyncResponse;");
			IntPtr native_imageBytes = JNIEnv.NewArray (imageBytes);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_imageBytes);
				__args [1] = new JValue (imageWidth);
				__args [2] = new JValue (imageHeight);
				__args [3] = new JValue (timeout);

				global::Com.Credenceid.Face.DetectFaceSyncResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.DetectFaceSyncResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_detectFaceSync_arrayBIII, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.DetectFaceSyncResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "detectFaceSync", "([BIII)Lcom/credenceid/face/DetectFaceSyncResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (imageBytes != null) {
					JNIEnv.CopyArray (native_imageBytes, imageBytes);
					JNIEnv.DeleteLocalRef (native_imageBytes);
				}
			}
		}

		static Delegate cb_ePassportCloseCommand;
#pragma warning disable 0169
		static Delegate GetEPassportCloseCommandHandler ()
		{
			if (cb_ePassportCloseCommand == null)
				cb_ePassportCloseCommand = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_EPassportCloseCommand);
			return cb_ePassportCloseCommand;
		}

		static void n_EPassportCloseCommand (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EPassportCloseCommand ();
		}
#pragma warning restore 0169

		static IntPtr id_ePassportCloseCommand;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='ePassportCloseCommand' and count(parameter)=0]"
		[Register ("ePassportCloseCommand", "()V", "GetEPassportCloseCommandHandler")]
		public virtual unsafe void EPassportCloseCommand ()
		{
			if (id_ePassportCloseCommand == IntPtr.Zero)
				id_ePassportCloseCommand = JNIEnv.GetMethodID (class_ref, "ePassportCloseCommand", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_ePassportCloseCommand);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ePassportCloseCommand", "()V"));
			} finally {
			}
		}

		static Delegate cb_ePassportCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnEPassportCommandListener_;
#pragma warning disable 0169
		static Delegate GetEPassportCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnEPassportCommandListener_Handler ()
		{
			if (cb_ePassportCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnEPassportCommandListener_ == null)
				cb_ePassportCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnEPassportCommandListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZL_V) n_EPassportCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnEPassportCommandListener_);
			return cb_ePassportCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnEPassportCommandListener_;
		}

		static void n_EPassportCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnEPassportCommandListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_APDU, bool protocolT0T1, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var APDU = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.ApduCommand> (native_APDU, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Credenceid.Biometrics.IBiometricsOnEPassportCommandListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnEPassportCommandListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.EPassportCommand (APDU, protocolT0T1, listener);
		}
#pragma warning restore 0169

		static IntPtr id_ePassportCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnEPassportCommandListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='ePassportCommand' and count(parameter)=3 and parameter[1][@type='com.credenceid.biometrics.ApduCommand'] and parameter[2][@type='boolean'] and parameter[3][@type='com.credenceid.biometrics.Biometrics.OnEPassportCommandListener']]"
		[Register ("ePassportCommand", "(Lcom/credenceid/biometrics/ApduCommand;ZLcom/credenceid/biometrics/Biometrics$OnEPassportCommandListener;)V", "GetEPassportCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnEPassportCommandListener_Handler")]
		public virtual unsafe void EPassportCommand (global::Com.Credenceid.Biometrics.ApduCommand APDU, bool protocolT0T1, global::Com.Credenceid.Biometrics.IBiometricsOnEPassportCommandListener listener)
		{
			if (id_ePassportCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnEPassportCommandListener_ == IntPtr.Zero)
				id_ePassportCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnEPassportCommandListener_ = JNIEnv.GetMethodID (class_ref, "ePassportCommand", "(Lcom/credenceid/biometrics/ApduCommand;ZLcom/credenceid/biometrics/Biometrics$OnEPassportCommandListener;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (APDU);
				__args [1] = new JValue (protocolT0T1);
				__args [2] = new JValue (listener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_ePassportCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnEPassportCommandListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ePassportCommand", "(Lcom/credenceid/biometrics/ApduCommand;ZLcom/credenceid/biometrics/Biometrics$OnEPassportCommandListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_ePassportOpenCommand_Lcom_credenceid_biometrics_Biometrics_EPassportReaderStatusListener_;
#pragma warning disable 0169
		static Delegate GetEPassportOpenCommand_Lcom_credenceid_biometrics_Biometrics_EPassportReaderStatusListener_Handler ()
		{
			if (cb_ePassportOpenCommand_Lcom_credenceid_biometrics_Biometrics_EPassportReaderStatusListener_ == null)
				cb_ePassportOpenCommand_Lcom_credenceid_biometrics_Biometrics_EPassportReaderStatusListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_EPassportOpenCommand_Lcom_credenceid_biometrics_Biometrics_EPassportReaderStatusListener_);
			return cb_ePassportOpenCommand_Lcom_credenceid_biometrics_Biometrics_EPassportReaderStatusListener_;
		}

		static void n_EPassportOpenCommand_Lcom_credenceid_biometrics_Biometrics_EPassportReaderStatusListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Credenceid.Biometrics.IBiometricsEPassportReaderStatusListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsEPassportReaderStatusListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.EPassportOpenCommand (listener);
		}
#pragma warning restore 0169

		static IntPtr id_ePassportOpenCommand_Lcom_credenceid_biometrics_Biometrics_EPassportReaderStatusListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='ePassportOpenCommand' and count(parameter)=1 and parameter[1][@type='com.credenceid.biometrics.Biometrics.EPassportReaderStatusListener']]"
		[Register ("ePassportOpenCommand", "(Lcom/credenceid/biometrics/Biometrics$EPassportReaderStatusListener;)V", "GetEPassportOpenCommand_Lcom_credenceid_biometrics_Biometrics_EPassportReaderStatusListener_Handler")]
		public virtual unsafe void EPassportOpenCommand (global::Com.Credenceid.Biometrics.IBiometricsEPassportReaderStatusListener listener)
		{
			if (id_ePassportOpenCommand_Lcom_credenceid_biometrics_Biometrics_EPassportReaderStatusListener_ == IntPtr.Zero)
				id_ePassportOpenCommand_Lcom_credenceid_biometrics_Biometrics_EPassportReaderStatusListener_ = JNIEnv.GetMethodID (class_ref, "ePassportOpenCommand", "(Lcom/credenceid/biometrics/Biometrics$EPassportReaderStatusListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (listener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_ePassportOpenCommand_Lcom_credenceid_biometrics_Biometrics_EPassportReaderStatusListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ePassportOpenCommand", "(Lcom/credenceid/biometrics/Biometrics$EPassportReaderStatusListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_ektpCardReadCommand_IarrayBLcom_credenceid_biometrics_Biometrics_OnEktpCardReadListener_;
#pragma warning disable 0169
		static Delegate GetEktpCardReadCommand_IarrayBLcom_credenceid_biometrics_Biometrics_OnEktpCardReadListener_Handler ()
		{
			if (cb_ektpCardReadCommand_IarrayBLcom_credenceid_biometrics_Biometrics_OnEktpCardReadListener_ == null)
				cb_ektpCardReadCommand_IarrayBLcom_credenceid_biometrics_Biometrics_OnEktpCardReadListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPILL_V) n_EktpCardReadCommand_IarrayBLcom_credenceid_biometrics_Biometrics_OnEktpCardReadListener_);
			return cb_ektpCardReadCommand_IarrayBLcom_credenceid_biometrics_Biometrics_OnEktpCardReadListener_;
		}

		static void n_EktpCardReadCommand_IarrayBLcom_credenceid_biometrics_Biometrics_OnEktpCardReadListener_ (IntPtr jnienv, IntPtr native__this, int command, IntPtr native_data, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var data = (byte[]) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var listener = (global::Com.Credenceid.Biometrics.IBiometricsOnEktpCardReadListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnEktpCardReadListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.EktpCardReadCommand (command, data, listener);
			if (data != null)
				JNIEnv.CopyArray (data, native_data);
		}
#pragma warning restore 0169

		static IntPtr id_ektpCardReadCommand_IarrayBLcom_credenceid_biometrics_Biometrics_OnEktpCardReadListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='ektpCardReadCommand' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='com.credenceid.biometrics.Biometrics.OnEktpCardReadListener']]"
		[Register ("ektpCardReadCommand", "(I[BLcom/credenceid/biometrics/Biometrics$OnEktpCardReadListener;)V", "GetEktpCardReadCommand_IarrayBLcom_credenceid_biometrics_Biometrics_OnEktpCardReadListener_Handler")]
		public virtual unsafe void EktpCardReadCommand (int command, byte[] data, global::Com.Credenceid.Biometrics.IBiometricsOnEktpCardReadListener listener)
		{
			if (id_ektpCardReadCommand_IarrayBLcom_credenceid_biometrics_Biometrics_OnEktpCardReadListener_ == IntPtr.Zero)
				id_ektpCardReadCommand_IarrayBLcom_credenceid_biometrics_Biometrics_OnEktpCardReadListener_ = JNIEnv.GetMethodID (class_ref, "ektpCardReadCommand", "(I[BLcom/credenceid/biometrics/Biometrics$OnEktpCardReadListener;)V");
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (command);
				__args [1] = new JValue (native_data);
				__args [2] = new JValue (listener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_ektpCardReadCommand_IarrayBLcom_credenceid_biometrics_Biometrics_OnEktpCardReadListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ektpCardReadCommand", "(I[BLcom/credenceid/biometrics/Biometrics$OnEktpCardReadListener;)V"), __args);
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

		static Delegate cb_enroll_ILcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnEnrollCallback_;
#pragma warning disable 0169
		static Delegate GetEnroll_ILcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnEnrollCallback_Handler ()
		{
			if (cb_enroll_ILcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnEnrollCallback_ == null)
				cb_enroll_ILcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnEnrollCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPILLLL_V) n_Enroll_ILcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnEnrollCallback_);
			return cb_enroll_ILcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnEnrollCallback_;
		}

		static void n_Enroll_ILcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnEnrollCallback_ (IntPtr jnienv, IntPtr native__this, int ID, IntPtr native_finger, IntPtr native_face, IntPtr native_iris, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var finger = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.FingerprintRecord> (native_finger, JniHandleOwnership.DoNotTransfer);
			var face = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.FaceRecord> (native_face, JniHandleOwnership.DoNotTransfer);
			var iris = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.IrisRecord> (native_iris, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Com.Credenceid.Database.IBiometricDatabaseOnEnrollCallback)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.IBiometricDatabaseOnEnrollCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.Enroll (ID, finger, face, iris, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_enroll_ILcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnEnrollCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='enroll' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='com.credenceid.database.FingerprintRecord'] and parameter[3][@type='com.credenceid.database.FaceRecord'] and parameter[4][@type='com.credenceid.database.IrisRecord'] and parameter[5][@type='com.credenceid.database.BiometricDatabase.OnEnrollCallback']]"
		[Register ("enroll", "(ILcom/credenceid/database/FingerprintRecord;Lcom/credenceid/database/FaceRecord;Lcom/credenceid/database/IrisRecord;Lcom/credenceid/database/BiometricDatabase$OnEnrollCallback;)V", "GetEnroll_ILcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnEnrollCallback_Handler")]
		public virtual unsafe void Enroll (int ID, global::Com.Credenceid.Database.FingerprintRecord finger, global::Com.Credenceid.Database.FaceRecord face, global::Com.Credenceid.Database.IrisRecord iris, global::Com.Credenceid.Database.IBiometricDatabaseOnEnrollCallback @callback)
		{
			if (id_enroll_ILcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnEnrollCallback_ == IntPtr.Zero)
				id_enroll_ILcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnEnrollCallback_ = JNIEnv.GetMethodID (class_ref, "enroll", "(ILcom/credenceid/database/FingerprintRecord;Lcom/credenceid/database/FaceRecord;Lcom/credenceid/database/IrisRecord;Lcom/credenceid/database/BiometricDatabase$OnEnrollCallback;)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (ID);
				__args [1] = new JValue (finger);
				__args [2] = new JValue (face);
				__args [3] = new JValue (iris);
				__args [4] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_enroll_ILcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnEnrollCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enroll", "(ILcom/credenceid/database/FingerprintRecord;Lcom/credenceid/database/FaceRecord;Lcom/credenceid/database/IrisRecord;Lcom/credenceid/database/BiometricDatabase$OnEnrollCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_enroll_IarrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnEnrollCallback_;
#pragma warning disable 0169
		static Delegate GetEnroll_IarrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnEnrollCallback_Handler ()
		{
			if (cb_enroll_IarrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnEnrollCallback_ == null)
				cb_enroll_IarrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnEnrollCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPILLLL_V) n_Enroll_IarrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnEnrollCallback_);
			return cb_enroll_IarrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnEnrollCallback_;
		}

		static void n_Enroll_IarrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnEnrollCallback_ (IntPtr jnienv, IntPtr native__this, int ID, IntPtr native_fingers, IntPtr native_face, IntPtr native_irises, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fingers = (global::Com.Credenceid.Database.FingerprintRecord[]) JNIEnv.GetArray (native_fingers, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Credenceid.Database.FingerprintRecord));
			var face = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.FaceRecord> (native_face, JniHandleOwnership.DoNotTransfer);
			var irises = (global::Com.Credenceid.Database.IrisRecord[]) JNIEnv.GetArray (native_irises, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Credenceid.Database.IrisRecord));
			var @callback = (global::Com.Credenceid.Database.IBiometricDatabaseOnEnrollCallback)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.IBiometricDatabaseOnEnrollCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.Enroll (ID, fingers, face, irises, @callback);
			if (fingers != null)
				JNIEnv.CopyArray (fingers, native_fingers);
			if (irises != null)
				JNIEnv.CopyArray (irises, native_irises);
		}
#pragma warning restore 0169

		static IntPtr id_enroll_IarrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnEnrollCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='enroll' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='com.credenceid.database.FingerprintRecord[]'] and parameter[3][@type='com.credenceid.database.FaceRecord'] and parameter[4][@type='com.credenceid.database.IrisRecord[]'] and parameter[5][@type='com.credenceid.database.BiometricDatabase.OnEnrollCallback']]"
		[Register ("enroll", "(I[Lcom/credenceid/database/FingerprintRecord;Lcom/credenceid/database/FaceRecord;[Lcom/credenceid/database/IrisRecord;Lcom/credenceid/database/BiometricDatabase$OnEnrollCallback;)V", "GetEnroll_IarrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnEnrollCallback_Handler")]
		public virtual unsafe void Enroll (int ID, global::Com.Credenceid.Database.FingerprintRecord[] fingers, global::Com.Credenceid.Database.FaceRecord face, global::Com.Credenceid.Database.IrisRecord[] irises, global::Com.Credenceid.Database.IBiometricDatabaseOnEnrollCallback @callback)
		{
			if (id_enroll_IarrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnEnrollCallback_ == IntPtr.Zero)
				id_enroll_IarrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnEnrollCallback_ = JNIEnv.GetMethodID (class_ref, "enroll", "(I[Lcom/credenceid/database/FingerprintRecord;Lcom/credenceid/database/FaceRecord;[Lcom/credenceid/database/IrisRecord;Lcom/credenceid/database/BiometricDatabase$OnEnrollCallback;)V");
			IntPtr native_fingers = JNIEnv.NewArray (fingers);
			IntPtr native_irises = JNIEnv.NewArray (irises);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (ID);
				__args [1] = new JValue (native_fingers);
				__args [2] = new JValue (face);
				__args [3] = new JValue (native_irises);
				__args [4] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_enroll_IarrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnEnrollCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enroll", "(I[Lcom/credenceid/database/FingerprintRecord;Lcom/credenceid/database/FaceRecord;[Lcom/credenceid/database/IrisRecord;Lcom/credenceid/database/BiometricDatabase$OnEnrollCallback;)V"), __args);
			} finally {
				if (fingers != null) {
					JNIEnv.CopyArray (native_fingers, fingers);
					JNIEnv.DeleteLocalRef (native_fingers);
				}
				if (irises != null) {
					JNIEnv.CopyArray (native_irises, irises);
					JNIEnv.DeleteLocalRef (native_irises);
				}
			}
		}

		static Delegate cb_finalizeBiometrics_Z;
#pragma warning disable 0169
		static Delegate GetFinalizeBiometrics_ZHandler ()
		{
			if (cb_finalizeBiometrics_Z == null)
				cb_finalizeBiometrics_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_FinalizeBiometrics_Z);
			return cb_finalizeBiometrics_Z;
		}

		static void n_FinalizeBiometrics_Z (IntPtr jnienv, IntPtr native__this, bool stopService)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FinalizeBiometrics (stopService);
		}
#pragma warning restore 0169

		static IntPtr id_finalizeBiometrics_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='finalizeBiometrics' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("finalizeBiometrics", "(Z)V", "GetFinalizeBiometrics_ZHandler")]
		public virtual unsafe void FinalizeBiometrics (bool stopService)
		{
			if (id_finalizeBiometrics_Z == IntPtr.Zero)
				id_finalizeBiometrics_Z = JNIEnv.GetMethodID (class_ref, "finalizeBiometrics", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (stopService);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_finalizeBiometrics_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "finalizeBiometrics", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_generateTerminalIsCertificate_Lcom_credenceid_biometrics_Biometrics_generateTerminalIsCertificateListener_;
#pragma warning disable 0169
		static Delegate GetGenerateTerminalIsCertificate_Lcom_credenceid_biometrics_Biometrics_generateTerminalIsCertificateListener_Handler ()
		{
			if (cb_generateTerminalIsCertificate_Lcom_credenceid_biometrics_Biometrics_generateTerminalIsCertificateListener_ == null)
				cb_generateTerminalIsCertificate_Lcom_credenceid_biometrics_Biometrics_generateTerminalIsCertificateListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_GenerateTerminalIsCertificate_Lcom_credenceid_biometrics_Biometrics_generateTerminalIsCertificateListener_);
			return cb_generateTerminalIsCertificate_Lcom_credenceid_biometrics_Biometrics_generateTerminalIsCertificateListener_;
		}

		static void n_GenerateTerminalIsCertificate_Lcom_credenceid_biometrics_Biometrics_generateTerminalIsCertificateListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Credenceid.Biometrics.IBiometricsGenerateTerminalIsCertificateListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsGenerateTerminalIsCertificateListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.GenerateTerminalIsCertificate (listener);
		}
#pragma warning restore 0169

		static IntPtr id_generateTerminalIsCertificate_Lcom_credenceid_biometrics_Biometrics_generateTerminalIsCertificateListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='generateTerminalIsCertificate' and count(parameter)=1 and parameter[1][@type='com.credenceid.biometrics.Biometrics.generateTerminalIsCertificateListener']]"
		[Register ("generateTerminalIsCertificate", "(Lcom/credenceid/biometrics/Biometrics$generateTerminalIsCertificateListener;)V", "GetGenerateTerminalIsCertificate_Lcom_credenceid_biometrics_Biometrics_generateTerminalIsCertificateListener_Handler")]
		public virtual unsafe void GenerateTerminalIsCertificate (global::Com.Credenceid.Biometrics.IBiometricsGenerateTerminalIsCertificateListener listener)
		{
			if (id_generateTerminalIsCertificate_Lcom_credenceid_biometrics_Biometrics_generateTerminalIsCertificateListener_ == IntPtr.Zero)
				id_generateTerminalIsCertificate_Lcom_credenceid_biometrics_Biometrics_generateTerminalIsCertificateListener_ = JNIEnv.GetMethodID (class_ref, "generateTerminalIsCertificate", "(Lcom/credenceid/biometrics/Biometrics$generateTerminalIsCertificateListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (listener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_generateTerminalIsCertificate_Lcom_credenceid_biometrics_Biometrics_generateTerminalIsCertificateListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "generateTerminalIsCertificate", "(Lcom/credenceid/biometrics/Biometrics$generateTerminalIsCertificateListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getFingerQuality_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_OnGetFingerQualityListener_;
#pragma warning disable 0169
		static Delegate GetGetFingerQuality_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_OnGetFingerQualityListener_Handler ()
		{
			if (cb_getFingerQuality_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_OnGetFingerQualityListener_ == null)
				cb_getFingerQuality_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_OnGetFingerQualityListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_GetFingerQuality_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_OnGetFingerQualityListener_);
			return cb_getFingerQuality_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_OnGetFingerQualityListener_;
		}

		static void n_GetFingerQuality_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_OnGetFingerQualityListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bitmap, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bitmap = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_bitmap, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Credenceid.Biometrics.IBiometricsOnGetFingerQualityListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnGetFingerQualityListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.GetFingerQuality (bitmap, listener);
		}
#pragma warning restore 0169

		static IntPtr id_getFingerQuality_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_OnGetFingerQualityListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='getFingerQuality' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='com.credenceid.biometrics.Biometrics.OnGetFingerQualityListener']]"
		[Register ("getFingerQuality", "(Landroid/graphics/Bitmap;Lcom/credenceid/biometrics/Biometrics$OnGetFingerQualityListener;)V", "GetGetFingerQuality_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_OnGetFingerQualityListener_Handler")]
		public virtual unsafe void GetFingerQuality (global::Android.Graphics.Bitmap bitmap, global::Com.Credenceid.Biometrics.IBiometricsOnGetFingerQualityListener listener)
		{
			if (id_getFingerQuality_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_OnGetFingerQualityListener_ == IntPtr.Zero)
				id_getFingerQuality_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_OnGetFingerQualityListener_ = JNIEnv.GetMethodID (class_ref, "getFingerQuality", "(Landroid/graphics/Bitmap;Lcom/credenceid/biometrics/Biometrics$OnGetFingerQualityListener;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (bitmap);
				__args [1] = new JValue (listener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getFingerQuality_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_OnGetFingerQualityListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFingerQuality", "(Landroid/graphics/Bitmap;Lcom/credenceid/biometrics/Biometrics$OnGetFingerQualityListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getFingerQuality_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_OnFingerQualityListener_;
#pragma warning disable 0169
		static Delegate GetGetFingerQuality_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_OnFingerQualityListener_Handler ()
		{
			if (cb_getFingerQuality_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_OnFingerQualityListener_ == null)
				cb_getFingerQuality_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_OnFingerQualityListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_GetFingerQuality_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_OnFingerQualityListener_);
			return cb_getFingerQuality_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_OnFingerQualityListener_;
		}

		static void n_GetFingerQuality_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_OnFingerQualityListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_absFilePath, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var absFilePath = JNIEnv.GetString (native_absFilePath, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Credenceid.Biometrics.IBiometricsOnFingerQualityListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnFingerQualityListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.GetFingerQuality (absFilePath, listener);
		}
#pragma warning restore 0169

		static IntPtr id_getFingerQuality_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_OnFingerQualityListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='getFingerQuality' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.credenceid.biometrics.Biometrics.OnFingerQualityListener']]"
		[Register ("getFingerQuality", "(Ljava/lang/String;Lcom/credenceid/biometrics/Biometrics$OnFingerQualityListener;)V", "GetGetFingerQuality_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_OnFingerQualityListener_Handler")]
		public virtual unsafe void GetFingerQuality (string absFilePath, global::Com.Credenceid.Biometrics.IBiometricsOnFingerQualityListener listener)
		{
			if (id_getFingerQuality_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_OnFingerQualityListener_ == IntPtr.Zero)
				id_getFingerQuality_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_OnFingerQualityListener_ = JNIEnv.GetMethodID (class_ref, "getFingerQuality", "(Ljava/lang/String;Lcom/credenceid/biometrics/Biometrics$OnFingerQualityListener;)V");
			IntPtr native_absFilePath = JNIEnv.NewString (absFilePath);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_absFilePath);
				__args [1] = new JValue (listener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getFingerQuality_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_OnFingerQualityListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFingerQuality", "(Ljava/lang/String;Lcom/credenceid/biometrics/Biometrics$OnFingerQualityListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_absFilePath);
			}
		}

		static Delegate cb_getPreferences_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_PreferencesListener_;
#pragma warning disable 0169
		static Delegate GetGetPreferences_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_PreferencesListener_Handler ()
		{
			if (cb_getPreferences_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_PreferencesListener_ == null)
				cb_getPreferences_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_PreferencesListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_GetPreferences_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_PreferencesListener_);
			return cb_getPreferences_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_PreferencesListener_;
		}

		static void n_GetPreferences_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_PreferencesListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Credenceid.Biometrics.IBiometricsPreferencesListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsPreferencesListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.GetPreferences (key, listener);
		}
#pragma warning restore 0169

		static IntPtr id_getPreferences_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_PreferencesListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='getPreferences' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.credenceid.biometrics.Biometrics.PreferencesListener']]"
		[Register ("getPreferences", "(Ljava/lang/String;Lcom/credenceid/biometrics/Biometrics$PreferencesListener;)V", "GetGetPreferences_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_PreferencesListener_Handler")]
		public virtual unsafe void GetPreferences (string key, global::Com.Credenceid.Biometrics.IBiometricsPreferencesListener listener)
		{
			if (id_getPreferences_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_PreferencesListener_ == IntPtr.Zero)
				id_getPreferences_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_PreferencesListener_ = JNIEnv.GetMethodID (class_ref, "getPreferences", "(Ljava/lang/String;Lcom/credenceid/biometrics/Biometrics$PreferencesListener;)V");
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (listener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getPreferences_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_PreferencesListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPreferences", "(Ljava/lang/String;Lcom/credenceid/biometrics/Biometrics$PreferencesListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_getProviderDetails_Lcom_credenceid_biometrics_Biometrics_OnGetProviderDetailsListener_;
#pragma warning disable 0169
		static Delegate GetGetProviderDetails_Lcom_credenceid_biometrics_Biometrics_OnGetProviderDetailsListener_Handler ()
		{
			if (cb_getProviderDetails_Lcom_credenceid_biometrics_Biometrics_OnGetProviderDetailsListener_ == null)
				cb_getProviderDetails_Lcom_credenceid_biometrics_Biometrics_OnGetProviderDetailsListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_GetProviderDetails_Lcom_credenceid_biometrics_Biometrics_OnGetProviderDetailsListener_);
			return cb_getProviderDetails_Lcom_credenceid_biometrics_Biometrics_OnGetProviderDetailsListener_;
		}

		static void n_GetProviderDetails_Lcom_credenceid_biometrics_Biometrics_OnGetProviderDetailsListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Credenceid.Biometrics.IBiometricsOnGetProviderDetailsListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnGetProviderDetailsListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.GetProviderDetails (listener);
		}
#pragma warning restore 0169

		static IntPtr id_getProviderDetails_Lcom_credenceid_biometrics_Biometrics_OnGetProviderDetailsListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='getProviderDetails' and count(parameter)=1 and parameter[1][@type='com.credenceid.biometrics.Biometrics.OnGetProviderDetailsListener']]"
		[Register ("getProviderDetails", "(Lcom/credenceid/biometrics/Biometrics$OnGetProviderDetailsListener;)V", "GetGetProviderDetails_Lcom_credenceid_biometrics_Biometrics_OnGetProviderDetailsListener_Handler")]
		public virtual unsafe void GetProviderDetails (global::Com.Credenceid.Biometrics.IBiometricsOnGetProviderDetailsListener listener)
		{
			if (id_getProviderDetails_Lcom_credenceid_biometrics_Biometrics_OnGetProviderDetailsListener_ == IntPtr.Zero)
				id_getProviderDetails_Lcom_credenceid_biometrics_Biometrics_OnGetProviderDetailsListener_ = JNIEnv.GetMethodID (class_ref, "getProviderDetails", "(Lcom/credenceid/biometrics/Biometrics$OnGetProviderDetailsListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (listener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getProviderDetails_Lcom_credenceid_biometrics_Biometrics_OnGetProviderDetailsListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getProviderDetails", "(Lcom/credenceid/biometrics/Biometrics$OnGetProviderDetailsListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedFullListener_;
#pragma warning disable 0169
		static Delegate GetGrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedFullListener_Handler ()
		{
			if (cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedFullListener_ == null)
				cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedFullListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZL_V) n_GrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedFullListener_);
			return cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedFullListener_;
		}

		static void n_GrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedFullListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_scanType, bool saveToDisk, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var scanType = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsScanType> (native_scanType, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedFullListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedFullListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.GrabFingerprint (scanType, saveToDisk, listener);
		}
#pragma warning restore 0169

		static IntPtr id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedFullListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='grabFingerprint' and count(parameter)=3 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ScanType'] and parameter[2][@type='boolean'] and parameter[3][@type='com.credenceid.biometrics.Biometrics.OnFingerprintGrabbedFullListener']]"
		[Register ("grabFingerprint", "(Lcom/credenceid/biometrics/Biometrics$ScanType;ZLcom/credenceid/biometrics/Biometrics$OnFingerprintGrabbedFullListener;)V", "GetGrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedFullListener_Handler")]
		public virtual unsafe void GrabFingerprint (global::Com.Credenceid.Biometrics.BiometricsScanType scanType, bool saveToDisk, global::Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedFullListener listener)
		{
			if (id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedFullListener_ == IntPtr.Zero)
				id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedFullListener_ = JNIEnv.GetMethodID (class_ref, "grabFingerprint", "(Lcom/credenceid/biometrics/Biometrics$ScanType;ZLcom/credenceid/biometrics/Biometrics$OnFingerprintGrabbedFullListener;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (scanType);
				__args [1] = new JValue (saveToDisk);
				__args [2] = new JValue (listener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedFullListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "grabFingerprint", "(Lcom/credenceid/biometrics/Biometrics$ScanType;ZLcom/credenceid/biometrics/Biometrics$OnFingerprintGrabbedFullListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedListener_;
#pragma warning disable 0169
		static Delegate GetGrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedListener_Handler ()
		{
			if (cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedListener_ == null)
				cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZL_V) n_GrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedListener_);
			return cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedListener_;
		}

		static void n_GrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_scanType, bool saveToDisk, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var scanType = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsScanType> (native_scanType, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.GrabFingerprint (scanType, saveToDisk, listener);
		}
#pragma warning restore 0169

		static IntPtr id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='grabFingerprint' and count(parameter)=3 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ScanType'] and parameter[2][@type='boolean'] and parameter[3][@type='com.credenceid.biometrics.Biometrics.OnFingerprintGrabbedListener']]"
		[Register ("grabFingerprint", "(Lcom/credenceid/biometrics/Biometrics$ScanType;ZLcom/credenceid/biometrics/Biometrics$OnFingerprintGrabbedListener;)V", "GetGrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedListener_Handler")]
		public virtual unsafe void GrabFingerprint (global::Com.Credenceid.Biometrics.BiometricsScanType scanType, bool saveToDisk, global::Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedListener listener)
		{
			if (id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedListener_ == IntPtr.Zero)
				id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedListener_ = JNIEnv.GetMethodID (class_ref, "grabFingerprint", "(Lcom/credenceid/biometrics/Biometrics$ScanType;ZLcom/credenceid/biometrics/Biometrics$OnFingerprintGrabbedListener;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (scanType);
				__args [1] = new JValue (saveToDisk);
				__args [2] = new JValue (listener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "grabFingerprint", "(Lcom/credenceid/biometrics/Biometrics$ScanType;ZLcom/credenceid/biometrics/Biometrics$OnFingerprintGrabbedListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedRawListener_;
#pragma warning disable 0169
		static Delegate GetGrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedRawListener_Handler ()
		{
			if (cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedRawListener_ == null)
				cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedRawListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZL_V) n_GrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedRawListener_);
			return cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedRawListener_;
		}

		static void n_GrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedRawListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_scanType, bool saveToDisk, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var scanType = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsScanType> (native_scanType, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedRawListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedRawListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.GrabFingerprint (scanType, saveToDisk, listener);
		}
#pragma warning restore 0169

		static IntPtr id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedRawListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='grabFingerprint' and count(parameter)=3 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ScanType'] and parameter[2][@type='boolean'] and parameter[3][@type='com.credenceid.biometrics.Biometrics.OnFingerprintGrabbedRawListener']]"
		[Register ("grabFingerprint", "(Lcom/credenceid/biometrics/Biometrics$ScanType;ZLcom/credenceid/biometrics/Biometrics$OnFingerprintGrabbedRawListener;)V", "GetGrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedRawListener_Handler")]
		public virtual unsafe void GrabFingerprint (global::Com.Credenceid.Biometrics.BiometricsScanType scanType, bool saveToDisk, global::Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedRawListener listener)
		{
			if (id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedRawListener_ == IntPtr.Zero)
				id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedRawListener_ = JNIEnv.GetMethodID (class_ref, "grabFingerprint", "(Lcom/credenceid/biometrics/Biometrics$ScanType;ZLcom/credenceid/biometrics/Biometrics$OnFingerprintGrabbedRawListener;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (scanType);
				__args [1] = new JValue (saveToDisk);
				__args [2] = new JValue (listener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedRawListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "grabFingerprint", "(Lcom/credenceid/biometrics/Biometrics$ScanType;ZLcom/credenceid/biometrics/Biometrics$OnFingerprintGrabbedRawListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedWSQListener_;
#pragma warning disable 0169
		static Delegate GetGrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedWSQListener_Handler ()
		{
			if (cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedWSQListener_ == null)
				cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedWSQListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZL_V) n_GrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedWSQListener_);
			return cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedWSQListener_;
		}

		static void n_GrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedWSQListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_scanType, bool saveToDisk, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var scanType = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsScanType> (native_scanType, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedWSQListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedWSQListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.GrabFingerprint (scanType, saveToDisk, listener);
		}
#pragma warning restore 0169

		static IntPtr id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedWSQListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='grabFingerprint' and count(parameter)=3 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ScanType'] and parameter[2][@type='boolean'] and parameter[3][@type='com.credenceid.biometrics.Biometrics.OnFingerprintGrabbedWSQListener']]"
		[Register ("grabFingerprint", "(Lcom/credenceid/biometrics/Biometrics$ScanType;ZLcom/credenceid/biometrics/Biometrics$OnFingerprintGrabbedWSQListener;)V", "GetGrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedWSQListener_Handler")]
		public virtual unsafe void GrabFingerprint (global::Com.Credenceid.Biometrics.BiometricsScanType scanType, bool saveToDisk, global::Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedWSQListener listener)
		{
			if (id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedWSQListener_ == IntPtr.Zero)
				id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedWSQListener_ = JNIEnv.GetMethodID (class_ref, "grabFingerprint", "(Lcom/credenceid/biometrics/Biometrics$ScanType;ZLcom/credenceid/biometrics/Biometrics$OnFingerprintGrabbedWSQListener;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (scanType);
				__args [1] = new JValue (saveToDisk);
				__args [2] = new JValue (listener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedWSQListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "grabFingerprint", "(Lcom/credenceid/biometrics/Biometrics$ScanType;ZLcom/credenceid/biometrics/Biometrics$OnFingerprintGrabbedWSQListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnMultiFingerprintGrabbedListener_;
#pragma warning disable 0169
		static Delegate GetGrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnMultiFingerprintGrabbedListener_Handler ()
		{
			if (cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnMultiFingerprintGrabbedListener_ == null)
				cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnMultiFingerprintGrabbedListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZL_V) n_GrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnMultiFingerprintGrabbedListener_);
			return cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnMultiFingerprintGrabbedListener_;
		}

		static void n_GrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnMultiFingerprintGrabbedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_scanType, bool saveToDisk, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var scanType = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsScanType> (native_scanType, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Credenceid.Biometrics.IBiometricsOnMultiFingerprintGrabbedListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnMultiFingerprintGrabbedListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.GrabFingerprint (scanType, saveToDisk, listener);
		}
#pragma warning restore 0169

		static IntPtr id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnMultiFingerprintGrabbedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='grabFingerprint' and count(parameter)=3 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ScanType'] and parameter[2][@type='boolean'] and parameter[3][@type='com.credenceid.biometrics.Biometrics.OnMultiFingerprintGrabbedListener']]"
		[Register ("grabFingerprint", "(Lcom/credenceid/biometrics/Biometrics$ScanType;ZLcom/credenceid/biometrics/Biometrics$OnMultiFingerprintGrabbedListener;)V", "GetGrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnMultiFingerprintGrabbedListener_Handler")]
		public virtual unsafe void GrabFingerprint (global::Com.Credenceid.Biometrics.BiometricsScanType scanType, bool saveToDisk, global::Com.Credenceid.Biometrics.IBiometricsOnMultiFingerprintGrabbedListener listener)
		{
			if (id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnMultiFingerprintGrabbedListener_ == IntPtr.Zero)
				id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnMultiFingerprintGrabbedListener_ = JNIEnv.GetMethodID (class_ref, "grabFingerprint", "(Lcom/credenceid/biometrics/Biometrics$ScanType;ZLcom/credenceid/biometrics/Biometrics$OnMultiFingerprintGrabbedListener;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (scanType);
				__args [1] = new JValue (saveToDisk);
				__args [2] = new JValue (listener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnMultiFingerprintGrabbedListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "grabFingerprint", "(Lcom/credenceid/biometrics/Biometrics$ScanType;ZLcom/credenceid/biometrics/Biometrics$OnMultiFingerprintGrabbedListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedFullListener_;
#pragma warning disable 0169
		static Delegate GetGrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedFullListener_Handler ()
		{
			if (cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedFullListener_ == null)
				cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedFullListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_GrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedFullListener_);
			return cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedFullListener_;
		}

		static void n_GrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedFullListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_scanType, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var scanType = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsScanType> (native_scanType, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedFullListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedFullListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.GrabFingerprint (scanType, listener);
		}
#pragma warning restore 0169

		static IntPtr id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedFullListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='grabFingerprint' and count(parameter)=2 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ScanType'] and parameter[2][@type='com.credenceid.biometrics.Biometrics.OnFingerprintGrabbedFullListener']]"
		[Register ("grabFingerprint", "(Lcom/credenceid/biometrics/Biometrics$ScanType;Lcom/credenceid/biometrics/Biometrics$OnFingerprintGrabbedFullListener;)V", "GetGrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedFullListener_Handler")]
		public virtual unsafe void GrabFingerprint (global::Com.Credenceid.Biometrics.BiometricsScanType scanType, global::Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedFullListener listener)
		{
			if (id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedFullListener_ == IntPtr.Zero)
				id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedFullListener_ = JNIEnv.GetMethodID (class_ref, "grabFingerprint", "(Lcom/credenceid/biometrics/Biometrics$ScanType;Lcom/credenceid/biometrics/Biometrics$OnFingerprintGrabbedFullListener;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (scanType);
				__args [1] = new JValue (listener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedFullListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "grabFingerprint", "(Lcom/credenceid/biometrics/Biometrics$ScanType;Lcom/credenceid/biometrics/Biometrics$OnFingerprintGrabbedFullListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedListener_;
#pragma warning disable 0169
		static Delegate GetGrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedListener_Handler ()
		{
			if (cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedListener_ == null)
				cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_GrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedListener_);
			return cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedListener_;
		}

		static void n_GrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_scanType, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var scanType = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsScanType> (native_scanType, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.GrabFingerprint (scanType, listener);
		}
#pragma warning restore 0169

		static IntPtr id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='grabFingerprint' and count(parameter)=2 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ScanType'] and parameter[2][@type='com.credenceid.biometrics.Biometrics.OnFingerprintGrabbedListener']]"
		[Register ("grabFingerprint", "(Lcom/credenceid/biometrics/Biometrics$ScanType;Lcom/credenceid/biometrics/Biometrics$OnFingerprintGrabbedListener;)V", "GetGrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedListener_Handler")]
		public virtual unsafe void GrabFingerprint (global::Com.Credenceid.Biometrics.BiometricsScanType scanType, global::Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedListener listener)
		{
			if (id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedListener_ == IntPtr.Zero)
				id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedListener_ = JNIEnv.GetMethodID (class_ref, "grabFingerprint", "(Lcom/credenceid/biometrics/Biometrics$ScanType;Lcom/credenceid/biometrics/Biometrics$OnFingerprintGrabbedListener;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (scanType);
				__args [1] = new JValue (listener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "grabFingerprint", "(Lcom/credenceid/biometrics/Biometrics$ScanType;Lcom/credenceid/biometrics/Biometrics$OnFingerprintGrabbedListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedWSQListener_;
#pragma warning disable 0169
		static Delegate GetGrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedWSQListener_Handler ()
		{
			if (cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedWSQListener_ == null)
				cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedWSQListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_GrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedWSQListener_);
			return cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedWSQListener_;
		}

		static void n_GrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedWSQListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_scanType, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var scanType = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsScanType> (native_scanType, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedWSQListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedWSQListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.GrabFingerprint (scanType, listener);
		}
#pragma warning restore 0169

		static IntPtr id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedWSQListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='grabFingerprint' and count(parameter)=2 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ScanType'] and parameter[2][@type='com.credenceid.biometrics.Biometrics.OnFingerprintGrabbedWSQListener']]"
		[Register ("grabFingerprint", "(Lcom/credenceid/biometrics/Biometrics$ScanType;Lcom/credenceid/biometrics/Biometrics$OnFingerprintGrabbedWSQListener;)V", "GetGrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedWSQListener_Handler")]
		public virtual unsafe void GrabFingerprint (global::Com.Credenceid.Biometrics.BiometricsScanType scanType, global::Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedWSQListener listener)
		{
			if (id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedWSQListener_ == IntPtr.Zero)
				id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedWSQListener_ = JNIEnv.GetMethodID (class_ref, "grabFingerprint", "(Lcom/credenceid/biometrics/Biometrics$ScanType;Lcom/credenceid/biometrics/Biometrics$OnFingerprintGrabbedWSQListener;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (scanType);
				__args [1] = new JValue (listener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedWSQListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "grabFingerprint", "(Lcom/credenceid/biometrics/Biometrics$ScanType;Lcom/credenceid/biometrics/Biometrics$OnFingerprintGrabbedWSQListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_grabFingerprintSync_I;
#pragma warning disable 0169
		static Delegate GetGrabFingerprintSync_IHandler ()
		{
			if (cb_grabFingerprintSync_I == null)
				cb_grabFingerprintSync_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_GrabFingerprintSync_I);
			return cb_grabFingerprintSync_I;
		}

		static IntPtr n_GrabFingerprintSync_I (IntPtr jnienv, IntPtr native__this, int timeout)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GrabFingerprintSync (timeout));
		}
#pragma warning restore 0169

		static IntPtr id_grabFingerprintSync_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='grabFingerprintSync' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("grabFingerprintSync", "(I)Lcom/credenceid/biometrics/FingerprintSyncResponse;", "GetGrabFingerprintSync_IHandler")]
		public virtual unsafe global::Com.Credenceid.Biometrics.FingerprintSyncResponse GrabFingerprintSync (int timeout)
		{
			if (id_grabFingerprintSync_I == IntPtr.Zero)
				id_grabFingerprintSync_I = JNIEnv.GetMethodID (class_ref, "grabFingerprintSync", "(I)Lcom/credenceid/biometrics/FingerprintSyncResponse;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (timeout);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.FingerprintSyncResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_grabFingerprintSync_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.FingerprintSyncResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "grabFingerprintSync", "(I)Lcom/credenceid/biometrics/FingerprintSyncResponse;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_initializeBiometrics_Lcom_credenceid_biometrics_Biometrics_OnInitializedListener_;
#pragma warning disable 0169
		static Delegate GetInitializeBiometrics_Lcom_credenceid_biometrics_Biometrics_OnInitializedListener_Handler ()
		{
			if (cb_initializeBiometrics_Lcom_credenceid_biometrics_Biometrics_OnInitializedListener_ == null)
				cb_initializeBiometrics_Lcom_credenceid_biometrics_Biometrics_OnInitializedListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_InitializeBiometrics_Lcom_credenceid_biometrics_Biometrics_OnInitializedListener_);
			return cb_initializeBiometrics_Lcom_credenceid_biometrics_Biometrics_OnInitializedListener_;
		}

		static void n_InitializeBiometrics_Lcom_credenceid_biometrics_Biometrics_OnInitializedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Credenceid.Biometrics.IBiometricsOnInitializedListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnInitializedListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.InitializeBiometrics (listener);
		}
#pragma warning restore 0169

		static IntPtr id_initializeBiometrics_Lcom_credenceid_biometrics_Biometrics_OnInitializedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='initializeBiometrics' and count(parameter)=1 and parameter[1][@type='com.credenceid.biometrics.Biometrics.OnInitializedListener']]"
		[Register ("initializeBiometrics", "(Lcom/credenceid/biometrics/Biometrics$OnInitializedListener;)V", "GetInitializeBiometrics_Lcom_credenceid_biometrics_Biometrics_OnInitializedListener_Handler")]
		public virtual unsafe void InitializeBiometrics (global::Com.Credenceid.Biometrics.IBiometricsOnInitializedListener listener)
		{
			if (id_initializeBiometrics_Lcom_credenceid_biometrics_Biometrics_OnInitializedListener_ == IntPtr.Zero)
				id_initializeBiometrics_Lcom_credenceid_biometrics_Biometrics_OnInitializedListener_ = JNIEnv.GetMethodID (class_ref, "initializeBiometrics", "(Lcom/credenceid/biometrics/Biometrics$OnInitializedListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (listener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initializeBiometrics_Lcom_credenceid_biometrics_Biometrics_OnInitializedListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initializeBiometrics", "(Lcom/credenceid/biometrics/Biometrics$OnInitializedListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_match_Lcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnMatchCallback_;
#pragma warning disable 0169
		static Delegate GetMatch_Lcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnMatchCallback_Handler ()
		{
			if (cb_match_Lcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnMatchCallback_ == null)
				cb_match_Lcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnMatchCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_Match_Lcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnMatchCallback_);
			return cb_match_Lcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnMatchCallback_;
		}

		static void n_Match_Lcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnMatchCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_finger, IntPtr native_face, IntPtr native_iris, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var finger = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.FingerprintRecord> (native_finger, JniHandleOwnership.DoNotTransfer);
			var face = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.FaceRecord> (native_face, JniHandleOwnership.DoNotTransfer);
			var iris = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.IrisRecord> (native_iris, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Com.Credenceid.Database.IBiometricDatabaseOnMatchCallback)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.IBiometricDatabaseOnMatchCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.Match (finger, face, iris, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_match_Lcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnMatchCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='match' and count(parameter)=4 and parameter[1][@type='com.credenceid.database.FingerprintRecord'] and parameter[2][@type='com.credenceid.database.FaceRecord'] and parameter[3][@type='com.credenceid.database.IrisRecord'] and parameter[4][@type='com.credenceid.database.BiometricDatabase.OnMatchCallback']]"
		[Register ("match", "(Lcom/credenceid/database/FingerprintRecord;Lcom/credenceid/database/FaceRecord;Lcom/credenceid/database/IrisRecord;Lcom/credenceid/database/BiometricDatabase$OnMatchCallback;)V", "GetMatch_Lcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnMatchCallback_Handler")]
		public virtual unsafe void Match (global::Com.Credenceid.Database.FingerprintRecord finger, global::Com.Credenceid.Database.FaceRecord face, global::Com.Credenceid.Database.IrisRecord iris, global::Com.Credenceid.Database.IBiometricDatabaseOnMatchCallback @callback)
		{
			if (id_match_Lcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnMatchCallback_ == IntPtr.Zero)
				id_match_Lcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnMatchCallback_ = JNIEnv.GetMethodID (class_ref, "match", "(Lcom/credenceid/database/FingerprintRecord;Lcom/credenceid/database/FaceRecord;Lcom/credenceid/database/IrisRecord;Lcom/credenceid/database/BiometricDatabase$OnMatchCallback;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (finger);
				__args [1] = new JValue (face);
				__args [2] = new JValue (iris);
				__args [3] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_match_Lcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnMatchCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "match", "(Lcom/credenceid/database/FingerprintRecord;Lcom/credenceid/database/FaceRecord;Lcom/credenceid/database/IrisRecord;Lcom/credenceid/database/BiometricDatabase$OnMatchCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_match_arrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnMatchCallback_;
#pragma warning disable 0169
		static Delegate GetMatch_arrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnMatchCallback_Handler ()
		{
			if (cb_match_arrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnMatchCallback_ == null)
				cb_match_arrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnMatchCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_Match_arrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnMatchCallback_);
			return cb_match_arrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnMatchCallback_;
		}

		static void n_Match_arrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnMatchCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fingers, IntPtr native_face, IntPtr native_irises, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fingers = (global::Com.Credenceid.Database.FingerprintRecord[]) JNIEnv.GetArray (native_fingers, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Credenceid.Database.FingerprintRecord));
			var face = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.FaceRecord> (native_face, JniHandleOwnership.DoNotTransfer);
			var irises = (global::Com.Credenceid.Database.IrisRecord[]) JNIEnv.GetArray (native_irises, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Credenceid.Database.IrisRecord));
			var @callback = (global::Com.Credenceid.Database.IBiometricDatabaseOnMatchCallback)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.IBiometricDatabaseOnMatchCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.Match (fingers, face, irises, @callback);
			if (fingers != null)
				JNIEnv.CopyArray (fingers, native_fingers);
			if (irises != null)
				JNIEnv.CopyArray (irises, native_irises);
		}
#pragma warning restore 0169

		static IntPtr id_match_arrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnMatchCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='match' and count(parameter)=4 and parameter[1][@type='com.credenceid.database.FingerprintRecord[]'] and parameter[2][@type='com.credenceid.database.FaceRecord'] and parameter[3][@type='com.credenceid.database.IrisRecord[]'] and parameter[4][@type='com.credenceid.database.BiometricDatabase.OnMatchCallback']]"
		[Register ("match", "([Lcom/credenceid/database/FingerprintRecord;Lcom/credenceid/database/FaceRecord;[Lcom/credenceid/database/IrisRecord;Lcom/credenceid/database/BiometricDatabase$OnMatchCallback;)V", "GetMatch_arrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnMatchCallback_Handler")]
		public virtual unsafe void Match (global::Com.Credenceid.Database.FingerprintRecord[] fingers, global::Com.Credenceid.Database.FaceRecord face, global::Com.Credenceid.Database.IrisRecord[] irises, global::Com.Credenceid.Database.IBiometricDatabaseOnMatchCallback @callback)
		{
			if (id_match_arrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnMatchCallback_ == IntPtr.Zero)
				id_match_arrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnMatchCallback_ = JNIEnv.GetMethodID (class_ref, "match", "([Lcom/credenceid/database/FingerprintRecord;Lcom/credenceid/database/FaceRecord;[Lcom/credenceid/database/IrisRecord;Lcom/credenceid/database/BiometricDatabase$OnMatchCallback;)V");
			IntPtr native_fingers = JNIEnv.NewArray (fingers);
			IntPtr native_irises = JNIEnv.NewArray (irises);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_fingers);
				__args [1] = new JValue (face);
				__args [2] = new JValue (native_irises);
				__args [3] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_match_arrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnMatchCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "match", "([Lcom/credenceid/database/FingerprintRecord;Lcom/credenceid/database/FaceRecord;[Lcom/credenceid/database/IrisRecord;Lcom/credenceid/database/BiometricDatabase$OnMatchCallback;)V"), __args);
			} finally {
				if (fingers != null) {
					JNIEnv.CopyArray (native_fingers, fingers);
					JNIEnv.DeleteLocalRef (native_fingers);
				}
				if (irises != null) {
					JNIEnv.CopyArray (native_irises, irises);
					JNIEnv.DeleteLocalRef (native_irises);
				}
			}
		}

		static Delegate cb_onActivityResult_IILandroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnActivityResult_IILandroid_content_Intent_Handler ()
		{
			if (cb_onActivityResult_IILandroid_content_Intent_ == null)
				cb_onActivityResult_IILandroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIL_V) n_OnActivityResult_IILandroid_content_Intent_);
			return cb_onActivityResult_IILandroid_content_Intent_;
		}

		static void n_OnActivityResult_IILandroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, int requestCode, int resultCode, IntPtr native_data)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var data = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_data, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityResult (requestCode, resultCode, data);
		}
#pragma warning restore 0169

		static IntPtr id_onActivityResult_IILandroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='onActivityResult' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.content.Intent']]"
		[Register ("onActivityResult", "(IILandroid/content/Intent;)V", "GetOnActivityResult_IILandroid_content_Intent_Handler")]
		public virtual unsafe void OnActivityResult (int requestCode, int resultCode, global::Android.Content.Intent data)
		{
			if (id_onActivityResult_IILandroid_content_Intent_ == IntPtr.Zero)
				id_onActivityResult_IILandroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onActivityResult", "(IILandroid/content/Intent;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (requestCode);
				__args [1] = new JValue (resultCode);
				__args [2] = new JValue (data);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onActivityResult_IILandroid_content_Intent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onActivityResult", "(IILandroid/content/Intent;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_openFingerprintReader_Lcom_credenceid_biometrics_Biometrics_FingerprintReaderStatusListener_;
#pragma warning disable 0169
		static Delegate GetOpenFingerprintReader_Lcom_credenceid_biometrics_Biometrics_FingerprintReaderStatusListener_Handler ()
		{
			if (cb_openFingerprintReader_Lcom_credenceid_biometrics_Biometrics_FingerprintReaderStatusListener_ == null)
				cb_openFingerprintReader_Lcom_credenceid_biometrics_Biometrics_FingerprintReaderStatusListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OpenFingerprintReader_Lcom_credenceid_biometrics_Biometrics_FingerprintReaderStatusListener_);
			return cb_openFingerprintReader_Lcom_credenceid_biometrics_Biometrics_FingerprintReaderStatusListener_;
		}

		static void n_OpenFingerprintReader_Lcom_credenceid_biometrics_Biometrics_FingerprintReaderStatusListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Credenceid.Biometrics.IBiometricsFingerprintReaderStatusListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsFingerprintReaderStatusListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.OpenFingerprintReader (listener);
		}
#pragma warning restore 0169

		static IntPtr id_openFingerprintReader_Lcom_credenceid_biometrics_Biometrics_FingerprintReaderStatusListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='openFingerprintReader' and count(parameter)=1 and parameter[1][@type='com.credenceid.biometrics.Biometrics.FingerprintReaderStatusListener']]"
		[Register ("openFingerprintReader", "(Lcom/credenceid/biometrics/Biometrics$FingerprintReaderStatusListener;)V", "GetOpenFingerprintReader_Lcom_credenceid_biometrics_Biometrics_FingerprintReaderStatusListener_Handler")]
		public virtual unsafe void OpenFingerprintReader (global::Com.Credenceid.Biometrics.IBiometricsFingerprintReaderStatusListener listener)
		{
			if (id_openFingerprintReader_Lcom_credenceid_biometrics_Biometrics_FingerprintReaderStatusListener_ == IntPtr.Zero)
				id_openFingerprintReader_Lcom_credenceid_biometrics_Biometrics_FingerprintReaderStatusListener_ = JNIEnv.GetMethodID (class_ref, "openFingerprintReader", "(Lcom/credenceid/biometrics/Biometrics$FingerprintReaderStatusListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (listener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_openFingerprintReader_Lcom_credenceid_biometrics_Biometrics_FingerprintReaderStatusListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "openFingerprintReader", "(Lcom/credenceid/biometrics/Biometrics$FingerprintReaderStatusListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_openMRZ_Lcom_credenceid_biometrics_Biometrics_MRZStatusListener_;
#pragma warning disable 0169
		static Delegate GetOpenMRZ_Lcom_credenceid_biometrics_Biometrics_MRZStatusListener_Handler ()
		{
			if (cb_openMRZ_Lcom_credenceid_biometrics_Biometrics_MRZStatusListener_ == null)
				cb_openMRZ_Lcom_credenceid_biometrics_Biometrics_MRZStatusListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OpenMRZ_Lcom_credenceid_biometrics_Biometrics_MRZStatusListener_);
			return cb_openMRZ_Lcom_credenceid_biometrics_Biometrics_MRZStatusListener_;
		}

		static void n_OpenMRZ_Lcom_credenceid_biometrics_Biometrics_MRZStatusListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Credenceid.Biometrics.IBiometricsMRZStatusListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsMRZStatusListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.OpenMRZ (listener);
		}
#pragma warning restore 0169

		static IntPtr id_openMRZ_Lcom_credenceid_biometrics_Biometrics_MRZStatusListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='openMRZ' and count(parameter)=1 and parameter[1][@type='com.credenceid.biometrics.Biometrics.MRZStatusListener']]"
		[Register ("openMRZ", "(Lcom/credenceid/biometrics/Biometrics$MRZStatusListener;)V", "GetOpenMRZ_Lcom_credenceid_biometrics_Biometrics_MRZStatusListener_Handler")]
		public virtual unsafe void OpenMRZ (global::Com.Credenceid.Biometrics.IBiometricsMRZStatusListener listener)
		{
			if (id_openMRZ_Lcom_credenceid_biometrics_Biometrics_MRZStatusListener_ == IntPtr.Zero)
				id_openMRZ_Lcom_credenceid_biometrics_Biometrics_MRZStatusListener_ = JNIEnv.GetMethodID (class_ref, "openMRZ", "(Lcom/credenceid/biometrics/Biometrics$MRZStatusListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (listener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_openMRZ_Lcom_credenceid_biometrics_Biometrics_MRZStatusListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "openMRZ", "(Lcom/credenceid/biometrics/Biometrics$MRZStatusListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_read_ILcom_credenceid_database_BiometricDatabase_OnReadCallback_;
#pragma warning disable 0169
		static Delegate GetRead_ILcom_credenceid_database_BiometricDatabase_OnReadCallback_Handler ()
		{
			if (cb_read_ILcom_credenceid_database_BiometricDatabase_OnReadCallback_ == null)
				cb_read_ILcom_credenceid_database_BiometricDatabase_OnReadCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_Read_ILcom_credenceid_database_BiometricDatabase_OnReadCallback_);
			return cb_read_ILcom_credenceid_database_BiometricDatabase_OnReadCallback_;
		}

		static void n_Read_ILcom_credenceid_database_BiometricDatabase_OnReadCallback_ (IntPtr jnienv, IntPtr native__this, int ID, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Com.Credenceid.Database.IBiometricDatabaseOnReadCallback)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.IBiometricDatabaseOnReadCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.Read (ID, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_read_ILcom_credenceid_database_BiometricDatabase_OnReadCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='read' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.credenceid.database.BiometricDatabase.OnReadCallback']]"
		[Register ("read", "(ILcom/credenceid/database/BiometricDatabase$OnReadCallback;)V", "GetRead_ILcom_credenceid_database_BiometricDatabase_OnReadCallback_Handler")]
		public virtual unsafe void Read (int ID, global::Com.Credenceid.Database.IBiometricDatabaseOnReadCallback @callback)
		{
			if (id_read_ILcom_credenceid_database_BiometricDatabase_OnReadCallback_ == IntPtr.Zero)
				id_read_ILcom_credenceid_database_BiometricDatabase_OnReadCallback_ = JNIEnv.GetMethodID (class_ref, "read", "(ILcom/credenceid/database/BiometricDatabase$OnReadCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (ID);
				__args [1] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_read_ILcom_credenceid_database_BiometricDatabase_OnReadCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "read", "(ILcom/credenceid/database/BiometricDatabase$OnReadCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_readICAODocument_Ljava_lang_String_Ljava_lang_String_ZLcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_;
#pragma warning disable 0169
		static Delegate GetReadICAODocument_Ljava_lang_String_Ljava_lang_String_ZLcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_Handler ()
		{
			if (cb_readICAODocument_Ljava_lang_String_Ljava_lang_String_ZLcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_ == null)
				cb_readICAODocument_Ljava_lang_String_Ljava_lang_String_ZLcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLZL_V) n_ReadICAODocument_Ljava_lang_String_Ljava_lang_String_ZLcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_);
			return cb_readICAODocument_Ljava_lang_String_Ljava_lang_String_ZLcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_;
		}

		static void n_ReadICAODocument_Ljava_lang_String_Ljava_lang_String_ZLcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_can, IntPtr native_certificatesPath, bool isEacPerformed, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var can = JNIEnv.GetString (native_can, JniHandleOwnership.DoNotTransfer);
			var certificatesPath = JNIEnv.GetString (native_certificatesPath, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Credenceid.Biometrics.IBiometricsCAODocumentReadListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsCAODocumentReadListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.ReadICAODocument (can, certificatesPath, isEacPerformed, listener);
		}
#pragma warning restore 0169

		static IntPtr id_readICAODocument_Ljava_lang_String_Ljava_lang_String_ZLcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='readICAODocument' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean'] and parameter[4][@type='com.credenceid.biometrics.Biometrics.ICAODocumentReadListener']]"
		[Register ("readICAODocument", "(Ljava/lang/String;Ljava/lang/String;ZLcom/credenceid/biometrics/Biometrics$ICAODocumentReadListener;)V", "GetReadICAODocument_Ljava_lang_String_Ljava_lang_String_ZLcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_Handler")]
		public virtual unsafe void ReadICAODocument (string can, string certificatesPath, bool isEacPerformed, global::Com.Credenceid.Biometrics.IBiometricsCAODocumentReadListener listener)
		{
			if (id_readICAODocument_Ljava_lang_String_Ljava_lang_String_ZLcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_ == IntPtr.Zero)
				id_readICAODocument_Ljava_lang_String_Ljava_lang_String_ZLcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_ = JNIEnv.GetMethodID (class_ref, "readICAODocument", "(Ljava/lang/String;Ljava/lang/String;ZLcom/credenceid/biometrics/Biometrics$ICAODocumentReadListener;)V");
			IntPtr native_can = JNIEnv.NewString (can);
			IntPtr native_certificatesPath = JNIEnv.NewString (certificatesPath);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_can);
				__args [1] = new JValue (native_certificatesPath);
				__args [2] = new JValue (isEacPerformed);
				__args [3] = new JValue (listener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_readICAODocument_Ljava_lang_String_Ljava_lang_String_ZLcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readICAODocument", "(Ljava/lang/String;Ljava/lang/String;ZLcom/credenceid/biometrics/Biometrics$ICAODocumentReadListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_can);
				JNIEnv.DeleteLocalRef (native_certificatesPath);
			}
		}

		static Delegate cb_readICAODocument_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_;
#pragma warning disable 0169
		static Delegate GetReadICAODocument_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_Handler ()
		{
			if (cb_readICAODocument_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_ == null)
				cb_readICAODocument_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_ReadICAODocument_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_);
			return cb_readICAODocument_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_;
		}

		static void n_ReadICAODocument_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dateOfBirth, IntPtr native_documentNumber, IntPtr native_dateOfExpiry, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var dateOfBirth = JNIEnv.GetString (native_dateOfBirth, JniHandleOwnership.DoNotTransfer);
			var documentNumber = JNIEnv.GetString (native_documentNumber, JniHandleOwnership.DoNotTransfer);
			var dateOfExpiry = JNIEnv.GetString (native_dateOfExpiry, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Credenceid.Biometrics.IBiometricsCAODocumentReadListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsCAODocumentReadListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.ReadICAODocument (dateOfBirth, documentNumber, dateOfExpiry, listener);
		}
#pragma warning restore 0169

		static IntPtr id_readICAODocument_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='readICAODocument' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.credenceid.biometrics.Biometrics.ICAODocumentReadListener']]"
		[Register ("readICAODocument", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/credenceid/biometrics/Biometrics$ICAODocumentReadListener;)V", "GetReadICAODocument_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_Handler")]
		public virtual unsafe void ReadICAODocument (string dateOfBirth, string documentNumber, string dateOfExpiry, global::Com.Credenceid.Biometrics.IBiometricsCAODocumentReadListener listener)
		{
			if (id_readICAODocument_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_ == IntPtr.Zero)
				id_readICAODocument_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_ = JNIEnv.GetMethodID (class_ref, "readICAODocument", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/credenceid/biometrics/Biometrics$ICAODocumentReadListener;)V");
			IntPtr native_dateOfBirth = JNIEnv.NewString (dateOfBirth);
			IntPtr native_documentNumber = JNIEnv.NewString (documentNumber);
			IntPtr native_dateOfExpiry = JNIEnv.NewString (dateOfExpiry);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_dateOfBirth);
				__args [1] = new JValue (native_documentNumber);
				__args [2] = new JValue (native_dateOfExpiry);
				__args [3] = new JValue (listener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_readICAODocument_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readICAODocument", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/credenceid/biometrics/Biometrics$ICAODocumentReadListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_dateOfBirth);
				JNIEnv.DeleteLocalRef (native_documentNumber);
				JNIEnv.DeleteLocalRef (native_dateOfExpiry);
			}
		}

		static Delegate cb_readICAODocument_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_;
#pragma warning disable 0169
		static Delegate GetReadICAODocument_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_Handler ()
		{
			if (cb_readICAODocument_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_ == null)
				cb_readICAODocument_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLZL_V) n_ReadICAODocument_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_);
			return cb_readICAODocument_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_;
		}

		static void n_ReadICAODocument_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dateOfBirth, IntPtr native_documentNumber, IntPtr native_dateOfExpiry, IntPtr native_certificatesPath, bool isEacPerformed, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var dateOfBirth = JNIEnv.GetString (native_dateOfBirth, JniHandleOwnership.DoNotTransfer);
			var documentNumber = JNIEnv.GetString (native_documentNumber, JniHandleOwnership.DoNotTransfer);
			var dateOfExpiry = JNIEnv.GetString (native_dateOfExpiry, JniHandleOwnership.DoNotTransfer);
			var certificatesPath = JNIEnv.GetString (native_certificatesPath, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Credenceid.Biometrics.IBiometricsCAODocumentReadListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsCAODocumentReadListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.ReadICAODocument (dateOfBirth, documentNumber, dateOfExpiry, certificatesPath, isEacPerformed, listener);
		}
#pragma warning restore 0169

		static IntPtr id_readICAODocument_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='readICAODocument' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='boolean'] and parameter[6][@type='com.credenceid.biometrics.Biometrics.ICAODocumentReadListener']]"
		[Register ("readICAODocument", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ZLcom/credenceid/biometrics/Biometrics$ICAODocumentReadListener;)V", "GetReadICAODocument_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_Handler")]
		public virtual unsafe void ReadICAODocument (string dateOfBirth, string documentNumber, string dateOfExpiry, string certificatesPath, bool isEacPerformed, global::Com.Credenceid.Biometrics.IBiometricsCAODocumentReadListener listener)
		{
			if (id_readICAODocument_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_ == IntPtr.Zero)
				id_readICAODocument_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_ = JNIEnv.GetMethodID (class_ref, "readICAODocument", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ZLcom/credenceid/biometrics/Biometrics$ICAODocumentReadListener;)V");
			IntPtr native_dateOfBirth = JNIEnv.NewString (dateOfBirth);
			IntPtr native_documentNumber = JNIEnv.NewString (documentNumber);
			IntPtr native_dateOfExpiry = JNIEnv.NewString (dateOfExpiry);
			IntPtr native_certificatesPath = JNIEnv.NewString (certificatesPath);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_dateOfBirth);
				__args [1] = new JValue (native_documentNumber);
				__args [2] = new JValue (native_dateOfExpiry);
				__args [3] = new JValue (native_certificatesPath);
				__args [4] = new JValue (isEacPerformed);
				__args [5] = new JValue (listener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_readICAODocument_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readICAODocument", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ZLcom/credenceid/biometrics/Biometrics$ICAODocumentReadListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_dateOfBirth);
				JNIEnv.DeleteLocalRef (native_documentNumber);
				JNIEnv.DeleteLocalRef (native_dateOfExpiry);
				JNIEnv.DeleteLocalRef (native_certificatesPath);
			}
		}

		static Delegate cb_readMRZ_Lcom_credenceid_biometrics_Biometrics_OnMRZReaderListener_;
#pragma warning disable 0169
		static Delegate GetReadMRZ_Lcom_credenceid_biometrics_Biometrics_OnMRZReaderListener_Handler ()
		{
			if (cb_readMRZ_Lcom_credenceid_biometrics_Biometrics_OnMRZReaderListener_ == null)
				cb_readMRZ_Lcom_credenceid_biometrics_Biometrics_OnMRZReaderListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ReadMRZ_Lcom_credenceid_biometrics_Biometrics_OnMRZReaderListener_);
			return cb_readMRZ_Lcom_credenceid_biometrics_Biometrics_OnMRZReaderListener_;
		}

		static void n_ReadMRZ_Lcom_credenceid_biometrics_Biometrics_OnMRZReaderListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Credenceid.Biometrics.IBiometricsOnMRZReaderListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnMRZReaderListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.ReadMRZ (listener);
		}
#pragma warning restore 0169

		static IntPtr id_readMRZ_Lcom_credenceid_biometrics_Biometrics_OnMRZReaderListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='readMRZ' and count(parameter)=1 and parameter[1][@type='com.credenceid.biometrics.Biometrics.OnMRZReaderListener']]"
		[Register ("readMRZ", "(Lcom/credenceid/biometrics/Biometrics$OnMRZReaderListener;)V", "GetReadMRZ_Lcom_credenceid_biometrics_Biometrics_OnMRZReaderListener_Handler")]
		public virtual unsafe void ReadMRZ (global::Com.Credenceid.Biometrics.IBiometricsOnMRZReaderListener listener)
		{
			if (id_readMRZ_Lcom_credenceid_biometrics_Biometrics_OnMRZReaderListener_ == IntPtr.Zero)
				id_readMRZ_Lcom_credenceid_biometrics_Biometrics_OnMRZReaderListener_ = JNIEnv.GetMethodID (class_ref, "readMRZ", "(Lcom/credenceid/biometrics/Biometrics$OnMRZReaderListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (listener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_readMRZ_Lcom_credenceid_biometrics_Biometrics_OnMRZReaderListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readMRZ", "(Lcom/credenceid/biometrics/Biometrics$OnMRZReaderListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_readSmartCard_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_GIcaoReadListener_;
#pragma warning disable 0169
		static Delegate GetReadSmartCard_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_GIcaoReadListener_Handler ()
		{
			if (cb_readSmartCard_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_GIcaoReadListener_ == null)
				cb_readSmartCard_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_GIcaoReadListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_ReadSmartCard_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_GIcaoReadListener_);
			return cb_readSmartCard_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_GIcaoReadListener_;
		}

		static void n_ReadSmartCard_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_GIcaoReadListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sharedKey, IntPtr native_certificatesPath, IntPtr native_cardProfile, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var sharedKey = JNIEnv.GetString (native_sharedKey, JniHandleOwnership.DoNotTransfer);
			var certificatesPath = JNIEnv.GetString (native_certificatesPath, JniHandleOwnership.DoNotTransfer);
			var cardProfile = JNIEnv.GetString (native_cardProfile, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Credenceid.Biometrics.IBiometricsGIcaoReadListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsGIcaoReadListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.ReadSmartCard (sharedKey, certificatesPath, cardProfile, listener);
		}
#pragma warning restore 0169

		static IntPtr id_readSmartCard_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_GIcaoReadListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='readSmartCard' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.credenceid.biometrics.Biometrics.GIcaoReadListener']]"
		[Register ("readSmartCard", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/credenceid/biometrics/Biometrics$GIcaoReadListener;)V", "GetReadSmartCard_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_GIcaoReadListener_Handler")]
		public virtual unsafe void ReadSmartCard (string sharedKey, string certificatesPath, string cardProfile, global::Com.Credenceid.Biometrics.IBiometricsGIcaoReadListener listener)
		{
			if (id_readSmartCard_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_GIcaoReadListener_ == IntPtr.Zero)
				id_readSmartCard_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_GIcaoReadListener_ = JNIEnv.GetMethodID (class_ref, "readSmartCard", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/credenceid/biometrics/Biometrics$GIcaoReadListener;)V");
			IntPtr native_sharedKey = JNIEnv.NewString (sharedKey);
			IntPtr native_certificatesPath = JNIEnv.NewString (certificatesPath);
			IntPtr native_cardProfile = JNIEnv.NewString (cardProfile);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_sharedKey);
				__args [1] = new JValue (native_certificatesPath);
				__args [2] = new JValue (native_cardProfile);
				__args [3] = new JValue (listener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_readSmartCard_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_GIcaoReadListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readSmartCard", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/credenceid/biometrics/Biometrics$GIcaoReadListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_sharedKey);
				JNIEnv.DeleteLocalRef (native_certificatesPath);
				JNIEnv.DeleteLocalRef (native_cardProfile);
			}
		}

		static Delegate cb_readSmartCard_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_GNIDReadListener_;
#pragma warning disable 0169
		static Delegate GetReadSmartCard_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_GNIDReadListener_Handler ()
		{
			if (cb_readSmartCard_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_GNIDReadListener_ == null)
				cb_readSmartCard_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_GNIDReadListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_ReadSmartCard_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_GNIDReadListener_);
			return cb_readSmartCard_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_GNIDReadListener_;
		}

		static void n_ReadSmartCard_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_GNIDReadListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sharedKey, IntPtr native_certificatesPath, IntPtr native_cardProfile, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var sharedKey = JNIEnv.GetString (native_sharedKey, JniHandleOwnership.DoNotTransfer);
			var certificatesPath = JNIEnv.GetString (native_certificatesPath, JniHandleOwnership.DoNotTransfer);
			var cardProfile = JNIEnv.GetString (native_cardProfile, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Credenceid.Biometrics.IBiometricsGNIDReadListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsGNIDReadListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.ReadSmartCard (sharedKey, certificatesPath, cardProfile, listener);
		}
#pragma warning restore 0169

		static IntPtr id_readSmartCard_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_GNIDReadListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='readSmartCard' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.credenceid.biometrics.Biometrics.GNIDReadListener']]"
		[Register ("readSmartCard", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/credenceid/biometrics/Biometrics$GNIDReadListener;)V", "GetReadSmartCard_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_GNIDReadListener_Handler")]
		public virtual unsafe void ReadSmartCard (string sharedKey, string certificatesPath, string cardProfile, global::Com.Credenceid.Biometrics.IBiometricsGNIDReadListener listener)
		{
			if (id_readSmartCard_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_GNIDReadListener_ == IntPtr.Zero)
				id_readSmartCard_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_GNIDReadListener_ = JNIEnv.GetMethodID (class_ref, "readSmartCard", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/credenceid/biometrics/Biometrics$GNIDReadListener;)V");
			IntPtr native_sharedKey = JNIEnv.NewString (sharedKey);
			IntPtr native_certificatesPath = JNIEnv.NewString (certificatesPath);
			IntPtr native_cardProfile = JNIEnv.NewString (cardProfile);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_sharedKey);
				__args [1] = new JValue (native_certificatesPath);
				__args [2] = new JValue (native_cardProfile);
				__args [3] = new JValue (listener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_readSmartCard_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_GNIDReadListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readSmartCard", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/credenceid/biometrics/Biometrics$GNIDReadListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_sharedKey);
				JNIEnv.DeleteLocalRef (native_certificatesPath);
				JNIEnv.DeleteLocalRef (native_cardProfile);
			}
		}

		static Delegate cb_registerCardStatusListener_Lcom_credenceid_biometrics_Biometrics_OnCardStatusListener_;
#pragma warning disable 0169
		static Delegate GetRegisterCardStatusListener_Lcom_credenceid_biometrics_Biometrics_OnCardStatusListener_Handler ()
		{
			if (cb_registerCardStatusListener_Lcom_credenceid_biometrics_Biometrics_OnCardStatusListener_ == null)
				cb_registerCardStatusListener_Lcom_credenceid_biometrics_Biometrics_OnCardStatusListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RegisterCardStatusListener_Lcom_credenceid_biometrics_Biometrics_OnCardStatusListener_);
			return cb_registerCardStatusListener_Lcom_credenceid_biometrics_Biometrics_OnCardStatusListener_;
		}

		static void n_RegisterCardStatusListener_Lcom_credenceid_biometrics_Biometrics_OnCardStatusListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p = (global::Com.Credenceid.Biometrics.IBiometricsOnCardStatusListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnCardStatusListener> (native_p, JniHandleOwnership.DoNotTransfer);
			__this.RegisterCardStatusListener (p);
		}
#pragma warning restore 0169

		static IntPtr id_registerCardStatusListener_Lcom_credenceid_biometrics_Biometrics_OnCardStatusListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='registerCardStatusListener' and count(parameter)=1 and parameter[1][@type='com.credenceid.biometrics.Biometrics.OnCardStatusListener']]"
		[Register ("registerCardStatusListener", "(Lcom/credenceid/biometrics/Biometrics$OnCardStatusListener;)V", "GetRegisterCardStatusListener_Lcom_credenceid_biometrics_Biometrics_OnCardStatusListener_Handler")]
		public virtual unsafe void RegisterCardStatusListener (global::Com.Credenceid.Biometrics.IBiometricsOnCardStatusListener p)
		{
			if (id_registerCardStatusListener_Lcom_credenceid_biometrics_Biometrics_OnCardStatusListener_ == IntPtr.Zero)
				id_registerCardStatusListener_Lcom_credenceid_biometrics_Biometrics_OnCardStatusListener_ = JNIEnv.GetMethodID (class_ref, "registerCardStatusListener", "(Lcom/credenceid/biometrics/Biometrics$OnCardStatusListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerCardStatusListener_Lcom_credenceid_biometrics_Biometrics_OnCardStatusListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerCardStatusListener", "(Lcom/credenceid/biometrics/Biometrics$OnCardStatusListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_registerEPassportStatusListener_Lcom_credenceid_biometrics_Biometrics_OnEPassportStatusListener_;
#pragma warning disable 0169
		static Delegate GetRegisterEPassportStatusListener_Lcom_credenceid_biometrics_Biometrics_OnEPassportStatusListener_Handler ()
		{
			if (cb_registerEPassportStatusListener_Lcom_credenceid_biometrics_Biometrics_OnEPassportStatusListener_ == null)
				cb_registerEPassportStatusListener_Lcom_credenceid_biometrics_Biometrics_OnEPassportStatusListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RegisterEPassportStatusListener_Lcom_credenceid_biometrics_Biometrics_OnEPassportStatusListener_);
			return cb_registerEPassportStatusListener_Lcom_credenceid_biometrics_Biometrics_OnEPassportStatusListener_;
		}

		static void n_RegisterEPassportStatusListener_Lcom_credenceid_biometrics_Biometrics_OnEPassportStatusListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p = (global::Com.Credenceid.Biometrics.IBiometricsOnEPassportStatusListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnEPassportStatusListener> (native_p, JniHandleOwnership.DoNotTransfer);
			__this.RegisterEPassportStatusListener (p);
		}
#pragma warning restore 0169

		static IntPtr id_registerEPassportStatusListener_Lcom_credenceid_biometrics_Biometrics_OnEPassportStatusListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='registerEPassportStatusListener' and count(parameter)=1 and parameter[1][@type='com.credenceid.biometrics.Biometrics.OnEPassportStatusListener']]"
		[Register ("registerEPassportStatusListener", "(Lcom/credenceid/biometrics/Biometrics$OnEPassportStatusListener;)V", "GetRegisterEPassportStatusListener_Lcom_credenceid_biometrics_Biometrics_OnEPassportStatusListener_Handler")]
		public virtual unsafe void RegisterEPassportStatusListener (global::Com.Credenceid.Biometrics.IBiometricsOnEPassportStatusListener p)
		{
			if (id_registerEPassportStatusListener_Lcom_credenceid_biometrics_Biometrics_OnEPassportStatusListener_ == IntPtr.Zero)
				id_registerEPassportStatusListener_Lcom_credenceid_biometrics_Biometrics_OnEPassportStatusListener_ = JNIEnv.GetMethodID (class_ref, "registerEPassportStatusListener", "(Lcom/credenceid/biometrics/Biometrics$OnEPassportStatusListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerEPassportStatusListener_Lcom_credenceid_biometrics_Biometrics_OnEPassportStatusListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerEPassportStatusListener", "(Lcom/credenceid/biometrics/Biometrics$OnEPassportStatusListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_registerMRZDocumentStatusListener_Lcom_credenceid_biometrics_Biometrics_OnMRZDocumentStatusListener_;
#pragma warning disable 0169
		static Delegate GetRegisterMRZDocumentStatusListener_Lcom_credenceid_biometrics_Biometrics_OnMRZDocumentStatusListener_Handler ()
		{
			if (cb_registerMRZDocumentStatusListener_Lcom_credenceid_biometrics_Biometrics_OnMRZDocumentStatusListener_ == null)
				cb_registerMRZDocumentStatusListener_Lcom_credenceid_biometrics_Biometrics_OnMRZDocumentStatusListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RegisterMRZDocumentStatusListener_Lcom_credenceid_biometrics_Biometrics_OnMRZDocumentStatusListener_);
			return cb_registerMRZDocumentStatusListener_Lcom_credenceid_biometrics_Biometrics_OnMRZDocumentStatusListener_;
		}

		static void n_RegisterMRZDocumentStatusListener_Lcom_credenceid_biometrics_Biometrics_OnMRZDocumentStatusListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p = (global::Com.Credenceid.Biometrics.IBiometricsOnMRZDocumentStatusListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnMRZDocumentStatusListener> (native_p, JniHandleOwnership.DoNotTransfer);
			__this.RegisterMRZDocumentStatusListener (p);
		}
#pragma warning restore 0169

		static IntPtr id_registerMRZDocumentStatusListener_Lcom_credenceid_biometrics_Biometrics_OnMRZDocumentStatusListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='registerMRZDocumentStatusListener' and count(parameter)=1 and parameter[1][@type='com.credenceid.biometrics.Biometrics.OnMRZDocumentStatusListener']]"
		[Register ("registerMRZDocumentStatusListener", "(Lcom/credenceid/biometrics/Biometrics$OnMRZDocumentStatusListener;)V", "GetRegisterMRZDocumentStatusListener_Lcom_credenceid_biometrics_Biometrics_OnMRZDocumentStatusListener_Handler")]
		public virtual unsafe void RegisterMRZDocumentStatusListener (global::Com.Credenceid.Biometrics.IBiometricsOnMRZDocumentStatusListener p)
		{
			if (id_registerMRZDocumentStatusListener_Lcom_credenceid_biometrics_Biometrics_OnMRZDocumentStatusListener_ == IntPtr.Zero)
				id_registerMRZDocumentStatusListener_Lcom_credenceid_biometrics_Biometrics_OnMRZDocumentStatusListener_ = JNIEnv.GetMethodID (class_ref, "registerMRZDocumentStatusListener", "(Lcom/credenceid/biometrics/Biometrics$OnMRZDocumentStatusListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerMRZDocumentStatusListener_Lcom_credenceid_biometrics_Biometrics_OnMRZDocumentStatusListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerMRZDocumentStatusListener", "(Lcom/credenceid/biometrics/Biometrics$OnMRZDocumentStatusListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_registerOnMRZReaderListener_Lcom_credenceid_biometrics_Biometrics_OnMRZReaderListener_;
#pragma warning disable 0169
		static Delegate GetRegisterOnMRZReaderListener_Lcom_credenceid_biometrics_Biometrics_OnMRZReaderListener_Handler ()
		{
			if (cb_registerOnMRZReaderListener_Lcom_credenceid_biometrics_Biometrics_OnMRZReaderListener_ == null)
				cb_registerOnMRZReaderListener_Lcom_credenceid_biometrics_Biometrics_OnMRZReaderListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RegisterOnMRZReaderListener_Lcom_credenceid_biometrics_Biometrics_OnMRZReaderListener_);
			return cb_registerOnMRZReaderListener_Lcom_credenceid_biometrics_Biometrics_OnMRZReaderListener_;
		}

		static void n_RegisterOnMRZReaderListener_Lcom_credenceid_biometrics_Biometrics_OnMRZReaderListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Credenceid.Biometrics.IBiometricsOnMRZReaderListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnMRZReaderListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.RegisterOnMRZReaderListener (listener);
		}
#pragma warning restore 0169

		static IntPtr id_registerOnMRZReaderListener_Lcom_credenceid_biometrics_Biometrics_OnMRZReaderListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='registerOnMRZReaderListener' and count(parameter)=1 and parameter[1][@type='com.credenceid.biometrics.Biometrics.OnMRZReaderListener']]"
		[Register ("registerOnMRZReaderListener", "(Lcom/credenceid/biometrics/Biometrics$OnMRZReaderListener;)V", "GetRegisterOnMRZReaderListener_Lcom_credenceid_biometrics_Biometrics_OnMRZReaderListener_Handler")]
		public virtual unsafe void RegisterOnMRZReaderListener (global::Com.Credenceid.Biometrics.IBiometricsOnMRZReaderListener listener)
		{
			if (id_registerOnMRZReaderListener_Lcom_credenceid_biometrics_Biometrics_OnMRZReaderListener_ == IntPtr.Zero)
				id_registerOnMRZReaderListener_Lcom_credenceid_biometrics_Biometrics_OnMRZReaderListener_ = JNIEnv.GetMethodID (class_ref, "registerOnMRZReaderListener", "(Lcom/credenceid/biometrics/Biometrics$OnMRZReaderListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (listener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerOnMRZReaderListener_Lcom_credenceid_biometrics_Biometrics_OnMRZReaderListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerOnMRZReaderListener", "(Lcom/credenceid/biometrics/Biometrics$OnMRZReaderListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_sendMessageToService_Landroid_os_Message_;
#pragma warning disable 0169
		static Delegate GetSendMessageToService_Landroid_os_Message_Handler ()
		{
			if (cb_sendMessageToService_Landroid_os_Message_ == null)
				cb_sendMessageToService_Landroid_os_Message_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SendMessageToService_Landroid_os_Message_);
			return cb_sendMessageToService_Landroid_os_Message_;
		}

		static void n_SendMessageToService_Landroid_os_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_msg)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var msg = global::Java.Lang.Object.GetObject<global::Android.OS.Message> (native_msg, JniHandleOwnership.DoNotTransfer);
			__this.SendMessageToService (msg);
		}
#pragma warning restore 0169

		static IntPtr id_sendMessageToService_Landroid_os_Message_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='sendMessageToService' and count(parameter)=1 and parameter[1][@type='android.os.Message']]"
		[Register ("sendMessageToService", "(Landroid/os/Message;)V", "GetSendMessageToService_Landroid_os_Message_Handler")]
		public virtual unsafe void SendMessageToService (global::Android.OS.Message msg)
		{
			if (id_sendMessageToService_Landroid_os_Message_ == IntPtr.Zero)
				id_sendMessageToService_Landroid_os_Message_ = JNIEnv.GetMethodID (class_ref, "sendMessageToService", "(Landroid/os/Message;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (msg);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendMessageToService_Landroid_os_Message_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendMessageToService", "(Landroid/os/Message;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setPreferences_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_PreferencesListener_;
#pragma warning disable 0169
		static Delegate GetSetPreferences_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_PreferencesListener_Handler ()
		{
			if (cb_setPreferences_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_PreferencesListener_ == null)
				cb_setPreferences_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_PreferencesListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_SetPreferences_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_PreferencesListener_);
			return cb_setPreferences_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_PreferencesListener_;
		}

		static void n_SetPreferences_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_PreferencesListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			var value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Credenceid.Biometrics.IBiometricsPreferencesListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsPreferencesListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SetPreferences (key, value, listener);
		}
#pragma warning restore 0169

		static IntPtr id_setPreferences_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_PreferencesListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='setPreferences' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.credenceid.biometrics.Biometrics.PreferencesListener']]"
		[Register ("setPreferences", "(Ljava/lang/String;Ljava/lang/String;Lcom/credenceid/biometrics/Biometrics$PreferencesListener;)V", "GetSetPreferences_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_PreferencesListener_Handler")]
		public virtual unsafe void SetPreferences (string key, string value, global::Com.Credenceid.Biometrics.IBiometricsPreferencesListener listener)
		{
			if (id_setPreferences_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_PreferencesListener_ == IntPtr.Zero)
				id_setPreferences_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_PreferencesListener_ = JNIEnv.GetMethodID (class_ref, "setPreferences", "(Ljava/lang/String;Ljava/lang/String;Lcom/credenceid/biometrics/Biometrics$PreferencesListener;)V");
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_key);
				__args [1] = new JValue (native_value);
				__args [2] = new JValue (listener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPreferences_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_PreferencesListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPreferences", "(Ljava/lang/String;Ljava/lang/String;Lcom/credenceid/biometrics/Biometrics$PreferencesListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_switchMobileData_ZLcom_credenceid_biometrics_Biometrics_OnMobileDataChangedListener_;
#pragma warning disable 0169
		static Delegate GetSwitchMobileData_ZLcom_credenceid_biometrics_Biometrics_OnMobileDataChangedListener_Handler ()
		{
			if (cb_switchMobileData_ZLcom_credenceid_biometrics_Biometrics_OnMobileDataChangedListener_ == null)
				cb_switchMobileData_ZLcom_credenceid_biometrics_Biometrics_OnMobileDataChangedListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZL_V) n_SwitchMobileData_ZLcom_credenceid_biometrics_Biometrics_OnMobileDataChangedListener_);
			return cb_switchMobileData_ZLcom_credenceid_biometrics_Biometrics_OnMobileDataChangedListener_;
		}

		static void n_SwitchMobileData_ZLcom_credenceid_biometrics_Biometrics_OnMobileDataChangedListener_ (IntPtr jnienv, IntPtr native__this, bool isEnable, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Com.Credenceid.Biometrics.IBiometricsOnMobileDataChangedListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnMobileDataChangedListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SwitchMobileData (isEnable, listener);
		}
#pragma warning restore 0169

		static IntPtr id_switchMobileData_ZLcom_credenceid_biometrics_Biometrics_OnMobileDataChangedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='switchMobileData' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='com.credenceid.biometrics.Biometrics.OnMobileDataChangedListener']]"
		[Register ("switchMobileData", "(ZLcom/credenceid/biometrics/Biometrics$OnMobileDataChangedListener;)V", "GetSwitchMobileData_ZLcom_credenceid_biometrics_Biometrics_OnMobileDataChangedListener_Handler")]
		public virtual unsafe void SwitchMobileData (bool isEnable, global::Com.Credenceid.Biometrics.IBiometricsOnMobileDataChangedListener listener)
		{
			if (id_switchMobileData_ZLcom_credenceid_biometrics_Biometrics_OnMobileDataChangedListener_ == IntPtr.Zero)
				id_switchMobileData_ZLcom_credenceid_biometrics_Biometrics_OnMobileDataChangedListener_ = JNIEnv.GetMethodID (class_ref, "switchMobileData", "(ZLcom/credenceid/biometrics/Biometrics$OnMobileDataChangedListener;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (isEnable);
				__args [1] = new JValue (listener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_switchMobileData_ZLcom_credenceid_biometrics_Biometrics_OnMobileDataChangedListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "switchMobileData", "(ZLcom/credenceid/biometrics/Biometrics$OnMobileDataChangedListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_verify_ILcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnVerifyCallback_;
#pragma warning disable 0169
		static Delegate GetVerify_ILcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnVerifyCallback_Handler ()
		{
			if (cb_verify_ILcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnVerifyCallback_ == null)
				cb_verify_ILcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnVerifyCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPILLLL_V) n_Verify_ILcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnVerifyCallback_);
			return cb_verify_ILcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnVerifyCallback_;
		}

		static void n_Verify_ILcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnVerifyCallback_ (IntPtr jnienv, IntPtr native__this, int ID, IntPtr native_finger, IntPtr native_face, IntPtr native_iris, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var finger = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.FingerprintRecord> (native_finger, JniHandleOwnership.DoNotTransfer);
			var face = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.FaceRecord> (native_face, JniHandleOwnership.DoNotTransfer);
			var iris = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.IrisRecord> (native_iris, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Com.Credenceid.Database.IBiometricDatabaseOnVerifyCallback)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.IBiometricDatabaseOnVerifyCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.Verify (ID, finger, face, iris, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_verify_ILcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnVerifyCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='verify' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='com.credenceid.database.FingerprintRecord'] and parameter[3][@type='com.credenceid.database.FaceRecord'] and parameter[4][@type='com.credenceid.database.IrisRecord'] and parameter[5][@type='com.credenceid.database.BiometricDatabase.OnVerifyCallback']]"
		[Register ("verify", "(ILcom/credenceid/database/FingerprintRecord;Lcom/credenceid/database/FaceRecord;Lcom/credenceid/database/IrisRecord;Lcom/credenceid/database/BiometricDatabase$OnVerifyCallback;)V", "GetVerify_ILcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnVerifyCallback_Handler")]
		public virtual unsafe void Verify (int ID, global::Com.Credenceid.Database.FingerprintRecord finger, global::Com.Credenceid.Database.FaceRecord face, global::Com.Credenceid.Database.IrisRecord iris, global::Com.Credenceid.Database.IBiometricDatabaseOnVerifyCallback @callback)
		{
			if (id_verify_ILcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnVerifyCallback_ == IntPtr.Zero)
				id_verify_ILcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnVerifyCallback_ = JNIEnv.GetMethodID (class_ref, "verify", "(ILcom/credenceid/database/FingerprintRecord;Lcom/credenceid/database/FaceRecord;Lcom/credenceid/database/IrisRecord;Lcom/credenceid/database/BiometricDatabase$OnVerifyCallback;)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (ID);
				__args [1] = new JValue (finger);
				__args [2] = new JValue (face);
				__args [3] = new JValue (iris);
				__args [4] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_verify_ILcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnVerifyCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "verify", "(ILcom/credenceid/database/FingerprintRecord;Lcom/credenceid/database/FaceRecord;Lcom/credenceid/database/IrisRecord;Lcom/credenceid/database/BiometricDatabase$OnVerifyCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_verify_IarrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnVerifyCallback_;
#pragma warning disable 0169
		static Delegate GetVerify_IarrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnVerifyCallback_Handler ()
		{
			if (cb_verify_IarrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnVerifyCallback_ == null)
				cb_verify_IarrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnVerifyCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPILLLL_V) n_Verify_IarrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnVerifyCallback_);
			return cb_verify_IarrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnVerifyCallback_;
		}

		static void n_Verify_IarrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnVerifyCallback_ (IntPtr jnienv, IntPtr native__this, int ID, IntPtr native_fingers, IntPtr native_face, IntPtr native_irises, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fingers = (global::Com.Credenceid.Database.FingerprintRecord[]) JNIEnv.GetArray (native_fingers, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Credenceid.Database.FingerprintRecord));
			var face = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.FaceRecord> (native_face, JniHandleOwnership.DoNotTransfer);
			var irises = (global::Com.Credenceid.Database.IrisRecord[]) JNIEnv.GetArray (native_irises, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Credenceid.Database.IrisRecord));
			var @callback = (global::Com.Credenceid.Database.IBiometricDatabaseOnVerifyCallback)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.IBiometricDatabaseOnVerifyCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.Verify (ID, fingers, face, irises, @callback);
			if (fingers != null)
				JNIEnv.CopyArray (fingers, native_fingers);
			if (irises != null)
				JNIEnv.CopyArray (irises, native_irises);
		}
#pragma warning restore 0169

		static IntPtr id_verify_IarrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnVerifyCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='BiometricsManager']/method[@name='verify' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='com.credenceid.database.FingerprintRecord[]'] and parameter[3][@type='com.credenceid.database.FaceRecord'] and parameter[4][@type='com.credenceid.database.IrisRecord[]'] and parameter[5][@type='com.credenceid.database.BiometricDatabase.OnVerifyCallback']]"
		[Register ("verify", "(I[Lcom/credenceid/database/FingerprintRecord;Lcom/credenceid/database/FaceRecord;[Lcom/credenceid/database/IrisRecord;Lcom/credenceid/database/BiometricDatabase$OnVerifyCallback;)V", "GetVerify_IarrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnVerifyCallback_Handler")]
		public virtual unsafe void Verify (int ID, global::Com.Credenceid.Database.FingerprintRecord[] fingers, global::Com.Credenceid.Database.FaceRecord face, global::Com.Credenceid.Database.IrisRecord[] irises, global::Com.Credenceid.Database.IBiometricDatabaseOnVerifyCallback @callback)
		{
			if (id_verify_IarrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnVerifyCallback_ == IntPtr.Zero)
				id_verify_IarrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnVerifyCallback_ = JNIEnv.GetMethodID (class_ref, "verify", "(I[Lcom/credenceid/database/FingerprintRecord;Lcom/credenceid/database/FaceRecord;[Lcom/credenceid/database/IrisRecord;Lcom/credenceid/database/BiometricDatabase$OnVerifyCallback;)V");
			IntPtr native_fingers = JNIEnv.NewArray (fingers);
			IntPtr native_irises = JNIEnv.NewArray (irises);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (ID);
				__args [1] = new JValue (native_fingers);
				__args [2] = new JValue (face);
				__args [3] = new JValue (native_irises);
				__args [4] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_verify_IarrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnVerifyCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "verify", "(I[Lcom/credenceid/database/FingerprintRecord;Lcom/credenceid/database/FaceRecord;[Lcom/credenceid/database/IrisRecord;Lcom/credenceid/database/BiometricDatabase$OnVerifyCallback;)V"), __args);
			} finally {
				if (fingers != null) {
					JNIEnv.CopyArray (native_fingers, fingers);
					JNIEnv.DeleteLocalRef (native_fingers);
				}
				if (irises != null) {
					JNIEnv.CopyArray (native_irises, irises);
					JNIEnv.DeleteLocalRef (native_irises);
				}
			}
		}

	}
}
