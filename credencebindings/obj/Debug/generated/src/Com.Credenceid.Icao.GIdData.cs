using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Credenceid.Icao {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData']"
	[global::Android.Runtime.Register ("com/credenceid/icao/GIdData", DoNotGenerateAcw=true)]
	public partial class GIdData : global::Java.Lang.Object, global::Java.IO.ISerializable {


		static IntPtr DG1_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData']/field[@name='DG1']"
		[Register ("DG1")]
		public global::Com.Credenceid.Icao.GIdData.DG1 Dg1 {
			get {
				if (DG1_jfieldId == IntPtr.Zero)
					DG1_jfieldId = JNIEnv.GetFieldID (class_ref, "DG1", "Lcom/credenceid/icao/GIdData$DG1;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, DG1_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.GIdData.DG1> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DG1_jfieldId == IntPtr.Zero)
					DG1_jfieldId = JNIEnv.GetFieldID (class_ref, "DG1", "Lcom/credenceid/icao/GIdData$DG1;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, DG1_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr DG10_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData']/field[@name='DG10']"
		[Register ("DG10")]
		public global::Com.Credenceid.Icao.GIdData.DG10 Dg10 {
			get {
				if (DG10_jfieldId == IntPtr.Zero)
					DG10_jfieldId = JNIEnv.GetFieldID (class_ref, "DG10", "Lcom/credenceid/icao/GIdData$DG10;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, DG10_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.GIdData.DG10> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DG10_jfieldId == IntPtr.Zero)
					DG10_jfieldId = JNIEnv.GetFieldID (class_ref, "DG10", "Lcom/credenceid/icao/GIdData$DG10;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, DG10_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr DG11_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData']/field[@name='DG11']"
		[Register ("DG11")]
		public global::Com.Credenceid.Icao.GIdData.DG11 Dg11 {
			get {
				if (DG11_jfieldId == IntPtr.Zero)
					DG11_jfieldId = JNIEnv.GetFieldID (class_ref, "DG11", "Lcom/credenceid/icao/GIdData$DG11;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, DG11_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.GIdData.DG11> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DG11_jfieldId == IntPtr.Zero)
					DG11_jfieldId = JNIEnv.GetFieldID (class_ref, "DG11", "Lcom/credenceid/icao/GIdData$DG11;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, DG11_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr DG2_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData']/field[@name='DG2']"
		[Register ("DG2")]
		public global::Com.Credenceid.Icao.GIdData.DG2 Dg2 {
			get {
				if (DG2_jfieldId == IntPtr.Zero)
					DG2_jfieldId = JNIEnv.GetFieldID (class_ref, "DG2", "Lcom/credenceid/icao/GIdData$DG2;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, DG2_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.GIdData.DG2> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DG2_jfieldId == IntPtr.Zero)
					DG2_jfieldId = JNIEnv.GetFieldID (class_ref, "DG2", "Lcom/credenceid/icao/GIdData$DG2;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, DG2_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr DG3_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData']/field[@name='DG3']"
		[Register ("DG3")]
		public global::Com.Credenceid.Icao.GIdData.DG3 Dg3 {
			get {
				if (DG3_jfieldId == IntPtr.Zero)
					DG3_jfieldId = JNIEnv.GetFieldID (class_ref, "DG3", "Lcom/credenceid/icao/GIdData$DG3;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, DG3_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.GIdData.DG3> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DG3_jfieldId == IntPtr.Zero)
					DG3_jfieldId = JNIEnv.GetFieldID (class_ref, "DG3", "Lcom/credenceid/icao/GIdData$DG3;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, DG3_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr DG4_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData']/field[@name='DG4']"
		[Register ("DG4")]
		public global::Com.Credenceid.Icao.GIdData.DG4 Dg4 {
			get {
				if (DG4_jfieldId == IntPtr.Zero)
					DG4_jfieldId = JNIEnv.GetFieldID (class_ref, "DG4", "Lcom/credenceid/icao/GIdData$DG4;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, DG4_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.GIdData.DG4> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DG4_jfieldId == IntPtr.Zero)
					DG4_jfieldId = JNIEnv.GetFieldID (class_ref, "DG4", "Lcom/credenceid/icao/GIdData$DG4;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, DG4_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr DG5_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData']/field[@name='DG5']"
		[Register ("DG5")]
		public global::Com.Credenceid.Icao.GIdData.DG5 Dg5 {
			get {
				if (DG5_jfieldId == IntPtr.Zero)
					DG5_jfieldId = JNIEnv.GetFieldID (class_ref, "DG5", "Lcom/credenceid/icao/GIdData$DG5;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, DG5_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.GIdData.DG5> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DG5_jfieldId == IntPtr.Zero)
					DG5_jfieldId = JNIEnv.GetFieldID (class_ref, "DG5", "Lcom/credenceid/icao/GIdData$DG5;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, DG5_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr DG6_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData']/field[@name='DG6']"
		[Register ("DG6")]
		public global::Com.Credenceid.Icao.GIdData.DG6 Dg6 {
			get {
				if (DG6_jfieldId == IntPtr.Zero)
					DG6_jfieldId = JNIEnv.GetFieldID (class_ref, "DG6", "Lcom/credenceid/icao/GIdData$DG6;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, DG6_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.GIdData.DG6> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DG6_jfieldId == IntPtr.Zero)
					DG6_jfieldId = JNIEnv.GetFieldID (class_ref, "DG6", "Lcom/credenceid/icao/GIdData$DG6;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, DG6_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr DG7_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData']/field[@name='DG7']"
		[Register ("DG7")]
		public global::Com.Credenceid.Icao.GIdData.DG7 Dg7 {
			get {
				if (DG7_jfieldId == IntPtr.Zero)
					DG7_jfieldId = JNIEnv.GetFieldID (class_ref, "DG7", "Lcom/credenceid/icao/GIdData$DG7;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, DG7_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.GIdData.DG7> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DG7_jfieldId == IntPtr.Zero)
					DG7_jfieldId = JNIEnv.GetFieldID (class_ref, "DG7", "Lcom/credenceid/icao/GIdData$DG7;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, DG7_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr DG8_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData']/field[@name='DG8']"
		[Register ("DG8")]
		public global::Com.Credenceid.Icao.GIdData.DG8 Dg8 {
			get {
				if (DG8_jfieldId == IntPtr.Zero)
					DG8_jfieldId = JNIEnv.GetFieldID (class_ref, "DG8", "Lcom/credenceid/icao/GIdData$DG8;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, DG8_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.GIdData.DG8> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DG8_jfieldId == IntPtr.Zero)
					DG8_jfieldId = JNIEnv.GetFieldID (class_ref, "DG8", "Lcom/credenceid/icao/GIdData$DG8;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, DG8_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr DG9_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData']/field[@name='DG9']"
		[Register ("DG9")]
		public global::Com.Credenceid.Icao.GIdData.DG9 Dg9 {
			get {
				if (DG9_jfieldId == IntPtr.Zero)
					DG9_jfieldId = JNIEnv.GetFieldID (class_ref, "DG9", "Lcom/credenceid/icao/GIdData$DG9;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, DG9_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.GIdData.DG9> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DG9_jfieldId == IntPtr.Zero)
					DG9_jfieldId = JNIEnv.GetFieldID (class_ref, "DG9", "Lcom/credenceid/icao/GIdData$DG9;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, DG9_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData.DG1']"
		[global::Android.Runtime.Register ("com/credenceid/icao/GIdData$DG1", DoNotGenerateAcw=true)]
		public partial class DG1 : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/credenceid/icao/GIdData$DG1", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DG1); }
			}

			protected DG1 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_credenceid_icao_GIdData_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData.DG1']/constructor[@name='GIdData.DG1' and count(parameter)=1 and parameter[1][@type='com.credenceid.icao.GIdData']]"
			[Register (".ctor", "(Lcom/credenceid/icao/GIdData;)V", "")]
			public unsafe DG1 (global::Com.Credenceid.Icao.GIdData __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (((object) this).GetType () != typeof (DG1)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lcom_credenceid_icao_GIdData_ == IntPtr.Zero)
						id_ctor_Lcom_credenceid_icao_GIdData_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/credenceid/icao/GIdData;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_credenceid_icao_GIdData_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_credenceid_icao_GIdData_, __args);
				} finally {
				}
			}

			static Delegate cb_getGender;
#pragma warning disable 0169
			static Delegate GetGetGenderHandler ()
			{
				if (cb_getGender == null)
					cb_getGender = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetGender);
				return cb_getGender;
			}

			static IntPtr n_GetGender (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.GIdData.DG1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Gender);
			}
#pragma warning restore 0169

			static Delegate cb_setGender_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetGender_Ljava_lang_String_Handler ()
			{
				if (cb_setGender_Ljava_lang_String_ == null)
					cb_setGender_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetGender_Ljava_lang_String_);
				return cb_setGender_Ljava_lang_String_;
			}

			static void n_SetGender_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_gender)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.GIdData.DG1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var gender = JNIEnv.GetString (native_gender, JniHandleOwnership.DoNotTransfer);
				__this.Gender = gender;
			}
#pragma warning restore 0169

			static IntPtr id_getGender;
			static IntPtr id_setGender_Ljava_lang_String_;
			public virtual unsafe string Gender {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData.DG1']/method[@name='getGender' and count(parameter)=0]"
				[Register ("getGender", "()Ljava/lang/String;", "GetGetGenderHandler")]
				get {
					if (id_getGender == IntPtr.Zero)
						id_getGender = JNIEnv.GetMethodID (class_ref, "getGender", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGender), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGender", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData.DG1']/method[@name='setGender' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setGender", "(Ljava/lang/String;)V", "GetSetGender_Ljava_lang_String_Handler")]
				set {
					if (id_setGender_Ljava_lang_String_ == IntPtr.Zero)
						id_setGender_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setGender", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setGender_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setGender", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getGivenName;
#pragma warning disable 0169
			static Delegate GetGetGivenNameHandler ()
			{
				if (cb_getGivenName == null)
					cb_getGivenName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetGivenName);
				return cb_getGivenName;
			}

			static IntPtr n_GetGivenName (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.GIdData.DG1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.GivenName);
			}
#pragma warning restore 0169

			static Delegate cb_setGivenName_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetGivenName_Ljava_lang_String_Handler ()
			{
				if (cb_setGivenName_Ljava_lang_String_ == null)
					cb_setGivenName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetGivenName_Ljava_lang_String_);
				return cb_setGivenName_Ljava_lang_String_;
			}

			static void n_SetGivenName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_givenName)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.GIdData.DG1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var givenName = JNIEnv.GetString (native_givenName, JniHandleOwnership.DoNotTransfer);
				__this.GivenName = givenName;
			}
#pragma warning restore 0169

			static IntPtr id_getGivenName;
			static IntPtr id_setGivenName_Ljava_lang_String_;
			public virtual unsafe string GivenName {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData.DG1']/method[@name='getGivenName' and count(parameter)=0]"
				[Register ("getGivenName", "()Ljava/lang/String;", "GetGetGivenNameHandler")]
				get {
					if (id_getGivenName == IntPtr.Zero)
						id_getGivenName = JNIEnv.GetMethodID (class_ref, "getGivenName", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGivenName), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGivenName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData.DG1']/method[@name='setGivenName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setGivenName", "(Ljava/lang/String;)V", "GetSetGivenName_Ljava_lang_String_Handler")]
				set {
					if (id_setGivenName_Ljava_lang_String_ == IntPtr.Zero)
						id_setGivenName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setGivenName", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setGivenName_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setGivenName", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getMiddleName;
#pragma warning disable 0169
			static Delegate GetGetMiddleNameHandler ()
			{
				if (cb_getMiddleName == null)
					cb_getMiddleName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMiddleName);
				return cb_getMiddleName;
			}

			static IntPtr n_GetMiddleName (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.GIdData.DG1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.MiddleName);
			}
#pragma warning restore 0169

			static Delegate cb_setMiddleName_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetMiddleName_Ljava_lang_String_Handler ()
			{
				if (cb_setMiddleName_Ljava_lang_String_ == null)
					cb_setMiddleName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetMiddleName_Ljava_lang_String_);
				return cb_setMiddleName_Ljava_lang_String_;
			}

			static void n_SetMiddleName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_givenName)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.GIdData.DG1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var givenName = JNIEnv.GetString (native_givenName, JniHandleOwnership.DoNotTransfer);
				__this.MiddleName = givenName;
			}
#pragma warning restore 0169

			static IntPtr id_getMiddleName;
			static IntPtr id_setMiddleName_Ljava_lang_String_;
			public virtual unsafe string MiddleName {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData.DG1']/method[@name='getMiddleName' and count(parameter)=0]"
				[Register ("getMiddleName", "()Ljava/lang/String;", "GetGetMiddleNameHandler")]
				get {
					if (id_getMiddleName == IntPtr.Zero)
						id_getMiddleName = JNIEnv.GetMethodID (class_ref, "getMiddleName", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMiddleName), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMiddleName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData.DG1']/method[@name='setMiddleName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setMiddleName", "(Ljava/lang/String;)V", "GetSetMiddleName_Ljava_lang_String_Handler")]
				set {
					if (id_setMiddleName_Ljava_lang_String_ == IntPtr.Zero)
						id_setMiddleName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMiddleName", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMiddleName_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMiddleName", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getSurName;
#pragma warning disable 0169
			static Delegate GetGetSurNameHandler ()
			{
				if (cb_getSurName == null)
					cb_getSurName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSurName);
				return cb_getSurName;
			}

			static IntPtr n_GetSurName (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.GIdData.DG1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.SurName);
			}
#pragma warning restore 0169

			static Delegate cb_setSurName_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetSurName_Ljava_lang_String_Handler ()
			{
				if (cb_setSurName_Ljava_lang_String_ == null)
					cb_setSurName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetSurName_Ljava_lang_String_);
				return cb_setSurName_Ljava_lang_String_;
			}

			static void n_SetSurName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_surName)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.GIdData.DG1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var surName = JNIEnv.GetString (native_surName, JniHandleOwnership.DoNotTransfer);
				__this.SurName = surName;
			}
#pragma warning restore 0169

			static IntPtr id_getSurName;
			static IntPtr id_setSurName_Ljava_lang_String_;
			public virtual unsafe string SurName {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData.DG1']/method[@name='getSurName' and count(parameter)=0]"
				[Register ("getSurName", "()Ljava/lang/String;", "GetGetSurNameHandler")]
				get {
					if (id_getSurName == IntPtr.Zero)
						id_getSurName = JNIEnv.GetMethodID (class_ref, "getSurName", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSurName), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSurName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData.DG1']/method[@name='setSurName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setSurName", "(Ljava/lang/String;)V", "GetSetSurName_Ljava_lang_String_Handler")]
				set {
					if (id_setSurName_Ljava_lang_String_ == IntPtr.Zero)
						id_setSurName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSurName", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSurName_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSurName", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData.DG10']"
		[global::Android.Runtime.Register ("com/credenceid/icao/GIdData$DG10", DoNotGenerateAcw=true)]
		public partial class DG10 : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/credenceid/icao/GIdData$DG10", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DG10); }
			}

			protected DG10 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_credenceid_icao_GIdData_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData.DG10']/constructor[@name='GIdData.DG10' and count(parameter)=1 and parameter[1][@type='com.credenceid.icao.GIdData']]"
			[Register (".ctor", "(Lcom/credenceid/icao/GIdData;)V", "")]
			public unsafe DG10 (global::Com.Credenceid.Icao.GIdData __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (((object) this).GetType () != typeof (DG10)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lcom_credenceid_icao_GIdData_ == IntPtr.Zero)
						id_ctor_Lcom_credenceid_icao_GIdData_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/credenceid/icao/GIdData;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_credenceid_icao_GIdData_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_credenceid_icao_GIdData_, __args);
				} finally {
				}
			}

			static Delegate cb_getFingers;
#pragma warning disable 0169
			static Delegate GetGetFingersHandler ()
			{
				if (cb_getFingers == null)
					cb_getFingers = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFingers);
				return cb_getFingers;
			}

			static IntPtr n_GetFingers (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.GIdData.DG10> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return global::Android.Runtime.JavaList<global::Com.Credenceid.Icao.GhanaIdCardFpTemplateInfo>.ToLocalJniHandle (__this.Fingers);
			}
#pragma warning restore 0169

			static IntPtr id_getFingers;
			public virtual unsafe global::System.Collections.Generic.IList<global::Com.Credenceid.Icao.GhanaIdCardFpTemplateInfo> Fingers {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData.DG10']/method[@name='getFingers' and count(parameter)=0]"
				[Register ("getFingers", "()Ljava/util/ArrayList;", "GetGetFingersHandler")]
				get {
					if (id_getFingers == IntPtr.Zero)
						id_getFingers = JNIEnv.GetMethodID (class_ref, "getFingers", "()Ljava/util/ArrayList;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return global::Android.Runtime.JavaList<global::Com.Credenceid.Icao.GhanaIdCardFpTemplateInfo>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFingers), JniHandleOwnership.TransferLocalRef);
						else
							return global::Android.Runtime.JavaList<global::Com.Credenceid.Icao.GhanaIdCardFpTemplateInfo>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFingers", "()Ljava/util/ArrayList;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_addFinger_Lcom_credenceid_icao_GhanaIdCardFpTemplateInfo_;
#pragma warning disable 0169
			static Delegate GetAddFinger_Lcom_credenceid_icao_GhanaIdCardFpTemplateInfo_Handler ()
			{
				if (cb_addFinger_Lcom_credenceid_icao_GhanaIdCardFpTemplateInfo_ == null)
					cb_addFinger_Lcom_credenceid_icao_GhanaIdCardFpTemplateInfo_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AddFinger_Lcom_credenceid_icao_GhanaIdCardFpTemplateInfo_);
				return cb_addFinger_Lcom_credenceid_icao_GhanaIdCardFpTemplateInfo_;
			}

			static void n_AddFinger_Lcom_credenceid_icao_GhanaIdCardFpTemplateInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fingerInfo)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.GIdData.DG10> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var fingerInfo = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.GhanaIdCardFpTemplateInfo> (native_fingerInfo, JniHandleOwnership.DoNotTransfer);
				__this.AddFinger (fingerInfo);
			}
#pragma warning restore 0169

			static IntPtr id_addFinger_Lcom_credenceid_icao_GhanaIdCardFpTemplateInfo_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData.DG10']/method[@name='addFinger' and count(parameter)=1 and parameter[1][@type='com.credenceid.icao.GhanaIdCardFpTemplateInfo']]"
			[Register ("addFinger", "(Lcom/credenceid/icao/GhanaIdCardFpTemplateInfo;)V", "GetAddFinger_Lcom_credenceid_icao_GhanaIdCardFpTemplateInfo_Handler")]
			public virtual unsafe void AddFinger (global::Com.Credenceid.Icao.GhanaIdCardFpTemplateInfo fingerInfo)
			{
				if (id_addFinger_Lcom_credenceid_icao_GhanaIdCardFpTemplateInfo_ == IntPtr.Zero)
					id_addFinger_Lcom_credenceid_icao_GhanaIdCardFpTemplateInfo_ = JNIEnv.GetMethodID (class_ref, "addFinger", "(Lcom/credenceid/icao/GhanaIdCardFpTemplateInfo;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (fingerInfo);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addFinger_Lcom_credenceid_icao_GhanaIdCardFpTemplateInfo_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addFinger", "(Lcom/credenceid/icao/GhanaIdCardFpTemplateInfo;)V"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData.DG11']"
		[global::Android.Runtime.Register ("com/credenceid/icao/GIdData$DG11", DoNotGenerateAcw=true)]
		public partial class DG11 : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/credenceid/icao/GIdData$DG11", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DG11); }
			}

			protected DG11 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_credenceid_icao_GIdData_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData.DG11']/constructor[@name='GIdData.DG11' and count(parameter)=1 and parameter[1][@type='com.credenceid.icao.GIdData']]"
			[Register (".ctor", "(Lcom/credenceid/icao/GIdData;)V", "")]
			public unsafe DG11 (global::Com.Credenceid.Icao.GIdData __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (((object) this).GetType () != typeof (DG11)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lcom_credenceid_icao_GIdData_ == IntPtr.Zero)
						id_ctor_Lcom_credenceid_icao_GIdData_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/credenceid/icao/GIdData;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_credenceid_icao_GIdData_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_credenceid_icao_GIdData_, __args);
				} finally {
				}
			}

			static Delegate cb_getCardType;
#pragma warning disable 0169
			static Delegate GetGetCardTypeHandler ()
			{
				if (cb_getCardType == null)
					cb_getCardType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCardType);
				return cb_getCardType;
			}

			static IntPtr n_GetCardType (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.GIdData.DG11> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.CardType);
			}
#pragma warning restore 0169

			static Delegate cb_setCardType_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetCardType_Ljava_lang_String_Handler ()
			{
				if (cb_setCardType_Ljava_lang_String_ == null)
					cb_setCardType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetCardType_Ljava_lang_String_);
				return cb_setCardType_Ljava_lang_String_;
			}

			static void n_SetCardType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cardType)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.GIdData.DG11> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var cardType = JNIEnv.GetString (native_cardType, JniHandleOwnership.DoNotTransfer);
				__this.CardType = cardType;
			}
#pragma warning restore 0169

			static IntPtr id_getCardType;
			static IntPtr id_setCardType_Ljava_lang_String_;
			public virtual unsafe string CardType {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData.DG11']/method[@name='getCardType' and count(parameter)=0]"
				[Register ("getCardType", "()Ljava/lang/String;", "GetGetCardTypeHandler")]
				get {
					if (id_getCardType == IntPtr.Zero)
						id_getCardType = JNIEnv.GetMethodID (class_ref, "getCardType", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCardType), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCardType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData.DG11']/method[@name='setCardType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setCardType", "(Ljava/lang/String;)V", "GetSetCardType_Ljava_lang_String_Handler")]
				set {
					if (id_setCardType_Ljava_lang_String_ == IntPtr.Zero)
						id_setCardType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCardType", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCardType_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCardType", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData.DG2']"
		[global::Android.Runtime.Register ("com/credenceid/icao/GIdData$DG2", DoNotGenerateAcw=true)]
		public partial class DG2 : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/credenceid/icao/GIdData$DG2", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DG2); }
			}

			protected DG2 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_credenceid_icao_GIdData_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData.DG2']/constructor[@name='GIdData.DG2' and count(parameter)=1 and parameter[1][@type='com.credenceid.icao.GIdData']]"
			[Register (".ctor", "(Lcom/credenceid/icao/GIdData;)V", "")]
			public unsafe DG2 (global::Com.Credenceid.Icao.GIdData __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (((object) this).GetType () != typeof (DG2)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lcom_credenceid_icao_GIdData_ == IntPtr.Zero)
						id_ctor_Lcom_credenceid_icao_GIdData_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/credenceid/icao/GIdData;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_credenceid_icao_GIdData_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_credenceid_icao_GIdData_, __args);
				} finally {
				}
			}

			static Delegate cb_getFaceImage;
#pragma warning disable 0169
			static Delegate GetGetFaceImageHandler ()
			{
				if (cb_getFaceImage == null)
					cb_getFaceImage = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFaceImage);
				return cb_getFaceImage;
			}

			static IntPtr n_GetFaceImage (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.GIdData.DG2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.FaceImage);
			}
#pragma warning restore 0169

			static Delegate cb_setFaceImage_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
			static Delegate GetSetFaceImage_Landroid_graphics_Bitmap_Handler ()
			{
				if (cb_setFaceImage_Landroid_graphics_Bitmap_ == null)
					cb_setFaceImage_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetFaceImage_Landroid_graphics_Bitmap_);
				return cb_setFaceImage_Landroid_graphics_Bitmap_;
			}

			static void n_SetFaceImage_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_faceBitmap)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.GIdData.DG2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var faceBitmap = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_faceBitmap, JniHandleOwnership.DoNotTransfer);
				__this.FaceImage = faceBitmap;
			}
#pragma warning restore 0169

			static IntPtr id_getFaceImage;
			static IntPtr id_setFaceImage_Landroid_graphics_Bitmap_;
			public virtual unsafe global::Android.Graphics.Bitmap FaceImage {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData.DG2']/method[@name='getFaceImage' and count(parameter)=0]"
				[Register ("getFaceImage", "()Landroid/graphics/Bitmap;", "GetGetFaceImageHandler")]
				get {
					if (id_getFaceImage == IntPtr.Zero)
						id_getFaceImage = JNIEnv.GetMethodID (class_ref, "getFaceImage", "()Landroid/graphics/Bitmap;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFaceImage), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFaceImage", "()Landroid/graphics/Bitmap;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData.DG2']/method[@name='setFaceImage' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
				[Register ("setFaceImage", "(Landroid/graphics/Bitmap;)V", "GetSetFaceImage_Landroid_graphics_Bitmap_Handler")]
				set {
					if (id_setFaceImage_Landroid_graphics_Bitmap_ == IntPtr.Zero)
						id_setFaceImage_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "setFaceImage", "(Landroid/graphics/Bitmap;)V");
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFaceImage_Landroid_graphics_Bitmap_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFaceImage", "(Landroid/graphics/Bitmap;)V"), __args);
					} finally {
					}
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData.DG3']"
		[global::Android.Runtime.Register ("com/credenceid/icao/GIdData$DG3", DoNotGenerateAcw=true)]
		public partial class DG3 : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/credenceid/icao/GIdData$DG3", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DG3); }
			}

			protected DG3 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_credenceid_icao_GIdData_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData.DG3']/constructor[@name='GIdData.DG3' and count(parameter)=1 and parameter[1][@type='com.credenceid.icao.GIdData']]"
			[Register (".ctor", "(Lcom/credenceid/icao/GIdData;)V", "")]
			public unsafe DG3 (global::Com.Credenceid.Icao.GIdData __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (((object) this).GetType () != typeof (DG3)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lcom_credenceid_icao_GIdData_ == IntPtr.Zero)
						id_ctor_Lcom_credenceid_icao_GIdData_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/credenceid/icao/GIdData;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_credenceid_icao_GIdData_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_credenceid_icao_GIdData_, __args);
				} finally {
				}
			}

			static Delegate cb_getDescription;
#pragma warning disable 0169
			static Delegate GetGetDescriptionHandler ()
			{
				if (cb_getDescription == null)
					cb_getDescription = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDescription);
				return cb_getDescription;
			}

			static IntPtr n_GetDescription (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.GIdData.DG3> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Description);
			}
#pragma warning restore 0169

			static Delegate cb_setDescription_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetDescription_Ljava_lang_String_Handler ()
			{
				if (cb_setDescription_Ljava_lang_String_ == null)
					cb_setDescription_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetDescription_Ljava_lang_String_);
				return cb_setDescription_Ljava_lang_String_;
			}

			static void n_SetDescription_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_description)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.GIdData.DG3> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var description = JNIEnv.GetString (native_description, JniHandleOwnership.DoNotTransfer);
				__this.Description = description;
			}
#pragma warning restore 0169

			static IntPtr id_getDescription;
			static IntPtr id_setDescription_Ljava_lang_String_;
			public virtual unsafe string Description {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData.DG3']/method[@name='getDescription' and count(parameter)=0]"
				[Register ("getDescription", "()Ljava/lang/String;", "GetGetDescriptionHandler")]
				get {
					if (id_getDescription == IntPtr.Zero)
						id_getDescription = JNIEnv.GetMethodID (class_ref, "getDescription", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDescription), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDescription", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData.DG3']/method[@name='setDescription' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setDescription", "(Ljava/lang/String;)V", "GetSetDescription_Ljava_lang_String_Handler")]
				set {
					if (id_setDescription_Ljava_lang_String_ == IntPtr.Zero)
						id_setDescription_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDescription", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDescription_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDescription", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getStreetAddress;
#pragma warning disable 0169
			static Delegate GetGetStreetAddressHandler ()
			{
				if (cb_getStreetAddress == null)
					cb_getStreetAddress = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetStreetAddress);
				return cb_getStreetAddress;
			}

			static IntPtr n_GetStreetAddress (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.GIdData.DG3> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.StreetAddress);
			}
#pragma warning restore 0169

			static Delegate cb_setStreetAddress_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetStreetAddress_Ljava_lang_String_Handler ()
			{
				if (cb_setStreetAddress_Ljava_lang_String_ == null)
					cb_setStreetAddress_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetStreetAddress_Ljava_lang_String_);
				return cb_setStreetAddress_Ljava_lang_String_;
			}

			static void n_SetStreetAddress_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_streetAddress)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.GIdData.DG3> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var streetAddress = JNIEnv.GetString (native_streetAddress, JniHandleOwnership.DoNotTransfer);
				__this.StreetAddress = streetAddress;
			}
#pragma warning restore 0169

			static IntPtr id_getStreetAddress;
			static IntPtr id_setStreetAddress_Ljava_lang_String_;
			public virtual unsafe string StreetAddress {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData.DG3']/method[@name='getStreetAddress' and count(parameter)=0]"
				[Register ("getStreetAddress", "()Ljava/lang/String;", "GetGetStreetAddressHandler")]
				get {
					if (id_getStreetAddress == IntPtr.Zero)
						id_getStreetAddress = JNIEnv.GetMethodID (class_ref, "getStreetAddress", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStreetAddress), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStreetAddress", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData.DG3']/method[@name='setStreetAddress' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setStreetAddress", "(Ljava/lang/String;)V", "GetSetStreetAddress_Ljava_lang_String_Handler")]
				set {
					if (id_setStreetAddress_Ljava_lang_String_ == IntPtr.Zero)
						id_setStreetAddress_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setStreetAddress", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStreetAddress_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStreetAddress", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getStreetNumber;
#pragma warning disable 0169
			static Delegate GetGetStreetNumberHandler ()
			{
				if (cb_getStreetNumber == null)
					cb_getStreetNumber = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetStreetNumber);
				return cb_getStreetNumber;
			}

			static IntPtr n_GetStreetNumber (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.GIdData.DG3> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.StreetNumber);
			}
#pragma warning restore 0169

			static Delegate cb_setStreetNumber_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetStreetNumber_Ljava_lang_String_Handler ()
			{
				if (cb_setStreetNumber_Ljava_lang_String_ == null)
					cb_setStreetNumber_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetStreetNumber_Ljava_lang_String_);
				return cb_setStreetNumber_Ljava_lang_String_;
			}

			static void n_SetStreetNumber_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_streetNumber)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.GIdData.DG3> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var streetNumber = JNIEnv.GetString (native_streetNumber, JniHandleOwnership.DoNotTransfer);
				__this.StreetNumber = streetNumber;
			}
#pragma warning restore 0169

			static IntPtr id_getStreetNumber;
			static IntPtr id_setStreetNumber_Ljava_lang_String_;
			public virtual unsafe string StreetNumber {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData.DG3']/method[@name='getStreetNumber' and count(parameter)=0]"
				[Register ("getStreetNumber", "()Ljava/lang/String;", "GetGetStreetNumberHandler")]
				get {
					if (id_getStreetNumber == IntPtr.Zero)
						id_getStreetNumber = JNIEnv.GetMethodID (class_ref, "getStreetNumber", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStreetNumber), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStreetNumber", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData.DG3']/method[@name='setStreetNumber' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setStreetNumber", "(Ljava/lang/String;)V", "GetSetStreetNumber_Ljava_lang_String_Handler")]
				set {
					if (id_setStreetNumber_Ljava_lang_String_ == IntPtr.Zero)
						id_setStreetNumber_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setStreetNumber", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStreetNumber_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStreetNumber", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData.DG4']"
		[global::Android.Runtime.Register ("com/credenceid/icao/GIdData$DG4", DoNotGenerateAcw=true)]
		public partial class DG4 : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/credenceid/icao/GIdData$DG4", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DG4); }
			}

			protected DG4 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_credenceid_icao_GIdData_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData.DG4']/constructor[@name='GIdData.DG4' and count(parameter)=1 and parameter[1][@type='com.credenceid.icao.GIdData']]"
			[Register (".ctor", "(Lcom/credenceid/icao/GIdData;)V", "")]
			public unsafe DG4 (global::Com.Credenceid.Icao.GIdData __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (((object) this).GetType () != typeof (DG4)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lcom_credenceid_icao_GIdData_ == IntPtr.Zero)
						id_ctor_Lcom_credenceid_icao_GIdData_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/credenceid/icao/GIdData;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_credenceid_icao_GIdData_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_credenceid_icao_GIdData_, __args);
				} finally {
				}
			}

			static Delegate cb_getCityLocation;
#pragma warning disable 0169
			static Delegate GetGetCityLocationHandler ()
			{
				if (cb_getCityLocation == null)
					cb_getCityLocation = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCityLocation);
				return cb_getCityLocation;
			}

			static IntPtr n_GetCityLocation (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.GIdData.DG4> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.CityLocation);
			}
