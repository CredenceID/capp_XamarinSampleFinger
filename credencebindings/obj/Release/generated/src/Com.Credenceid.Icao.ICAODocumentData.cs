using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Credenceid.Icao {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData']"
	[global::Android.Runtime.Register ("com/credenceid/icao/ICAODocumentData", DoNotGenerateAcw=true)]
	public partial class ICAODocumentData : global::Java.Lang.Object, global::Java.IO.ISerializable {


		static IntPtr DG1_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData']/field[@name='DG1']"
		[Register ("DG1")]
		public global::Com.Credenceid.Icao.ICAODocumentData.DG1 Dg1 {
			get {
				if (DG1_jfieldId == IntPtr.Zero)
					DG1_jfieldId = JNIEnv.GetFieldID (class_ref, "DG1", "Lcom/credenceid/icao/ICAODocumentData$DG1;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, DG1_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG1> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DG1_jfieldId == IntPtr.Zero)
					DG1_jfieldId = JNIEnv.GetFieldID (class_ref, "DG1", "Lcom/credenceid/icao/ICAODocumentData$DG1;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, DG1_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr DG11_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData']/field[@name='DG11']"
		[Register ("DG11")]
		public global::Com.Credenceid.Icao.ICAODocumentData.DG11 Dg11 {
			get {
				if (DG11_jfieldId == IntPtr.Zero)
					DG11_jfieldId = JNIEnv.GetFieldID (class_ref, "DG11", "Lcom/credenceid/icao/ICAODocumentData$DG11;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, DG11_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG11> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DG11_jfieldId == IntPtr.Zero)
					DG11_jfieldId = JNIEnv.GetFieldID (class_ref, "DG11", "Lcom/credenceid/icao/ICAODocumentData$DG11;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, DG11_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr DG12_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData']/field[@name='DG12']"
		[Register ("DG12")]
		public global::Com.Credenceid.Icao.ICAODocumentData.DG12 Dg12 {
			get {
				if (DG12_jfieldId == IntPtr.Zero)
					DG12_jfieldId = JNIEnv.GetFieldID (class_ref, "DG12", "Lcom/credenceid/icao/ICAODocumentData$DG12;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, DG12_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG12> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DG12_jfieldId == IntPtr.Zero)
					DG12_jfieldId = JNIEnv.GetFieldID (class_ref, "DG12", "Lcom/credenceid/icao/ICAODocumentData$DG12;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, DG12_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr DG2_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData']/field[@name='DG2']"
		[Register ("DG2")]
		public global::Com.Credenceid.Icao.ICAODocumentData.DG2 Dg2 {
			get {
				if (DG2_jfieldId == IntPtr.Zero)
					DG2_jfieldId = JNIEnv.GetFieldID (class_ref, "DG2", "Lcom/credenceid/icao/ICAODocumentData$DG2;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, DG2_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG2> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DG2_jfieldId == IntPtr.Zero)
					DG2_jfieldId = JNIEnv.GetFieldID (class_ref, "DG2", "Lcom/credenceid/icao/ICAODocumentData$DG2;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, DG2_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr DG3_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData']/field[@name='DG3']"
		[Register ("DG3")]
		public global::Com.Credenceid.Icao.ICAODocumentData.DG3 Dg3 {
			get {
				if (DG3_jfieldId == IntPtr.Zero)
					DG3_jfieldId = JNIEnv.GetFieldID (class_ref, "DG3", "Lcom/credenceid/icao/ICAODocumentData$DG3;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, DG3_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG3> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DG3_jfieldId == IntPtr.Zero)
					DG3_jfieldId = JNIEnv.GetFieldID (class_ref, "DG3", "Lcom/credenceid/icao/ICAODocumentData$DG3;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, DG3_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr DG7_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData']/field[@name='DG7']"
		[Register ("DG7")]
		public global::Com.Credenceid.Icao.ICAODocumentData.DG7 Dg7 {
			get {
				if (DG7_jfieldId == IntPtr.Zero)
					DG7_jfieldId = JNIEnv.GetFieldID (class_ref, "DG7", "Lcom/credenceid/icao/ICAODocumentData$DG7;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, DG7_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG7> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DG7_jfieldId == IntPtr.Zero)
					DG7_jfieldId = JNIEnv.GetFieldID (class_ref, "DG7", "Lcom/credenceid/icao/ICAODocumentData$DG7;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, DG7_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG1']"
		[global::Android.Runtime.Register ("com/credenceid/icao/ICAODocumentData$DG1", DoNotGenerateAcw=true)]
		public partial class DG1 : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/credenceid/icao/ICAODocumentData$DG1", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DG1); }
			}

			protected DG1 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_credenceid_icao_ICAODocumentData_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG1']/constructor[@name='ICAODocumentData.DG1' and count(parameter)=1 and parameter[1][@type='com.credenceid.icao.ICAODocumentData']]"
			[Register (".ctor", "(Lcom/credenceid/icao/ICAODocumentData;)V", "")]
			public unsafe DG1 (global::Com.Credenceid.Icao.ICAODocumentData __self)
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

					if (id_ctor_Lcom_credenceid_icao_ICAODocumentData_ == IntPtr.Zero)
						id_ctor_Lcom_credenceid_icao_ICAODocumentData_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/credenceid/icao/ICAODocumentData;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_credenceid_icao_ICAODocumentData_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_credenceid_icao_ICAODocumentData_, __args);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var dateOfBirth = JNIEnv.GetString (native_dateOfBirth, JniHandleOwnership.DoNotTransfer);
				__this.DateOfBirth = dateOfBirth;
			}
#pragma warning restore 0169

			static IntPtr id_getDateOfBirth;
			static IntPtr id_setDateOfBirth_Ljava_lang_String_;
			public virtual unsafe string DateOfBirth {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG1']/method[@name='getDateOfBirth' and count(parameter)=0]"
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
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG1']/method[@name='setDateOfBirth' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

			static Delegate cb_getDateOfExpiry;
#pragma warning disable 0169
			static Delegate GetGetDateOfExpiryHandler ()
			{
				if (cb_getDateOfExpiry == null)
					cb_getDateOfExpiry = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDateOfExpiry);
				return cb_getDateOfExpiry;
			}

			static IntPtr n_GetDateOfExpiry (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.DateOfExpiry);
			}
#pragma warning restore 0169

			static Delegate cb_setDateOfExpiry_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetDateOfExpiry_Ljava_lang_String_Handler ()
			{
				if (cb_setDateOfExpiry_Ljava_lang_String_ == null)
					cb_setDateOfExpiry_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetDateOfExpiry_Ljava_lang_String_);
				return cb_setDateOfExpiry_Ljava_lang_String_;
			}

			static void n_SetDateOfExpiry_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dateOfExpiry)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var dateOfExpiry = JNIEnv.GetString (native_dateOfExpiry, JniHandleOwnership.DoNotTransfer);
				__this.DateOfExpiry = dateOfExpiry;
			}
#pragma warning restore 0169

			static IntPtr id_getDateOfExpiry;
			static IntPtr id_setDateOfExpiry_Ljava_lang_String_;
			public virtual unsafe string DateOfExpiry {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG1']/method[@name='getDateOfExpiry' and count(parameter)=0]"
				[Register ("getDateOfExpiry", "()Ljava/lang/String;", "GetGetDateOfExpiryHandler")]
				get {
					if (id_getDateOfExpiry == IntPtr.Zero)
						id_getDateOfExpiry = JNIEnv.GetMethodID (class_ref, "getDateOfExpiry", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDateOfExpiry), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDateOfExpiry", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG1']/method[@name='setDateOfExpiry' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setDateOfExpiry", "(Ljava/lang/String;)V", "GetSetDateOfExpiry_Ljava_lang_String_Handler")]
				set {
					if (id_setDateOfExpiry_Ljava_lang_String_ == IntPtr.Zero)
						id_setDateOfExpiry_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDateOfExpiry", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDateOfExpiry_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDateOfExpiry", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getDocumentCode;
#pragma warning disable 0169
			static Delegate GetGetDocumentCodeHandler ()
			{
				if (cb_getDocumentCode == null)
					cb_getDocumentCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDocumentCode);
				return cb_getDocumentCode;
			}

			static IntPtr n_GetDocumentCode (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.DocumentCode);
			}
#pragma warning restore 0169

			static Delegate cb_setDocumentCode_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetDocumentCode_Ljava_lang_String_Handler ()
			{
				if (cb_setDocumentCode_Ljava_lang_String_ == null)
					cb_setDocumentCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetDocumentCode_Ljava_lang_String_);
				return cb_setDocumentCode_Ljava_lang_String_;
			}

			static void n_SetDocumentCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_documentCode)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var documentCode = JNIEnv.GetString (native_documentCode, JniHandleOwnership.DoNotTransfer);
				__this.DocumentCode = documentCode;
			}
#pragma warning restore 0169

			static IntPtr id_getDocumentCode;
			static IntPtr id_setDocumentCode_Ljava_lang_String_;
			public virtual unsafe string DocumentCode {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG1']/method[@name='getDocumentCode' and count(parameter)=0]"
				[Register ("getDocumentCode", "()Ljava/lang/String;", "GetGetDocumentCodeHandler")]
				get {
					if (id_getDocumentCode == IntPtr.Zero)
						id_getDocumentCode = JNIEnv.GetMethodID (class_ref, "getDocumentCode", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDocumentCode), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDocumentCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG1']/method[@name='setDocumentCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setDocumentCode", "(Ljava/lang/String;)V", "GetSetDocumentCode_Ljava_lang_String_Handler")]
				set {
					if (id_setDocumentCode_Ljava_lang_String_ == IntPtr.Zero)
						id_setDocumentCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDocumentCode", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDocumentCode_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDocumentCode", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getDocumentNumber;
#pragma warning disable 0169
			static Delegate GetGetDocumentNumberHandler ()
			{
				if (cb_getDocumentNumber == null)
					cb_getDocumentNumber = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDocumentNumber);
				return cb_getDocumentNumber;
			}

			static IntPtr n_GetDocumentNumber (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.DocumentNumber);
			}
#pragma warning restore 0169

			static Delegate cb_setDocumentNumber_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetDocumentNumber_Ljava_lang_String_Handler ()
			{
				if (cb_setDocumentNumber_Ljava_lang_String_ == null)
					cb_setDocumentNumber_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetDocumentNumber_Ljava_lang_String_);
				return cb_setDocumentNumber_Ljava_lang_String_;
			}

			static void n_SetDocumentNumber_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_documentNumber)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var documentNumber = JNIEnv.GetString (native_documentNumber, JniHandleOwnership.DoNotTransfer);
				__this.DocumentNumber = documentNumber;
			}
#pragma warning restore 0169

			static IntPtr id_getDocumentNumber;
			static IntPtr id_setDocumentNumber_Ljava_lang_String_;
			public virtual unsafe string DocumentNumber {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG1']/method[@name='getDocumentNumber' and count(parameter)=0]"
				[Register ("getDocumentNumber", "()Ljava/lang/String;", "GetGetDocumentNumberHandler")]
				get {
					if (id_getDocumentNumber == IntPtr.Zero)
						id_getDocumentNumber = JNIEnv.GetMethodID (class_ref, "getDocumentNumber", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDocumentNumber), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDocumentNumber", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG1']/method[@name='setDocumentNumber' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setDocumentNumber", "(Ljava/lang/String;)V", "GetSetDocumentNumber_Ljava_lang_String_Handler")]
				set {
					if (id_setDocumentNumber_Ljava_lang_String_ == IntPtr.Zero)
						id_setDocumentNumber_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDocumentNumber", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDocumentNumber_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDocumentNumber", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var gender = JNIEnv.GetString (native_gender, JniHandleOwnership.DoNotTransfer);
				__this.Gender = gender;
			}
#pragma warning restore 0169

			static IntPtr id_getGender;
			static IntPtr id_setGender_Ljava_lang_String_;
			public virtual unsafe string Gender {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG1']/method[@name='getGender' and count(parameter)=0]"
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
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG1']/method[@name='setGender' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

			static Delegate cb_getIssuingState;
#pragma warning disable 0169
			static Delegate GetGetIssuingStateHandler ()
			{
				if (cb_getIssuingState == null)
					cb_getIssuingState = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetIssuingState);
				return cb_getIssuingState;
			}

			static IntPtr n_GetIssuingState (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.IssuingState);
			}
#pragma warning restore 0169

			static Delegate cb_setIssuingState_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetIssuingState_Ljava_lang_String_Handler ()
			{
				if (cb_setIssuingState_Ljava_lang_String_ == null)
					cb_setIssuingState_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetIssuingState_Ljava_lang_String_);
				return cb_setIssuingState_Ljava_lang_String_;
			}

			static void n_SetIssuingState_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_issuingState)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var issuingState = JNIEnv.GetString (native_issuingState, JniHandleOwnership.DoNotTransfer);
				__this.IssuingState = issuingState;
			}
#pragma warning restore 0169

			static IntPtr id_getIssuingState;
			static IntPtr id_setIssuingState_Ljava_lang_String_;
			public virtual unsafe string IssuingState {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG1']/method[@name='getIssuingState' and count(parameter)=0]"
				[Register ("getIssuingState", "()Ljava/lang/String;", "GetGetIssuingStateHandler")]
				get {
					if (id_getIssuingState == IntPtr.Zero)
						id_getIssuingState = JNIEnv.GetMethodID (class_ref, "getIssuingState", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIssuingState), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIssuingState", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG1']/method[@name='setIssuingState' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setIssuingState", "(Ljava/lang/String;)V", "GetSetIssuingState_Ljava_lang_String_Handler")]
				set {
					if (id_setIssuingState_Ljava_lang_String_ == IntPtr.Zero)
						id_setIssuingState_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setIssuingState", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIssuingState_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIssuingState", "(Ljava/lang/String;)V"), __args);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

			static void n_SetMiddleName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_middleName)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var middleName = JNIEnv.GetString (native_middleName, JniHandleOwnership.DoNotTransfer);
				__this.MiddleName = middleName;
			}
#pragma warning restore 0169

			static IntPtr id_getMiddleName;
			static IntPtr id_setMiddleName_Ljava_lang_String_;
			public virtual unsafe string MiddleName {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG1']/method[@name='getMiddleName' and count(parameter)=0]"
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
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG1']/method[@name='setMiddleName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

			static Delegate cb_getName;
#pragma warning disable 0169
			static Delegate GetGetNameHandler ()
			{
				if (cb_getName == null)
					cb_getName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetName);
				return cb_getName;
			}

			static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Name);
			}
#pragma warning restore 0169

			static Delegate cb_setName_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetName_Ljava_lang_String_Handler ()
			{
				if (cb_setName_Ljava_lang_String_ == null)
					cb_setName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetName_Ljava_lang_String_);
				return cb_setName_Ljava_lang_String_;
			}

			static void n_SetName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
				__this.Name = name;
			}
#pragma warning restore 0169

			static IntPtr id_getName;
			static IntPtr id_setName_Ljava_lang_String_;
			public virtual unsafe string Name {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG1']/method[@name='getName' and count(parameter)=0]"
				[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
				get {
					if (id_getName == IntPtr.Zero)
						id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG1']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setName", "(Ljava/lang/String;)V", "GetSetName_Ljava_lang_String_Handler")]
				set {
					if (id_setName_Ljava_lang_String_ == IntPtr.Zero)
						id_setName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setName", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setName_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setName", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getNationality;
#pragma warning disable 0169
			static Delegate GetGetNationalityHandler ()
			{
				if (cb_getNationality == null)
					cb_getNationality = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetNationality);
				return cb_getNationality;
			}

			static IntPtr n_GetNationality (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Nationality);
			}
#pragma warning restore 0169

			static Delegate cb_setNationality_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetNationality_Ljava_lang_String_Handler ()
			{
				if (cb_setNationality_Ljava_lang_String_ == null)
					cb_setNationality_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetNationality_Ljava_lang_String_);
				return cb_setNationality_Ljava_lang_String_;
			}

			static void n_SetNationality_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_nationality)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var nationality = JNIEnv.GetString (native_nationality, JniHandleOwnership.DoNotTransfer);
				__this.Nationality = nationality;
			}
#pragma warning restore 0169

			static IntPtr id_getNationality;
			static IntPtr id_setNationality_Ljava_lang_String_;
			public virtual unsafe string Nationality {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG1']/method[@name='getNationality' and count(parameter)=0]"
				[Register ("getNationality", "()Ljava/lang/String;", "GetGetNationalityHandler")]
				get {
					if (id_getNationality == IntPtr.Zero)
						id_getNationality = JNIEnv.GetMethodID (class_ref, "getNationality", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNationality), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNationality", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG1']/method[@name='setNationality' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setNationality", "(Ljava/lang/String;)V", "GetSetNationality_Ljava_lang_String_Handler")]
				set {
					if (id_setNationality_Ljava_lang_String_ == IntPtr.Zero)
						id_setNationality_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setNationality", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNationality_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNationality", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getOptionalDataOne;
#pragma warning disable 0169
			static Delegate GetGetOptionalDataOneHandler ()
			{
				if (cb_getOptionalDataOne == null)
					cb_getOptionalDataOne = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOptionalDataOne);
				return cb_getOptionalDataOne;
			}

			static IntPtr n_GetOptionalDataOne (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.OptionalDataOne);
			}
