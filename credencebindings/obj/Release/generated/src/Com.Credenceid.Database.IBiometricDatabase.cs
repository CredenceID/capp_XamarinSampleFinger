using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Credenceid.Database {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.credenceid.database']/interface[@name='BiometricDatabase.OnDeleteCallback']"
	[Register ("com/credenceid/database/BiometricDatabase$OnDeleteCallback", "", "Com.Credenceid.Database.IBiometricDatabaseOnDeleteCallbackInvoker")]
	public partial interface IBiometricDatabaseOnDeleteCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/interface[@name='BiometricDatabase.OnDeleteCallback']/method[@name='onDelete' and count(parameter)=1 and parameter[1][@type='com.credenceid.database.BiometricDatabase.Status']]"
		[Register ("onDelete", "(Lcom/credenceid/database/BiometricDatabase$Status;)V", "GetOnDelete_Lcom_credenceid_database_BiometricDatabase_Status_Handler:Com.Credenceid.Database.IBiometricDatabaseOnDeleteCallbackInvoker, CredenceBindings")]
		void OnDelete (global::Com.Credenceid.Database.BiometricDatabaseStatus p0);

	}

	[global::Android.Runtime.Register ("com/credenceid/database/BiometricDatabase$OnDeleteCallback", DoNotGenerateAcw=true)]
	internal partial class IBiometricDatabaseOnDeleteCallbackInvoker : global::Java.Lang.Object, IBiometricDatabaseOnDeleteCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/credenceid/database/BiometricDatabase$OnDeleteCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBiometricDatabaseOnDeleteCallbackInvoker); }
		}

		IntPtr class_ref;

		public static IBiometricDatabaseOnDeleteCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBiometricDatabaseOnDeleteCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.credenceid.database.BiometricDatabase.OnDeleteCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBiometricDatabaseOnDeleteCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onDelete_Lcom_credenceid_database_BiometricDatabase_Status_;
#pragma warning disable 0169
		static Delegate GetOnDelete_Lcom_credenceid_database_BiometricDatabase_Status_Handler ()
		{
			if (cb_onDelete_Lcom_credenceid_database_BiometricDatabase_Status_ == null)
				cb_onDelete_Lcom_credenceid_database_BiometricDatabase_Status_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnDelete_Lcom_credenceid_database_BiometricDatabase_Status_);
			return cb_onDelete_Lcom_credenceid_database_BiometricDatabase_Status_;
		}

		static void n_OnDelete_Lcom_credenceid_database_BiometricDatabase_Status_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.IBiometricDatabaseOnDeleteCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.BiometricDatabaseStatus> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDelete (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDelete_Lcom_credenceid_database_BiometricDatabase_Status_;
		public unsafe void OnDelete (global::Com.Credenceid.Database.BiometricDatabaseStatus p0)
		{
			if (id_onDelete_Lcom_credenceid_database_BiometricDatabase_Status_ == IntPtr.Zero)
				id_onDelete_Lcom_credenceid_database_BiometricDatabase_Status_ = JNIEnv.GetMethodID (class_ref, "onDelete", "(Lcom/credenceid/database/BiometricDatabase$Status;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDelete_Lcom_credenceid_database_BiometricDatabase_Status_, __args);
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.credenceid.database']/interface[@name='BiometricDatabase.OnEnrollCallback']"
	[Register ("com/credenceid/database/BiometricDatabase$OnEnrollCallback", "", "Com.Credenceid.Database.IBiometricDatabaseOnEnrollCallbackInvoker")]
	public partial interface IBiometricDatabaseOnEnrollCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/interface[@name='BiometricDatabase.OnEnrollCallback']/method[@name='onEnroll' and count(parameter)=2 and parameter[1][@type='com.credenceid.database.BiometricDatabase.Status'] and parameter[2][@type='int']]"
		[Register ("onEnroll", "(Lcom/credenceid/database/BiometricDatabase$Status;I)V", "GetOnEnroll_Lcom_credenceid_database_BiometricDatabase_Status_IHandler:Com.Credenceid.Database.IBiometricDatabaseOnEnrollCallbackInvoker, CredenceBindings")]
		void OnEnroll (global::Com.Credenceid.Database.BiometricDatabaseStatus p0, int p1);

	}

	[global::Android.Runtime.Register ("com/credenceid/database/BiometricDatabase$OnEnrollCallback", DoNotGenerateAcw=true)]
	internal partial class IBiometricDatabaseOnEnrollCallbackInvoker : global::Java.Lang.Object, IBiometricDatabaseOnEnrollCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/credenceid/database/BiometricDatabase$OnEnrollCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBiometricDatabaseOnEnrollCallbackInvoker); }
		}

		IntPtr class_ref;

		public static IBiometricDatabaseOnEnrollCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBiometricDatabaseOnEnrollCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.credenceid.database.BiometricDatabase.OnEnrollCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBiometricDatabaseOnEnrollCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onEnroll_Lcom_credenceid_database_BiometricDatabase_Status_I;