#pragma warning restore 0169

			static Delegate cb_setCityLocation_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetCityLocation_Ljava_lang_String_Handler ()
			{
				if (cb_setCityLocation_Ljava_lang_String_ == null)
					cb_setCityLocation_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetCityLocation_Ljava_lang_String_);
				return cb_setCityLocation_Ljava_lang_String_;
			}

			static void n_SetCityLocation_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cityLocation)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.GIdData.DG4> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var cityLocation = JNIEnv.GetString (native_cityLocation, JniHandleOwnership.DoNotTransfer);
				__this.CityLocation = cityLocation;
			}
#pragma warning restore 0169

			static IntPtr id_getCityLocation;
			static IntPtr id_setCityLocation_Ljava_lang_String_;
			public virtual unsafe string CityLocation {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData.DG4']/method[@name='getCityLocation' and count(parameter)=0]"
				[Register ("getCityLocation", "()Ljava/lang/String;", "GetGetCityLocationHandler")]
				get {
					if (id_getCityLocation == IntPtr.Zero)
						id_getCityLocation = JNIEnv.GetMethodID (class_ref, "getCityLocation", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCityLocation), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCityLocation", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData.DG4']/method[@name='setCityLocation' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setCityLocation", "(Ljava/lang/String;)V", "GetSetCityLocation_Ljava_lang_String_Handler")]
				set {
					if (id_setCityLocation_Ljava_lang_String_ == IntPtr.Zero)
						id_setCityLocation_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCityLocation", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCityLocation_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCityLocation", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getCountryOfResidenceLocation;
#pragma warning disable 0169
			static Delegate GetGetCountryOfResidenceLocationHandler ()
			{
				if (cb_getCountryOfResidenceLocation == null)
					cb_getCountryOfResidenceLocation = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCountryOfResidenceLocation);
				return cb_getCountryOfResidenceLocation;
			}

			static IntPtr n_GetCountryOfResidenceLocation (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.GIdData.DG4> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.CountryOfResidenceLocation);
			}
