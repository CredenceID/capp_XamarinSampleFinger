using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Credenceid.Biometrics {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='CardCommandResponse']"
	[global::Android.Runtime.Register ("com/credenceid/biometrics/CardCommandResponse", DoNotGenerateAcw=true)]
	public partial class CardCommandResponse : global::Java.Lang.Object {


		static IntPtr data_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='CardCommandResponse']/field[@name='data']"
		[Register ("data")]
		public IList<byte> Data {
			get {
				if (data_jfieldId == IntPtr.Zero)
					data_jfieldId = JNIEnv.GetFieldID (class_ref, "data", "[B");
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, data_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (data_jfieldId == IntPtr.Zero)
					data_jfieldId = JNIEnv.GetFieldID (class_ref, "data", "[B");
				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, data_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr result_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='CardCommandResponse']/field[@name='result']"
		[Register ("result")]
		public global::Com.Credenceid.Biometrics.BiometricsResultCode Result {
			get {
				if (result_jfieldId == IntPtr.Zero)
					result_jfieldId = JNIEnv.GetFieldID (class_ref, "result", "Lcom/credenceid/biometrics/Biometrics$ResultCode;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, result_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsResultCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (result_jfieldId == IntPtr.Zero)
					result_jfieldId = JNIEnv.GetFieldID (class_ref, "result", "Lcom/credenceid/biometrics/Biometrics$ResultCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, result_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr sw1_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='CardCommandResponse']/field[@name='sw1']"
		[Register ("sw1")]
		public sbyte Sw1 {
			get {
				if (sw1_jfieldId == IntPtr.Zero)
					sw1_jfieldId = JNIEnv.GetFieldID (class_ref, "sw1", "B");
				return JNIEnv.GetByteField (((global::Java.Lang.Object) this).Handle, sw1_jfieldId);
			}
			set {
				if (sw1_jfieldId == IntPtr.Zero)
					sw1_jfieldId = JNIEnv.GetFieldID (class_ref, "sw1", "B");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, sw1_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr sw2_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='CardCommandResponse']/field[@name='sw2']"
		[Register ("sw2")]
		public sbyte Sw2 {
			get {
				if (sw2_jfieldId == IntPtr.Zero)
					sw2_jfieldId = JNIEnv.GetFieldID (class_ref, "sw2", "B");
				return JNIEnv.GetByteField (((global::Java.Lang.Object) this).Handle, sw2_jfieldId);
			}
			set {
				if (sw2_jfieldId == IntPtr.Zero)
					sw2_jfieldId = JNIEnv.GetFieldID (class_ref, "sw2", "B");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, sw2_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/credenceid/biometrics/CardCommandResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CardCommandResponse); }
		}

		protected CardCommandResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_BBarrayBLcom_credenceid_biometrics_Biometrics_ResultCode_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='CardCommandResponse']/constructor[@name='CardCommandResponse' and count(parameter)=4 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte[]'] and parameter[4][@type='com.credenceid.biometrics.Biometrics.ResultCode']]"
		[Register (".ctor", "(BB[BLcom/credenceid/biometrics/Biometrics$ResultCode;)V", "")]
		public unsafe CardCommandResponse (sbyte sw1, sbyte sw2, byte[] data, global::Com.Credenceid.Biometrics.BiometricsResultCode resultCode)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (sw1);
				__args [1] = new JValue (sw2);
				__args [2] = new JValue (native_data);
				__args [3] = new JValue (resultCode);
				if (((object) this).GetType () != typeof (CardCommandResponse)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(BB[BLcom/credenceid/biometrics/Biometrics$ResultCode;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(BB[BLcom/credenceid/biometrics/Biometrics$ResultCode;)V", __args);
					return;
				}

				if (id_ctor_BBarrayBLcom_credenceid_biometrics_Biometrics_ResultCode_ == IntPtr.Zero)
					id_ctor_BBarrayBLcom_credenceid_biometrics_Biometrics_ResultCode_ = JNIEnv.GetMethodID (class_ref, "<init>", "(BB[BLcom/credenceid/biometrics/Biometrics$ResultCode;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_BBarrayBLcom_credenceid_biometrics_Biometrics_ResultCode_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_BBarrayBLcom_credenceid_biometrics_Biometrics_ResultCode_, __args);
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

	}
}