#pragma warning disable 0169
		static Delegate GetOnEnroll_Lcom_credenceid_database_BiometricDatabase_Status_IHandler ()
		{
			if (cb_onEnroll_Lcom_credenceid_database_BiometricDatabase_Status_I == null)
				cb_onEnroll_Lcom_credenceid_database_BiometricDatabase_Status_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_OnEnroll_Lcom_credenceid_database_BiometricDatabase_Status_I);
			return cb_onEnroll_Lcom_credenceid_database_BiometricDatabase_Status_I;
		}

		static void n_OnEnroll_Lcom_credenceid_database_BiometricDatabase_Status_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.IBiometricDatabaseOnEnrollCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.BiometricDatabaseStatus> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnEnroll (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onEnroll_Lcom_credenceid_database_BiometricDatabase_Status_I;
		public unsafe void OnEnroll (global::Com.Credenceid.Database.BiometricDatabaseStatus p0, int p1)
		{
			if (id_onEnroll_Lcom_credenceid_database_BiometricDatabase_Status_I == IntPtr.Zero)
				id_onEnroll_Lcom_credenceid_database_BiometricDatabase_Status_I = JNIEnv.GetMethodID (class_ref, "onEnroll", "(Lcom/credenceid/database/BiometricDatabase$Status;I)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onEnroll_Lcom_credenceid_database_BiometricDatabase_Status_I, __args);
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.credenceid.database']/interface[@name='BiometricDatabase.OnMatchCallback']"
	[Register ("com/credenceid/database/BiometricDatabase$OnMatchCallback", "", "Com.Credenceid.Database.IBiometricDatabaseOnMatchCallbackInvoker")]
	public partial interface IBiometricDatabaseOnMatchCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/interface[@name='BiometricDatabase.OnMatchCallback']/method[@name='onMatch' and count(parameter)=2 and parameter[1][@type='com.credenceid.database.BiometricDatabase.Status'] and parameter[2][@type='java.util.ArrayList&lt;com.credenceid.database.MatchItem&gt;']]"
		[Register ("onMatch", "(Lcom/credenceid/database/BiometricDatabase$Status;Ljava/util/ArrayList;)V", "GetOnMatch_Lcom_credenceid_database_BiometricDatabase_Status_Ljava_util_ArrayList_Handler:Com.Credenceid.Database.IBiometricDatabaseOnMatchCallbackInvoker, CredenceBindings")]
		void OnMatch (global::Com.Credenceid.Database.BiometricDatabaseStatus p0, global::System.Collections.Generic.IList<global::Com.Credenceid.Database.MatchItem> p1);

	}

	[global::Android.Runtime.Register ("com/credenceid/database/BiometricDatabase$OnMatchCallback", DoNotGenerateAcw=true)]
	internal partial class IBiometricDatabaseOnMatchCallbackInvoker : global::Java.Lang.Object, IBiometricDatabaseOnMatchCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/credenceid/database/BiometricDatabase$OnMatchCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBiometricDatabaseOnMatchCallbackInvoker); }
		}

		IntPtr class_ref;

		public static IBiometricDatabaseOnMatchCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBiometricDatabaseOnMatchCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.credenceid.database.BiometricDatabase.OnMatchCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBiometricDatabaseOnMatchCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onMatch_Lcom_credenceid_database_BiometricDatabase_Status_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetOnMatch_Lcom_credenceid_database_BiometricDatabase_Status_Ljava_util_ArrayList_Handler ()
		{
			if (cb_onMatch_Lcom_credenceid_database_BiometricDatabase_Status_Ljava_util_ArrayList_ == null)
				cb_onMatch_Lcom_credenceid_database_BiometricDatabase_Status_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnMatch_Lcom_credenceid_database_BiometricDatabase_Status_Ljava_util_ArrayList_);
			return cb_onMatch_Lcom_credenceid_database_BiometricDatabase_Status_Ljava_util_ArrayList_;
		}

		static void n_OnMatch_Lcom_credenceid_database_BiometricDatabase_Status_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.IBiometricDatabaseOnMatchCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.BiometricDatabaseStatus> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<global::Com.Credenceid.Database.MatchItem>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnMatch (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onMatch_Lcom_credenceid_database_BiometricDatabase_Status_Ljava_util_ArrayList_;
		public unsafe void OnMatch (global::Com.Credenceid.Database.BiometricDatabaseStatus p0, global::System.Collections.Generic.IList<global::Com.Credenceid.Database.MatchItem> p1)
		{
			if (id_onMatch_Lcom_credenceid_database_BiometricDatabase_Status_Ljava_util_ArrayList_ == IntPtr.Zero)
				id_onMatch_Lcom_credenceid_database_BiometricDatabase_Status_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "onMatch", "(Lcom/credenceid/database/BiometricDatabase$Status;Ljava/util/ArrayList;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Com.Credenceid.Database.MatchItem>.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMatch_Lcom_credenceid_database_BiometricDatabase_Status_Ljava_util_ArrayList_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.credenceid.database']/interface[@name='BiometricDatabase.OnReadCallback']"
	[Register ("com/credenceid/database/BiometricDatabase$OnReadCallback", "", "Com.Credenceid.Database.IBiometricDatabaseOnReadCallbackInvoker")]
	public partial interface IBiometricDatabaseOnReadCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/interface[@name='BiometricDatabase.OnReadCallback']/method[@name='onRead' and count(parameter)=4 and parameter[1][@type='com.credenceid.database.BiometricDatabase.Status'] and parameter[2][@type='com.credenceid.database.FingerprintRecord[]'] and parameter[3][@type='com.credenceid.database.FaceRecord'] and parameter[4][@type='com.credenceid.database.IrisRecord[]']]"
		[Register ("onRead", "(Lcom/credenceid/database/BiometricDatabase$Status;[Lcom/credenceid/database/FingerprintRecord;Lcom/credenceid/database/FaceRecord;[Lcom/credenceid/database/IrisRecord;)V", "GetOnRead_Lcom_credenceid_database_BiometricDatabase_Status_arrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Handler:Com.Credenceid.Database.IBiometricDatabaseOnReadCallbackInvoker, CredenceBindings")]
		void OnRead (global::Com.Credenceid.Database.BiometricDatabaseStatus p0, global::Com.Credenceid.Database.FingerprintRecord[] p1, global::Com.Credenceid.Database.FaceRecord p2, global::Com.Credenceid.Database.IrisRecord[] p3);

	}

	[global::Android.Runtime.Register ("com/credenceid/database/BiometricDatabase$OnReadCallback", DoNotGenerateAcw=true)]
	internal partial class IBiometricDatabaseOnReadCallbackInvoker : global::Java.Lang.Object, IBiometricDatabaseOnReadCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/credenceid/database/BiometricDatabase$OnReadCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBiometricDatabaseOnReadCallbackInvoker); }
		}

		IntPtr class_ref;

		public static IBiometricDatabaseOnReadCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBiometricDatabaseOnReadCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.credenceid.database.BiometricDatabase.OnReadCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBiometricDatabaseOnReadCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onRead_Lcom_credenceid_database_BiometricDatabase_Status_arrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_;
#pragma warning disable 0169
		static Delegate GetOnRead_Lcom_credenceid_database_BiometricDatabase_Status_arrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Handler ()
		{
			if (cb_onRead_Lcom_credenceid_database_BiometricDatabase_Status_arrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_ == null)
				cb_onRead_Lcom_credenceid_database_BiometricDatabase_Status_arrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_OnRead_Lcom_credenceid_database_BiometricDatabase_Status_arrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_);
			return cb_onRead_Lcom_credenceid_database_BiometricDatabase_Status_arrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_;
		}

		static void n_OnRead_Lcom_credenceid_database_BiometricDatabase_Status_arrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.IBiometricDatabaseOnReadCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.BiometricDatabaseStatus> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Credenceid.Database.FingerprintRecord[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Credenceid.Database.FingerprintRecord));
			var p2 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.FaceRecord> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = (global::Com.Credenceid.Database.IrisRecord[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Credenceid.Database.IrisRecord));
			__this.OnRead (p0, p1, p2, p3);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
		}