#pragma warning restore 0169

			static Delegate cb_setCountryOfResidenceLocation_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetCountryOfResidenceLocation_Ljava_lang_String_Handler ()
			{
				if (cb_setCountryOfResidenceLocation_Ljava_lang_String_ == null)
					cb_setCountryOfResidenceLocation_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetCountryOfResidenceLocation_Ljava_lang_String_);
				return cb_setCountryOfResidenceLocation_Ljava_lang_String_;
			}

			static void n_SetCountryOfResidenceLocation_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_countryOfResidenceLocation)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.GIdData.DG4> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var countryOfResidenceLocation = JNIEnv.GetString (native_countryOfResidenceLocation, JniHandleOwnership.DoNotTransfer);
				__this.CountryOfResidenceLocation = countryOfResidenceLocation;
			}
#pragma warning restore 0169

			static IntPtr id_getCountryOfResidenceLocation;
			static IntPtr id_setCountryOfResidenceLocation_Ljava_lang_String_;
			public virtual unsafe string CountryOfResidenceLocation {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData.DG4']/method[@name='getCountryOfResidenceLocation' and count(parameter)=0]"
				[Register ("getCountryOfResidenceLocation", "()Ljava/lang/String;", "GetGetCountryOfResidenceLocationHandler")]
				get {
					if (id_getCountryOfResidenceLocation == IntPtr.Zero)
						id_getCountryOfResidenceLocation = JNIEnv.GetMethodID (class_ref, "getCountryOfResidenceLocation", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCountryOfResidenceLocation), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCountryOfResidenceLocation", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData.DG4']/method[@name='setCountryOfResidenceLocation' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setCountryOfResidenceLocation", "(Ljava/lang/String;)V", "GetSetCountryOfResidenceLocation_Ljava_lang_String_Handler")]
				set {
					if (id_setCountryOfResidenceLocation_Ljava_lang_String_ == IntPtr.Zero)
						id_setCountryOfResidenceLocation_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCountryOfResidenceLocation", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCountryOfResidenceLocation_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCountryOfResidenceLocation", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getZipLocation;
#pragma warning disable 0169
			static Delegate GetGetZipLocationHandler ()
			{
				if (cb_getZipLocation == null)
					cb_getZipLocation = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetZipLocation);
				return cb_getZipLocation;
			}

			static IntPtr n_GetZipLocation (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.GIdData.DG4> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ZipLocation);
			}
