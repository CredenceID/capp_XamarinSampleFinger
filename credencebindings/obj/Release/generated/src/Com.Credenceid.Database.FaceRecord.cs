using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Credenceid.Database {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.credenceid.database']/class[@name='FaceRecord']"
	[global::Android.Runtime.Register ("com/credenceid/database/FaceRecord", DoNotGenerateAcw=true)]
	public partial class FaceRecord : global::Com.Credenceid.Database.BiometricData, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.database']/class[@name='FaceRecord']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/credenceid/database/FaceRecord", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FaceRecord); }
		}

		protected FaceRecord (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.database']/class[@name='FaceRecord']/constructor[@name='FaceRecord' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FaceRecord ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (FaceRecord)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.database']/class[@name='FaceRecord']/constructor[@name='FaceRecord' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register (".ctor", "(Landroid/graphics/Bitmap;)V", "")]
		public unsafe FaceRecord (global::Android.Graphics.Bitmap imageOne)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (imageOne);
				if (((object) this).GetType () != typeof (FaceRecord)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.database']/class[@name='FaceRecord']/constructor[@name='FaceRecord' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='android.graphics.Bitmap']]"
		[Register (".ctor", "(Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;)V", "")]
		public unsafe FaceRecord (global::Android.Graphics.Bitmap imageOne, global::Android.Graphics.Bitmap imageTwo)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (imageOne);
				__args [1] = new JValue (imageTwo);
				if (((object) this).GetType () != typeof (FaceRecord)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.database']/class[@name='FaceRecord']/constructor[@name='FaceRecord' and count(parameter)=3 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='android.graphics.Bitmap'] and parameter[3][@type='android.graphics.Bitmap']]"
		[Register (".ctor", "(Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;)V", "")]
		public unsafe FaceRecord (global::Android.Graphics.Bitmap imageOne, global::Android.Graphics.Bitmap imageTwo, global::Android.Graphics.Bitmap imageThree)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (imageOne);
				__args [1] = new JValue (imageTwo);
				__args [2] = new JValue (imageThree);
				if (((object) this).GetType () != typeof (FaceRecord)) {
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

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.database']/class[@name='FaceRecord']/constructor[@name='FaceRecord' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		public unsafe FaceRecord (global::Android.OS.Parcel parcel)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (parcel);
				if (((object) this).GetType () != typeof (FaceRecord)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/os/Parcel;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/os/Parcel;)V", __args);
					return;
				}

				if (id_ctor_Landroid_os_Parcel_ == IntPtr.Zero)
					id_ctor_Landroid_os_Parcel_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Parcel;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Parcel_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_os_Parcel_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.database']/class[@name='FaceRecord']/constructor[@name='FaceRecord' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public unsafe FaceRecord (byte[] imageOne)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_imageOne = JNIEnv.NewArray (imageOne);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_imageOne);
				if (((object) this).GetType () != typeof (FaceRecord)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.database']/class[@name='FaceRecord']/constructor[@name='FaceRecord' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register (".ctor", "([B[B)V", "")]
		public unsafe FaceRecord (byte[] imageOne, byte[] imageTwo)
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
				if (((object) this).GetType () != typeof (FaceRecord)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.database']/class[@name='FaceRecord']/constructor[@name='FaceRecord' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
		[Register (".ctor", "([B[B[B)V", "")]
		public unsafe FaceRecord (byte[] imageOne, byte[] imageTwo, byte[] imageThree)
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
				if (((object) this).GetType () != typeof (FaceRecord)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.database']/class[@name='FaceRecord']/constructor[@name='FaceRecord' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe FaceRecord (string imageOneAbsPath)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_imageOneAbsPath = JNIEnv.NewString (imageOneAbsPath);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_imageOneAbsPath);
				if (((object) this).GetType () != typeof (FaceRecord)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.database']/class[@name='FaceRecord']/constructor[@name='FaceRecord' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe FaceRecord (string imageOneAbsPath, string imageTwoAbsPath)
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
				if (((object) this).GetType () != typeof (FaceRecord)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.database']/class[@name='FaceRecord']/constructor[@name='FaceRecord' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe FaceRecord (string imageOneAbsPath, string imageTwoAbsPath, string imageThreeAbsPath)
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
				if (((object) this).GetType () != typeof (FaceRecord)) {
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.FaceRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/class[@name='FaceRecord']/method[@name='describeContents' and count(parameter)=0]"
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

		static Delegate cb_getTemplate;
#pragma warning disable 0169
		static Delegate GetGetTemplateHandler ()
		{
			if (cb_getTemplate == null)
				cb_getTemplate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTemplate);
			return cb_getTemplate;
		}

		static IntPtr n_GetTemplate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.FaceRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetTemplate ());
		}
#pragma warning restore 0169

		static IntPtr id_getTemplate;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/class[@name='FaceRecord']/method[@name='getTemplate' and count(parameter)=0]"
		[Register ("getTemplate", "()[B", "GetGetTemplateHandler")]
		public virtual unsafe byte[] GetTemplate ()
		{
			if (id_getTemplate == IntPtr.Zero)
				id_getTemplate = JNIEnv.GetMethodID (class_ref, "getTemplate", "()[B");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTemplate), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTemplate", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_setTemplate_arrayB;
#pragma warning disable 0169
		static Delegate GetSetTemplate_arrayBHandler ()
		{
			if (cb_setTemplate_arrayB == null)
				cb_setTemplate_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetTemplate_arrayB);
			return cb_setTemplate_arrayB;
		}

		static void n_SetTemplate_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_template)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.FaceRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var template = (byte[]) JNIEnv.GetArray (native_template, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetTemplate (template);
			if (template != null)
				JNIEnv.CopyArray (template, native_template);
		}
#pragma warning restore 0169

		static IntPtr id_setTemplate_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/class[@name='FaceRecord']/method[@name='setTemplate' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setTemplate", "([B)V", "GetSetTemplate_arrayBHandler")]
		public virtual unsafe void SetTemplate (byte[] template)
		{
			if (id_setTemplate_arrayB == IntPtr.Zero)
				id_setTemplate_arrayB = JNIEnv.GetMethodID (class_ref, "setTemplate", "([B)V");
			IntPtr native_template = JNIEnv.NewArray (template);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_template);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTemplate_arrayB, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTemplate", "([B)V"), __args);
			} finally {
				if (template != null) {
					JNIEnv.CopyArray (native_template, template);
					JNIEnv.DeleteLocalRef (native_template);
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

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_parcel, int native_size)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.FaceRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var parcel = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_parcel, JniHandleOwnership.DoNotTransfer);
			var size = (global::Android.OS.ParcelableWriteFlags) native_size;
			__this.WriteToParcel (parcel, size);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/class[@name='FaceRecord']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe void WriteToParcel (global::Android.OS.Parcel parcel, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags size)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (parcel);
				__args [1] = new JValue ((int) size);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeToParcel", "(Landroid/os/Parcel;I)V"), __args);
			} finally {
			}
		}

	}
}