#pragma warning restore 0169

			static Delegate cb_setOptionalDataOne_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetOptionalDataOne_Ljava_lang_String_Handler ()
			{
				if (cb_setOptionalDataOne_Ljava_lang_String_ == null)
					cb_setOptionalDataOne_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOptionalDataOne_Ljava_lang_String_);
				return cb_setOptionalDataOne_Ljava_lang_String_;
			}

			static void n_SetOptionalDataOne_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_optionalDataOne)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var optionalDataOne = JNIEnv.GetString (native_optionalDataOne, JniHandleOwnership.DoNotTransfer);
				__this.OptionalDataOne = optionalDataOne;
			}
#pragma warning restore 0169

			static IntPtr id_getOptionalDataOne;
			static IntPtr id_setOptionalDataOne_Ljava_lang_String_;
			public virtual unsafe string OptionalDataOne {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG1']/method[@name='getOptionalDataOne' and count(parameter)=0]"
				[Register ("getOptionalDataOne", "()Ljava/lang/String;", "GetGetOptionalDataOneHandler")]
				get {
					if (id_getOptionalDataOne == IntPtr.Zero)
						id_getOptionalDataOne = JNIEnv.GetMethodID (class_ref, "getOptionalDataOne", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOptionalDataOne), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOptionalDataOne", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG1']/method[@name='setOptionalDataOne' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setOptionalDataOne", "(Ljava/lang/String;)V", "GetSetOptionalDataOne_Ljava_lang_String_Handler")]
				set {
					if (id_setOptionalDataOne_Ljava_lang_String_ == IntPtr.Zero)
						id_setOptionalDataOne_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setOptionalDataOne", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOptionalDataOne_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOptionalDataOne", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getOptionalDataTwo;
#pragma warning disable 0169
			static Delegate GetGetOptionalDataTwoHandler ()
			{
				if (cb_getOptionalDataTwo == null)
					cb_getOptionalDataTwo = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOptionalDataTwo);
				return cb_getOptionalDataTwo;
			}

			static IntPtr n_GetOptionalDataTwo (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.OptionalDataTwo);
			}
#pragma warning restore 0169

			static Delegate cb_setOptionalDataTwo_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetOptionalDataTwo_Ljava_lang_String_Handler ()
			{
				if (cb_setOptionalDataTwo_Ljava_lang_String_ == null)
					cb_setOptionalDataTwo_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOptionalDataTwo_Ljava_lang_String_);
				return cb_setOptionalDataTwo_Ljava_lang_String_;
			}

			static void n_SetOptionalDataTwo_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_optionalDataTwo)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var optionalDataTwo = JNIEnv.GetString (native_optionalDataTwo, JniHandleOwnership.DoNotTransfer);
				__this.OptionalDataTwo = optionalDataTwo;
			}
#pragma warning restore 0169

			static IntPtr id_getOptionalDataTwo;
			static IntPtr id_setOptionalDataTwo_Ljava_lang_String_;
			public virtual unsafe string OptionalDataTwo {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG1']/method[@name='getOptionalDataTwo' and count(parameter)=0]"
				[Register ("getOptionalDataTwo", "()Ljava/lang/String;", "GetGetOptionalDataTwoHandler")]
				get {
					if (id_getOptionalDataTwo == IntPtr.Zero)
						id_getOptionalDataTwo = JNIEnv.GetMethodID (class_ref, "getOptionalDataTwo", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOptionalDataTwo), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOptionalDataTwo", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG1']/method[@name='setOptionalDataTwo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setOptionalDataTwo", "(Ljava/lang/String;)V", "GetSetOptionalDataTwo_Ljava_lang_String_Handler")]
				set {
					if (id_setOptionalDataTwo_Ljava_lang_String_ == IntPtr.Zero)
						id_setOptionalDataTwo_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setOptionalDataTwo", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOptionalDataTwo_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOptionalDataTwo", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getPrimaryIdentifier;
#pragma warning disable 0169
			static Delegate GetGetPrimaryIdentifierHandler ()
			{
				if (cb_getPrimaryIdentifier == null)
					cb_getPrimaryIdentifier = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPrimaryIdentifier);
				return cb_getPrimaryIdentifier;
			}

			static IntPtr n_GetPrimaryIdentifier (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.PrimaryIdentifier);
			}