#pragma warning restore 0169

			static Delegate cb_setZipLocation_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetZipLocation_Ljava_lang_String_Handler ()
			{
				if (cb_setZipLocation_Ljava_lang_String_ == null)
					cb_setZipLocation_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetZipLocation_Ljava_lang_String_);
				return cb_setZipLocation_Ljava_lang_String_;
			}

			static void n_SetZipLocation_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_zipLocation)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.GIdData.DG4> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var zipLocation = JNIEnv.GetString (native_zipLocation, JniHandleOwnership.DoNotTransfer);
				__this.ZipLocation = zipLocation;
			}
#pragma warning restore 0169

			static IntPtr id_getZipLocation;
			static IntPtr id_setZipLocation_Ljava_lang_String_;
			public virtual unsafe string ZipLocation {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData.DG4']/method[@name='getZipLocation' and count(parameter)=0]"
				[Register ("getZipLocation", "()Ljava/lang/String;", "GetGetZipLocationHandler")]
				get {
					if (id_getZipLocation == IntPtr.Zero)
						id_getZipLocation = JNIEnv.GetMethodID (class_ref, "getZipLocation", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getZipLocation), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getZipLocation", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData.DG4']/method[@name='setZipLocation' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setZipLocation", "(Ljava/lang/String;)V", "GetSetZipLocation_Ljava_lang_String_Handler")]
				set {
					if (id_setZipLocation_Ljava_lang_String_ == IntPtr.Zero)
						id_setZipLocation_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setZipLocation", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setZipLocation_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setZipLocation", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData.DG5']"
		[global::Android.Runtime.Register ("com/credenceid/icao/GIdData$DG5", DoNotGenerateAcw=true)]
		public partial class DG5 : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/credenceid/icao/GIdData$DG5", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DG5); }
			}

			protected DG5 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_credenceid_icao_GIdData_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData.DG5']/constructor[@name='GIdData.DG5' and count(parameter)=1 and parameter[1][@type='com.credenceid.icao.GIdData']]"
			[Register (".ctor", "(Lcom/credenceid/icao/GIdData;)V", "")]
			public unsafe DG5 (global::Com.Credenceid.Icao.GIdData __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (((object) this).GetType () != typeof (DG5)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lcom_credenceid_icao_GIdData_ == IntPtr.Zero)
						id_ctor_Lcom_credenceid_icao_GIdData_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/credenceid/icao/GIdData;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_credenceid_icao_GIdData_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_credenceid_icao_GIdData_, __args);
				} finally {
				}
			}

			static Delegate cb_getDateOfBirth;
