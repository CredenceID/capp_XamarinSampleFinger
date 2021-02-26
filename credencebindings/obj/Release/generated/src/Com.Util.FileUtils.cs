using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.util']/class[@name='FileUtils']"
	[global::Android.Runtime.Register ("com/util/FileUtils", DoNotGenerateAcw=true)]
	public partial class FileUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/util/FileUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FileUtils); }
		}

		protected FileUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.util']/class[@name='FileUtils']/constructor[@name='FileUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FileUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (FileUtils)) {
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

		static IntPtr id_delete_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.util']/class[@name='FileUtils']/method[@name='delete' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("delete", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool Delete (string absFilePath)
		{
			if (id_delete_Ljava_lang_String_ == IntPtr.Zero)
				id_delete_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "delete", "(Ljava/lang/String;)Z");
			IntPtr native_absFilePath = JNIEnv.NewString (absFilePath);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_absFilePath);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_delete_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_absFilePath);
			}
		}

		static IntPtr id_readBitmap_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.util']/class[@name='FileUtils']/method[@name='readBitmap' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("readBitmap", "(Ljava/lang/String;)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap ReadBitmap (string absFilePath)
		{
			if (id_readBitmap_Ljava_lang_String_ == IntPtr.Zero)
				id_readBitmap_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "readBitmap", "(Ljava/lang/String;)Landroid/graphics/Bitmap;");
			IntPtr native_absFilePath = JNIEnv.NewString (absFilePath);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_absFilePath);
				global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_readBitmap_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_absFilePath);
			}
		}

	}
}
