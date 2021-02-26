using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Credenceid.Biometrics {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.CardReaderStatusListener']"
	[Register ("com/credenceid/biometrics/Biometrics$CardReaderStatusListener", "", "Com.Credenceid.Biometrics.IBiometricsCardReaderStatusListenerInvoker")]
	public partial interface IBiometricsCardReaderStatusListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.CardReaderStatusListener']/method[@name='onCardReaderClosed' and count(parameter)=2 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ResultCode'] and parameter[2][@type='com.credenceid.biometrics.Biometrics.CloseReasonCode']]"
		[Register ("onCardReaderClosed", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Lcom/credenceid/biometrics/Biometrics$CloseReasonCode;)V", "GetOnCardReaderClosed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_Handler:Com.Credenceid.Biometrics.IBiometricsCardReaderStatusListenerInvoker, CredenceBindings")]
		void OnCardReaderClosed (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.CardReaderStatusListener']/method[@name='onCardReaderOpen' and count(parameter)=1 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ResultCode']]"
		[Register ("onCardReaderOpen", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;)V", "GetOnCardReaderOpen_Lcom_credenceid_biometrics_Biometrics_ResultCode_Handler:Com.Credenceid.Biometrics.IBiometricsCardReaderStatusListenerInvoker, CredenceBindings")]
		void OnCardReaderOpen (global::Com.Credenceid.Biometrics.BiometricsResultCode p0);

	}

	[global::Android.Runtime.Register ("com/credenceid/biometrics/Biometrics$CardReaderStatusListener", DoNotGenerateAcw=true)]
	internal partial class IBiometricsCardReaderStatusListenerInvoker : global::Java.Lang.Object, IBiometricsCardReaderStatusListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/credenceid/biometrics/Biometrics$CardReaderStatusListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBiometricsCardReaderStatusListenerInvoker); }
		}

		IntPtr class_ref;

		public static IBiometricsCardReaderStatusListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBiometricsCardReaderStatusListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.credenceid.biometrics.Biometrics.CardReaderStatusListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBiometricsCardReaderStatusListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onCardReaderClosed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_;
#pragma warning disable 0169
		static Delegate GetOnCardReaderClosed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_Handler ()
		{
			if (cb_onCardReaderClosed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_ == null)
				cb_onCardReaderClosed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnCardReaderClosed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_);
			return cb_onCardReaderClosed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_;
		}

		static void n_OnCardReaderClosed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsCardReaderStatusListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsResultCode> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnCardReaderClosed (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onCardReaderClosed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_;
		public unsafe void OnCardReaderClosed (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode p1)
		{
			if (id_onCardReaderClosed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_ == IntPtr.Zero)
				id_onCardReaderClosed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_ = JNIEnv.GetMethodID (class_ref, "onCardReaderClosed", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Lcom/credenceid/biometrics/Biometrics$CloseReasonCode;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCardReaderClosed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_, __args);
		}

		static Delegate cb_onCardReaderOpen_Lcom_credenceid_biometrics_Biometrics_ResultCode_;
#pragma warning disable 0169
		static Delegate GetOnCardReaderOpen_Lcom_credenceid_biometrics_Biometrics_ResultCode_Handler ()
		{
			if (cb_onCardReaderOpen_Lcom_credenceid_biometrics_Biometrics_ResultCode_ == null)
				cb_onCardReaderOpen_Lcom_credenceid_biometrics_Biometrics_ResultCode_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnCardReaderOpen_Lcom_credenceid_biometrics_Biometrics_ResultCode_);
			return cb_onCardReaderOpen_Lcom_credenceid_biometrics_Biometrics_ResultCode_;
		}

		static void n_OnCardReaderOpen_Lcom_credenceid_biometrics_Biometrics_ResultCode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsCardReaderStatusListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsResultCode> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCardReaderOpen (p0);
		}
#pragma warning restore 0169

		IntPtr id_onCardReaderOpen_Lcom_credenceid_biometrics_Biometrics_ResultCode_;
		public unsafe void OnCardReaderOpen (global::Com.Credenceid.Biometrics.BiometricsResultCode p0)
		{
			if (id_onCardReaderOpen_Lcom_credenceid_biometrics_Biometrics_ResultCode_ == IntPtr.Zero)
				id_onCardReaderOpen_Lcom_credenceid_biometrics_Biometrics_ResultCode_ = JNIEnv.GetMethodID (class_ref, "onCardReaderOpen", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCardReaderOpen_Lcom_credenceid_biometrics_Biometrics_ResultCode_, __args);
		}

	}

	// event args for com.credenceid.biometrics.Biometrics.CardReaderStatusListener.onCardReaderClosed
	public partial class CardReaderClosedEventArgs : global::System.EventArgs {

		public CardReaderClosedEventArgs (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Credenceid.Biometrics.BiometricsResultCode p0;
		public global::Com.Credenceid.Biometrics.BiometricsResultCode P0 {
			get { return p0; }
		}

		global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode p1;
		public global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode P1 {
			get { return p1; }
		}
	}

	// event args for com.credenceid.biometrics.Biometrics.CardReaderStatusListener.onCardReaderOpen
	public partial class CardReaderOpenEventArgs : global::System.EventArgs {

		public CardReaderOpenEventArgs (global::Com.Credenceid.Biometrics.BiometricsResultCode p0)
		{
			this.p0 = p0;
		}

		global::Com.Credenceid.Biometrics.BiometricsResultCode p0;
		public global::Com.Credenceid.Biometrics.BiometricsResultCode P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/credenceid/biometrics/Biometrics_CardReaderStatusListenerImplementor")]
	internal sealed partial class IBiometricsCardReaderStatusListenerImplementor : global::Java.Lang.Object, IBiometricsCardReaderStatusListener {

		object sender;

		public IBiometricsCardReaderStatusListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/credenceid/biometrics/Biometrics_CardReaderStatusListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<CardReaderClosedEventArgs> OnCardReaderClosedHandler;
#pragma warning restore 0649

		public void OnCardReaderClosed (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode p1)
		{
			var __h = OnCardReaderClosedHandler;
			if (__h != null)
				__h (sender, new CardReaderClosedEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<CardReaderOpenEventArgs> OnCardReaderOpenHandler;
#pragma warning restore 0649

		public void OnCardReaderOpen (global::Com.Credenceid.Biometrics.BiometricsResultCode p0)
		{
			var __h = OnCardReaderOpenHandler;
			if (__h != null)
				__h (sender, new CardReaderOpenEventArgs (p0));
		}

		internal static bool __IsEmpty (IBiometricsCardReaderStatusListenerImplementor value)
		{
			return value.OnCardReaderClosedHandler == null && value.OnCardReaderOpenHandler == null;
		}
	}


	// Metadata.xml XPath class reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='Biometrics.CloseReasonCode']"
	[global::Android.Runtime.Register ("com/credenceid/biometrics/Biometrics$CloseReasonCode", DoNotGenerateAcw=true)]
	public sealed partial class BiometricsCloseReasonCode : global::Java.Lang.Enum {


		static IntPtr NORMAL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='Biometrics.CloseReasonCode']/field[@name='NORMAL']"
		[Register ("NORMAL")]
		public static global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode Normal {
			get {
				if (NORMAL_jfieldId == IntPtr.Zero)
					NORMAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NORMAL", "Lcom/credenceid/biometrics/Biometrics$CloseReasonCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NORMAL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SCREEN_OFF_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='Biometrics.CloseReasonCode']/field[@name='SCREEN_OFF']"
		[Register ("SCREEN_OFF")]
		public static global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode ScreenOff {
			get {
				if (SCREEN_OFF_jfieldId == IntPtr.Zero)
					SCREEN_OFF_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SCREEN_OFF", "Lcom/credenceid/biometrics/Biometrics$CloseReasonCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SCREEN_OFF_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SYSTEM_OFF_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='Biometrics.CloseReasonCode']/field[@name='SYSTEM_OFF']"
		[Register ("SYSTEM_OFF")]
		public static global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode SystemOff {
			get {
				if (SYSTEM_OFF_jfieldId == IntPtr.Zero)
					SYSTEM_OFF_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SYSTEM_OFF", "Lcom/credenceid/biometrics/Biometrics$CloseReasonCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SYSTEM_OFF_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TIMEOUT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='Biometrics.CloseReasonCode']/field[@name='TIMEOUT']"
		[Register ("TIMEOUT")]
		public static global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode Timeout {
			get {
				if (TIMEOUT_jfieldId == IntPtr.Zero)
					TIMEOUT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TIMEOUT", "Lcom/credenceid/biometrics/Biometrics$CloseReasonCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TIMEOUT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/credenceid/biometrics/Biometrics$CloseReasonCode", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BiometricsCloseReasonCode); }
		}

		internal BiometricsCloseReasonCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='Biometrics.CloseReasonCode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/credenceid/biometrics/Biometrics$CloseReasonCode;", "")]
		public static unsafe global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode ValueOf (string name)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/credenceid/biometrics/Biometrics$CloseReasonCode;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode __ret = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='Biometrics.CloseReasonCode']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/credenceid/biometrics/Biometrics$CloseReasonCode;", "")]
		public static unsafe global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/credenceid/biometrics/Biometrics$CloseReasonCode;");
			try {
				return (global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode));
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.EPassportReaderStatusListener']"
	[Register ("com/credenceid/biometrics/Biometrics$EPassportReaderStatusListener", "", "Com.Credenceid.Biometrics.IBiometricsEPassportReaderStatusListenerInvoker")]
	public partial interface IBiometricsEPassportReaderStatusListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.EPassportReaderStatusListener']/method[@name='onEPassportReaderClosed' and count(parameter)=2 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ResultCode'] and parameter[2][@type='com.credenceid.biometrics.Biometrics.CloseReasonCode']]"
		[Register ("onEPassportReaderClosed", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Lcom/credenceid/biometrics/Biometrics$CloseReasonCode;)V", "GetOnEPassportReaderClosed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_Handler:Com.Credenceid.Biometrics.IBiometricsEPassportReaderStatusListenerInvoker, CredenceBindings")]
		void OnEPassportReaderClosed (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.EPassportReaderStatusListener']/method[@name='onEPassportReaderOpen' and count(parameter)=1 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ResultCode']]"
		[Register ("onEPassportReaderOpen", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;)V", "GetOnEPassportReaderOpen_Lcom_credenceid_biometrics_Biometrics_ResultCode_Handler:Com.Credenceid.Biometrics.IBiometricsEPassportReaderStatusListenerInvoker, CredenceBindings")]
		void OnEPassportReaderOpen (global::Com.Credenceid.Biometrics.BiometricsResultCode p0);

	}

	[global::Android.Runtime.Register ("com/credenceid/biometrics/Biometrics$EPassportReaderStatusListener", DoNotGenerateAcw=true)]
	internal partial class IBiometricsEPassportReaderStatusListenerInvoker : global::Java.Lang.Object, IBiometricsEPassportReaderStatusListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/credenceid/biometrics/Biometrics$EPassportReaderStatusListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBiometricsEPassportReaderStatusListenerInvoker); }
		}

		IntPtr class_ref;

		public static IBiometricsEPassportReaderStatusListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBiometricsEPassportReaderStatusListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.credenceid.biometrics.Biometrics.EPassportReaderStatusListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBiometricsEPassportReaderStatusListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onEPassportReaderClosed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_;
#pragma warning disable 0169
		static Delegate GetOnEPassportReaderClosed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_Handler ()
		{
			if (cb_onEPassportReaderClosed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_ == null)
				cb_onEPassportReaderClosed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnEPassportReaderClosed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_);
			return cb_onEPassportReaderClosed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_;
		}

		static void n_OnEPassportReaderClosed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsEPassportReaderStatusListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsResultCode> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnEPassportReaderClosed (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onEPassportReaderClosed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_;
		public unsafe void OnEPassportReaderClosed (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode p1)
		{
			if (id_onEPassportReaderClosed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_ == IntPtr.Zero)
				id_onEPassportReaderClosed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_ = JNIEnv.GetMethodID (class_ref, "onEPassportReaderClosed", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Lcom/credenceid/biometrics/Biometrics$CloseReasonCode;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onEPassportReaderClosed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_, __args);
		}

		static Delegate cb_onEPassportReaderOpen_Lcom_credenceid_biometrics_Biometrics_ResultCode_;
#pragma warning disable 0169
		static Delegate GetOnEPassportReaderOpen_Lcom_credenceid_biometrics_Biometrics_ResultCode_Handler ()
		{
			if (cb_onEPassportReaderOpen_Lcom_credenceid_biometrics_Biometrics_ResultCode_ == null)
				cb_onEPassportReaderOpen_Lcom_credenceid_biometrics_Biometrics_ResultCode_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnEPassportReaderOpen_Lcom_credenceid_biometrics_Biometrics_ResultCode_);
			return cb_onEPassportReaderOpen_Lcom_credenceid_biometrics_Biometrics_ResultCode_;
		}

		static void n_OnEPassportReaderOpen_Lcom_credenceid_biometrics_Biometrics_ResultCode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsEPassportReaderStatusListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsResultCode> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnEPassportReaderOpen (p0);
		}
#pragma warning restore 0169

		IntPtr id_onEPassportReaderOpen_Lcom_credenceid_biometrics_Biometrics_ResultCode_;
		public unsafe void OnEPassportReaderOpen (global::Com.Credenceid.Biometrics.BiometricsResultCode p0)
		{
			if (id_onEPassportReaderOpen_Lcom_credenceid_biometrics_Biometrics_ResultCode_ == IntPtr.Zero)
				id_onEPassportReaderOpen_Lcom_credenceid_biometrics_Biometrics_ResultCode_ = JNIEnv.GetMethodID (class_ref, "onEPassportReaderOpen", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onEPassportReaderOpen_Lcom_credenceid_biometrics_Biometrics_ResultCode_, __args);
		}

	}

	// event args for com.credenceid.biometrics.Biometrics.EPassportReaderStatusListener.onEPassportReaderClosed
	public partial class EPassportReaderClosedEventArgs : global::System.EventArgs {

		public EPassportReaderClosedEventArgs (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Credenceid.Biometrics.BiometricsResultCode p0;
		public global::Com.Credenceid.Biometrics.BiometricsResultCode P0 {
			get { return p0; }
		}

		global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode p1;
		public global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode P1 {
			get { return p1; }
		}
	}

	// event args for com.credenceid.biometrics.Biometrics.EPassportReaderStatusListener.onEPassportReaderOpen
	public partial class EPassportReaderOpenEventArgs : global::System.EventArgs {

		public EPassportReaderOpenEventArgs (global::Com.Credenceid.Biometrics.BiometricsResultCode p0)
		{
			this.p0 = p0;
		}

		global::Com.Credenceid.Biometrics.BiometricsResultCode p0;
		public global::Com.Credenceid.Biometrics.BiometricsResultCode P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/credenceid/biometrics/Biometrics_EPassportReaderStatusListenerImplementor")]
	internal sealed partial class IBiometricsEPassportReaderStatusListenerImplementor : global::Java.Lang.Object, IBiometricsEPassportReaderStatusListener {

		object sender;

		public IBiometricsEPassportReaderStatusListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/credenceid/biometrics/Biometrics_EPassportReaderStatusListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<EPassportReaderClosedEventArgs> OnEPassportReaderClosedHandler;
#pragma warning restore 0649

		public void OnEPassportReaderClosed (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode p1)
		{
			var __h = OnEPassportReaderClosedHandler;
			if (__h != null)
				__h (sender, new EPassportReaderClosedEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<EPassportReaderOpenEventArgs> OnEPassportReaderOpenHandler;
#pragma warning restore 0649

		public void OnEPassportReaderOpen (global::Com.Credenceid.Biometrics.BiometricsResultCode p0)
		{
			var __h = OnEPassportReaderOpenHandler;
			if (__h != null)
				__h (sender, new EPassportReaderOpenEventArgs (p0));
		}

		internal static bool __IsEmpty (IBiometricsEPassportReaderStatusListenerImplementor value)
		{
			return value.OnEPassportReaderClosedHandler == null && value.OnEPassportReaderOpenHandler == null;
		}
	}


	// Metadata.xml XPath class reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='Biometrics.EyeSelection']"
	[global::Android.Runtime.Register ("com/credenceid/biometrics/Biometrics$EyeSelection", DoNotGenerateAcw=true)]
	public sealed partial class BiometricsEyeSelection : global::Java.Lang.Enum {


		static IntPtr BOTH_EYES_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='Biometrics.EyeSelection']/field[@name='BOTH_EYES']"
		[Register ("BOTH_EYES")]
		public static global::Com.Credenceid.Biometrics.BiometricsEyeSelection BothEyes {
			get {
				if (BOTH_EYES_jfieldId == IntPtr.Zero)
					BOTH_EYES_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BOTH_EYES", "Lcom/credenceid/biometrics/Biometrics$EyeSelection;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BOTH_EYES_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsEyeSelection> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr LEFT_EYE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='Biometrics.EyeSelection']/field[@name='LEFT_EYE']"
		[Register ("LEFT_EYE")]
		public static global::Com.Credenceid.Biometrics.BiometricsEyeSelection LeftEye {
			get {
				if (LEFT_EYE_jfieldId == IntPtr.Zero)
					LEFT_EYE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LEFT_EYE", "Lcom/credenceid/biometrics/Biometrics$EyeSelection;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LEFT_EYE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsEyeSelection> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr RIGHT_EYE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='Biometrics.EyeSelection']/field[@name='RIGHT_EYE']"
		[Register ("RIGHT_EYE")]
		public static global::Com.Credenceid.Biometrics.BiometricsEyeSelection RightEye {
			get {
				if (RIGHT_EYE_jfieldId == IntPtr.Zero)
					RIGHT_EYE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RIGHT_EYE", "Lcom/credenceid/biometrics/Biometrics$EyeSelection;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RIGHT_EYE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsEyeSelection> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/credenceid/biometrics/Biometrics$EyeSelection", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BiometricsEyeSelection); }
		}

		internal BiometricsEyeSelection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='Biometrics.EyeSelection']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/credenceid/biometrics/Biometrics$EyeSelection;", "")]
		public static unsafe global::Com.Credenceid.Biometrics.BiometricsEyeSelection ValueOf (string name)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/credenceid/biometrics/Biometrics$EyeSelection;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::Com.Credenceid.Biometrics.BiometricsEyeSelection __ret = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsEyeSelection> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='Biometrics.EyeSelection']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/credenceid/biometrics/Biometrics$EyeSelection;", "")]
		public static unsafe global::Com.Credenceid.Biometrics.BiometricsEyeSelection[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/credenceid/biometrics/Biometrics$EyeSelection;");
			try {
				return (global::Com.Credenceid.Biometrics.BiometricsEyeSelection[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Credenceid.Biometrics.BiometricsEyeSelection));
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.FingerprintReaderStatusListener']"
	[Register ("com/credenceid/biometrics/Biometrics$FingerprintReaderStatusListener", "", "Com.Credenceid.Biometrics.IBiometricsFingerprintReaderStatusListenerInvoker")]
	public partial interface IBiometricsFingerprintReaderStatusListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.FingerprintReaderStatusListener']/method[@name='onCloseFingerprintReader' and count(parameter)=2 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ResultCode'] and parameter[2][@type='com.credenceid.biometrics.Biometrics.CloseReasonCode']]"
		[Register ("onCloseFingerprintReader", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Lcom/credenceid/biometrics/Biometrics$CloseReasonCode;)V", "GetOnCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_Handler:Com.Credenceid.Biometrics.IBiometricsFingerprintReaderStatusListenerInvoker, CredenceBindings")]
		void OnCloseFingerprintReader (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.FingerprintReaderStatusListener']/method[@name='onOpenFingerprintReader' and count(parameter)=2 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ResultCode'] and parameter[2][@type='java.lang.String']]"
		[Register ("onOpenFingerprintReader", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Ljava/lang/String;)V", "GetOnOpenFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_Handler:Com.Credenceid.Biometrics.IBiometricsFingerprintReaderStatusListenerInvoker, CredenceBindings")]
		void OnOpenFingerprintReader (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, string p1);

	}

	[global::Android.Runtime.Register ("com/credenceid/biometrics/Biometrics$FingerprintReaderStatusListener", DoNotGenerateAcw=true)]
	internal partial class IBiometricsFingerprintReaderStatusListenerInvoker : global::Java.Lang.Object, IBiometricsFingerprintReaderStatusListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/credenceid/biometrics/Biometrics$FingerprintReaderStatusListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBiometricsFingerprintReaderStatusListenerInvoker); }
		}

		IntPtr class_ref;

		public static IBiometricsFingerprintReaderStatusListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBiometricsFingerprintReaderStatusListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.credenceid.biometrics.Biometrics.FingerprintReaderStatusListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBiometricsFingerprintReaderStatusListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_;
#pragma warning disable 0169
		static Delegate GetOnCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_Handler ()
		{
			if (cb_onCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_ == null)
				cb_onCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_);
			return cb_onCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_;
		}

		static void n_OnCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsFingerprintReaderStatusListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsResultCode> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnCloseFingerprintReader (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_;
		public unsafe void OnCloseFingerprintReader (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode p1)
		{
			if (id_onCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_ == IntPtr.Zero)
				id_onCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_ = JNIEnv.GetMethodID (class_ref, "onCloseFingerprintReader", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Lcom/credenceid/biometrics/Biometrics$CloseReasonCode;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_, __args);
		}

		static Delegate cb_onOpenFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnOpenFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_Handler ()
		{
			if (cb_onOpenFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_ == null)
				cb_onOpenFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnOpenFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_);
			return cb_onOpenFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_;
		}

		static void n_OnOpenFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsFingerprintReaderStatusListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsResultCode> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnOpenFingerprintReader (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onOpenFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_;
		public unsafe void OnOpenFingerprintReader (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, string p1)
		{
			if (id_onOpenFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_ == IntPtr.Zero)
				id_onOpenFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onOpenFingerprintReader", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onOpenFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

	// event args for com.credenceid.biometrics.Biometrics.FingerprintReaderStatusListener.onCloseFingerprintReader
	public partial class CloseFingerprintReaderEventArgs : global::System.EventArgs {

		public CloseFingerprintReaderEventArgs (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Credenceid.Biometrics.BiometricsResultCode p0;
		public global::Com.Credenceid.Biometrics.BiometricsResultCode P0 {
			get { return p0; }
		}

		global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode p1;
		public global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode P1 {
			get { return p1; }
		}
	}

	// event args for com.credenceid.biometrics.Biometrics.FingerprintReaderStatusListener.onOpenFingerprintReader
	public partial class OpenFingerprintReaderEventArgs : global::System.EventArgs {

		public OpenFingerprintReaderEventArgs (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, string p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Credenceid.Biometrics.BiometricsResultCode p0;
		public global::Com.Credenceid.Biometrics.BiometricsResultCode P0 {
			get { return p0; }
		}

		string p1;
		public string P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/credenceid/biometrics/Biometrics_FingerprintReaderStatusListenerImplementor")]
	internal sealed partial class IBiometricsFingerprintReaderStatusListenerImplementor : global::Java.Lang.Object, IBiometricsFingerprintReaderStatusListener {

		object sender;

		public IBiometricsFingerprintReaderStatusListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/credenceid/biometrics/Biometrics_FingerprintReaderStatusListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<CloseFingerprintReaderEventArgs> OnCloseFingerprintReaderHandler;
#pragma warning restore 0649

		public void OnCloseFingerprintReader (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode p1)
		{
			var __h = OnCloseFingerprintReaderHandler;
			if (__h != null)
				__h (sender, new CloseFingerprintReaderEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<OpenFingerprintReaderEventArgs> OnOpenFingerprintReaderHandler;
#pragma warning restore 0649

		public void OnOpenFingerprintReader (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, string p1)
		{
			var __h = OnOpenFingerprintReaderHandler;
			if (__h != null)
				__h (sender, new OpenFingerprintReaderEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IBiometricsFingerprintReaderStatusListenerImplementor value)
		{
			return value.OnCloseFingerprintReaderHandler == null && value.OnOpenFingerprintReaderHandler == null;
		}
	}


	// Metadata.xml XPath class reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='Biometrics.FingerprintScannerType']"
	[global::Android.Runtime.Register ("com/credenceid/biometrics/Biometrics$FingerprintScannerType", DoNotGenerateAcw=true)]
	public sealed partial class BiometricsFingerprintScannerType : global::Java.Lang.Enum {


		static IntPtr FAP10_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='Biometrics.FingerprintScannerType']/field[@name='FAP10']"
		[Register ("FAP10")]
		public static global::Com.Credenceid.Biometrics.BiometricsFingerprintScannerType Fap10 {
			get {
				if (FAP10_jfieldId == IntPtr.Zero)
					FAP10_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FAP10", "Lcom/credenceid/biometrics/Biometrics$FingerprintScannerType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FAP10_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsFingerprintScannerType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr FAP20_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='Biometrics.FingerprintScannerType']/field[@name='FAP20']"
		[Register ("FAP20")]
		public static global::Com.Credenceid.Biometrics.BiometricsFingerprintScannerType Fap20 {
			get {
				if (FAP20_jfieldId == IntPtr.Zero)
					FAP20_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FAP20", "Lcom/credenceid/biometrics/Biometrics$FingerprintScannerType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FAP20_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsFingerprintScannerType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr FAP30_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='Biometrics.FingerprintScannerType']/field[@name='FAP30']"
		[Register ("FAP30")]
		public static global::Com.Credenceid.Biometrics.BiometricsFingerprintScannerType Fap30 {
			get {
				if (FAP30_jfieldId == IntPtr.Zero)
					FAP30_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FAP30", "Lcom/credenceid/biometrics/Biometrics$FingerprintScannerType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FAP30_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsFingerprintScannerType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr FAP45_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='Biometrics.FingerprintScannerType']/field[@name='FAP45']"
		[Register ("FAP45")]
		public static global::Com.Credenceid.Biometrics.BiometricsFingerprintScannerType Fap45 {
			get {
				if (FAP45_jfieldId == IntPtr.Zero)
					FAP45_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FAP45", "Lcom/credenceid/biometrics/Biometrics$FingerprintScannerType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FAP45_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsFingerprintScannerType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr FAP50_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='Biometrics.FingerprintScannerType']/field[@name='FAP50']"
		[Register ("FAP50")]
		public static global::Com.Credenceid.Biometrics.BiometricsFingerprintScannerType Fap50 {
			get {
				if (FAP50_jfieldId == IntPtr.Zero)
					FAP50_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FAP50", "Lcom/credenceid/biometrics/Biometrics$FingerprintScannerType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FAP50_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsFingerprintScannerType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NONE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='Biometrics.FingerprintScannerType']/field[@name='NONE']"
		[Register ("NONE")]
		public static global::Com.Credenceid.Biometrics.BiometricsFingerprintScannerType None {
			get {
				if (NONE_jfieldId == IntPtr.Zero)
					NONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NONE", "Lcom/credenceid/biometrics/Biometrics$FingerprintScannerType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NONE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsFingerprintScannerType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/credenceid/biometrics/Biometrics$FingerprintScannerType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BiometricsFingerprintScannerType); }
		}

		internal BiometricsFingerprintScannerType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='Biometrics.FingerprintScannerType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/credenceid/biometrics/Biometrics$FingerprintScannerType;", "")]
		public static unsafe global::Com.Credenceid.Biometrics.BiometricsFingerprintScannerType ValueOf (string name)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/credenceid/biometrics/Biometrics$FingerprintScannerType;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::Com.Credenceid.Biometrics.BiometricsFingerprintScannerType __ret = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsFingerprintScannerType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='Biometrics.FingerprintScannerType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/credenceid/biometrics/Biometrics$FingerprintScannerType;", "")]
		public static unsafe global::Com.Credenceid.Biometrics.BiometricsFingerprintScannerType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/credenceid/biometrics/Biometrics$FingerprintScannerType;");
			try {
				return (global::Com.Credenceid.Biometrics.BiometricsFingerprintScannerType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Credenceid.Biometrics.BiometricsFingerprintScannerType));
			} finally {
			}
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='Biometrics.FMDFormat']"
	[global::Android.Runtime.Register ("com/credenceid/biometrics/Biometrics$FMDFormat", DoNotGenerateAcw=true)]
	public sealed partial class BiometricsFMDFormat : global::Java.Lang.Enum {


		static IntPtr ANSI_378_2004_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='Biometrics.FMDFormat']/field[@name='ANSI_378_2004']"
		[Register ("ANSI_378_2004")]
		public static global::Com.Credenceid.Biometrics.BiometricsFMDFormat Ansi3782004 {
			get {
				if (ANSI_378_2004_jfieldId == IntPtr.Zero)
					ANSI_378_2004_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ANSI_378_2004", "Lcom/credenceid/biometrics/Biometrics$FMDFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ANSI_378_2004_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsFMDFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ISO_19794_2_2005_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='Biometrics.FMDFormat']/field[@name='ISO_19794_2_2005']"
		[Register ("ISO_19794_2_2005")]
		public static global::Com.Credenceid.Biometrics.BiometricsFMDFormat Iso1979422005 {
			get {
				if (ISO_19794_2_2005_jfieldId == IntPtr.Zero)
					ISO_19794_2_2005_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ISO_19794_2_2005", "Lcom/credenceid/biometrics/Biometrics$FMDFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ISO_19794_2_2005_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsFMDFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/credenceid/biometrics/Biometrics$FMDFormat", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BiometricsFMDFormat); }
		}

		internal BiometricsFMDFormat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='Biometrics.FMDFormat']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/credenceid/biometrics/Biometrics$FMDFormat;", "")]
		public static unsafe global::Com.Credenceid.Biometrics.BiometricsFMDFormat ValueOf (string name)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/credenceid/biometrics/Biometrics$FMDFormat;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::Com.Credenceid.Biometrics.BiometricsFMDFormat __ret = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsFMDFormat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='Biometrics.FMDFormat']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/credenceid/biometrics/Biometrics$FMDFormat;", "")]
		public static unsafe global::Com.Credenceid.Biometrics.BiometricsFMDFormat[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/credenceid/biometrics/Biometrics$FMDFormat;");
			try {
				return (global::Com.Credenceid.Biometrics.BiometricsFMDFormat[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Credenceid.Biometrics.BiometricsFMDFormat));
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.generateTerminalIsCertificateListener']"
	[Register ("com/credenceid/biometrics/Biometrics$generateTerminalIsCertificateListener", "", "Com.Credenceid.Biometrics.IBiometricsGenerateTerminalIsCertificateListenerInvoker")]
	public partial interface IBiometricsGenerateTerminalIsCertificateListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.generateTerminalIsCertificateListener']/method[@name='onGenerateCertificate' and count(parameter)=2 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ResultCode'] and parameter[2][@type='java.lang.String']]"
		[Register ("onGenerateCertificate", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Ljava/lang/String;)V", "GetOnGenerateCertificate_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_Handler:Com.Credenceid.Biometrics.IBiometricsGenerateTerminalIsCertificateListenerInvoker, CredenceBindings")]
		void OnGenerateCertificate (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, string p1);

	}

	[global::Android.Runtime.Register ("com/credenceid/biometrics/Biometrics$generateTerminalIsCertificateListener", DoNotGenerateAcw=true)]
	internal partial class IBiometricsGenerateTerminalIsCertificateListenerInvoker : global::Java.Lang.Object, IBiometricsGenerateTerminalIsCertificateListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/credenceid/biometrics/Biometrics$generateTerminalIsCertificateListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBiometricsGenerateTerminalIsCertificateListenerInvoker); }
		}

		IntPtr class_ref;

		public static IBiometricsGenerateTerminalIsCertificateListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBiometricsGenerateTerminalIsCertificateListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.credenceid.biometrics.Biometrics.generateTerminalIsCertificateListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBiometricsGenerateTerminalIsCertificateListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onGenerateCertificate_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnGenerateCertificate_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_Handler ()
		{
			if (cb_onGenerateCertificate_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_ == null)
				cb_onGenerateCertificate_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnGenerateCertificate_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_);
			return cb_onGenerateCertificate_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_;
		}

		static void n_OnGenerateCertificate_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsGenerateTerminalIsCertificateListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsResultCode> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnGenerateCertificate (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onGenerateCertificate_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_;
		public unsafe void OnGenerateCertificate (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, string p1)
		{
			if (id_onGenerateCertificate_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_ == IntPtr.Zero)
				id_onGenerateCertificate_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onGenerateCertificate", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onGenerateCertificate_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

	// event args for com.credenceid.biometrics.Biometrics.generateTerminalIsCertificateListener.onGenerateCertificate
	public partial class BiometricsGenerateTerminalIsCertificateEventArgs : global::System.EventArgs {

		public BiometricsGenerateTerminalIsCertificateEventArgs (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, string p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Credenceid.Biometrics.BiometricsResultCode p0;
		public global::Com.Credenceid.Biometrics.BiometricsResultCode P0 {
			get { return p0; }
		}

		string p1;
		public string P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/credenceid/biometrics/Biometrics_generateTerminalIsCertificateListenerImplementor")]
	internal sealed partial class IBiometricsGenerateTerminalIsCertificateListenerImplementor : global::Java.Lang.Object, IBiometricsGenerateTerminalIsCertificateListener {

		object sender;

		public IBiometricsGenerateTerminalIsCertificateListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/credenceid/biometrics/Biometrics_generateTerminalIsCertificateListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<BiometricsGenerateTerminalIsCertificateEventArgs> Handler;
#pragma warning restore 0649

		public void OnGenerateCertificate (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, string p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new BiometricsGenerateTerminalIsCertificateEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IBiometricsGenerateTerminalIsCertificateListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.GIcaoReadListener']"
	[Register ("com/credenceid/biometrics/Biometrics$GIcaoReadListener", "", "Com.Credenceid.Biometrics.IBiometricsGIcaoReadListenerInvoker")]
	public partial interface IBiometricsGIcaoReadListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.GIcaoReadListener']/method[@name='onGIDRead' and count(parameter)=4 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ResultCode'] and parameter[2][@type='com.credenceid.icao.ICAOReadIntermediateCode'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.credenceid.icao.ICAODocumentData']]"
		[Register ("onGIDRead", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Lcom/credenceid/icao/ICAOReadIntermediateCode;Ljava/lang/String;Lcom/credenceid/icao/ICAODocumentData;)V", "GetOnGIDRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_icao_ICAOReadIntermediateCode_Ljava_lang_String_Lcom_credenceid_icao_ICAODocumentData_Handler:Com.Credenceid.Biometrics.IBiometricsGIcaoReadListenerInvoker, CredenceBindings")]
		void OnGIDRead (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Com.Credenceid.Icao.ICAOReadIntermediateCode p1, string p2, global::Com.Credenceid.Icao.ICAODocumentData p3);

	}

	[global::Android.Runtime.Register ("com/credenceid/biometrics/Biometrics$GIcaoReadListener", DoNotGenerateAcw=true)]
	internal partial class IBiometricsGIcaoReadListenerInvoker : global::Java.Lang.Object, IBiometricsGIcaoReadListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/credenceid/biometrics/Biometrics$GIcaoReadListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBiometricsGIcaoReadListenerInvoker); }
		}

		IntPtr class_ref;

		public static IBiometricsGIcaoReadListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBiometricsGIcaoReadListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.credenceid.biometrics.Biometrics.GIcaoReadListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBiometricsGIcaoReadListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onGIDRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_icao_ICAOReadIntermediateCode_Ljava_lang_String_Lcom_credenceid_icao_ICAODocumentData_;
#pragma warning disable 0169
		static Delegate GetOnGIDRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_icao_ICAOReadIntermediateCode_Ljava_lang_String_Lcom_credenceid_icao_ICAODocumentData_Handler ()
		{
			if (cb_onGIDRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_icao_ICAOReadIntermediateCode_Ljava_lang_String_Lcom_credenceid_icao_ICAODocumentData_ == null)
				cb_onGIDRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_icao_ICAOReadIntermediateCode_Ljava_lang_String_Lcom_credenceid_icao_ICAODocumentData_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_OnGIDRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_icao_ICAOReadIntermediateCode_Ljava_lang_String_Lcom_credenceid_icao_ICAODocumentData_);
			return cb_onGIDRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_icao_ICAOReadIntermediateCode_Ljava_lang_String_Lcom_credenceid_icao_ICAODocumentData_;
		}

		static void n_OnGIDRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_icao_ICAOReadIntermediateCode_Ljava_lang_String_Lcom_credenceid_icao_ICAODocumentData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsGIcaoReadListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsResultCode> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAOReadIntermediateCode> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.OnGIDRead (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_onGIDRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_icao_ICAOReadIntermediateCode_Ljava_lang_String_Lcom_credenceid_icao_ICAODocumentData_;
		public unsafe void OnGIDRead (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Com.Credenceid.Icao.ICAOReadIntermediateCode p1, string p2, global::Com.Credenceid.Icao.ICAODocumentData p3)
		{
			if (id_onGIDRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_icao_ICAOReadIntermediateCode_Ljava_lang_String_Lcom_credenceid_icao_ICAODocumentData_ == IntPtr.Zero)
				id_onGIDRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_icao_ICAOReadIntermediateCode_Ljava_lang_String_Lcom_credenceid_icao_ICAODocumentData_ = JNIEnv.GetMethodID (class_ref, "onGIDRead", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Lcom/credenceid/icao/ICAOReadIntermediateCode;Ljava/lang/String;Lcom/credenceid/icao/ICAODocumentData;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onGIDRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_icao_ICAOReadIntermediateCode_Ljava_lang_String_Lcom_credenceid_icao_ICAODocumentData_, __args);
			JNIEnv.DeleteLocalRef (native_p2);
		}

	}

	// event args for com.credenceid.biometrics.Biometrics.GIcaoReadListener.onGIDRead
	public partial class BiometricsGIcaoReadEventArgs : global::System.EventArgs {

		public BiometricsGIcaoReadEventArgs (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Com.Credenceid.Icao.ICAOReadIntermediateCode p1, string p2, global::Com.Credenceid.Icao.ICAODocumentData p3)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
		}

		global::Com.Credenceid.Biometrics.BiometricsResultCode p0;
		public global::Com.Credenceid.Biometrics.BiometricsResultCode P0 {
			get { return p0; }
		}

		global::Com.Credenceid.Icao.ICAOReadIntermediateCode p1;
		public global::Com.Credenceid.Icao.ICAOReadIntermediateCode P1 {
			get { return p1; }
		}

		string p2;
		public string P2 {
			get { return p2; }
		}

		global::Com.Credenceid.Icao.ICAODocumentData p3;
		public global::Com.Credenceid.Icao.ICAODocumentData P3 {
			get { return p3; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/credenceid/biometrics/Biometrics_GIcaoReadListenerImplementor")]
	internal sealed partial class IBiometricsGIcaoReadListenerImplementor : global::Java.Lang.Object, IBiometricsGIcaoReadListener {

		object sender;

		public IBiometricsGIcaoReadListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/credenceid/biometrics/Biometrics_GIcaoReadListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<BiometricsGIcaoReadEventArgs> Handler;
#pragma warning restore 0649

		public void OnGIDRead (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Com.Credenceid.Icao.ICAOReadIntermediateCode p1, string p2, global::Com.Credenceid.Icao.ICAODocumentData p3)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new BiometricsGIcaoReadEventArgs (p0, p1, p2, p3));
		}

		internal static bool __IsEmpty (IBiometricsGIcaoReadListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.GNIDReadListener']"
	[Register ("com/credenceid/biometrics/Biometrics$GNIDReadListener", "", "Com.Credenceid.Biometrics.IBiometricsGNIDReadListenerInvoker")]
	public partial interface IBiometricsGNIDReadListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.GNIDReadListener']/method[@name='onGIDRead' and count(parameter)=4 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ResultCode'] and parameter[2][@type='com.credenceid.icao.ICAOReadIntermediateCode'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.credenceid.icao.GIdData']]"
		[Register ("onGIDRead", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Lcom/credenceid/icao/ICAOReadIntermediateCode;Ljava/lang/String;Lcom/credenceid/icao/GIdData;)V", "GetOnGIDRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_icao_ICAOReadIntermediateCode_Ljava_lang_String_Lcom_credenceid_icao_GIdData_Handler:Com.Credenceid.Biometrics.IBiometricsGNIDReadListenerInvoker, CredenceBindings")]
		void OnGIDRead (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Com.Credenceid.Icao.ICAOReadIntermediateCode p1, string p2, global::Com.Credenceid.Icao.GIdData p3);

	}

	[global::Android.Runtime.Register ("com/credenceid/biometrics/Biometrics$GNIDReadListener", DoNotGenerateAcw=true)]
	internal partial class IBiometricsGNIDReadListenerInvoker : global::Java.Lang.Object, IBiometricsGNIDReadListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/credenceid/biometrics/Biometrics$GNIDReadListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBiometricsGNIDReadListenerInvoker); }
		}

		IntPtr class_ref;

		public static IBiometricsGNIDReadListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBiometricsGNIDReadListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.credenceid.biometrics.Biometrics.GNIDReadListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBiometricsGNIDReadListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onGIDRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_icao_ICAOReadIntermediateCode_Ljava_lang_String_Lcom_credenceid_icao_GIdData_;
#pragma warning disable 0169
		static Delegate GetOnGIDRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_icao_ICAOReadIntermediateCode_Ljava_lang_String_Lcom_credenceid_icao_GIdData_Handler ()
		{
			if (cb_onGIDRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_icao_ICAOReadIntermediateCode_Ljava_lang_String_Lcom_credenceid_icao_GIdData_ == null)
				cb_onGIDRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_icao_ICAOReadIntermediateCode_Ljava_lang_String_Lcom_credenceid_icao_GIdData_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_OnGIDRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_icao_ICAOReadIntermediateCode_Ljava_lang_String_Lcom_credenceid_icao_GIdData_);
			return cb_onGIDRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_icao_ICAOReadIntermediateCode_Ljava_lang_String_Lcom_credenceid_icao_GIdData_;
		}

		static void n_OnGIDRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_icao_ICAOReadIntermediateCode_Ljava_lang_String_Lcom_credenceid_icao_GIdData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsGNIDReadListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsResultCode> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAOReadIntermediateCode> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.GIdData> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.OnGIDRead (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_onGIDRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_icao_ICAOReadIntermediateCode_Ljava_lang_String_Lcom_credenceid_icao_GIdData_;
		public unsafe void OnGIDRead (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Com.Credenceid.Icao.ICAOReadIntermediateCode p1, string p2, global::Com.Credenceid.Icao.GIdData p3)
		{
			if (id_onGIDRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_icao_ICAOReadIntermediateCode_Ljava_lang_String_Lcom_credenceid_icao_GIdData_ == IntPtr.Zero)
				id_onGIDRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_icao_ICAOReadIntermediateCode_Ljava_lang_String_Lcom_credenceid_icao_GIdData_ = JNIEnv.GetMethodID (class_ref, "onGIDRead", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Lcom/credenceid/icao/ICAOReadIntermediateCode;Ljava/lang/String;Lcom/credenceid/icao/GIdData;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onGIDRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_icao_ICAOReadIntermediateCode_Ljava_lang_String_Lcom_credenceid_icao_GIdData_, __args);
			JNIEnv.DeleteLocalRef (native_p2);
		}

	}

	// event args for com.credenceid.biometrics.Biometrics.GNIDReadListener.onGIDRead
	public partial class BiometricsGNIDReadEventArgs : global::System.EventArgs {

		public BiometricsGNIDReadEventArgs (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Com.Credenceid.Icao.ICAOReadIntermediateCode p1, string p2, global::Com.Credenceid.Icao.GIdData p3)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
		}

		global::Com.Credenceid.Biometrics.BiometricsResultCode p0;
		public global::Com.Credenceid.Biometrics.BiometricsResultCode P0 {
			get { return p0; }
		}

		global::Com.Credenceid.Icao.ICAOReadIntermediateCode p1;
		public global::Com.Credenceid.Icao.ICAOReadIntermediateCode P1 {
			get { return p1; }
		}

		string p2;
		public string P2 {
			get { return p2; }
		}

		global::Com.Credenceid.Icao.GIdData p3;
		public global::Com.Credenceid.Icao.GIdData P3 {
			get { return p3; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/credenceid/biometrics/Biometrics_GNIDReadListenerImplementor")]
	internal sealed partial class IBiometricsGNIDReadListenerImplementor : global::Java.Lang.Object, IBiometricsGNIDReadListener {

		object sender;

		public IBiometricsGNIDReadListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/credenceid/biometrics/Biometrics_GNIDReadListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<BiometricsGNIDReadEventArgs> Handler;
#pragma warning restore 0649

		public void OnGIDRead (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Com.Credenceid.Icao.ICAOReadIntermediateCode p1, string p2, global::Com.Credenceid.Icao.GIdData p3)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new BiometricsGNIDReadEventArgs (p0, p1, p2, p3));
		}

		internal static bool __IsEmpty (IBiometricsGNIDReadListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.ICAODocumentReadListener']"
	[Register ("com/credenceid/biometrics/Biometrics$ICAODocumentReadListener", "", "Com.Credenceid.Biometrics.IBiometricsCAODocumentReadListenerInvoker")]
	public partial interface IBiometricsCAODocumentReadListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.ICAODocumentReadListener']/method[@name='onICAODocumentRead' and count(parameter)=4 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ResultCode'] and parameter[2][@type='com.credenceid.icao.ICAOReadIntermediateCode'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.credenceid.icao.ICAODocumentData']]"
		[Register ("onICAODocumentRead", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Lcom/credenceid/icao/ICAOReadIntermediateCode;Ljava/lang/String;Lcom/credenceid/icao/ICAODocumentData;)V", "GetOnICAODocumentRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_icao_ICAOReadIntermediateCode_Ljava_lang_String_Lcom_credenceid_icao_ICAODocumentData_Handler:Com.Credenceid.Biometrics.IBiometricsCAODocumentReadListenerInvoker, CredenceBindings")]
		void OnICAODocumentRead (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Com.Credenceid.Icao.ICAOReadIntermediateCode p1, string p2, global::Com.Credenceid.Icao.ICAODocumentData p3);

	}

	[global::Android.Runtime.Register ("com/credenceid/biometrics/Biometrics$ICAODocumentReadListener", DoNotGenerateAcw=true)]
	internal partial class IBiometricsCAODocumentReadListenerInvoker : global::Java.Lang.Object, IBiometricsCAODocumentReadListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/credenceid/biometrics/Biometrics$ICAODocumentReadListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBiometricsCAODocumentReadListenerInvoker); }
		}

		IntPtr class_ref;

		public static IBiometricsCAODocumentReadListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBiometricsCAODocumentReadListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.credenceid.biometrics.Biometrics.ICAODocumentReadListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBiometricsCAODocumentReadListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onICAODocumentRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_icao_ICAOReadIntermediateCode_Ljava_lang_String_Lcom_credenceid_icao_ICAODocumentData_;
#pragma warning disable 0169
		static Delegate GetOnICAODocumentRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_icao_ICAOReadIntermediateCode_Ljava_lang_String_Lcom_credenceid_icao_ICAODocumentData_Handler ()
		{
			if (cb_onICAODocumentRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_icao_ICAOReadIntermediateCode_Ljava_lang_String_Lcom_credenceid_icao_ICAODocumentData_ == null)
				cb_onICAODocumentRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_icao_ICAOReadIntermediateCode_Ljava_lang_String_Lcom_credenceid_icao_ICAODocumentData_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_OnICAODocumentRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_icao_ICAOReadIntermediateCode_Ljava_lang_String_Lcom_credenceid_icao_ICAODocumentData_);
			return cb_onICAODocumentRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_icao_ICAOReadIntermediateCode_Ljava_lang_String_Lcom_credenceid_icao_ICAODocumentData_;
		}

		static void n_OnICAODocumentRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_icao_ICAOReadIntermediateCode_Ljava_lang_String_Lcom_credenceid_icao_ICAODocumentData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsCAODocumentReadListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsResultCode> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAOReadIntermediateCode> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.ICAODocumentData> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.OnICAODocumentRead (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_onICAODocumentRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_icao_ICAOReadIntermediateCode_Ljava_lang_String_Lcom_credenceid_icao_ICAODocumentData_;
		public unsafe void OnICAODocumentRead (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Com.Credenceid.Icao.ICAOReadIntermediateCode p1, string p2, global::Com.Credenceid.Icao.ICAODocumentData p3)
		{
			if (id_onICAODocumentRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_icao_ICAOReadIntermediateCode_Ljava_lang_String_Lcom_credenceid_icao_ICAODocumentData_ == IntPtr.Zero)
				id_onICAODocumentRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_icao_ICAOReadIntermediateCode_Ljava_lang_String_Lcom_credenceid_icao_ICAODocumentData_ = JNIEnv.GetMethodID (class_ref, "onICAODocumentRead", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Lcom/credenceid/icao/ICAOReadIntermediateCode;Ljava/lang/String;Lcom/credenceid/icao/ICAODocumentData;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onICAODocumentRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_icao_ICAOReadIntermediateCode_Ljava_lang_String_Lcom_credenceid_icao_ICAODocumentData_, __args);
			JNIEnv.DeleteLocalRef (native_p2);
		}

	}

	// event args for com.credenceid.biometrics.Biometrics.ICAODocumentReadListener.onICAODocumentRead
	public partial class BiometricsCAODocumentReadEventArgs : global::System.EventArgs {

		public BiometricsCAODocumentReadEventArgs (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Com.Credenceid.Icao.ICAOReadIntermediateCode p1, string p2, global::Com.Credenceid.Icao.ICAODocumentData p3)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
		}

		global::Com.Credenceid.Biometrics.BiometricsResultCode p0;
		public global::Com.Credenceid.Biometrics.BiometricsResultCode P0 {
			get { return p0; }
		}

		global::Com.Credenceid.Icao.ICAOReadIntermediateCode p1;
		public global::Com.Credenceid.Icao.ICAOReadIntermediateCode P1 {
			get { return p1; }
		}

		string p2;
		public string P2 {
			get { return p2; }
		}

		global::Com.Credenceid.Icao.ICAODocumentData p3;
		public global::Com.Credenceid.Icao.ICAODocumentData P3 {
			get { return p3; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/credenceid/biometrics/Biometrics_ICAODocumentReadListenerImplementor")]
	internal sealed partial class IBiometricsCAODocumentReadListenerImplementor : global::Java.Lang.Object, IBiometricsCAODocumentReadListener {

		object sender;

		public IBiometricsCAODocumentReadListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/credenceid/biometrics/Biometrics_ICAODocumentReadListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<BiometricsCAODocumentReadEventArgs> Handler;
#pragma warning restore 0649

		public void OnICAODocumentRead (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Com.Credenceid.Icao.ICAOReadIntermediateCode p1, string p2, global::Com.Credenceid.Icao.ICAODocumentData p3)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new BiometricsCAODocumentReadEventArgs (p0, p1, p2, p3));
		}

		internal static bool __IsEmpty (IBiometricsCAODocumentReadListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.MRZStatusListener']"
	[Register ("com/credenceid/biometrics/Biometrics$MRZStatusListener", "", "Com.Credenceid.Biometrics.IBiometricsMRZStatusListenerInvoker")]
	public partial interface IBiometricsMRZStatusListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.MRZStatusListener']/method[@name='onMRZClose' and count(parameter)=2 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ResultCode'] and parameter[2][@type='com.credenceid.biometrics.Biometrics.CloseReasonCode']]"
		[Register ("onMRZClose", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Lcom/credenceid/biometrics/Biometrics$CloseReasonCode;)V", "GetOnMRZClose_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_Handler:Com.Credenceid.Biometrics.IBiometricsMRZStatusListenerInvoker, CredenceBindings")]
		void OnMRZClose (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.MRZStatusListener']/method[@name='onMRZOpen' and count(parameter)=1 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ResultCode']]"
		[Register ("onMRZOpen", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;)V", "GetOnMRZOpen_Lcom_credenceid_biometrics_Biometrics_ResultCode_Handler:Com.Credenceid.Biometrics.IBiometricsMRZStatusListenerInvoker, CredenceBindings")]
		void OnMRZOpen (global::Com.Credenceid.Biometrics.BiometricsResultCode p0);

	}

	[global::Android.Runtime.Register ("com/credenceid/biometrics/Biometrics$MRZStatusListener", DoNotGenerateAcw=true)]
	internal partial class IBiometricsMRZStatusListenerInvoker : global::Java.Lang.Object, IBiometricsMRZStatusListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/credenceid/biometrics/Biometrics$MRZStatusListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBiometricsMRZStatusListenerInvoker); }
		}

		IntPtr class_ref;

		public static IBiometricsMRZStatusListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBiometricsMRZStatusListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.credenceid.biometrics.Biometrics.MRZStatusListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBiometricsMRZStatusListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onMRZClose_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_;
#pragma warning disable 0169
		static Delegate GetOnMRZClose_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_Handler ()
		{
			if (cb_onMRZClose_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_ == null)
				cb_onMRZClose_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnMRZClose_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_);
			return cb_onMRZClose_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_;
		}

		static void n_OnMRZClose_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsMRZStatusListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsResultCode> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnMRZClose (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onMRZClose_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_;
		public unsafe void OnMRZClose (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode p1)
		{
			if (id_onMRZClose_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_ == IntPtr.Zero)
				id_onMRZClose_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_ = JNIEnv.GetMethodID (class_ref, "onMRZClose", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Lcom/credenceid/biometrics/Biometrics$CloseReasonCode;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMRZClose_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_, __args);
		}

		static Delegate cb_onMRZOpen_Lcom_credenceid_biometrics_Biometrics_ResultCode_;
#pragma warning disable 0169
		static Delegate GetOnMRZOpen_Lcom_credenceid_biometrics_Biometrics_ResultCode_Handler ()
		{
			if (cb_onMRZOpen_Lcom_credenceid_biometrics_Biometrics_ResultCode_ == null)
				cb_onMRZOpen_Lcom_credenceid_biometrics_Biometrics_ResultCode_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnMRZOpen_Lcom_credenceid_biometrics_Biometrics_ResultCode_);
			return cb_onMRZOpen_Lcom_credenceid_biometrics_Biometrics_ResultCode_;
		}

		static void n_OnMRZOpen_Lcom_credenceid_biometrics_Biometrics_ResultCode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsMRZStatusListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsResultCode> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnMRZOpen (p0);
		}
