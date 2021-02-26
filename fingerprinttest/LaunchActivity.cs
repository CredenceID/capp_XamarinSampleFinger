//using Android.App;
//using Android.Content;
//using Android.OS;
//using Android.Runtime;
//using Android.Views;
//using Android.Widget;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using Android.Widget;
//using Android.OS;
//using Com.Credenceid.Biometrics;
//using System;
//using Android.Content;
//using SampleFingerprint;
//using Android.Graphics;
//using Android.Content.PM;

//namespace SampleFingerprint
//{
//    [Activity(Label = "LaunchActivity")]
//    public class LaunchActivity : Activity
//    {

//// When permissions are requested you must pass a number to reference result by.

//        private const int REQUEST_ALL_PERMISSIONS = 5791;

//        private Array PERMISSIONS = arrayOf(Camera, WRITE_EXTERNAL_STORAGE);
//        protected override void OnCreate(Bundle savedInstanceState)
//        {
//            base.OnCreate(savedInstanceState);
//            this.RequestPermissions();
//            // Create your application here
//        }

//        /**
//     * Requests for first permission that is not granted.
//     */
//        private void RequestPermissions()
//        {
//            if (Build.VERSION.SdkInt >= Build.VERSION_CODES.M)
//            {
//                for (Permission in PERMISSIONS)
//                {
//                    /* Requests for first permission not granted. When user grants permission, inside
//                     * "Allow" callback we must then request for next non-granted permission.
//                     *
//                     * This is essentially a recursive function that goes through an array one-by-one.
//                     */
//                    if (PERMISSION_GRANTED != checkSelfPermission(permission))
//                    {
//                        requestPermissions(PERMISSIONS, REQUEST_ALL_PERMISSIONS)
//                        return
//                    }
//                }

//                /* Reach here if all permissions have been granted. */
//                this.initBiometrics()
//        }

//            OnRequestPermissionsResult()
//                {

//            }
//        }

//        private void OnRequestPermissionsResult()
//        {
//            throw new NotImplementedException();
//        }
//    }
//}