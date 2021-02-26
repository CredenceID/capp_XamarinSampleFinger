using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Credenceid.Database {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.credenceid.database']/class[@name='BiometricData']"
	[global::Android.Runtime.Register ("com/credenceid/database/BiometricData", DoNotGenerateAcw=true)]
	public partial class BiometricData : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/credenceid/database/BiometricData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BiometricData); }
		}

		protected BiometricData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.database']/class[@name='BiometricData']/constructor[@name='BiometricData' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BiometricData ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BiometricData)) {
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

		static IntPtr id_ctor_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.database']/class[@name='BiometricData']/constructor[@name='BiometricData' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register (".ctor", "(Landroid/graphics/Bitmap;)V", "")]
		public unsafe BiometricData (global::Android.Graphics.Bitmap imageOne)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (imageOne);
				if (((object) this).GetType () != typeof (BiometricData)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/graphics/Bitmap;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/graphics/Bitmap;)V", __args);
					return;
				}

				if (id_ctor_Landroid_graphics_Bitmap_ == IntPtr.Zero)
					id_ctor_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/graphics/Bitmap;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_graphics_Bitmap_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_graphics_Bitmap_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.database']/class[@name='BiometricData']/constructor[@name='BiometricData' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='android.graphics.Bitmap']]"
		[Register (".ctor", "(Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;)V", "")]
		public unsafe BiometricData (global::Android.Graphics.Bitmap imageOne, global::Android.Graphics.Bitmap imageTwo)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (imageOne);
				__args [1] = new JValue (imageTwo);
				if (((object) this).GetType () != typeof (BiometricData)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;)V", __args);
					return;
				}

				if (id_ctor_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_ == IntPtr.Zero)
					id_ctor_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.database']/class[@name='BiometricData']/constructor[@name='BiometricData' and count(parameter)=3 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='android.graphics.Bitmap'] and parameter[3][@type='android.graphics.Bitmap']]"
		[Register (".ctor", "(Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;)V", "")]
		public unsafe BiometricData (global::Android.Graphics.Bitmap imageOne, global::Android.Graphics.Bitmap imageTwo, global::Android.Graphics.Bitmap imageThree)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (imageOne);
				__args [1] = new JValue (imageTwo);
				__args [2] = new JValue (imageThree);
				if (((object) this).GetType () != typeof (BiometricData)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;)V", __args);
					return;
				}

				if (id_ctor_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_ == IntPtr.Zero)
					id_ctor_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.database']/class[@name='BiometricData']/constructor[@name='BiometricData' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public unsafe BiometricData (byte[] imageOne)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_imageOne = JNIEnv.NewArray (imageOne);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_imageOne);
				if (((object) this).GetType () != typeof (BiometricData)) {
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
				if (imageOne != null) {
					JNIEnv.CopyArray (native_imageOne, imageOne);
					JNIEnv.DeleteLocalRef (native_imageOne);
				}
			}
		}

		static IntPtr id_ctor_arrayBarrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.database']/class[@name='BiometricData']/constructor[@name='BiometricData' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register (".ctor", "([B[B)V", "")]
		public unsafe BiometricData (byte[] imageOne, byte[] imageTwo)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_imageOne = JNIEnv.NewArray (imageOne);
			IntPtr native_imageTwo = JNIEnv.NewArray (imageTwo);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_imageOne);
				__args [1] = new JValue (native_imageTwo);
				if (((object) this).GetType () != typeof (BiometricData)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([B[B)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([B[B)V", __args);
					return;
				}

				if (id_ctor_arrayBarrayB == IntPtr.Zero)
					id_ctor_arrayBarrayB = JNIEnv.GetMethodID (class_ref, "<init>", "([B[B)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayBarrayB, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayBarrayB, __args);
			} finally {
				if (imageOne != null) {
					JNIEnv.CopyArray (native_imageOne, imageOne);
					JNIEnv.DeleteLocalRef (native_imageOne);
				}
				if (imageTwo != null) {
					JNIEnv.CopyArray (native_imageTwo, imageTwo);
					JNIEnv.DeleteLocalRef (native_imageTwo);
				}
			}
		}

		static IntPtr id_ctor_arrayBarrayBarrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.database']/class[@name='BiometricData']/constructor[@name='BiometricData' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
		[Register (".ctor", "([B[B[B)V", "")]
		public unsafe BiometricData (byte[] imageOne, byte[] imageTwo, byte[] imageThree)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_imageOne = JNIEnv.NewArray (imageOne);
			IntPtr native_imageTwo = JNIEnv.NewArray (imageTwo);
			IntPtr native_imageThree = JNIEnv.NewArray (imageThree);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_imageOne);
				__args [1] = new JValue (native_imageTwo);
				__args [2] = new JValue (native_imageThree);
				if (((object) this).GetType () != typeof (BiometricData)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([B[B[B)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([B[B[B)V", __args);
					return;
				}

				if (id_ctor_arrayBarrayBarrayB == IntPtr.Zero)
					id_ctor_arrayBarrayBarrayB = JNIEnv.GetMethodID (class_ref, "<init>", "([B[B[B)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayBarrayBarrayB, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayBarrayBarrayB, __args);
			} finally {
				if (imageOne != null) {
					JNIEnv.CopyArray (native_imageOne, imageOne);
					JNIEnv.DeleteLocalRef (native_imageOne);
				}
				if (imageTwo != null) {
					JNIEnv.CopyArray (native_imageTwo, imageTwo);
					JNIEnv.DeleteLocalRef (native_imageTwo);
				}
				if (imageThree != null) {
					JNIEnv.CopyArray (native_imageThree, imageThree);
					JNIEnv.DeleteLocalRef (native_imageThree);
				}
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.database']/class[@name='BiometricData']/constructor[@name='BiometricData' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe BiometricData (string imageOneAbsPath)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_imageOneAbsPath = JNIEnv.NewString (imageOneAbsPath);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_imageOneAbsPath);
				if (((object) this).GetType () != typeof (BiometricData)) {
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
				JNIEnv.DeleteLocalRef (native_imageOneAbsPath);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.database']/class[@name='BiometricData']/constructor[@name='BiometricData' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe BiometricData (string imageOneAbsPath, string imageTwoAbsPath)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_imageOneAbsPath = JNIEnv.NewString (imageOneAbsPath);
			IntPtr native_imageTwoAbsPath = JNIEnv.NewString (imageTwoAbsPath);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_imageOneAbsPath);
				__args [1] = new JValue (native_imageTwoAbsPath);
				if (((object) this).GetType () != typeof (BiometricData)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_imageOneAbsPath);
				JNIEnv.DeleteLocalRef (native_imageTwoAbsPath);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.database']/class[@name='BiometricData']/constructor[@name='BiometricData' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe BiometricData (string imageOneAbsPath, string imageTwoAbsPath, string imageThreeAbsPath)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_imageOneAbsPath = JNIEnv.NewString (imageOneAbsPath);
			IntPtr native_imageTwoAbsPath = JNIEnv.NewString (imageTwoAbsPath);
			IntPtr native_imageThreeAbsPath = JNIEnv.NewString (imageThreeAbsPath);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_imageOneAbsPath);
				__args [1] = new JValue (native_imageTwoAbsPath);
				__args [2] = new JValue (native_imageThreeAbsPath);
				if (((object) this).GetType () != typeof (BiometricData)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_imageOneAbsPath);
				JNIEnv.DeleteLocalRef (native_imageTwoAbsPath);
				JNIEnv.DeleteLocalRef (native_imageThreeAbsPath);
			}
		}

		static Delegate cb_getGUID;
#pragma warning disable 0169
		static Delegate GetGetGUIDHandler ()
		{
			if (cb_getGUID == null)
				cb_getGUID = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetGUID);
			return cb_getGUID;
		}

		static IntPtr n_GetGUID (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.BiometricData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GUID);
		}
#pragma warning restore 0169

		static Delegate cb_setGUID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetGUID_Ljava_lang_String_Handler ()
		{
			if (cb_setGUID_Ljava_lang_String_ == null)
				cb_setGUID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetGUID_Ljava_lang_String_);
			return cb_setGUID_Ljava_lang_String_;
		}

		static void n_SetGUID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_GUID)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.BiometricData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var GUID = JNIEnv.GetString (native_GUID, JniHandleOwnership.DoNotTransfer);
			__this.GUID = GUID;
		}
#pragma warning restore 0169

		static IntPtr id_getGUID;
		static IntPtr id_setGUID_Ljava_lang_String_;
		public virtual unsafe string GUID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/class[@name='BiometricData']/method[@name='getGUID' and count(parameter)=0]"
			[Register ("getGUID", "()Ljava/lang/String;", "GetGetGUIDHandler")]
			get {
				if (id_getGUID == IntPtr.Zero)
					id_getGUID = JNIEnv.GetMethodID (class_ref, "getGUID", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGUID), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGUID", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/class[@name='BiometricData']/method[@name='setGUID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setGUID", "(Ljava/lang/String;)V", "GetSetGUID_Ljava_lang_String_Handler")]
			set {
				if (id_setGUID_Ljava_lang_String_ == IntPtr.Zero)
					id_setGUID_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setGUID", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setGUID_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setGUID", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getImages;
#pragma warning disable 0169
		static Delegate GetGetImagesHandler ()
		{
			if (cb_getImages == null)
				cb_getImages = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetImages);
			return cb_getImages;
		}

		static IntPtr n_GetImages (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.BiometricData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<byte[]>.ToLocalJniHandle (__this.Images);
		}