#pragma warning restore 0169

		IntPtr id_onMRZOpen_Lcom_credenceid_biometrics_Biometrics_ResultCode_;
		public unsafe void OnMRZOpen (global::Com.Credenceid.Biometrics.BiometricsResultCode p0)
		{
			if (id_onMRZOpen_Lcom_credenceid_biometrics_Biometrics_ResultCode_ == IntPtr.Zero)
				id_onMRZOpen_Lcom_credenceid_biometrics_Biometrics_ResultCode_ = JNIEnv.GetMethodID (class_ref, "onMRZOpen", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMRZOpen_Lcom_credenceid_biometrics_Biometrics_ResultCode_, __args);
		}

	}

	// event args for com.credenceid.biometrics.Biometrics.MRZStatusListener.onMRZClose
	public partial class MRZCloseEventArgs : global::System.EventArgs {

		public MRZCloseEventArgs (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Credenceid.Biometrics.BiometricsResultCode p0;
		public global::Com.Credenceid.Biometrics.BiometricsResultCode P0 {
			get { return p0; }
		}

		global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode p1;
		public global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode P1 {
			get { return p1; }
		}
	}

	// event args for com.credenceid.biometrics.Biometrics.MRZStatusListener.onMRZOpen
	public partial class MRZOpenEventArgs : global::System.EventArgs {

		public MRZOpenEventArgs (global::Com.Credenceid.Biometrics.BiometricsResultCode p0)
		{
			this.p0 = p0;
		}

		global::Com.Credenceid.Biometrics.BiometricsResultCode p0;
		public global::Com.Credenceid.Biometrics.BiometricsResultCode P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/credenceid/biometrics/Biometrics_MRZStatusListenerImplementor")]
	internal sealed partial class IBiometricsMRZStatusListenerImplementor : global::Java.Lang.Object, IBiometricsMRZStatusListener {

		object sender;

		public IBiometricsMRZStatusListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/credenceid/biometrics/Biometrics_MRZStatusListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<MRZCloseEventArgs> OnMRZCloseHandler;
#pragma warning restore 0649

		public void OnMRZClose (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode p1)
		{
			var __h = OnMRZCloseHandler;
			if (__h != null)
				__h (sender, new MRZCloseEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<MRZOpenEventArgs> OnMRZOpenHandler;
#pragma warning restore 0649

		public void OnMRZOpen (global::Com.Credenceid.Biometrics.BiometricsResultCode p0)
		{
			var __h = OnMRZOpenHandler;
			if (__h != null)
				__h (sender, new MRZOpenEventArgs (p0));
		}

		internal static bool __IsEmpty (IBiometricsMRZStatusListenerImplementor value)
		{
			return value.OnMRZCloseHandler == null && value.OnMRZOpenHandler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.OnCardCommandListener']"
	[Register ("com/credenceid/biometrics/Biometrics$OnCardCommandListener", "", "Com.Credenceid.Biometrics.IBiometricsOnCardCommandListenerInvoker")]
	public partial interface IBiometricsOnCardCommandListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.OnCardCommandListener']/method[@name='onCardCommandComplete' and count(parameter)=4 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ResultCode'] and parameter[2][@type='byte'] and parameter[3][@type='byte'] and parameter[4][@type='byte[]']]"
		[Register ("onCardCommandComplete", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;BB[B)V", "GetOnCardCommandComplete_Lcom_credenceid_biometrics_Biometrics_ResultCode_BBarrayBHandler:Com.Credenceid.Biometrics.IBiometricsOnCardCommandListenerInvoker, CredenceBindings")]
		void OnCardCommandComplete (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, sbyte p1, sbyte p2, byte[] p3);

	}

	[global::Android.Runtime.Register ("com/credenceid/biometrics/Biometrics$OnCardCommandListener", DoNotGenerateAcw=true)]
	internal partial class IBiometricsOnCardCommandListenerInvoker : global::Java.Lang.Object, IBiometricsOnCardCommandListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/credenceid/biometrics/Biometrics$OnCardCommandListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBiometricsOnCardCommandListenerInvoker); }
		}

		IntPtr class_ref;

		public static IBiometricsOnCardCommandListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBiometricsOnCardCommandListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.credenceid.biometrics.Biometrics.OnCardCommandListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBiometricsOnCardCommandListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onCardCommandComplete_Lcom_credenceid_biometrics_Biometrics_ResultCode_BBarrayB;
#pragma warning disable 0169
		static Delegate GetOnCardCommandComplete_Lcom_credenceid_biometrics_Biometrics_ResultCode_BBarrayBHandler ()
		{
			if (cb_onCardCommandComplete_Lcom_credenceid_biometrics_Biometrics_ResultCode_BBarrayB == null)
				cb_onCardCommandComplete_Lcom_credenceid_biometrics_Biometrics_ResultCode_BBarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLBBL_V) n_OnCardCommandComplete_Lcom_credenceid_biometrics_Biometrics_ResultCode_BBarrayB);
			return cb_onCardCommandComplete_Lcom_credenceid_biometrics_Biometrics_ResultCode_BBarrayB;
		}

		static void n_OnCardCommandComplete_Lcom_credenceid_biometrics_Biometrics_ResultCode_BBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, sbyte p1, sbyte p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnCardCommandListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsResultCode> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p3 = (byte[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnCardCommandComplete (p0, p1, p2, p3);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
		}
#pragma warning restore 0169

		IntPtr id_onCardCommandComplete_Lcom_credenceid_biometrics_Biometrics_ResultCode_BBarrayB;
		public unsafe void OnCardCommandComplete (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, sbyte p1, sbyte p2, byte[] p3)
		{
			if (id_onCardCommandComplete_Lcom_credenceid_biometrics_Biometrics_ResultCode_BBarrayB == IntPtr.Zero)
				id_onCardCommandComplete_Lcom_credenceid_biometrics_Biometrics_ResultCode_BBarrayB = JNIEnv.GetMethodID (class_ref, "onCardCommandComplete", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;BB[B)V");
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (native_p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCardCommandComplete_Lcom_credenceid_biometrics_Biometrics_ResultCode_BBarrayB, __args);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

	}

	// event args for com.credenceid.biometrics.Biometrics.OnCardCommandListener.onCardCommandComplete
	public partial class BiometricsOnCardCommandEventArgs : global::System.EventArgs {

		public BiometricsOnCardCommandEventArgs (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, sbyte p1, sbyte p2, byte[] p3)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
		}

		global::Com.Credenceid.Biometrics.BiometricsResultCode p0;
		public global::Com.Credenceid.Biometrics.BiometricsResultCode P0 {
			get { return p0; }
		}

		sbyte p1;
		public sbyte P1 {
			get { return p1; }
		}

		sbyte p2;
		public sbyte P2 {
			get { return p2; }
		}

		byte[] p3;
		public byte[] P3 {
			get { return p3; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/credenceid/biometrics/Biometrics_OnCardCommandListenerImplementor")]
	internal sealed partial class IBiometricsOnCardCommandListenerImplementor : global::Java.Lang.Object, IBiometricsOnCardCommandListener {

		object sender;

		public IBiometricsOnCardCommandListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/credenceid/biometrics/Biometrics_OnCardCommandListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<BiometricsOnCardCommandEventArgs> Handler;
#pragma warning restore 0649

		public void OnCardCommandComplete (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, sbyte p1, sbyte p2, byte[] p3)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new BiometricsOnCardCommandEventArgs (p0, p1, p2, p3));
		}

		internal static bool __IsEmpty (IBiometricsOnCardCommandListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.OnCardCommandSyncResultListener']"
	[Register ("com/credenceid/biometrics/Biometrics$OnCardCommandSyncResultListener", "", "Com.Credenceid.Biometrics.IBiometricsOnCardCommandSyncResultListenerInvoker")]
	public partial interface IBiometricsOnCardCommandSyncResultListener : IJavaObject {

	}

	[global::Android.Runtime.Register ("com/credenceid/biometrics/Biometrics$OnCardCommandSyncResultListener", DoNotGenerateAcw=true)]
	internal partial class IBiometricsOnCardCommandSyncResultListenerInvoker : global::Java.Lang.Object, IBiometricsOnCardCommandSyncResultListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/credenceid/biometrics/Biometrics$OnCardCommandSyncResultListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBiometricsOnCardCommandSyncResultListenerInvoker); }
		}

		IntPtr class_ref;

		public static IBiometricsOnCardCommandSyncResultListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBiometricsOnCardCommandSyncResultListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.credenceid.biometrics.Biometrics.OnCardCommandSyncResultListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBiometricsOnCardCommandSyncResultListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}

	[global::Android.Runtime.Register ("mono/com/credenceid/biometrics/Biometrics_OnCardCommandSyncResultListenerImplementor")]
	internal sealed partial class IBiometricsOnCardCommandSyncResultListenerImplementor : global::Java.Lang.Object, IBiometricsOnCardCommandSyncResultListener {

		public IBiometricsOnCardCommandSyncResultListenerImplementor ()
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/credenceid/biometrics/Biometrics_OnCardCommandSyncResultListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
		}


		internal static bool __IsEmpty (IBiometricsOnCardCommandSyncResultListenerImplementor value)
		{
			return true;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.OnCardStatusListener']"
	[Register ("com/credenceid/biometrics/Biometrics$OnCardStatusListener", "", "Com.Credenceid.Biometrics.IBiometricsOnCardStatusListenerInvoker")]
	public partial interface IBiometricsOnCardStatusListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.OnCardStatusListener']/method[@name='onCardStatusChange' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onCardStatusChange", "(Ljava/lang/String;II)V", "GetOnCardStatusChange_Ljava_lang_String_IIHandler:Com.Credenceid.Biometrics.IBiometricsOnCardStatusListenerInvoker, CredenceBindings")]
		void OnCardStatusChange (string p0, int p1, int p2);

	}

	[global::Android.Runtime.Register ("com/credenceid/biometrics/Biometrics$OnCardStatusListener", DoNotGenerateAcw=true)]
	internal partial class IBiometricsOnCardStatusListenerInvoker : global::Java.Lang.Object, IBiometricsOnCardStatusListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/credenceid/biometrics/Biometrics$OnCardStatusListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBiometricsOnCardStatusListenerInvoker); }
		}

		IntPtr class_ref;

		public static IBiometricsOnCardStatusListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBiometricsOnCardStatusListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.credenceid.biometrics.Biometrics.OnCardStatusListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBiometricsOnCardStatusListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onCardStatusChange_Ljava_lang_String_II;
