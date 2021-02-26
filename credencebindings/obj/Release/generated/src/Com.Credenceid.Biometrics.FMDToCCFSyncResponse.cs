using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Credenceid.Biometrics {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='FMDToCCFSyncResponse']"
	[global::Android.Runtime.Register ("com/credenceid/biometrics/FMDToCCFSyncResponse", DoNotGenerateAcw=true)]
	public partial class FMDToCCFSyncResponse : global::Java.Lang.Object {


		static IntPtr CCF_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='FMDToCCFSyncResponse']/field[@name='CCF']"
		[Register ("CCF")]
		public IList<byte> Ccf {
			get {
				if (CCF_jfieldId == IntPtr.Zero)
					CCF_jfieldId = JNIEnv.GetFieldID (class_ref, "CCF", "[B");
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, CCF_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CCF_jfieldId == IntPtr.Zero)
					CCF_jfieldId = JNIEnv.GetFieldID (class_ref, "CCF", "[B");
				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, CCF_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr resultCode_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='FMDToCCFSyncResponse']/field[@name='resultCode']"
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
				return JNIEnv.FindClass ("com/credenceid/biometrics/FMDToCCFSyncResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FMDToCCFSyncResponse); }
		}

		protected FMDToCCFSyncResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_credenceid_biometrics_Biometrics_ResultCode_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='FMDToCCFSyncResponse']/constructor[@name='FMDToCCFSyncResponse' and count(parameter)=1 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ResultCode']]"
		[Register (".ctor", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;)V", "")]
		public unsafe FMDToCCFSyncResponse (global::Com.Credenceid.Biometrics.BiometricsResultCode resultCode)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (resultCode);
				if (((object) this).GetType () != typeof (FMDToCCFSyncResponse)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='FMDToCCFSyncResponse']/constructor[@name='FMDToCCFSyncResponse' and count(parameter)=2 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ResultCode'] and parameter[2][@type='byte[]']]"
		[Register (".ctor", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;[B)V", "")]
		public unsafe FMDToCCFSyncResponse (global::Com.Credenceid.Biometrics.BiometricsResultCode resultCode, byte[] CCF)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_CCF = JNIEnv.NewArray (CCF);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (resultCode);
				__args [1] = new JValue (native_CCF);
				if (((object) this).GetType () != typeof (FMDToCCFSyncResponse)) {
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
				if (CCF != null) {
					JNIEnv.CopyArray (native_CCF, CCF);
					JNIEnv.DeleteLocalRef (native_CCF);
				}
			}
		}

	}
}