#pragma warning restore 0169

		static IntPtr id_getImages;
		public virtual unsafe global::System.Collections.Generic.IList<byte[]> Images {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/class[@name='BiometricData']/method[@name='getImages' and count(parameter)=0]"
			[Register ("getImages", "()Ljava/util/List;", "GetGetImagesHandler")]
			get {
				if (id_getImages == IntPtr.Zero)
					id_getImages = JNIEnv.GetMethodID (class_ref, "getImages", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<byte[]>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getImages), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<byte[]>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImages", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getImagesAsBitmaps;
#pragma warning disable 0169
		static Delegate GetGetImagesAsBitmapsHandler ()
		{
			if (cb_getImagesAsBitmaps == null)
				cb_getImagesAsBitmaps = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetImagesAsBitmaps);
			return cb_getImagesAsBitmaps;
		}

		static IntPtr n_GetImagesAsBitmaps (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.BiometricData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Android.Graphics.Bitmap>.ToLocalJniHandle (__this.ImagesAsBitmaps);
		}
#pragma warning restore 0169

		static IntPtr id_getImagesAsBitmaps;
		public virtual unsafe global::System.Collections.Generic.IList<global::Android.Graphics.Bitmap> ImagesAsBitmaps {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/class[@name='BiometricData']/method[@name='getImagesAsBitmaps' and count(parameter)=0]"
			[Register ("getImagesAsBitmaps", "()Ljava/util/List;", "GetGetImagesAsBitmapsHandler")]
			get {
				if (id_getImagesAsBitmaps == IntPtr.Zero)
					id_getImagesAsBitmaps = JNIEnv.GetMethodID (class_ref, "getImagesAsBitmaps", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Android.Graphics.Bitmap>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getImagesAsBitmaps), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Android.Graphics.Bitmap>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImagesAsBitmaps", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTemplates;
#pragma warning disable 0169
		static Delegate GetGetTemplatesHandler ()
		{
			if (cb_getTemplates == null)
				cb_getTemplates = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTemplates);
			return cb_getTemplates;
		}

		static IntPtr n_GetTemplates (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.BiometricData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<byte[]>.ToLocalJniHandle (__this.Templates);
		}
#pragma warning restore 0169

		static IntPtr id_getTemplates;
		public virtual unsafe global::System.Collections.Generic.IList<byte[]> Templates {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/class[@name='BiometricData']/method[@name='getTemplates' and count(parameter)=0]"
			[Register ("getTemplates", "()Ljava/util/List;", "GetGetTemplatesHandler")]
			get {
				if (id_getTemplates == IntPtr.Zero)
					id_getTemplates = JNIEnv.GetMethodID (class_ref, "getTemplates", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<byte[]>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTemplates), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<byte[]>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTemplates", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_deleteImage_Lcom_credenceid_database_ImageIndex_;
#pragma warning disable 0169
		static Delegate GetDeleteImage_Lcom_credenceid_database_ImageIndex_Handler ()
		{
			if (cb_deleteImage_Lcom_credenceid_database_ImageIndex_ == null)
				cb_deleteImage_Lcom_credenceid_database_ImageIndex_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_DeleteImage_Lcom_credenceid_database_ImageIndex_);
			return cb_deleteImage_Lcom_credenceid_database_ImageIndex_;
		}

		static void n_DeleteImage_Lcom_credenceid_database_ImageIndex_ (IntPtr jnienv, IntPtr native__this, IntPtr native_index)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.BiometricData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var index = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.ImageIndex> (native_index, JniHandleOwnership.DoNotTransfer);
			__this.DeleteImage (index);
		}
#pragma warning restore 0169

		static IntPtr id_deleteImage_Lcom_credenceid_database_ImageIndex_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/class[@name='BiometricData']/method[@name='deleteImage' and count(parameter)=1 and parameter[1][@type='com.credenceid.database.ImageIndex']]"
		[Register ("deleteImage", "(Lcom/credenceid/database/ImageIndex;)V", "GetDeleteImage_Lcom_credenceid_database_ImageIndex_Handler")]
		public virtual unsafe void DeleteImage (global::Com.Credenceid.Database.ImageIndex index)
		{
			if (id_deleteImage_Lcom_credenceid_database_ImageIndex_ == IntPtr.Zero)
				id_deleteImage_Lcom_credenceid_database_ImageIndex_ = JNIEnv.GetMethodID (class_ref, "deleteImage", "(Lcom/credenceid/database/ImageIndex;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (index);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteImage_Lcom_credenceid_database_ImageIndex_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteImage", "(Lcom/credenceid/database/ImageIndex;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_deleteTemplate_Lcom_credenceid_database_ImageIndex_;
#pragma warning disable 0169
		static Delegate GetDeleteTemplate_Lcom_credenceid_database_ImageIndex_Handler ()
		{
			if (cb_deleteTemplate_Lcom_credenceid_database_ImageIndex_ == null)
				cb_deleteTemplate_Lcom_credenceid_database_ImageIndex_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_DeleteTemplate_Lcom_credenceid_database_ImageIndex_);
			return cb_deleteTemplate_Lcom_credenceid_database_ImageIndex_;
		}

		static void n_DeleteTemplate_Lcom_credenceid_database_ImageIndex_ (IntPtr jnienv, IntPtr native__this, IntPtr native_index)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.BiometricData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var index = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.ImageIndex> (native_index, JniHandleOwnership.DoNotTransfer);
			__this.DeleteTemplate (index);
		}
#pragma warning restore 0169

		static IntPtr id_deleteTemplate_Lcom_credenceid_database_ImageIndex_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/class[@name='BiometricData']/method[@name='deleteTemplate' and count(parameter)=1 and parameter[1][@type='com.credenceid.database.ImageIndex']]"
		[Register ("deleteTemplate", "(Lcom/credenceid/database/ImageIndex;)V", "GetDeleteTemplate_Lcom_credenceid_database_ImageIndex_Handler")]
		public virtual unsafe void DeleteTemplate (global::Com.Credenceid.Database.ImageIndex index)
		{
			if (id_deleteTemplate_Lcom_credenceid_database_ImageIndex_ == IntPtr.Zero)
				id_deleteTemplate_Lcom_credenceid_database_ImageIndex_ = JNIEnv.GetMethodID (class_ref, "deleteTemplate", "(Lcom/credenceid/database/ImageIndex;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (index);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteTemplate_Lcom_credenceid_database_ImageIndex_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteTemplate", "(Lcom/credenceid/database/ImageIndex;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getFirstValidImage;
#pragma warning disable 0169
		static Delegate GetGetFirstValidImageHandler ()
		{
			if (cb_getFirstValidImage == null)
				cb_getFirstValidImage = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFirstValidImage);
			return cb_getFirstValidImage;
		}

		static IntPtr n_GetFirstValidImage (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.BiometricData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetFirstValidImage ());
		}
#pragma warning restore 0169

		static IntPtr id_getFirstValidImage;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/class[@name='BiometricData']/method[@name='getFirstValidImage' and count(parameter)=0]"
		[Register ("getFirstValidImage", "()[B", "GetGetFirstValidImageHandler")]
		public virtual unsafe byte[] GetFirstValidImage ()
		{
			if (id_getFirstValidImage == IntPtr.Zero)
				id_getFirstValidImage = JNIEnv.GetMethodID (class_ref, "getFirstValidImage", "()[B");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFirstValidImage), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFirstValidImage", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_getFirstValidTemplate;
#pragma warning disable 0169
		static Delegate GetGetFirstValidTemplateHandler ()
		{
			if (cb_getFirstValidTemplate == null)
				cb_getFirstValidTemplate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFirstValidTemplate);
			return cb_getFirstValidTemplate;
		}

		static IntPtr n_GetFirstValidTemplate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.BiometricData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetFirstValidTemplate ());
		}