#pragma warning disable 0169
			static Delegate GetGetDateOfBirthHandler ()
			{
				if (cb_getDateOfBirth == null)
					cb_getDateOfBirth = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDateOfBirth);
				return cb_getDateOfBirth;
			}

			static IntPtr n_GetDateOfBirth (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.GIdData.DG5> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.DateOfBirth);
			}
#pragma warning restore 0169

			static Delegate cb_setDateOfBirth_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetDateOfBirth_Ljava_lang_String_Handler ()
			{
				if (cb_setDateOfBirth_Ljava_lang_String_ == null)
					cb_setDateOfBirth_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetDateOfBirth_Ljava_lang_String_);
				return cb_setDateOfBirth_Ljava_lang_String_;
			}

			static void n_SetDateOfBirth_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dateOfBirth)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.GIdData.DG5> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var dateOfBirth = JNIEnv.GetString (native_dateOfBirth, JniHandleOwnership.DoNotTransfer);
				__this.DateOfBirth = dateOfBirth;
			}
#pragma warning restore 0169

			static IntPtr id_getDateOfBirth;
			static IntPtr id_setDateOfBirth_Ljava_lang_String_;
			public virtual unsafe string DateOfBirth {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData.DG5']/method[@name='getDateOfBirth' and count(parameter)=0]"
				[Register ("getDateOfBirth", "()Ljava/lang/String;", "GetGetDateOfBirthHandler")]
				get {
					if (id_getDateOfBirth == IntPtr.Zero)
						id_getDateOfBirth = JNIEnv.GetMethodID (class_ref, "getDateOfBirth", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDateOfBirth), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDateOfBirth", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData.DG5']/method[@name='setDateOfBirth' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setDateOfBirth", "(Ljava/lang/String;)V", "GetSetDateOfBirth_Ljava_lang_String_Handler")]
				set {
					if (id_setDateOfBirth_Ljava_lang_String_ == IntPtr.Zero)
						id_setDateOfBirth_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDateOfBirth", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDateOfBirth_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDateOfBirth", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData.DG6']"
		[global::Android.Runtime.Register ("com/credenceid/icao/GIdData$DG6", DoNotGenerateAcw=true)]
		public partial class DG6 : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/credenceid/icao/GIdData$DG6", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DG6); }
			}

			protected DG6 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_credenceid_icao_GIdData_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData.DG6']/constructor[@name='GIdData.DG6' and count(parameter)=1 and parameter[1][@type='com.credenceid.icao.GIdData']]"
			[Register (".ctor", "(Lcom/credenceid/icao/GIdData;)V", "")]
			public unsafe DG6 (global::Com.Credenceid.Icao.GIdData __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (((object) this).GetType () != typeof (DG6)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lcom_credenceid_icao_GIdData_ == IntPtr.Zero)
						id_ctor_Lcom_credenceid_icao_GIdData_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/credenceid/icao/GIdData;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_credenceid_icao_GIdData_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_credenceid_icao_GIdData_, __args);
				} finally {
				}
			}

			static Delegate cb_getNin;
