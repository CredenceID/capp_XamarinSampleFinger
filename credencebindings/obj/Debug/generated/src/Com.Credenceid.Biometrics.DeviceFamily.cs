using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Credenceid.Biometrics {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='DeviceFamily']"
	[global::Android.Runtime.Register ("com/credenceid/biometrics/DeviceFamily", DoNotGenerateAcw=true)]
	public sealed partial class DeviceFamily : global::Java.Lang.Enum {


		static IntPtr CredenceOne_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='DeviceFamily']/field[@name='CredenceOne']"
		[Register ("CredenceOne")]
		public static global::Com.Credenceid.Biometrics.DeviceFamily CredenceOne {
			get {
				if (CredenceOne_jfieldId == IntPtr.Zero)
					CredenceOne_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CredenceOne", "Lcom/credenceid/biometrics/DeviceFamily;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CredenceOne_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.DeviceFamily> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CredenceTAB_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='DeviceFamily']/field[@name='CredenceTAB']"
		[Register ("CredenceTAB")]
		public static global::Com.Credenceid.Biometrics.DeviceFamily CredenceTAB {
			get {
				if (CredenceTAB_jfieldId == IntPtr.Zero)
					CredenceTAB_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CredenceTAB", "Lcom/credenceid/biometrics/DeviceFamily;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CredenceTAB_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.DeviceFamily> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CredenceTAB2_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='DeviceFamily']/field[@name='CredenceTAB2']"
		[Register ("CredenceTAB2")]
		public static global::Com.Credenceid.Biometrics.DeviceFamily CredenceTAB2 {
			get {
				if (CredenceTAB2_jfieldId == IntPtr.Zero)
					CredenceTAB2_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CredenceTAB2", "Lcom/credenceid/biometrics/DeviceFamily;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CredenceTAB2_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.DeviceFamily> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CredenceTwo_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='DeviceFamily']/field[@name='CredenceTwo']"
		[Register ("CredenceTwo")]
		public static global::Com.Credenceid.Biometrics.DeviceFamily CredenceTwo {
			get {
				if (CredenceTwo_jfieldId == IntPtr.Zero)
					CredenceTwo_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CredenceTwo", "Lcom/credenceid/biometrics/DeviceFamily;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CredenceTwo_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.DeviceFamily> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Generic_Android_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='DeviceFamily']/field[@name='Generic_Android']"
		[Register ("Generic_Android")]
		public static global::Com.Credenceid.Biometrics.DeviceFamily GenericAndroid {
			get {
				if (Generic_Android_jfieldId == IntPtr.Zero)
					Generic_Android_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Generic_Android", "Lcom/credenceid/biometrics/DeviceFamily;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Generic_Android_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.DeviceFamily> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr InvalidDevice_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='DeviceFamily']/field[@name='InvalidDevice']"
		[Register ("InvalidDevice")]
		public static global::Com.Credenceid.Biometrics.DeviceFamily InvalidDevice {
			get {
				if (InvalidDevice_jfieldId == IntPtr.Zero)
					InvalidDevice_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "InvalidDevice", "Lcom/credenceid/biometrics/DeviceFamily;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, InvalidDevice_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.DeviceFamily> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Starlight_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='DeviceFamily']/field[@name='Starlight']"
		[Register ("Starlight")]
		public static global::Com.Credenceid.Biometrics.DeviceFamily Starlight {
			get {
				if (Starlight_jfieldId == IntPtr.Zero)
					Starlight_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Starlight", "Lcom/credenceid/biometrics/DeviceFamily;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Starlight_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.DeviceFamily> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TridentOne_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='DeviceFamily']/field[@name='TridentOne']"
		[Register ("TridentOne")]
		public static global::Com.Credenceid.Biometrics.DeviceFamily TridentOne {
			get {
				if (TridentOne_jfieldId == IntPtr.Zero)
					TridentOne_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TridentOne", "Lcom/credenceid/biometrics/DeviceFamily;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TridentOne_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.DeviceFamily> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TridentTwo_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='DeviceFamily']/field[@name='TridentTwo']"
		[Register ("TridentTwo")]
		public static global::Com.Credenceid.Biometrics.DeviceFamily TridentTwo {
			get {
				if (TridentTwo_jfieldId == IntPtr.Zero)
					TridentTwo_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TridentTwo", "Lcom/credenceid/biometrics/DeviceFamily;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TridentTwo_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.DeviceFamily> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Twizzler_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='DeviceFamily']/field[@name='Twizzler']"
		[Register ("Twizzler")]
		public static global::Com.Credenceid.Biometrics.DeviceFamily Twizzler {
			get {
				if (Twizzler_jfieldId == IntPtr.Zero)
					Twizzler_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Twizzler", "Lcom/credenceid/biometrics/DeviceFamily;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Twizzler_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.DeviceFamily> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/credenceid/biometrics/DeviceFamily", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DeviceFamily); }
		}

		internal DeviceFamily (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='DeviceFamily']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/credenceid/biometrics/DeviceFamily;", "")]
		public static unsafe global::Com.Credenceid.Biometrics.DeviceFamily ValueOf (string name)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/credenceid/biometrics/DeviceFamily;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::Com.Credenceid.Biometrics.DeviceFamily __ret = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.DeviceFamily> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='DeviceFamily']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/credenceid/biometrics/DeviceFamily;", "")]
		public static unsafe global::Com.Credenceid.Biometrics.DeviceFamily[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/credenceid/biometrics/DeviceFamily;");
			try {
				return (global::Com.Credenceid.Biometrics.DeviceFamily[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Credenceid.Biometrics.DeviceFamily));
			} finally {
			}
		}

	}
}
