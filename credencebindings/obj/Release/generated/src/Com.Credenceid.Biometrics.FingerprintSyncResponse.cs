using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Credenceid.Biometrics {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='FingerprintSyncResponse']"
	[global::Android.Runtime.Register ("com/credenceid/biometrics/FingerprintSyncResponse", DoNotGenerateAcw=true)]
	public partial class FingerprintSyncResponse : global::Java.Lang.Object {


		static IntPtr bitmap_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='FingerprintSyncResponse']/field[@name='bitmap']"
		[Register ("bitmap")]
		public global::Android.Graphics.Bitmap Bitmap {
			get {
				if (bitmap_jfieldId == IntPtr.Zero)
					bitmap_jfieldId = JNIEnv.GetFieldID (class_ref, "bitmap", "Landroid/graphics/Bitmap;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, bitmap_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (bitmap_jfieldId == IntPtr.Zero)
					bitmap_jfieldId = JNIEnv.GetFieldID (class_ref, "bitmap", "Landroid/graphics/Bitmap;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, bitmap_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr rawImage_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='FingerprintSyncResponse']/field[@name='rawImage']"
		[Register ("rawImage")]
		public IList<byte> RawImage {
			get {
				if (rawImage_jfieldId == IntPtr.Zero)
					rawImage_jfieldId = JNIEnv.GetFieldID (class_ref, "rawImage", "[B");
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, rawImage_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (rawImage_jfieldId == IntPtr.Zero)
					rawImage_jfieldId = JNIEnv.GetFieldID (class_ref, "rawImage", "[B");
				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, rawImage_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr resultCode_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='FingerprintSyncResponse']/field[@name='resultCode']"
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

		static IntPtr status_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='FingerprintSyncResponse']/field[@name='status']"
		[Register ("status")]
		public string Status {
			get {
				if (status_jfieldId == IntPtr.Zero)
					status_jfieldId = JNIEnv.GetFieldID (class_ref, "status", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, status_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (status_jfieldId == IntPtr.Zero)
					status_jfieldId = JNIEnv.GetFieldID (class_ref, "status", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, status_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/credenceid/biometrics/FingerprintSyncResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FingerprintSyncResponse); }
		}

		protected FingerprintSyncResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_graphics_Bitmap_arrayBLcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='FingerprintSyncResponse']/constructor[@name='FingerprintSyncResponse' and count(parameter)=4 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='byte[]'] and parameter[3][@type='com.credenceid.biometrics.Biometrics.ResultCode'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/graphics/Bitmap;[BLcom/credenceid/biometrics/Biometrics$ResultCode;Ljava/lang/String;)V", "")]
		public unsafe FingerprintSyncResponse (global::Android.Graphics.Bitmap bitmap, byte[] rawImage, global::Com.Credenceid.Biometrics.BiometricsResultCode resultCode, string status)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_rawImage = JNIEnv.NewArray (rawImage);
			IntPtr native_status = JNIEnv.NewString (status);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (bitmap);
				__args [1] = new JValue (native_rawImage);
				__args [2] = new JValue (resultCode);
				__args [3] = new JValue (native_status);
				if (((object) this).GetType () != typeof (FingerprintSyncResponse)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/graphics/Bitmap;[BLcom/credenceid/biometrics/Biometrics$ResultCode;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/graphics/Bitmap;[BLcom/credenceid/biometrics/Biometrics$ResultCode;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Landroid_graphics_Bitmap_arrayBLcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Landroid_graphics_Bitmap_arrayBLcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/graphics/Bitmap;[BLcom/credenceid/biometrics/Biometrics$ResultCode;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_graphics_Bitmap_arrayBLcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_graphics_Bitmap_arrayBLcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_, __args);
			} finally {
				if (rawImage != null) {
					JNIEnv.CopyArray (native_rawImage, rawImage);
					JNIEnv.DeleteLocalRef (native_rawImage);
				}
				JNIEnv.DeleteLocalRef (native_status);
			}
		}

	}
}