#pragma warning disable 0169
			static Delegate GetGetNinHandler ()
			{
				if (cb_getNin == null)
					cb_getNin = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetNin);
				return cb_getNin;
			}

			static IntPtr n_GetNin (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.GIdData.DG6> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Nin);
			}
#pragma warning restore 0169

			static Delegate cb_setNin_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetNin_Ljava_lang_String_Handler ()
			{
				if (cb_setNin_Ljava_lang_String_ == null)
					cb_setNin_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetNin_Ljava_lang_String_);
				return cb_setNin_Ljava_lang_String_;
			}

			static void n_SetNin_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_nin)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.GIdData.DG6> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var nin = JNIEnv.GetString (native_nin, JniHandleOwnership.DoNotTransfer);
				__this.Nin = nin;
			}
#pragma warning restore 0169

			static IntPtr id_getNin;
			static IntPtr id_setNin_Ljava_lang_String_;
			public virtual unsafe string Nin {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData.DG6']/method[@name='getNin' and count(parameter)=0]"
				[Register ("getNin", "()Ljava/lang/String;", "GetGetNinHandler")]
				get {
					if (id_getNin == IntPtr.Zero)
						id_getNin = JNIEnv.GetMethodID (class_ref, "getNin", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNin), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNin", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData.DG6']/method[@name='setNin' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setNin", "(Ljava/lang/String;)V", "GetSetNin_Ljava_lang_String_Handler")]
				set {
					if (id_setNin_Ljava_lang_String_ == IntPtr.Zero)
						id_setNin_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setNin", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNin_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNin", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData.DG7']"
		[global::Android.Runtime.Register ("com/credenceid/icao/GIdData$DG7", DoNotGenerateAcw=true)]
		public partial class DG7 : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/credenceid/icao/GIdData$DG7", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DG7); }
			}

			protected DG7 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_credenceid_icao_GIdData_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData.DG7']/constructor[@name='GIdData.DG7' and count(parameter)=1 and parameter[1][@type='com.credenceid.icao.GIdData']]"
			[Register (".ctor", "(Lcom/credenceid/icao/GIdData;)V", "")]
			public unsafe DG7 (global::Com.Credenceid.Icao.GIdData __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (((object) this).GetType () != typeof (DG7)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lcom_credenceid_icao_GIdData_ == IntPtr.Zero)
						id_ctor_Lcom_credenceid_icao_GIdData_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/credenceid/icao/GIdData;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_credenceid_icao_GIdData_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_credenceid_icao_GIdData_, __args);
				} finally {
				}
			}

			static Delegate cb_getTrackingNumber;