#pragma warning restore 0169

		IntPtr id_onRead_Lcom_credenceid_database_BiometricDatabase_Status_arrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_;
		public unsafe void OnRead (global::Com.Credenceid.Database.BiometricDatabaseStatus p0, global::Com.Credenceid.Database.FingerprintRecord[] p1, global::Com.Credenceid.Database.FaceRecord p2, global::Com.Credenceid.Database.IrisRecord[] p3)
		{
			if (id_onRead_Lcom_credenceid_database_BiometricDatabase_Status_arrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_ == IntPtr.Zero)
				id_onRead_Lcom_credenceid_database_BiometricDatabase_Status_arrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_ = JNIEnv.GetMethodID (class_ref, "onRead", "(Lcom/credenceid/database/BiometricDatabase$Status;[Lcom/credenceid/database/FingerprintRecord;Lcom/credenceid/database/FaceRecord;[Lcom/credenceid/database/IrisRecord;)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (native_p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRead_Lcom_credenceid_database_BiometricDatabase_Status_arrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.credenceid.database']/interface[@name='BiometricDatabase.OnUpdateCallback']"
	[Register ("com/credenceid/database/BiometricDatabase$OnUpdateCallback", "", "Com.Credenceid.Database.IBiometricDatabaseOnUpdateCallbackInvoker")]
	public partial interface IBiometricDatabaseOnUpdateCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/interface[@name='BiometricDatabase.OnUpdateCallback']/method[@name='onUpdate' and count(parameter)=1 and parameter[1][@type='com.credenceid.database.BiometricDatabase.Status']]"
		[Register ("onUpdate", "(Lcom/credenceid/database/BiometricDatabase$Status;)V", "GetOnUpdate_Lcom_credenceid_database_BiometricDatabase_Status_Handler:Com.Credenceid.Database.IBiometricDatabaseOnUpdateCallbackInvoker, CredenceBindings")]
		void OnUpdate (global::Com.Credenceid.Database.BiometricDatabaseStatus p0);

	}

	[global::Android.Runtime.Register ("com/credenceid/database/BiometricDatabase$OnUpdateCallback", DoNotGenerateAcw=true)]
	internal partial class IBiometricDatabaseOnUpdateCallbackInvoker : global::Java.Lang.Object, IBiometricDatabaseOnUpdateCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/credenceid/database/BiometricDatabase$OnUpdateCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBiometricDatabaseOnUpdateCallbackInvoker); }
		}

		IntPtr class_ref;

		public static IBiometricDatabaseOnUpdateCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBiometricDatabaseOnUpdateCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.credenceid.database.BiometricDatabase.OnUpdateCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBiometricDatabaseOnUpdateCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onUpdate_Lcom_credenceid_database_BiometricDatabase_Status_;
#pragma warning disable 0169
		static Delegate GetOnUpdate_Lcom_credenceid_database_BiometricDatabase_Status_Handler ()
		{
			if (cb_onUpdate_Lcom_credenceid_database_BiometricDatabase_Status_ == null)
				cb_onUpdate_Lcom_credenceid_database_BiometricDatabase_Status_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnUpdate_Lcom_credenceid_database_BiometricDatabase_Status_);
			return cb_onUpdate_Lcom_credenceid_database_BiometricDatabase_Status_;
		}

		static void n_OnUpdate_Lcom_credenceid_database_BiometricDatabase_Status_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.IBiometricDatabaseOnUpdateCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.BiometricDatabaseStatus> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnUpdate (p0);
		}
#pragma warning restore 0169

		IntPtr id_onUpdate_Lcom_credenceid_database_BiometricDatabase_Status_;
		public unsafe void OnUpdate (global::Com.Credenceid.Database.BiometricDatabaseStatus p0)
		{
			if (id_onUpdate_Lcom_credenceid_database_BiometricDatabase_Status_ == IntPtr.Zero)
				id_onUpdate_Lcom_credenceid_database_BiometricDatabase_Status_ = JNIEnv.GetMethodID (class_ref, "onUpdate", "(Lcom/credenceid/database/BiometricDatabase$Status;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUpdate_Lcom_credenceid_database_BiometricDatabase_Status_, __args);
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.credenceid.database']/interface[@name='BiometricDatabase.OnVerifyCallback']"
	[Register ("com/credenceid/database/BiometricDatabase$OnVerifyCallback", "", "Com.Credenceid.Database.IBiometricDatabaseOnVerifyCallbackInvoker")]
	public partial interface IBiometricDatabaseOnVerifyCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/interface[@name='BiometricDatabase.OnVerifyCallback']/method[@name='onVerify' and count(parameter)=2 and parameter[1][@type='com.credenceid.database.BiometricDatabase.Status'] and parameter[2][@type='com.credenceid.database.MatchItem']]"
		[Register ("onVerify", "(Lcom/credenceid/database/BiometricDatabase$Status;Lcom/credenceid/database/MatchItem;)V", "GetOnVerify_Lcom_credenceid_database_BiometricDatabase_Status_Lcom_credenceid_database_MatchItem_Handler:Com.Credenceid.Database.IBiometricDatabaseOnVerifyCallbackInvoker, CredenceBindings")]
		void OnVerify (global::Com.Credenceid.Database.BiometricDatabaseStatus p0, global::Com.Credenceid.Database.MatchItem p1);

	}

	[global::Android.Runtime.Register ("com/credenceid/database/BiometricDatabase$OnVerifyCallback", DoNotGenerateAcw=true)]
	internal partial class IBiometricDatabaseOnVerifyCallbackInvoker : global::Java.Lang.Object, IBiometricDatabaseOnVerifyCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/credenceid/database/BiometricDatabase$OnVerifyCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBiometricDatabaseOnVerifyCallbackInvoker); }
		}

		IntPtr class_ref;

		public static IBiometricDatabaseOnVerifyCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBiometricDatabaseOnVerifyCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.credenceid.database.BiometricDatabase.OnVerifyCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBiometricDatabaseOnVerifyCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onVerify_Lcom_credenceid_database_BiometricDatabase_Status_Lcom_credenceid_database_MatchItem_;
