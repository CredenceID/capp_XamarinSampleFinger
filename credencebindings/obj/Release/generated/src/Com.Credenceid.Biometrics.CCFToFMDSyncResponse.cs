using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Credenceid.Biometrics {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='CCFToFMDSyncResponse']"
	[global::Android.Runtime.Register ("com/credenceid/biometrics/CCFToFMDSyncResponse", DoNotGenerateAcw=true)]
	public partial class CCFToFMDSyncResponse : global::Java.Lang.Object {


		static IntPtr FMD_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='CCFToFMDSyncResponse']/field[@name='FMD']"
		[Register ("FMD")]
		public IList<byte> Fmd {
			get {
				if (FMD_jfieldId == IntPtr.Zero)
					FMD_jfieldId = JNIEnv.GetFieldID (class_ref, "FMD", "[B");
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, FMD_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (FMD_jfieldId == IntPtr.Zero)
					FMD_jfieldId = JNIEnv.GetFieldID (class_ref, "FMD", "[B");
				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, FMD_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr resultCode_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='CCFToFMDSyncResponse']/field[@name='resultCode']"
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
				return JNIEnv.FindClass ("com/credenceid/biometrics/CCFToFMDSyncResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CCFToFMDSyncResponse); }
		}

		protected CCFToFMDSyncResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_credenceid_biometrics_Biometrics_ResultCode_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='CCFToFMDSyncResponse']/constructor[@name='CCFToFMDSyncResponse' and count(parameter)=1 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ResultCode']]"
		[Register (".ctor", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;)V", "")]
		public unsafe CCFToFMDSyncResponse (global::Com.Credenceid.Biometrics.BiometricsResultCode resultCode)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (resultCode);
				if (((object) this).GetType () != typeof (CCFToFMDSyncResponse)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='CCFToFMDSyncResponse']/constructor[@name='CCFToFMDSyncResponse' and count(parameter)=2 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ResultCode'] and parameter[2][@type='byte[]']]"
		[Register (".ctor", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;[B)V", "")]
		public unsafe CCFToFMDSyncResponse (global::Com.Credenceid.Biometrics.BiometricsResultCode resultCode, byte[] FMD)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_FMD = JNIEnv.NewArray (FMD);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (resultCode);
				__args [1] = new JValue (native_FMD);
				if (((object) this).GetType () != typeof (CCFToFMDSyncResponse)) {
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
				if (FMD != null) {
					JNIEnv.CopyArray (native_FMD, FMD);
					JNIEnv.DeleteLocalRef (native_FMD);
				}
			}
		}

	}
}