#pragma warning restore 0169

			static Delegate cb_setPrimaryIdentifier_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetPrimaryIdentifier_Ljava_lang_String_Handler ()
			{
				if (cb_setPrimaryIdentifier_Ljava_lang_String_ == null)
					cb_setPrimaryIdentifier_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetPrimaryIdentifier_Ljava_lang_String_);
				return cb_setPrimaryIdentifier_Ljava_lang_String_;
			}

			static void n_SetPrimaryIdentifier_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_primaryIdentifier)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var primaryIdentifier = JNIEnv.GetString (native_primaryIdentifier, JniHandleOwnership.DoNotTransfer);
				__this.PrimaryIdentifier = primaryIdentifier;
			}
#pragma warning restore 0169

			static IntPtr id_getPrimaryIdentifier;
			static IntPtr id_setPrimaryIdentifier_Ljava_lang_String_;
			public virtual unsafe string PrimaryIdentifier {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG1']/method[@name='getPrimaryIdentifier' and count(parameter)=0]"
				[Register ("getPrimaryIdentifier", "()Ljava/lang/String;", "GetGetPrimaryIdentifierHandler")]
				get {
					if (id_getPrimaryIdentifier == IntPtr.Zero)
						id_getPrimaryIdentifier = JNIEnv.GetMethodID (class_ref, "getPrimaryIdentifier", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPrimaryIdentifier), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPrimaryIdentifier", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG1']/method[@name='setPrimaryIdentifier' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setPrimaryIdentifier", "(Ljava/lang/String;)V", "GetSetPrimaryIdentifier_Ljava_lang_String_Handler")]
				set {
					if (id_setPrimaryIdentifier_Ljava_lang_String_ == IntPtr.Zero)
						id_setPrimaryIdentifier_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPrimaryIdentifier", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPrimaryIdentifier_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPrimaryIdentifier", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getSecondaryIdentifier;
#pragma warning disable 0169
			static Delegate GetGetSecondaryIdentifierHandler ()
			{
				if (cb_getSecondaryIdentifier == null)
					cb_getSecondaryIdentifier = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSecondaryIdentifier);
				return cb_getSecondaryIdentifier;
			}

			static IntPtr n_GetSecondaryIdentifier (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.SecondaryIdentifier);
			}
#pragma warning restore 0169

			static Delegate cb_setSecondaryIdentifier_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetSecondaryIdentifier_Ljava_lang_String_Handler ()
			{
				if (cb_setSecondaryIdentifier_Ljava_lang_String_ == null)
					cb_setSecondaryIdentifier_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetSecondaryIdentifier_Ljava_lang_String_);
				return cb_setSecondaryIdentifier_Ljava_lang_String_;
			}

			static void n_SetSecondaryIdentifier_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_secondaryIdentifier)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var secondaryIdentifier = JNIEnv.GetString (native_secondaryIdentifier, JniHandleOwnership.DoNotTransfer);
				__this.SecondaryIdentifier = secondaryIdentifier;
			}
#pragma warning restore 0169

			static IntPtr id_getSecondaryIdentifier;
			static IntPtr id_setSecondaryIdentifier_Ljava_lang_String_;
			public virtual unsafe string SecondaryIdentifier {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG1']/method[@name='getSecondaryIdentifier' and count(parameter)=0]"
				[Register ("getSecondaryIdentifier", "()Ljava/lang/String;", "GetGetSecondaryIdentifierHandler")]
				get {
					if (id_getSecondaryIdentifier == IntPtr.Zero)
						id_getSecondaryIdentifier = JNIEnv.GetMethodID (class_ref, "getSecondaryIdentifier", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSecondaryIdentifier), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSecondaryIdentifier", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG1']/method[@name='setSecondaryIdentifier' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setSecondaryIdentifier", "(Ljava/lang/String;)V", "GetSetSecondaryIdentifier_Ljava_lang_String_Handler")]
				set {
					if (id_setSecondaryIdentifier_Ljava_lang_String_ == IntPtr.Zero)
						id_setSecondaryIdentifier_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSecondaryIdentifier", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSecondaryIdentifier_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSecondaryIdentifier", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getSurname;
#pragma warning disable 0169
			static Delegate GetGetSurnameHandler ()
			{
				if (cb_getSurname == null)
					cb_getSurname = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSurname);
				return cb_getSurname;
			}

			static IntPtr n_GetSurname (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Surname);
			}
#pragma warning restore 0169

			static Delegate cb_setSurname_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetSurname_Ljava_lang_String_Handler ()
			{
				if (cb_setSurname_Ljava_lang_String_ == null)
					cb_setSurname_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetSurname_Ljava_lang_String_);
				return cb_setSurname_Ljava_lang_String_;
			}

			static void n_SetSurname_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_surname)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG1> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var surname = JNIEnv.GetString (native_surname, JniHandleOwnership.DoNotTransfer);
				__this.Surname = surname;
			}
#pragma warning restore 0169

			static IntPtr id_getSurname;
			static IntPtr id_setSurname_Ljava_lang_String_;
			public virtual unsafe string Surname {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG1']/method[@name='getSurname' and count(parameter)=0]"
				[Register ("getSurname", "()Ljava/lang/String;", "GetGetSurnameHandler")]
				get {
					if (id_getSurname == IntPtr.Zero)
						id_getSurname = JNIEnv.GetMethodID (class_ref, "getSurname", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSurname), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSurname", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG1']/method[@name='setSurname' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setSurname", "(Ljava/lang/String;)V", "GetSetSurname_Ljava_lang_String_Handler")]
				set {
					if (id_setSurname_Ljava_lang_String_ == IntPtr.Zero)
						id_setSurname_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSurname", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSurname_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSurname", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG11']"
		[global::Android.Runtime.Register ("com/credenceid/icao/ICAODocumentData$DG11", DoNotGenerateAcw=true)]
		public partial class DG11 : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/credenceid/icao/ICAODocumentData$DG11", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DG11); }
			}

			protected DG11 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_credenceid_icao_ICAODocumentData_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG11']/constructor[@name='ICAODocumentData.DG11' and count(parameter)=1 and parameter[1][@type='com.credenceid.icao.ICAODocumentData']]"
			[Register (".ctor", "(Lcom/credenceid/icao/ICAODocumentData;)V", "")]
			public unsafe DG11 (global::Com.Credenceid.Icao.ICAODocumentData __self)
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

					if (id_ctor_Lcom_credenceid_icao_ICAODocumentData_ == IntPtr.Zero)
						id_ctor_Lcom_credenceid_icao_ICAODocumentData_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/credenceid/icao/ICAODocumentData;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_credenceid_icao_ICAODocumentData_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_credenceid_icao_ICAODocumentData_, __args);
				} finally {
				}
			}

			static Delegate cb_getCustodyInformation;
#pragma warning disable 0169
			static Delegate GetGetCustodyInformationHandler ()
			{
				if (cb_getCustodyInformation == null)
					cb_getCustodyInformation = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCustodyInformation);
				return cb_getCustodyInformation;
			}

			static IntPtr n_GetCustodyInformation (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG11> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.CustodyInformation);
			}
#pragma warning restore 0169

			static Delegate cb_setCustodyInformation_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetCustodyInformation_Ljava_lang_String_Handler ()
			{
				if (cb_setCustodyInformation_Ljava_lang_String_ == null)
					cb_setCustodyInformation_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetCustodyInformation_Ljava_lang_String_);
				return cb_setCustodyInformation_Ljava_lang_String_;
			}

			static void n_SetCustodyInformation_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_val)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG11> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var val = JNIEnv.GetString (native_val, JniHandleOwnership.DoNotTransfer);
				__this.CustodyInformation = val;
			}
#pragma warning restore 0169

			static IntPtr id_getCustodyInformation;
			static IntPtr id_setCustodyInformation_Ljava_lang_String_;
			public virtual unsafe string CustodyInformation {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG11']/method[@name='getCustodyInformation' and count(parameter)=0]"
				[Register ("getCustodyInformation", "()Ljava/lang/String;", "GetGetCustodyInformationHandler")]
				get {
					if (id_getCustodyInformation == IntPtr.Zero)
						id_getCustodyInformation = JNIEnv.GetMethodID (class_ref, "getCustodyInformation", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCustodyInformation), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCustodyInformation", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG11']/method[@name='setCustodyInformation' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setCustodyInformation", "(Ljava/lang/String;)V", "GetSetCustodyInformation_Ljava_lang_String_Handler")]
				set {
					if (id_setCustodyInformation_Ljava_lang_String_ == IntPtr.Zero)
						id_setCustodyInformation_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCustodyInformation", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCustodyInformation_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCustodyInformation", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getFullDateOfBirth;
#pragma warning disable 0169
			static Delegate GetGetFullDateOfBirthHandler ()
			{
				if (cb_getFullDateOfBirth == null)
					cb_getFullDateOfBirth = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFullDateOfBirth);
				return cb_getFullDateOfBirth;
			}

			static IntPtr n_GetFullDateOfBirth (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG11> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.FullDateOfBirth);
			}
#pragma warning restore 0169

			static Delegate cb_setFullDateOfBirth_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetFullDateOfBirth_Ljava_lang_String_Handler ()
			{
				if (cb_setFullDateOfBirth_Ljava_lang_String_ == null)
					cb_setFullDateOfBirth_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetFullDateOfBirth_Ljava_lang_String_);
				return cb_setFullDateOfBirth_Ljava_lang_String_;
			}

			static void n_SetFullDateOfBirth_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_val)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG11> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var val = JNIEnv.GetString (native_val, JniHandleOwnership.DoNotTransfer);
				__this.FullDateOfBirth = val;
			}
#pragma warning restore 0169

			static IntPtr id_getFullDateOfBirth;
			static IntPtr id_setFullDateOfBirth_Ljava_lang_String_;
			public virtual unsafe string FullDateOfBirth {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG11']/method[@name='getFullDateOfBirth' and count(parameter)=0]"
				[Register ("getFullDateOfBirth", "()Ljava/lang/String;", "GetGetFullDateOfBirthHandler")]
				get {
					if (id_getFullDateOfBirth == IntPtr.Zero)
						id_getFullDateOfBirth = JNIEnv.GetMethodID (class_ref, "getFullDateOfBirth", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFullDateOfBirth), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFullDateOfBirth", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG11']/method[@name='setFullDateOfBirth' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setFullDateOfBirth", "(Ljava/lang/String;)V", "GetSetFullDateOfBirth_Ljava_lang_String_Handler")]
				set {
					if (id_setFullDateOfBirth_Ljava_lang_String_ == IntPtr.Zero)
						id_setFullDateOfBirth_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setFullDateOfBirth", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFullDateOfBirth_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFullDateOfBirth", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getNameOfHolder;
#pragma warning disable 0169
			static Delegate GetGetNameOfHolderHandler ()
			{
				if (cb_getNameOfHolder == null)
					cb_getNameOfHolder = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetNameOfHolder);
				return cb_getNameOfHolder;
			}

			static IntPtr n_GetNameOfHolder (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG11> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.NameOfHolder);
			}