#pragma warning disable 0169
			static Delegate GetGetTrackingNumberHandler ()
			{
				if (cb_getTrackingNumber == null)
					cb_getTrackingNumber = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTrackingNumber);
				return cb_getTrackingNumber;
			}

			static IntPtr n_GetTrackingNumber (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.GIdData.DG7> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.TrackingNumber);
			}
#pragma warning restore 0169

			static Delegate cb_setTrackingNumber_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetTrackingNumber_Ljava_lang_String_Handler ()
			{
				if (cb_setTrackingNumber_Ljava_lang_String_ == null)
					cb_setTrackingNumber_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetTrackingNumber_Ljava_lang_String_);
				return cb_setTrackingNumber_Ljava_lang_String_;
			}

			static void n_SetTrackingNumber_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_trackingNumber)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.GIdData.DG7> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var trackingNumber = JNIEnv.GetString (native_trackingNumber, JniHandleOwnership.DoNotTransfer);
				__this.TrackingNumber = trackingNumber;
			}
#pragma warning restore 0169

			static IntPtr id_getTrackingNumber;
			static IntPtr id_setTrackingNumber_Ljava_lang_String_;
			public virtual unsafe string TrackingNumber {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData.DG7']/method[@name='getTrackingNumber' and count(parameter)=0]"
				[Register ("getTrackingNumber", "()Ljava/lang/String;", "GetGetTrackingNumberHandler")]
				get {
					if (id_getTrackingNumber == IntPtr.Zero)
						id_getTrackingNumber = JNIEnv.GetMethodID (class_ref, "getTrackingNumber", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTrackingNumber), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTrackingNumber", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData.DG7']/method[@name='setTrackingNumber' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setTrackingNumber", "(Ljava/lang/String;)V", "GetSetTrackingNumber_Ljava_lang_String_Handler")]
				set {
					if (id_setTrackingNumber_Ljava_lang_String_ == IntPtr.Zero)
						id_setTrackingNumber_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTrackingNumber", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTrackingNumber_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTrackingNumber", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData.DG8']"
		[global::Android.Runtime.Register ("com/credenceid/icao/GIdData$DG8", DoNotGenerateAcw=true)]
		public partial class DG8 : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/credenceid/icao/GIdData$DG8", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DG8); }
			}

			protected DG8 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_credenceid_icao_GIdData_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData.DG8']/constructor[@name='GIdData.DG8' and count(parameter)=1 and parameter[1][@type='com.credenceid.icao.GIdData']]"
			[Register (".ctor", "(Lcom/credenceid/icao/GIdData;)V", "")]
			public unsafe DG8 (global::Com.Credenceid.Icao.GIdData __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (((object) this).GetType () != typeof (DG8)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lcom_credenceid_icao_GIdData_ == IntPtr.Zero)
						id_ctor_Lcom_credenceid_icao_GIdData_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/credenceid/icao/GIdData;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_credenceid_icao_GIdData_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_credenceid_icao_GIdData_, __args);
				} finally {
				}
			}

			static Delegate cb_getNextOfKin;