#pragma warning restore 0169

		static IntPtr id_getFirstValidTemplate;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/class[@name='BiometricData']/method[@name='getFirstValidTemplate' and count(parameter)=0]"
		[Register ("getFirstValidTemplate", "()[B", "GetGetFirstValidTemplateHandler")]
		public virtual unsafe byte[] GetFirstValidTemplate ()
		{
			if (id_getFirstValidTemplate == IntPtr.Zero)
				id_getFirstValidTemplate = JNIEnv.GetMethodID (class_ref, "getFirstValidTemplate", "()[B");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFirstValidTemplate), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFirstValidTemplate", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_getImage_Lcom_credenceid_database_ImageIndex_;
#pragma warning disable 0169
		static Delegate GetGetImage_Lcom_credenceid_database_ImageIndex_Handler ()
		{
			if (cb_getImage_Lcom_credenceid_database_ImageIndex_ == null)
				cb_getImage_Lcom_credenceid_database_ImageIndex_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetImage_Lcom_credenceid_database_ImageIndex_);
			return cb_getImage_Lcom_credenceid_database_ImageIndex_;
		}

		static IntPtr n_GetImage_Lcom_credenceid_database_ImageIndex_ (IntPtr jnienv, IntPtr native__this, IntPtr native_index)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.BiometricData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var index = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.ImageIndex> (native_index, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetImage (index));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getImage_Lcom_credenceid_database_ImageIndex_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/class[@name='BiometricData']/method[@name='getImage' and count(parameter)=1 and parameter[1][@type='com.credenceid.database.ImageIndex']]"
		[Register ("getImage", "(Lcom/credenceid/database/ImageIndex;)[B", "GetGetImage_Lcom_credenceid_database_ImageIndex_Handler")]
		public virtual unsafe byte[] GetImage (global::Com.Credenceid.Database.ImageIndex index)
		{
			if (id_getImage_Lcom_credenceid_database_ImageIndex_ == IntPtr.Zero)
				id_getImage_Lcom_credenceid_database_ImageIndex_ = JNIEnv.GetMethodID (class_ref, "getImage", "(Lcom/credenceid/database/ImageIndex;)[B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (index);

				byte[] __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getImage_Lcom_credenceid_database_ImageIndex_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImage", "(Lcom/credenceid/database/ImageIndex;)[B"), __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getImageAsBitmap_Lcom_credenceid_database_ImageIndex_;
#pragma warning disable 0169
		static Delegate GetGetImageAsBitmap_Lcom_credenceid_database_ImageIndex_Handler ()
		{
			if (cb_getImageAsBitmap_Lcom_credenceid_database_ImageIndex_ == null)
				cb_getImageAsBitmap_Lcom_credenceid_database_ImageIndex_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetImageAsBitmap_Lcom_credenceid_database_ImageIndex_);
			return cb_getImageAsBitmap_Lcom_credenceid_database_ImageIndex_;
		}

		static IntPtr n_GetImageAsBitmap_Lcom_credenceid_database_ImageIndex_ (IntPtr jnienv, IntPtr native__this, IntPtr native_index)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.BiometricData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var index = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.ImageIndex> (native_index, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetImageAsBitmap (index));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getImageAsBitmap_Lcom_credenceid_database_ImageIndex_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/class[@name='BiometricData']/method[@name='getImageAsBitmap' and count(parameter)=1 and parameter[1][@type='com.credenceid.database.ImageIndex']]"
		[Register ("getImageAsBitmap", "(Lcom/credenceid/database/ImageIndex;)Landroid/graphics/Bitmap;", "GetGetImageAsBitmap_Lcom_credenceid_database_ImageIndex_Handler")]
		public virtual unsafe global::Android.Graphics.Bitmap GetImageAsBitmap (global::Com.Credenceid.Database.ImageIndex index)
		{
			if (id_getImageAsBitmap_Lcom_credenceid_database_ImageIndex_ == IntPtr.Zero)
				id_getImageAsBitmap_Lcom_credenceid_database_ImageIndex_ = JNIEnv.GetMethodID (class_ref, "getImageAsBitmap", "(Lcom/credenceid/database/ImageIndex;)Landroid/graphics/Bitmap;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (index);

				global::Android.Graphics.Bitmap __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getImageAsBitmap_Lcom_credenceid_database_ImageIndex_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImageAsBitmap", "(Lcom/credenceid/database/ImageIndex;)Landroid/graphics/Bitmap;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getTemplate_Lcom_credenceid_database_ImageIndex_;
#pragma warning disable 0169
		static Delegate GetGetTemplate_Lcom_credenceid_database_ImageIndex_Handler ()
		{
			if (cb_getTemplate_Lcom_credenceid_database_ImageIndex_ == null)
				cb_getTemplate_Lcom_credenceid_database_ImageIndex_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetTemplate_Lcom_credenceid_database_ImageIndex_);
			return cb_getTemplate_Lcom_credenceid_database_ImageIndex_;
		}

		static IntPtr n_GetTemplate_Lcom_credenceid_database_ImageIndex_ (IntPtr jnienv, IntPtr native__this, IntPtr native_index)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.BiometricData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var index = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.ImageIndex> (native_index, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetTemplate (index));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getTemplate_Lcom_credenceid_database_ImageIndex_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/class[@name='BiometricData']/method[@name='getTemplate' and count(parameter)=1 and parameter[1][@type='com.credenceid.database.ImageIndex']]"
		[Register ("getTemplate", "(Lcom/credenceid/database/ImageIndex;)[B", "GetGetTemplate_Lcom_credenceid_database_ImageIndex_Handler")]
		public virtual unsafe byte[] GetTemplate (global::Com.Credenceid.Database.ImageIndex index)
		{
			if (id_getTemplate_Lcom_credenceid_database_ImageIndex_ == IntPtr.Zero)
				id_getTemplate_Lcom_credenceid_database_ImageIndex_ = JNIEnv.GetMethodID (class_ref, "getTemplate", "(Lcom/credenceid/database/ImageIndex;)[B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (index);

				byte[] __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTemplate_Lcom_credenceid_database_ImageIndex_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTemplate", "(Lcom/credenceid/database/ImageIndex;)[B"), __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setImage_Lcom_credenceid_database_ImageIndex_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetSetImage_Lcom_credenceid_database_ImageIndex_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_setImage_Lcom_credenceid_database_ImageIndex_Landroid_graphics_Bitmap_ == null)
				cb_setImage_Lcom_credenceid_database_ImageIndex_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_Z) n_SetImage_Lcom_credenceid_database_ImageIndex_Landroid_graphics_Bitmap_);
			return cb_setImage_Lcom_credenceid_database_ImageIndex_Landroid_graphics_Bitmap_;
		}

		static bool n_SetImage_Lcom_credenceid_database_ImageIndex_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_index, IntPtr native_image)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.BiometricData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var index = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.ImageIndex> (native_index, JniHandleOwnership.DoNotTransfer);
			var image = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_image, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetImage (index, image);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setImage_Lcom_credenceid_database_ImageIndex_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/class[@name='BiometricData']/method[@name='setImage' and count(parameter)=2 and parameter[1][@type='com.credenceid.database.ImageIndex'] and parameter[2][@type='android.graphics.Bitmap']]"
		[Register ("setImage", "(Lcom/credenceid/database/ImageIndex;Landroid/graphics/Bitmap;)Z", "GetSetImage_Lcom_credenceid_database_ImageIndex_Landroid_graphics_Bitmap_Handler")]
		public virtual unsafe bool SetImage (global::Com.Credenceid.Database.ImageIndex index, global::Android.Graphics.Bitmap image)
		{
			if (id_setImage_Lcom_credenceid_database_ImageIndex_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_setImage_Lcom_credenceid_database_ImageIndex_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "setImage", "(Lcom/credenceid/database/ImageIndex;Landroid/graphics/Bitmap;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (index);
				__args [1] = new JValue (image);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_setImage_Lcom_credenceid_database_ImageIndex_Landroid_graphics_Bitmap_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setImage", "(Lcom/credenceid/database/ImageIndex;Landroid/graphics/Bitmap;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setImage_Lcom_credenceid_database_ImageIndex_arrayB;
#pragma warning disable 0169
		static Delegate GetSetImage_Lcom_credenceid_database_ImageIndex_arrayBHandler ()
		{
			if (cb_setImage_Lcom_credenceid_database_ImageIndex_arrayB == null)
				cb_setImage_Lcom_credenceid_database_ImageIndex_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_Z) n_SetImage_Lcom_credenceid_database_ImageIndex_arrayB);
			return cb_setImage_Lcom_credenceid_database_ImageIndex_arrayB;
		}

		static bool n_SetImage_Lcom_credenceid_database_ImageIndex_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_index, IntPtr native_image)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.BiometricData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var index = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.ImageIndex> (native_index, JniHandleOwnership.DoNotTransfer);
			var image = (byte[]) JNIEnv.GetArray (native_image, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.SetImage (index, image);
			if (image != null)
				JNIEnv.CopyArray (image, native_image);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setImage_Lcom_credenceid_database_ImageIndex_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/class[@name='BiometricData']/method[@name='setImage' and count(parameter)=2 and parameter[1][@type='com.credenceid.database.ImageIndex'] and parameter[2][@type='byte[]']]"
		[Register ("setImage", "(Lcom/credenceid/database/ImageIndex;[B)Z", "GetSetImage_Lcom_credenceid_database_ImageIndex_arrayBHandler")]
		public virtual unsafe bool SetImage (global::Com.Credenceid.Database.ImageIndex index, byte[] image)
		{
			if (id_setImage_Lcom_credenceid_database_ImageIndex_arrayB == IntPtr.Zero)
				id_setImage_Lcom_credenceid_database_ImageIndex_arrayB = JNIEnv.GetMethodID (class_ref, "setImage", "(Lcom/credenceid/database/ImageIndex;[B)Z");
			IntPtr native_image = JNIEnv.NewArray (image);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (index);
				__args [1] = new JValue (native_image);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_setImage_Lcom_credenceid_database_ImageIndex_arrayB, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setImage", "(Lcom/credenceid/database/ImageIndex;[B)Z"), __args);
				return __ret;
			} finally {
				if (image != null) {
					JNIEnv.CopyArray (native_image, image);
					JNIEnv.DeleteLocalRef (native_image);
				}
			}
		}

		static Delegate cb_setImage_Lcom_credenceid_database_ImageIndex_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetImage_Lcom_credenceid_database_ImageIndex_Ljava_lang_String_Handler ()
		{
			if (cb_setImage_Lcom_credenceid_database_ImageIndex_Ljava_lang_String_ == null)
				cb_setImage_Lcom_credenceid_database_ImageIndex_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_Z) n_SetImage_Lcom_credenceid_database_ImageIndex_Ljava_lang_String_);
			return cb_setImage_Lcom_credenceid_database_ImageIndex_Ljava_lang_String_;
		}

		static bool n_SetImage_Lcom_credenceid_database_ImageIndex_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_index, IntPtr native_imageAbsFilePath)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.BiometricData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var index = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.ImageIndex> (native_index, JniHandleOwnership.DoNotTransfer);
			var imageAbsFilePath = JNIEnv.GetString (native_imageAbsFilePath, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetImage (index, imageAbsFilePath);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setImage_Lcom_credenceid_database_ImageIndex_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/class[@name='BiometricData']/method[@name='setImage' and count(parameter)=2 and parameter[1][@type='com.credenceid.database.ImageIndex'] and parameter[2][@type='java.lang.String']]"
		[Register ("setImage", "(Lcom/credenceid/database/ImageIndex;Ljava/lang/String;)Z", "GetSetImage_Lcom_credenceid_database_ImageIndex_Ljava_lang_String_Handler")]
		public virtual unsafe bool SetImage (global::Com.Credenceid.Database.ImageIndex index, string imageAbsFilePath)
		{
			if (id_setImage_Lcom_credenceid_database_ImageIndex_Ljava_lang_String_ == IntPtr.Zero)
				id_setImage_Lcom_credenceid_database_ImageIndex_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setImage", "(Lcom/credenceid/database/ImageIndex;Ljava/lang/String;)Z");
			IntPtr native_imageAbsFilePath = JNIEnv.NewString (imageAbsFilePath);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (index);
				__args [1] = new JValue (native_imageAbsFilePath);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_setImage_Lcom_credenceid_database_ImageIndex_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setImage", "(Lcom/credenceid/database/ImageIndex;Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_imageAbsFilePath);
			}
		}

		static Delegate cb_setTemplate_Lcom_credenceid_database_ImageIndex_arrayB;