#pragma warning restore 0169

			static Delegate cb_setNameOfHolder_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetNameOfHolder_Ljava_lang_String_Handler ()
			{
				if (cb_setNameOfHolder_Ljava_lang_String_ == null)
					cb_setNameOfHolder_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetNameOfHolder_Ljava_lang_String_);
				return cb_setNameOfHolder_Ljava_lang_String_;
			}

			static void n_SetNameOfHolder_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_val)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG11> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var val = JNIEnv.GetString (native_val, JniHandleOwnership.DoNotTransfer);
				__this.NameOfHolder = val;
			}
#pragma warning restore 0169

			static IntPtr id_getNameOfHolder;
			static IntPtr id_setNameOfHolder_Ljava_lang_String_;
			public virtual unsafe string NameOfHolder {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG11']/method[@name='getNameOfHolder' and count(parameter)=0]"
				[Register ("getNameOfHolder", "()Ljava/lang/String;", "GetGetNameOfHolderHandler")]
				get {
					if (id_getNameOfHolder == IntPtr.Zero)
						id_getNameOfHolder = JNIEnv.GetMethodID (class_ref, "getNameOfHolder", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNameOfHolder), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNameOfHolder", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG11']/method[@name='setNameOfHolder' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setNameOfHolder", "(Ljava/lang/String;)V", "GetSetNameOfHolder_Ljava_lang_String_Handler")]
				set {
					if (id_setNameOfHolder_Ljava_lang_String_ == IntPtr.Zero)
						id_setNameOfHolder_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setNameOfHolder", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNameOfHolder_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNameOfHolder", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getOtherNames;
#pragma warning disable 0169
			static Delegate GetGetOtherNamesHandler ()
			{
				if (cb_getOtherNames == null)
					cb_getOtherNames = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOtherNames);
				return cb_getOtherNames;
			}

			static IntPtr n_GetOtherNames (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG11> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.OtherNames);
			}
#pragma warning restore 0169

			static Delegate cb_setOtherNames_Ljava_util_ArrayList_;
#pragma warning disable 0169
			static Delegate GetSetOtherNames_Ljava_util_ArrayList_Handler ()
			{
				if (cb_setOtherNames_Ljava_util_ArrayList_ == null)
					cb_setOtherNames_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOtherNames_Ljava_util_ArrayList_);
				return cb_setOtherNames_Ljava_util_ArrayList_;
			}

			static void n_SetOtherNames_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_val)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG11> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var val = global::Android.Runtime.JavaList<string>.FromJniHandle (native_val, JniHandleOwnership.DoNotTransfer);
				__this.OtherNames = val;
			}
#pragma warning restore 0169

			static IntPtr id_getOtherNames;
			static IntPtr id_setOtherNames_Ljava_util_ArrayList_;
			public virtual unsafe global::System.Collections.Generic.IList<string> OtherNames {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG11']/method[@name='getOtherNames' and count(parameter)=0]"
				[Register ("getOtherNames", "()Ljava/util/ArrayList;", "GetGetOtherNamesHandler")]
				get {
					if (id_getOtherNames == IntPtr.Zero)
						id_getOtherNames = JNIEnv.GetMethodID (class_ref, "getOtherNames", "()Ljava/util/ArrayList;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOtherNames), JniHandleOwnership.TransferLocalRef);
						else
							return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOtherNames", "()Ljava/util/ArrayList;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG11']/method[@name='setOtherNames' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;java.lang.String&gt;']]"
				[Register ("setOtherNames", "(Ljava/util/ArrayList;)V", "GetSetOtherNames_Ljava_util_ArrayList_Handler")]
				set {
					if (id_setOtherNames_Ljava_util_ArrayList_ == IntPtr.Zero)
						id_setOtherNames_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "setOtherNames", "(Ljava/util/ArrayList;)V");
					IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOtherNames_Ljava_util_ArrayList_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOtherNames", "(Ljava/util/ArrayList;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getOtherValidTDNumbers;
#pragma warning disable 0169
			static Delegate GetGetOtherValidTDNumbersHandler ()
			{
				if (cb_getOtherValidTDNumbers == null)
					cb_getOtherValidTDNumbers = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOtherValidTDNumbers);
				return cb_getOtherValidTDNumbers;
			}

			static IntPtr n_GetOtherValidTDNumbers (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG11> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.OtherValidTDNumbers);
			}
#pragma warning restore 0169

			static Delegate cb_setOtherValidTDNumbers_Ljava_util_ArrayList_;
#pragma warning disable 0169
			static Delegate GetSetOtherValidTDNumbers_Ljava_util_ArrayList_Handler ()
			{
				if (cb_setOtherValidTDNumbers_Ljava_util_ArrayList_ == null)
					cb_setOtherValidTDNumbers_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOtherValidTDNumbers_Ljava_util_ArrayList_);
				return cb_setOtherValidTDNumbers_Ljava_util_ArrayList_;
			}

			static void n_SetOtherValidTDNumbers_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_val)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG11> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var val = global::Android.Runtime.JavaList<string>.FromJniHandle (native_val, JniHandleOwnership.DoNotTransfer);
				__this.OtherValidTDNumbers = val;
			}
#pragma warning restore 0169

			static IntPtr id_getOtherValidTDNumbers;
			static IntPtr id_setOtherValidTDNumbers_Ljava_util_ArrayList_;
			public virtual unsafe global::System.Collections.Generic.IList<string> OtherValidTDNumbers {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG11']/method[@name='getOtherValidTDNumbers' and count(parameter)=0]"
				[Register ("getOtherValidTDNumbers", "()Ljava/util/ArrayList;", "GetGetOtherValidTDNumbersHandler")]
				get {
					if (id_getOtherValidTDNumbers == IntPtr.Zero)
						id_getOtherValidTDNumbers = JNIEnv.GetMethodID (class_ref, "getOtherValidTDNumbers", "()Ljava/util/ArrayList;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOtherValidTDNumbers), JniHandleOwnership.TransferLocalRef);
						else
							return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOtherValidTDNumbers", "()Ljava/util/ArrayList;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG11']/method[@name='setOtherValidTDNumbers' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;java.lang.String&gt;']]"
				[Register ("setOtherValidTDNumbers", "(Ljava/util/ArrayList;)V", "GetSetOtherValidTDNumbers_Ljava_util_ArrayList_Handler")]
				set {
					if (id_setOtherValidTDNumbers_Ljava_util_ArrayList_ == IntPtr.Zero)
						id_setOtherValidTDNumbers_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "setOtherValidTDNumbers", "(Ljava/util/ArrayList;)V");
					IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOtherValidTDNumbers_Ljava_util_ArrayList_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOtherValidTDNumbers", "(Ljava/util/ArrayList;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getPermanentAddress;
#pragma warning disable 0169
			static Delegate GetGetPermanentAddressHandler ()
			{
				if (cb_getPermanentAddress == null)
					cb_getPermanentAddress = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPermanentAddress);
				return cb_getPermanentAddress;
			}

			static IntPtr n_GetPermanentAddress (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG11> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.PermanentAddress);
			}
#pragma warning restore 0169

			static Delegate cb_setPermanentAddress_Ljava_util_ArrayList_;
#pragma warning disable 0169
			static Delegate GetSetPermanentAddress_Ljava_util_ArrayList_Handler ()
			{
				if (cb_setPermanentAddress_Ljava_util_ArrayList_ == null)
					cb_setPermanentAddress_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetPermanentAddress_Ljava_util_ArrayList_);
				return cb_setPermanentAddress_Ljava_util_ArrayList_;
			}

			static void n_SetPermanentAddress_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_val)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG11> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var val = global::Android.Runtime.JavaList<string>.FromJniHandle (native_val, JniHandleOwnership.DoNotTransfer);
				__this.PermanentAddress = val;
			}
#pragma warning restore 0169

			static IntPtr id_getPermanentAddress;
			static IntPtr id_setPermanentAddress_Ljava_util_ArrayList_;
			public virtual unsafe global::System.Collections.Generic.IList<string> PermanentAddress {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG11']/method[@name='getPermanentAddress' and count(parameter)=0]"
				[Register ("getPermanentAddress", "()Ljava/util/ArrayList;", "GetGetPermanentAddressHandler")]
				get {
					if (id_getPermanentAddress == IntPtr.Zero)
						id_getPermanentAddress = JNIEnv.GetMethodID (class_ref, "getPermanentAddress", "()Ljava/util/ArrayList;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPermanentAddress), JniHandleOwnership.TransferLocalRef);
						else
							return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPermanentAddress", "()Ljava/util/ArrayList;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG11']/method[@name='setPermanentAddress' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;java.lang.String&gt;']]"
				[Register ("setPermanentAddress", "(Ljava/util/ArrayList;)V", "GetSetPermanentAddress_Ljava_util_ArrayList_Handler")]
				set {
					if (id_setPermanentAddress_Ljava_util_ArrayList_ == IntPtr.Zero)
						id_setPermanentAddress_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "setPermanentAddress", "(Ljava/util/ArrayList;)V");
					IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPermanentAddress_Ljava_util_ArrayList_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPermanentAddress", "(Ljava/util/ArrayList;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getPersonalNumber;
#pragma warning disable 0169
			static Delegate GetGetPersonalNumberHandler ()
			{
				if (cb_getPersonalNumber == null)
					cb_getPersonalNumber = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPersonalNumber);
				return cb_getPersonalNumber;
			}

			static IntPtr n_GetPersonalNumber (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG11> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.PersonalNumber);
			}
#pragma warning restore 0169

			static Delegate cb_setPersonalNumber_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetPersonalNumber_Ljava_lang_String_Handler ()
			{
				if (cb_setPersonalNumber_Ljava_lang_String_ == null)
					cb_setPersonalNumber_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetPersonalNumber_Ljava_lang_String_);
				return cb_setPersonalNumber_Ljava_lang_String_;
			}

			static void n_SetPersonalNumber_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_val)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG11> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var val = JNIEnv.GetString (native_val, JniHandleOwnership.DoNotTransfer);
				__this.PersonalNumber = val;
			}
#pragma warning restore 0169

			static IntPtr id_getPersonalNumber;
			static IntPtr id_setPersonalNumber_Ljava_lang_String_;
			public virtual unsafe string PersonalNumber {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG11']/method[@name='getPersonalNumber' and count(parameter)=0]"
				[Register ("getPersonalNumber", "()Ljava/lang/String;", "GetGetPersonalNumberHandler")]
				get {
					if (id_getPersonalNumber == IntPtr.Zero)
						id_getPersonalNumber = JNIEnv.GetMethodID (class_ref, "getPersonalNumber", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPersonalNumber), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPersonalNumber", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG11']/method[@name='setPersonalNumber' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setPersonalNumber", "(Ljava/lang/String;)V", "GetSetPersonalNumber_Ljava_lang_String_Handler")]
				set {
					if (id_setPersonalNumber_Ljava_lang_String_ == IntPtr.Zero)
						id_setPersonalNumber_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPersonalNumber", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPersonalNumber_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPersonalNumber", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getPersonalSummary;
#pragma warning disable 0169
			static Delegate GetGetPersonalSummaryHandler ()
			{
				if (cb_getPersonalSummary == null)
					cb_getPersonalSummary = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPersonalSummary);
				return cb_getPersonalSummary;
			}

			static IntPtr n_GetPersonalSummary (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG11> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.PersonalSummary);
			}