#pragma warning disable 0169
			static Delegate GetGetNextOfKinHandler ()
			{
				if (cb_getNextOfKin == null)
					cb_getNextOfKin = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetNextOfKin);
				return cb_getNextOfKin;
			}

			static IntPtr n_GetNextOfKin (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.GIdData.DG8> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.NextOfKin);
			}
#pragma warning restore 0169

			static Delegate cb_setNextOfKin_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetNextOfKin_Ljava_lang_String_Handler ()
			{
				if (cb_setNextOfKin_Ljava_lang_String_ == null)
					cb_setNextOfKin_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetNextOfKin_Ljava_lang_String_);
				return cb_setNextOfKin_Ljava_lang_String_;
			}

			static void n_SetNextOfKin_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_nextOfKin)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.GIdData.DG8> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var nextOfKin = JNIEnv.GetString (native_nextOfKin, JniHandleOwnership.DoNotTransfer);
				__this.NextOfKin = nextOfKin;
			}
#pragma warning restore 0169

			static IntPtr id_getNextOfKin;
			static IntPtr id_setNextOfKin_Ljava_lang_String_;
			public virtual unsafe string NextOfKin {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData.DG8']/method[@name='getNextOfKin' and count(parameter)=0]"
				[Register ("getNextOfKin", "()Ljava/lang/String;", "GetGetNextOfKinHandler")]
				get {
					if (id_getNextOfKin == IntPtr.Zero)
						id_getNextOfKin = JNIEnv.GetMethodID (class_ref, "getNextOfKin", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNextOfKin), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNextOfKin", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData.DG8']/method[@name='setNextOfKin' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setNextOfKin", "(Ljava/lang/String;)V", "GetSetNextOfKin_Ljava_lang_String_Handler")]
				set {
					if (id_setNextOfKin_Ljava_lang_String_ == IntPtr.Zero)
						id_setNextOfKin_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setNextOfKin", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNextOfKin_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNextOfKin", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData.DG9']"
		[global::Android.Runtime.Register ("com/credenceid/icao/GIdData$DG9", DoNotGenerateAcw=true)]
		public partial class DG9 : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/credenceid/icao/GIdData$DG9", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DG9); }
			}

			protected DG9 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_credenceid_icao_GIdData_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData.DG9']/constructor[@name='GIdData.DG9' and count(parameter)=1 and parameter[1][@type='com.credenceid.icao.GIdData']]"
			[Register (".ctor", "(Lcom/credenceid/icao/GIdData;)V", "")]
			public unsafe DG9 (global::Com.Credenceid.Icao.GIdData __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (((object) this).GetType () != typeof (DG9)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lcom_credenceid_icao_GIdData_ == IntPtr.Zero)
						id_ctor_Lcom_credenceid_icao_GIdData_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/credenceid/icao/GIdData;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_credenceid_icao_GIdData_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_credenceid_icao_GIdData_, __args);
				} finally {
				}
			}

			static Delegate cb_getValidityDate;
#pragma warning disable 0169
			static Delegate GetGetValidityDateHandler ()
			{
				if (cb_getValidityDate == null)
					cb_getValidityDate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetValidityDate);
				return cb_getValidityDate;
			}

			static IntPtr n_GetValidityDate (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.GIdData.DG9> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ValidityDate);
			}
#pragma warning restore 0169

			static Delegate cb_setValidityDate_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetValidityDate_Ljava_lang_String_Handler ()
			{
				if (cb_setValidityDate_Ljava_lang_String_ == null)
					cb_setValidityDate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetValidityDate_Ljava_lang_String_);
				return cb_setValidityDate_Ljava_lang_String_;
			}

			static void n_SetValidityDate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_validityDate)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.GIdData.DG9> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var validityDate = JNIEnv.GetString (native_validityDate, JniHandleOwnership.DoNotTransfer);
				__this.ValidityDate = validityDate;
			}
#pragma warning restore 0169

			static IntPtr id_getValidityDate;
			static IntPtr id_setValidityDate_Ljava_lang_String_;
			public virtual unsafe string ValidityDate {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData.DG9']/method[@name='getValidityDate' and count(parameter)=0]"
				[Register ("getValidityDate", "()Ljava/lang/String;", "GetGetValidityDateHandler")]
				get {
					if (id_getValidityDate == IntPtr.Zero)
						id_getValidityDate = JNIEnv.GetMethodID (class_ref, "getValidityDate", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getValidityDate), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getValidityDate", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData.DG9']/method[@name='setValidityDate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setValidityDate", "(Ljava/lang/String;)V", "GetSetValidityDate_Ljava_lang_String_Handler")]
				set {
					if (id_setValidityDate_Ljava_lang_String_ == IntPtr.Zero)
						id_setValidityDate_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setValidityDate", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setValidityDate_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setValidityDate", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/credenceid/icao/GIdData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GIdData); }
		}

		protected GIdData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GIdData']/constructor[@name='GIdData' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GIdData ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GIdData)) {
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

	}
}
