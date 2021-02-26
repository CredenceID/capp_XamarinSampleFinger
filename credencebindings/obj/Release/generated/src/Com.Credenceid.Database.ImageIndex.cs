using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Credenceid.Database {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.credenceid.database']/class[@name='ImageIndex']"
	[global::Android.Runtime.Register ("com/credenceid/database/ImageIndex", DoNotGenerateAcw=true)]
	public sealed partial class ImageIndex : global::Java.Lang.Enum {


		static IntPtr ONE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.database']/class[@name='ImageIndex']/field[@name='ONE']"
		[Register ("ONE")]
		public static global::Com.Credenceid.Database.ImageIndex One {
			get {
				if (ONE_jfieldId == IntPtr.Zero)
					ONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ONE", "Lcom/credenceid/database/ImageIndex;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ONE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.ImageIndex> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr THREE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.database']/class[@name='ImageIndex']/field[@name='THREE']"
		[Register ("THREE")]
		public static global::Com.Credenceid.Database.ImageIndex Three {
			get {
				if (THREE_jfieldId == IntPtr.Zero)
					THREE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "THREE", "Lcom/credenceid/database/ImageIndex;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, THREE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.ImageIndex> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TOTAL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.database']/class[@name='ImageIndex']/field[@name='TOTAL']"
		[Register ("TOTAL")]
		public static global::Com.Credenceid.Database.ImageIndex Total {
			get {
				if (TOTAL_jfieldId == IntPtr.Zero)
					TOTAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TOTAL", "Lcom/credenceid/database/ImageIndex;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TOTAL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.ImageIndex> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TWO_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.database']/class[@name='ImageIndex']/field[@name='TWO']"
		[Register ("TWO")]
		public static global::Com.Credenceid.Database.ImageIndex Two {
			get {
				if (TWO_jfieldId == IntPtr.Zero)
					TWO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TWO", "Lcom/credenceid/database/ImageIndex;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TWO_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.ImageIndex> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/credenceid/database/ImageIndex", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ImageIndex); }
		}

		internal ImageIndex (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getValue;
		public unsafe int Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/class[@name='ImageIndex']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()I", "")]
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getValue);
				} finally {
				}
			}
		}

		static IntPtr id_valueOf_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/class[@name='ImageIndex']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("valueOf", "(I)Lcom/credenceid/database/ImageIndex;", "")]
		public static unsafe global::Com.Credenceid.Database.ImageIndex ValueOf (int val)
		{
			if (id_valueOf_I == IntPtr.Zero)
				id_valueOf_I = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(I)Lcom/credenceid/database/ImageIndex;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (val);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.ImageIndex> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/class[@name='ImageIndex']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/credenceid/database/ImageIndex;", "")]
		public static unsafe global::Com.Credenceid.Database.ImageIndex ValueOf (string name)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/credenceid/database/ImageIndex;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::Com.Credenceid.Database.ImageIndex __ret = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.ImageIndex> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/class[@name='ImageIndex']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/credenceid/database/ImageIndex;", "")]
		public static unsafe global::Com.Credenceid.Database.ImageIndex[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/credenceid/database/ImageIndex;");
			try {
				return (global::Com.Credenceid.Database.ImageIndex[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Credenceid.Database.ImageIndex));
			} finally {
			}
		}

	}
}
