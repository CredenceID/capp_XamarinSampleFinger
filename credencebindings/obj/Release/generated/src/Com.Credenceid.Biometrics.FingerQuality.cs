using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Credenceid.Biometrics {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='FingerQuality']"
	[global::Android.Runtime.Register ("com/credenceid/biometrics/FingerQuality", DoNotGenerateAcw=true)]
	public partial class FingerQuality : global::Java.Lang.Object {


		static IntPtr cbeffProductType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='FingerQuality']/field[@name='cbeffProductType']"
		[Register ("cbeffProductType")]
		public int CbeffProductType {
			get {
				if (cbeffProductType_jfieldId == IntPtr.Zero)
					cbeffProductType_jfieldId = JNIEnv.GetFieldID (class_ref, "cbeffProductType", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, cbeffProductType_jfieldId);
			}
			set {
				if (cbeffProductType_jfieldId == IntPtr.Zero)
					cbeffProductType_jfieldId = JNIEnv.GetFieldID (class_ref, "cbeffProductType", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, cbeffProductType_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr formatSize_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='FingerQuality']/field[@name='formatSize']"
		[Register ("formatSize")]
		public int FormatSize {
			get {
				if (formatSize_jfieldId == IntPtr.Zero)
					formatSize_jfieldId = JNIEnv.GetFieldID (class_ref, "formatSize", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, formatSize_jfieldId);
			}
			set {
				if (formatSize_jfieldId == IntPtr.Zero)
					formatSize_jfieldId = JNIEnv.GetFieldID (class_ref, "formatSize", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, formatSize_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr g_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='FingerQuality']/field[@name='g']"
		[Register ("g")]
		public int G {
			get {
				if (g_jfieldId == IntPtr.Zero)
					g_jfieldId = JNIEnv.GetFieldID (class_ref, "g", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, g_jfieldId);
			}
			set {
				if (g_jfieldId == IntPtr.Zero)
					g_jfieldId = JNIEnv.GetFieldID (class_ref, "g", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, g_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr height_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='FingerQuality']/field[@name='height']"
		[Register ("height")]
		public int Height {
			get {
				if (height_jfieldId == IntPtr.Zero)
					height_jfieldId = JNIEnv.GetFieldID (class_ref, "height", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, height_jfieldId);
			}
			set {
				if (height_jfieldId == IntPtr.Zero)
					height_jfieldId = JNIEnv.GetFieldID (class_ref, "height", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, height_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr horizontalResolution_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='FingerQuality']/field[@name='horizontalResolution']"
		[Register ("horizontalResolution")]
		public int HorizontalResolution {
			get {
				if (horizontalResolution_jfieldId == IntPtr.Zero)
					horizontalResolution_jfieldId = JNIEnv.GetFieldID (class_ref, "horizontalResolution", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, horizontalResolution_jfieldId);
			}
			set {
				if (horizontalResolution_jfieldId == IntPtr.Zero)
					horizontalResolution_jfieldId = JNIEnv.GetFieldID (class_ref, "horizontalResolution", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, horizontalResolution_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr impressionType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='FingerQuality']/field[@name='impressionType']"
		[Register ("impressionType")]
		public string ImpressionType {
			get {
				if (impressionType_jfieldId == IntPtr.Zero)
					impressionType_jfieldId = JNIEnv.GetFieldID (class_ref, "impressionType", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, impressionType_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (impressionType_jfieldId == IntPtr.Zero)
					impressionType_jfieldId = JNIEnv.GetFieldID (class_ref, "impressionType", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, impressionType_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr patternClass_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='FingerQuality']/field[@name='patternClass']"
		[Register ("patternClass")]
		public string PatternClass {
			get {
				if (patternClass_jfieldId == IntPtr.Zero)
					patternClass_jfieldId = JNIEnv.GetFieldID (class_ref, "patternClass", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, patternClass_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (patternClass_jfieldId == IntPtr.Zero)
					patternClass_jfieldId = JNIEnv.GetFieldID (class_ref, "patternClass", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, patternClass_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr position_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='FingerQuality']/field[@name='position']"
		[Register ("position")]
		public string Position {
			get {
				if (position_jfieldId == IntPtr.Zero)
					position_jfieldId = JNIEnv.GetFieldID (class_ref, "position", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, position_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (position_jfieldId == IntPtr.Zero)
					position_jfieldId = JNIEnv.GetFieldID (class_ref, "position", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, position_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr ridgeCountsType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='FingerQuality']/field[@name='ridgeCountsType']"
		[Register ("ridgeCountsType")]
		public string RidgeCountsType {
			get {
				if (ridgeCountsType_jfieldId == IntPtr.Zero)
					ridgeCountsType_jfieldId = JNIEnv.GetFieldID (class_ref, "ridgeCountsType", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, ridgeCountsType_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ridgeCountsType_jfieldId == IntPtr.Zero)
					ridgeCountsType_jfieldId = JNIEnv.GetFieldID (class_ref, "ridgeCountsType", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, ridgeCountsType_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr templateQuality_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='FingerQuality']/field[@name='templateQuality']"
		[Register ("templateQuality")]
		public int TemplateQuality {
			get {
				if (templateQuality_jfieldId == IntPtr.Zero)
					templateQuality_jfieldId = JNIEnv.GetFieldID (class_ref, "templateQuality", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, templateQuality_jfieldId);
			}
			set {
				if (templateQuality_jfieldId == IntPtr.Zero)
					templateQuality_jfieldId = JNIEnv.GetFieldID (class_ref, "templateQuality", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, templateQuality_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr verticalResolution_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='FingerQuality']/field[@name='verticalResolution']"
		[Register ("verticalResolution")]
		public int VerticalResolution {
			get {
				if (verticalResolution_jfieldId == IntPtr.Zero)
					verticalResolution_jfieldId = JNIEnv.GetFieldID (class_ref, "verticalResolution", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, verticalResolution_jfieldId);
			}
			set {
				if (verticalResolution_jfieldId == IntPtr.Zero)
					verticalResolution_jfieldId = JNIEnv.GetFieldID (class_ref, "verticalResolution", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, verticalResolution_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr width_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='FingerQuality']/field[@name='width']"
		[Register ("width")]
		public int Width {
			get {
				if (width_jfieldId == IntPtr.Zero)
					width_jfieldId = JNIEnv.GetFieldID (class_ref, "width", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, width_jfieldId);
			}
			set {
				if (width_jfieldId == IntPtr.Zero)
					width_jfieldId = JNIEnv.GetFieldID (class_ref, "width", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, width_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/credenceid/biometrics/FingerQuality", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FingerQuality); }
		}

		protected FingerQuality (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='FingerQuality']/constructor[@name='FingerQuality' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FingerQuality ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (FingerQuality)) {
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

		static IntPtr id_fromArray_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='FingerQuality']/method[@name='fromArray' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("fromArray", "([Ljava/lang/String;)Lcom/credenceid/biometrics/FingerQuality;", "")]
		public static unsafe global::Com.Credenceid.Biometrics.FingerQuality FromArray (string[] a)
		{
			if (id_fromArray_arrayLjava_lang_String_ == IntPtr.Zero)
				id_fromArray_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "fromArray", "([Ljava/lang/String;)Lcom/credenceid/biometrics/FingerQuality;");
			IntPtr native_a = JNIEnv.NewArray (a);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_a);
				global::Com.Credenceid.Biometrics.FingerQuality __ret = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.FingerQuality> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromArray_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (a != null) {
					JNIEnv.CopyArray (native_a, a);
					JNIEnv.DeleteLocalRef (native_a);
				}
			}
		}

		static Delegate cb_setQualityScore_I;
#pragma warning disable 0169
		static Delegate GetSetQualityScore_IHandler ()
		{
			if (cb_setQualityScore_I == null)
				cb_setQualityScore_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetQualityScore_I);
			return cb_setQualityScore_I;
		}

		static void n_SetQualityScore_I (IntPtr jnienv, IntPtr native__this, int score)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.FingerQuality> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetQualityScore (score);
		}
#pragma warning restore 0169

		static IntPtr id_setQualityScore_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='FingerQuality']/method[@name='setQualityScore' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setQualityScore", "(I)V", "GetSetQualityScore_IHandler")]
		public virtual unsafe void SetQualityScore (int score)
		{
			if (id_setQualityScore_I == IntPtr.Zero)
				id_setQualityScore_I = JNIEnv.GetMethodID (class_ref, "setQualityScore", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (score);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setQualityScore_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setQualityScore", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_toArray;
#pragma warning disable 0169
		static Delegate GetToArrayHandler ()
		{
			if (cb_toArray == null)
				cb_toArray = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToArray);
			return cb_toArray;
		}

		static IntPtr n_ToArray (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.FingerQuality> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ToArray ());
		}
#pragma warning restore 0169

		static IntPtr id_toArray;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='FingerQuality']/method[@name='toArray' and count(parameter)=0]"
		[Register ("toArray", "()[Ljava/lang/String;", "GetToArrayHandler")]
		public virtual unsafe string[] ToArray ()
		{
			if (id_toArray == IntPtr.Zero)
				id_toArray = JNIEnv.GetMethodID (class_ref, "toArray", "()[Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toArray), JniHandleOwnership.TransferLocalRef, typeof (string));
				else
					return (string[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toArray", "()[Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

	}
}