#pragma warning restore 0169

			static Delegate cb_setPersonalSummary_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetPersonalSummary_Ljava_lang_String_Handler ()
			{
				if (cb_setPersonalSummary_Ljava_lang_String_ == null)
					cb_setPersonalSummary_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetPersonalSummary_Ljava_lang_String_);
				return cb_setPersonalSummary_Ljava_lang_String_;
			}

			static void n_SetPersonalSummary_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_val)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG11> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var val = JNIEnv.GetString (native_val, JniHandleOwnership.DoNotTransfer);
				__this.PersonalSummary = val;
			}
#pragma warning restore 0169

			static IntPtr id_getPersonalSummary;
			static IntPtr id_setPersonalSummary_Ljava_lang_String_;
			public virtual unsafe string PersonalSummary {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG11']/method[@name='getPersonalSummary' and count(parameter)=0]"
				[Register ("getPersonalSummary", "()Ljava/lang/String;", "GetGetPersonalSummaryHandler")]
				get {
					if (id_getPersonalSummary == IntPtr.Zero)
						id_getPersonalSummary = JNIEnv.GetMethodID (class_ref, "getPersonalSummary", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPersonalSummary), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPersonalSummary", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG11']/method[@name='setPersonalSummary' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setPersonalSummary", "(Ljava/lang/String;)V", "GetSetPersonalSummary_Ljava_lang_String_Handler")]
				set {
					if (id_setPersonalSummary_Ljava_lang_String_ == IntPtr.Zero)
						id_setPersonalSummary_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPersonalSummary", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPersonalSummary_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPersonalSummary", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getPhoneNumber;
#pragma warning disable 0169
			static Delegate GetGetPhoneNumberHandler ()
			{
				if (cb_getPhoneNumber == null)
					cb_getPhoneNumber = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPhoneNumber);
				return cb_getPhoneNumber;
			}

			static IntPtr n_GetPhoneNumber (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG11> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.PhoneNumber);
			}
#pragma warning restore 0169

			static Delegate cb_setPhoneNumber_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetPhoneNumber_Ljava_lang_String_Handler ()
			{
				if (cb_setPhoneNumber_Ljava_lang_String_ == null)
					cb_setPhoneNumber_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetPhoneNumber_Ljava_lang_String_);
				return cb_setPhoneNumber_Ljava_lang_String_;
			}

			static void n_SetPhoneNumber_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_val)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG11> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var val = JNIEnv.GetString (native_val, JniHandleOwnership.DoNotTransfer);
				__this.PhoneNumber = val;
			}
#pragma warning restore 0169

			static IntPtr id_getPhoneNumber;
			static IntPtr id_setPhoneNumber_Ljava_lang_String_;
			public virtual unsafe string PhoneNumber {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG11']/method[@name='getPhoneNumber' and count(parameter)=0]"
				[Register ("getPhoneNumber", "()Ljava/lang/String;", "GetGetPhoneNumberHandler")]
				get {
					if (id_getPhoneNumber == IntPtr.Zero)
						id_getPhoneNumber = JNIEnv.GetMethodID (class_ref, "getPhoneNumber", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPhoneNumber), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPhoneNumber", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG11']/method[@name='setPhoneNumber' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setPhoneNumber", "(Ljava/lang/String;)V", "GetSetPhoneNumber_Ljava_lang_String_Handler")]
				set {
					if (id_setPhoneNumber_Ljava_lang_String_ == IntPtr.Zero)
						id_setPhoneNumber_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPhoneNumber", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPhoneNumber_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPhoneNumber", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getPlaceOfBirth;
#pragma warning disable 0169
			static Delegate GetGetPlaceOfBirthHandler ()
			{
				if (cb_getPlaceOfBirth == null)
					cb_getPlaceOfBirth = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPlaceOfBirth);
				return cb_getPlaceOfBirth;
			}

			static IntPtr n_GetPlaceOfBirth (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG11> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.PlaceOfBirth);
			}
#pragma warning restore 0169

			static Delegate cb_setPlaceOfBirth_Ljava_util_ArrayList_;
#pragma warning disable 0169
			static Delegate GetSetPlaceOfBirth_Ljava_util_ArrayList_Handler ()
			{
				if (cb_setPlaceOfBirth_Ljava_util_ArrayList_ == null)
					cb_setPlaceOfBirth_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetPlaceOfBirth_Ljava_util_ArrayList_);
				return cb_setPlaceOfBirth_Ljava_util_ArrayList_;
			}

			static void n_SetPlaceOfBirth_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_val)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG11> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var val = global::Android.Runtime.JavaList<string>.FromJniHandle (native_val, JniHandleOwnership.DoNotTransfer);
				__this.PlaceOfBirth = val;
			}
#pragma warning restore 0169

			static IntPtr id_getPlaceOfBirth;
			static IntPtr id_setPlaceOfBirth_Ljava_util_ArrayList_;
			public virtual unsafe global::System.Collections.Generic.IList<string> PlaceOfBirth {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG11']/method[@name='getPlaceOfBirth' and count(parameter)=0]"
				[Register ("getPlaceOfBirth", "()Ljava/util/ArrayList;", "GetGetPlaceOfBirthHandler")]
				get {
					if (id_getPlaceOfBirth == IntPtr.Zero)
						id_getPlaceOfBirth = JNIEnv.GetMethodID (class_ref, "getPlaceOfBirth", "()Ljava/util/ArrayList;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPlaceOfBirth), JniHandleOwnership.TransferLocalRef);
						else
							return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPlaceOfBirth", "()Ljava/util/ArrayList;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG11']/method[@name='setPlaceOfBirth' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;java.lang.String&gt;']]"
				[Register ("setPlaceOfBirth", "(Ljava/util/ArrayList;)V", "GetSetPlaceOfBirth_Ljava_util_ArrayList_Handler")]
				set {
					if (id_setPlaceOfBirth_Ljava_util_ArrayList_ == IntPtr.Zero)
						id_setPlaceOfBirth_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "setPlaceOfBirth", "(Ljava/util/ArrayList;)V");
					IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPlaceOfBirth_Ljava_util_ArrayList_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPlaceOfBirth", "(Ljava/util/ArrayList;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getProfession;
#pragma warning disable 0169
			static Delegate GetGetProfessionHandler ()
			{
				if (cb_getProfession == null)
					cb_getProfession = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetProfession);
				return cb_getProfession;
			}

			static IntPtr n_GetProfession (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG11> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Profession);
			}
#pragma warning restore 0169

			static IntPtr id_getProfession;
			public virtual unsafe string Profession {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG11']/method[@name='getProfession' and count(parameter)=0]"
				[Register ("getProfession", "()Ljava/lang/String;", "GetGetProfessionHandler")]
				get {
					if (id_getProfession == IntPtr.Zero)
						id_getProfession = JNIEnv.GetMethodID (class_ref, "getProfession", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProfession), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getProfession", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getTitle;
#pragma warning disable 0169
			static Delegate GetGetTitleHandler ()
			{
				if (cb_getTitle == null)
					cb_getTitle = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTitle);
				return cb_getTitle;
			}

			static IntPtr n_GetTitle (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG11> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Title);
			}
#pragma warning restore 0169

			static Delegate cb_setTitle_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetTitle_Ljava_lang_String_Handler ()
			{
				if (cb_setTitle_Ljava_lang_String_ == null)
					cb_setTitle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetTitle_Ljava_lang_String_);
				return cb_setTitle_Ljava_lang_String_;
			}

			static void n_SetTitle_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_val)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG11> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var val = JNIEnv.GetString (native_val, JniHandleOwnership.DoNotTransfer);
				__this.Title = val;
			}
#pragma warning restore 0169

			static IntPtr id_getTitle;
			static IntPtr id_setTitle_Ljava_lang_String_;
			public virtual unsafe string Title {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG11']/method[@name='getTitle' and count(parameter)=0]"
				[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler")]
				get {
					if (id_getTitle == IntPtr.Zero)
						id_getTitle = JNIEnv.GetMethodID (class_ref, "getTitle", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTitle), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTitle", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG11']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setTitle", "(Ljava/lang/String;)V", "GetSetTitle_Ljava_lang_String_Handler")]
				set {
					if (id_setTitle_Ljava_lang_String_ == IntPtr.Zero)
						id_setTitle_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTitle", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTitle_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTitle", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getProofOfCitizenship;
#pragma warning disable 0169
			static Delegate GetGetProofOfCitizenshipHandler ()
			{
				if (cb_getProofOfCitizenship == null)
					cb_getProofOfCitizenship = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetProofOfCitizenship);
				return cb_getProofOfCitizenship;
			}

			static IntPtr n_GetProofOfCitizenship (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG11> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewArray (__this.GetProofOfCitizenship ());
			}
#pragma warning restore 0169

			static IntPtr id_getProofOfCitizenship;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG11']/method[@name='getProofOfCitizenship' and count(parameter)=0]"
			[Register ("getProofOfCitizenship", "()[B", "GetGetProofOfCitizenshipHandler")]
			public virtual unsafe byte[] GetProofOfCitizenship ()
			{
				if (id_getProofOfCitizenship == IntPtr.Zero)
					id_getProofOfCitizenship = JNIEnv.GetMethodID (class_ref, "getProofOfCitizenship", "()[B");
				try {

					if (((object) this).GetType () == ThresholdType)
						return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProofOfCitizenship), JniHandleOwnership.TransferLocalRef, typeof (byte));
					else
						return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getProofOfCitizenship", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
				} finally {
				}
			}

			static Delegate cb_setProofOfCitizenship_arrayB;
#pragma warning disable 0169
			static Delegate GetSetProofOfCitizenship_arrayBHandler ()
			{
				if (cb_setProofOfCitizenship_arrayB == null)
					cb_setProofOfCitizenship_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetProofOfCitizenship_arrayB);
				return cb_setProofOfCitizenship_arrayB;
			}

			static void n_SetProofOfCitizenship_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_val)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG11> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var val = (byte[]) JNIEnv.GetArray (native_val, JniHandleOwnership.DoNotTransfer, typeof (byte));
				__this.SetProofOfCitizenship (val);
				if (val != null)
					JNIEnv.CopyArray (val, native_val);
			}
