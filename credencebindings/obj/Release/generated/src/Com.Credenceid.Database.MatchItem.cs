using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Credenceid.Database {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.credenceid.database']/class[@name='MatchItem']"
	[global::Android.Runtime.Register ("com/credenceid/database/MatchItem", DoNotGenerateAcw=true)]
	public partial class MatchItem : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/credenceid/database/MatchItem", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MatchItem); }
		}

		protected MatchItem (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.database']/class[@name='MatchItem']/constructor[@name='MatchItem' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MatchItem ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MatchItem)) {
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

		static IntPtr id_ctor_IIII;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.database']/class[@name='MatchItem']/constructor[@name='MatchItem' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register (".ctor", "(IIII)V", "")]
		public unsafe MatchItem (int ID, int fingerprintScore, int faceScore, int irisScore)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (ID);
				__args [1] = new JValue (fingerprintScore);
				__args [2] = new JValue (faceScore);
				__args [3] = new JValue (irisScore);
				if (((object) this).GetType () != typeof (MatchItem)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(IIII)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(IIII)V", __args);
					return;
				}

				if (id_ctor_IIII == IntPtr.Zero)
					id_ctor_IIII = JNIEnv.GetMethodID (class_ref, "<init>", "(IIII)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IIII, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_IIII, __args);
			} finally {
			}
		}

		static Delegate cb_getFaceScore;
#pragma warning disable 0169
		static Delegate GetGetFaceScoreHandler ()
		{
			if (cb_getFaceScore == null)
				cb_getFaceScore = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetFaceScore);
			return cb_getFaceScore;
		}

		static int n_GetFaceScore (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.MatchItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FaceScore;
		}
#pragma warning restore 0169

		static IntPtr id_getFaceScore;
		public virtual unsafe int FaceScore {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/class[@name='MatchItem']/method[@name='getFaceScore' and count(parameter)=0]"
			[Register ("getFaceScore", "()I", "GetGetFaceScoreHandler")]
			get {
				if (id_getFaceScore == IntPtr.Zero)
					id_getFaceScore = JNIEnv.GetMethodID (class_ref, "getFaceScore", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getFaceScore);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFaceScore", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getFingerprintScore;
#pragma warning disable 0169
		static Delegate GetGetFingerprintScoreHandler ()
		{
			if (cb_getFingerprintScore == null)
				cb_getFingerprintScore = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetFingerprintScore);
			return cb_getFingerprintScore;
		}

		static int n_GetFingerprintScore (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.MatchItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FingerprintScore;
		}
#pragma warning restore 0169

		static IntPtr id_getFingerprintScore;
		public virtual unsafe int FingerprintScore {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/class[@name='MatchItem']/method[@name='getFingerprintScore' and count(parameter)=0]"
			[Register ("getFingerprintScore", "()I", "GetGetFingerprintScoreHandler")]
			get {
				if (id_getFingerprintScore == IntPtr.Zero)
					id_getFingerprintScore = JNIEnv.GetMethodID (class_ref, "getFingerprintScore", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getFingerprintScore);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFingerprintScore", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getID;
#pragma warning disable 0169
		static Delegate GetGetIDHandler ()
		{
			if (cb_getID == null)
				cb_getID = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetID);
			return cb_getID;
		}

		static int n_GetID (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.MatchItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ID;
		}
#pragma warning restore 0169

		static Delegate cb_setID_I;
#pragma warning disable 0169
		static Delegate GetSetID_IHandler ()
		{
			if (cb_setID_I == null)
				cb_setID_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetID_I);
			return cb_setID_I;
		}

		static void n_SetID_I (IntPtr jnienv, IntPtr native__this, int val)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.MatchItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ID = val;
		}
#pragma warning restore 0169

		static IntPtr id_getID;
		static IntPtr id_setID_I;
		public virtual unsafe int ID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/class[@name='MatchItem']/method[@name='getID' and count(parameter)=0]"
			[Register ("getID", "()I", "GetGetIDHandler")]
			get {
				if (id_getID == IntPtr.Zero)
					id_getID = JNIEnv.GetMethodID (class_ref, "getID", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getID);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getID", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/class[@name='MatchItem']/method[@name='setID' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setID", "(I)V", "GetSetID_IHandler")]
			set {
				if (id_setID_I == IntPtr.Zero)
					id_setID_I = JNIEnv.GetMethodID (class_ref, "setID", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setID_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setID", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getIrisScore;
#pragma warning disable 0169
		static Delegate GetGetIrisScoreHandler ()
		{
			if (cb_getIrisScore == null)
				cb_getIrisScore = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetIrisScore);
			return cb_getIrisScore;
		}

		static int n_GetIrisScore (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.MatchItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IrisScore;
		}
#pragma warning restore 0169

		static IntPtr id_getIrisScore;
		public virtual unsafe int IrisScore {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/class[@name='MatchItem']/method[@name='getIrisScore' and count(parameter)=0]"
			[Register ("getIrisScore", "()I", "GetGetIrisScoreHandler")]
			get {
				if (id_getIrisScore == IntPtr.Zero)
					id_getIrisScore = JNIEnv.GetMethodID (class_ref, "getIrisScore", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getIrisScore);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIrisScore", "()I"));
				} finally {
				}
			}
		}

		static IntPtr id_parse_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/class[@name='MatchItem']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parse", "(Ljava/lang/String;)Lcom/credenceid/database/MatchItem;", "")]
		public static unsafe global::Com.Credenceid.Database.MatchItem Parse (string parcelString)
		{
			if (id_parse_Ljava_lang_String_ == IntPtr.Zero)
				id_parse_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "parse", "(Ljava/lang/String;)Lcom/credenceid/database/MatchItem;");
			IntPtr native_parcelString = JNIEnv.NewString (parcelString);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_parcelString);
				global::Com.Credenceid.Database.MatchItem __ret = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.MatchItem> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parse_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_parcelString);
			}
		}

		static IntPtr id_parseArray_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/class[@name='MatchItem']/method[@name='parseArray' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parseArray", "(Ljava/lang/String;)Ljava/util/ArrayList;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Com.Credenceid.Database.MatchItem> ParseArray (string parcelString)
		{
			if (id_parseArray_Ljava_lang_String_ == IntPtr.Zero)
				id_parseArray_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "parseArray", "(Ljava/lang/String;)Ljava/util/ArrayList;");
			IntPtr native_parcelString = JNIEnv.NewString (parcelString);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_parcelString);
				global::System.Collections.Generic.IList<global::Com.Credenceid.Database.MatchItem> __ret = global::Android.Runtime.JavaList<global::Com.Credenceid.Database.MatchItem>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseArray_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_parcelString);
			}
		}

	}
}