#pragma warning disable 0169
		static Delegate GetOnCardStatusChange_Ljava_lang_String_IIHandler ()
		{
			if (cb_onCardStatusChange_Ljava_lang_String_II == null)
				cb_onCardStatusChange_Ljava_lang_String_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_V) n_OnCardStatusChange_Ljava_lang_String_II);
			return cb_onCardStatusChange_Ljava_lang_String_II;
		}

		static void n_OnCardStatusChange_Ljava_lang_String_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnCardStatusListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCardStatusChange (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onCardStatusChange_Ljava_lang_String_II;
		public unsafe void OnCardStatusChange (string p0, int p1, int p2)
		{
			if (id_onCardStatusChange_Ljava_lang_String_II == IntPtr.Zero)
				id_onCardStatusChange_Ljava_lang_String_II = JNIEnv.GetMethodID (class_ref, "onCardStatusChange", "(Ljava/lang/String;II)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCardStatusChange_Ljava_lang_String_II, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

	// event args for com.credenceid.biometrics.Biometrics.OnCardStatusListener.onCardStatusChange
	public partial class BiometricsOnCardStatusEventArgs : global::System.EventArgs {

		public BiometricsOnCardStatusEventArgs (string p0, int p1, int p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}

		int p1;
		public int P1 {
			get { return p1; }
		}

		int p2;
		public int P2 {
			get { return p2; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/credenceid/biometrics/Biometrics_OnCardStatusListenerImplementor")]
	internal sealed partial class IBiometricsOnCardStatusListenerImplementor : global::Java.Lang.Object, IBiometricsOnCardStatusListener {

		object sender;

		public IBiometricsOnCardStatusListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/credenceid/biometrics/Biometrics_OnCardStatusListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<BiometricsOnCardStatusEventArgs> Handler;
#pragma warning restore 0649

		public void OnCardStatusChange (string p0, int p1, int p2)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new BiometricsOnCardStatusEventArgs (p0, p1, p2));
		}

		internal static bool __IsEmpty (IBiometricsOnCardStatusListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.OnCCFToFMDConversionListener']"
	[Register ("com/credenceid/biometrics/Biometrics$OnCCFToFMDConversionListener", "", "Com.Credenceid.Biometrics.IBiometricsOnCCFToFMDConversionListenerInvoker")]
	public partial interface IBiometricsOnCCFToFMDConversionListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.OnCCFToFMDConversionListener']/method[@name='onCCFToFMDConversion' and count(parameter)=2 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ResultCode'] and parameter[2][@type='byte[]']]"
		[Register ("onCCFToFMDConversion", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;[B)V", "GetOnCCFToFMDConversion_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayBHandler:Com.Credenceid.Biometrics.IBiometricsOnCCFToFMDConversionListenerInvoker, CredenceBindings")]
		void OnCCFToFMDConversion (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, byte[] p1);

	}

	[global::Android.Runtime.Register ("com/credenceid/biometrics/Biometrics$OnCCFToFMDConversionListener", DoNotGenerateAcw=true)]
	internal partial class IBiometricsOnCCFToFMDConversionListenerInvoker : global::Java.Lang.Object, IBiometricsOnCCFToFMDConversionListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/credenceid/biometrics/Biometrics$OnCCFToFMDConversionListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBiometricsOnCCFToFMDConversionListenerInvoker); }
		}

		IntPtr class_ref;

		public static IBiometricsOnCCFToFMDConversionListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBiometricsOnCCFToFMDConversionListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.credenceid.biometrics.Biometrics.OnCCFToFMDConversionListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBiometricsOnCCFToFMDConversionListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onCCFToFMDConversion_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayB;
#pragma warning disable 0169
		static Delegate GetOnCCFToFMDConversion_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayBHandler ()
		{
			if (cb_onCCFToFMDConversion_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayB == null)
				cb_onCCFToFMDConversion_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnCCFToFMDConversion_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayB);
			return cb_onCCFToFMDConversion_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayB;
		}

		static void n_OnCCFToFMDConversion_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnCCFToFMDConversionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsResultCode> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnCCFToFMDConversion (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		IntPtr id_onCCFToFMDConversion_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayB;
		public unsafe void OnCCFToFMDConversion (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, byte[] p1)
		{
			if (id_onCCFToFMDConversion_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayB == IntPtr.Zero)
				id_onCCFToFMDConversion_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayB = JNIEnv.GetMethodID (class_ref, "onCCFToFMDConversion", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;[B)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCCFToFMDConversion_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayB, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}

	// event args for com.credenceid.biometrics.Biometrics.OnCCFToFMDConversionListener.onCCFToFMDConversion
	public partial class BiometricsOnCCFToFMDConversionEventArgs : global::System.EventArgs {

		public BiometricsOnCCFToFMDConversionEventArgs (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, byte[] p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Credenceid.Biometrics.BiometricsResultCode p0;
		public global::Com.Credenceid.Biometrics.BiometricsResultCode P0 {
			get { return p0; }
		}

		byte[] p1;
		public byte[] P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/credenceid/biometrics/Biometrics_OnCCFToFMDConversionListenerImplementor")]
	internal sealed partial class IBiometricsOnCCFToFMDConversionListenerImplementor : global::Java.Lang.Object, IBiometricsOnCCFToFMDConversionListener {

		object sender;

		public IBiometricsOnCCFToFMDConversionListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/credenceid/biometrics/Biometrics_OnCCFToFMDConversionListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<BiometricsOnCCFToFMDConversionEventArgs> Handler;
#pragma warning restore 0649

		public void OnCCFToFMDConversion (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, byte[] p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new BiometricsOnCCFToFMDConversionEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IBiometricsOnCCFToFMDConversionListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.OnCompareFMDListener']"
	[Register ("com/credenceid/biometrics/Biometrics$OnCompareFMDListener", "", "Com.Credenceid.Biometrics.IBiometricsOnCompareFMDListenerInvoker")]
	public partial interface IBiometricsOnCompareFMDListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.OnCompareFMDListener']/method[@name='onCompareFMD' and count(parameter)=2 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ResultCode'] and parameter[2][@type='float']]"
		[Register ("onCompareFMD", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;F)V", "GetOnCompareFMD_Lcom_credenceid_biometrics_Biometrics_ResultCode_FHandler:Com.Credenceid.Biometrics.IBiometricsOnCompareFMDListenerInvoker, CredenceBindings")]
		void OnCompareFMD (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, float p1);

	}

	[global::Android.Runtime.Register ("com/credenceid/biometrics/Biometrics$OnCompareFMDListener", DoNotGenerateAcw=true)]
	internal partial class IBiometricsOnCompareFMDListenerInvoker : global::Java.Lang.Object, IBiometricsOnCompareFMDListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/credenceid/biometrics/Biometrics$OnCompareFMDListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBiometricsOnCompareFMDListenerInvoker); }
		}

		IntPtr class_ref;

		public static IBiometricsOnCompareFMDListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBiometricsOnCompareFMDListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.credenceid.biometrics.Biometrics.OnCompareFMDListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBiometricsOnCompareFMDListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onCompareFMD_Lcom_credenceid_biometrics_Biometrics_ResultCode_F;
#pragma warning disable 0169
		static Delegate GetOnCompareFMD_Lcom_credenceid_biometrics_Biometrics_ResultCode_FHandler ()
		{
			if (cb_onCompareFMD_Lcom_credenceid_biometrics_Biometrics_ResultCode_F == null)
				cb_onCompareFMD_Lcom_credenceid_biometrics_Biometrics_ResultCode_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLF_V) n_OnCompareFMD_Lcom_credenceid_biometrics_Biometrics_ResultCode_F);
			return cb_onCompareFMD_Lcom_credenceid_biometrics_Biometrics_ResultCode_F;
		}

		static void n_OnCompareFMD_Lcom_credenceid_biometrics_Biometrics_ResultCode_F (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnCompareFMDListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsResultCode> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCompareFMD (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onCompareFMD_Lcom_credenceid_biometrics_Biometrics_ResultCode_F;
		public unsafe void OnCompareFMD (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, float p1)
		{
			if (id_onCompareFMD_Lcom_credenceid_biometrics_Biometrics_ResultCode_F == IntPtr.Zero)
				id_onCompareFMD_Lcom_credenceid_biometrics_Biometrics_ResultCode_F = JNIEnv.GetMethodID (class_ref, "onCompareFMD", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;F)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCompareFMD_Lcom_credenceid_biometrics_Biometrics_ResultCode_F, __args);
		}

	}

	// event args for com.credenceid.biometrics.Biometrics.OnCompareFMDListener.onCompareFMD
	public partial class BiometricsOnCompareFMDEventArgs : global::System.EventArgs {

		public BiometricsOnCompareFMDEventArgs (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, float p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Credenceid.Biometrics.BiometricsResultCode p0;
		public global::Com.Credenceid.Biometrics.BiometricsResultCode P0 {
			get { return p0; }
		}

		float p1;
		public float P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/credenceid/biometrics/Biometrics_OnCompareFMDListenerImplementor")]
	internal sealed partial class IBiometricsOnCompareFMDListenerImplementor : global::Java.Lang.Object, IBiometricsOnCompareFMDListener {

		object sender;

		public IBiometricsOnCompareFMDListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/credenceid/biometrics/Biometrics_OnCompareFMDListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<BiometricsOnCompareFMDEventArgs> Handler;
#pragma warning restore 0649

		public void OnCompareFMD (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, float p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new BiometricsOnCompareFMDEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IBiometricsOnCompareFMDListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.OnCompressToWSQListener']"
	[Register ("com/credenceid/biometrics/Biometrics$OnCompressToWSQListener", "", "Com.Credenceid.Biometrics.IBiometricsOnCompressToWSQListenerInvoker")]
	public partial interface IBiometricsOnCompressToWSQListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.OnCompressToWSQListener']/method[@name='onConvertToWsq' and count(parameter)=2 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ResultCode'] and parameter[2][@type='java.lang.String']]"
		[Register ("onConvertToWsq", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Ljava/lang/String;)V", "GetOnConvertToWsq_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_Handler:Com.Credenceid.Biometrics.IBiometricsOnCompressToWSQListenerInvoker, CredenceBindings")]
		void OnConvertToWsq (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, string p1);

	}

	[global::Android.Runtime.Register ("com/credenceid/biometrics/Biometrics$OnCompressToWSQListener", DoNotGenerateAcw=true)]
	internal partial class IBiometricsOnCompressToWSQListenerInvoker : global::Java.Lang.Object, IBiometricsOnCompressToWSQListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/credenceid/biometrics/Biometrics$OnCompressToWSQListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBiometricsOnCompressToWSQListenerInvoker); }
		}

		IntPtr class_ref;

		public static IBiometricsOnCompressToWSQListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBiometricsOnCompressToWSQListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.credenceid.biometrics.Biometrics.OnCompressToWSQListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBiometricsOnCompressToWSQListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onConvertToWsq_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnConvertToWsq_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_Handler ()
		{
			if (cb_onConvertToWsq_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_ == null)
				cb_onConvertToWsq_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnConvertToWsq_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_);
			return cb_onConvertToWsq_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_;
		}

		static void n_OnConvertToWsq_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnCompressToWSQListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsResultCode> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnConvertToWsq (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onConvertToWsq_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_;
		public unsafe void OnConvertToWsq (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, string p1)
		{
			if (id_onConvertToWsq_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_ == IntPtr.Zero)
				id_onConvertToWsq_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onConvertToWsq", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConvertToWsq_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

	// event args for com.credenceid.biometrics.Biometrics.OnCompressToWSQListener.onConvertToWsq
	public partial class BiometricsOnCompressToWSQEventArgs : global::System.EventArgs {

		public BiometricsOnCompressToWSQEventArgs (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, string p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Credenceid.Biometrics.BiometricsResultCode p0;
		public global::Com.Credenceid.Biometrics.BiometricsResultCode P0 {
			get { return p0; }
		}

		string p1;
		public string P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/credenceid/biometrics/Biometrics_OnCompressToWSQListenerImplementor")]
	internal sealed partial class IBiometricsOnCompressToWSQListenerImplementor : global::Java.Lang.Object, IBiometricsOnCompressToWSQListener {

		object sender;

		public IBiometricsOnCompressToWSQListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/credenceid/biometrics/Biometrics_OnCompressToWSQListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<BiometricsOnCompressToWSQEventArgs> Handler;
#pragma warning restore 0649

		public void OnConvertToWsq (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, string p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new BiometricsOnCompressToWSQEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IBiometricsOnCompressToWSQListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.OnConvertToFMDListener']"
	[Register ("com/credenceid/biometrics/Biometrics$OnConvertToFMDListener", "", "Com.Credenceid.Biometrics.IBiometricsOnConvertToFMDListenerInvoker")]
	public partial interface IBiometricsOnConvertToFMDListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.OnConvertToFMDListener']/method[@name='onConvertToFMD' and count(parameter)=2 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ResultCode'] and parameter[2][@type='byte[]']]"
		[Register ("onConvertToFMD", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;[B)V", "GetOnConvertToFMD_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayBHandler:Com.Credenceid.Biometrics.IBiometricsOnConvertToFMDListenerInvoker, CredenceBindings")]
		void OnConvertToFMD (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, byte[] p1);

	}

	[global::Android.Runtime.Register ("com/credenceid/biometrics/Biometrics$OnConvertToFMDListener", DoNotGenerateAcw=true)]
	internal partial class IBiometricsOnConvertToFMDListenerInvoker : global::Java.Lang.Object, IBiometricsOnConvertToFMDListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/credenceid/biometrics/Biometrics$OnConvertToFMDListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBiometricsOnConvertToFMDListenerInvoker); }
		}

		IntPtr class_ref;

		public static IBiometricsOnConvertToFMDListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBiometricsOnConvertToFMDListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.credenceid.biometrics.Biometrics.OnConvertToFMDListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBiometricsOnConvertToFMDListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onConvertToFMD_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayB;
#pragma warning disable 0169
		static Delegate GetOnConvertToFMD_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayBHandler ()
		{
			if (cb_onConvertToFMD_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayB == null)
				cb_onConvertToFMD_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnConvertToFMD_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayB);
			return cb_onConvertToFMD_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayB;
		}

		static void n_OnConvertToFMD_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnConvertToFMDListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsResultCode> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnConvertToFMD (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		IntPtr id_onConvertToFMD_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayB;
		public unsafe void OnConvertToFMD (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, byte[] p1)
		{
			if (id_onConvertToFMD_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayB == IntPtr.Zero)
				id_onConvertToFMD_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayB = JNIEnv.GetMethodID (class_ref, "onConvertToFMD", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;[B)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConvertToFMD_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayB, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}

	// event args for com.credenceid.biometrics.Biometrics.OnConvertToFMDListener.onConvertToFMD
	public partial class BiometricsOnConvertToFMDEventArgs : global::System.EventArgs {

		public BiometricsOnConvertToFMDEventArgs (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, byte[] p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Credenceid.Biometrics.BiometricsResultCode p0;
		public global::Com.Credenceid.Biometrics.BiometricsResultCode P0 {
			get { return p0; }
		}

		byte[] p1;
		public byte[] P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/credenceid/biometrics/Biometrics_OnConvertToFMDListenerImplementor")]
	internal sealed partial class IBiometricsOnConvertToFMDListenerImplementor : global::Java.Lang.Object, IBiometricsOnConvertToFMDListener {

		object sender;

		public IBiometricsOnConvertToFMDListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/credenceid/biometrics/Biometrics_OnConvertToFMDListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<BiometricsOnConvertToFMDEventArgs> Handler;
#pragma warning restore 0649

		public void OnConvertToFMD (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, byte[] p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new BiometricsOnConvertToFMDEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IBiometricsOnConvertToFMDListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.OnDecompressWSQListener']"
	[Register ("com/credenceid/biometrics/Biometrics$OnDecompressWSQListener", "", "Com.Credenceid.Biometrics.IBiometricsOnDecompressWSQListenerInvoker")]
	public partial interface IBiometricsOnDecompressWSQListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.OnDecompressWSQListener']/method[@name='onDecompressWsq' and count(parameter)=2 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ResultCode'] and parameter[2][@type='byte[]']]"
		[Register ("onDecompressWsq", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;[B)V", "GetOnDecompressWsq_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayBHandler:Com.Credenceid.Biometrics.IBiometricsOnDecompressWSQListenerInvoker, CredenceBindings")]
		void OnDecompressWsq (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, byte[] p1);

	}

	[global::Android.Runtime.Register ("com/credenceid/biometrics/Biometrics$OnDecompressWSQListener", DoNotGenerateAcw=true)]
	internal partial class IBiometricsOnDecompressWSQListenerInvoker : global::Java.Lang.Object, IBiometricsOnDecompressWSQListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/credenceid/biometrics/Biometrics$OnDecompressWSQListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBiometricsOnDecompressWSQListenerInvoker); }
		}

		IntPtr class_ref;

		public static IBiometricsOnDecompressWSQListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBiometricsOnDecompressWSQListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.credenceid.biometrics.Biometrics.OnDecompressWSQListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBiometricsOnDecompressWSQListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onDecompressWsq_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayB;
#pragma warning disable 0169
		static Delegate GetOnDecompressWsq_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayBHandler ()
		{
			if (cb_onDecompressWsq_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayB == null)
				cb_onDecompressWsq_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnDecompressWsq_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayB);
			return cb_onDecompressWsq_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayB;
		}

		static void n_OnDecompressWsq_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnDecompressWSQListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsResultCode> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnDecompressWsq (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		IntPtr id_onDecompressWsq_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayB;
		public unsafe void OnDecompressWsq (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, byte[] p1)
		{
			if (id_onDecompressWsq_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayB == IntPtr.Zero)
				id_onDecompressWsq_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayB = JNIEnv.GetMethodID (class_ref, "onDecompressWsq", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;[B)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDecompressWsq_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayB, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}

	// event args for com.credenceid.biometrics.Biometrics.OnDecompressWSQListener.onDecompressWsq
	public partial class BiometricsOnDecompressWSQEventArgs : global::System.EventArgs {

		public BiometricsOnDecompressWSQEventArgs (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, byte[] p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Credenceid.Biometrics.BiometricsResultCode p0;
		public global::Com.Credenceid.Biometrics.BiometricsResultCode P0 {
			get { return p0; }
		}

		byte[] p1;
		public byte[] P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/credenceid/biometrics/Biometrics_OnDecompressWSQListenerImplementor")]
	internal sealed partial class IBiometricsOnDecompressWSQListenerImplementor : global::Java.Lang.Object, IBiometricsOnDecompressWSQListener {

		object sender;

		public IBiometricsOnDecompressWSQListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/credenceid/biometrics/Biometrics_OnDecompressWSQListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<BiometricsOnDecompressWSQEventArgs> Handler;
#pragma warning restore 0649

		public void OnDecompressWsq (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, byte[] p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new BiometricsOnDecompressWSQEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IBiometricsOnDecompressWSQListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.OnEktpCardReadListener']"
	[Register ("com/credenceid/biometrics/Biometrics$OnEktpCardReadListener", "", "Com.Credenceid.Biometrics.IBiometricsOnEktpCardReadListenerInvoker")]
	public partial interface IBiometricsOnEktpCardReadListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.OnEktpCardReadListener']/method[@name='OnEktpCardRead' and count(parameter)=3 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ResultCode'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='byte[]']]"
		[Register ("OnEktpCardRead", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Ljava/lang/String;[B)V", "GetOnEktpCardRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_arrayBHandler:Com.Credenceid.Biometrics.IBiometricsOnEktpCardReadListenerInvoker, CredenceBindings")]
		void OnEktpCardRead (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, string p1, byte[] p2);

	}

	[global::Android.Runtime.Register ("com/credenceid/biometrics/Biometrics$OnEktpCardReadListener", DoNotGenerateAcw=true)]
	internal partial class IBiometricsOnEktpCardReadListenerInvoker : global::Java.Lang.Object, IBiometricsOnEktpCardReadListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/credenceid/biometrics/Biometrics$OnEktpCardReadListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBiometricsOnEktpCardReadListenerInvoker); }
		}

		IntPtr class_ref;

		public static IBiometricsOnEktpCardReadListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBiometricsOnEktpCardReadListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.credenceid.biometrics.Biometrics.OnEktpCardReadListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBiometricsOnEktpCardReadListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_OnEktpCardRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_arrayB;
#pragma warning disable 0169
		static Delegate GetOnEktpCardRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_arrayBHandler ()
		{
			if (cb_OnEktpCardRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_arrayB == null)
				cb_OnEktpCardRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_OnEktpCardRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_arrayB);
			return cb_OnEktpCardRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_arrayB;
		}

		static void n_OnEktpCardRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnEktpCardReadListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsResultCode> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnEktpCardRead (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		IntPtr id_OnEktpCardRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_arrayB;
		public unsafe void OnEktpCardRead (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, string p1, byte[] p2)
		{
			if (id_OnEktpCardRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_arrayB == IntPtr.Zero)
				id_OnEktpCardRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_arrayB = JNIEnv.GetMethodID (class_ref, "OnEktpCardRead", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Ljava/lang/String;[B)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnEktpCardRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_arrayB, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}

	// event args for com.credenceid.biometrics.Biometrics.OnEktpCardReadListener.OnEktpCardRead
	public partial class BiometricsOnEktpCardReadEventArgs : global::System.EventArgs {

		public BiometricsOnEktpCardReadEventArgs (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, string p1, byte[] p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		global::Com.Credenceid.Biometrics.BiometricsResultCode p0;
		public global::Com.Credenceid.Biometrics.BiometricsResultCode P0 {
			get { return p0; }
		}

		string p1;
		public string P1 {
			get { return p1; }
		}

		byte[] p2;
		public byte[] P2 {
			get { return p2; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/credenceid/biometrics/Biometrics_OnEktpCardReadListenerImplementor")]
	internal sealed partial class IBiometricsOnEktpCardReadListenerImplementor : global::Java.Lang.Object, IBiometricsOnEktpCardReadListener {

		object sender;

		public IBiometricsOnEktpCardReadListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/credenceid/biometrics/Biometrics_OnEktpCardReadListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<BiometricsOnEktpCardReadEventArgs> Handler;
#pragma warning restore 0649

		public void OnEktpCardRead (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, string p1, byte[] p2)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new BiometricsOnEktpCardReadEventArgs (p0, p1, p2));
		}

		internal static bool __IsEmpty (IBiometricsOnEktpCardReadListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.OnEPassportCommandListener']"
	[Register ("com/credenceid/biometrics/Biometrics$OnEPassportCommandListener", "", "Com.Credenceid.Biometrics.IBiometricsOnEPassportCommandListenerInvoker")]
	public partial interface IBiometricsOnEPassportCommandListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.OnEPassportCommandListener']/method[@name='onEPassportCommandComplete' and count(parameter)=4 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ResultCode'] and parameter[2][@type='byte'] and parameter[3][@type='byte'] and parameter[4][@type='byte[]']]"
		[Register ("onEPassportCommandComplete", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;BB[B)V", "GetOnEPassportCommandComplete_Lcom_credenceid_biometrics_Biometrics_ResultCode_BBarrayBHandler:Com.Credenceid.Biometrics.IBiometricsOnEPassportCommandListenerInvoker, CredenceBindings")]
		void OnEPassportCommandComplete (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, sbyte p1, sbyte p2, byte[] p3);

	}

	[global::Android.Runtime.Register ("com/credenceid/biometrics/Biometrics$OnEPassportCommandListener", DoNotGenerateAcw=true)]
	internal partial class IBiometricsOnEPassportCommandListenerInvoker : global::Java.Lang.Object, IBiometricsOnEPassportCommandListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/credenceid/biometrics/Biometrics$OnEPassportCommandListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBiometricsOnEPassportCommandListenerInvoker); }
		}

		IntPtr class_ref;

		public static IBiometricsOnEPassportCommandListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBiometricsOnEPassportCommandListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.credenceid.biometrics.Biometrics.OnEPassportCommandListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBiometricsOnEPassportCommandListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onEPassportCommandComplete_Lcom_credenceid_biometrics_Biometrics_ResultCode_BBarrayB;
#pragma warning disable 0169
		static Delegate GetOnEPassportCommandComplete_Lcom_credenceid_biometrics_Biometrics_ResultCode_BBarrayBHandler ()
		{
			if (cb_onEPassportCommandComplete_Lcom_credenceid_biometrics_Biometrics_ResultCode_BBarrayB == null)
				cb_onEPassportCommandComplete_Lcom_credenceid_biometrics_Biometrics_ResultCode_BBarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLBBL_V) n_OnEPassportCommandComplete_Lcom_credenceid_biometrics_Biometrics_ResultCode_BBarrayB);
			return cb_onEPassportCommandComplete_Lcom_credenceid_biometrics_Biometrics_ResultCode_BBarrayB;
		}

		static void n_OnEPassportCommandComplete_Lcom_credenceid_biometrics_Biometrics_ResultCode_BBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, sbyte p1, sbyte p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnEPassportCommandListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsResultCode> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p3 = (byte[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnEPassportCommandComplete (p0, p1, p2, p3);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
		}
#pragma warning restore 0169

		IntPtr id_onEPassportCommandComplete_Lcom_credenceid_biometrics_Biometrics_ResultCode_BBarrayB;
		public unsafe void OnEPassportCommandComplete (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, sbyte p1, sbyte p2, byte[] p3)
		{
			if (id_onEPassportCommandComplete_Lcom_credenceid_biometrics_Biometrics_ResultCode_BBarrayB == IntPtr.Zero)
				id_onEPassportCommandComplete_Lcom_credenceid_biometrics_Biometrics_ResultCode_BBarrayB = JNIEnv.GetMethodID (class_ref, "onEPassportCommandComplete", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;BB[B)V");
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (native_p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onEPassportCommandComplete_Lcom_credenceid_biometrics_Biometrics_ResultCode_BBarrayB, __args);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

	}

	// event args for com.credenceid.biometrics.Biometrics.OnEPassportCommandListener.onEPassportCommandComplete
	public partial class BiometricsOnEPassportCommandEventArgs : global::System.EventArgs {

		public BiometricsOnEPassportCommandEventArgs (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, sbyte p1, sbyte p2, byte[] p3)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
		}

		global::Com.Credenceid.Biometrics.BiometricsResultCode p0;
		public global::Com.Credenceid.Biometrics.BiometricsResultCode P0 {
			get { return p0; }
		}

		sbyte p1;
		public sbyte P1 {
			get { return p1; }
		}

		sbyte p2;
		public sbyte P2 {
			get { return p2; }
		}

		byte[] p3;
		public byte[] P3 {
			get { return p3; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/credenceid/biometrics/Biometrics_OnEPassportCommandListenerImplementor")]
	internal sealed partial class IBiometricsOnEPassportCommandListenerImplementor : global::Java.Lang.Object, IBiometricsOnEPassportCommandListener {

		object sender;

		public IBiometricsOnEPassportCommandListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/credenceid/biometrics/Biometrics_OnEPassportCommandListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<BiometricsOnEPassportCommandEventArgs> Handler;
#pragma warning restore 0649

		public void OnEPassportCommandComplete (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, sbyte p1, sbyte p2, byte[] p3)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new BiometricsOnEPassportCommandEventArgs (p0, p1, p2, p3));
		}

		internal static bool __IsEmpty (IBiometricsOnEPassportCommandListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.OnEPassportStatusListener']"
	[Register ("com/credenceid/biometrics/Biometrics$OnEPassportStatusListener", "", "Com.Credenceid.Biometrics.IBiometricsOnEPassportStatusListenerInvoker")]
	public partial interface IBiometricsOnEPassportStatusListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.OnEPassportStatusListener']/method[@name='onEPassportCardStatusChange' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("onEPassportCardStatusChange", "(II)V", "GetOnEPassportCardStatusChange_IIHandler:Com.Credenceid.Biometrics.IBiometricsOnEPassportStatusListenerInvoker, CredenceBindings")]
		void OnEPassportCardStatusChange (int p0, int p1);

	}

	[global::Android.Runtime.Register ("com/credenceid/biometrics/Biometrics$OnEPassportStatusListener", DoNotGenerateAcw=true)]
	internal partial class IBiometricsOnEPassportStatusListenerInvoker : global::Java.Lang.Object, IBiometricsOnEPassportStatusListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/credenceid/biometrics/Biometrics$OnEPassportStatusListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBiometricsOnEPassportStatusListenerInvoker); }
		}

		IntPtr class_ref;

		public static IBiometricsOnEPassportStatusListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBiometricsOnEPassportStatusListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.credenceid.biometrics.Biometrics.OnEPassportStatusListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBiometricsOnEPassportStatusListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onEPassportCardStatusChange_II;
#pragma warning disable 0169
		static Delegate GetOnEPassportCardStatusChange_IIHandler ()
		{
			if (cb_onEPassportCardStatusChange_II == null)
				cb_onEPassportCardStatusChange_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_V) n_OnEPassportCardStatusChange_II);
			return cb_onEPassportCardStatusChange_II;
		}

		static void n_OnEPassportCardStatusChange_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnEPassportStatusListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnEPassportCardStatusChange (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onEPassportCardStatusChange_II;
		public unsafe void OnEPassportCardStatusChange (int p0, int p1)
		{
			if (id_onEPassportCardStatusChange_II == IntPtr.Zero)
				id_onEPassportCardStatusChange_II = JNIEnv.GetMethodID (class_ref, "onEPassportCardStatusChange", "(II)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onEPassportCardStatusChange_II, __args);
		}

	}

	// event args for com.credenceid.biometrics.Biometrics.OnEPassportStatusListener.onEPassportCardStatusChange
	public partial class BiometricsOnEPassportStatusEventArgs : global::System.EventArgs {

		public BiometricsOnEPassportStatusEventArgs (int p0, int p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}

		int p1;
		public int P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/credenceid/biometrics/Biometrics_OnEPassportStatusListenerImplementor")]
	internal sealed partial class IBiometricsOnEPassportStatusListenerImplementor : global::Java.Lang.Object, IBiometricsOnEPassportStatusListener {

		object sender;

		public IBiometricsOnEPassportStatusListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/credenceid/biometrics/Biometrics_OnEPassportStatusListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<BiometricsOnEPassportStatusEventArgs> Handler;
#pragma warning restore 0649

		public void OnEPassportCardStatusChange (int p0, int p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new BiometricsOnEPassportStatusEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IBiometricsOnEPassportStatusListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.OnFingerprintGrabbedFullListener']"
	[Register ("com/credenceid/biometrics/Biometrics$OnFingerprintGrabbedFullListener", "", "Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedFullListenerInvoker")]
	public partial interface IBiometricsOnFingerprintGrabbedFullListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.OnFingerprintGrabbedFullListener']/method[@name='onCloseFingerprintReader' and count(parameter)=2 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ResultCode'] and parameter[2][@type='com.credenceid.biometrics.Biometrics.CloseReasonCode']]"
		[Register ("onCloseFingerprintReader", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Lcom/credenceid/biometrics/Biometrics$CloseReasonCode;)V", "GetOnCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_Handler:Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedFullListenerInvoker, CredenceBindings")]
		void OnCloseFingerprintReader (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.OnFingerprintGrabbedFullListener']/method[@name='onFingerprintGrabbed' and count(parameter)=11 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ResultCode'] and parameter[2][@type='android.graphics.Bitmap'] and parameter[3][@type='android.graphics.Bitmap'] and parameter[4][@type='android.graphics.Bitmap'] and parameter[5][@type='byte[]'] and parameter[6][@type='byte[]'] and parameter[7][@type='byte[]'] and parameter[8][@type='java.lang.String'] and parameter[9][@type='java.lang.String'] and parameter[10][@type='java.lang.String'] and parameter[11][@type='java.lang.String']]"
		[Register ("onFingerprintGrabbed", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;[B[B[BLjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetOnFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_arrayBarrayBarrayBLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedFullListenerInvoker, CredenceBindings")]
		void OnFingerprintGrabbed (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Android.Graphics.Bitmap p1, global::Android.Graphics.Bitmap p2, global::Android.Graphics.Bitmap p3, byte[] p4, byte[] p5, byte[] p6, string p7, string p8, string p9, string p10);

	}

	[global::Android.Runtime.Register ("com/credenceid/biometrics/Biometrics$OnFingerprintGrabbedFullListener", DoNotGenerateAcw=true)]
	internal partial class IBiometricsOnFingerprintGrabbedFullListenerInvoker : global::Java.Lang.Object, IBiometricsOnFingerprintGrabbedFullListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/credenceid/biometrics/Biometrics$OnFingerprintGrabbedFullListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBiometricsOnFingerprintGrabbedFullListenerInvoker); }
		}

		IntPtr class_ref;

		public static IBiometricsOnFingerprintGrabbedFullListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBiometricsOnFingerprintGrabbedFullListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.credenceid.biometrics.Biometrics.OnFingerprintGrabbedFullListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBiometricsOnFingerprintGrabbedFullListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_;
#pragma warning disable 0169
		static Delegate GetOnCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_Handler ()
		{
			if (cb_onCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_ == null)
				cb_onCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_);
			return cb_onCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_;
		}

		static void n_OnCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedFullListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsResultCode> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnCloseFingerprintReader (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_;
		public unsafe void OnCloseFingerprintReader (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode p1)
		{
			if (id_onCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_ == IntPtr.Zero)
				id_onCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_ = JNIEnv.GetMethodID (class_ref, "onCloseFingerprintReader", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Lcom/credenceid/biometrics/Biometrics$CloseReasonCode;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_, __args);
		}

		static Delegate cb_onFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_arrayBarrayBarrayBLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_arrayBarrayBarrayBLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_onFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_arrayBarrayBarrayBLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_onFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_arrayBarrayBarrayBLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLLLLLLLL_V) n_OnFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_arrayBarrayBarrayBLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_onFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_arrayBarrayBarrayBLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_OnFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_arrayBarrayBarrayBLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5, IntPtr native_p6, IntPtr native_p7, IntPtr native_p8, IntPtr native_p9, IntPtr native_p10)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedFullListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsResultCode> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p3, JniHandleOwnership.DoNotTransfer);
			var p4 = (byte[]) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p5 = (byte[]) JNIEnv.GetArray (native_p5, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p6 = (byte[]) JNIEnv.GetArray (native_p6, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p7 = JNIEnv.GetString (native_p7, JniHandleOwnership.DoNotTransfer);
			var p8 = JNIEnv.GetString (native_p8, JniHandleOwnership.DoNotTransfer);
			var p9 = JNIEnv.GetString (native_p9, JniHandleOwnership.DoNotTransfer);
			var p10 = JNIEnv.GetString (native_p10, JniHandleOwnership.DoNotTransfer);
			__this.OnFingerprintGrabbed (p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10);
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
			if (p5 != null)
				JNIEnv.CopyArray (p5, native_p5);
			if (p6 != null)
				JNIEnv.CopyArray (p6, native_p6);
		}
#pragma warning restore 0169

		IntPtr id_onFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_arrayBarrayBarrayBLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void OnFingerprintGrabbed (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Android.Graphics.Bitmap p1, global::Android.Graphics.Bitmap p2, global::Android.Graphics.Bitmap p3, byte[] p4, byte[] p5, byte[] p6, string p7, string p8, string p9, string p10)
		{
			if (id_onFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_arrayBarrayBarrayBLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_onFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_arrayBarrayBarrayBLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onFingerprintGrabbed", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;[B[B[BLjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			IntPtr native_p5 = JNIEnv.NewArray (p5);
			IntPtr native_p6 = JNIEnv.NewArray (p6);
			IntPtr native_p7 = JNIEnv.NewString (p7);
			IntPtr native_p8 = JNIEnv.NewString (p8);
			IntPtr native_p9 = JNIEnv.NewString (p9);
			IntPtr native_p10 = JNIEnv.NewString (p10);
			JValue* __args = stackalloc JValue [11];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (native_p4);
			__args [5] = new JValue (native_p5);
			__args [6] = new JValue (native_p6);
			__args [7] = new JValue (native_p7);
			__args [8] = new JValue (native_p8);
			__args [9] = new JValue (native_p9);
			__args [10] = new JValue (native_p10);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_arrayBarrayBarrayBLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			if (p4 != null) {
				JNIEnv.CopyArray (native_p4, p4);
				JNIEnv.DeleteLocalRef (native_p4);
			}
			if (p5 != null) {
				JNIEnv.CopyArray (native_p5, p5);
				JNIEnv.DeleteLocalRef (native_p5);
			}
			if (p6 != null) {
				JNIEnv.CopyArray (native_p6, p6);
				JNIEnv.DeleteLocalRef (native_p6);
			}
			JNIEnv.DeleteLocalRef (native_p7);
			JNIEnv.DeleteLocalRef (native_p8);
			JNIEnv.DeleteLocalRef (native_p9);
			JNIEnv.DeleteLocalRef (native_p10);
		}

	}

	// event args for com.credenceid.biometrics.Biometrics.OnFingerprintGrabbedFullListener.onCloseFingerprintReader
	public partial class FullFingerprintsCloseArgs : global::System.EventArgs {

		public FullFingerprintsCloseArgs (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Credenceid.Biometrics.BiometricsResultCode p0;
		public global::Com.Credenceid.Biometrics.BiometricsResultCode P0 {
			get { return p0; }
		}

		global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode p1;
		public global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode P1 {
			get { return p1; }
		}
	}

	// event args for com.credenceid.biometrics.Biometrics.OnFingerprintGrabbedFullListener.onFingerprintGrabbed
	public partial class FullFingerprintsGrabbedArgs : global::System.EventArgs {

		public FullFingerprintsGrabbedArgs (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Android.Graphics.Bitmap p1, global::Android.Graphics.Bitmap p2, global::Android.Graphics.Bitmap p3, byte[] p4, byte[] p5, byte[] p6, string p7, string p8, string p9, string p10)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
			this.p4 = p4;
			this.p5 = p5;
			this.p6 = p6;
			this.p7 = p7;
			this.p8 = p8;
			this.p9 = p9;
			this.p10 = p10;
		}

		global::Com.Credenceid.Biometrics.BiometricsResultCode p0;
		public global::Com.Credenceid.Biometrics.BiometricsResultCode P0 {
			get { return p0; }
		}

		global::Android.Graphics.Bitmap p1;
		public global::Android.Graphics.Bitmap P1 {
			get { return p1; }
		}

		global::Android.Graphics.Bitmap p2;
		public global::Android.Graphics.Bitmap P2 {
			get { return p2; }
		}

		global::Android.Graphics.Bitmap p3;
		public global::Android.Graphics.Bitmap P3 {
			get { return p3; }
		}

		byte[] p4;
		public byte[] P4 {
			get { return p4; }
		}

		byte[] p5;
		public byte[] P5 {
			get { return p5; }
		}

		byte[] p6;
		public byte[] P6 {
			get { return p6; }
		}

		string p7;
		public string P7 {
			get { return p7; }
		}

		string p8;
		public string P8 {
			get { return p8; }
		}

		string p9;
		public string P9 {
			get { return p9; }
		}

		string p10;
		public string P10 {
			get { return p10; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/credenceid/biometrics/Biometrics_OnFingerprintGrabbedFullListenerImplementor")]
	internal sealed partial class IBiometricsOnFingerprintGrabbedFullListenerImplementor : global::Java.Lang.Object, IBiometricsOnFingerprintGrabbedFullListener {

		object sender;

		public IBiometricsOnFingerprintGrabbedFullListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/credenceid/biometrics/Biometrics_OnFingerprintGrabbedFullListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<FullFingerprintsCloseArgs> OnCloseFingerprintReaderHandler;
#pragma warning restore 0649

		public void OnCloseFingerprintReader (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode p1)
		{
			var __h = OnCloseFingerprintReaderHandler;
			if (__h != null)
				__h (sender, new FullFingerprintsCloseArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<FullFingerprintsGrabbedArgs> OnFingerprintGrabbedHandler;
#pragma warning restore 0649

		public void OnFingerprintGrabbed (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Android.Graphics.Bitmap p1, global::Android.Graphics.Bitmap p2, global::Android.Graphics.Bitmap p3, byte[] p4, byte[] p5, byte[] p6, string p7, string p8, string p9, string p10)
		{
			var __h = OnFingerprintGrabbedHandler;
			if (__h != null)
				__h (sender, new FullFingerprintsGrabbedArgs (p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10));
		}

		internal static bool __IsEmpty (IBiometricsOnFingerprintGrabbedFullListenerImplementor value)
		{
			return value.OnCloseFingerprintReaderHandler == null && value.OnFingerprintGrabbedHandler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.OnFingerprintGrabbedListener']"
	[Register ("com/credenceid/biometrics/Biometrics$OnFingerprintGrabbedListener", "", "Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedListenerInvoker")]
	public partial interface IBiometricsOnFingerprintGrabbedListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.OnFingerprintGrabbedListener']/method[@name='onCloseFingerprintReader' and count(parameter)=2 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ResultCode'] and parameter[2][@type='com.credenceid.biometrics.Biometrics.CloseReasonCode']]"
		[Register ("onCloseFingerprintReader", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Lcom/credenceid/biometrics/Biometrics$CloseReasonCode;)V", "GetOnCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_Handler:Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedListenerInvoker, CredenceBindings")]
		void OnCloseFingerprintReader (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.OnFingerprintGrabbedListener']/method[@name='onFingerprintGrabbed' and count(parameter)=5 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ResultCode'] and parameter[2][@type='android.graphics.Bitmap'] and parameter[3][@type='byte[]'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register ("onFingerprintGrabbed", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Landroid/graphics/Bitmap;[BLjava/lang/String;Ljava/lang/String;)V", "GetOnFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_arrayBLjava_lang_String_Ljava_lang_String_Handler:Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedListenerInvoker, CredenceBindings")]
		void OnFingerprintGrabbed (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Android.Graphics.Bitmap p1, byte[] p2, string p3, string p4);

	}

	[global::Android.Runtime.Register ("com/credenceid/biometrics/Biometrics$OnFingerprintGrabbedListener", DoNotGenerateAcw=true)]
	internal partial class IBiometricsOnFingerprintGrabbedListenerInvoker : global::Java.Lang.Object, IBiometricsOnFingerprintGrabbedListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/credenceid/biometrics/Biometrics$OnFingerprintGrabbedListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBiometricsOnFingerprintGrabbedListenerInvoker); }
		}

		IntPtr class_ref;

		public static IBiometricsOnFingerprintGrabbedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBiometricsOnFingerprintGrabbedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.credenceid.biometrics.Biometrics.OnFingerprintGrabbedListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBiometricsOnFingerprintGrabbedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_;
#pragma warning disable 0169
		static Delegate GetOnCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_Handler ()
		{
			if (cb_onCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_ == null)
				cb_onCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_);
			return cb_onCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_;
		}

		static void n_OnCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsResultCode> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnCloseFingerprintReader (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_;
		public unsafe void OnCloseFingerprintReader (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode p1)
		{
			if (id_onCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_ == IntPtr.Zero)
				id_onCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_ = JNIEnv.GetMethodID (class_ref, "onCloseFingerprintReader", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Lcom/credenceid/biometrics/Biometrics$CloseReasonCode;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_, __args);
		}

		static Delegate cb_onFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_arrayBLjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_arrayBLjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_onFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_arrayBLjava_lang_String_Ljava_lang_String_ == null)
				cb_onFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_arrayBLjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLL_V) n_OnFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_arrayBLjava_lang_String_Ljava_lang_String_);
			return cb_onFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_arrayBLjava_lang_String_Ljava_lang_String_;
		}

		static void n_OnFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_arrayBLjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsResultCode> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			var p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.OnFingerprintGrabbed (p0, p1, p2, p3, p4);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		IntPtr id_onFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_arrayBLjava_lang_String_Ljava_lang_String_;
		public unsafe void OnFingerprintGrabbed (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Android.Graphics.Bitmap p1, byte[] p2, string p3, string p4)
		{
			if (id_onFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_arrayBLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_onFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_arrayBLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onFingerprintGrabbed", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Landroid/graphics/Bitmap;[BLjava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (native_p4);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_arrayBLjava_lang_String_Ljava_lang_String_, __args);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			JNIEnv.DeleteLocalRef (native_p3);
			JNIEnv.DeleteLocalRef (native_p4);
		}

	}

	// event args for com.credenceid.biometrics.Biometrics.OnFingerprintGrabbedListener.onCloseFingerprintReader
	public partial class FingerprintClosedArgs : global::System.EventArgs {

		public FingerprintClosedArgs (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Credenceid.Biometrics.BiometricsResultCode p0;
		public global::Com.Credenceid.Biometrics.BiometricsResultCode P0 {
			get { return p0; }
		}

		global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode p1;
		public global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode P1 {
			get { return p1; }
		}
	}

	// event args for com.credenceid.biometrics.Biometrics.OnFingerprintGrabbedListener.onFingerprintGrabbed
	public partial class FingerprintGrabbedArgs : global::System.EventArgs {

		public FingerprintGrabbedArgs (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Android.Graphics.Bitmap p1, byte[] p2, string p3, string p4)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
			this.p4 = p4;
		}

		global::Com.Credenceid.Biometrics.BiometricsResultCode p0;
		public global::Com.Credenceid.Biometrics.BiometricsResultCode P0 {
			get { return p0; }
		}

		global::Android.Graphics.Bitmap p1;
		public global::Android.Graphics.Bitmap P1 {
			get { return p1; }
		}

		byte[] p2;
		public byte[] P2 {
			get { return p2; }
		}

		string p3;
		public string P3 {
			get { return p3; }
		}

		string p4;
		public string P4 {
			get { return p4; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/credenceid/biometrics/Biometrics_OnFingerprintGrabbedListenerImplementor")]
	internal sealed partial class IBiometricsOnFingerprintGrabbedListenerImplementor : global::Java.Lang.Object, IBiometricsOnFingerprintGrabbedListener {

		object sender;

		public IBiometricsOnFingerprintGrabbedListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/credenceid/biometrics/Biometrics_OnFingerprintGrabbedListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<FingerprintClosedArgs> OnCloseFingerprintReaderHandler;
#pragma warning restore 0649

		public void OnCloseFingerprintReader (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode p1)
		{
			var __h = OnCloseFingerprintReaderHandler;
			if (__h != null)
				__h (sender, new FingerprintClosedArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<FingerprintGrabbedArgs> OnFingerprintGrabbedHandler;
#pragma warning restore 0649

		public void OnFingerprintGrabbed (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Android.Graphics.Bitmap p1, byte[] p2, string p3, string p4)
		{
			var __h = OnFingerprintGrabbedHandler;
			if (__h != null)
				__h (sender, new FingerprintGrabbedArgs (p0, p1, p2, p3, p4));
		}

		internal static bool __IsEmpty (IBiometricsOnFingerprintGrabbedListenerImplementor value)
		{
			return value.OnCloseFingerprintReaderHandler == null && value.OnFingerprintGrabbedHandler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.OnFingerprintGrabbedRawListener']"
	[Register ("com/credenceid/biometrics/Biometrics$OnFingerprintGrabbedRawListener", "", "Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedRawListenerInvoker")]
	public partial interface IBiometricsOnFingerprintGrabbedRawListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.OnFingerprintGrabbedRawListener']/method[@name='onCloseFingerprintReader' and count(parameter)=2 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ResultCode'] and parameter[2][@type='com.credenceid.biometrics.Biometrics.CloseReasonCode']]"
		[Register ("onCloseFingerprintReader", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Lcom/credenceid/biometrics/Biometrics$CloseReasonCode;)V", "GetOnCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_Handler:Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedRawListenerInvoker, CredenceBindings")]
		void OnCloseFingerprintReader (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.OnFingerprintGrabbedRawListener']/method[@name='onFingerprintGrabbed' and count(parameter)=6 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ResultCode'] and parameter[2][@type='android.graphics.Bitmap'] and parameter[3][@type='byte[]'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='byte[]'] and parameter[6][@type='java.lang.String']]"
		[Register ("onFingerprintGrabbed", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Landroid/graphics/Bitmap;[BLjava/lang/String;[BLjava/lang/String;)V", "GetOnFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_arrayBLjava_lang_String_arrayBLjava_lang_String_Handler:Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedRawListenerInvoker, CredenceBindings")]
		void OnFingerprintGrabbed (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Android.Graphics.Bitmap p1, byte[] p2, string p3, byte[] p4, string p5);

	}

	[global::Android.Runtime.Register ("com/credenceid/biometrics/Biometrics$OnFingerprintGrabbedRawListener", DoNotGenerateAcw=true)]
	internal partial class IBiometricsOnFingerprintGrabbedRawListenerInvoker : global::Java.Lang.Object, IBiometricsOnFingerprintGrabbedRawListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/credenceid/biometrics/Biometrics$OnFingerprintGrabbedRawListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBiometricsOnFingerprintGrabbedRawListenerInvoker); }
		}

		IntPtr class_ref;

		public static IBiometricsOnFingerprintGrabbedRawListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBiometricsOnFingerprintGrabbedRawListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.credenceid.biometrics.Biometrics.OnFingerprintGrabbedRawListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBiometricsOnFingerprintGrabbedRawListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_;
#pragma warning disable 0169
		static Delegate GetOnCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_Handler ()
		{
			if (cb_onCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_ == null)
				cb_onCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_);
			return cb_onCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_;
		}

		static void n_OnCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedRawListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsResultCode> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnCloseFingerprintReader (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_;
		public unsafe void OnCloseFingerprintReader (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode p1)
		{
			if (id_onCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_ == IntPtr.Zero)
				id_onCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_ = JNIEnv.GetMethodID (class_ref, "onCloseFingerprintReader", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Lcom/credenceid/biometrics/Biometrics$CloseReasonCode;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_, __args);
		}

		static Delegate cb_onFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_arrayBLjava_lang_String_arrayBLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_arrayBLjava_lang_String_arrayBLjava_lang_String_Handler ()
		{
			if (cb_onFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_arrayBLjava_lang_String_arrayBLjava_lang_String_ == null)
				cb_onFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_arrayBLjava_lang_String_arrayBLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLLL_V) n_OnFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_arrayBLjava_lang_String_arrayBLjava_lang_String_);
			return cb_onFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_arrayBLjava_lang_String_arrayBLjava_lang_String_;
		}

		static void n_OnFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_arrayBLjava_lang_String_arrayBLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedRawListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsResultCode> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			var p4 = (byte[]) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			__this.OnFingerprintGrabbed (p0, p1, p2, p3, p4, p5);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
		}
#pragma warning restore 0169

		IntPtr id_onFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_arrayBLjava_lang_String_arrayBLjava_lang_String_;
		public unsafe void OnFingerprintGrabbed (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Android.Graphics.Bitmap p1, byte[] p2, string p3, byte[] p4, string p5)
		{
			if (id_onFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_arrayBLjava_lang_String_arrayBLjava_lang_String_ == IntPtr.Zero)
				id_onFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_arrayBLjava_lang_String_arrayBLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onFingerprintGrabbed", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Landroid/graphics/Bitmap;[BLjava/lang/String;[BLjava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			JValue* __args = stackalloc JValue [6];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (native_p4);
			__args [5] = new JValue (native_p5);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_arrayBLjava_lang_String_arrayBLjava_lang_String_, __args);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			JNIEnv.DeleteLocalRef (native_p3);
			if (p4 != null) {
				JNIEnv.CopyArray (native_p4, p4);
				JNIEnv.DeleteLocalRef (native_p4);
			}
			JNIEnv.DeleteLocalRef (native_p5);
		}

	}

	// event args for com.credenceid.biometrics.Biometrics.OnFingerprintGrabbedRawListener.onCloseFingerprintReader
	public partial class RawFingerprintsCloseArgs : global::System.EventArgs {

		public RawFingerprintsCloseArgs (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Credenceid.Biometrics.BiometricsResultCode p0;
		public global::Com.Credenceid.Biometrics.BiometricsResultCode P0 {
			get { return p0; }
		}

		global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode p1;
		public global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode P1 {
			get { return p1; }
		}
	}

	// event args for com.credenceid.biometrics.Biometrics.OnFingerprintGrabbedRawListener.onFingerprintGrabbed
	public partial class RawFingerprintsGrabbedArgs : global::System.EventArgs {

		public RawFingerprintsGrabbedArgs (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Android.Graphics.Bitmap p1, byte[] p2, string p3, byte[] p4, string p5)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
			this.p4 = p4;
			this.p5 = p5;
		}

		global::Com.Credenceid.Biometrics.BiometricsResultCode p0;
		public global::Com.Credenceid.Biometrics.BiometricsResultCode P0 {
			get { return p0; }
		}

		global::Android.Graphics.Bitmap p1;
		public global::Android.Graphics.Bitmap P1 {
			get { return p1; }
		}

		byte[] p2;
		public byte[] P2 {
			get { return p2; }
		}

		string p3;
		public string P3 {
			get { return p3; }
		}

		byte[] p4;
		public byte[] P4 {
			get { return p4; }
		}

		string p5;
		public string P5 {
			get { return p5; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/credenceid/biometrics/Biometrics_OnFingerprintGrabbedRawListenerImplementor")]
	internal sealed partial class IBiometricsOnFingerprintGrabbedRawListenerImplementor : global::Java.Lang.Object, IBiometricsOnFingerprintGrabbedRawListener {

		object sender;

		public IBiometricsOnFingerprintGrabbedRawListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/credenceid/biometrics/Biometrics_OnFingerprintGrabbedRawListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<RawFingerprintsCloseArgs> OnCloseFingerprintReaderHandler;
#pragma warning restore 0649

		public void OnCloseFingerprintReader (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode p1)
		{
			var __h = OnCloseFingerprintReaderHandler;
			if (__h != null)
				__h (sender, new RawFingerprintsCloseArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<RawFingerprintsGrabbedArgs> OnFingerprintGrabbedHandler;
#pragma warning restore 0649

		public void OnFingerprintGrabbed (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Android.Graphics.Bitmap p1, byte[] p2, string p3, byte[] p4, string p5)
		{
			var __h = OnFingerprintGrabbedHandler;
			if (__h != null)
				__h (sender, new RawFingerprintsGrabbedArgs (p0, p1, p2, p3, p4, p5));
		}

		internal static bool __IsEmpty (IBiometricsOnFingerprintGrabbedRawListenerImplementor value)
		{
			return value.OnCloseFingerprintReaderHandler == null && value.OnFingerprintGrabbedHandler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.OnFingerprintGrabbedWSQListener']"
	[Register ("com/credenceid/biometrics/Biometrics$OnFingerprintGrabbedWSQListener", "", "Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedWSQListenerInvoker")]
	public partial interface IBiometricsOnFingerprintGrabbedWSQListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.OnFingerprintGrabbedWSQListener']/method[@name='onCloseFingerprintReader' and count(parameter)=2 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ResultCode'] and parameter[2][@type='com.credenceid.biometrics.Biometrics.CloseReasonCode']]"
		[Register ("onCloseFingerprintReader", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Lcom/credenceid/biometrics/Biometrics$CloseReasonCode;)V", "GetOnCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_Handler:Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedWSQListenerInvoker, CredenceBindings")]
		void OnCloseFingerprintReader (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.OnFingerprintGrabbedWSQListener']/method[@name='onFingerprintGrabbed' and count(parameter)=7 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ResultCode'] and parameter[2][@type='android.graphics.Bitmap'] and parameter[3][@type='byte[]'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='int']]"
		[Register ("onFingerprintGrabbed", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Landroid/graphics/Bitmap;[BLjava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V", "GetOnFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_arrayBLjava_lang_String_Ljava_lang_String_Ljava_lang_String_IHandler:Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedWSQListenerInvoker, CredenceBindings")]
		void OnFingerprintGrabbed (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Android.Graphics.Bitmap p1, byte[] p2, string p3, string p4, string p5, int p6);

	}

	[global::Android.Runtime.Register ("com/credenceid/biometrics/Biometrics$OnFingerprintGrabbedWSQListener", DoNotGenerateAcw=true)]
	internal partial class IBiometricsOnFingerprintGrabbedWSQListenerInvoker : global::Java.Lang.Object, IBiometricsOnFingerprintGrabbedWSQListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/credenceid/biometrics/Biometrics$OnFingerprintGrabbedWSQListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBiometricsOnFingerprintGrabbedWSQListenerInvoker); }
		}

		IntPtr class_ref;

		public static IBiometricsOnFingerprintGrabbedWSQListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBiometricsOnFingerprintGrabbedWSQListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.credenceid.biometrics.Biometrics.OnFingerprintGrabbedWSQListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBiometricsOnFingerprintGrabbedWSQListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_;
#pragma warning disable 0169
		static Delegate GetOnCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_Handler ()
		{
			if (cb_onCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_ == null)
				cb_onCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_);
			return cb_onCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_;
		}

		static void n_OnCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedWSQListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsResultCode> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnCloseFingerprintReader (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_;
		public unsafe void OnCloseFingerprintReader (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode p1)
		{
			if (id_onCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_ == IntPtr.Zero)
				id_onCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_ = JNIEnv.GetMethodID (class_ref, "onCloseFingerprintReader", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Lcom/credenceid/biometrics/Biometrics$CloseReasonCode;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_, __args);
		}

		static Delegate cb_onFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_arrayBLjava_lang_String_Ljava_lang_String_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetOnFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_arrayBLjava_lang_String_Ljava_lang_String_Ljava_lang_String_IHandler ()
		{
			if (cb_onFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_arrayBLjava_lang_String_Ljava_lang_String_Ljava_lang_String_I == null)
				cb_onFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_arrayBLjava_lang_String_Ljava_lang_String_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLLLI_V) n_OnFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_arrayBLjava_lang_String_Ljava_lang_String_Ljava_lang_String_I);
			return cb_onFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_arrayBLjava_lang_String_Ljava_lang_String_Ljava_lang_String_I;
		}

		static void n_OnFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_arrayBLjava_lang_String_Ljava_lang_String_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5, int p6)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedWSQListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsResultCode> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			var p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			var p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			__this.OnFingerprintGrabbed (p0, p1, p2, p3, p4, p5, p6);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		IntPtr id_onFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_arrayBLjava_lang_String_Ljava_lang_String_Ljava_lang_String_I;
		public unsafe void OnFingerprintGrabbed (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Android.Graphics.Bitmap p1, byte[] p2, string p3, string p4, string p5, int p6)
		{
			if (id_onFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_arrayBLjava_lang_String_Ljava_lang_String_Ljava_lang_String_I == IntPtr.Zero)
				id_onFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_arrayBLjava_lang_String_Ljava_lang_String_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "onFingerprintGrabbed", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Landroid/graphics/Bitmap;[BLjava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			JValue* __args = stackalloc JValue [7];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (native_p4);
			__args [5] = new JValue (native_p5);
			__args [6] = new JValue (p6);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_arrayBLjava_lang_String_Ljava_lang_String_Ljava_lang_String_I, __args);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			JNIEnv.DeleteLocalRef (native_p3);
			JNIEnv.DeleteLocalRef (native_p4);
			JNIEnv.DeleteLocalRef (native_p5);
		}

	}

	// event args for com.credenceid.biometrics.Biometrics.OnFingerprintGrabbedWSQListener.onCloseFingerprintReader
	public partial class WsqFingerprintsCloseArgs : global::System.EventArgs {

		public WsqFingerprintsCloseArgs (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Credenceid.Biometrics.BiometricsResultCode p0;
		public global::Com.Credenceid.Biometrics.BiometricsResultCode P0 {
			get { return p0; }
		}

		global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode p1;
		public global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode P1 {
			get { return p1; }
		}
	}

	// event args for com.credenceid.biometrics.Biometrics.OnFingerprintGrabbedWSQListener.onFingerprintGrabbed
	public partial class WsqFingerprintsGrabbedArgs : global::System.EventArgs {

		public WsqFingerprintsGrabbedArgs (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Android.Graphics.Bitmap p1, byte[] p2, string p3, string p4, string p5, int p6)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
			this.p4 = p4;
			this.p5 = p5;
			this.p6 = p6;
		}

		global::Com.Credenceid.Biometrics.BiometricsResultCode p0;
		public global::Com.Credenceid.Biometrics.BiometricsResultCode P0 {
			get { return p0; }
		}

		global::Android.Graphics.Bitmap p1;
		public global::Android.Graphics.Bitmap P1 {
			get { return p1; }
		}

		byte[] p2;
		public byte[] P2 {
			get { return p2; }
		}

		string p3;
		public string P3 {
			get { return p3; }
		}

		string p4;
		public string P4 {
			get { return p4; }
		}

		string p5;
		public string P5 {
			get { return p5; }
		}

		int p6;
		public int P6 {
			get { return p6; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/credenceid/biometrics/Biometrics_OnFingerprintGrabbedWSQListenerImplementor")]
	internal sealed partial class IBiometricsOnFingerprintGrabbedWSQListenerImplementor : global::Java.Lang.Object, IBiometricsOnFingerprintGrabbedWSQListener {

		object sender;

		public IBiometricsOnFingerprintGrabbedWSQListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/credenceid/biometrics/Biometrics_OnFingerprintGrabbedWSQListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<WsqFingerprintsCloseArgs> OnCloseFingerprintReaderHandler;
#pragma warning restore 0649

		public void OnCloseFingerprintReader (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode p1)
		{
			var __h = OnCloseFingerprintReaderHandler;
			if (__h != null)
				__h (sender, new WsqFingerprintsCloseArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<WsqFingerprintsGrabbedArgs> OnFingerprintGrabbedHandler;
#pragma warning restore 0649

		public void OnFingerprintGrabbed (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Android.Graphics.Bitmap p1, byte[] p2, string p3, string p4, string p5, int p6)
		{
			var __h = OnFingerprintGrabbedHandler;
			if (__h != null)
				__h (sender, new WsqFingerprintsGrabbedArgs (p0, p1, p2, p3, p4, p5, p6));
		}

		internal static bool __IsEmpty (IBiometricsOnFingerprintGrabbedWSQListenerImplementor value)
		{
			return value.OnCloseFingerprintReaderHandler == null && value.OnFingerprintGrabbedHandler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.OnFingerQualityListener']"
	[Register ("com/credenceid/biometrics/Biometrics$OnFingerQualityListener", "", "Com.Credenceid.Biometrics.IBiometricsOnFingerQualityListenerInvoker")]
	public partial interface IBiometricsOnFingerQualityListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.OnFingerQualityListener']/method[@name='onGetFingerQuality' and count(parameter)=2 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ResultCode'] and parameter[2][@type='com.credenceid.biometrics.FingerQuality']]"
		[Register ("onGetFingerQuality", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Lcom/credenceid/biometrics/FingerQuality;)V", "GetOnGetFingerQuality_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_FingerQuality_Handler:Com.Credenceid.Biometrics.IBiometricsOnFingerQualityListenerInvoker, CredenceBindings")]
		void OnGetFingerQuality (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Com.Credenceid.Biometrics.FingerQuality p1);

	}

	[global::Android.Runtime.Register ("com/credenceid/biometrics/Biometrics$OnFingerQualityListener", DoNotGenerateAcw=true)]
	internal partial class IBiometricsOnFingerQualityListenerInvoker : global::Java.Lang.Object, IBiometricsOnFingerQualityListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/credenceid/biometrics/Biometrics$OnFingerQualityListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBiometricsOnFingerQualityListenerInvoker); }
		}

		IntPtr class_ref;

		public static IBiometricsOnFingerQualityListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBiometricsOnFingerQualityListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.credenceid.biometrics.Biometrics.OnFingerQualityListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBiometricsOnFingerQualityListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onGetFingerQuality_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_FingerQuality_;
#pragma warning disable 0169
		static Delegate GetOnGetFingerQuality_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_FingerQuality_Handler ()
		{
			if (cb_onGetFingerQuality_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_FingerQuality_ == null)
				cb_onGetFingerQuality_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_FingerQuality_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnGetFingerQuality_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_FingerQuality_);
			return cb_onGetFingerQuality_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_FingerQuality_;
		}

		static void n_OnGetFingerQuality_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_FingerQuality_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnFingerQualityListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsResultCode> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.FingerQuality> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnGetFingerQuality (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onGetFingerQuality_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_FingerQuality_;
		public unsafe void OnGetFingerQuality (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Com.Credenceid.Biometrics.FingerQuality p1)
		{
			if (id_onGetFingerQuality_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_FingerQuality_ == IntPtr.Zero)
				id_onGetFingerQuality_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_FingerQuality_ = JNIEnv.GetMethodID (class_ref, "onGetFingerQuality", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Lcom/credenceid/biometrics/FingerQuality;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onGetFingerQuality_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_FingerQuality_, __args);
		}

	}

	// event args for com.credenceid.biometrics.Biometrics.OnFingerQualityListener.onGetFingerQuality
	public partial class BiometricsOnFingerQualityEventArgs : global::System.EventArgs {

		public BiometricsOnFingerQualityEventArgs (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Com.Credenceid.Biometrics.FingerQuality p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Credenceid.Biometrics.BiometricsResultCode p0;
		public global::Com.Credenceid.Biometrics.BiometricsResultCode P0 {
			get { return p0; }
		}

		global::Com.Credenceid.Biometrics.FingerQuality p1;
		public global::Com.Credenceid.Biometrics.FingerQuality P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/credenceid/biometrics/Biometrics_OnFingerQualityListenerImplementor")]
	internal sealed partial class IBiometricsOnFingerQualityListenerImplementor : global::Java.Lang.Object, IBiometricsOnFingerQualityListener {

		object sender;

		public IBiometricsOnFingerQualityListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/credenceid/biometrics/Biometrics_OnFingerQualityListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<BiometricsOnFingerQualityEventArgs> Handler;
#pragma warning restore 0649

		public void OnGetFingerQuality (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Com.Credenceid.Biometrics.FingerQuality p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new BiometricsOnFingerQualityEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IBiometricsOnFingerQualityListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.OnFMDToCCFConversionListener']"
	[Register ("com/credenceid/biometrics/Biometrics$OnFMDToCCFConversionListener", "", "Com.Credenceid.Biometrics.IBiometricsOnFMDToCCFConversionListenerInvoker")]
	public partial interface IBiometricsOnFMDToCCFConversionListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.OnFMDToCCFConversionListener']/method[@name='onFMDToCCFConversion' and count(parameter)=2 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ResultCode'] and parameter[2][@type='byte[]']]"
		[Register ("onFMDToCCFConversion", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;[B)V", "GetOnFMDToCCFConversion_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayBHandler:Com.Credenceid.Biometrics.IBiometricsOnFMDToCCFConversionListenerInvoker, CredenceBindings")]
		void OnFMDToCCFConversion (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, byte[] p1);

	}

	[global::Android.Runtime.Register ("com/credenceid/biometrics/Biometrics$OnFMDToCCFConversionListener", DoNotGenerateAcw=true)]
	internal partial class IBiometricsOnFMDToCCFConversionListenerInvoker : global::Java.Lang.Object, IBiometricsOnFMDToCCFConversionListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/credenceid/biometrics/Biometrics$OnFMDToCCFConversionListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBiometricsOnFMDToCCFConversionListenerInvoker); }
		}

		IntPtr class_ref;

		public static IBiometricsOnFMDToCCFConversionListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBiometricsOnFMDToCCFConversionListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.credenceid.biometrics.Biometrics.OnFMDToCCFConversionListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBiometricsOnFMDToCCFConversionListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onFMDToCCFConversion_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayB;
#pragma warning disable 0169
		static Delegate GetOnFMDToCCFConversion_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayBHandler ()
		{
			if (cb_onFMDToCCFConversion_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayB == null)
				cb_onFMDToCCFConversion_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnFMDToCCFConversion_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayB);
			return cb_onFMDToCCFConversion_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayB;
		}

		static void n_OnFMDToCCFConversion_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnFMDToCCFConversionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsResultCode> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnFMDToCCFConversion (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		IntPtr id_onFMDToCCFConversion_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayB;
		public unsafe void OnFMDToCCFConversion (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, byte[] p1)
		{
			if (id_onFMDToCCFConversion_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayB == IntPtr.Zero)
				id_onFMDToCCFConversion_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayB = JNIEnv.GetMethodID (class_ref, "onFMDToCCFConversion", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;[B)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFMDToCCFConversion_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayB, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}

	// event args for com.credenceid.biometrics.Biometrics.OnFMDToCCFConversionListener.onFMDToCCFConversion
	public partial class BiometricsOnFMDToCCFConversionEventArgs : global::System.EventArgs {

		public BiometricsOnFMDToCCFConversionEventArgs (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, byte[] p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Credenceid.Biometrics.BiometricsResultCode p0;
		public global::Com.Credenceid.Biometrics.BiometricsResultCode P0 {
			get { return p0; }
		}

		byte[] p1;
		public byte[] P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/credenceid/biometrics/Biometrics_OnFMDToCCFConversionListenerImplementor")]
	internal sealed partial class IBiometricsOnFMDToCCFConversionListenerImplementor : global::Java.Lang.Object, IBiometricsOnFMDToCCFConversionListener {

		object sender;

		public IBiometricsOnFMDToCCFConversionListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/credenceid/biometrics/Biometrics_OnFMDToCCFConversionListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<BiometricsOnFMDToCCFConversionEventArgs> Handler;
#pragma warning restore 0649

		public void OnFMDToCCFConversion (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, byte[] p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new BiometricsOnFMDToCCFConversionEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IBiometricsOnFMDToCCFConversionListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.OnGetFingerQualityListener']"
	[Register ("com/credenceid/biometrics/Biometrics$OnGetFingerQualityListener", "", "Com.Credenceid.Biometrics.IBiometricsOnGetFingerQualityListenerInvoker")]
	public partial interface IBiometricsOnGetFingerQualityListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.OnGetFingerQualityListener']/method[@name='onGetFingerQuality' and count(parameter)=2 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ResultCode'] and parameter[2][@type='int']]"
		[Register ("onGetFingerQuality", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;I)V", "GetOnGetFingerQuality_Lcom_credenceid_biometrics_Biometrics_ResultCode_IHandler:Com.Credenceid.Biometrics.IBiometricsOnGetFingerQualityListenerInvoker, CredenceBindings")]
		void OnGetFingerQuality (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, int p1);

	}

	[global::Android.Runtime.Register ("com/credenceid/biometrics/Biometrics$OnGetFingerQualityListener", DoNotGenerateAcw=true)]
	internal partial class IBiometricsOnGetFingerQualityListenerInvoker : global::Java.Lang.Object, IBiometricsOnGetFingerQualityListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/credenceid/biometrics/Biometrics$OnGetFingerQualityListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBiometricsOnGetFingerQualityListenerInvoker); }
		}

		IntPtr class_ref;

		public static IBiometricsOnGetFingerQualityListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBiometricsOnGetFingerQualityListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.credenceid.biometrics.Biometrics.OnGetFingerQualityListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBiometricsOnGetFingerQualityListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onGetFingerQuality_Lcom_credenceid_biometrics_Biometrics_ResultCode_I;
#pragma warning disable 0169
		static Delegate GetOnGetFingerQuality_Lcom_credenceid_biometrics_Biometrics_ResultCode_IHandler ()
		{
			if (cb_onGetFingerQuality_Lcom_credenceid_biometrics_Biometrics_ResultCode_I == null)
				cb_onGetFingerQuality_Lcom_credenceid_biometrics_Biometrics_ResultCode_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_OnGetFingerQuality_Lcom_credenceid_biometrics_Biometrics_ResultCode_I);
			return cb_onGetFingerQuality_Lcom_credenceid_biometrics_Biometrics_ResultCode_I;
		}

		static void n_OnGetFingerQuality_Lcom_credenceid_biometrics_Biometrics_ResultCode_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnGetFingerQualityListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsResultCode> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnGetFingerQuality (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onGetFingerQuality_Lcom_credenceid_biometrics_Biometrics_ResultCode_I;
		public unsafe void OnGetFingerQuality (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, int p1)
		{
			if (id_onGetFingerQuality_Lcom_credenceid_biometrics_Biometrics_ResultCode_I == IntPtr.Zero)
				id_onGetFingerQuality_Lcom_credenceid_biometrics_Biometrics_ResultCode_I = JNIEnv.GetMethodID (class_ref, "onGetFingerQuality", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;I)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onGetFingerQuality_Lcom_credenceid_biometrics_Biometrics_ResultCode_I, __args);
		}

	}

	// event args for com.credenceid.biometrics.Biometrics.OnGetFingerQualityListener.onGetFingerQuality
	public partial class BiometricsOnGetFingerQualityEventArgs : global::System.EventArgs {

		public BiometricsOnGetFingerQualityEventArgs (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, int p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Credenceid.Biometrics.BiometricsResultCode p0;
		public global::Com.Credenceid.Biometrics.BiometricsResultCode P0 {
			get { return p0; }
		}

		int p1;
		public int P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/credenceid/biometrics/Biometrics_OnGetFingerQualityListenerImplementor")]
	internal sealed partial class IBiometricsOnGetFingerQualityListenerImplementor : global::Java.Lang.Object, IBiometricsOnGetFingerQualityListener {

		object sender;

		public IBiometricsOnGetFingerQualityListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/credenceid/biometrics/Biometrics_OnGetFingerQualityListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<BiometricsOnGetFingerQualityEventArgs> Handler;
#pragma warning restore 0649

		public void OnGetFingerQuality (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, int p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new BiometricsOnGetFingerQualityEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IBiometricsOnGetFingerQualityListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.OnGetProviderDetailsListener']"
	[Register ("com/credenceid/biometrics/Biometrics$OnGetProviderDetailsListener", "", "Com.Credenceid.Biometrics.IBiometricsOnGetProviderDetailsListenerInvoker")]
	public partial interface IBiometricsOnGetProviderDetailsListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.OnGetProviderDetailsListener']/method[@name='onGetProviderDetails' and count(parameter)=2 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ResultCode'] and parameter[2][@type='java.lang.String']]"
		[Register ("onGetProviderDetails", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Ljava/lang/String;)V", "GetOnGetProviderDetails_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_Handler:Com.Credenceid.Biometrics.IBiometricsOnGetProviderDetailsListenerInvoker, CredenceBindings")]
		void OnGetProviderDetails (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, string p1);

	}

	[global::Android.Runtime.Register ("com/credenceid/biometrics/Biometrics$OnGetProviderDetailsListener", DoNotGenerateAcw=true)]
	internal partial class IBiometricsOnGetProviderDetailsListenerInvoker : global::Java.Lang.Object, IBiometricsOnGetProviderDetailsListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/credenceid/biometrics/Biometrics$OnGetProviderDetailsListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBiometricsOnGetProviderDetailsListenerInvoker); }
		}

		IntPtr class_ref;

		public static IBiometricsOnGetProviderDetailsListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBiometricsOnGetProviderDetailsListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.credenceid.biometrics.Biometrics.OnGetProviderDetailsListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBiometricsOnGetProviderDetailsListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onGetProviderDetails_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnGetProviderDetails_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_Handler ()
		{
			if (cb_onGetProviderDetails_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_ == null)
				cb_onGetProviderDetails_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnGetProviderDetails_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_);
			return cb_onGetProviderDetails_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_;
		}

		static void n_OnGetProviderDetails_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnGetProviderDetailsListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsResultCode> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnGetProviderDetails (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onGetProviderDetails_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_;
		public unsafe void OnGetProviderDetails (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, string p1)
		{
			if (id_onGetProviderDetails_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_ == IntPtr.Zero)
				id_onGetProviderDetails_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onGetProviderDetails", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onGetProviderDetails_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

	// event args for com.credenceid.biometrics.Biometrics.OnGetProviderDetailsListener.onGetProviderDetails
	public partial class BiometricsOnGetProviderDetailsEventArgs : global::System.EventArgs {

		public BiometricsOnGetProviderDetailsEventArgs (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, string p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Credenceid.Biometrics.BiometricsResultCode p0;
		public global::Com.Credenceid.Biometrics.BiometricsResultCode P0 {
			get { return p0; }
		}

		string p1;
		public string P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/credenceid/biometrics/Biometrics_OnGetProviderDetailsListenerImplementor")]
	internal sealed partial class IBiometricsOnGetProviderDetailsListenerImplementor : global::Java.Lang.Object, IBiometricsOnGetProviderDetailsListener {

		object sender;

		public IBiometricsOnGetProviderDetailsListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/credenceid/biometrics/Biometrics_OnGetProviderDetailsListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<BiometricsOnGetProviderDetailsEventArgs> Handler;
#pragma warning restore 0649

		public void OnGetProviderDetails (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, string p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new BiometricsOnGetProviderDetailsEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IBiometricsOnGetProviderDetailsListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.OnInitializedListener']"
	[Register ("com/credenceid/biometrics/Biometrics$OnInitializedListener", "", "Com.Credenceid.Biometrics.IBiometricsOnInitializedListenerInvoker")]
	public partial interface IBiometricsOnInitializedListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.OnInitializedListener']/method[@name='onInitialized' and count(parameter)=3 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ResultCode'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("onInitialized", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Ljava/lang/String;Ljava/lang/String;)V", "GetOnInitialized_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_Ljava_lang_String_Handler:Com.Credenceid.Biometrics.IBiometricsOnInitializedListenerInvoker, CredenceBindings")]
		void OnInitialized (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, string p1, string p2);

	}

	[global::Android.Runtime.Register ("com/credenceid/biometrics/Biometrics$OnInitializedListener", DoNotGenerateAcw=true)]
	internal partial class IBiometricsOnInitializedListenerInvoker : global::Java.Lang.Object, IBiometricsOnInitializedListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/credenceid/biometrics/Biometrics$OnInitializedListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBiometricsOnInitializedListenerInvoker); }
		}

		IntPtr class_ref;

		public static IBiometricsOnInitializedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBiometricsOnInitializedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.credenceid.biometrics.Biometrics.OnInitializedListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBiometricsOnInitializedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onInitialized_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnInitialized_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_onInitialized_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_onInitialized_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_OnInitialized_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_Ljava_lang_String_);
			return cb_onInitialized_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_OnInitialized_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnInitializedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsResultCode> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnInitialized (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onInitialized_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void OnInitialized (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, string p1, string p2)
		{
			if (id_onInitialized_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_onInitialized_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onInitialized", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInitialized_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

	}

	// event args for com.credenceid.biometrics.Biometrics.OnInitializedListener.onInitialized
	public partial class BiometricsOnInitializedEventArgs : global::System.EventArgs {

		public BiometricsOnInitializedEventArgs (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, string p1, string p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		global::Com.Credenceid.Biometrics.BiometricsResultCode p0;
		public global::Com.Credenceid.Biometrics.BiometricsResultCode P0 {
			get { return p0; }
		}

		string p1;
		public string P1 {
			get { return p1; }
		}

		string p2;
		public string P2 {
			get { return p2; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/credenceid/biometrics/Biometrics_OnInitializedListenerImplementor")]
	internal sealed partial class IBiometricsOnInitializedListenerImplementor : global::Java.Lang.Object, IBiometricsOnInitializedListener {

		object sender;

		public IBiometricsOnInitializedListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/credenceid/biometrics/Biometrics_OnInitializedListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<BiometricsOnInitializedEventArgs> Handler;
#pragma warning restore 0649

		public void OnInitialized (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, string p1, string p2)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new BiometricsOnInitializedEventArgs (p0, p1, p2));
		}

		internal static bool __IsEmpty (IBiometricsOnInitializedListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.OnIrisesCapturedListener']"
	[Register ("com/credenceid/biometrics/Biometrics$OnIrisesCapturedListener", "", "Com.Credenceid.Biometrics.IBiometricsOnIrisesCapturedListenerInvoker")]
	public partial interface IBiometricsOnIrisesCapturedListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.OnIrisesCapturedListener']/method[@name='onCloseIrisScanner' and count(parameter)=2 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ResultCode'] and parameter[2][@type='com.credenceid.biometrics.Biometrics.CloseReasonCode']]"
		[Register ("onCloseIrisScanner", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Lcom/credenceid/biometrics/Biometrics$CloseReasonCode;)V", "GetOnCloseIrisScanner_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_Handler:Com.Credenceid.Biometrics.IBiometricsOnIrisesCapturedListenerInvoker, CredenceBindings")]
		void OnCloseIrisScanner (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.OnIrisesCapturedListener']/method[@name='onIrisesCaptured' and count(parameter)=6 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ResultCode'] and parameter[2][@type='android.graphics.Bitmap'] and parameter[3][@type='android.graphics.Bitmap'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String']]"
		[Register ("onIrisesCaptured", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetOnIrisesCaptured_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Com.Credenceid.Biometrics.IBiometricsOnIrisesCapturedListenerInvoker, CredenceBindings")]
		void OnIrisesCaptured (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Android.Graphics.Bitmap p1, global::Android.Graphics.Bitmap p2, string p3, string p4, string p5);

	}

	[global::Android.Runtime.Register ("com/credenceid/biometrics/Biometrics$OnIrisesCapturedListener", DoNotGenerateAcw=true)]
	internal partial class IBiometricsOnIrisesCapturedListenerInvoker : global::Java.Lang.Object, IBiometricsOnIrisesCapturedListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/credenceid/biometrics/Biometrics$OnIrisesCapturedListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBiometricsOnIrisesCapturedListenerInvoker); }
		}

		IntPtr class_ref;

		public static IBiometricsOnIrisesCapturedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBiometricsOnIrisesCapturedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.credenceid.biometrics.Biometrics.OnIrisesCapturedListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBiometricsOnIrisesCapturedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onCloseIrisScanner_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_;
#pragma warning disable 0169
		static Delegate GetOnCloseIrisScanner_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_Handler ()
		{
			if (cb_onCloseIrisScanner_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_ == null)
				cb_onCloseIrisScanner_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnCloseIrisScanner_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_);
			return cb_onCloseIrisScanner_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_;
		}

		static void n_OnCloseIrisScanner_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnIrisesCapturedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsResultCode> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnCloseIrisScanner (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onCloseIrisScanner_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_;
		public unsafe void OnCloseIrisScanner (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode p1)
		{
			if (id_onCloseIrisScanner_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_ == IntPtr.Zero)
				id_onCloseIrisScanner_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_ = JNIEnv.GetMethodID (class_ref, "onCloseIrisScanner", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Lcom/credenceid/biometrics/Biometrics$CloseReasonCode;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCloseIrisScanner_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_, __args);
		}

		static Delegate cb_onIrisesCaptured_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnIrisesCaptured_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_onIrisesCaptured_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_onIrisesCaptured_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLLL_V) n_OnIrisesCaptured_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_onIrisesCaptured_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_OnIrisesCaptured_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnIrisesCapturedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsResultCode> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			var p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			var p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			__this.OnIrisesCaptured (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		IntPtr id_onIrisesCaptured_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void OnIrisesCaptured (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Android.Graphics.Bitmap p1, global::Android.Graphics.Bitmap p2, string p3, string p4, string p5)
		{
			if (id_onIrisesCaptured_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_onIrisesCaptured_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onIrisesCaptured", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			JValue* __args = stackalloc JValue [6];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (native_p4);
			__args [5] = new JValue (native_p5);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onIrisesCaptured_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p3);
			JNIEnv.DeleteLocalRef (native_p4);
			JNIEnv.DeleteLocalRef (native_p5);
		}

	}

	// event args for com.credenceid.biometrics.Biometrics.OnIrisesCapturedListener.onCloseIrisScanner
	public partial class CloseIrisScannerEventArgs : global::System.EventArgs {

		public CloseIrisScannerEventArgs (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Credenceid.Biometrics.BiometricsResultCode p0;
		public global::Com.Credenceid.Biometrics.BiometricsResultCode P0 {
			get { return p0; }
		}

		global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode p1;
		public global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode P1 {
			get { return p1; }
		}
	}

	// event args for com.credenceid.biometrics.Biometrics.OnIrisesCapturedListener.onIrisesCaptured
	public partial class IrisesCapturedEventArgs : global::System.EventArgs {

		public IrisesCapturedEventArgs (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Android.Graphics.Bitmap p1, global::Android.Graphics.Bitmap p2, string p3, string p4, string p5)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
			this.p4 = p4;
			this.p5 = p5;
		}

		global::Com.Credenceid.Biometrics.BiometricsResultCode p0;
		public global::Com.Credenceid.Biometrics.BiometricsResultCode P0 {
			get { return p0; }
		}

		global::Android.Graphics.Bitmap p1;
		public global::Android.Graphics.Bitmap P1 {
			get { return p1; }
		}

		global::Android.Graphics.Bitmap p2;
		public global::Android.Graphics.Bitmap P2 {
			get { return p2; }
		}

		string p3;
		public string P3 {
			get { return p3; }
		}

		string p4;
		public string P4 {
			get { return p4; }
		}

		string p5;
		public string P5 {
			get { return p5; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/credenceid/biometrics/Biometrics_OnIrisesCapturedListenerImplementor")]
	internal sealed partial class IBiometricsOnIrisesCapturedListenerImplementor : global::Java.Lang.Object, IBiometricsOnIrisesCapturedListener {

		object sender;

		public IBiometricsOnIrisesCapturedListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/credenceid/biometrics/Biometrics_OnIrisesCapturedListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<CloseIrisScannerEventArgs> OnCloseIrisScannerHandler;
#pragma warning restore 0649

		public void OnCloseIrisScanner (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode p1)
		{
			var __h = OnCloseIrisScannerHandler;
			if (__h != null)
				__h (sender, new CloseIrisScannerEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<IrisesCapturedEventArgs> OnIrisesCapturedHandler;
#pragma warning restore 0649

		public void OnIrisesCaptured (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Android.Graphics.Bitmap p1, global::Android.Graphics.Bitmap p2, string p3, string p4, string p5)
		{
			var __h = OnIrisesCapturedHandler;
			if (__h != null)
				__h (sender, new IrisesCapturedEventArgs (p0, p1, p2, p3, p4, p5));
		}

		internal static bool __IsEmpty (IBiometricsOnIrisesCapturedListenerImplementor value)
		{
			return value.OnCloseIrisScannerHandler == null && value.OnIrisesCapturedHandler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.OnMobileDataChangedListener']"
	[Register ("com/credenceid/biometrics/Biometrics$OnMobileDataChangedListener", "", "Com.Credenceid.Biometrics.IBiometricsOnMobileDataChangedListenerInvoker")]
	public partial interface IBiometricsOnMobileDataChangedListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.OnMobileDataChangedListener']/method[@name='onMobileDataChange' and count(parameter)=2 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ResultCode'] and parameter[2][@type='java.lang.String']]"
		[Register ("onMobileDataChange", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Ljava/lang/String;)V", "GetOnMobileDataChange_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_Handler:Com.Credenceid.Biometrics.IBiometricsOnMobileDataChangedListenerInvoker, CredenceBindings")]
		void OnMobileDataChange (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, string p1);

	}

	[global::Android.Runtime.Register ("com/credenceid/biometrics/Biometrics$OnMobileDataChangedListener", DoNotGenerateAcw=true)]
	internal partial class IBiometricsOnMobileDataChangedListenerInvoker : global::Java.Lang.Object, IBiometricsOnMobileDataChangedListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/credenceid/biometrics/Biometrics$OnMobileDataChangedListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBiometricsOnMobileDataChangedListenerInvoker); }
		}

		IntPtr class_ref;

		public static IBiometricsOnMobileDataChangedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBiometricsOnMobileDataChangedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.credenceid.biometrics.Biometrics.OnMobileDataChangedListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBiometricsOnMobileDataChangedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onMobileDataChange_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnMobileDataChange_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_Handler ()
		{
			if (cb_onMobileDataChange_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_ == null)
				cb_onMobileDataChange_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnMobileDataChange_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_);
			return cb_onMobileDataChange_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_;
		}

		static void n_OnMobileDataChange_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnMobileDataChangedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsResultCode> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnMobileDataChange (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onMobileDataChange_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_;
		public unsafe void OnMobileDataChange (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, string p1)
		{
			if (id_onMobileDataChange_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_ == IntPtr.Zero)
				id_onMobileDataChange_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onMobileDataChange", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMobileDataChange_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

	// event args for com.credenceid.biometrics.Biometrics.OnMobileDataChangedListener.onMobileDataChange
	public partial class BiometricsOnMobileDataChangedEventArgs : global::System.EventArgs {

		public BiometricsOnMobileDataChangedEventArgs (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, string p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Credenceid.Biometrics.BiometricsResultCode p0;
		public global::Com.Credenceid.Biometrics.BiometricsResultCode P0 {
			get { return p0; }
		}

		string p1;
		public string P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/credenceid/biometrics/Biometrics_OnMobileDataChangedListenerImplementor")]
	internal sealed partial class IBiometricsOnMobileDataChangedListenerImplementor : global::Java.Lang.Object, IBiometricsOnMobileDataChangedListener {

		object sender;

		public IBiometricsOnMobileDataChangedListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/credenceid/biometrics/Biometrics_OnMobileDataChangedListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<BiometricsOnMobileDataChangedEventArgs> Handler;
#pragma warning restore 0649

		public void OnMobileDataChange (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, string p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new BiometricsOnMobileDataChangedEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IBiometricsOnMobileDataChangedListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.OnMRZDocumentStatusListener']"
	[Register ("com/credenceid/biometrics/Biometrics$OnMRZDocumentStatusListener", "", "Com.Credenceid.Biometrics.IBiometricsOnMRZDocumentStatusListenerInvoker")]
	public partial interface IBiometricsOnMRZDocumentStatusListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.OnMRZDocumentStatusListener']/method[@name='onMRZDocumentStatusChange' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("onMRZDocumentStatusChange", "(II)V", "GetOnMRZDocumentStatusChange_IIHandler:Com.Credenceid.Biometrics.IBiometricsOnMRZDocumentStatusListenerInvoker, CredenceBindings")]
		void OnMRZDocumentStatusChange (int p0, int p1);

	}

	[global::Android.Runtime.Register ("com/credenceid/biometrics/Biometrics$OnMRZDocumentStatusListener", DoNotGenerateAcw=true)]
	internal partial class IBiometricsOnMRZDocumentStatusListenerInvoker : global::Java.Lang.Object, IBiometricsOnMRZDocumentStatusListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/credenceid/biometrics/Biometrics$OnMRZDocumentStatusListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBiometricsOnMRZDocumentStatusListenerInvoker); }
		}

		IntPtr class_ref;

		public static IBiometricsOnMRZDocumentStatusListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBiometricsOnMRZDocumentStatusListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.credenceid.biometrics.Biometrics.OnMRZDocumentStatusListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBiometricsOnMRZDocumentStatusListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onMRZDocumentStatusChange_II;
#pragma warning disable 0169
		static Delegate GetOnMRZDocumentStatusChange_IIHandler ()
		{
			if (cb_onMRZDocumentStatusChange_II == null)
				cb_onMRZDocumentStatusChange_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_V) n_OnMRZDocumentStatusChange_II);
			return cb_onMRZDocumentStatusChange_II;
		}

		static void n_OnMRZDocumentStatusChange_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnMRZDocumentStatusListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnMRZDocumentStatusChange (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onMRZDocumentStatusChange_II;
		public unsafe void OnMRZDocumentStatusChange (int p0, int p1)
		{
			if (id_onMRZDocumentStatusChange_II == IntPtr.Zero)
				id_onMRZDocumentStatusChange_II = JNIEnv.GetMethodID (class_ref, "onMRZDocumentStatusChange", "(II)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMRZDocumentStatusChange_II, __args);
		}

	}

	// event args for com.credenceid.biometrics.Biometrics.OnMRZDocumentStatusListener.onMRZDocumentStatusChange
	public partial class BiometricsOnMRZDocumentStatusEventArgs : global::System.EventArgs {

		public BiometricsOnMRZDocumentStatusEventArgs (int p0, int p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}

		int p1;
		public int P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/credenceid/biometrics/Biometrics_OnMRZDocumentStatusListenerImplementor")]
	internal sealed partial class IBiometricsOnMRZDocumentStatusListenerImplementor : global::Java.Lang.Object, IBiometricsOnMRZDocumentStatusListener {

		object sender;

		public IBiometricsOnMRZDocumentStatusListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/credenceid/biometrics/Biometrics_OnMRZDocumentStatusListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<BiometricsOnMRZDocumentStatusEventArgs> Handler;
#pragma warning restore 0649

		public void OnMRZDocumentStatusChange (int p0, int p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new BiometricsOnMRZDocumentStatusEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IBiometricsOnMRZDocumentStatusListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.OnMRZReaderListener']"
	[Register ("com/credenceid/biometrics/Biometrics$OnMRZReaderListener", "", "Com.Credenceid.Biometrics.IBiometricsOnMRZReaderListenerInvoker")]
	public partial interface IBiometricsOnMRZReaderListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.OnMRZReaderListener']/method[@name='onMRZRead' and count(parameter)=5 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ResultCode'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='byte[]'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register ("onMRZRead", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Ljava/lang/String;[BLjava/lang/String;Ljava/lang/String;)V", "GetOnMRZRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_Handler:Com.Credenceid.Biometrics.IBiometricsOnMRZReaderListenerInvoker, CredenceBindings")]
		void OnMRZRead (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, string p1, byte[] p2, string p3, string p4);

	}

	[global::Android.Runtime.Register ("com/credenceid/biometrics/Biometrics$OnMRZReaderListener", DoNotGenerateAcw=true)]
	internal partial class IBiometricsOnMRZReaderListenerInvoker : global::Java.Lang.Object, IBiometricsOnMRZReaderListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/credenceid/biometrics/Biometrics$OnMRZReaderListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBiometricsOnMRZReaderListenerInvoker); }
		}

		IntPtr class_ref;

		public static IBiometricsOnMRZReaderListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBiometricsOnMRZReaderListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.credenceid.biometrics.Biometrics.OnMRZReaderListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBiometricsOnMRZReaderListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onMRZRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnMRZRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_onMRZRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_ == null)
				cb_onMRZRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLL_V) n_OnMRZRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_);
			return cb_onMRZRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_;
		}

		static void n_OnMRZRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnMRZReaderListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsResultCode> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			var p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.OnMRZRead (p0, p1, p2, p3, p4);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		IntPtr id_onMRZRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_;
		public unsafe void OnMRZRead (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, string p1, byte[] p2, string p3, string p4)
		{
			if (id_onMRZRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_onMRZRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onMRZRead", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Ljava/lang/String;[BLjava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (native_p4);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMRZRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			JNIEnv.DeleteLocalRef (native_p3);
			JNIEnv.DeleteLocalRef (native_p4);
		}

	}

	// event args for com.credenceid.biometrics.Biometrics.OnMRZReaderListener.onMRZRead
	public partial class BiometricsOnMRZReaderEventArgs : global::System.EventArgs {

		public BiometricsOnMRZReaderEventArgs (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, string p1, byte[] p2, string p3, string p4)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
			this.p4 = p4;
		}

		global::Com.Credenceid.Biometrics.BiometricsResultCode p0;
		public global::Com.Credenceid.Biometrics.BiometricsResultCode P0 {
			get { return p0; }
		}

		string p1;
		public string P1 {
			get { return p1; }
		}

		byte[] p2;
		public byte[] P2 {
			get { return p2; }
		}

		string p3;
		public string P3 {
			get { return p3; }
		}

		string p4;
		public string P4 {
			get { return p4; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/credenceid/biometrics/Biometrics_OnMRZReaderListenerImplementor")]
	internal sealed partial class IBiometricsOnMRZReaderListenerImplementor : global::Java.Lang.Object, IBiometricsOnMRZReaderListener {

		object sender;

		public IBiometricsOnMRZReaderListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/credenceid/biometrics/Biometrics_OnMRZReaderListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<BiometricsOnMRZReaderEventArgs> Handler;
#pragma warning restore 0649

		public void OnMRZRead (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, string p1, byte[] p2, string p3, string p4)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new BiometricsOnMRZReaderEventArgs (p0, p1, p2, p3, p4));
		}

		internal static bool __IsEmpty (IBiometricsOnMRZReaderListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.OnMultiFingerprintGrabbedListener']"
	[Register ("com/credenceid/biometrics/Biometrics$OnMultiFingerprintGrabbedListener", "", "Com.Credenceid.Biometrics.IBiometricsOnMultiFingerprintGrabbedListenerInvoker")]
	public partial interface IBiometricsOnMultiFingerprintGrabbedListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.OnMultiFingerprintGrabbedListener']/method[@name='onCloseFingerprintReader' and count(parameter)=2 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ResultCode'] and parameter[2][@type='com.credenceid.biometrics.Biometrics.CloseReasonCode']]"
		[Register ("onCloseFingerprintReader", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Lcom/credenceid/biometrics/Biometrics$CloseReasonCode;)V", "GetOnCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_Handler:Com.Credenceid.Biometrics.IBiometricsOnMultiFingerprintGrabbedListenerInvoker, CredenceBindings")]
		void OnCloseFingerprintReader (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.OnMultiFingerprintGrabbedListener']/method[@name='onFingerprintGrabbed' and count(parameter)=6 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ResultCode'] and parameter[2][@type='android.graphics.Bitmap'] and parameter[3][@type='android.graphics.Bitmap[]'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String[]'] and parameter[6][@type='java.lang.String']]"
		[Register ("onFingerprintGrabbed", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Landroid/graphics/Bitmap;[Landroid/graphics/Bitmap;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)V", "GetOnFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_arrayLandroid_graphics_Bitmap_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Handler:Com.Credenceid.Biometrics.IBiometricsOnMultiFingerprintGrabbedListenerInvoker, CredenceBindings")]
		void OnFingerprintGrabbed (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Android.Graphics.Bitmap p1, global::Android.Graphics.Bitmap[] p2, string p3, string[] p4, string p5);

	}

	[global::Android.Runtime.Register ("com/credenceid/biometrics/Biometrics$OnMultiFingerprintGrabbedListener", DoNotGenerateAcw=true)]
	internal partial class IBiometricsOnMultiFingerprintGrabbedListenerInvoker : global::Java.Lang.Object, IBiometricsOnMultiFingerprintGrabbedListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/credenceid/biometrics/Biometrics$OnMultiFingerprintGrabbedListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBiometricsOnMultiFingerprintGrabbedListenerInvoker); }
		}

		IntPtr class_ref;

		public static IBiometricsOnMultiFingerprintGrabbedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBiometricsOnMultiFingerprintGrabbedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.credenceid.biometrics.Biometrics.OnMultiFingerprintGrabbedListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBiometricsOnMultiFingerprintGrabbedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_;
#pragma warning disable 0169
		static Delegate GetOnCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_Handler ()
		{
			if (cb_onCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_ == null)
				cb_onCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_);
			return cb_onCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_;
		}

		static void n_OnCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnMultiFingerprintGrabbedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsResultCode> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnCloseFingerprintReader (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_;
		public unsafe void OnCloseFingerprintReader (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode p1)
		{
			if (id_onCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_ == IntPtr.Zero)
				id_onCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_ = JNIEnv.GetMethodID (class_ref, "onCloseFingerprintReader", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Lcom/credenceid/biometrics/Biometrics$CloseReasonCode;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_, __args);
		}

		static Delegate cb_onFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_arrayLandroid_graphics_Bitmap_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_arrayLandroid_graphics_Bitmap_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_onFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_arrayLandroid_graphics_Bitmap_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_ == null)
				cb_onFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_arrayLandroid_graphics_Bitmap_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLLL_V) n_OnFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_arrayLandroid_graphics_Bitmap_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_);
			return cb_onFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_arrayLandroid_graphics_Bitmap_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_;
		}

		static void n_OnFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_arrayLandroid_graphics_Bitmap_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnMultiFingerprintGrabbedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsResultCode> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Android.Graphics.Bitmap[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (global::Android.Graphics.Bitmap));
			var p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			var p4 = (string[]) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (string));
			var p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			__this.OnFingerprintGrabbed (p0, p1, p2, p3, p4, p5);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
		}
