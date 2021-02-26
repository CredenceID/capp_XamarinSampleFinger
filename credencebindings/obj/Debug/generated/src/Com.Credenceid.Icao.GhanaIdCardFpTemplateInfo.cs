using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Credenceid.Icao {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GhanaIdCardFpTemplateInfo']"
	[global::Android.Runtime.Register ("com/credenceid/icao/GhanaIdCardFpTemplateInfo", DoNotGenerateAcw=true)]
	public partial class GhanaIdCardFpTemplateInfo : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/credenceid/icao/GhanaIdCardFpTemplateInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GhanaIdCardFpTemplateInfo); }
		}

		protected GhanaIdCardFpTemplateInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayBB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GhanaIdCardFpTemplateInfo']/constructor[@name='GhanaIdCardFpTemplateInfo' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte']]"
		[Register (".ctor", "([BB)V", "")]
		public unsafe GhanaIdCardFpTemplateInfo (byte[] fpTemplate, sbyte position)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_fpTemplate = JNIEnv.NewArray (fpTemplate);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_fpTemplate);
				__args [1] = new JValue (position);
				if (((object) this).GetType () != typeof (GhanaIdCardFpTemplateInfo)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([BB)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([BB)V", __args);
					return;
				}

				if (id_ctor_arrayBB == IntPtr.Zero)
					id_ctor_arrayBB = JNIEnv.GetMethodID (class_ref, "<init>", "([BB)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayBB, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayBB, __args);
			} finally {
				if (fpTemplate != null) {
					JNIEnv.CopyArray (native_fpTemplate, fpTemplate);
					JNIEnv.DeleteLocalRef (native_fpTemplate);
				}
			}
		}

		static Delegate cb_getPosition;
#pragma warning disable 0169
		static Delegate GetGetPositionHandler ()
		{
			if (cb_getPosition == null)
				cb_getPosition = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_B) n_GetPosition);
			return cb_getPosition;
		}

		static sbyte n_GetPosition (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.GhanaIdCardFpTemplateInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Position;
		}
#pragma warning restore 0169

		static IntPtr id_getPosition;
		public virtual unsafe sbyte Position {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GhanaIdCardFpTemplateInfo']/method[@name='getPosition' and count(parameter)=0]"
			[Register ("getPosition", "()B", "GetGetPositionHandler")]
			get {
				if (id_getPosition == IntPtr.Zero)
					id_getPosition = JNIEnv.GetMethodID (class_ref, "getPosition", "()B");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallByteMethod (((global::Java.Lang.Object) this).Handle, id_getPosition);
					else
						return JNIEnv.CallNonvirtualByteMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPosition", "()B"));
				} finally {
				}
			}
		}

		static Delegate cb_getPositionName;
#pragma warning disable 0169
		static Delegate GetGetPositionNameHandler ()
		{
			if (cb_getPositionName == null)
				cb_getPositionName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPositionName);
			return cb_getPositionName;
		}

		static IntPtr n_GetPositionName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.GhanaIdCardFpTemplateInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PositionName);
		}
#pragma warning restore 0169

		static IntPtr id_getPositionName;
		public virtual unsafe string PositionName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GhanaIdCardFpTemplateInfo']/method[@name='getPositionName' and count(parameter)=0]"
			[Register ("getPositionName", "()Ljava/lang/String;", "GetGetPositionNameHandler")]
			get {
				if (id_getPositionName == IntPtr.Zero)
					id_getPositionName = JNIEnv.GetMethodID (class_ref, "getPositionName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPositionName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPositionName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMinutiae;
#pragma warning disable 0169
		static Delegate GetGetMinutiaeHandler ()
		{
			if (cb_getMinutiae == null)
				cb_getMinutiae = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMinutiae);
			return cb_getMinutiae;
		}

		static IntPtr n_GetMinutiae (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.GhanaIdCardFpTemplateInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetMinutiae ());
		}
#pragma warning restore 0169

		static IntPtr id_getMinutiae;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='GhanaIdCardFpTemplateInfo']/method[@name='getMinutiae' and count(parameter)=0]"
		[Register ("getMinutiae", "()[B", "GetGetMinutiaeHandler")]
		public virtual unsafe byte[] GetMinutiae ()
		{
			if (id_getMinutiae == IntPtr.Zero)
				id_getMinutiae = JNIEnv.GetMethodID (class_ref, "getMinutiae", "()[B");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMinutiae), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMinutiae", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

	}
}
