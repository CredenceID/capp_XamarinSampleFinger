using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.util']/class[@name='HexUtils']"
	[global::Android.Runtime.Register ("com/util/HexUtils", DoNotGenerateAcw=true)]
	public partial class HexUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/util/HexUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HexUtils); }
		}

		protected HexUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.util']/class[@name='HexUtils']/constructor[@name='HexUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HexUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (HexUtils)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_toString_B;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.util']/class[@name='HexUtils']/method[@name='toString' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("toString", "(B)Ljava/lang/String;", "")]
		public static unsafe string ToString (sbyte data)
		{
			if (id_toString_B == IntPtr.Zero)
				id_toString_B = JNIEnv.GetStaticMethodID (class_ref, "toString", "(B)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (data);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toString_B, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_toString_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.util']/class[@name='HexUtils']/method[@name='toString' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("toString", "([B)Ljava/lang/String;", "")]
		public static unsafe string ToString (byte[] data)
		{
			if (id_toString_arrayB == IntPtr.Zero)
				id_toString_arrayB = JNIEnv.GetStaticMethodID (class_ref, "toString", "([B)Ljava/lang/String;");
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_data);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toString_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

		static IntPtr id_toString_arrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.util']/class[@name='HexUtils']/method[@name='toString' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("toString", "([BII)Ljava/lang/String;", "")]
		public static unsafe string ToString (byte[] data, int offset, int length)
		{
			if (id_toString_arrayBII == IntPtr.Zero)
				id_toString_arrayBII = JNIEnv.GetStaticMethodID (class_ref, "toString", "([BII)Ljava/lang/String;");
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_data);
				__args [1] = new JValue (offset);
				__args [2] = new JValue (length);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toString_arrayBII, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

		static IntPtr id_toString_arrayarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.util']/class[@name='HexUtils']/method[@name='toString' and count(parameter)=1 and parameter[1][@type='byte[][]']]"
		[Register ("toString", "([[B)Ljava/lang/String;", "")]
		public static unsafe string ToString (byte[][] data)
		{
			if (id_toString_arrayarrayB == IntPtr.Zero)
				id_toString_arrayarrayB = JNIEnv.GetStaticMethodID (class_ref, "toString", "([[B)Ljava/lang/String;");
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_data);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toString_arrayarrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

	}
}