#pragma warning restore 0169

			static IntPtr id_setProofOfCitizenship_arrayB;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG11']/method[@name='setProofOfCitizenship' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("setProofOfCitizenship", "([B)V", "GetSetProofOfCitizenship_arrayBHandler")]
			public virtual unsafe void SetProofOfCitizenship (byte[] val)
			{
				if (id_setProofOfCitizenship_arrayB == IntPtr.Zero)
					id_setProofOfCitizenship_arrayB = JNIEnv.GetMethodID (class_ref, "setProofOfCitizenship", "([B)V");
				IntPtr native_val = JNIEnv.NewArray (val);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_val);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setProofOfCitizenship_arrayB, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setProofOfCitizenship", "([B)V"), __args);
				} finally {
					if (val != null) {
						JNIEnv.CopyArray (native_val, val);
						JNIEnv.DeleteLocalRef (native_val);
					}
				}
			}

			static Delegate cb_settProfession_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSettProfession_Ljava_lang_String_Handler ()
			{
				if (cb_settProfession_Ljava_lang_String_ == null)
					cb_settProfession_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SettProfession_Ljava_lang_String_);
				return cb_settProfession_Ljava_lang_String_;
			}

			static void n_SettProfession_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_val)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG11> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var val = JNIEnv.GetString (native_val, JniHandleOwnership.DoNotTransfer);
				__this.SettProfession (val);
			}
#pragma warning restore 0169

			static IntPtr id_settProfession_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG11']/method[@name='settProfession' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("settProfession", "(Ljava/lang/String;)V", "GetSettProfession_Ljava_lang_String_Handler")]
			public virtual unsafe void SettProfession (string val)
			{
				if (id_settProfession_Ljava_lang_String_ == IntPtr.Zero)
					id_settProfession_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "settProfession", "(Ljava/lang/String;)V");
				IntPtr native_val = JNIEnv.NewString (val);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_val);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_settProfession_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "settProfession", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_val);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG12']"
		[global::Android.Runtime.Register ("com/credenceid/icao/ICAODocumentData$DG12", DoNotGenerateAcw=true)]
		public partial class DG12 : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/credenceid/icao/ICAODocumentData$DG12", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DG12); }
			}

			protected DG12 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_credenceid_icao_ICAODocumentData_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG12']/constructor[@name='ICAODocumentData.DG12' and count(parameter)=1 and parameter[1][@type='com.credenceid.icao.ICAODocumentData']]"
			[Register (".ctor", "(Lcom/credenceid/icao/ICAODocumentData;)V", "")]
			public unsafe DG12 (global::Com.Credenceid.Icao.ICAODocumentData __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (((object) this).GetType () != typeof (DG12)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lcom_credenceid_icao_ICAODocumentData_ == IntPtr.Zero)
						id_ctor_Lcom_credenceid_icao_ICAODocumentData_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/credenceid/icao/ICAODocumentData;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_credenceid_icao_ICAODocumentData_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_credenceid_icao_ICAODocumentData_, __args);
				} finally {
				}
			}

			static Delegate cb_getDateOfIssue;
#pragma warning disable 0169
			static Delegate GetGetDateOfIssueHandler ()
			{
				if (cb_getDateOfIssue == null)
					cb_getDateOfIssue = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDateOfIssue);
				return cb_getDateOfIssue;
			}

			static IntPtr n_GetDateOfIssue (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG12> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.DateOfIssue);
			}
#pragma warning restore 0169

			static Delegate cb_setDateOfIssue_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetDateOfIssue_Ljava_lang_String_Handler ()
			{
				if (cb_setDateOfIssue_Ljava_lang_String_ == null)
					cb_setDateOfIssue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetDateOfIssue_Ljava_lang_String_);
				return cb_setDateOfIssue_Ljava_lang_String_;
			}

			static void n_SetDateOfIssue_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_val)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG12> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var val = JNIEnv.GetString (native_val, JniHandleOwnership.DoNotTransfer);
				__this.DateOfIssue = val;
			}
#pragma warning restore 0169

			static IntPtr id_getDateOfIssue;
			static IntPtr id_setDateOfIssue_Ljava_lang_String_;
			public virtual unsafe string DateOfIssue {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG12']/method[@name='getDateOfIssue' and count(parameter)=0]"
				[Register ("getDateOfIssue", "()Ljava/lang/String;", "GetGetDateOfIssueHandler")]
				get {
					if (id_getDateOfIssue == IntPtr.Zero)
						id_getDateOfIssue = JNIEnv.GetMethodID (class_ref, "getDateOfIssue", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDateOfIssue), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDateOfIssue", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG12']/method[@name='setDateOfIssue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setDateOfIssue", "(Ljava/lang/String;)V", "GetSetDateOfIssue_Ljava_lang_String_Handler")]
				set {
					if (id_setDateOfIssue_Ljava_lang_String_ == IntPtr.Zero)
						id_setDateOfIssue_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDateOfIssue", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDateOfIssue_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDateOfIssue", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getDateTimeOfPersonalization;
#pragma warning disable 0169
			static Delegate GetGetDateTimeOfPersonalizationHandler ()
			{
				if (cb_getDateTimeOfPersonalization == null)
					cb_getDateTimeOfPersonalization = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDateTimeOfPersonalization);
				return cb_getDateTimeOfPersonalization;
			}

			static IntPtr n_GetDateTimeOfPersonalization (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG12> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.DateTimeOfPersonalization);
			}
#pragma warning restore 0169

			static Delegate cb_setDateTimeOfPersonalization_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetDateTimeOfPersonalization_Ljava_lang_String_Handler ()
			{
				if (cb_setDateTimeOfPersonalization_Ljava_lang_String_ == null)
					cb_setDateTimeOfPersonalization_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetDateTimeOfPersonalization_Ljava_lang_String_);
				return cb_setDateTimeOfPersonalization_Ljava_lang_String_;
			}

			static void n_SetDateTimeOfPersonalization_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_val)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG12> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var val = JNIEnv.GetString (native_val, JniHandleOwnership.DoNotTransfer);
				__this.DateTimeOfPersonalization = val;
			}
#pragma warning restore 0169

			static IntPtr id_getDateTimeOfPersonalization;
			static IntPtr id_setDateTimeOfPersonalization_Ljava_lang_String_;
			public virtual unsafe string DateTimeOfPersonalization {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG12']/method[@name='getDateTimeOfPersonalization' and count(parameter)=0]"
				[Register ("getDateTimeOfPersonalization", "()Ljava/lang/String;", "GetGetDateTimeOfPersonalizationHandler")]
				get {
					if (id_getDateTimeOfPersonalization == IntPtr.Zero)
						id_getDateTimeOfPersonalization = JNIEnv.GetMethodID (class_ref, "getDateTimeOfPersonalization", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDateTimeOfPersonalization), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDateTimeOfPersonalization", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG12']/method[@name='setDateTimeOfPersonalization' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setDateTimeOfPersonalization", "(Ljava/lang/String;)V", "GetSetDateTimeOfPersonalization_Ljava_lang_String_Handler")]
				set {
					if (id_setDateTimeOfPersonalization_Ljava_lang_String_ == IntPtr.Zero)
						id_setDateTimeOfPersonalization_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDateTimeOfPersonalization", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDateTimeOfPersonalization_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDateTimeOfPersonalization", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getEndorsementObservations;
#pragma warning disable 0169
			static Delegate GetGetEndorsementObservationsHandler ()
			{
				if (cb_getEndorsementObservations == null)
					cb_getEndorsementObservations = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetEndorsementObservations);
				return cb_getEndorsementObservations;
			}

			static IntPtr n_GetEndorsementObservations (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG12> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.EndorsementObservations);
			}
#pragma warning restore 0169

			static Delegate cb_setEndorsementObservations_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetEndorsementObservations_Ljava_lang_String_Handler ()
			{
				if (cb_setEndorsementObservations_Ljava_lang_String_ == null)
					cb_setEndorsementObservations_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetEndorsementObservations_Ljava_lang_String_);
				return cb_setEndorsementObservations_Ljava_lang_String_;
			}

			static void n_SetEndorsementObservations_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_val)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG12> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var val = JNIEnv.GetString (native_val, JniHandleOwnership.DoNotTransfer);
				__this.EndorsementObservations = val;
			}
#pragma warning restore 0169

			static IntPtr id_getEndorsementObservations;
			static IntPtr id_setEndorsementObservations_Ljava_lang_String_;
			public virtual unsafe string EndorsementObservations {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG12']/method[@name='getEndorsementObservations' and count(parameter)=0]"
				[Register ("getEndorsementObservations", "()Ljava/lang/String;", "GetGetEndorsementObservationsHandler")]
				get {
					if (id_getEndorsementObservations == IntPtr.Zero)
						id_getEndorsementObservations = JNIEnv.GetMethodID (class_ref, "getEndorsementObservations", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEndorsementObservations), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEndorsementObservations", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG12']/method[@name='setEndorsementObservations' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setEndorsementObservations", "(Ljava/lang/String;)V", "GetSetEndorsementObservations_Ljava_lang_String_Handler")]
				set {
					if (id_setEndorsementObservations_Ljava_lang_String_ == IntPtr.Zero)
						id_setEndorsementObservations_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setEndorsementObservations", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEndorsementObservations_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEndorsementObservations", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getIssuingAuthority;
#pragma warning disable 0169
			static Delegate GetGetIssuingAuthorityHandler ()
			{
				if (cb_getIssuingAuthority == null)
					cb_getIssuingAuthority = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetIssuingAuthority);
				return cb_getIssuingAuthority;
			}

			static IntPtr n_GetIssuingAuthority (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG12> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.IssuingAuthority);
			}
#pragma warning restore 0169

			static Delegate cb_setIssuingAuthority_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetIssuingAuthority_Ljava_lang_String_Handler ()
			{
				if (cb_setIssuingAuthority_Ljava_lang_String_ == null)
					cb_setIssuingAuthority_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetIssuingAuthority_Ljava_lang_String_);
				return cb_setIssuingAuthority_Ljava_lang_String_;
			}

			static void n_SetIssuingAuthority_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_val)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG12> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var val = JNIEnv.GetString (native_val, JniHandleOwnership.DoNotTransfer);
				__this.IssuingAuthority = val;
			}
