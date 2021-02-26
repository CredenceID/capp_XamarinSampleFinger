using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Credenceid.Face {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.credenceid.face']/class[@name='CreateFaceTemplateSyncResponse']"
	[global::Android.Runtime.Register ("com/credenceid/face/CreateFaceTemplateSyncResponse", DoNotGenerateAcw=true)]
	public partial class CreateFaceTemplateSyncResponse : global::Java.Lang.Object {


		static IntPtr resultCode_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.face']/class[@name='CreateFaceTemplateSyncResponse']/field[@name='resultCode']"
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

		static IntPtr template_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.face']/class[@name='CreateFaceTemplateSyncResponse']/field[@name='template']"
		[Register ("template")]
		public IList<byte> Template {
			get {
				if (template_jfieldId == IntPtr.Zero)
					template_jfieldId = JNIEnv.GetFieldID (class_ref, "template", "[B");
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, template_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (template_jfieldId == IntPtr.Zero)
					template_jfieldId = JNIEnv.GetFieldID (class_ref, "template", "[B");
				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, template_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/credenceid/face/CreateFaceTemplateSyncResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CreateFaceTemplateSyncResponse); }
		}

		protected CreateFaceTemplateSyncResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_credenceid_biometrics_Biometrics_ResultCode_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.face']/class[@name='CreateFaceTemplateSyncResponse']/constructor[@name='CreateFaceTemplateSyncResponse' and count(parameter)=1 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ResultCode']]"
		[Register (".ctor", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;)V", "")]
		public unsafe CreateFaceTemplateSyncResponse (global::Com.Credenceid.Biometrics.BiometricsResultCode resultCode)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (resultCode);
				if (((object) this).GetType () != typeof (CreateFaceTemplateSyncResponse)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/credenceid/biometrics/Biometrics$ResultCode;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/credenceid/biometrics/Biometrics$ResultCode;)V", __args);
					return;
				}

				if (id_ctor_Lcom_credenceid_biometrics_Biometrics_ResultCode_ == IntPtr.Zero)
					id_ctor_Lcom_credenceid_biometrics_Biometrics_ResultCode_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_credenceid_biometrics_Biometrics_ResultCode_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_credenceid_biometrics_Biometrics_ResultCode_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.face']/class[@name='CreateFaceTemplateSyncResponse']/constructor[@name='CreateFaceTemplateSyncResponse' and count(parameter)=2 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ResultCode'] and parameter[2][@type='byte[]']]"
		[Register (".ctor", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;[B)V", "")]
		public unsafe CreateFaceTemplateSyncResponse (global::Com.Credenceid.Biometrics.BiometricsResultCode resultCode, byte[] template)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_template = JNIEnv.NewArray (template);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (resultCode);
				__args [1] = new JValue (native_template);
				if (((object) this).GetType () != typeof (CreateFaceTemplateSyncResponse)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/credenceid/biometrics/Biometrics$ResultCode;[B)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/credenceid/biometrics/Biometrics$ResultCode;[B)V", __args);
					return;
				}

				if (id_ctor_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayB == IntPtr.Zero)
					id_ctor_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayB = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;[B)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayB, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayB, __args);
			} finally {
				if (template != null) {
					JNIEnv.CopyArray (native_template, template);
					JNIEnv.DeleteLocalRef (native_template);
				}
			}
		}

	}
}
