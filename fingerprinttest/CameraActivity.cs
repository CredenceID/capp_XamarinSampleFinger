using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using System;

namespace SampleFingerprint
{
    [Activity(Label = "CameraActivity")]
    public class CameraActivity : Activity, ISurfaceHolderCallback
    {

        private string TAG = "CameraActivity";

        /**
 * To obtain high face detection rate we use lowest possible camera resolution for preview.
 * For the actual picture size, we will use the largest available resolution so there is no
 * loss in face image quality.
 */
        private const  int P_WIDTH = 320;
        private const  int P_HEIGHT = 240;
        private const  int syncAPITimeoutMS = 3000;

        /**
 * It is always good to have a global context in case non-activity classes require it. In
 * this case "Beeper" class requires it so it may grab audio file from assets.
 */

            private Context context = null;
            private Camera camera  = null;
       
     //If true then camera is in preview, if false it is not.
   
        private bool inPreview = false;
        
        /**
         * Has camera preview settings been initialized. If true yes, false otherwise. This is required
         * so camera preview does not start without it first being configured.
         */
        private bool mIsCameraConfigured = false;

        private ISurfaceHolder holder = null;

        public ISurfaceHolder surfaceHolder { get; private set; }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
        }

      
        /**
         * This callback is invoked after camera finishes taking a picture.
         */



        /**
        * This is required to stop camera every time back button is pressed.
        */

        public override void OnBackPressed()
        {
            base.OnBackPressed();
            this.stopReleaseCamera();
            this.finish();
        }

        private void finish()
        {
            throw new NotImplementedException();
        }

        private void stopReleaseCamera()
        {
        //    Log.d(App.TAG, "stopReleaseCamera()")

        //if (null != camera)
        //    {
        //        Log.d(App.TAG, "Camera is not null, will release.")

        //    /* Tell camera to no longer invoke callback on each preview frame. */
        //    camera!!.setPreviewCallback(null)
        //    /* Turn off flash. */
        //    this.setTorchEnable(false)

        //    /* Stop camera preview. */
        //    if (inPreview)
        //        {
        //            Log.d(App.TAG, "Camera was in preview, executing: camera.stopPreview().")
        //        camera!!.stopPreview()
        //    }

        //        Log.d(App.TAG, "Executing: camera.release().")
        //    /* Release camera and nullify object. */
        //    camera!!.release()
        //    camera = null
        //    /* We are no longer in preview mode. */
        //    inPreview = false
        //    mIsCameraConfigured = false;
        //    }
        }

        /**
   * This is required to stop camera preview every time activity loses focus.
   */
        protected override void OnPause()
        {
            Log.Debug(TAG, "onPause()");
            base.OnPause();
            this.stopReleaseCamera();
        }

        /**
           * This is required to stop camera every time application is killed.
           */

        protected override void OnDestroy()
        {
            Log.Debug(TAG, "onDestroy()");
            base.OnDestroy();
            this.stopReleaseCamera();
        }

        public void SurfaceChanged(ISurfaceHolder holder, [GeneratedEnum] Format format, int width, int height)
        {
            if(camera==null)
            {
                Log.WriteLine(LogPriority.Info,TAG, "Camera object is null, will not set up preview.");
                return;
            }
        }

        public void SurfaceCreated(ISurfaceHolder holder)
        {
            surfaceHolder = holder;
        }

        public void SurfaceDestroyed(ISurfaceHolder holder)
        {
            if (camera==null)
                return;

            if(inPreview)
            {
                
            }
        }

        private class FaceData
        {
     


        }

    }
}