#pragma warning restore 0169

			static IntPtr id_getIssuingAuthority;
			static IntPtr id_setIssuingAuthority_Ljava_lang_String_;
			public virtual unsafe string IssuingAuthority {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG12']/method[@name='getIssuingAuthority' and count(parameter)=0]"
				[Register ("getIssuingAuthority", "()Ljava/lang/String;", "GetGetIssuingAuthorityHandler")]
				get {
					if (id_getIssuingAuthority == IntPtr.Zero)
						id_getIssuingAuthority = JNIEnv.GetMethodID (class_ref, "getIssuingAuthority", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIssuingAuthority), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIssuingAuthority", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG12']/method[@name='setIssuingAuthority' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setIssuingAuthority", "(Ljava/lang/String;)V", "GetSetIssuingAuthority_Ljava_lang_String_Handler")]
				set {
					if (id_setIssuingAuthority_Ljava_lang_String_ == IntPtr.Zero)
						id_setIssuingAuthority_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setIssuingAuthority", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIssuingAuthority_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIssuingAuthority", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getNameOfOtherPersons;
#pragma warning disable 0169
			static Delegate GetGetNameOfOtherPersonsHandler ()
			{
				if (cb_getNameOfOtherPersons == null)
					cb_getNameOfOtherPersons = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetNameOfOtherPersons);
				return cb_getNameOfOtherPersons;
			}

			static IntPtr n_GetNameOfOtherPersons (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG12> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.NameOfOtherPersons);
			}
#pragma warning restore 0169

			static Delegate cb_setNameOfOtherPersons_Ljava_util_ArrayList_;
#pragma warning disable 0169
			static Delegate GetSetNameOfOtherPersons_Ljava_util_ArrayList_Handler ()
			{
				if (cb_setNameOfOtherPersons_Ljava_util_ArrayList_ == null)
					cb_setNameOfOtherPersons_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetNameOfOtherPersons_Ljava_util_ArrayList_);
				return cb_setNameOfOtherPersons_Ljava_util_ArrayList_;
			}

			static void n_SetNameOfOtherPersons_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_val)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG12> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var val = global::Android.Runtime.JavaList<string>.FromJniHandle (native_val, JniHandleOwnership.DoNotTransfer);
				__this.NameOfOtherPersons = val;
			}
#pragma warning restore 0169

			static IntPtr id_getNameOfOtherPersons;
			static IntPtr id_setNameOfOtherPersons_Ljava_util_ArrayList_;
			public virtual unsafe global::System.Collections.Generic.IList<string> NameOfOtherPersons {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG12']/method[@name='getNameOfOtherPersons' and count(parameter)=0]"
				[Register ("getNameOfOtherPersons", "()Ljava/util/ArrayList;", "GetGetNameOfOtherPersonsHandler")]
				get {
					if (id_getNameOfOtherPersons == IntPtr.Zero)
						id_getNameOfOtherPersons = JNIEnv.GetMethodID (class_ref, "getNameOfOtherPersons", "()Ljava/util/ArrayList;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNameOfOtherPersons), JniHandleOwnership.TransferLocalRef);
						else
							return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNameOfOtherPersons", "()Ljava/util/ArrayList;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG12']/method[@name='setNameOfOtherPersons' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;java.lang.String&gt;']]"
				[Register ("setNameOfOtherPersons", "(Ljava/util/ArrayList;)V", "GetSetNameOfOtherPersons_Ljava_util_ArrayList_Handler")]
				set {
					if (id_setNameOfOtherPersons_Ljava_util_ArrayList_ == IntPtr.Zero)
						id_setNameOfOtherPersons_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "setNameOfOtherPersons", "(Ljava/util/ArrayList;)V");
					IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNameOfOtherPersons_Ljava_util_ArrayList_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNameOfOtherPersons", "(Ljava/util/ArrayList;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getPersonalizationSystemSerialNumber;
#pragma warning disable 0169
			static Delegate GetGetPersonalizationSystemSerialNumberHandler ()
			{
				if (cb_getPersonalizationSystemSerialNumber == null)
					cb_getPersonalizationSystemSerialNumber = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPersonalizationSystemSerialNumber);
				return cb_getPersonalizationSystemSerialNumber;
			}

			static IntPtr n_GetPersonalizationSystemSerialNumber (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG12> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.PersonalizationSystemSerialNumber);
			}
#pragma warning restore 0169

			static Delegate cb_setPersonalizationSystemSerialNumber_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetPersonalizationSystemSerialNumber_Ljava_lang_String_Handler ()
			{
				if (cb_setPersonalizationSystemSerialNumber_Ljava_lang_String_ == null)
					cb_setPersonalizationSystemSerialNumber_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetPersonalizationSystemSerialNumber_Ljava_lang_String_);
				return cb_setPersonalizationSystemSerialNumber_Ljava_lang_String_;
			}

			static void n_SetPersonalizationSystemSerialNumber_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_val)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG12> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var val = JNIEnv.GetString (native_val, JniHandleOwnership.DoNotTransfer);
				__this.PersonalizationSystemSerialNumber = val;
			}
#pragma warning restore 0169

			static IntPtr id_getPersonalizationSystemSerialNumber;
			static IntPtr id_setPersonalizationSystemSerialNumber_Ljava_lang_String_;
			public virtual unsafe string PersonalizationSystemSerialNumber {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG12']/method[@name='getPersonalizationSystemSerialNumber' and count(parameter)=0]"
				[Register ("getPersonalizationSystemSerialNumber", "()Ljava/lang/String;", "GetGetPersonalizationSystemSerialNumberHandler")]
				get {
					if (id_getPersonalizationSystemSerialNumber == IntPtr.Zero)
						id_getPersonalizationSystemSerialNumber = JNIEnv.GetMethodID (class_ref, "getPersonalizationSystemSerialNumber", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPersonalizationSystemSerialNumber), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPersonalizationSystemSerialNumber", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG12']/method[@name='setPersonalizationSystemSerialNumber' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setPersonalizationSystemSerialNumber", "(Ljava/lang/String;)V", "GetSetPersonalizationSystemSerialNumber_Ljava_lang_String_Handler")]
				set {
					if (id_setPersonalizationSystemSerialNumber_Ljava_lang_String_ == IntPtr.Zero)
						id_setPersonalizationSystemSerialNumber_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPersonalizationSystemSerialNumber", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPersonalizationSystemSerialNumber_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPersonalizationSystemSerialNumber", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getTaxOrExitRequirements;
#pragma warning disable 0169
			static Delegate GetGetTaxOrExitRequirementsHandler ()
			{
				if (cb_getTaxOrExitRequirements == null)
					cb_getTaxOrExitRequirements = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTaxOrExitRequirements);
				return cb_getTaxOrExitRequirements;
			}

			static IntPtr n_GetTaxOrExitRequirements (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG12> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.TaxOrExitRequirements);
			}
#pragma warning restore 0169

			static Delegate cb_setTaxOrExitRequirements_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetTaxOrExitRequirements_Ljava_lang_String_Handler ()
			{
				if (cb_setTaxOrExitRequirements_Ljava_lang_String_ == null)
					cb_setTaxOrExitRequirements_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetTaxOrExitRequirements_Ljava_lang_String_);
				return cb_setTaxOrExitRequirements_Ljava_lang_String_;
			}

			static void n_SetTaxOrExitRequirements_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_val)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG12> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var val = JNIEnv.GetString (native_val, JniHandleOwnership.DoNotTransfer);
				__this.TaxOrExitRequirements = val;
			}
#pragma warning restore 0169

			static IntPtr id_getTaxOrExitRequirements;
			static IntPtr id_setTaxOrExitRequirements_Ljava_lang_String_;
			public virtual unsafe string TaxOrExitRequirements {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG12']/method[@name='getTaxOrExitRequirements' and count(parameter)=0]"
				[Register ("getTaxOrExitRequirements", "()Ljava/lang/String;", "GetGetTaxOrExitRequirementsHandler")]
				get {
					if (id_getTaxOrExitRequirements == IntPtr.Zero)
						id_getTaxOrExitRequirements = JNIEnv.GetMethodID (class_ref, "getTaxOrExitRequirements", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTaxOrExitRequirements), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTaxOrExitRequirements", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG12']/method[@name='setTaxOrExitRequirements' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setTaxOrExitRequirements", "(Ljava/lang/String;)V", "GetSetTaxOrExitRequirements_Ljava_lang_String_Handler")]
				set {
					if (id_setTaxOrExitRequirements_Ljava_lang_String_ == IntPtr.Zero)
						id_setTaxOrExitRequirements_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTaxOrExitRequirements", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTaxOrExitRequirements_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTaxOrExitRequirements", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getImageOfFront;
#pragma warning disable 0169
			static Delegate GetGetImageOfFrontHandler ()
			{
				if (cb_getImageOfFront == null)
					cb_getImageOfFront = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetImageOfFront);
				return cb_getImageOfFront;
			}

			static IntPtr n_GetImageOfFront (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG12> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewArray (__this.GetImageOfFront ());
			}
#pragma warning restore 0169

			static IntPtr id_getImageOfFront;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG12']/method[@name='getImageOfFront' and count(parameter)=0]"
			[Register ("getImageOfFront", "()[B", "GetGetImageOfFrontHandler")]
			public virtual unsafe byte[] GetImageOfFront ()
			{
				if (id_getImageOfFront == IntPtr.Zero)
					id_getImageOfFront = JNIEnv.GetMethodID (class_ref, "getImageOfFront", "()[B");
				try {

					if (((object) this).GetType () == ThresholdType)
						return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getImageOfFront), JniHandleOwnership.TransferLocalRef, typeof (byte));
					else
						return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImageOfFront", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
				} finally {
				}
			}

			static Delegate cb_getImageOfRear;
#pragma warning disable 0169
			static Delegate GetGetImageOfRearHandler ()
			{
				if (cb_getImageOfRear == null)
					cb_getImageOfRear = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetImageOfRear);
				return cb_getImageOfRear;
			}

			static IntPtr n_GetImageOfRear (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG12> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewArray (__this.GetImageOfRear ());
			}
#pragma warning restore 0169

			static IntPtr id_getImageOfRear;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG12']/method[@name='getImageOfRear' and count(parameter)=0]"
			[Register ("getImageOfRear", "()[B", "GetGetImageOfRearHandler")]
			public virtual unsafe byte[] GetImageOfRear ()
			{
				if (id_getImageOfRear == IntPtr.Zero)
					id_getImageOfRear = JNIEnv.GetMethodID (class_ref, "getImageOfRear", "()[B");
				try {

					if (((object) this).GetType () == ThresholdType)
						return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getImageOfRear), JniHandleOwnership.TransferLocalRef, typeof (byte));
					else
						return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImageOfRear", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
				} finally {
				}
			}

			static Delegate cb_setImageOfFront_arrayB;
#pragma warning disable 0169
			static Delegate GetSetImageOfFront_arrayBHandler ()
			{
				if (cb_setImageOfFront_arrayB == null)
					cb_setImageOfFront_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetImageOfFront_arrayB);
				return cb_setImageOfFront_arrayB;
			}

			static void n_SetImageOfFront_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_val)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG12> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var val = (byte[]) JNIEnv.GetArray (native_val, JniHandleOwnership.DoNotTransfer, typeof (byte));
				__this.SetImageOfFront (val);
				if (val != null)
					JNIEnv.CopyArray (val, native_val);
			}