#pragma warning restore 0169

		IntPtr id_onFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_arrayLandroid_graphics_Bitmap_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_;
		public unsafe void OnFingerprintGrabbed (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Android.Graphics.Bitmap p1, global::Android.Graphics.Bitmap[] p2, string p3, string[] p4, string p5)
		{
			if (id_onFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_arrayLandroid_graphics_Bitmap_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_onFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_arrayLandroid_graphics_Bitmap_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onFingerprintGrabbed", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Landroid/graphics/Bitmap;[Landroid/graphics/Bitmap;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			JValue* __args = stackalloc JValue [6];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (native_p4);
			__args [5] = new JValue (native_p5);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_arrayLandroid_graphics_Bitmap_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_, __args);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			JNIEnv.DeleteLocalRef (native_p3);
			if (p4 != null) {
				JNIEnv.CopyArray (native_p4, p4);
				JNIEnv.DeleteLocalRef (native_p4);
			}
			JNIEnv.DeleteLocalRef (native_p5);
		}

	}

	// event args for com.credenceid.biometrics.Biometrics.OnMultiFingerprintGrabbedListener.onCloseFingerprintReader
	public partial class MultiFingerprintsClosedArgs : global::System.EventArgs {

		public MultiFingerprintsClosedArgs (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Credenceid.Biometrics.BiometricsResultCode p0;
		public global::Com.Credenceid.Biometrics.BiometricsResultCode P0 {
			get { return p0; }
		}

		global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode p1;
		public global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode P1 {
			get { return p1; }
		}
	}

	// event args for com.credenceid.biometrics.Biometrics.OnMultiFingerprintGrabbedListener.onFingerprintGrabbed
	public partial class MultiFingerprintsGrabbedArgs : global::System.EventArgs {

		public MultiFingerprintsGrabbedArgs (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Android.Graphics.Bitmap p1, global::Android.Graphics.Bitmap[] p2, string p3, string[] p4, string p5)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
			this.p4 = p4;
			this.p5 = p5;
		}

		global::Com.Credenceid.Biometrics.BiometricsResultCode p0;
		public global::Com.Credenceid.Biometrics.BiometricsResultCode P0 {
			get { return p0; }
		}

		global::Android.Graphics.Bitmap p1;
		public global::Android.Graphics.Bitmap P1 {
			get { return p1; }
		}

		global::Android.Graphics.Bitmap[] p2;
		public global::Android.Graphics.Bitmap[] P2 {
			get { return p2; }
		}

		string p3;
		public string P3 {
			get { return p3; }
		}

		string[] p4;
		public string[] P4 {
			get { return p4; }
		}

		string p5;
		public string P5 {
			get { return p5; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/credenceid/biometrics/Biometrics_OnMultiFingerprintGrabbedListenerImplementor")]
	internal sealed partial class IBiometricsOnMultiFingerprintGrabbedListenerImplementor : global::Java.Lang.Object, IBiometricsOnMultiFingerprintGrabbedListener {

		object sender;

		public IBiometricsOnMultiFingerprintGrabbedListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/credenceid/biometrics/Biometrics_OnMultiFingerprintGrabbedListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<MultiFingerprintsClosedArgs> OnCloseFingerprintReaderHandler;
#pragma warning restore 0649

		public void OnCloseFingerprintReader (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Com.Credenceid.Biometrics.BiometricsCloseReasonCode p1)
		{
			var __h = OnCloseFingerprintReaderHandler;
			if (__h != null)
				__h (sender, new MultiFingerprintsClosedArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<MultiFingerprintsGrabbedArgs> OnFingerprintGrabbedHandler;
#pragma warning restore 0649

		public void OnFingerprintGrabbed (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Android.Graphics.Bitmap p1, global::Android.Graphics.Bitmap[] p2, string p3, string[] p4, string p5)
		{
			var __h = OnFingerprintGrabbedHandler;
			if (__h != null)
				__h (sender, new MultiFingerprintsGrabbedArgs (p0, p1, p2, p3, p4, p5));
		}

		internal static bool __IsEmpty (IBiometricsOnMultiFingerprintGrabbedListenerImplementor value)
		{
			return value.OnCloseFingerprintReaderHandler == null && value.OnFingerprintGrabbedHandler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.PreferencesListener']"
	[Register ("com/credenceid/biometrics/Biometrics$PreferencesListener", "", "Com.Credenceid.Biometrics.IBiometricsPreferencesListenerInvoker")]
	public partial interface IBiometricsPreferencesListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics.PreferencesListener']/method[@name='onPreferences' and count(parameter)=3 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ResultCode'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("onPreferences", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Ljava/lang/String;Ljava/lang/String;)V", "GetOnPreferences_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_Ljava_lang_String_Handler:Com.Credenceid.Biometrics.IBiometricsPreferencesListenerInvoker, CredenceBindings")]
		void OnPreferences (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, string p1, string p2);

	}

	[global::Android.Runtime.Register ("com/credenceid/biometrics/Biometrics$PreferencesListener", DoNotGenerateAcw=true)]
	internal partial class IBiometricsPreferencesListenerInvoker : global::Java.Lang.Object, IBiometricsPreferencesListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/credenceid/biometrics/Biometrics$PreferencesListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBiometricsPreferencesListenerInvoker); }
		}

		IntPtr class_ref;

		public static IBiometricsPreferencesListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBiometricsPreferencesListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.credenceid.biometrics.Biometrics.PreferencesListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBiometricsPreferencesListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onPreferences_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnPreferences_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_onPreferences_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_onPreferences_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_OnPreferences_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_Ljava_lang_String_);
			return cb_onPreferences_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_OnPreferences_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsPreferencesListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsResultCode> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnPreferences (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onPreferences_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void OnPreferences (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, string p1, string p2)
		{
			if (id_onPreferences_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_onPreferences_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onPreferences", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPreferences_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

	}

	// event args for com.credenceid.biometrics.Biometrics.PreferencesListener.onPreferences
	public partial class BiometricsPreferencesEventArgs : global::System.EventArgs {

		public BiometricsPreferencesEventArgs (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, string p1, string p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		global::Com.Credenceid.Biometrics.BiometricsResultCode p0;
		public global::Com.Credenceid.Biometrics.BiometricsResultCode P0 {
			get { return p0; }
		}

		string p1;
		public string P1 {
			get { return p1; }
		}

		string p2;
		public string P2 {
			get { return p2; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/credenceid/biometrics/Biometrics_PreferencesListenerImplementor")]
	internal sealed partial class IBiometricsPreferencesListenerImplementor : global::Java.Lang.Object, IBiometricsPreferencesListener {

		object sender;

		public IBiometricsPreferencesListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/credenceid/biometrics/Biometrics_PreferencesListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<BiometricsPreferencesEventArgs> Handler;
#pragma warning restore 0649

		public void OnPreferences (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, string p1, string p2)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new BiometricsPreferencesEventArgs (p0, p1, p2));
		}

		internal static bool __IsEmpty (IBiometricsPreferencesListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath class reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='Biometrics.ResultCode']"
	[global::Android.Runtime.Register ("com/credenceid/biometrics/Biometrics$ResultCode", DoNotGenerateAcw=true)]
	public sealed partial class BiometricsResultCode : global::Java.Lang.Enum {


		static IntPtr API_UNAVAILABLE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='Biometrics.ResultCode']/field[@name='API_UNAVAILABLE']"
		[Register ("API_UNAVAILABLE")]
		public static global::Com.Credenceid.Biometrics.BiometricsResultCode ApiUnavailable {
			get {
				if (API_UNAVAILABLE_jfieldId == IntPtr.Zero)
					API_UNAVAILABLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "API_UNAVAILABLE", "Lcom/credenceid/biometrics/Biometrics$ResultCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, API_UNAVAILABLE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsResultCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr FAIL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='Biometrics.ResultCode']/field[@name='FAIL']"
		[Register ("FAIL")]
		public static global::Com.Credenceid.Biometrics.BiometricsResultCode Fail {
			get {
				if (FAIL_jfieldId == IntPtr.Zero)
					FAIL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FAIL", "Lcom/credenceid/biometrics/Biometrics$ResultCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FAIL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsResultCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr INTERMEDIATE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='Biometrics.ResultCode']/field[@name='INTERMEDIATE']"
		[Register ("INTERMEDIATE")]
		public static global::Com.Credenceid.Biometrics.BiometricsResultCode Intermediate {
			get {
				if (INTERMEDIATE_jfieldId == IntPtr.Zero)
					INTERMEDIATE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INTERMEDIATE", "Lcom/credenceid/biometrics/Biometrics$ResultCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INTERMEDIATE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsResultCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr OK_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='Biometrics.ResultCode']/field[@name='OK']"
		[Register ("OK")]
		public static global::Com.Credenceid.Biometrics.BiometricsResultCode Ok {
			get {
				if (OK_jfieldId == IntPtr.Zero)
					OK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OK", "Lcom/credenceid/biometrics/Biometrics$ResultCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OK_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsResultCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr WARNING_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='Biometrics.ResultCode']/field[@name='WARNING']"
		[Register ("WARNING")]
		public static global::Com.Credenceid.Biometrics.BiometricsResultCode Warning {
			get {
				if (WARNING_jfieldId == IntPtr.Zero)
					WARNING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WARNING", "Lcom/credenceid/biometrics/Biometrics$ResultCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WARNING_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsResultCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/credenceid/biometrics/Biometrics$ResultCode", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BiometricsResultCode); }
		}

		internal BiometricsResultCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='Biometrics.ResultCode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/credenceid/biometrics/Biometrics$ResultCode;", "")]
		public static unsafe global::Com.Credenceid.Biometrics.BiometricsResultCode ValueOf (string name)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/credenceid/biometrics/Biometrics$ResultCode;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::Com.Credenceid.Biometrics.BiometricsResultCode __ret = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsResultCode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='Biometrics.ResultCode']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/credenceid/biometrics/Biometrics$ResultCode;", "")]
		public static unsafe global::Com.Credenceid.Biometrics.BiometricsResultCode[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/credenceid/biometrics/Biometrics$ResultCode;");
			try {
				return (global::Com.Credenceid.Biometrics.BiometricsResultCode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Credenceid.Biometrics.BiometricsResultCode));
			} finally {
			}
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='Biometrics.ScanType']"
	[global::Android.Runtime.Register ("com/credenceid/biometrics/Biometrics$ScanType", DoNotGenerateAcw=true)]
	public sealed partial class BiometricsScanType : global::Java.Lang.Enum {


		static IntPtr FOUR_FINGERS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='Biometrics.ScanType']/field[@name='FOUR_FINGERS']"
		[Register ("FOUR_FINGERS")]
		public static global::Com.Credenceid.Biometrics.BiometricsScanType FourFingers {
			get {
				if (FOUR_FINGERS_jfieldId == IntPtr.Zero)
					FOUR_FINGERS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FOUR_FINGERS", "Lcom/credenceid/biometrics/Biometrics$ScanType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FOUR_FINGERS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsScanType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ROLL_SINGLE_FINGER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='Biometrics.ScanType']/field[@name='ROLL_SINGLE_FINGER']"
		[Register ("ROLL_SINGLE_FINGER")]
		public static global::Com.Credenceid.Biometrics.BiometricsScanType RollSingleFinger {
			get {
				if (ROLL_SINGLE_FINGER_jfieldId == IntPtr.Zero)
					ROLL_SINGLE_FINGER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ROLL_SINGLE_FINGER", "Lcom/credenceid/biometrics/Biometrics$ScanType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ROLL_SINGLE_FINGER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsScanType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SINGLE_FINGER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='Biometrics.ScanType']/field[@name='SINGLE_FINGER']"
		[Register ("SINGLE_FINGER")]
		public static global::Com.Credenceid.Biometrics.BiometricsScanType SingleFinger {
			get {
				if (SINGLE_FINGER_jfieldId == IntPtr.Zero)
					SINGLE_FINGER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SINGLE_FINGER", "Lcom/credenceid/biometrics/Biometrics$ScanType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SINGLE_FINGER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsScanType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TWO_FINGERS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='Biometrics.ScanType']/field[@name='TWO_FINGERS']"
		[Register ("TWO_FINGERS")]
		public static global::Com.Credenceid.Biometrics.BiometricsScanType TwoFingers {
			get {
				if (TWO_FINGERS_jfieldId == IntPtr.Zero)
					TWO_FINGERS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TWO_FINGERS", "Lcom/credenceid/biometrics/Biometrics$ScanType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TWO_FINGERS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsScanType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TWO_FINGERS_SPLIT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='Biometrics.ScanType']/field[@name='TWO_FINGERS_SPLIT']"
		[Register ("TWO_FINGERS_SPLIT")]
		public static global::Com.Credenceid.Biometrics.BiometricsScanType TwoFingersSplit {
			get {
				if (TWO_FINGERS_SPLIT_jfieldId == IntPtr.Zero)
					TWO_FINGERS_SPLIT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TWO_FINGERS_SPLIT", "Lcom/credenceid/biometrics/Biometrics$ScanType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TWO_FINGERS_SPLIT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsScanType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/credenceid/biometrics/Biometrics$ScanType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BiometricsScanType); }
		}

		internal BiometricsScanType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='Biometrics.ScanType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/credenceid/biometrics/Biometrics$ScanType;", "")]
		public static unsafe global::Com.Credenceid.Biometrics.BiometricsScanType ValueOf (string name)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/credenceid/biometrics/Biometrics$ScanType;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::Com.Credenceid.Biometrics.BiometricsScanType __ret = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsScanType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='Biometrics.ScanType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/credenceid/biometrics/Biometrics$ScanType;", "")]
		public static unsafe global::Com.Credenceid.Biometrics.BiometricsScanType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/credenceid/biometrics/Biometrics$ScanType;");
			try {
				return (global::Com.Credenceid.Biometrics.BiometricsScanType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Credenceid.Biometrics.BiometricsScanType));
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']"
	[Register ("com/credenceid/biometrics/Biometrics", "", "Com.Credenceid.Biometrics.IBiometricsInvoker")]
	public partial interface IBiometrics : IJavaObject {

		global::Com.Credenceid.Biometrics.DeviceFamily DeviceFamily {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='getDeviceFamily' and count(parameter)=0]"
			[Register ("getDeviceFamily", "()Lcom/credenceid/biometrics/DeviceFamily;", "GetGetDeviceFamilyHandler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")] get;
		}

		string DeviceID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='getDeviceID' and count(parameter)=0]"
			[Register ("getDeviceID", "()Ljava/lang/String;", "GetGetDeviceIDHandler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")] get;
		}

		global::Com.Credenceid.Biometrics.DeviceType DeviceType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='getDeviceType' and count(parameter)=0]"
			[Register ("getDeviceType", "()Lcom/credenceid/biometrics/DeviceType;", "GetGetDeviceTypeHandler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")] get;
		}

		global::Com.Credenceid.Biometrics.BiometricsFingerprintScannerType FingerprintScannerType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='getFingerprintScannerType' and count(parameter)=0]"
			[Register ("getFingerprintScannerType", "()Lcom/credenceid/biometrics/Biometrics$FingerprintScannerType;", "GetGetFingerprintScannerTypeHandler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")] get;
		}

		bool HasCardReader {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='hasCardReader' and count(parameter)=0]"
			[Register ("hasCardReader", "()Z", "GetHasCardReaderHandler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")] get;
		}

		bool HasFMDMatcher {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='hasFMDMatcher' and count(parameter)=0]"
			[Register ("hasFMDMatcher", "()Z", "GetHasFMDMatcherHandler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")] get;
		}

		bool HasFingerprintScanner {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='hasFingerprintScanner' and count(parameter)=0]"
			[Register ("hasFingerprintScanner", "()Z", "GetHasFingerprintScannerHandler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")] get;
		}

		bool HasIrisScanner {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='hasIrisScanner' and count(parameter)=0]"
			[Register ("hasIrisScanner", "()Z", "GetHasIrisScannerHandler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")] get;
		}

		bool HasMRZReader {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='hasMRZReader' and count(parameter)=0]"
			[Register ("hasMRZReader", "()Z", "GetHasMRZReaderHandler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")] get;
		}

		bool HasNFCCardReader {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='hasNFCCardReader' and count(parameter)=0]"
			[Register ("hasNFCCardReader", "()Z", "GetHasNFCCardReaderHandler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")] get;
		}

		bool HasUSBCamera {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='hasUSBCamera' and count(parameter)=0]"
			[Register ("hasUSBCamera", "()Z", "GetHasUSBCameraHandler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")] get;
		}

		bool HasUSBFileAccessEnabling {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='hasUSBFileAccessEnabling' and count(parameter)=0]"
			[Register ("hasUSBFileAccessEnabling", "()Z", "GetHasUSBFileAccessEnablingHandler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")] get;
		}

		string ProductName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='getProductName' and count(parameter)=0]"
			[Register ("getProductName", "()Ljava/lang/String;", "GetGetProductNameHandler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")] get;
		}

		string SDKJarVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='getSDKJarVersion' and count(parameter)=0]"
			[Register ("getSDKJarVersion", "()Ljava/lang/String;", "GetGetSDKJarVersionHandler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")] get;
		}

		string ServiceVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='getServiceVersion' and count(parameter)=0]"
			[Register ("getServiceVersion", "()Ljava/lang/String;", "GetGetServiceVersionHandler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='cameraTorchEnable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("cameraTorchEnable", "(Z)Z", "GetCameraTorchEnable_ZHandler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		bool CameraTorchEnable (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='cancelCapture' and count(parameter)=0]"
		[Register ("cancelCapture", "()V", "GetCancelCaptureHandler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		void CancelCapture ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='captureIrises' and count(parameter)=2 and parameter[1][@type='com.credenceid.biometrics.Biometrics.EyeSelection'] and parameter[2][@type='com.credenceid.biometrics.Biometrics.OnIrisesCapturedListener']]"
		[Register ("captureIrises", "(Lcom/credenceid/biometrics/Biometrics$EyeSelection;Lcom/credenceid/biometrics/Biometrics$OnIrisesCapturedListener;)V", "GetCaptureIrises_Lcom_credenceid_biometrics_Biometrics_EyeSelection_Lcom_credenceid_biometrics_Biometrics_OnIrisesCapturedListener_Handler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		void CaptureIrises (global::Com.Credenceid.Biometrics.BiometricsEyeSelection p0, global::Com.Credenceid.Biometrics.IBiometricsOnIrisesCapturedListener p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='cardCloseCommand' and count(parameter)=0]"
		[Register ("cardCloseCommand", "()V", "GetCardCloseCommandHandler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		void CardCloseCommand ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='cardCommand' and count(parameter)=3 and parameter[1][@type='com.credenceid.biometrics.ApduCommand'] and parameter[2][@type='boolean'] and parameter[3][@type='com.credenceid.biometrics.Biometrics.OnCardCommandListener']]"
		[Register ("cardCommand", "(Lcom/credenceid/biometrics/ApduCommand;ZLcom/credenceid/biometrics/Biometrics$OnCardCommandListener;)V", "GetCardCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnCardCommandListener_Handler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		void CardCommand (global::Com.Credenceid.Biometrics.ApduCommand p0, bool p1, global::Com.Credenceid.Biometrics.IBiometricsOnCardCommandListener p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='cardCommand' and count(parameter)=3 and parameter[1][@type='com.credenceid.biometrics.ApduCommand'] and parameter[2][@type='boolean'] and parameter[3][@type='com.credenceid.biometrics.Biometrics.OnCardCommandSyncResultListener']]"
		[Register ("cardCommand", "(Lcom/credenceid/biometrics/ApduCommand;ZLcom/credenceid/biometrics/Biometrics$OnCardCommandSyncResultListener;)V", "GetCardCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnCardCommandSyncResultListener_Handler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		void CardCommand (global::Com.Credenceid.Biometrics.ApduCommand p0, bool p1, global::Com.Credenceid.Biometrics.IBiometricsOnCardCommandSyncResultListener p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='cardConnectSync' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("cardConnectSync", "(I)Z", "GetCardConnectSync_IHandler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		bool CardConnectSync (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='cardDisconnectSync' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("cardDisconnectSync", "(I)Z", "GetCardDisconnectSync_IHandler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		bool CardDisconnectSync (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='cardOpenCommand' and count(parameter)=1 and parameter[1][@type='com.credenceid.biometrics.Biometrics.CardReaderStatusListener']]"
		[Register ("cardOpenCommand", "(Lcom/credenceid/biometrics/Biometrics$CardReaderStatusListener;)V", "GetCardOpenCommand_Lcom_credenceid_biometrics_Biometrics_CardReaderStatusListener_Handler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		void CardOpenCommand (global::Com.Credenceid.Biometrics.IBiometricsCardReaderStatusListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='closeFingerprintReader' and count(parameter)=0]"
		[Register ("closeFingerprintReader", "()V", "GetCloseFingerprintReaderHandler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		void CloseFingerprintReader ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='closeIrisScanner' and count(parameter)=0]"
		[Register ("closeIrisScanner", "()V", "GetCloseIrisScannerHandler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		void CloseIrisScanner ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='closeMRZ' and count(parameter)=0]"
		[Register ("closeMRZ", "()V", "GetCloseMRZHandler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		void CloseMRZ ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='compareFMD' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='com.credenceid.biometrics.Biometrics.FMDFormat'] and parameter[4][@type='com.credenceid.biometrics.Biometrics.OnCompareFMDListener']]"
		[Register ("compareFMD", "([B[BLcom/credenceid/biometrics/Biometrics$FMDFormat;Lcom/credenceid/biometrics/Biometrics$OnCompareFMDListener;)V", "GetCompareFMD_arrayBarrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnCompareFMDListener_Handler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		void CompareFMD (byte[] p0, byte[] p1, global::Com.Credenceid.Biometrics.BiometricsFMDFormat p2, global::Com.Credenceid.Biometrics.IBiometricsOnCompareFMDListener p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='compareFMDSync' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='com.credenceid.biometrics.Biometrics.FMDFormat'] and parameter[4][@type='int']]"
		[Register ("compareFMDSync", "([B[BLcom/credenceid/biometrics/Biometrics$FMDFormat;I)Lcom/credenceid/biometrics/CompareFMDSyncResponse;", "GetCompareFMDSync_arrayBarrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_IHandler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		global::Com.Credenceid.Biometrics.CompareFMDSyncResponse CompareFMDSync (byte[] p0, byte[] p1, global::Com.Credenceid.Biometrics.BiometricsFMDFormat p2, int p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='compressToWSQ' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='float'] and parameter[3][@type='com.credenceid.biometrics.Biometrics.OnCompressToWSQListener']]"
		[Register ("compressToWSQ", "(Ljava/lang/String;FLcom/credenceid/biometrics/Biometrics$OnCompressToWSQListener;)V", "GetCompressToWSQ_Ljava_lang_String_FLcom_credenceid_biometrics_Biometrics_OnCompressToWSQListener_Handler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		void CompressToWSQ (string p0, float p1, global::Com.Credenceid.Biometrics.IBiometricsOnCompressToWSQListener p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='convertCCFToFMD' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='com.credenceid.biometrics.Biometrics.OnCCFToFMDConversionListener']]"
		[Register ("convertCCFToFMD", "([BLcom/credenceid/biometrics/Biometrics$OnCCFToFMDConversionListener;)V", "GetConvertCCFToFMD_arrayBLcom_credenceid_biometrics_Biometrics_OnCCFToFMDConversionListener_Handler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		void ConvertCCFToFMD (byte[] p0, global::Com.Credenceid.Biometrics.IBiometricsOnCCFToFMDConversionListener p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='convertCCFToFMD' and count(parameter)=6 and parameter[1][@type='byte[]'] and parameter[2][@type='short'] and parameter[3][@type='short'] and parameter[4][@type='short'] and parameter[5][@type='short'] and parameter[6][@type='com.credenceid.biometrics.Biometrics.OnCCFToFMDConversionListener']]"
		[Register ("convertCCFToFMD", "([BSSSSLcom/credenceid/biometrics/Biometrics$OnCCFToFMDConversionListener;)V", "GetConvertCCFToFMD_arrayBSSSSLcom_credenceid_biometrics_Biometrics_OnCCFToFMDConversionListener_Handler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		void ConvertCCFToFMD (byte[] p0, short p1, short p2, short p3, short p4, global::Com.Credenceid.Biometrics.IBiometricsOnCCFToFMDConversionListener p5);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='convertCCFToFMDSync' and count(parameter)=6 and parameter[1][@type='byte[]'] and parameter[2][@type='short'] and parameter[3][@type='short'] and parameter[4][@type='short'] and parameter[5][@type='short'] and parameter[6][@type='int']]"
		[Register ("convertCCFToFMDSync", "([BSSSSI)Lcom/credenceid/biometrics/CCFToFMDSyncResponse;", "GetConvertCCFToFMDSync_arrayBSSSSIHandler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		global::Com.Credenceid.Biometrics.CCFToFMDSyncResponse ConvertCCFToFMDSync (byte[] p0, short p1, short p2, short p3, short p4, int p5);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='convertFMDToCCF' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='com.credenceid.biometrics.Biometrics.OnFMDToCCFConversionListener']]"
		[Register ("convertFMDToCCF", "([BLcom/credenceid/biometrics/Biometrics$OnFMDToCCFConversionListener;)V", "GetConvertFMDToCCF_arrayBLcom_credenceid_biometrics_Biometrics_OnFMDToCCFConversionListener_Handler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		void ConvertFMDToCCF (byte[] p0, global::Com.Credenceid.Biometrics.IBiometricsOnFMDToCCFConversionListener p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='convertFMDToCCFSync' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("convertFMDToCCFSync", "([BI)Lcom/credenceid/biometrics/FMDToCCFSyncResponse;", "GetConvertFMDToCCFSync_arrayBIHandler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		global::Com.Credenceid.Biometrics.FMDToCCFSyncResponse ConvertFMDToCCFSync (byte[] p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='convertToFMD' and count(parameter)=3 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='com.credenceid.biometrics.Biometrics.FMDFormat'] and parameter[3][@type='com.credenceid.biometrics.Biometrics.OnConvertToFMDListener']]"
		[Register ("convertToFMD", "(Landroid/graphics/Bitmap;Lcom/credenceid/biometrics/Biometrics$FMDFormat;Lcom/credenceid/biometrics/Biometrics$OnConvertToFMDListener;)V", "GetConvertToFMD_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnConvertToFMDListener_Handler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		void ConvertToFMD (global::Android.Graphics.Bitmap p0, global::Com.Credenceid.Biometrics.BiometricsFMDFormat p1, global::Com.Credenceid.Biometrics.IBiometricsOnConvertToFMDListener p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='convertToFMD' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='com.credenceid.biometrics.Biometrics.FMDFormat'] and parameter[3][@type='com.credenceid.biometrics.Biometrics.OnConvertToFMDListener']]"
		[Register ("convertToFMD", "([BLcom/credenceid/biometrics/Biometrics$FMDFormat;Lcom/credenceid/biometrics/Biometrics$OnConvertToFMDListener;)V", "GetConvertToFMD_arrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnConvertToFMDListener_Handler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		void ConvertToFMD (byte[] p0, global::Com.Credenceid.Biometrics.BiometricsFMDFormat p1, global::Com.Credenceid.Biometrics.IBiometricsOnConvertToFMDListener p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='convertToFMDSync' and count(parameter)=3 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='com.credenceid.biometrics.Biometrics.FMDFormat'] and parameter[3][@type='int']]"
		[Register ("convertToFMDSync", "(Landroid/graphics/Bitmap;Lcom/credenceid/biometrics/Biometrics$FMDFormat;I)Lcom/credenceid/biometrics/ConvertToFMDSyncResponse;", "GetConvertToFMDSync_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_FMDFormat_IHandler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		global::Com.Credenceid.Biometrics.ConvertToFMDSyncResponse ConvertToFMDSync (global::Android.Graphics.Bitmap p0, global::Com.Credenceid.Biometrics.BiometricsFMDFormat p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='convertToFMDSync' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='com.credenceid.biometrics.Biometrics.FMDFormat'] and parameter[3][@type='int']]"
		[Register ("convertToFMDSync", "([BLcom/credenceid/biometrics/Biometrics$FMDFormat;I)Lcom/credenceid/biometrics/ConvertToFMDSyncResponse;", "GetConvertToFMDSync_arrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_IHandler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		global::Com.Credenceid.Biometrics.ConvertToFMDSyncResponse ConvertToFMDSync (byte[] p0, global::Com.Credenceid.Biometrics.BiometricsFMDFormat p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='decompressWSQ' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='com.credenceid.biometrics.Biometrics.OnDecompressWSQListener']]"
		[Register ("decompressWSQ", "([BLcom/credenceid/biometrics/Biometrics$OnDecompressWSQListener;)V", "GetDecompressWSQ_arrayBLcom_credenceid_biometrics_Biometrics_OnDecompressWSQListener_Handler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		void DecompressWSQ (byte[] p0, global::Com.Credenceid.Biometrics.IBiometricsOnDecompressWSQListener p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='decompressWSQ' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.credenceid.biometrics.Biometrics.OnDecompressWSQListener']]"
		[Register ("decompressWSQ", "(Ljava/lang/String;Lcom/credenceid/biometrics/Biometrics$OnDecompressWSQListener;)V", "GetDecompressWSQ_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_OnDecompressWSQListener_Handler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		void DecompressWSQ (string p0, global::Com.Credenceid.Biometrics.IBiometricsOnDecompressWSQListener p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='ePassportCloseCommand' and count(parameter)=0]"
		[Register ("ePassportCloseCommand", "()V", "GetEPassportCloseCommandHandler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		void EPassportCloseCommand ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='ePassportCommand' and count(parameter)=3 and parameter[1][@type='com.credenceid.biometrics.ApduCommand'] and parameter[2][@type='boolean'] and parameter[3][@type='com.credenceid.biometrics.Biometrics.OnEPassportCommandListener']]"
		[Register ("ePassportCommand", "(Lcom/credenceid/biometrics/ApduCommand;ZLcom/credenceid/biometrics/Biometrics$OnEPassportCommandListener;)V", "GetEPassportCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnEPassportCommandListener_Handler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		void EPassportCommand (global::Com.Credenceid.Biometrics.ApduCommand p0, bool p1, global::Com.Credenceid.Biometrics.IBiometricsOnEPassportCommandListener p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='ePassportOpenCommand' and count(parameter)=1 and parameter[1][@type='com.credenceid.biometrics.Biometrics.EPassportReaderStatusListener']]"
		[Register ("ePassportOpenCommand", "(Lcom/credenceid/biometrics/Biometrics$EPassportReaderStatusListener;)V", "GetEPassportOpenCommand_Lcom_credenceid_biometrics_Biometrics_EPassportReaderStatusListener_Handler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		void EPassportOpenCommand (global::Com.Credenceid.Biometrics.IBiometricsEPassportReaderStatusListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='ektpCardReadCommand' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='com.credenceid.biometrics.Biometrics.OnEktpCardReadListener']]"
		[Register ("ektpCardReadCommand", "(I[BLcom/credenceid/biometrics/Biometrics$OnEktpCardReadListener;)V", "GetEktpCardReadCommand_IarrayBLcom_credenceid_biometrics_Biometrics_OnEktpCardReadListener_Handler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		void EktpCardReadCommand (int p0, byte[] p1, global::Com.Credenceid.Biometrics.IBiometricsOnEktpCardReadListener p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='finalizeBiometrics' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("finalizeBiometrics", "(Z)V", "GetFinalizeBiometrics_ZHandler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		void FinalizeBiometrics (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='generateTerminalIsCertificate' and count(parameter)=1 and parameter[1][@type='com.credenceid.biometrics.Biometrics.generateTerminalIsCertificateListener']]"
		[Register ("generateTerminalIsCertificate", "(Lcom/credenceid/biometrics/Biometrics$generateTerminalIsCertificateListener;)V", "GetGenerateTerminalIsCertificate_Lcom_credenceid_biometrics_Biometrics_generateTerminalIsCertificateListener_Handler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		void GenerateTerminalIsCertificate (global::Com.Credenceid.Biometrics.IBiometricsGenerateTerminalIsCertificateListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='getFingerQuality' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='com.credenceid.biometrics.Biometrics.OnGetFingerQualityListener']]"
		[Register ("getFingerQuality", "(Landroid/graphics/Bitmap;Lcom/credenceid/biometrics/Biometrics$OnGetFingerQualityListener;)V", "GetGetFingerQuality_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_OnGetFingerQualityListener_Handler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		void GetFingerQuality (global::Android.Graphics.Bitmap p0, global::Com.Credenceid.Biometrics.IBiometricsOnGetFingerQualityListener p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='getFingerQuality' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.credenceid.biometrics.Biometrics.OnFingerQualityListener']]"
		[Register ("getFingerQuality", "(Ljava/lang/String;Lcom/credenceid/biometrics/Biometrics$OnFingerQualityListener;)V", "GetGetFingerQuality_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_OnFingerQualityListener_Handler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		void GetFingerQuality (string p0, global::Com.Credenceid.Biometrics.IBiometricsOnFingerQualityListener p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='getPreferences' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.credenceid.biometrics.Biometrics.PreferencesListener']]"
		[Register ("getPreferences", "(Ljava/lang/String;Lcom/credenceid/biometrics/Biometrics$PreferencesListener;)V", "GetGetPreferences_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_PreferencesListener_Handler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		void GetPreferences (string p0, global::Com.Credenceid.Biometrics.IBiometricsPreferencesListener p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='getProviderDetails' and count(parameter)=1 and parameter[1][@type='com.credenceid.biometrics.Biometrics.OnGetProviderDetailsListener']]"
		[Register ("getProviderDetails", "(Lcom/credenceid/biometrics/Biometrics$OnGetProviderDetailsListener;)V", "GetGetProviderDetails_Lcom_credenceid_biometrics_Biometrics_OnGetProviderDetailsListener_Handler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		void GetProviderDetails (global::Com.Credenceid.Biometrics.IBiometricsOnGetProviderDetailsListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='grabFingerprint' and count(parameter)=3 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ScanType'] and parameter[2][@type='boolean'] and parameter[3][@type='com.credenceid.biometrics.Biometrics.OnFingerprintGrabbedFullListener']]"
		[Register ("grabFingerprint", "(Lcom/credenceid/biometrics/Biometrics$ScanType;ZLcom/credenceid/biometrics/Biometrics$OnFingerprintGrabbedFullListener;)V", "GetGrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedFullListener_Handler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		void GrabFingerprint (global::Com.Credenceid.Biometrics.BiometricsScanType p0, bool p1, global::Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedFullListener p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='grabFingerprint' and count(parameter)=3 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ScanType'] and parameter[2][@type='boolean'] and parameter[3][@type='com.credenceid.biometrics.Biometrics.OnFingerprintGrabbedListener']]"
		[Register ("grabFingerprint", "(Lcom/credenceid/biometrics/Biometrics$ScanType;ZLcom/credenceid/biometrics/Biometrics$OnFingerprintGrabbedListener;)V", "GetGrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedListener_Handler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		void GrabFingerprint (global::Com.Credenceid.Biometrics.BiometricsScanType p0, bool p1, global::Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedListener p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='grabFingerprint' and count(parameter)=3 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ScanType'] and parameter[2][@type='boolean'] and parameter[3][@type='com.credenceid.biometrics.Biometrics.OnFingerprintGrabbedRawListener']]"
		[Register ("grabFingerprint", "(Lcom/credenceid/biometrics/Biometrics$ScanType;ZLcom/credenceid/biometrics/Biometrics$OnFingerprintGrabbedRawListener;)V", "GetGrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedRawListener_Handler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		void GrabFingerprint (global::Com.Credenceid.Biometrics.BiometricsScanType p0, bool p1, global::Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedRawListener p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='grabFingerprint' and count(parameter)=3 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ScanType'] and parameter[2][@type='boolean'] and parameter[3][@type='com.credenceid.biometrics.Biometrics.OnFingerprintGrabbedWSQListener']]"
		[Register ("grabFingerprint", "(Lcom/credenceid/biometrics/Biometrics$ScanType;ZLcom/credenceid/biometrics/Biometrics$OnFingerprintGrabbedWSQListener;)V", "GetGrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedWSQListener_Handler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		void GrabFingerprint (global::Com.Credenceid.Biometrics.BiometricsScanType p0, bool p1, global::Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedWSQListener p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='grabFingerprint' and count(parameter)=3 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ScanType'] and parameter[2][@type='boolean'] and parameter[3][@type='com.credenceid.biometrics.Biometrics.OnMultiFingerprintGrabbedListener']]"
		[Register ("grabFingerprint", "(Lcom/credenceid/biometrics/Biometrics$ScanType;ZLcom/credenceid/biometrics/Biometrics$OnMultiFingerprintGrabbedListener;)V", "GetGrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnMultiFingerprintGrabbedListener_Handler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		void GrabFingerprint (global::Com.Credenceid.Biometrics.BiometricsScanType p0, bool p1, global::Com.Credenceid.Biometrics.IBiometricsOnMultiFingerprintGrabbedListener p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='grabFingerprint' and count(parameter)=2 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ScanType'] and parameter[2][@type='com.credenceid.biometrics.Biometrics.OnFingerprintGrabbedFullListener']]"
		[Register ("grabFingerprint", "(Lcom/credenceid/biometrics/Biometrics$ScanType;Lcom/credenceid/biometrics/Biometrics$OnFingerprintGrabbedFullListener;)V", "GetGrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedFullListener_Handler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		void GrabFingerprint (global::Com.Credenceid.Biometrics.BiometricsScanType p0, global::Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedFullListener p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='grabFingerprint' and count(parameter)=2 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ScanType'] and parameter[2][@type='com.credenceid.biometrics.Biometrics.OnFingerprintGrabbedListener']]"
		[Register ("grabFingerprint", "(Lcom/credenceid/biometrics/Biometrics$ScanType;Lcom/credenceid/biometrics/Biometrics$OnFingerprintGrabbedListener;)V", "GetGrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedListener_Handler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		void GrabFingerprint (global::Com.Credenceid.Biometrics.BiometricsScanType p0, global::Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedListener p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='grabFingerprint' and count(parameter)=2 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ScanType'] and parameter[2][@type='com.credenceid.biometrics.Biometrics.OnFingerprintGrabbedWSQListener']]"
		[Register ("grabFingerprint", "(Lcom/credenceid/biometrics/Biometrics$ScanType;Lcom/credenceid/biometrics/Biometrics$OnFingerprintGrabbedWSQListener;)V", "GetGrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedWSQListener_Handler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		void GrabFingerprint (global::Com.Credenceid.Biometrics.BiometricsScanType p0, global::Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedWSQListener p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='grabFingerprintSync' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("grabFingerprintSync", "(I)Lcom/credenceid/biometrics/FingerprintSyncResponse;", "GetGrabFingerprintSync_IHandler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		global::Com.Credenceid.Biometrics.FingerprintSyncResponse GrabFingerprintSync (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='initializeBiometrics' and count(parameter)=1 and parameter[1][@type='com.credenceid.biometrics.Biometrics.OnInitializedListener']]"
		[Register ("initializeBiometrics", "(Lcom/credenceid/biometrics/Biometrics$OnInitializedListener;)V", "GetInitializeBiometrics_Lcom_credenceid_biometrics_Biometrics_OnInitializedListener_Handler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		void InitializeBiometrics (global::Com.Credenceid.Biometrics.IBiometricsOnInitializedListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='openFingerprintReader' and count(parameter)=1 and parameter[1][@type='com.credenceid.biometrics.Biometrics.FingerprintReaderStatusListener']]"
		[Register ("openFingerprintReader", "(Lcom/credenceid/biometrics/Biometrics$FingerprintReaderStatusListener;)V", "GetOpenFingerprintReader_Lcom_credenceid_biometrics_Biometrics_FingerprintReaderStatusListener_Handler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		void OpenFingerprintReader (global::Com.Credenceid.Biometrics.IBiometricsFingerprintReaderStatusListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='openMRZ' and count(parameter)=1 and parameter[1][@type='com.credenceid.biometrics.Biometrics.MRZStatusListener']]"
		[Register ("openMRZ", "(Lcom/credenceid/biometrics/Biometrics$MRZStatusListener;)V", "GetOpenMRZ_Lcom_credenceid_biometrics_Biometrics_MRZStatusListener_Handler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		void OpenMRZ (global::Com.Credenceid.Biometrics.IBiometricsMRZStatusListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='readICAODocument' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean'] and parameter[4][@type='com.credenceid.biometrics.Biometrics.ICAODocumentReadListener']]"
		[Register ("readICAODocument", "(Ljava/lang/String;Ljava/lang/String;ZLcom/credenceid/biometrics/Biometrics$ICAODocumentReadListener;)V", "GetReadICAODocument_Ljava_lang_String_Ljava_lang_String_ZLcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_Handler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		void ReadICAODocument (string p0, string p1, bool p2, global::Com.Credenceid.Biometrics.IBiometricsCAODocumentReadListener p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='readICAODocument' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.credenceid.biometrics.Biometrics.ICAODocumentReadListener']]"
		[Register ("readICAODocument", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/credenceid/biometrics/Biometrics$ICAODocumentReadListener;)V", "GetReadICAODocument_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_Handler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		void ReadICAODocument (string p0, string p1, string p2, global::Com.Credenceid.Biometrics.IBiometricsCAODocumentReadListener p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='readICAODocument' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='boolean'] and parameter[6][@type='com.credenceid.biometrics.Biometrics.ICAODocumentReadListener']]"
		[Register ("readICAODocument", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ZLcom/credenceid/biometrics/Biometrics$ICAODocumentReadListener;)V", "GetReadICAODocument_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_Handler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		void ReadICAODocument (string p0, string p1, string p2, string p3, bool p4, global::Com.Credenceid.Biometrics.IBiometricsCAODocumentReadListener p5);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='readMRZ' and count(parameter)=1 and parameter[1][@type='com.credenceid.biometrics.Biometrics.OnMRZReaderListener']]"
		[Register ("readMRZ", "(Lcom/credenceid/biometrics/Biometrics$OnMRZReaderListener;)V", "GetReadMRZ_Lcom_credenceid_biometrics_Biometrics_OnMRZReaderListener_Handler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		void ReadMRZ (global::Com.Credenceid.Biometrics.IBiometricsOnMRZReaderListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='readSmartCard' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.credenceid.biometrics.Biometrics.GIcaoReadListener']]"
		[Register ("readSmartCard", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/credenceid/biometrics/Biometrics$GIcaoReadListener;)V", "GetReadSmartCard_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_GIcaoReadListener_Handler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		void ReadSmartCard (string p0, string p1, string p2, global::Com.Credenceid.Biometrics.IBiometricsGIcaoReadListener p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='readSmartCard' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.credenceid.biometrics.Biometrics.GNIDReadListener']]"
		[Register ("readSmartCard", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/credenceid/biometrics/Biometrics$GNIDReadListener;)V", "GetReadSmartCard_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_GNIDReadListener_Handler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		void ReadSmartCard (string p0, string p1, string p2, global::Com.Credenceid.Biometrics.IBiometricsGNIDReadListener p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='registerCardStatusListener' and count(parameter)=1 and parameter[1][@type='com.credenceid.biometrics.Biometrics.OnCardStatusListener']]"
		[Register ("registerCardStatusListener", "(Lcom/credenceid/biometrics/Biometrics$OnCardStatusListener;)V", "GetRegisterCardStatusListener_Lcom_credenceid_biometrics_Biometrics_OnCardStatusListener_Handler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		void RegisterCardStatusListener (global::Com.Credenceid.Biometrics.IBiometricsOnCardStatusListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='registerEPassportStatusListener' and count(parameter)=1 and parameter[1][@type='com.credenceid.biometrics.Biometrics.OnEPassportStatusListener']]"
		[Register ("registerEPassportStatusListener", "(Lcom/credenceid/biometrics/Biometrics$OnEPassportStatusListener;)V", "GetRegisterEPassportStatusListener_Lcom_credenceid_biometrics_Biometrics_OnEPassportStatusListener_Handler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		void RegisterEPassportStatusListener (global::Com.Credenceid.Biometrics.IBiometricsOnEPassportStatusListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='registerMRZDocumentStatusListener' and count(parameter)=1 and parameter[1][@type='com.credenceid.biometrics.Biometrics.OnMRZDocumentStatusListener']]"
		[Register ("registerMRZDocumentStatusListener", "(Lcom/credenceid/biometrics/Biometrics$OnMRZDocumentStatusListener;)V", "GetRegisterMRZDocumentStatusListener_Lcom_credenceid_biometrics_Biometrics_OnMRZDocumentStatusListener_Handler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		void RegisterMRZDocumentStatusListener (global::Com.Credenceid.Biometrics.IBiometricsOnMRZDocumentStatusListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='registerOnMRZReaderListener' and count(parameter)=1 and parameter[1][@type='com.credenceid.biometrics.Biometrics.OnMRZReaderListener']]"
		[Register ("registerOnMRZReaderListener", "(Lcom/credenceid/biometrics/Biometrics$OnMRZReaderListener;)V", "GetRegisterOnMRZReaderListener_Lcom_credenceid_biometrics_Biometrics_OnMRZReaderListener_Handler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		void RegisterOnMRZReaderListener (global::Com.Credenceid.Biometrics.IBiometricsOnMRZReaderListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='setPreferences' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.credenceid.biometrics.Biometrics.PreferencesListener']]"
		[Register ("setPreferences", "(Ljava/lang/String;Ljava/lang/String;Lcom/credenceid/biometrics/Biometrics$PreferencesListener;)V", "GetSetPreferences_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_PreferencesListener_Handler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		void SetPreferences (string p0, string p1, global::Com.Credenceid.Biometrics.IBiometricsPreferencesListener p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/interface[@name='Biometrics']/method[@name='switchMobileData' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='com.credenceid.biometrics.Biometrics.OnMobileDataChangedListener']]"
		[Register ("switchMobileData", "(ZLcom/credenceid/biometrics/Biometrics$OnMobileDataChangedListener;)V", "GetSwitchMobileData_ZLcom_credenceid_biometrics_Biometrics_OnMobileDataChangedListener_Handler:Com.Credenceid.Biometrics.IBiometricsInvoker, CredenceBindings")]
		void SwitchMobileData (bool p0, global::Com.Credenceid.Biometrics.IBiometricsOnMobileDataChangedListener p1);

	}

	[global::Android.Runtime.Register ("com/credenceid/biometrics/Biometrics", DoNotGenerateAcw=true)]
	internal partial class IBiometricsInvoker : global::Java.Lang.Object, IBiometrics {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/credenceid/biometrics/Biometrics");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBiometricsInvoker); }
		}

		IntPtr class_ref;

		public static IBiometrics GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBiometrics> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.credenceid.biometrics.Biometrics"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBiometricsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getDeviceFamily;
#pragma warning disable 0169
		static Delegate GetGetDeviceFamilyHandler ()
		{
			if (cb_getDeviceFamily == null)
				cb_getDeviceFamily = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeviceFamily);
			return cb_getDeviceFamily;
		}

		static IntPtr n_GetDeviceFamily (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeviceFamily);
		}
#pragma warning restore 0169

		IntPtr id_getDeviceFamily;
		public unsafe global::Com.Credenceid.Biometrics.DeviceFamily DeviceFamily {
			get {
				if (id_getDeviceFamily == IntPtr.Zero)
					id_getDeviceFamily = JNIEnv.GetMethodID (class_ref, "getDeviceFamily", "()Lcom/credenceid/biometrics/DeviceFamily;");
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.DeviceFamily> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeviceFamily), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getDeviceID;
#pragma warning disable 0169
		static Delegate GetGetDeviceIDHandler ()
		{
			if (cb_getDeviceID == null)
				cb_getDeviceID = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeviceID);
			return cb_getDeviceID;
		}

		static IntPtr n_GetDeviceID (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceID);
		}
#pragma warning restore 0169

		IntPtr id_getDeviceID;
		public unsafe string DeviceID {
			get {
				if (id_getDeviceID == IntPtr.Zero)
					id_getDeviceID = JNIEnv.GetMethodID (class_ref, "getDeviceID", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeviceID), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getDeviceType;
#pragma warning disable 0169
		static Delegate GetGetDeviceTypeHandler ()
		{
			if (cb_getDeviceType == null)
				cb_getDeviceType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeviceType);
			return cb_getDeviceType;
		}

		static IntPtr n_GetDeviceType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeviceType);
		}
#pragma warning restore 0169

		IntPtr id_getDeviceType;
		public unsafe global::Com.Credenceid.Biometrics.DeviceType DeviceType {
			get {
				if (id_getDeviceType == IntPtr.Zero)
					id_getDeviceType = JNIEnv.GetMethodID (class_ref, "getDeviceType", "()Lcom/credenceid/biometrics/DeviceType;");
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.DeviceType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeviceType), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getFingerprintScannerType;
#pragma warning disable 0169
		static Delegate GetGetFingerprintScannerTypeHandler ()
		{
			if (cb_getFingerprintScannerType == null)
				cb_getFingerprintScannerType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFingerprintScannerType);
			return cb_getFingerprintScannerType;
		}

		static IntPtr n_GetFingerprintScannerType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FingerprintScannerType);
		}
#pragma warning restore 0169

		IntPtr id_getFingerprintScannerType;
		public unsafe global::Com.Credenceid.Biometrics.BiometricsFingerprintScannerType FingerprintScannerType {
			get {
				if (id_getFingerprintScannerType == IntPtr.Zero)
					id_getFingerprintScannerType = JNIEnv.GetMethodID (class_ref, "getFingerprintScannerType", "()Lcom/credenceid/biometrics/Biometrics$FingerprintScannerType;");
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsFingerprintScannerType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFingerprintScannerType), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_hasCardReader;
#pragma warning disable 0169
		static Delegate GetHasCardReaderHandler ()
		{
			if (cb_hasCardReader == null)
				cb_hasCardReader = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasCardReader);
			return cb_hasCardReader;
		}

		static bool n_HasCardReader (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasCardReader;
		}
#pragma warning restore 0169

		IntPtr id_hasCardReader;
		public unsafe bool HasCardReader {
			get {
				if (id_hasCardReader == IntPtr.Zero)
					id_hasCardReader = JNIEnv.GetMethodID (class_ref, "hasCardReader", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasCardReader);
			}
		}

		static Delegate cb_hasFMDMatcher;
#pragma warning disable 0169
		static Delegate GetHasFMDMatcherHandler ()
		{
			if (cb_hasFMDMatcher == null)
				cb_hasFMDMatcher = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasFMDMatcher);
			return cb_hasFMDMatcher;
		}

		static bool n_HasFMDMatcher (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasFMDMatcher;
		}
#pragma warning restore 0169

		IntPtr id_hasFMDMatcher;
		public unsafe bool HasFMDMatcher {
			get {
				if (id_hasFMDMatcher == IntPtr.Zero)
					id_hasFMDMatcher = JNIEnv.GetMethodID (class_ref, "hasFMDMatcher", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasFMDMatcher);
			}
		}

		static Delegate cb_hasFingerprintScanner;
#pragma warning disable 0169
		static Delegate GetHasFingerprintScannerHandler ()
		{
			if (cb_hasFingerprintScanner == null)
				cb_hasFingerprintScanner = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasFingerprintScanner);
			return cb_hasFingerprintScanner;
		}

		static bool n_HasFingerprintScanner (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasFingerprintScanner;
		}
#pragma warning restore 0169

		IntPtr id_hasFingerprintScanner;
		public unsafe bool HasFingerprintScanner {
			get {
				if (id_hasFingerprintScanner == IntPtr.Zero)
					id_hasFingerprintScanner = JNIEnv.GetMethodID (class_ref, "hasFingerprintScanner", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasFingerprintScanner);
			}
		}

		static Delegate cb_hasIrisScanner;
#pragma warning disable 0169
		static Delegate GetHasIrisScannerHandler ()
		{
			if (cb_hasIrisScanner == null)
				cb_hasIrisScanner = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasIrisScanner);
			return cb_hasIrisScanner;
		}

		static bool n_HasIrisScanner (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasIrisScanner;
		}
#pragma warning restore 0169

		IntPtr id_hasIrisScanner;
		public unsafe bool HasIrisScanner {
			get {
				if (id_hasIrisScanner == IntPtr.Zero)
					id_hasIrisScanner = JNIEnv.GetMethodID (class_ref, "hasIrisScanner", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasIrisScanner);
			}
		}

		static Delegate cb_hasMRZReader;
#pragma warning disable 0169
		static Delegate GetHasMRZReaderHandler ()
		{
			if (cb_hasMRZReader == null)
				cb_hasMRZReader = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasMRZReader);
			return cb_hasMRZReader;
		}

		static bool n_HasMRZReader (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasMRZReader;
		}
#pragma warning restore 0169

		IntPtr id_hasMRZReader;
		public unsafe bool HasMRZReader {
			get {
				if (id_hasMRZReader == IntPtr.Zero)
					id_hasMRZReader = JNIEnv.GetMethodID (class_ref, "hasMRZReader", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasMRZReader);
			}
		}

		static Delegate cb_hasNFCCardReader;
#pragma warning disable 0169
		static Delegate GetHasNFCCardReaderHandler ()
		{
			if (cb_hasNFCCardReader == null)
				cb_hasNFCCardReader = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasNFCCardReader);
			return cb_hasNFCCardReader;
		}

		static bool n_HasNFCCardReader (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasNFCCardReader;
		}
#pragma warning restore 0169

		IntPtr id_hasNFCCardReader;
		public unsafe bool HasNFCCardReader {
			get {
				if (id_hasNFCCardReader == IntPtr.Zero)
					id_hasNFCCardReader = JNIEnv.GetMethodID (class_ref, "hasNFCCardReader", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasNFCCardReader);
			}
		}

		static Delegate cb_hasUSBCamera;
#pragma warning disable 0169
		static Delegate GetHasUSBCameraHandler ()
		{
			if (cb_hasUSBCamera == null)
				cb_hasUSBCamera = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasUSBCamera);
			return cb_hasUSBCamera;
		}

		static bool n_HasUSBCamera (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasUSBCamera;
		}
#pragma warning restore 0169

		IntPtr id_hasUSBCamera;
		public unsafe bool HasUSBCamera {
			get {
				if (id_hasUSBCamera == IntPtr.Zero)
					id_hasUSBCamera = JNIEnv.GetMethodID (class_ref, "hasUSBCamera", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasUSBCamera);
			}
		}

		static Delegate cb_hasUSBFileAccessEnabling;
#pragma warning disable 0169
		static Delegate GetHasUSBFileAccessEnablingHandler ()
		{
			if (cb_hasUSBFileAccessEnabling == null)
				cb_hasUSBFileAccessEnabling = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasUSBFileAccessEnabling);
			return cb_hasUSBFileAccessEnabling;
		}

		static bool n_HasUSBFileAccessEnabling (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasUSBFileAccessEnabling;
		}
#pragma warning restore 0169

		IntPtr id_hasUSBFileAccessEnabling;
		public unsafe bool HasUSBFileAccessEnabling {
			get {
				if (id_hasUSBFileAccessEnabling == IntPtr.Zero)
					id_hasUSBFileAccessEnabling = JNIEnv.GetMethodID (class_ref, "hasUSBFileAccessEnabling", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasUSBFileAccessEnabling);
			}
		}

		static Delegate cb_getProductName;
#pragma warning disable 0169
		static Delegate GetGetProductNameHandler ()
		{
			if (cb_getProductName == null)
				cb_getProductName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetProductName);
			return cb_getProductName;
		}

		static IntPtr n_GetProductName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ProductName);
		}
#pragma warning restore 0169

		IntPtr id_getProductName;
		public unsafe string ProductName {
			get {
				if (id_getProductName == IntPtr.Zero)
					id_getProductName = JNIEnv.GetMethodID (class_ref, "getProductName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProductName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSDKJarVersion;
#pragma warning disable 0169
		static Delegate GetGetSDKJarVersionHandler ()
		{
			if (cb_getSDKJarVersion == null)
				cb_getSDKJarVersion = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSDKJarVersion);
			return cb_getSDKJarVersion;
		}

		static IntPtr n_GetSDKJarVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SDKJarVersion);
		}
#pragma warning restore 0169

		IntPtr id_getSDKJarVersion;
		public unsafe string SDKJarVersion {
			get {
				if (id_getSDKJarVersion == IntPtr.Zero)
					id_getSDKJarVersion = JNIEnv.GetMethodID (class_ref, "getSDKJarVersion", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSDKJarVersion), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getServiceVersion;
#pragma warning disable 0169
		static Delegate GetGetServiceVersionHandler ()
		{
			if (cb_getServiceVersion == null)
				cb_getServiceVersion = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetServiceVersion);
			return cb_getServiceVersion;
		}

		static IntPtr n_GetServiceVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ServiceVersion);
		}
#pragma warning restore 0169

		IntPtr id_getServiceVersion;
		public unsafe string ServiceVersion {
			get {
				if (id_getServiceVersion == IntPtr.Zero)
					id_getServiceVersion = JNIEnv.GetMethodID (class_ref, "getServiceVersion", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getServiceVersion), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_cameraTorchEnable_Z;
#pragma warning disable 0169
		static Delegate GetCameraTorchEnable_ZHandler ()
		{
			if (cb_cameraTorchEnable_Z == null)
				cb_cameraTorchEnable_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_Z) n_CameraTorchEnable_Z);
			return cb_cameraTorchEnable_Z;
		}

		static bool n_CameraTorchEnable_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CameraTorchEnable (p0);
		}
#pragma warning restore 0169

		IntPtr id_cameraTorchEnable_Z;
		public unsafe bool CameraTorchEnable (bool p0)
		{
			if (id_cameraTorchEnable_Z == IntPtr.Zero)
				id_cameraTorchEnable_Z = JNIEnv.GetMethodID (class_ref, "cameraTorchEnable", "(Z)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_cameraTorchEnable_Z, __args);
		}

		static Delegate cb_cancelCapture;
#pragma warning disable 0169
		static Delegate GetCancelCaptureHandler ()
		{
			if (cb_cancelCapture == null)
				cb_cancelCapture = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_CancelCapture);
			return cb_cancelCapture;
		}

		static void n_CancelCapture (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CancelCapture ();
		}
#pragma warning restore 0169

		IntPtr id_cancelCapture;
		public unsafe void CancelCapture ()
		{
			if (id_cancelCapture == IntPtr.Zero)
				id_cancelCapture = JNIEnv.GetMethodID (class_ref, "cancelCapture", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancelCapture);
		}

		static Delegate cb_captureIrises_Lcom_credenceid_biometrics_Biometrics_EyeSelection_Lcom_credenceid_biometrics_Biometrics_OnIrisesCapturedListener_;
#pragma warning disable 0169
		static Delegate GetCaptureIrises_Lcom_credenceid_biometrics_Biometrics_EyeSelection_Lcom_credenceid_biometrics_Biometrics_OnIrisesCapturedListener_Handler ()
		{
			if (cb_captureIrises_Lcom_credenceid_biometrics_Biometrics_EyeSelection_Lcom_credenceid_biometrics_Biometrics_OnIrisesCapturedListener_ == null)
				cb_captureIrises_Lcom_credenceid_biometrics_Biometrics_EyeSelection_Lcom_credenceid_biometrics_Biometrics_OnIrisesCapturedListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_CaptureIrises_Lcom_credenceid_biometrics_Biometrics_EyeSelection_Lcom_credenceid_biometrics_Biometrics_OnIrisesCapturedListener_);
			return cb_captureIrises_Lcom_credenceid_biometrics_Biometrics_EyeSelection_Lcom_credenceid_biometrics_Biometrics_OnIrisesCapturedListener_;
		}

		static void n_CaptureIrises_Lcom_credenceid_biometrics_Biometrics_EyeSelection_Lcom_credenceid_biometrics_Biometrics_OnIrisesCapturedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsEyeSelection> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Credenceid.Biometrics.IBiometricsOnIrisesCapturedListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnIrisesCapturedListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.CaptureIrises (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_captureIrises_Lcom_credenceid_biometrics_Biometrics_EyeSelection_Lcom_credenceid_biometrics_Biometrics_OnIrisesCapturedListener_;
		public unsafe void CaptureIrises (global::Com.Credenceid.Biometrics.BiometricsEyeSelection p0, global::Com.Credenceid.Biometrics.IBiometricsOnIrisesCapturedListener p1)
		{
			if (id_captureIrises_Lcom_credenceid_biometrics_Biometrics_EyeSelection_Lcom_credenceid_biometrics_Biometrics_OnIrisesCapturedListener_ == IntPtr.Zero)
				id_captureIrises_Lcom_credenceid_biometrics_Biometrics_EyeSelection_Lcom_credenceid_biometrics_Biometrics_OnIrisesCapturedListener_ = JNIEnv.GetMethodID (class_ref, "captureIrises", "(Lcom/credenceid/biometrics/Biometrics$EyeSelection;Lcom/credenceid/biometrics/Biometrics$OnIrisesCapturedListener;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_captureIrises_Lcom_credenceid_biometrics_Biometrics_EyeSelection_Lcom_credenceid_biometrics_Biometrics_OnIrisesCapturedListener_, __args);
		}

		static Delegate cb_cardCloseCommand;
#pragma warning disable 0169
		static Delegate GetCardCloseCommandHandler ()
		{
			if (cb_cardCloseCommand == null)
				cb_cardCloseCommand = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_CardCloseCommand);
			return cb_cardCloseCommand;
		}

		static void n_CardCloseCommand (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CardCloseCommand ();
		}
#pragma warning restore 0169

		IntPtr id_cardCloseCommand;
		public unsafe void CardCloseCommand ()
		{
			if (id_cardCloseCommand == IntPtr.Zero)
				id_cardCloseCommand = JNIEnv.GetMethodID (class_ref, "cardCloseCommand", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cardCloseCommand);
		}

		static Delegate cb_cardCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnCardCommandListener_;
#pragma warning disable 0169
		static Delegate GetCardCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnCardCommandListener_Handler ()
		{
			if (cb_cardCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnCardCommandListener_ == null)
				cb_cardCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnCardCommandListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZL_V) n_CardCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnCardCommandListener_);
			return cb_cardCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnCardCommandListener_;
		}

		static void n_CardCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnCardCommandListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.ApduCommand> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.Credenceid.Biometrics.IBiometricsOnCardCommandListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnCardCommandListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.CardCommand (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_cardCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnCardCommandListener_;
		public unsafe void CardCommand (global::Com.Credenceid.Biometrics.ApduCommand p0, bool p1, global::Com.Credenceid.Biometrics.IBiometricsOnCardCommandListener p2)
		{
			if (id_cardCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnCardCommandListener_ == IntPtr.Zero)
				id_cardCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnCardCommandListener_ = JNIEnv.GetMethodID (class_ref, "cardCommand", "(Lcom/credenceid/biometrics/ApduCommand;ZLcom/credenceid/biometrics/Biometrics$OnCardCommandListener;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cardCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnCardCommandListener_, __args);
		}

		static Delegate cb_cardCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnCardCommandSyncResultListener_;
#pragma warning disable 0169
		static Delegate GetCardCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnCardCommandSyncResultListener_Handler ()
		{
			if (cb_cardCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnCardCommandSyncResultListener_ == null)
				cb_cardCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnCardCommandSyncResultListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZL_V) n_CardCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnCardCommandSyncResultListener_);
			return cb_cardCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnCardCommandSyncResultListener_;
		}

		static void n_CardCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnCardCommandSyncResultListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.ApduCommand> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.Credenceid.Biometrics.IBiometricsOnCardCommandSyncResultListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnCardCommandSyncResultListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.CardCommand (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_cardCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnCardCommandSyncResultListener_;
		public unsafe void CardCommand (global::Com.Credenceid.Biometrics.ApduCommand p0, bool p1, global::Com.Credenceid.Biometrics.IBiometricsOnCardCommandSyncResultListener p2)
		{
			if (id_cardCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnCardCommandSyncResultListener_ == IntPtr.Zero)
				id_cardCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnCardCommandSyncResultListener_ = JNIEnv.GetMethodID (class_ref, "cardCommand", "(Lcom/credenceid/biometrics/ApduCommand;ZLcom/credenceid/biometrics/Biometrics$OnCardCommandSyncResultListener;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cardCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnCardCommandSyncResultListener_, __args);
		}

		static Delegate cb_cardConnectSync_I;
#pragma warning disable 0169
		static Delegate GetCardConnectSync_IHandler ()
		{
			if (cb_cardConnectSync_I == null)
				cb_cardConnectSync_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_CardConnectSync_I);
			return cb_cardConnectSync_I;
		}

		static bool n_CardConnectSync_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CardConnectSync (p0);
		}
#pragma warning restore 0169

		IntPtr id_cardConnectSync_I;
		public unsafe bool CardConnectSync (int p0)
		{
			if (id_cardConnectSync_I == IntPtr.Zero)
				id_cardConnectSync_I = JNIEnv.GetMethodID (class_ref, "cardConnectSync", "(I)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_cardConnectSync_I, __args);
		}

		static Delegate cb_cardDisconnectSync_I;
#pragma warning disable 0169
		static Delegate GetCardDisconnectSync_IHandler ()
		{
			if (cb_cardDisconnectSync_I == null)
				cb_cardDisconnectSync_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_CardDisconnectSync_I);
			return cb_cardDisconnectSync_I;
		}

		static bool n_CardDisconnectSync_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CardDisconnectSync (p0);
		}
#pragma warning restore 0169

		IntPtr id_cardDisconnectSync_I;
		public unsafe bool CardDisconnectSync (int p0)
		{
			if (id_cardDisconnectSync_I == IntPtr.Zero)
				id_cardDisconnectSync_I = JNIEnv.GetMethodID (class_ref, "cardDisconnectSync", "(I)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_cardDisconnectSync_I, __args);
		}

		static Delegate cb_cardOpenCommand_Lcom_credenceid_biometrics_Biometrics_CardReaderStatusListener_;
#pragma warning disable 0169
		static Delegate GetCardOpenCommand_Lcom_credenceid_biometrics_Biometrics_CardReaderStatusListener_Handler ()
		{
			if (cb_cardOpenCommand_Lcom_credenceid_biometrics_Biometrics_CardReaderStatusListener_ == null)
				cb_cardOpenCommand_Lcom_credenceid_biometrics_Biometrics_CardReaderStatusListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_CardOpenCommand_Lcom_credenceid_biometrics_Biometrics_CardReaderStatusListener_);
			return cb_cardOpenCommand_Lcom_credenceid_biometrics_Biometrics_CardReaderStatusListener_;
		}

		static void n_CardOpenCommand_Lcom_credenceid_biometrics_Biometrics_CardReaderStatusListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Credenceid.Biometrics.IBiometricsCardReaderStatusListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsCardReaderStatusListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CardOpenCommand (p0);
		}
#pragma warning restore 0169

		IntPtr id_cardOpenCommand_Lcom_credenceid_biometrics_Biometrics_CardReaderStatusListener_;
		public unsafe void CardOpenCommand (global::Com.Credenceid.Biometrics.IBiometricsCardReaderStatusListener p0)
		{
			if (id_cardOpenCommand_Lcom_credenceid_biometrics_Biometrics_CardReaderStatusListener_ == IntPtr.Zero)
				id_cardOpenCommand_Lcom_credenceid_biometrics_Biometrics_CardReaderStatusListener_ = JNIEnv.GetMethodID (class_ref, "cardOpenCommand", "(Lcom/credenceid/biometrics/Biometrics$CardReaderStatusListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cardOpenCommand_Lcom_credenceid_biometrics_Biometrics_CardReaderStatusListener_, __args);
		}

		static Delegate cb_closeFingerprintReader;
#pragma warning disable 0169
		static Delegate GetCloseFingerprintReaderHandler ()
		{
			if (cb_closeFingerprintReader == null)
				cb_closeFingerprintReader = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_CloseFingerprintReader);
			return cb_closeFingerprintReader;
		}

		static void n_CloseFingerprintReader (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CloseFingerprintReader ();
		}
#pragma warning restore 0169

		IntPtr id_closeFingerprintReader;
		public unsafe void CloseFingerprintReader ()
		{
			if (id_closeFingerprintReader == IntPtr.Zero)
				id_closeFingerprintReader = JNIEnv.GetMethodID (class_ref, "closeFingerprintReader", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_closeFingerprintReader);
		}

		static Delegate cb_closeIrisScanner;
#pragma warning disable 0169
		static Delegate GetCloseIrisScannerHandler ()
		{
			if (cb_closeIrisScanner == null)
				cb_closeIrisScanner = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_CloseIrisScanner);
			return cb_closeIrisScanner;
		}

		static void n_CloseIrisScanner (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CloseIrisScanner ();
		}
#pragma warning restore 0169

		IntPtr id_closeIrisScanner;
		public unsafe void CloseIrisScanner ()
		{
			if (id_closeIrisScanner == IntPtr.Zero)
				id_closeIrisScanner = JNIEnv.GetMethodID (class_ref, "closeIrisScanner", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_closeIrisScanner);
		}

		static Delegate cb_closeMRZ;
#pragma warning disable 0169
		static Delegate GetCloseMRZHandler ()
		{
			if (cb_closeMRZ == null)
				cb_closeMRZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_CloseMRZ);
			return cb_closeMRZ;
		}

		static void n_CloseMRZ (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CloseMRZ ();
		}
#pragma warning restore 0169

		IntPtr id_closeMRZ;
		public unsafe void CloseMRZ ()
		{
			if (id_closeMRZ == IntPtr.Zero)
				id_closeMRZ = JNIEnv.GetMethodID (class_ref, "closeMRZ", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_closeMRZ);
		}

		static Delegate cb_compareFMD_arrayBarrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnCompareFMDListener_;
#pragma warning disable 0169
		static Delegate GetCompareFMD_arrayBarrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnCompareFMDListener_Handler ()
		{
			if (cb_compareFMD_arrayBarrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnCompareFMDListener_ == null)
				cb_compareFMD_arrayBarrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnCompareFMDListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_CompareFMD_arrayBarrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnCompareFMDListener_);
			return cb_compareFMD_arrayBarrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnCompareFMDListener_;
		}

		static void n_CompareFMD_arrayBarrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnCompareFMDListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p2 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsFMDFormat> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = (global::Com.Credenceid.Biometrics.IBiometricsOnCompareFMDListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnCompareFMDListener> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.CompareFMD (p0, p1, p2, p3);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		IntPtr id_compareFMD_arrayBarrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnCompareFMDListener_;
		public unsafe void CompareFMD (byte[] p0, byte[] p1, global::Com.Credenceid.Biometrics.BiometricsFMDFormat p2, global::Com.Credenceid.Biometrics.IBiometricsOnCompareFMDListener p3)
		{
			if (id_compareFMD_arrayBarrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnCompareFMDListener_ == IntPtr.Zero)
				id_compareFMD_arrayBarrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnCompareFMDListener_ = JNIEnv.GetMethodID (class_ref, "compareFMD", "([B[BLcom/credenceid/biometrics/Biometrics$FMDFormat;Lcom/credenceid/biometrics/Biometrics$OnCompareFMDListener;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_compareFMD_arrayBarrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnCompareFMDListener_, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_compareFMDSync_arrayBarrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_I;
#pragma warning disable 0169
		static Delegate GetCompareFMDSync_arrayBarrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_IHandler ()
		{
			if (cb_compareFMDSync_arrayBarrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_I == null)
				cb_compareFMDSync_arrayBarrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLI_L) n_CompareFMDSync_arrayBarrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_I);
			return cb_compareFMDSync_arrayBarrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_I;
		}

		static IntPtr n_CompareFMDSync_arrayBarrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, int p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p2 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsFMDFormat> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CompareFMDSync (p0, p1, p2, p3));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_compareFMDSync_arrayBarrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_I;
		public unsafe global::Com.Credenceid.Biometrics.CompareFMDSyncResponse CompareFMDSync (byte[] p0, byte[] p1, global::Com.Credenceid.Biometrics.BiometricsFMDFormat p2, int p3)
		{
			if (id_compareFMDSync_arrayBarrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_I == IntPtr.Zero)
				id_compareFMDSync_arrayBarrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_I = JNIEnv.GetMethodID (class_ref, "compareFMDSync", "([B[BLcom/credenceid/biometrics/Biometrics$FMDFormat;I)Lcom/credenceid/biometrics/CompareFMDSyncResponse;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.CompareFMDSyncResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_compareFMDSync_arrayBarrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_I, __args), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate cb_compressToWSQ_Ljava_lang_String_FLcom_credenceid_biometrics_Biometrics_OnCompressToWSQListener_;
#pragma warning disable 0169
		static Delegate GetCompressToWSQ_Ljava_lang_String_FLcom_credenceid_biometrics_Biometrics_OnCompressToWSQListener_Handler ()
		{
			if (cb_compressToWSQ_Ljava_lang_String_FLcom_credenceid_biometrics_Biometrics_OnCompressToWSQListener_ == null)
				cb_compressToWSQ_Ljava_lang_String_FLcom_credenceid_biometrics_Biometrics_OnCompressToWSQListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLFL_V) n_CompressToWSQ_Ljava_lang_String_FLcom_credenceid_biometrics_Biometrics_OnCompressToWSQListener_);
			return cb_compressToWSQ_Ljava_lang_String_FLcom_credenceid_biometrics_Biometrics_OnCompressToWSQListener_;
		}

		static void n_CompressToWSQ_Ljava_lang_String_FLcom_credenceid_biometrics_Biometrics_OnCompressToWSQListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.Credenceid.Biometrics.IBiometricsOnCompressToWSQListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnCompressToWSQListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.CompressToWSQ (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_compressToWSQ_Ljava_lang_String_FLcom_credenceid_biometrics_Biometrics_OnCompressToWSQListener_;
		public unsafe void CompressToWSQ (string p0, float p1, global::Com.Credenceid.Biometrics.IBiometricsOnCompressToWSQListener p2)
		{
			if (id_compressToWSQ_Ljava_lang_String_FLcom_credenceid_biometrics_Biometrics_OnCompressToWSQListener_ == IntPtr.Zero)
				id_compressToWSQ_Ljava_lang_String_FLcom_credenceid_biometrics_Biometrics_OnCompressToWSQListener_ = JNIEnv.GetMethodID (class_ref, "compressToWSQ", "(Ljava/lang/String;FLcom/credenceid/biometrics/Biometrics$OnCompressToWSQListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_compressToWSQ_Ljava_lang_String_FLcom_credenceid_biometrics_Biometrics_OnCompressToWSQListener_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_convertCCFToFMD_arrayBLcom_credenceid_biometrics_Biometrics_OnCCFToFMDConversionListener_;
#pragma warning disable 0169
		static Delegate GetConvertCCFToFMD_arrayBLcom_credenceid_biometrics_Biometrics_OnCCFToFMDConversionListener_Handler ()
		{
			if (cb_convertCCFToFMD_arrayBLcom_credenceid_biometrics_Biometrics_OnCCFToFMDConversionListener_ == null)
				cb_convertCCFToFMD_arrayBLcom_credenceid_biometrics_Biometrics_OnCCFToFMDConversionListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_ConvertCCFToFMD_arrayBLcom_credenceid_biometrics_Biometrics_OnCCFToFMDConversionListener_);
			return cb_convertCCFToFMD_arrayBLcom_credenceid_biometrics_Biometrics_OnCCFToFMDConversionListener_;
		}

		static void n_ConvertCCFToFMD_arrayBLcom_credenceid_biometrics_Biometrics_OnCCFToFMDConversionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p1 = (global::Com.Credenceid.Biometrics.IBiometricsOnCCFToFMDConversionListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnCCFToFMDConversionListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ConvertCCFToFMD (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_convertCCFToFMD_arrayBLcom_credenceid_biometrics_Biometrics_OnCCFToFMDConversionListener_;
		public unsafe void ConvertCCFToFMD (byte[] p0, global::Com.Credenceid.Biometrics.IBiometricsOnCCFToFMDConversionListener p1)
		{
			if (id_convertCCFToFMD_arrayBLcom_credenceid_biometrics_Biometrics_OnCCFToFMDConversionListener_ == IntPtr.Zero)
				id_convertCCFToFMD_arrayBLcom_credenceid_biometrics_Biometrics_OnCCFToFMDConversionListener_ = JNIEnv.GetMethodID (class_ref, "convertCCFToFMD", "([BLcom/credenceid/biometrics/Biometrics$OnCCFToFMDConversionListener;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_convertCCFToFMD_arrayBLcom_credenceid_biometrics_Biometrics_OnCCFToFMDConversionListener_, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_convertCCFToFMD_arrayBSSSSLcom_credenceid_biometrics_Biometrics_OnCCFToFMDConversionListener_;
#pragma warning disable 0169
		static Delegate GetConvertCCFToFMD_arrayBSSSSLcom_credenceid_biometrics_Biometrics_OnCCFToFMDConversionListener_Handler ()
		{
			if (cb_convertCCFToFMD_arrayBSSSSLcom_credenceid_biometrics_Biometrics_OnCCFToFMDConversionListener_ == null)
				cb_convertCCFToFMD_arrayBSSSSLcom_credenceid_biometrics_Biometrics_OnCCFToFMDConversionListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLSSSSL_V) n_ConvertCCFToFMD_arrayBSSSSLcom_credenceid_biometrics_Biometrics_OnCCFToFMDConversionListener_);
			return cb_convertCCFToFMD_arrayBSSSSLcom_credenceid_biometrics_Biometrics_OnCCFToFMDConversionListener_;
		}

		static void n_ConvertCCFToFMD_arrayBSSSSLcom_credenceid_biometrics_Biometrics_OnCCFToFMDConversionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, short p1, short p2, short p3, short p4, IntPtr native_p5)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p5 = (global::Com.Credenceid.Biometrics.IBiometricsOnCCFToFMDConversionListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnCCFToFMDConversionListener> (native_p5, JniHandleOwnership.DoNotTransfer);
			__this.ConvertCCFToFMD (p0, p1, p2, p3, p4, p5);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_convertCCFToFMD_arrayBSSSSLcom_credenceid_biometrics_Biometrics_OnCCFToFMDConversionListener_;
		public unsafe void ConvertCCFToFMD (byte[] p0, short p1, short p2, short p3, short p4, global::Com.Credenceid.Biometrics.IBiometricsOnCCFToFMDConversionListener p5)
		{
			if (id_convertCCFToFMD_arrayBSSSSLcom_credenceid_biometrics_Biometrics_OnCCFToFMDConversionListener_ == IntPtr.Zero)
				id_convertCCFToFMD_arrayBSSSSLcom_credenceid_biometrics_Biometrics_OnCCFToFMDConversionListener_ = JNIEnv.GetMethodID (class_ref, "convertCCFToFMD", "([BSSSSLcom/credenceid/biometrics/Biometrics$OnCCFToFMDConversionListener;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [6];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (p4);
			__args [5] = new JValue (p5);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_convertCCFToFMD_arrayBSSSSLcom_credenceid_biometrics_Biometrics_OnCCFToFMDConversionListener_, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_convertCCFToFMDSync_arrayBSSSSI;
#pragma warning disable 0169
		static Delegate GetConvertCCFToFMDSync_arrayBSSSSIHandler ()
		{
			if (cb_convertCCFToFMDSync_arrayBSSSSI == null)
				cb_convertCCFToFMDSync_arrayBSSSSI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLSSSSI_L) n_ConvertCCFToFMDSync_arrayBSSSSI);
			return cb_convertCCFToFMDSync_arrayBSSSSI;
		}

		static IntPtr n_ConvertCCFToFMDSync_arrayBSSSSI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, short p1, short p2, short p3, short p4, int p5)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ConvertCCFToFMDSync (p0, p1, p2, p3, p4, p5));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_convertCCFToFMDSync_arrayBSSSSI;
		public unsafe global::Com.Credenceid.Biometrics.CCFToFMDSyncResponse ConvertCCFToFMDSync (byte[] p0, short p1, short p2, short p3, short p4, int p5)
		{
			if (id_convertCCFToFMDSync_arrayBSSSSI == IntPtr.Zero)
				id_convertCCFToFMDSync_arrayBSSSSI = JNIEnv.GetMethodID (class_ref, "convertCCFToFMDSync", "([BSSSSI)Lcom/credenceid/biometrics/CCFToFMDSyncResponse;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [6];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (p4);
			__args [5] = new JValue (p5);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.CCFToFMDSyncResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_convertCCFToFMDSync_arrayBSSSSI, __args), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_convertFMDToCCF_arrayBLcom_credenceid_biometrics_Biometrics_OnFMDToCCFConversionListener_;
#pragma warning disable 0169
		static Delegate GetConvertFMDToCCF_arrayBLcom_credenceid_biometrics_Biometrics_OnFMDToCCFConversionListener_Handler ()
		{
			if (cb_convertFMDToCCF_arrayBLcom_credenceid_biometrics_Biometrics_OnFMDToCCFConversionListener_ == null)
				cb_convertFMDToCCF_arrayBLcom_credenceid_biometrics_Biometrics_OnFMDToCCFConversionListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_ConvertFMDToCCF_arrayBLcom_credenceid_biometrics_Biometrics_OnFMDToCCFConversionListener_);
			return cb_convertFMDToCCF_arrayBLcom_credenceid_biometrics_Biometrics_OnFMDToCCFConversionListener_;
		}

		static void n_ConvertFMDToCCF_arrayBLcom_credenceid_biometrics_Biometrics_OnFMDToCCFConversionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p1 = (global::Com.Credenceid.Biometrics.IBiometricsOnFMDToCCFConversionListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnFMDToCCFConversionListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ConvertFMDToCCF (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_convertFMDToCCF_arrayBLcom_credenceid_biometrics_Biometrics_OnFMDToCCFConversionListener_;
		public unsafe void ConvertFMDToCCF (byte[] p0, global::Com.Credenceid.Biometrics.IBiometricsOnFMDToCCFConversionListener p1)
		{
			if (id_convertFMDToCCF_arrayBLcom_credenceid_biometrics_Biometrics_OnFMDToCCFConversionListener_ == IntPtr.Zero)
				id_convertFMDToCCF_arrayBLcom_credenceid_biometrics_Biometrics_OnFMDToCCFConversionListener_ = JNIEnv.GetMethodID (class_ref, "convertFMDToCCF", "([BLcom/credenceid/biometrics/Biometrics$OnFMDToCCFConversionListener;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_convertFMDToCCF_arrayBLcom_credenceid_biometrics_Biometrics_OnFMDToCCFConversionListener_, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_convertFMDToCCFSync_arrayBI;
#pragma warning disable 0169
		static Delegate GetConvertFMDToCCFSync_arrayBIHandler ()
		{
			if (cb_convertFMDToCCFSync_arrayBI == null)
				cb_convertFMDToCCFSync_arrayBI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_L) n_ConvertFMDToCCFSync_arrayBI);
			return cb_convertFMDToCCFSync_arrayBI;
		}

		static IntPtr n_ConvertFMDToCCFSync_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ConvertFMDToCCFSync (p0, p1));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_convertFMDToCCFSync_arrayBI;
		public unsafe global::Com.Credenceid.Biometrics.FMDToCCFSyncResponse ConvertFMDToCCFSync (byte[] p0, int p1)
		{
			if (id_convertFMDToCCFSync_arrayBI == IntPtr.Zero)
				id_convertFMDToCCFSync_arrayBI = JNIEnv.GetMethodID (class_ref, "convertFMDToCCFSync", "([BI)Lcom/credenceid/biometrics/FMDToCCFSyncResponse;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.FMDToCCFSyncResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_convertFMDToCCFSync_arrayBI, __args), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_convertToFMD_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnConvertToFMDListener_;
#pragma warning disable 0169
		static Delegate GetConvertToFMD_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnConvertToFMDListener_Handler ()
		{
			if (cb_convertToFMD_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnConvertToFMDListener_ == null)
				cb_convertToFMD_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnConvertToFMDListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_ConvertToFMD_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnConvertToFMDListener_);
			return cb_convertToFMD_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnConvertToFMDListener_;
		}

		static void n_ConvertToFMD_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnConvertToFMDListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsFMDFormat> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.Credenceid.Biometrics.IBiometricsOnConvertToFMDListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnConvertToFMDListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.ConvertToFMD (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_convertToFMD_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnConvertToFMDListener_;
		public unsafe void ConvertToFMD (global::Android.Graphics.Bitmap p0, global::Com.Credenceid.Biometrics.BiometricsFMDFormat p1, global::Com.Credenceid.Biometrics.IBiometricsOnConvertToFMDListener p2)
		{
			if (id_convertToFMD_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnConvertToFMDListener_ == IntPtr.Zero)
				id_convertToFMD_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnConvertToFMDListener_ = JNIEnv.GetMethodID (class_ref, "convertToFMD", "(Landroid/graphics/Bitmap;Lcom/credenceid/biometrics/Biometrics$FMDFormat;Lcom/credenceid/biometrics/Biometrics$OnConvertToFMDListener;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_convertToFMD_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnConvertToFMDListener_, __args);
		}

		static Delegate cb_convertToFMD_arrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnConvertToFMDListener_;
#pragma warning disable 0169
		static Delegate GetConvertToFMD_arrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnConvertToFMDListener_Handler ()
		{
			if (cb_convertToFMD_arrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnConvertToFMDListener_ == null)
				cb_convertToFMD_arrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnConvertToFMDListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_ConvertToFMD_arrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnConvertToFMDListener_);
			return cb_convertToFMD_arrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnConvertToFMDListener_;
		}

		static void n_ConvertToFMD_arrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnConvertToFMDListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsFMDFormat> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.Credenceid.Biometrics.IBiometricsOnConvertToFMDListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnConvertToFMDListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.ConvertToFMD (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_convertToFMD_arrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnConvertToFMDListener_;
		public unsafe void ConvertToFMD (byte[] p0, global::Com.Credenceid.Biometrics.BiometricsFMDFormat p1, global::Com.Credenceid.Biometrics.IBiometricsOnConvertToFMDListener p2)
		{
			if (id_convertToFMD_arrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnConvertToFMDListener_ == IntPtr.Zero)
				id_convertToFMD_arrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnConvertToFMDListener_ = JNIEnv.GetMethodID (class_ref, "convertToFMD", "([BLcom/credenceid/biometrics/Biometrics$FMDFormat;Lcom/credenceid/biometrics/Biometrics$OnConvertToFMDListener;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_convertToFMD_arrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_Lcom_credenceid_biometrics_Biometrics_OnConvertToFMDListener_, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_convertToFMDSync_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_FMDFormat_I;
#pragma warning disable 0169
		static Delegate GetConvertToFMDSync_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_FMDFormat_IHandler ()
		{
			if (cb_convertToFMDSync_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_FMDFormat_I == null)
				cb_convertToFMDSync_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_FMDFormat_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLI_L) n_ConvertToFMDSync_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_FMDFormat_I);
			return cb_convertToFMDSync_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_FMDFormat_I;
		}

		static IntPtr n_ConvertToFMDSync_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_FMDFormat_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsFMDFormat> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ConvertToFMDSync (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_convertToFMDSync_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_FMDFormat_I;
		public unsafe global::Com.Credenceid.Biometrics.ConvertToFMDSyncResponse ConvertToFMDSync (global::Android.Graphics.Bitmap p0, global::Com.Credenceid.Biometrics.BiometricsFMDFormat p1, int p2)
		{
			if (id_convertToFMDSync_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_FMDFormat_I == IntPtr.Zero)
				id_convertToFMDSync_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_FMDFormat_I = JNIEnv.GetMethodID (class_ref, "convertToFMDSync", "(Landroid/graphics/Bitmap;Lcom/credenceid/biometrics/Biometrics$FMDFormat;I)Lcom/credenceid/biometrics/ConvertToFMDSyncResponse;");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.ConvertToFMDSyncResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_convertToFMDSync_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_FMDFormat_I, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_convertToFMDSync_arrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_I;
#pragma warning disable 0169
		static Delegate GetConvertToFMDSync_arrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_IHandler ()
		{
			if (cb_convertToFMDSync_arrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_I == null)
				cb_convertToFMDSync_arrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLI_L) n_ConvertToFMDSync_arrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_I);
			return cb_convertToFMDSync_arrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_I;
		}

		static IntPtr n_ConvertToFMDSync_arrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsFMDFormat> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ConvertToFMDSync (p0, p1, p2));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_convertToFMDSync_arrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_I;
		public unsafe global::Com.Credenceid.Biometrics.ConvertToFMDSyncResponse ConvertToFMDSync (byte[] p0, global::Com.Credenceid.Biometrics.BiometricsFMDFormat p1, int p2)
		{
			if (id_convertToFMDSync_arrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_I == IntPtr.Zero)
				id_convertToFMDSync_arrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_I = JNIEnv.GetMethodID (class_ref, "convertToFMDSync", "([BLcom/credenceid/biometrics/Biometrics$FMDFormat;I)Lcom/credenceid/biometrics/ConvertToFMDSyncResponse;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.ConvertToFMDSyncResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_convertToFMDSync_arrayBLcom_credenceid_biometrics_Biometrics_FMDFormat_I, __args), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_decompressWSQ_arrayBLcom_credenceid_biometrics_Biometrics_OnDecompressWSQListener_;
#pragma warning disable 0169
		static Delegate GetDecompressWSQ_arrayBLcom_credenceid_biometrics_Biometrics_OnDecompressWSQListener_Handler ()
		{
			if (cb_decompressWSQ_arrayBLcom_credenceid_biometrics_Biometrics_OnDecompressWSQListener_ == null)
				cb_decompressWSQ_arrayBLcom_credenceid_biometrics_Biometrics_OnDecompressWSQListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_DecompressWSQ_arrayBLcom_credenceid_biometrics_Biometrics_OnDecompressWSQListener_);
			return cb_decompressWSQ_arrayBLcom_credenceid_biometrics_Biometrics_OnDecompressWSQListener_;
		}

		static void n_DecompressWSQ_arrayBLcom_credenceid_biometrics_Biometrics_OnDecompressWSQListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p1 = (global::Com.Credenceid.Biometrics.IBiometricsOnDecompressWSQListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnDecompressWSQListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.DecompressWSQ (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_decompressWSQ_arrayBLcom_credenceid_biometrics_Biometrics_OnDecompressWSQListener_;
		public unsafe void DecompressWSQ (byte[] p0, global::Com.Credenceid.Biometrics.IBiometricsOnDecompressWSQListener p1)
		{
			if (id_decompressWSQ_arrayBLcom_credenceid_biometrics_Biometrics_OnDecompressWSQListener_ == IntPtr.Zero)
				id_decompressWSQ_arrayBLcom_credenceid_biometrics_Biometrics_OnDecompressWSQListener_ = JNIEnv.GetMethodID (class_ref, "decompressWSQ", "([BLcom/credenceid/biometrics/Biometrics$OnDecompressWSQListener;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_decompressWSQ_arrayBLcom_credenceid_biometrics_Biometrics_OnDecompressWSQListener_, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_decompressWSQ_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_OnDecompressWSQListener_;
#pragma warning disable 0169
		static Delegate GetDecompressWSQ_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_OnDecompressWSQListener_Handler ()
		{
			if (cb_decompressWSQ_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_OnDecompressWSQListener_ == null)
				cb_decompressWSQ_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_OnDecompressWSQListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_DecompressWSQ_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_OnDecompressWSQListener_);
			return cb_decompressWSQ_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_OnDecompressWSQListener_;
		}

		static void n_DecompressWSQ_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_OnDecompressWSQListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Credenceid.Biometrics.IBiometricsOnDecompressWSQListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnDecompressWSQListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.DecompressWSQ (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_decompressWSQ_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_OnDecompressWSQListener_;
		public unsafe void DecompressWSQ (string p0, global::Com.Credenceid.Biometrics.IBiometricsOnDecompressWSQListener p1)
		{
			if (id_decompressWSQ_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_OnDecompressWSQListener_ == IntPtr.Zero)
				id_decompressWSQ_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_OnDecompressWSQListener_ = JNIEnv.GetMethodID (class_ref, "decompressWSQ", "(Ljava/lang/String;Lcom/credenceid/biometrics/Biometrics$OnDecompressWSQListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_decompressWSQ_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_OnDecompressWSQListener_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_ePassportCloseCommand;
#pragma warning disable 0169
		static Delegate GetEPassportCloseCommandHandler ()
		{
			if (cb_ePassportCloseCommand == null)
				cb_ePassportCloseCommand = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_EPassportCloseCommand);
			return cb_ePassportCloseCommand;
		}

		static void n_EPassportCloseCommand (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EPassportCloseCommand ();
		}
#pragma warning restore 0169

		IntPtr id_ePassportCloseCommand;
		public unsafe void EPassportCloseCommand ()
		{
			if (id_ePassportCloseCommand == IntPtr.Zero)
				id_ePassportCloseCommand = JNIEnv.GetMethodID (class_ref, "ePassportCloseCommand", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_ePassportCloseCommand);
		}

		static Delegate cb_ePassportCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnEPassportCommandListener_;
#pragma warning disable 0169
		static Delegate GetEPassportCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnEPassportCommandListener_Handler ()
		{
			if (cb_ePassportCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnEPassportCommandListener_ == null)
				cb_ePassportCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnEPassportCommandListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZL_V) n_EPassportCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnEPassportCommandListener_);
			return cb_ePassportCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnEPassportCommandListener_;
		}

		static void n_EPassportCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnEPassportCommandListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.ApduCommand> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.Credenceid.Biometrics.IBiometricsOnEPassportCommandListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnEPassportCommandListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.EPassportCommand (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_ePassportCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnEPassportCommandListener_;
		public unsafe void EPassportCommand (global::Com.Credenceid.Biometrics.ApduCommand p0, bool p1, global::Com.Credenceid.Biometrics.IBiometricsOnEPassportCommandListener p2)
		{
			if (id_ePassportCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnEPassportCommandListener_ == IntPtr.Zero)
				id_ePassportCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnEPassportCommandListener_ = JNIEnv.GetMethodID (class_ref, "ePassportCommand", "(Lcom/credenceid/biometrics/ApduCommand;ZLcom/credenceid/biometrics/Biometrics$OnEPassportCommandListener;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_ePassportCommand_Lcom_credenceid_biometrics_ApduCommand_ZLcom_credenceid_biometrics_Biometrics_OnEPassportCommandListener_, __args);
		}

		static Delegate cb_ePassportOpenCommand_Lcom_credenceid_biometrics_Biometrics_EPassportReaderStatusListener_;
#pragma warning disable 0169
		static Delegate GetEPassportOpenCommand_Lcom_credenceid_biometrics_Biometrics_EPassportReaderStatusListener_Handler ()
		{
			if (cb_ePassportOpenCommand_Lcom_credenceid_biometrics_Biometrics_EPassportReaderStatusListener_ == null)
				cb_ePassportOpenCommand_Lcom_credenceid_biometrics_Biometrics_EPassportReaderStatusListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_EPassportOpenCommand_Lcom_credenceid_biometrics_Biometrics_EPassportReaderStatusListener_);
			return cb_ePassportOpenCommand_Lcom_credenceid_biometrics_Biometrics_EPassportReaderStatusListener_;
		}

		static void n_EPassportOpenCommand_Lcom_credenceid_biometrics_Biometrics_EPassportReaderStatusListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Credenceid.Biometrics.IBiometricsEPassportReaderStatusListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsEPassportReaderStatusListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EPassportOpenCommand (p0);
		}
#pragma warning restore 0169

		IntPtr id_ePassportOpenCommand_Lcom_credenceid_biometrics_Biometrics_EPassportReaderStatusListener_;
		public unsafe void EPassportOpenCommand (global::Com.Credenceid.Biometrics.IBiometricsEPassportReaderStatusListener p0)
		{
			if (id_ePassportOpenCommand_Lcom_credenceid_biometrics_Biometrics_EPassportReaderStatusListener_ == IntPtr.Zero)
				id_ePassportOpenCommand_Lcom_credenceid_biometrics_Biometrics_EPassportReaderStatusListener_ = JNIEnv.GetMethodID (class_ref, "ePassportOpenCommand", "(Lcom/credenceid/biometrics/Biometrics$EPassportReaderStatusListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_ePassportOpenCommand_Lcom_credenceid_biometrics_Biometrics_EPassportReaderStatusListener_, __args);
		}

		static Delegate cb_ektpCardReadCommand_IarrayBLcom_credenceid_biometrics_Biometrics_OnEktpCardReadListener_;
#pragma warning disable 0169
		static Delegate GetEktpCardReadCommand_IarrayBLcom_credenceid_biometrics_Biometrics_OnEktpCardReadListener_Handler ()
		{
			if (cb_ektpCardReadCommand_IarrayBLcom_credenceid_biometrics_Biometrics_OnEktpCardReadListener_ == null)
				cb_ektpCardReadCommand_IarrayBLcom_credenceid_biometrics_Biometrics_OnEktpCardReadListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPILL_V) n_EktpCardReadCommand_IarrayBLcom_credenceid_biometrics_Biometrics_OnEktpCardReadListener_);
			return cb_ektpCardReadCommand_IarrayBLcom_credenceid_biometrics_Biometrics_OnEktpCardReadListener_;
		}

		static void n_EktpCardReadCommand_IarrayBLcom_credenceid_biometrics_Biometrics_OnEktpCardReadListener_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p2 = (global::Com.Credenceid.Biometrics.IBiometricsOnEktpCardReadListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnEktpCardReadListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.EktpCardReadCommand (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		IntPtr id_ektpCardReadCommand_IarrayBLcom_credenceid_biometrics_Biometrics_OnEktpCardReadListener_;
		public unsafe void EktpCardReadCommand (int p0, byte[] p1, global::Com.Credenceid.Biometrics.IBiometricsOnEktpCardReadListener p2)
		{
			if (id_ektpCardReadCommand_IarrayBLcom_credenceid_biometrics_Biometrics_OnEktpCardReadListener_ == IntPtr.Zero)
				id_ektpCardReadCommand_IarrayBLcom_credenceid_biometrics_Biometrics_OnEktpCardReadListener_ = JNIEnv.GetMethodID (class_ref, "ektpCardReadCommand", "(I[BLcom/credenceid/biometrics/Biometrics$OnEktpCardReadListener;)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_ektpCardReadCommand_IarrayBLcom_credenceid_biometrics_Biometrics_OnEktpCardReadListener_, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_finalizeBiometrics_Z;
#pragma warning disable 0169
		static Delegate GetFinalizeBiometrics_ZHandler ()
		{
			if (cb_finalizeBiometrics_Z == null)
				cb_finalizeBiometrics_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_FinalizeBiometrics_Z);
			return cb_finalizeBiometrics_Z;
		}

		static void n_FinalizeBiometrics_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FinalizeBiometrics (p0);
		}
#pragma warning restore 0169

		IntPtr id_finalizeBiometrics_Z;
		public unsafe void FinalizeBiometrics (bool p0)
		{
			if (id_finalizeBiometrics_Z == IntPtr.Zero)
				id_finalizeBiometrics_Z = JNIEnv.GetMethodID (class_ref, "finalizeBiometrics", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_finalizeBiometrics_Z, __args);
		}

		static Delegate cb_generateTerminalIsCertificate_Lcom_credenceid_biometrics_Biometrics_generateTerminalIsCertificateListener_;
#pragma warning disable 0169
		static Delegate GetGenerateTerminalIsCertificate_Lcom_credenceid_biometrics_Biometrics_generateTerminalIsCertificateListener_Handler ()
		{
			if (cb_generateTerminalIsCertificate_Lcom_credenceid_biometrics_Biometrics_generateTerminalIsCertificateListener_ == null)
				cb_generateTerminalIsCertificate_Lcom_credenceid_biometrics_Biometrics_generateTerminalIsCertificateListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_GenerateTerminalIsCertificate_Lcom_credenceid_biometrics_Biometrics_generateTerminalIsCertificateListener_);
			return cb_generateTerminalIsCertificate_Lcom_credenceid_biometrics_Biometrics_generateTerminalIsCertificateListener_;
		}

		static void n_GenerateTerminalIsCertificate_Lcom_credenceid_biometrics_Biometrics_generateTerminalIsCertificateListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Credenceid.Biometrics.IBiometricsGenerateTerminalIsCertificateListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsGenerateTerminalIsCertificateListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GenerateTerminalIsCertificate (p0);
		}
#pragma warning restore 0169

		IntPtr id_generateTerminalIsCertificate_Lcom_credenceid_biometrics_Biometrics_generateTerminalIsCertificateListener_;
		public unsafe void GenerateTerminalIsCertificate (global::Com.Credenceid.Biometrics.IBiometricsGenerateTerminalIsCertificateListener p0)
		{
			if (id_generateTerminalIsCertificate_Lcom_credenceid_biometrics_Biometrics_generateTerminalIsCertificateListener_ == IntPtr.Zero)
				id_generateTerminalIsCertificate_Lcom_credenceid_biometrics_Biometrics_generateTerminalIsCertificateListener_ = JNIEnv.GetMethodID (class_ref, "generateTerminalIsCertificate", "(Lcom/credenceid/biometrics/Biometrics$generateTerminalIsCertificateListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_generateTerminalIsCertificate_Lcom_credenceid_biometrics_Biometrics_generateTerminalIsCertificateListener_, __args);
		}

		static Delegate cb_getFingerQuality_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_OnGetFingerQualityListener_;
#pragma warning disable 0169
		static Delegate GetGetFingerQuality_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_OnGetFingerQualityListener_Handler ()
		{
			if (cb_getFingerQuality_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_OnGetFingerQualityListener_ == null)
				cb_getFingerQuality_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_OnGetFingerQualityListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_GetFingerQuality_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_OnGetFingerQualityListener_);
			return cb_getFingerQuality_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_OnGetFingerQualityListener_;
		}

		static void n_GetFingerQuality_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_OnGetFingerQualityListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Credenceid.Biometrics.IBiometricsOnGetFingerQualityListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnGetFingerQualityListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.GetFingerQuality (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_getFingerQuality_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_OnGetFingerQualityListener_;
		public unsafe void GetFingerQuality (global::Android.Graphics.Bitmap p0, global::Com.Credenceid.Biometrics.IBiometricsOnGetFingerQualityListener p1)
		{
			if (id_getFingerQuality_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_OnGetFingerQualityListener_ == IntPtr.Zero)
				id_getFingerQuality_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_OnGetFingerQualityListener_ = JNIEnv.GetMethodID (class_ref, "getFingerQuality", "(Landroid/graphics/Bitmap;Lcom/credenceid/biometrics/Biometrics$OnGetFingerQualityListener;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getFingerQuality_Landroid_graphics_Bitmap_Lcom_credenceid_biometrics_Biometrics_OnGetFingerQualityListener_, __args);
		}

		static Delegate cb_getFingerQuality_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_OnFingerQualityListener_;
#pragma warning disable 0169
		static Delegate GetGetFingerQuality_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_OnFingerQualityListener_Handler ()
		{
			if (cb_getFingerQuality_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_OnFingerQualityListener_ == null)
				cb_getFingerQuality_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_OnFingerQualityListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_GetFingerQuality_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_OnFingerQualityListener_);
			return cb_getFingerQuality_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_OnFingerQualityListener_;
		}

		static void n_GetFingerQuality_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_OnFingerQualityListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Credenceid.Biometrics.IBiometricsOnFingerQualityListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnFingerQualityListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.GetFingerQuality (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_getFingerQuality_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_OnFingerQualityListener_;
		public unsafe void GetFingerQuality (string p0, global::Com.Credenceid.Biometrics.IBiometricsOnFingerQualityListener p1)
		{
			if (id_getFingerQuality_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_OnFingerQualityListener_ == IntPtr.Zero)
				id_getFingerQuality_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_OnFingerQualityListener_ = JNIEnv.GetMethodID (class_ref, "getFingerQuality", "(Ljava/lang/String;Lcom/credenceid/biometrics/Biometrics$OnFingerQualityListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getFingerQuality_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_OnFingerQualityListener_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_getPreferences_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_PreferencesListener_;
#pragma warning disable 0169
		static Delegate GetGetPreferences_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_PreferencesListener_Handler ()
		{
			if (cb_getPreferences_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_PreferencesListener_ == null)
				cb_getPreferences_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_PreferencesListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_GetPreferences_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_PreferencesListener_);
			return cb_getPreferences_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_PreferencesListener_;
		}

		static void n_GetPreferences_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_PreferencesListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Credenceid.Biometrics.IBiometricsPreferencesListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsPreferencesListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.GetPreferences (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_getPreferences_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_PreferencesListener_;
		public unsafe void GetPreferences (string p0, global::Com.Credenceid.Biometrics.IBiometricsPreferencesListener p1)
		{
			if (id_getPreferences_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_PreferencesListener_ == IntPtr.Zero)
				id_getPreferences_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_PreferencesListener_ = JNIEnv.GetMethodID (class_ref, "getPreferences", "(Ljava/lang/String;Lcom/credenceid/biometrics/Biometrics$PreferencesListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getPreferences_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_PreferencesListener_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_getProviderDetails_Lcom_credenceid_biometrics_Biometrics_OnGetProviderDetailsListener_;
#pragma warning disable 0169
		static Delegate GetGetProviderDetails_Lcom_credenceid_biometrics_Biometrics_OnGetProviderDetailsListener_Handler ()
		{
			if (cb_getProviderDetails_Lcom_credenceid_biometrics_Biometrics_OnGetProviderDetailsListener_ == null)
				cb_getProviderDetails_Lcom_credenceid_biometrics_Biometrics_OnGetProviderDetailsListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_GetProviderDetails_Lcom_credenceid_biometrics_Biometrics_OnGetProviderDetailsListener_);
			return cb_getProviderDetails_Lcom_credenceid_biometrics_Biometrics_OnGetProviderDetailsListener_;
		}

		static void n_GetProviderDetails_Lcom_credenceid_biometrics_Biometrics_OnGetProviderDetailsListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Credenceid.Biometrics.IBiometricsOnGetProviderDetailsListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnGetProviderDetailsListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetProviderDetails (p0);
		}
#pragma warning restore 0169

		IntPtr id_getProviderDetails_Lcom_credenceid_biometrics_Biometrics_OnGetProviderDetailsListener_;
		public unsafe void GetProviderDetails (global::Com.Credenceid.Biometrics.IBiometricsOnGetProviderDetailsListener p0)
		{
			if (id_getProviderDetails_Lcom_credenceid_biometrics_Biometrics_OnGetProviderDetailsListener_ == IntPtr.Zero)
				id_getProviderDetails_Lcom_credenceid_biometrics_Biometrics_OnGetProviderDetailsListener_ = JNIEnv.GetMethodID (class_ref, "getProviderDetails", "(Lcom/credenceid/biometrics/Biometrics$OnGetProviderDetailsListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getProviderDetails_Lcom_credenceid_biometrics_Biometrics_OnGetProviderDetailsListener_, __args);
		}

		static Delegate cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedFullListener_;
#pragma warning disable 0169
		static Delegate GetGrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedFullListener_Handler ()
		{
			if (cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedFullListener_ == null)
				cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedFullListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZL_V) n_GrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedFullListener_);
			return cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedFullListener_;
		}

		static void n_GrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedFullListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsScanType> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedFullListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedFullListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.GrabFingerprint (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedFullListener_;
		public unsafe void GrabFingerprint (global::Com.Credenceid.Biometrics.BiometricsScanType p0, bool p1, global::Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedFullListener p2)
		{
			if (id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedFullListener_ == IntPtr.Zero)
				id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedFullListener_ = JNIEnv.GetMethodID (class_ref, "grabFingerprint", "(Lcom/credenceid/biometrics/Biometrics$ScanType;ZLcom/credenceid/biometrics/Biometrics$OnFingerprintGrabbedFullListener;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedFullListener_, __args);
		}

		static Delegate cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedListener_;
#pragma warning disable 0169
		static Delegate GetGrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedListener_Handler ()
		{
			if (cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedListener_ == null)
				cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZL_V) n_GrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedListener_);
			return cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedListener_;
		}

		static void n_GrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsScanType> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.GrabFingerprint (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedListener_;
		public unsafe void GrabFingerprint (global::Com.Credenceid.Biometrics.BiometricsScanType p0, bool p1, global::Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedListener p2)
		{
			if (id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedListener_ == IntPtr.Zero)
				id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedListener_ = JNIEnv.GetMethodID (class_ref, "grabFingerprint", "(Lcom/credenceid/biometrics/Biometrics$ScanType;ZLcom/credenceid/biometrics/Biometrics$OnFingerprintGrabbedListener;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedListener_, __args);
		}

		static Delegate cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedRawListener_;
#pragma warning disable 0169
		static Delegate GetGrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedRawListener_Handler ()
		{
			if (cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedRawListener_ == null)
				cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedRawListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZL_V) n_GrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedRawListener_);
			return cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedRawListener_;
		}

		static void n_GrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedRawListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsScanType> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedRawListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedRawListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.GrabFingerprint (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedRawListener_;
		public unsafe void GrabFingerprint (global::Com.Credenceid.Biometrics.BiometricsScanType p0, bool p1, global::Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedRawListener p2)
		{
			if (id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedRawListener_ == IntPtr.Zero)
				id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedRawListener_ = JNIEnv.GetMethodID (class_ref, "grabFingerprint", "(Lcom/credenceid/biometrics/Biometrics$ScanType;ZLcom/credenceid/biometrics/Biometrics$OnFingerprintGrabbedRawListener;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedRawListener_, __args);
		}

		static Delegate cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedWSQListener_;
#pragma warning disable 0169
		static Delegate GetGrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedWSQListener_Handler ()
		{
			if (cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedWSQListener_ == null)
				cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedWSQListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZL_V) n_GrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedWSQListener_);
			return cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedWSQListener_;
		}

		static void n_GrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedWSQListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsScanType> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedWSQListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedWSQListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.GrabFingerprint (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedWSQListener_;
		public unsafe void GrabFingerprint (global::Com.Credenceid.Biometrics.BiometricsScanType p0, bool p1, global::Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedWSQListener p2)
		{
			if (id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedWSQListener_ == IntPtr.Zero)
				id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedWSQListener_ = JNIEnv.GetMethodID (class_ref, "grabFingerprint", "(Lcom/credenceid/biometrics/Biometrics$ScanType;ZLcom/credenceid/biometrics/Biometrics$OnFingerprintGrabbedWSQListener;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedWSQListener_, __args);
		}

		static Delegate cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnMultiFingerprintGrabbedListener_;
#pragma warning disable 0169
		static Delegate GetGrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnMultiFingerprintGrabbedListener_Handler ()
		{
			if (cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnMultiFingerprintGrabbedListener_ == null)
				cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnMultiFingerprintGrabbedListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZL_V) n_GrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnMultiFingerprintGrabbedListener_);
			return cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnMultiFingerprintGrabbedListener_;
		}

		static void n_GrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnMultiFingerprintGrabbedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsScanType> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.Credenceid.Biometrics.IBiometricsOnMultiFingerprintGrabbedListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnMultiFingerprintGrabbedListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.GrabFingerprint (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnMultiFingerprintGrabbedListener_;
		public unsafe void GrabFingerprint (global::Com.Credenceid.Biometrics.BiometricsScanType p0, bool p1, global::Com.Credenceid.Biometrics.IBiometricsOnMultiFingerprintGrabbedListener p2)
		{
			if (id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnMultiFingerprintGrabbedListener_ == IntPtr.Zero)
				id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnMultiFingerprintGrabbedListener_ = JNIEnv.GetMethodID (class_ref, "grabFingerprint", "(Lcom/credenceid/biometrics/Biometrics$ScanType;ZLcom/credenceid/biometrics/Biometrics$OnMultiFingerprintGrabbedListener;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_ZLcom_credenceid_biometrics_Biometrics_OnMultiFingerprintGrabbedListener_, __args);
		}

		static Delegate cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedFullListener_;
#pragma warning disable 0169
		static Delegate GetGrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedFullListener_Handler ()
		{
			if (cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedFullListener_ == null)
				cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedFullListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_GrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedFullListener_);
			return cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedFullListener_;
		}

		static void n_GrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedFullListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsScanType> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedFullListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedFullListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.GrabFingerprint (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedFullListener_;
		public unsafe void GrabFingerprint (global::Com.Credenceid.Biometrics.BiometricsScanType p0, global::Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedFullListener p1)
		{
			if (id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedFullListener_ == IntPtr.Zero)
				id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedFullListener_ = JNIEnv.GetMethodID (class_ref, "grabFingerprint", "(Lcom/credenceid/biometrics/Biometrics$ScanType;Lcom/credenceid/biometrics/Biometrics$OnFingerprintGrabbedFullListener;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedFullListener_, __args);
		}

		static Delegate cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedListener_;
#pragma warning disable 0169
		static Delegate GetGrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedListener_Handler ()
		{
			if (cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedListener_ == null)
				cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_GrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedListener_);
			return cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedListener_;
		}

		static void n_GrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsScanType> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.GrabFingerprint (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedListener_;
		public unsafe void GrabFingerprint (global::Com.Credenceid.Biometrics.BiometricsScanType p0, global::Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedListener p1)
		{
			if (id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedListener_ == IntPtr.Zero)
				id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedListener_ = JNIEnv.GetMethodID (class_ref, "grabFingerprint", "(Lcom/credenceid/biometrics/Biometrics$ScanType;Lcom/credenceid/biometrics/Biometrics$OnFingerprintGrabbedListener;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedListener_, __args);
		}

		static Delegate cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedWSQListener_;
#pragma warning disable 0169
		static Delegate GetGrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedWSQListener_Handler ()
		{
			if (cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedWSQListener_ == null)
				cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedWSQListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_GrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedWSQListener_);
			return cb_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedWSQListener_;
		}

		static void n_GrabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedWSQListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsScanType> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedWSQListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedWSQListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.GrabFingerprint (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedWSQListener_;
		public unsafe void GrabFingerprint (global::Com.Credenceid.Biometrics.BiometricsScanType p0, global::Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedWSQListener p1)
		{
			if (id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedWSQListener_ == IntPtr.Zero)
				id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedWSQListener_ = JNIEnv.GetMethodID (class_ref, "grabFingerprint", "(Lcom/credenceid/biometrics/Biometrics$ScanType;Lcom/credenceid/biometrics/Biometrics$OnFingerprintGrabbedWSQListener;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_grabFingerprint_Lcom_credenceid_biometrics_Biometrics_ScanType_Lcom_credenceid_biometrics_Biometrics_OnFingerprintGrabbedWSQListener_, __args);
		}

		static Delegate cb_grabFingerprintSync_I;
#pragma warning disable 0169
		static Delegate GetGrabFingerprintSync_IHandler ()
		{
			if (cb_grabFingerprintSync_I == null)
				cb_grabFingerprintSync_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_GrabFingerprintSync_I);
			return cb_grabFingerprintSync_I;
		}

		static IntPtr n_GrabFingerprintSync_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GrabFingerprintSync (p0));
		}
#pragma warning restore 0169

		IntPtr id_grabFingerprintSync_I;
		public unsafe global::Com.Credenceid.Biometrics.FingerprintSyncResponse GrabFingerprintSync (int p0)
		{
			if (id_grabFingerprintSync_I == IntPtr.Zero)
				id_grabFingerprintSync_I = JNIEnv.GetMethodID (class_ref, "grabFingerprintSync", "(I)Lcom/credenceid/biometrics/FingerprintSyncResponse;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.FingerprintSyncResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_grabFingerprintSync_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_initializeBiometrics_Lcom_credenceid_biometrics_Biometrics_OnInitializedListener_;
#pragma warning disable 0169
		static Delegate GetInitializeBiometrics_Lcom_credenceid_biometrics_Biometrics_OnInitializedListener_Handler ()
		{
			if (cb_initializeBiometrics_Lcom_credenceid_biometrics_Biometrics_OnInitializedListener_ == null)
				cb_initializeBiometrics_Lcom_credenceid_biometrics_Biometrics_OnInitializedListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_InitializeBiometrics_Lcom_credenceid_biometrics_Biometrics_OnInitializedListener_);
			return cb_initializeBiometrics_Lcom_credenceid_biometrics_Biometrics_OnInitializedListener_;
		}

		static void n_InitializeBiometrics_Lcom_credenceid_biometrics_Biometrics_OnInitializedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Credenceid.Biometrics.IBiometricsOnInitializedListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnInitializedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.InitializeBiometrics (p0);
		}
#pragma warning restore 0169

		IntPtr id_initializeBiometrics_Lcom_credenceid_biometrics_Biometrics_OnInitializedListener_;
		public unsafe void InitializeBiometrics (global::Com.Credenceid.Biometrics.IBiometricsOnInitializedListener p0)
		{
			if (id_initializeBiometrics_Lcom_credenceid_biometrics_Biometrics_OnInitializedListener_ == IntPtr.Zero)
				id_initializeBiometrics_Lcom_credenceid_biometrics_Biometrics_OnInitializedListener_ = JNIEnv.GetMethodID (class_ref, "initializeBiometrics", "(Lcom/credenceid/biometrics/Biometrics$OnInitializedListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initializeBiometrics_Lcom_credenceid_biometrics_Biometrics_OnInitializedListener_, __args);
		}

		static Delegate cb_openFingerprintReader_Lcom_credenceid_biometrics_Biometrics_FingerprintReaderStatusListener_;
#pragma warning disable 0169
		static Delegate GetOpenFingerprintReader_Lcom_credenceid_biometrics_Biometrics_FingerprintReaderStatusListener_Handler ()
		{
			if (cb_openFingerprintReader_Lcom_credenceid_biometrics_Biometrics_FingerprintReaderStatusListener_ == null)
				cb_openFingerprintReader_Lcom_credenceid_biometrics_Biometrics_FingerprintReaderStatusListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OpenFingerprintReader_Lcom_credenceid_biometrics_Biometrics_FingerprintReaderStatusListener_);
			return cb_openFingerprintReader_Lcom_credenceid_biometrics_Biometrics_FingerprintReaderStatusListener_;
		}

		static void n_OpenFingerprintReader_Lcom_credenceid_biometrics_Biometrics_FingerprintReaderStatusListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Credenceid.Biometrics.IBiometricsFingerprintReaderStatusListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsFingerprintReaderStatusListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OpenFingerprintReader (p0);
		}
#pragma warning restore 0169

		IntPtr id_openFingerprintReader_Lcom_credenceid_biometrics_Biometrics_FingerprintReaderStatusListener_;
		public unsafe void OpenFingerprintReader (global::Com.Credenceid.Biometrics.IBiometricsFingerprintReaderStatusListener p0)
		{
			if (id_openFingerprintReader_Lcom_credenceid_biometrics_Biometrics_FingerprintReaderStatusListener_ == IntPtr.Zero)
				id_openFingerprintReader_Lcom_credenceid_biometrics_Biometrics_FingerprintReaderStatusListener_ = JNIEnv.GetMethodID (class_ref, "openFingerprintReader", "(Lcom/credenceid/biometrics/Biometrics$FingerprintReaderStatusListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_openFingerprintReader_Lcom_credenceid_biometrics_Biometrics_FingerprintReaderStatusListener_, __args);
		}

		static Delegate cb_openMRZ_Lcom_credenceid_biometrics_Biometrics_MRZStatusListener_;
#pragma warning disable 0169
		static Delegate GetOpenMRZ_Lcom_credenceid_biometrics_Biometrics_MRZStatusListener_Handler ()
		{
			if (cb_openMRZ_Lcom_credenceid_biometrics_Biometrics_MRZStatusListener_ == null)
				cb_openMRZ_Lcom_credenceid_biometrics_Biometrics_MRZStatusListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OpenMRZ_Lcom_credenceid_biometrics_Biometrics_MRZStatusListener_);
			return cb_openMRZ_Lcom_credenceid_biometrics_Biometrics_MRZStatusListener_;
		}

		static void n_OpenMRZ_Lcom_credenceid_biometrics_Biometrics_MRZStatusListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Credenceid.Biometrics.IBiometricsMRZStatusListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsMRZStatusListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OpenMRZ (p0);
		}
#pragma warning restore 0169

		IntPtr id_openMRZ_Lcom_credenceid_biometrics_Biometrics_MRZStatusListener_;
		public unsafe void OpenMRZ (global::Com.Credenceid.Biometrics.IBiometricsMRZStatusListener p0)
		{
			if (id_openMRZ_Lcom_credenceid_biometrics_Biometrics_MRZStatusListener_ == IntPtr.Zero)
				id_openMRZ_Lcom_credenceid_biometrics_Biometrics_MRZStatusListener_ = JNIEnv.GetMethodID (class_ref, "openMRZ", "(Lcom/credenceid/biometrics/Biometrics$MRZStatusListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_openMRZ_Lcom_credenceid_biometrics_Biometrics_MRZStatusListener_, __args);
		}

		static Delegate cb_readICAODocument_Ljava_lang_String_Ljava_lang_String_ZLcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_;
#pragma warning disable 0169
		static Delegate GetReadICAODocument_Ljava_lang_String_Ljava_lang_String_ZLcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_Handler ()
		{
			if (cb_readICAODocument_Ljava_lang_String_Ljava_lang_String_ZLcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_ == null)
				cb_readICAODocument_Ljava_lang_String_Ljava_lang_String_ZLcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLZL_V) n_ReadICAODocument_Ljava_lang_String_Ljava_lang_String_ZLcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_);
			return cb_readICAODocument_Ljava_lang_String_Ljava_lang_String_ZLcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_;
		}

		static void n_ReadICAODocument_Ljava_lang_String_Ljava_lang_String_ZLcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p3 = (global::Com.Credenceid.Biometrics.IBiometricsCAODocumentReadListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsCAODocumentReadListener> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.ReadICAODocument (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_readICAODocument_Ljava_lang_String_Ljava_lang_String_ZLcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_;
		public unsafe void ReadICAODocument (string p0, string p1, bool p2, global::Com.Credenceid.Biometrics.IBiometricsCAODocumentReadListener p3)
		{
			if (id_readICAODocument_Ljava_lang_String_Ljava_lang_String_ZLcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_ == IntPtr.Zero)
				id_readICAODocument_Ljava_lang_String_Ljava_lang_String_ZLcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_ = JNIEnv.GetMethodID (class_ref, "readICAODocument", "(Ljava/lang/String;Ljava/lang/String;ZLcom/credenceid/biometrics/Biometrics$ICAODocumentReadListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_readICAODocument_Ljava_lang_String_Ljava_lang_String_ZLcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_readICAODocument_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_;
#pragma warning disable 0169
		static Delegate GetReadICAODocument_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_Handler ()
		{
			if (cb_readICAODocument_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_ == null)
				cb_readICAODocument_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_ReadICAODocument_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_);
			return cb_readICAODocument_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_;
		}

		static void n_ReadICAODocument_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = (global::Com.Credenceid.Biometrics.IBiometricsCAODocumentReadListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsCAODocumentReadListener> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.ReadICAODocument (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_readICAODocument_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_;
		public unsafe void ReadICAODocument (string p0, string p1, string p2, global::Com.Credenceid.Biometrics.IBiometricsCAODocumentReadListener p3)
		{
			if (id_readICAODocument_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_ == IntPtr.Zero)
				id_readICAODocument_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_ = JNIEnv.GetMethodID (class_ref, "readICAODocument", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/credenceid/biometrics/Biometrics$ICAODocumentReadListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_readICAODocument_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_readICAODocument_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_;
#pragma warning disable 0169
		static Delegate GetReadICAODocument_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_Handler ()
		{
			if (cb_readICAODocument_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_ == null)
				cb_readICAODocument_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLZL_V) n_ReadICAODocument_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_);
			return cb_readICAODocument_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_;
		}

		static void n_ReadICAODocument_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, bool p4, IntPtr native_p5)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			var p5 = (global::Com.Credenceid.Biometrics.IBiometricsCAODocumentReadListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsCAODocumentReadListener> (native_p5, JniHandleOwnership.DoNotTransfer);
			__this.ReadICAODocument (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		IntPtr id_readICAODocument_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_;
		public unsafe void ReadICAODocument (string p0, string p1, string p2, string p3, bool p4, global::Com.Credenceid.Biometrics.IBiometricsCAODocumentReadListener p5)
		{
			if (id_readICAODocument_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_ == IntPtr.Zero)
				id_readICAODocument_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_ = JNIEnv.GetMethodID (class_ref, "readICAODocument", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ZLcom/credenceid/biometrics/Biometrics$ICAODocumentReadListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			JValue* __args = stackalloc JValue [6];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (p4);
			__args [5] = new JValue (p5);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_readICAODocument_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLcom_credenceid_biometrics_Biometrics_ICAODocumentReadListener_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
		}

		static Delegate cb_readMRZ_Lcom_credenceid_biometrics_Biometrics_OnMRZReaderListener_;
#pragma warning disable 0169
		static Delegate GetReadMRZ_Lcom_credenceid_biometrics_Biometrics_OnMRZReaderListener_Handler ()
		{
			if (cb_readMRZ_Lcom_credenceid_biometrics_Biometrics_OnMRZReaderListener_ == null)
				cb_readMRZ_Lcom_credenceid_biometrics_Biometrics_OnMRZReaderListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ReadMRZ_Lcom_credenceid_biometrics_Biometrics_OnMRZReaderListener_);
			return cb_readMRZ_Lcom_credenceid_biometrics_Biometrics_OnMRZReaderListener_;
		}

		static void n_ReadMRZ_Lcom_credenceid_biometrics_Biometrics_OnMRZReaderListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Credenceid.Biometrics.IBiometricsOnMRZReaderListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnMRZReaderListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReadMRZ (p0);
		}
#pragma warning restore 0169

		IntPtr id_readMRZ_Lcom_credenceid_biometrics_Biometrics_OnMRZReaderListener_;
		public unsafe void ReadMRZ (global::Com.Credenceid.Biometrics.IBiometricsOnMRZReaderListener p0)
		{
			if (id_readMRZ_Lcom_credenceid_biometrics_Biometrics_OnMRZReaderListener_ == IntPtr.Zero)
				id_readMRZ_Lcom_credenceid_biometrics_Biometrics_OnMRZReaderListener_ = JNIEnv.GetMethodID (class_ref, "readMRZ", "(Lcom/credenceid/biometrics/Biometrics$OnMRZReaderListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_readMRZ_Lcom_credenceid_biometrics_Biometrics_OnMRZReaderListener_, __args);
		}

		static Delegate cb_readSmartCard_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_GIcaoReadListener_;
#pragma warning disable 0169
		static Delegate GetReadSmartCard_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_GIcaoReadListener_Handler ()
		{
			if (cb_readSmartCard_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_GIcaoReadListener_ == null)
				cb_readSmartCard_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_GIcaoReadListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_ReadSmartCard_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_GIcaoReadListener_);
			return cb_readSmartCard_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_GIcaoReadListener_;
		}

		static void n_ReadSmartCard_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_GIcaoReadListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = (global::Com.Credenceid.Biometrics.IBiometricsGIcaoReadListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsGIcaoReadListener> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.ReadSmartCard (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_readSmartCard_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_GIcaoReadListener_;
		public unsafe void ReadSmartCard (string p0, string p1, string p2, global::Com.Credenceid.Biometrics.IBiometricsGIcaoReadListener p3)
		{
			if (id_readSmartCard_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_GIcaoReadListener_ == IntPtr.Zero)
				id_readSmartCard_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_GIcaoReadListener_ = JNIEnv.GetMethodID (class_ref, "readSmartCard", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/credenceid/biometrics/Biometrics$GIcaoReadListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_readSmartCard_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_GIcaoReadListener_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_readSmartCard_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_GNIDReadListener_;
#pragma warning disable 0169
		static Delegate GetReadSmartCard_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_GNIDReadListener_Handler ()
		{
			if (cb_readSmartCard_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_GNIDReadListener_ == null)
				cb_readSmartCard_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_GNIDReadListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_ReadSmartCard_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_GNIDReadListener_);
			return cb_readSmartCard_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_GNIDReadListener_;
		}

		static void n_ReadSmartCard_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_GNIDReadListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = (global::Com.Credenceid.Biometrics.IBiometricsGNIDReadListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsGNIDReadListener> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.ReadSmartCard (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_readSmartCard_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_GNIDReadListener_;
		public unsafe void ReadSmartCard (string p0, string p1, string p2, global::Com.Credenceid.Biometrics.IBiometricsGNIDReadListener p3)
		{
			if (id_readSmartCard_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_GNIDReadListener_ == IntPtr.Zero)
				id_readSmartCard_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_GNIDReadListener_ = JNIEnv.GetMethodID (class_ref, "readSmartCard", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/credenceid/biometrics/Biometrics$GNIDReadListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_readSmartCard_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_GNIDReadListener_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_registerCardStatusListener_Lcom_credenceid_biometrics_Biometrics_OnCardStatusListener_;
#pragma warning disable 0169
		static Delegate GetRegisterCardStatusListener_Lcom_credenceid_biometrics_Biometrics_OnCardStatusListener_Handler ()
		{
			if (cb_registerCardStatusListener_Lcom_credenceid_biometrics_Biometrics_OnCardStatusListener_ == null)
				cb_registerCardStatusListener_Lcom_credenceid_biometrics_Biometrics_OnCardStatusListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RegisterCardStatusListener_Lcom_credenceid_biometrics_Biometrics_OnCardStatusListener_);
			return cb_registerCardStatusListener_Lcom_credenceid_biometrics_Biometrics_OnCardStatusListener_;
		}

		static void n_RegisterCardStatusListener_Lcom_credenceid_biometrics_Biometrics_OnCardStatusListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Credenceid.Biometrics.IBiometricsOnCardStatusListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnCardStatusListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterCardStatusListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_registerCardStatusListener_Lcom_credenceid_biometrics_Biometrics_OnCardStatusListener_;
		public unsafe void RegisterCardStatusListener (global::Com.Credenceid.Biometrics.IBiometricsOnCardStatusListener p0)
		{
			if (id_registerCardStatusListener_Lcom_credenceid_biometrics_Biometrics_OnCardStatusListener_ == IntPtr.Zero)
				id_registerCardStatusListener_Lcom_credenceid_biometrics_Biometrics_OnCardStatusListener_ = JNIEnv.GetMethodID (class_ref, "registerCardStatusListener", "(Lcom/credenceid/biometrics/Biometrics$OnCardStatusListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerCardStatusListener_Lcom_credenceid_biometrics_Biometrics_OnCardStatusListener_, __args);
		}

		static Delegate cb_registerEPassportStatusListener_Lcom_credenceid_biometrics_Biometrics_OnEPassportStatusListener_;
#pragma warning disable 0169
		static Delegate GetRegisterEPassportStatusListener_Lcom_credenceid_biometrics_Biometrics_OnEPassportStatusListener_Handler ()
		{
			if (cb_registerEPassportStatusListener_Lcom_credenceid_biometrics_Biometrics_OnEPassportStatusListener_ == null)
				cb_registerEPassportStatusListener_Lcom_credenceid_biometrics_Biometrics_OnEPassportStatusListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RegisterEPassportStatusListener_Lcom_credenceid_biometrics_Biometrics_OnEPassportStatusListener_);
			return cb_registerEPassportStatusListener_Lcom_credenceid_biometrics_Biometrics_OnEPassportStatusListener_;
		}

		static void n_RegisterEPassportStatusListener_Lcom_credenceid_biometrics_Biometrics_OnEPassportStatusListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Credenceid.Biometrics.IBiometricsOnEPassportStatusListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnEPassportStatusListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterEPassportStatusListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_registerEPassportStatusListener_Lcom_credenceid_biometrics_Biometrics_OnEPassportStatusListener_;
		public unsafe void RegisterEPassportStatusListener (global::Com.Credenceid.Biometrics.IBiometricsOnEPassportStatusListener p0)
		{
			if (id_registerEPassportStatusListener_Lcom_credenceid_biometrics_Biometrics_OnEPassportStatusListener_ == IntPtr.Zero)
				id_registerEPassportStatusListener_Lcom_credenceid_biometrics_Biometrics_OnEPassportStatusListener_ = JNIEnv.GetMethodID (class_ref, "registerEPassportStatusListener", "(Lcom/credenceid/biometrics/Biometrics$OnEPassportStatusListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerEPassportStatusListener_Lcom_credenceid_biometrics_Biometrics_OnEPassportStatusListener_, __args);
		}

		static Delegate cb_registerMRZDocumentStatusListener_Lcom_credenceid_biometrics_Biometrics_OnMRZDocumentStatusListener_;
#pragma warning disable 0169
		static Delegate GetRegisterMRZDocumentStatusListener_Lcom_credenceid_biometrics_Biometrics_OnMRZDocumentStatusListener_Handler ()
		{
			if (cb_registerMRZDocumentStatusListener_Lcom_credenceid_biometrics_Biometrics_OnMRZDocumentStatusListener_ == null)
				cb_registerMRZDocumentStatusListener_Lcom_credenceid_biometrics_Biometrics_OnMRZDocumentStatusListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RegisterMRZDocumentStatusListener_Lcom_credenceid_biometrics_Biometrics_OnMRZDocumentStatusListener_);
			return cb_registerMRZDocumentStatusListener_Lcom_credenceid_biometrics_Biometrics_OnMRZDocumentStatusListener_;
		}

		static void n_RegisterMRZDocumentStatusListener_Lcom_credenceid_biometrics_Biometrics_OnMRZDocumentStatusListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Credenceid.Biometrics.IBiometricsOnMRZDocumentStatusListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnMRZDocumentStatusListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterMRZDocumentStatusListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_registerMRZDocumentStatusListener_Lcom_credenceid_biometrics_Biometrics_OnMRZDocumentStatusListener_;
		public unsafe void RegisterMRZDocumentStatusListener (global::Com.Credenceid.Biometrics.IBiometricsOnMRZDocumentStatusListener p0)
		{
			if (id_registerMRZDocumentStatusListener_Lcom_credenceid_biometrics_Biometrics_OnMRZDocumentStatusListener_ == IntPtr.Zero)
				id_registerMRZDocumentStatusListener_Lcom_credenceid_biometrics_Biometrics_OnMRZDocumentStatusListener_ = JNIEnv.GetMethodID (class_ref, "registerMRZDocumentStatusListener", "(Lcom/credenceid/biometrics/Biometrics$OnMRZDocumentStatusListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerMRZDocumentStatusListener_Lcom_credenceid_biometrics_Biometrics_OnMRZDocumentStatusListener_, __args);
		}

		static Delegate cb_registerOnMRZReaderListener_Lcom_credenceid_biometrics_Biometrics_OnMRZReaderListener_;
#pragma warning disable 0169
		static Delegate GetRegisterOnMRZReaderListener_Lcom_credenceid_biometrics_Biometrics_OnMRZReaderListener_Handler ()
		{
			if (cb_registerOnMRZReaderListener_Lcom_credenceid_biometrics_Biometrics_OnMRZReaderListener_ == null)
				cb_registerOnMRZReaderListener_Lcom_credenceid_biometrics_Biometrics_OnMRZReaderListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RegisterOnMRZReaderListener_Lcom_credenceid_biometrics_Biometrics_OnMRZReaderListener_);
			return cb_registerOnMRZReaderListener_Lcom_credenceid_biometrics_Biometrics_OnMRZReaderListener_;
		}

		static void n_RegisterOnMRZReaderListener_Lcom_credenceid_biometrics_Biometrics_OnMRZReaderListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Credenceid.Biometrics.IBiometricsOnMRZReaderListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnMRZReaderListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterOnMRZReaderListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_registerOnMRZReaderListener_Lcom_credenceid_biometrics_Biometrics_OnMRZReaderListener_;
		public unsafe void RegisterOnMRZReaderListener (global::Com.Credenceid.Biometrics.IBiometricsOnMRZReaderListener p0)
		{
			if (id_registerOnMRZReaderListener_Lcom_credenceid_biometrics_Biometrics_OnMRZReaderListener_ == IntPtr.Zero)
				id_registerOnMRZReaderListener_Lcom_credenceid_biometrics_Biometrics_OnMRZReaderListener_ = JNIEnv.GetMethodID (class_ref, "registerOnMRZReaderListener", "(Lcom/credenceid/biometrics/Biometrics$OnMRZReaderListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerOnMRZReaderListener_Lcom_credenceid_biometrics_Biometrics_OnMRZReaderListener_, __args);
		}

		static Delegate cb_setPreferences_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_PreferencesListener_;
#pragma warning disable 0169
		static Delegate GetSetPreferences_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_PreferencesListener_Handler ()
		{
			if (cb_setPreferences_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_PreferencesListener_ == null)
				cb_setPreferences_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_PreferencesListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_SetPreferences_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_PreferencesListener_);
			return cb_setPreferences_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_PreferencesListener_;
		}

		static void n_SetPreferences_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_PreferencesListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.Credenceid.Biometrics.IBiometricsPreferencesListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsPreferencesListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SetPreferences (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_setPreferences_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_PreferencesListener_;
		public unsafe void SetPreferences (string p0, string p1, global::Com.Credenceid.Biometrics.IBiometricsPreferencesListener p2)
		{
			if (id_setPreferences_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_PreferencesListener_ == IntPtr.Zero)
				id_setPreferences_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_PreferencesListener_ = JNIEnv.GetMethodID (class_ref, "setPreferences", "(Ljava/lang/String;Ljava/lang/String;Lcom/credenceid/biometrics/Biometrics$PreferencesListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPreferences_Ljava_lang_String_Ljava_lang_String_Lcom_credenceid_biometrics_Biometrics_PreferencesListener_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_switchMobileData_ZLcom_credenceid_biometrics_Biometrics_OnMobileDataChangedListener_;
#pragma warning disable 0169
		static Delegate GetSwitchMobileData_ZLcom_credenceid_biometrics_Biometrics_OnMobileDataChangedListener_Handler ()
		{
			if (cb_switchMobileData_ZLcom_credenceid_biometrics_Biometrics_OnMobileDataChangedListener_ == null)
				cb_switchMobileData_ZLcom_credenceid_biometrics_Biometrics_OnMobileDataChangedListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZL_V) n_SwitchMobileData_ZLcom_credenceid_biometrics_Biometrics_OnMobileDataChangedListener_);
			return cb_switchMobileData_ZLcom_credenceid_biometrics_Biometrics_OnMobileDataChangedListener_;
		}

		static void n_SwitchMobileData_ZLcom_credenceid_biometrics_Biometrics_OnMobileDataChangedListener_ (IntPtr jnienv, IntPtr native__this, bool p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometrics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Credenceid.Biometrics.IBiometricsOnMobileDataChangedListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IBiometricsOnMobileDataChangedListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SwitchMobileData (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_switchMobileData_ZLcom_credenceid_biometrics_Biometrics_OnMobileDataChangedListener_;
		public unsafe void SwitchMobileData (bool p0, global::Com.Credenceid.Biometrics.IBiometricsOnMobileDataChangedListener p1)
		{
			if (id_switchMobileData_ZLcom_credenceid_biometrics_Biometrics_OnMobileDataChangedListener_ == IntPtr.Zero)
				id_switchMobileData_ZLcom_credenceid_biometrics_Biometrics_OnMobileDataChangedListener_ = JNIEnv.GetMethodID (class_ref, "switchMobileData", "(ZLcom/credenceid/biometrics/Biometrics$OnMobileDataChangedListener;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_switchMobileData_ZLcom_credenceid_biometrics_Biometrics_OnMobileDataChangedListener_, __args);
		}

	}

}