#pragma warning disable 0169
		static Delegate GetSetTemplate_Lcom_credenceid_database_ImageIndex_arrayBHandler ()
		{
			if (cb_setTemplate_Lcom_credenceid_database_ImageIndex_arrayB == null)
				cb_setTemplate_Lcom_credenceid_database_ImageIndex_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_Z) n_SetTemplate_Lcom_credenceid_database_ImageIndex_arrayB);
			return cb_setTemplate_Lcom_credenceid_database_ImageIndex_arrayB;
		}

		static bool n_SetTemplate_Lcom_credenceid_database_ImageIndex_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_index, IntPtr native_template)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.BiometricData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var index = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.ImageIndex> (native_index, JniHandleOwnership.DoNotTransfer);
			var template = (byte[]) JNIEnv.GetArray (native_template, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.SetTemplate (index, template);
			if (template != null)
				JNIEnv.CopyArray (template, native_template);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setTemplate_Lcom_credenceid_database_ImageIndex_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/class[@name='BiometricData']/method[@name='setTemplate' and count(parameter)=2 and parameter[1][@type='com.credenceid.database.ImageIndex'] and parameter[2][@type='byte[]']]"
		[Register ("setTemplate", "(Lcom/credenceid/database/ImageIndex;[B)Z", "GetSetTemplate_Lcom_credenceid_database_ImageIndex_arrayBHandler")]
		public virtual unsafe bool SetTemplate (global::Com.Credenceid.Database.ImageIndex index, byte[] template)
		{
			if (id_setTemplate_Lcom_credenceid_database_ImageIndex_arrayB == IntPtr.Zero)
				id_setTemplate_Lcom_credenceid_database_ImageIndex_arrayB = JNIEnv.GetMethodID (class_ref, "setTemplate", "(Lcom/credenceid/database/ImageIndex;[B)Z");
			IntPtr native_template = JNIEnv.NewArray (template);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (index);
				__args [1] = new JValue (native_template);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_setTemplate_Lcom_credenceid_database_ImageIndex_arrayB, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTemplate", "(Lcom/credenceid/database/ImageIndex;[B)Z"), __args);
				return __ret;
			} finally {
				if (template != null) {
					JNIEnv.CopyArray (native_template, template);
					JNIEnv.DeleteLocalRef (native_template);
				}
			}
		}

	}
}