#pragma warning restore 0169

			static IntPtr id_setImageOfFront_arrayB;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG12']/method[@name='setImageOfFront' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("setImageOfFront", "([B)V", "GetSetImageOfFront_arrayBHandler")]
			public virtual unsafe void SetImageOfFront (byte[] val)
			{
				if (id_setImageOfFront_arrayB == IntPtr.Zero)
					id_setImageOfFront_arrayB = JNIEnv.GetMethodID (class_ref, "setImageOfFront", "([B)V");
				IntPtr native_val = JNIEnv.NewArray (val);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_val);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setImageOfFront_arrayB, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setImageOfFront", "([B)V"), __args);
				} finally {
					if (val != null) {
						JNIEnv.CopyArray (native_val, val);
						JNIEnv.DeleteLocalRef (native_val);
					}
				}
			}

			static Delegate cb_setImageOfRear_arrayB;
#pragma warning disable 0169
			static Delegate GetSetImageOfRear_arrayBHandler ()
			{
				if (cb_setImageOfRear_arrayB == null)
					cb_setImageOfRear_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetImageOfRear_arrayB);
				return cb_setImageOfRear_arrayB;
			}

			static void n_SetImageOfRear_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_val)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG12> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var val = (byte[]) JNIEnv.GetArray (native_val, JniHandleOwnership.DoNotTransfer, typeof (byte));
				__this.SetImageOfRear (val);
				if (val != null)
					JNIEnv.CopyArray (val, native_val);
			}
#pragma warning restore 0169

			static IntPtr id_setImageOfRear_arrayB;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG12']/method[@name='setImageOfRear' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("setImageOfRear", "([B)V", "GetSetImageOfRear_arrayBHandler")]
			public virtual unsafe void SetImageOfRear (byte[] val)
			{
				if (id_setImageOfRear_arrayB == IntPtr.Zero)
					id_setImageOfRear_arrayB = JNIEnv.GetMethodID (class_ref, "setImageOfRear", "([B)V");
				IntPtr native_val = JNIEnv.NewArray (val);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_val);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setImageOfRear_arrayB, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setImageOfRear", "([B)V"), __args);
				} finally {
					if (val != null) {
						JNIEnv.CopyArray (native_val, val);
						JNIEnv.DeleteLocalRef (native_val);
					}
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG2']"
		[global::Android.Runtime.Register ("com/credenceid/icao/ICAODocumentData$DG2", DoNotGenerateAcw=true)]
		public partial class DG2 : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/credenceid/icao/ICAODocumentData$DG2", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DG2); }
			}

			protected DG2 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_credenceid_icao_ICAODocumentData_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG2']/constructor[@name='ICAODocumentData.DG2' and count(parameter)=1 and parameter[1][@type='com.credenceid.icao.ICAODocumentData']]"
			[Register (".ctor", "(Lcom/credenceid/icao/ICAODocumentData;)V", "")]
			public unsafe DG2 (global::Com.Credenceid.Icao.ICAODocumentData __self)
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

					if (id_ctor_Lcom_credenceid_icao_ICAODocumentData_ == IntPtr.Zero)
						id_ctor_Lcom_credenceid_icao_ICAODocumentData_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/credenceid/icao/ICAODocumentData;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_credenceid_icao_ICAODocumentData_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_credenceid_icao_ICAODocumentData_, __args);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var faceBitmap = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_faceBitmap, JniHandleOwnership.DoNotTransfer);
				__this.FaceImage = faceBitmap;
			}
#pragma warning restore 0169

			static IntPtr id_getFaceImage;
			static IntPtr id_setFaceImage_Landroid_graphics_Bitmap_;
			public virtual unsafe global::Android.Graphics.Bitmap FaceImage {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG2']/method[@name='getFaceImage' and count(parameter)=0]"
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
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG2']/method[@name='setFaceImage' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG3']"
		[global::Android.Runtime.Register ("com/credenceid/icao/ICAODocumentData$DG3", DoNotGenerateAcw=true)]
		public partial class DG3 : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/credenceid/icao/ICAODocumentData$DG3", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DG3); }
			}

			protected DG3 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_credenceid_icao_ICAODocumentData_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG3']/constructor[@name='ICAODocumentData.DG3' and count(parameter)=1 and parameter[1][@type='com.credenceid.icao.ICAODocumentData']]"
			[Register (".ctor", "(Lcom/credenceid/icao/ICAODocumentData;)V", "")]
			public unsafe DG3 (global::Com.Credenceid.Icao.ICAODocumentData __self)
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

					if (id_ctor_Lcom_credenceid_icao_ICAODocumentData_ == IntPtr.Zero)
						id_ctor_Lcom_credenceid_icao_ICAODocumentData_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/credenceid/icao/ICAODocumentData;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_credenceid_icao_ICAODocumentData_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_credenceid_icao_ICAODocumentData_, __args);
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
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG3> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return global::Android.Runtime.JavaList<global::Com.Credenceid.Icao.FingerInfo>.ToLocalJniHandle (__this.Fingers);
			}
#pragma warning restore 0169

			static IntPtr id_getFingers;
			public virtual unsafe global::System.Collections.Generic.IList<global::Com.Credenceid.Icao.FingerInfo> Fingers {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG3']/method[@name='getFingers' and count(parameter)=0]"
				[Register ("getFingers", "()Ljava/util/ArrayList;", "GetGetFingersHandler")]
				get {
					if (id_getFingers == IntPtr.Zero)
						id_getFingers = JNIEnv.GetMethodID (class_ref, "getFingers", "()Ljava/util/ArrayList;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return global::Android.Runtime.JavaList<global::Com.Credenceid.Icao.FingerInfo>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFingers), JniHandleOwnership.TransferLocalRef);
						else
							return global::Android.Runtime.JavaList<global::Com.Credenceid.Icao.FingerInfo>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFingers", "()Ljava/util/ArrayList;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_addFinger_Lcom_credenceid_icao_FingerInfo_;
#pragma warning disable 0169
			static Delegate GetAddFinger_Lcom_credenceid_icao_FingerInfo_Handler ()
			{
				if (cb_addFinger_Lcom_credenceid_icao_FingerInfo_ == null)
					cb_addFinger_Lcom_credenceid_icao_FingerInfo_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AddFinger_Lcom_credenceid_icao_FingerInfo_);
				return cb_addFinger_Lcom_credenceid_icao_FingerInfo_;
			}

			static void n_AddFinger_Lcom_credenceid_icao_FingerInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fingerInfo)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG3> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var fingerInfo = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.FingerInfo> (native_fingerInfo, JniHandleOwnership.DoNotTransfer);
				__this.AddFinger (fingerInfo);
			}
#pragma warning restore 0169

			static IntPtr id_addFinger_Lcom_credenceid_icao_FingerInfo_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG3']/method[@name='addFinger' and count(parameter)=1 and parameter[1][@type='com.credenceid.icao.FingerInfo']]"
			[Register ("addFinger", "(Lcom/credenceid/icao/FingerInfo;)V", "GetAddFinger_Lcom_credenceid_icao_FingerInfo_Handler")]
			public virtual unsafe void AddFinger (global::Com.Credenceid.Icao.FingerInfo fingerInfo)
			{
				if (id_addFinger_Lcom_credenceid_icao_FingerInfo_ == IntPtr.Zero)
					id_addFinger_Lcom_credenceid_icao_FingerInfo_ = JNIEnv.GetMethodID (class_ref, "addFinger", "(Lcom/credenceid/icao/FingerInfo;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (fingerInfo);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addFinger_Lcom_credenceid_icao_FingerInfo_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addFinger", "(Lcom/credenceid/icao/FingerInfo;)V"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG7']"
		[global::Android.Runtime.Register ("com/credenceid/icao/ICAODocumentData$DG7", DoNotGenerateAcw=true)]
		public partial class DG7 : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/credenceid/icao/ICAODocumentData$DG7", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DG7); }
			}

			protected DG7 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_credenceid_icao_ICAODocumentData_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG7']/constructor[@name='ICAODocumentData.DG7' and count(parameter)=1 and parameter[1][@type='com.credenceid.icao.ICAODocumentData']]"
			[Register (".ctor", "(Lcom/credenceid/icao/ICAODocumentData;)V", "")]
			public unsafe DG7 (global::Com.Credenceid.Icao.ICAODocumentData __self)
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

					if (id_ctor_Lcom_credenceid_icao_ICAODocumentData_ == IntPtr.Zero)
						id_ctor_Lcom_credenceid_icao_ICAODocumentData_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/credenceid/icao/ICAODocumentData;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_credenceid_icao_ICAODocumentData_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_credenceid_icao_ICAODocumentData_, __args);
				} finally {
				}
			}

			static Delegate cb_getSignature;
#pragma warning disable 0169
			static Delegate GetGetSignatureHandler ()
			{
				if (cb_getSignature == null)
					cb_getSignature = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSignature);
				return cb_getSignature;
			}

			static IntPtr n_GetSignature (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG7> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Signature);
			}
#pragma warning restore 0169

			static Delegate cb_setSignature_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
			static Delegate GetSetSignature_Landroid_graphics_Bitmap_Handler ()
			{
				if (cb_setSignature_Landroid_graphics_Bitmap_ == null)
					cb_setSignature_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetSignature_Landroid_graphics_Bitmap_);
				return cb_setSignature_Landroid_graphics_Bitmap_;
			}

			static void n_SetSignature_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_signature)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData.DG7> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var signature = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_signature, JniHandleOwnership.DoNotTransfer);
				__this.Signature = signature;
			}
#pragma warning restore 0169

			static IntPtr id_getSignature;
			static IntPtr id_setSignature_Landroid_graphics_Bitmap_;
			public virtual unsafe global::Android.Graphics.Bitmap Signature {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG7']/method[@name='getSignature' and count(parameter)=0]"
				[Register ("getSignature", "()Landroid/graphics/Bitmap;", "GetGetSignatureHandler")]
				get {
					if (id_getSignature == IntPtr.Zero)
						id_getSignature = JNIEnv.GetMethodID (class_ref, "getSignature", "()Landroid/graphics/Bitmap;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSignature), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSignature", "()Landroid/graphics/Bitmap;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData.DG7']/method[@name='setSignature' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
				[Register ("setSignature", "(Landroid/graphics/Bitmap;)V", "GetSetSignature_Landroid_graphics_Bitmap_Handler")]
				set {
					if (id_setSignature_Landroid_graphics_Bitmap_ == IntPtr.Zero)
						id_setSignature_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "setSignature", "(Landroid/graphics/Bitmap;)V");
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSignature_Landroid_graphics_Bitmap_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSignature", "(Landroid/graphics/Bitmap;)V"), __args);
					} finally {
					}
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/credenceid/icao/ICAODocumentData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ICAODocumentData); }
		}

		protected ICAODocumentData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.icao']/class[@name='ICAODocumentData']/constructor[@name='ICAODocumentData' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ICAODocumentData ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ICAODocumentData)) {
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
