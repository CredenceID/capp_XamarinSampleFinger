using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.util']/class[@name='BitmapUtils']"
	[global::Android.Runtime.Register ("com/util/BitmapUtils", DoNotGenerateAcw=true)]
	public partial class BitmapUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/util/BitmapUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BitmapUtils); }
		}

		protected BitmapUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.util']/class[@name='BitmapUtils']/constructor[@name='BitmapUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BitmapUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BitmapUtils)) {
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

		static IntPtr id_cropToSquare_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.util']/class[@name='BitmapUtils']/method[@name='cropToSquare' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("cropToSquare", "(Landroid/graphics/Bitmap;)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap CropToSquare (global::Android.Graphics.Bitmap bitmap)
		{
			if (id_cropToSquare_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_cropToSquare_Landroid_graphics_Bitmap_ = JNIEnv.GetStaticMethodID (class_ref, "cropToSquare", "(Landroid/graphics/Bitmap;)Landroid/graphics/Bitmap;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (bitmap);
				global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_cropToSquare_Landroid_graphics_Bitmap_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_rotate_Landroid_graphics_Bitmap_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.util']/class[@name='BitmapUtils']/method[@name='rotate' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='int']]"
		[Register ("rotate", "(Landroid/graphics/Bitmap;I)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap Rotate (global::Android.Graphics.Bitmap bitmap, int angle)
		{
			if (id_rotate_Landroid_graphics_Bitmap_I == IntPtr.Zero)
				id_rotate_Landroid_graphics_Bitmap_I = JNIEnv.GetStaticMethodID (class_ref, "rotate", "(Landroid/graphics/Bitmap;I)Landroid/graphics/Bitmap;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (bitmap);
				__args [1] = new JValue (angle);
				global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_rotate_Landroid_graphics_Bitmap_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toBitmap_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.util']/class[@name='BitmapUtils']/method[@name='toBitmap' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("toBitmap", "([B)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap ToBitmap (byte[] data)
		{
			if (id_toBitmap_arrayB == IntPtr.Zero)
				id_toBitmap_arrayB = JNIEnv.GetStaticMethodID (class_ref, "toBitmap", "([B)Landroid/graphics/Bitmap;");
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_data);
				global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toBitmap_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

		static IntPtr id_toBytes_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.util']/class[@name='BitmapUtils']/method[@name='toBytes' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("toBytes", "(Landroid/graphics/Bitmap;)[B", "")]
		public static unsafe byte[] ToBytes (global::Android.Graphics.Bitmap bitmap)
		{
			if (id_toBytes_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_toBytes_Landroid_graphics_Bitmap_ = JNIEnv.GetStaticMethodID (class_ref, "toBytes", "(Landroid/graphics/Bitmap;)[B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (bitmap);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_toBytes_Landroid_graphics_Bitmap_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toGrayScale_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.util']/class[@name='BitmapUtils']/method[@name='toGrayScale' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("toGrayScale", "(Landroid/graphics/Bitmap;)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap ToGrayScale (global::Android.Graphics.Bitmap bitmap)
		{
			if (id_toGrayScale_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_toGrayScale_Landroid_graphics_Bitmap_ = JNIEnv.GetStaticMethodID (class_ref, "toGrayScale", "(Landroid/graphics/Bitmap;)Landroid/graphics/Bitmap;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (bitmap);
				global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toGrayScale_Landroid_graphics_Bitmap_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
