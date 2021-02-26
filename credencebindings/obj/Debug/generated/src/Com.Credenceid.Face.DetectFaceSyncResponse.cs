using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Credenceid.Face {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.credenceid.face']/class[@name='DetectFaceSyncResponse']"
	[global::Android.Runtime.Register ("com/credenceid/face/DetectFaceSyncResponse", DoNotGenerateAcw=true)]
	public partial class DetectFaceSyncResponse : global::Java.Lang.Object {


		static IntPtr faceRect_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.face']/class[@name='DetectFaceSyncResponse']/field[@name='faceRect']"
		[Register ("faceRect")]
		public global::Android.Graphics.RectF FaceRect {
			get {
				if (faceRect_jfieldId == IntPtr.Zero)
					faceRect_jfieldId = JNIEnv.GetFieldID (class_ref, "faceRect", "Landroid/graphics/RectF;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, faceRect_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (faceRect_jfieldId == IntPtr.Zero)
					faceRect_jfieldId = JNIEnv.GetFieldID (class_ref, "faceRect", "Landroid/graphics/RectF;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, faceRect_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr resultCode_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.face']/class[@name='DetectFaceSyncResponse']/field[@name='resultCode']"
		[Register ("resultCode")]
		public global::Com.Credenceid.Biometrics.BiometricsResultCode ResultCode {
			get {
				if (resultCode_jfieldId == IntPtr.Zero)
					resultCode_jfieldId = JNIEnv.GetFieldID (class_ref, "resultCode", "Lcom/credenceid/biometrics/Biometrics$ResultCode;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, resultCode_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsResultCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (resultCode_jfieldId == IntPtr.Zero)
					resultCode_jfieldId = JNIEnv.GetFieldID (class_ref, "resultCode", "Lcom/credenceid/biometrics/Biometrics$ResultCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, resultCode_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/credenceid/face/DetectFaceSyncResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DetectFaceSyncResponse); }
		}

		protected DetectFaceSyncResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_RectF_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.face']/class[@name='DetectFaceSyncResponse']/constructor[@name='DetectFaceSyncResponse' and count(parameter)=2 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ResultCode'] and parameter[2][@type='android.graphics.RectF']]"
		[Register (".ctor", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Landroid/graphics/RectF;)V", "")]
		public unsafe DetectFaceSyncResponse (global::Com.Credenceid.Biometrics.BiometricsResultCode resultCode, global::Android.Graphics.RectF faceRect)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (resultCode);
				__args [1] = new JValue (faceRect);
				if (((object) this).GetType () != typeof (DetectFaceSyncResponse)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Landroid/graphics/RectF;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Landroid/graphics/RectF;)V", __args);
					return;
				}

				if (id_ctor_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_RectF_ == IntPtr.Zero)
					id_ctor_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_RectF_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Landroid/graphics/RectF;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_RectF_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_RectF_, __args);
			} finally {
			}
		}

	}
}
