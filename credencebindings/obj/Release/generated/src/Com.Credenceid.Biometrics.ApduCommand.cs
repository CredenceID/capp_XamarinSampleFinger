using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Credenceid.Biometrics {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='ApduCommand']"
	[global::Android.Runtime.Register ("com/credenceid/biometrics/ApduCommand", DoNotGenerateAcw=true)]
	public partial class ApduCommand : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='ApduCommand']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr cla_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='ApduCommand']/field[@name='cla']"
		[Register ("cla")]
		public sbyte Cla {
			get {
				if (cla_jfieldId == IntPtr.Zero)
					cla_jfieldId = JNIEnv.GetFieldID (class_ref, "cla", "B");
				return JNIEnv.GetByteField (((global::Java.Lang.Object) this).Handle, cla_jfieldId);
			}
			set {
				if (cla_jfieldId == IntPtr.Zero)
					cla_jfieldId = JNIEnv.GetFieldID (class_ref, "cla", "B");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, cla_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr command_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='ApduCommand']/field[@name='command']"
		[Register ("command")]
		public IList<byte> Command {
			get {
				if (command_jfieldId == IntPtr.Zero)
					command_jfieldId = JNIEnv.GetFieldID (class_ref, "command", "[B");
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, command_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (command_jfieldId == IntPtr.Zero)
					command_jfieldId = JNIEnv.GetFieldID (class_ref, "command", "[B");
				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, command_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr ins_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='ApduCommand']/field[@name='ins']"
		[Register ("ins")]
		public sbyte Ins {
			get {
				if (ins_jfieldId == IntPtr.Zero)
					ins_jfieldId = JNIEnv.GetFieldID (class_ref, "ins", "B");
				return JNIEnv.GetByteField (((global::Java.Lang.Object) this).Handle, ins_jfieldId);
			}
			set {
				if (ins_jfieldId == IntPtr.Zero)
					ins_jfieldId = JNIEnv.GetFieldID (class_ref, "ins", "B");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, ins_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr p1_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='ApduCommand']/field[@name='p1']"
		[Register ("p1")]
		public sbyte P1 {
			get {
				if (p1_jfieldId == IntPtr.Zero)
					p1_jfieldId = JNIEnv.GetFieldID (class_ref, "p1", "B");
				return JNIEnv.GetByteField (((global::Java.Lang.Object) this).Handle, p1_jfieldId);
			}
			set {
				if (p1_jfieldId == IntPtr.Zero)
					p1_jfieldId = JNIEnv.GetFieldID (class_ref, "p1", "B");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, p1_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr p2_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='ApduCommand']/field[@name='p2']"
		[Register ("p2")]
		public sbyte P2 {
			get {
				if (p2_jfieldId == IntPtr.Zero)
					p2_jfieldId = JNIEnv.GetFieldID (class_ref, "p2", "B");
				return JNIEnv.GetByteField (((global::Java.Lang.Object) this).Handle, p2_jfieldId);
			}
			set {
				if (p2_jfieldId == IntPtr.Zero)
					p2_jfieldId = JNIEnv.GetFieldID (class_ref, "p2", "B");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, p2_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr response_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='ApduCommand']/field[@name='response']"
		[Register ("response")]
		public IList<byte> Response {
			get {
				if (response_jfieldId == IntPtr.Zero)
					response_jfieldId = JNIEnv.GetFieldID (class_ref, "response", "[B");
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, response_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (response_jfieldId == IntPtr.Zero)
					response_jfieldId = JNIEnv.GetFieldID (class_ref, "response", "[B");
				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, response_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr sw1_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='ApduCommand']/field[@name='sw1']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='ApduCommand']/field[@name='sw2']"
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
				return JNIEnv.FindClass ("com/credenceid/biometrics/ApduCommand", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ApduCommand); }
		}

		protected ApduCommand (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_BBBBarrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='ApduCommand']/constructor[@name='ApduCommand' and count(parameter)=5 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='byte'] and parameter[4][@type='byte'] and parameter[5][@type='byte[]']]"
		[Register (".ctor", "(BBBB[B)V", "")]
		public unsafe ApduCommand (sbyte cla, sbyte ins, sbyte p1, sbyte p2, byte[] command)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_command = JNIEnv.NewArray (command);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (cla);
				__args [1] = new JValue (ins);
				__args [2] = new JValue (p1);
				__args [3] = new JValue (p2);
				__args [4] = new JValue (native_command);
				if (((object) this).GetType () != typeof (ApduCommand)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(BBBB[B)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(BBBB[B)V", __args);
					return;
				}

				if (id_ctor_BBBBarrayB == IntPtr.Zero)
					id_ctor_BBBBarrayB = JNIEnv.GetMethodID (class_ref, "<init>", "(BBBB[B)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_BBBBarrayB, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_BBBBarrayB, __args);
			} finally {
				if (command != null) {
					JNIEnv.CopyArray (native_command, command);
					JNIEnv.DeleteLocalRef (native_command);
				}
			}
		}

		static IntPtr id_ctor_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='ApduCommand']/constructor[@name='ApduCommand' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public unsafe ApduCommand (byte[] command)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_command = JNIEnv.NewArray (command);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_command);
				if (((object) this).GetType () != typeof (ApduCommand)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([B)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([B)V", __args);
					return;
				}

				if (id_ctor_arrayB == IntPtr.Zero)
					id_ctor_arrayB = JNIEnv.GetMethodID (class_ref, "<init>", "([B)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayB, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayB, __args);
			} finally {
				if (command != null) {
					JNIEnv.CopyArray (native_command, command);
					JNIEnv.DeleteLocalRef (native_command);
				}
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='ApduCommand']/constructor[@name='ApduCommand' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe ApduCommand (string APDU)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_APDU = JNIEnv.NewString (APDU);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_APDU);
				if (((object) this).GetType () != typeof (ApduCommand)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_APDU);
			}
		}

		static Delegate cb_isSuccess;
#pragma warning disable 0169
		static Delegate GetIsSuccessHandler ()
		{
			if (cb_isSuccess == null)
				cb_isSuccess = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsSuccess);
			return cb_isSuccess;
		}

		static bool n_IsSuccess (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.ApduCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSuccess;
		}
#pragma warning restore 0169

		static IntPtr id_isSuccess;
		public virtual unsafe bool IsSuccess {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='ApduCommand']/method[@name='isSuccess' and count(parameter)=0]"
			[Register ("isSuccess", "()Z", "GetIsSuccessHandler")]
			get {
				if (id_isSuccess == IntPtr.Zero)
					id_isSuccess = JNIEnv.GetMethodID (class_ref, "isSuccess", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSuccess);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSuccess", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.ApduCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='ApduCommand']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public virtual unsafe int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_describeContents);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "describeContents", "()I"));
			} finally {
			}
		}

		static Delegate cb_getCommandBytes;