#pragma warning disable 0169
		static Delegate GetOnVerify_Lcom_credenceid_database_BiometricDatabase_Status_Lcom_credenceid_database_MatchItem_Handler ()
		{
			if (cb_onVerify_Lcom_credenceid_database_BiometricDatabase_Status_Lcom_credenceid_database_MatchItem_ == null)
				cb_onVerify_Lcom_credenceid_database_BiometricDatabase_Status_Lcom_credenceid_database_MatchItem_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnVerify_Lcom_credenceid_database_BiometricDatabase_Status_Lcom_credenceid_database_MatchItem_);
			return cb_onVerify_Lcom_credenceid_database_BiometricDatabase_Status_Lcom_credenceid_database_MatchItem_;
		}

		static void n_OnVerify_Lcom_credenceid_database_BiometricDatabase_Status_Lcom_credenceid_database_MatchItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.IBiometricDatabaseOnVerifyCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.BiometricDatabaseStatus> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.MatchItem> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnVerify (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onVerify_Lcom_credenceid_database_BiometricDatabase_Status_Lcom_credenceid_database_MatchItem_;
		public unsafe void OnVerify (global::Com.Credenceid.Database.BiometricDatabaseStatus p0, global::Com.Credenceid.Database.MatchItem p1)
		{
			if (id_onVerify_Lcom_credenceid_database_BiometricDatabase_Status_Lcom_credenceid_database_MatchItem_ == IntPtr.Zero)
				id_onVerify_Lcom_credenceid_database_BiometricDatabase_Status_Lcom_credenceid_database_MatchItem_ = JNIEnv.GetMethodID (class_ref, "onVerify", "(Lcom/credenceid/database/BiometricDatabase$Status;Lcom/credenceid/database/MatchItem;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onVerify_Lcom_credenceid_database_BiometricDatabase_Status_Lcom_credenceid_database_MatchItem_, __args);
		}

	}


	// Metadata.xml XPath class reference: path="/api/package[@name='com.credenceid.database']/class[@name='BiometricDatabase.Status']"
	[global::Android.Runtime.Register ("com/credenceid/database/BiometricDatabase$Status", DoNotGenerateAcw=true)]
	public sealed partial class BiometricDatabaseStatus : global::Java.Lang.Enum {


		static IntPtr ERR_BAD_FACE_DATA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.database']/class[@name='BiometricDatabase.Status']/field[@name='ERR_BAD_FACE_DATA']"
		[Register ("ERR_BAD_FACE_DATA")]
		public static global::Com.Credenceid.Database.BiometricDatabaseStatus ErrBadFaceData {
			get {
				if (ERR_BAD_FACE_DATA_jfieldId == IntPtr.Zero)
					ERR_BAD_FACE_DATA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERR_BAD_FACE_DATA", "Lcom/credenceid/database/BiometricDatabase$Status;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERR_BAD_FACE_DATA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.BiometricDatabaseStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ERR_BAD_FINGERPRINT_DATA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.database']/class[@name='BiometricDatabase.Status']/field[@name='ERR_BAD_FINGERPRINT_DATA']"
		[Register ("ERR_BAD_FINGERPRINT_DATA")]
		public static global::Com.Credenceid.Database.BiometricDatabaseStatus ErrBadFingerprintData {
			get {
				if (ERR_BAD_FINGERPRINT_DATA_jfieldId == IntPtr.Zero)
					ERR_BAD_FINGERPRINT_DATA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERR_BAD_FINGERPRINT_DATA", "Lcom/credenceid/database/BiometricDatabase$Status;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERR_BAD_FINGERPRINT_DATA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.BiometricDatabaseStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ERR_BAD_IRIS_DATA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.database']/class[@name='BiometricDatabase.Status']/field[@name='ERR_BAD_IRIS_DATA']"
		[Register ("ERR_BAD_IRIS_DATA")]
		public static global::Com.Credenceid.Database.BiometricDatabaseStatus ErrBadIrisData {
			get {
				if (ERR_BAD_IRIS_DATA_jfieldId == IntPtr.Zero)
					ERR_BAD_IRIS_DATA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERR_BAD_IRIS_DATA", "Lcom/credenceid/database/BiometricDatabase$Status;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERR_BAD_IRIS_DATA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.BiometricDatabaseStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ERR_DB_READ_WRITE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.database']/class[@name='BiometricDatabase.Status']/field[@name='ERR_DB_READ_WRITE']"
		[Register ("ERR_DB_READ_WRITE")]
		public static global::Com.Credenceid.Database.BiometricDatabaseStatus ErrDbReadWrite {
			get {
				if (ERR_DB_READ_WRITE_jfieldId == IntPtr.Zero)
					ERR_DB_READ_WRITE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERR_DB_READ_WRITE", "Lcom/credenceid/database/BiometricDatabase$Status;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERR_DB_READ_WRITE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.BiometricDatabaseStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ERR_NO_DATA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.database']/class[@name='BiometricDatabase.Status']/field[@name='ERR_NO_DATA']"
		[Register ("ERR_NO_DATA")]
		public static global::Com.Credenceid.Database.BiometricDatabaseStatus ErrNoData {
			get {
				if (ERR_NO_DATA_jfieldId == IntPtr.Zero)
					ERR_NO_DATA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERR_NO_DATA", "Lcom/credenceid/database/BiometricDatabase$Status;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERR_NO_DATA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.BiometricDatabaseStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ERR_RECORD_ALREADY_EXISTS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.database']/class[@name='BiometricDatabase.Status']/field[@name='ERR_RECORD_ALREADY_EXISTS']"
		[Register ("ERR_RECORD_ALREADY_EXISTS")]
		public static global::Com.Credenceid.Database.BiometricDatabaseStatus ErrRecordAlreadyExists {
			get {
				if (ERR_RECORD_ALREADY_EXISTS_jfieldId == IntPtr.Zero)
					ERR_RECORD_ALREADY_EXISTS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERR_RECORD_ALREADY_EXISTS", "Lcom/credenceid/database/BiometricDatabase$Status;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERR_RECORD_ALREADY_EXISTS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.BiometricDatabaseStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ERR_RECORD_NOT_FOUND_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.database']/class[@name='BiometricDatabase.Status']/field[@name='ERR_RECORD_NOT_FOUND']"
		[Register ("ERR_RECORD_NOT_FOUND")]
		public static global::Com.Credenceid.Database.BiometricDatabaseStatus ErrRecordNotFound {
			get {
				if (ERR_RECORD_NOT_FOUND_jfieldId == IntPtr.Zero)
					ERR_RECORD_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERR_RECORD_NOT_FOUND", "Lcom/credenceid/database/BiometricDatabase$Status;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERR_RECORD_NOT_FOUND_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.BiometricDatabaseStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr INACTIVE_API_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.database']/class[@name='BiometricDatabase.Status']/field[@name='INACTIVE_API']"
		[Register ("INACTIVE_API")]
		public static global::Com.Credenceid.Database.BiometricDatabaseStatus InactiveApi {
			get {
				if (INACTIVE_API_jfieldId == IntPtr.Zero)
					INACTIVE_API_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INACTIVE_API", "Lcom/credenceid/database/BiometricDatabase$Status;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INACTIVE_API_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.BiometricDatabaseStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr LICENSE_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.database']/class[@name='BiometricDatabase.Status']/field[@name='LICENSE_ERROR']"
		[Register ("LICENSE_ERROR")]
		public static global::Com.Credenceid.Database.BiometricDatabaseStatus LicenseError {
			get {
				if (LICENSE_ERROR_jfieldId == IntPtr.Zero)
					LICENSE_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LICENSE_ERROR", "Lcom/credenceid/database/BiometricDatabase$Status;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LICENSE_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.BiometricDatabaseStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NO_MATCH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.database']/class[@name='BiometricDatabase.Status']/field[@name='NO_MATCH']"
		[Register ("NO_MATCH")]
		public static global::Com.Credenceid.Database.BiometricDatabaseStatus NoMatch {
			get {
				if (NO_MATCH_jfieldId == IntPtr.Zero)
					NO_MATCH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NO_MATCH", "Lcom/credenceid/database/BiometricDatabase$Status;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NO_MATCH_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.BiometricDatabaseStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SUCCESS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.database']/class[@name='BiometricDatabase.Status']/field[@name='SUCCESS']"
		[Register ("SUCCESS")]
		public static global::Com.Credenceid.Database.BiometricDatabaseStatus Success {
			get {
				if (SUCCESS_jfieldId == IntPtr.Zero)
					SUCCESS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SUCCESS", "Lcom/credenceid/database/BiometricDatabase$Status;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SUCCESS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.BiometricDatabaseStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UNKNOWN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.database']/class[@name='BiometricDatabase.Status']/field[@name='UNKNOWN']"
		[Register ("UNKNOWN")]
		public static global::Com.Credenceid.Database.BiometricDatabaseStatus Unknown {
			get {
				if (UNKNOWN_jfieldId == IntPtr.Zero)
					UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN", "Lcom/credenceid/database/BiometricDatabase$Status;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNKNOWN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.BiometricDatabaseStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/credenceid/database/BiometricDatabase$Status", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BiometricDatabaseStatus); }
		}

		internal BiometricDatabaseStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getValue;
		public unsafe int Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/class[@name='BiometricDatabase.Status']/method[@name='getValue' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/class[@name='BiometricDatabase.Status']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("valueOf", "(I)Lcom/credenceid/database/BiometricDatabase$Status;", "")]
		public static unsafe global::Com.Credenceid.Database.BiometricDatabaseStatus ValueOf (int val)
		{
			if (id_valueOf_I == IntPtr.Zero)
				id_valueOf_I = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(I)Lcom/credenceid/database/BiometricDatabase$Status;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (val);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.BiometricDatabaseStatus> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/class[@name='BiometricDatabase.Status']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/credenceid/database/BiometricDatabase$Status;", "")]
		public static unsafe global::Com.Credenceid.Database.BiometricDatabaseStatus ValueOf (string name)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/credenceid/database/BiometricDatabase$Status;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::Com.Credenceid.Database.BiometricDatabaseStatus __ret = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.BiometricDatabaseStatus> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/class[@name='BiometricDatabase.Status']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/credenceid/database/BiometricDatabase$Status;", "")]
		public static unsafe global::Com.Credenceid.Database.BiometricDatabaseStatus[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/credenceid/database/BiometricDatabase$Status;");
			try {
				return (global::Com.Credenceid.Database.BiometricDatabaseStatus[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Credenceid.Database.BiometricDatabaseStatus));
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.credenceid.database']/interface[@name='BiometricDatabase']"
	[Register ("com/credenceid/database/BiometricDatabase", "", "Com.Credenceid.Database.IBiometricDatabaseInvoker")]
	public partial interface IBiometricDatabase : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/interface[@name='BiometricDatabase']/method[@name='delete' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.credenceid.database.BiometricDatabase.OnDeleteCallback']]"
		[Register ("delete", "(ILcom/credenceid/database/BiometricDatabase$OnDeleteCallback;)V", "GetDelete_ILcom_credenceid_database_BiometricDatabase_OnDeleteCallback_Handler:Com.Credenceid.Database.IBiometricDatabaseInvoker, CredenceBindings")]
		void Delete (int p0, global::Com.Credenceid.Database.IBiometricDatabaseOnDeleteCallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/interface[@name='BiometricDatabase']/method[@name='enroll' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='com.credenceid.database.FingerprintRecord'] and parameter[3][@type='com.credenceid.database.FaceRecord'] and parameter[4][@type='com.credenceid.database.IrisRecord'] and parameter[5][@type='com.credenceid.database.BiometricDatabase.OnEnrollCallback']]"
		[Register ("enroll", "(ILcom/credenceid/database/FingerprintRecord;Lcom/credenceid/database/FaceRecord;Lcom/credenceid/database/IrisRecord;Lcom/credenceid/database/BiometricDatabase$OnEnrollCallback;)V", "GetEnroll_ILcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnEnrollCallback_Handler:Com.Credenceid.Database.IBiometricDatabaseInvoker, CredenceBindings")]
		void Enroll (int p0, global::Com.Credenceid.Database.FingerprintRecord p1, global::Com.Credenceid.Database.FaceRecord p2, global::Com.Credenceid.Database.IrisRecord p3, global::Com.Credenceid.Database.IBiometricDatabaseOnEnrollCallback p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/interface[@name='BiometricDatabase']/method[@name='enroll' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='com.credenceid.database.FingerprintRecord[]'] and parameter[3][@type='com.credenceid.database.FaceRecord'] and parameter[4][@type='com.credenceid.database.IrisRecord[]'] and parameter[5][@type='com.credenceid.database.BiometricDatabase.OnEnrollCallback']]"
		[Register ("enroll", "(I[Lcom/credenceid/database/FingerprintRecord;Lcom/credenceid/database/FaceRecord;[Lcom/credenceid/database/IrisRecord;Lcom/credenceid/database/BiometricDatabase$OnEnrollCallback;)V", "GetEnroll_IarrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnEnrollCallback_Handler:Com.Credenceid.Database.IBiometricDatabaseInvoker, CredenceBindings")]
		void Enroll (int p0, global::Com.Credenceid.Database.FingerprintRecord[] p1, global::Com.Credenceid.Database.FaceRecord p2, global::Com.Credenceid.Database.IrisRecord[] p3, global::Com.Credenceid.Database.IBiometricDatabaseOnEnrollCallback p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/interface[@name='BiometricDatabase']/method[@name='match' and count(parameter)=4 and parameter[1][@type='com.credenceid.database.FingerprintRecord'] and parameter[2][@type='com.credenceid.database.FaceRecord'] and parameter[3][@type='com.credenceid.database.IrisRecord'] and parameter[4][@type='com.credenceid.database.BiometricDatabase.OnMatchCallback']]"
		[Register ("match", "(Lcom/credenceid/database/FingerprintRecord;Lcom/credenceid/database/FaceRecord;Lcom/credenceid/database/IrisRecord;Lcom/credenceid/database/BiometricDatabase$OnMatchCallback;)V", "GetMatch_Lcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnMatchCallback_Handler:Com.Credenceid.Database.IBiometricDatabaseInvoker, CredenceBindings")]
		void Match (global::Com.Credenceid.Database.FingerprintRecord p0, global::Com.Credenceid.Database.FaceRecord p1, global::Com.Credenceid.Database.IrisRecord p2, global::Com.Credenceid.Database.IBiometricDatabaseOnMatchCallback p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/interface[@name='BiometricDatabase']/method[@name='match' and count(parameter)=4 and parameter[1][@type='com.credenceid.database.FingerprintRecord[]'] and parameter[2][@type='com.credenceid.database.FaceRecord'] and parameter[3][@type='com.credenceid.database.IrisRecord[]'] and parameter[4][@type='com.credenceid.database.BiometricDatabase.OnMatchCallback']]"
		[Register ("match", "([Lcom/credenceid/database/FingerprintRecord;Lcom/credenceid/database/FaceRecord;[Lcom/credenceid/database/IrisRecord;Lcom/credenceid/database/BiometricDatabase$OnMatchCallback;)V", "GetMatch_arrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnMatchCallback_Handler:Com.Credenceid.Database.IBiometricDatabaseInvoker, CredenceBindings")]
		void Match (global::Com.Credenceid.Database.FingerprintRecord[] p0, global::Com.Credenceid.Database.FaceRecord p1, global::Com.Credenceid.Database.IrisRecord[] p2, global::Com.Credenceid.Database.IBiometricDatabaseOnMatchCallback p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/interface[@name='BiometricDatabase']/method[@name='read' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.credenceid.database.BiometricDatabase.OnReadCallback']]"
		[Register ("read", "(ILcom/credenceid/database/BiometricDatabase$OnReadCallback;)V", "GetRead_ILcom_credenceid_database_BiometricDatabase_OnReadCallback_Handler:Com.Credenceid.Database.IBiometricDatabaseInvoker, CredenceBindings")]
		void Read (int p0, global::Com.Credenceid.Database.IBiometricDatabaseOnReadCallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/interface[@name='BiometricDatabase']/method[@name='verify' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='com.credenceid.database.FingerprintRecord'] and parameter[3][@type='com.credenceid.database.FaceRecord'] and parameter[4][@type='com.credenceid.database.IrisRecord'] and parameter[5][@type='com.credenceid.database.BiometricDatabase.OnVerifyCallback']]"
		[Register ("verify", "(ILcom/credenceid/database/FingerprintRecord;Lcom/credenceid/database/FaceRecord;Lcom/credenceid/database/IrisRecord;Lcom/credenceid/database/BiometricDatabase$OnVerifyCallback;)V", "GetVerify_ILcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnVerifyCallback_Handler:Com.Credenceid.Database.IBiometricDatabaseInvoker, CredenceBindings")]
		void Verify (int p0, global::Com.Credenceid.Database.FingerprintRecord p1, global::Com.Credenceid.Database.FaceRecord p2, global::Com.Credenceid.Database.IrisRecord p3, global::Com.Credenceid.Database.IBiometricDatabaseOnVerifyCallback p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/interface[@name='BiometricDatabase']/method[@name='verify' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='com.credenceid.database.FingerprintRecord[]'] and parameter[3][@type='com.credenceid.database.FaceRecord'] and parameter[4][@type='com.credenceid.database.IrisRecord[]'] and parameter[5][@type='com.credenceid.database.BiometricDatabase.OnVerifyCallback']]"
		[Register ("verify", "(I[Lcom/credenceid/database/FingerprintRecord;Lcom/credenceid/database/FaceRecord;[Lcom/credenceid/database/IrisRecord;Lcom/credenceid/database/BiometricDatabase$OnVerifyCallback;)V", "GetVerify_IarrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnVerifyCallback_Handler:Com.Credenceid.Database.IBiometricDatabaseInvoker, CredenceBindings")]
		void Verify (int p0, global::Com.Credenceid.Database.FingerprintRecord[] p1, global::Com.Credenceid.Database.FaceRecord p2, global::Com.Credenceid.Database.IrisRecord[] p3, global::Com.Credenceid.Database.IBiometricDatabaseOnVerifyCallback p4);

	}

	[global::Android.Runtime.Register ("com/credenceid/database/BiometricDatabase", DoNotGenerateAcw=true)]
	internal partial class IBiometricDatabaseInvoker : global::Java.Lang.Object, IBiometricDatabase {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/credenceid/database/BiometricDatabase");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBiometricDatabaseInvoker); }
		}

		IntPtr class_ref;

		public static IBiometricDatabase GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBiometricDatabase> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.credenceid.database.BiometricDatabase"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBiometricDatabaseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_delete_ILcom_credenceid_database_BiometricDatabase_OnDeleteCallback_;
#pragma warning disable 0169
		static Delegate GetDelete_ILcom_credenceid_database_BiometricDatabase_OnDeleteCallback_Handler ()
		{
			if (cb_delete_ILcom_credenceid_database_BiometricDatabase_OnDeleteCallback_ == null)
				cb_delete_ILcom_credenceid_database_BiometricDatabase_OnDeleteCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_Delete_ILcom_credenceid_database_BiometricDatabase_OnDeleteCallback_);
			return cb_delete_ILcom_credenceid_database_BiometricDatabase_OnDeleteCallback_;
		}

		static void n_Delete_ILcom_credenceid_database_BiometricDatabase_OnDeleteCallback_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.IBiometricDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Credenceid.Database.IBiometricDatabaseOnDeleteCallback)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.IBiometricDatabaseOnDeleteCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Delete (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_delete_ILcom_credenceid_database_BiometricDatabase_OnDeleteCallback_;
		public unsafe void Delete (int p0, global::Com.Credenceid.Database.IBiometricDatabaseOnDeleteCallback p1)
		{
			if (id_delete_ILcom_credenceid_database_BiometricDatabase_OnDeleteCallback_ == IntPtr.Zero)
				id_delete_ILcom_credenceid_database_BiometricDatabase_OnDeleteCallback_ = JNIEnv.GetMethodID (class_ref, "delete", "(ILcom/credenceid/database/BiometricDatabase$OnDeleteCallback;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_delete_ILcom_credenceid_database_BiometricDatabase_OnDeleteCallback_, __args);
		}

		static Delegate cb_enroll_ILcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnEnrollCallback_;
#pragma warning disable 0169
		static Delegate GetEnroll_ILcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnEnrollCallback_Handler ()
		{
			if (cb_enroll_ILcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnEnrollCallback_ == null)
				cb_enroll_ILcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnEnrollCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPILLLL_V) n_Enroll_ILcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnEnrollCallback_);
			return cb_enroll_ILcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnEnrollCallback_;
		}

		static void n_Enroll_ILcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnEnrollCallback_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.IBiometricDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.FingerprintRecord> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.FaceRecord> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.IrisRecord> (native_p3, JniHandleOwnership.DoNotTransfer);
			var p4 = (global::Com.Credenceid.Database.IBiometricDatabaseOnEnrollCallback)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.IBiometricDatabaseOnEnrollCallback> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.Enroll (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_enroll_ILcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnEnrollCallback_;
		public unsafe void Enroll (int p0, global::Com.Credenceid.Database.FingerprintRecord p1, global::Com.Credenceid.Database.FaceRecord p2, global::Com.Credenceid.Database.IrisRecord p3, global::Com.Credenceid.Database.IBiometricDatabaseOnEnrollCallback p4)
		{
			if (id_enroll_ILcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnEnrollCallback_ == IntPtr.Zero)
				id_enroll_ILcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnEnrollCallback_ = JNIEnv.GetMethodID (class_ref, "enroll", "(ILcom/credenceid/database/FingerprintRecord;Lcom/credenceid/database/FaceRecord;Lcom/credenceid/database/IrisRecord;Lcom/credenceid/database/BiometricDatabase$OnEnrollCallback;)V");
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (p4);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_enroll_ILcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnEnrollCallback_, __args);
		}

		static Delegate cb_enroll_IarrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnEnrollCallback_;
#pragma warning disable 0169
		static Delegate GetEnroll_IarrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnEnrollCallback_Handler ()
		{
			if (cb_enroll_IarrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnEnrollCallback_ == null)
				cb_enroll_IarrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnEnrollCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPILLLL_V) n_Enroll_IarrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnEnrollCallback_);
			return cb_enroll_IarrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnEnrollCallback_;
		}

		static void n_Enroll_IarrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnEnrollCallback_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.IBiometricDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Credenceid.Database.FingerprintRecord[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Credenceid.Database.FingerprintRecord));
			var p2 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.FaceRecord> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = (global::Com.Credenceid.Database.IrisRecord[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Credenceid.Database.IrisRecord));
			var p4 = (global::Com.Credenceid.Database.IBiometricDatabaseOnEnrollCallback)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.IBiometricDatabaseOnEnrollCallback> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.Enroll (p0, p1, p2, p3, p4);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
		}
#pragma warning restore 0169

		IntPtr id_enroll_IarrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnEnrollCallback_;
		public unsafe void Enroll (int p0, global::Com.Credenceid.Database.FingerprintRecord[] p1, global::Com.Credenceid.Database.FaceRecord p2, global::Com.Credenceid.Database.IrisRecord[] p3, global::Com.Credenceid.Database.IBiometricDatabaseOnEnrollCallback p4)
		{
			if (id_enroll_IarrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnEnrollCallback_ == IntPtr.Zero)
				id_enroll_IarrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnEnrollCallback_ = JNIEnv.GetMethodID (class_ref, "enroll", "(I[Lcom/credenceid/database/FingerprintRecord;Lcom/credenceid/database/FaceRecord;[Lcom/credenceid/database/IrisRecord;Lcom/credenceid/database/BiometricDatabase$OnEnrollCallback;)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (p4);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_enroll_IarrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnEnrollCallback_, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_match_Lcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnMatchCallback_;
#pragma warning disable 0169
		static Delegate GetMatch_Lcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnMatchCallback_Handler ()
		{
			if (cb_match_Lcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnMatchCallback_ == null)
				cb_match_Lcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnMatchCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_Match_Lcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnMatchCallback_);
			return cb_match_Lcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnMatchCallback_;
		}

		static void n_Match_Lcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnMatchCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.IBiometricDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.FingerprintRecord> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.FaceRecord> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.IrisRecord> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = (global::Com.Credenceid.Database.IBiometricDatabaseOnMatchCallback)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.IBiometricDatabaseOnMatchCallback> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.Match (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_match_Lcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnMatchCallback_;
		public unsafe void Match (global::Com.Credenceid.Database.FingerprintRecord p0, global::Com.Credenceid.Database.FaceRecord p1, global::Com.Credenceid.Database.IrisRecord p2, global::Com.Credenceid.Database.IBiometricDatabaseOnMatchCallback p3)
		{
			if (id_match_Lcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnMatchCallback_ == IntPtr.Zero)
				id_match_Lcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnMatchCallback_ = JNIEnv.GetMethodID (class_ref, "match", "(Lcom/credenceid/database/FingerprintRecord;Lcom/credenceid/database/FaceRecord;Lcom/credenceid/database/IrisRecord;Lcom/credenceid/database/BiometricDatabase$OnMatchCallback;)V");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_match_Lcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnMatchCallback_, __args);
		}

		static Delegate cb_match_arrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnMatchCallback_;
#pragma warning disable 0169
		static Delegate GetMatch_arrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnMatchCallback_Handler ()
		{
			if (cb_match_arrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnMatchCallback_ == null)
				cb_match_arrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnMatchCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_Match_arrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnMatchCallback_);
			return cb_match_arrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnMatchCallback_;
		}

		static void n_Match_arrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnMatchCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.IBiometricDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Credenceid.Database.FingerprintRecord[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Credenceid.Database.FingerprintRecord));
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.FaceRecord> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Com.Credenceid.Database.IrisRecord[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Credenceid.Database.IrisRecord));
			var p3 = (global::Com.Credenceid.Database.IBiometricDatabaseOnMatchCallback)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.IBiometricDatabaseOnMatchCallback> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.Match (p0, p1, p2, p3);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		IntPtr id_match_arrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnMatchCallback_;
		public unsafe void Match (global::Com.Credenceid.Database.FingerprintRecord[] p0, global::Com.Credenceid.Database.FaceRecord p1, global::Com.Credenceid.Database.IrisRecord[] p2, global::Com.Credenceid.Database.IBiometricDatabaseOnMatchCallback p3)
		{
			if (id_match_arrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnMatchCallback_ == IntPtr.Zero)
				id_match_arrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnMatchCallback_ = JNIEnv.GetMethodID (class_ref, "match", "([Lcom/credenceid/database/FingerprintRecord;Lcom/credenceid/database/FaceRecord;[Lcom/credenceid/database/IrisRecord;Lcom/credenceid/database/BiometricDatabase$OnMatchCallback;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_match_arrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnMatchCallback_, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_read_ILcom_credenceid_database_BiometricDatabase_OnReadCallback_;
#pragma warning disable 0169
		static Delegate GetRead_ILcom_credenceid_database_BiometricDatabase_OnReadCallback_Handler ()
		{
			if (cb_read_ILcom_credenceid_database_BiometricDatabase_OnReadCallback_ == null)
				cb_read_ILcom_credenceid_database_BiometricDatabase_OnReadCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_Read_ILcom_credenceid_database_BiometricDatabase_OnReadCallback_);
			return cb_read_ILcom_credenceid_database_BiometricDatabase_OnReadCallback_;
		}

		static void n_Read_ILcom_credenceid_database_BiometricDatabase_OnReadCallback_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.IBiometricDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Credenceid.Database.IBiometricDatabaseOnReadCallback)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.IBiometricDatabaseOnReadCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Read (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_read_ILcom_credenceid_database_BiometricDatabase_OnReadCallback_;
		public unsafe void Read (int p0, global::Com.Credenceid.Database.IBiometricDatabaseOnReadCallback p1)
		{
			if (id_read_ILcom_credenceid_database_BiometricDatabase_OnReadCallback_ == IntPtr.Zero)
				id_read_ILcom_credenceid_database_BiometricDatabase_OnReadCallback_ = JNIEnv.GetMethodID (class_ref, "read", "(ILcom/credenceid/database/BiometricDatabase$OnReadCallback;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_read_ILcom_credenceid_database_BiometricDatabase_OnReadCallback_, __args);
		}

		static Delegate cb_verify_ILcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnVerifyCallback_;
#pragma warning disable 0169
		static Delegate GetVerify_ILcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnVerifyCallback_Handler ()
		{
			if (cb_verify_ILcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnVerifyCallback_ == null)
				cb_verify_ILcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnVerifyCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPILLLL_V) n_Verify_ILcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnVerifyCallback_);
			return cb_verify_ILcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnVerifyCallback_;
		}

		static void n_Verify_ILcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnVerifyCallback_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.IBiometricDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.FingerprintRecord> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.FaceRecord> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.IrisRecord> (native_p3, JniHandleOwnership.DoNotTransfer);
			var p4 = (global::Com.Credenceid.Database.IBiometricDatabaseOnVerifyCallback)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.IBiometricDatabaseOnVerifyCallback> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.Verify (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_verify_ILcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnVerifyCallback_;
		public unsafe void Verify (int p0, global::Com.Credenceid.Database.FingerprintRecord p1, global::Com.Credenceid.Database.FaceRecord p2, global::Com.Credenceid.Database.IrisRecord p3, global::Com.Credenceid.Database.IBiometricDatabaseOnVerifyCallback p4)
		{
			if (id_verify_ILcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnVerifyCallback_ == IntPtr.Zero)
				id_verify_ILcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnVerifyCallback_ = JNIEnv.GetMethodID (class_ref, "verify", "(ILcom/credenceid/database/FingerprintRecord;Lcom/credenceid/database/FaceRecord;Lcom/credenceid/database/IrisRecord;Lcom/credenceid/database/BiometricDatabase$OnVerifyCallback;)V");
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (p4);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_verify_ILcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_Lcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnVerifyCallback_, __args);
		}

		static Delegate cb_verify_IarrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnVerifyCallback_;
#pragma warning disable 0169
		static Delegate GetVerify_IarrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnVerifyCallback_Handler ()
		{
			if (cb_verify_IarrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnVerifyCallback_ == null)
				cb_verify_IarrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnVerifyCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPILLLL_V) n_Verify_IarrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnVerifyCallback_);
			return cb_verify_IarrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnVerifyCallback_;
		}

		static void n_Verify_IarrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnVerifyCallback_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.IBiometricDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Credenceid.Database.FingerprintRecord[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Credenceid.Database.FingerprintRecord));
			var p2 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.FaceRecord> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = (global::Com.Credenceid.Database.IrisRecord[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Credenceid.Database.IrisRecord));
			var p4 = (global::Com.Credenceid.Database.IBiometricDatabaseOnVerifyCallback)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.IBiometricDatabaseOnVerifyCallback> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.Verify (p0, p1, p2, p3, p4);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
		}
#pragma warning restore 0169

		IntPtr id_verify_IarrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnVerifyCallback_;
		public unsafe void Verify (int p0, global::Com.Credenceid.Database.FingerprintRecord[] p1, global::Com.Credenceid.Database.FaceRecord p2, global::Com.Credenceid.Database.IrisRecord[] p3, global::Com.Credenceid.Database.IBiometricDatabaseOnVerifyCallback p4)
		{
			if (id_verify_IarrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnVerifyCallback_ == IntPtr.Zero)
				id_verify_IarrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnVerifyCallback_ = JNIEnv.GetMethodID (class_ref, "verify", "(I[Lcom/credenceid/database/FingerprintRecord;Lcom/credenceid/database/FaceRecord;[Lcom/credenceid/database/IrisRecord;Lcom/credenceid/database/BiometricDatabase$OnVerifyCallback;)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (p4);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_verify_IarrayLcom_credenceid_database_FingerprintRecord_Lcom_credenceid_database_FaceRecord_arrayLcom_credenceid_database_IrisRecord_Lcom_credenceid_database_BiometricDatabase_OnVerifyCallback_, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

	}

}