#pragma warning disable 0169
		static Delegate GetGetCommandBytesHandler ()
		{
			if (cb_getCommandBytes == null)
				cb_getCommandBytes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCommandBytes);
			return cb_getCommandBytes;
		}

		static IntPtr n_GetCommandBytes (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.ApduCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetCommandBytes ());
		}
#pragma warning restore 0169

		static IntPtr id_getCommandBytes;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='ApduCommand']/method[@name='getCommandBytes' and count(parameter)=0]"
		[Register ("getCommandBytes", "()[B", "GetGetCommandBytesHandler")]
		public virtual unsafe byte[] GetCommandBytes ()
		{
			if (id_getCommandBytes == IntPtr.Zero)
				id_getCommandBytes = JNIEnv.GetMethodID (class_ref, "getCommandBytes", "()[B");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCommandBytes), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCommandBytes", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_setResponse_arrayB;
#pragma warning disable 0169
		static Delegate GetSetResponse_arrayBHandler ()
		{
			if (cb_setResponse_arrayB == null)
				cb_setResponse_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetResponse_arrayB);
			return cb_setResponse_arrayB;
		}

		static void n_SetResponse_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_response_data)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.ApduCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var response_data = (byte[]) JNIEnv.GetArray (native_response_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetResponse (response_data);
			if (response_data != null)
				JNIEnv.CopyArray (response_data, native_response_data);
		}
#pragma warning restore 0169

		static IntPtr id_setResponse_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='ApduCommand']/method[@name='setResponse' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setResponse", "([B)V", "GetSetResponse_arrayBHandler")]
		public virtual unsafe void SetResponse (byte[] response_data)
		{
			if (id_setResponse_arrayB == IntPtr.Zero)
				id_setResponse_arrayB = JNIEnv.GetMethodID (class_ref, "setResponse", "([B)V");
			IntPtr native_response_data = JNIEnv.NewArray (response_data);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_response_data);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setResponse_arrayB, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setResponse", "([B)V"), __args);
			} finally {
				if (response_data != null) {
					JNIEnv.CopyArray (native_response_data, response_data);
					JNIEnv.DeleteLocalRef (native_response_data);
				}
			}
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_dest, int native_flags)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.ApduCommand> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			var flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='ApduCommand']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (dest);
				__args [1] = new JValue ((int) flags);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeToParcel", "(Landroid/os/Parcel;I)V"), __args);
			} finally {
			}
		}

	}
}
