using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Credenceid.Icao {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.credenceid.icao']/class[@name='FingerInfo']"
	[global::Android.Runtime.Register ("com/credenceid/icao/FingerInfo", DoNotGenerateAcw=true)]
	public partial class FingerInfo : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/credenceid/icao/FingerInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FingerInfo); }
		}

		protected FingerInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.icao']/class[@name='FingerInfo']/constructor[@name='FingerInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FingerInfo ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (FingerInfo)) {
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

		static Delegate cb_getBitmap;
#pragma warning disable 0169
		static Delegate GetGetBitmapHandler ()
		{
			if (cb_getBitmap == null)
				cb_getBitmap = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetBitmap);
			return cb_getBitmap;
		}

		static IntPtr n_GetBitmap (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.FingerInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Bitmap);
		}
#pragma warning restore 0169

		static Delegate cb_setBitmap_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetSetBitmap_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_setBitmap_Landroid_graphics_Bitmap_ == null)
				cb_setBitmap_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetBitmap_Landroid_graphics_Bitmap_);
			return cb_setBitmap_Landroid_graphics_Bitmap_;
		}

		static void n_SetBitmap_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bitmap)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.FingerInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bitmap = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_bitmap, JniHandleOwnership.DoNotTransfer);
			__this.Bitmap = bitmap;
		}
#pragma warning restore 0169

		static IntPtr id_getBitmap;
		static IntPtr id_setBitmap_Landroid_graphics_Bitmap_;
		public virtual unsafe global::Android.Graphics.Bitmap Bitmap {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='FingerInfo']/method[@name='getBitmap' and count(parameter)=0]"
			[Register ("getBitmap", "()Landroid/graphics/Bitmap;", "GetGetBitmapHandler")]
			get {
				if (id_getBitmap == IntPtr.Zero)
					id_getBitmap = JNIEnv.GetMethodID (class_ref, "getBitmap", "()Landroid/graphics/Bitmap;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBitmap), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBitmap", "()Landroid/graphics/Bitmap;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='FingerInfo']/method[@name='setBitmap' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
			[Register ("setBitmap", "(Landroid/graphics/Bitmap;)V", "GetSetBitmap_Landroid_graphics_Bitmap_Handler")]
			set {
				if (id_setBitmap_Landroid_graphics_Bitmap_ == IntPtr.Zero)
					id_setBitmap_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "setBitmap", "(Landroid/graphics/Bitmap;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBitmap_Landroid_graphics_Bitmap_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBitmap", "(Landroid/graphics/Bitmap;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getImageHeight;
#pragma warning disable 0169
		static Delegate GetGetImageHeightHandler ()
		{
			if (cb_getImageHeight == null)
				cb_getImageHeight = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetImageHeight);
			return cb_getImageHeight;
		}

		static int n_GetImageHeight (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.FingerInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ImageHeight;
		}
#pragma warning restore 0169

		static IntPtr id_getImageHeight;
		public virtual unsafe int ImageHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='FingerInfo']/method[@name='getImageHeight' and count(parameter)=0]"
			[Register ("getImageHeight", "()I", "GetGetImageHeightHandler")]
			get {
				if (id_getImageHeight == IntPtr.Zero)
					id_getImageHeight = JNIEnv.GetMethodID (class_ref, "getImageHeight", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getImageHeight);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImageHeight", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getImageWidth;
#pragma warning disable 0169
		static Delegate GetGetImageWidthHandler ()
		{
			if (cb_getImageWidth == null)
				cb_getImageWidth = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetImageWidth);
			return cb_getImageWidth;
		}

		static int n_GetImageWidth (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.FingerInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ImageWidth;
		}
#pragma warning restore 0169

		static IntPtr id_getImageWidth;
		public virtual unsafe int ImageWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='FingerInfo']/method[@name='getImageWidth' and count(parameter)=0]"
			[Register ("getImageWidth", "()I", "GetGetImageWidthHandler")]
			get {
				if (id_getImageWidth == IntPtr.Zero)
					id_getImageWidth = JNIEnv.GetMethodID (class_ref, "getImageWidth", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getImageWidth);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImageWidth", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getPosition;
#pragma warning disable 0169
		static Delegate GetGetPositionHandler ()
		{
			if (cb_getPosition == null)
				cb_getPosition = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetPosition);
			return cb_getPosition;
		}

		static int n_GetPosition (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.FingerInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Position;
		}
#pragma warning restore 0169

		static Delegate cb_setPosition_I;
#pragma warning disable 0169
		static Delegate GetSetPosition_IHandler ()
		{
			if (cb_setPosition_I == null)
				cb_setPosition_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetPosition_I);
			return cb_setPosition_I;
		}

		static void n_SetPosition_I (IntPtr jnienv, IntPtr native__this, int val)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.FingerInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Position = val;
		}
#pragma warning restore 0169

		static IntPtr id_getPosition;
		static IntPtr id_setPosition_I;
		public virtual unsafe int Position {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='FingerInfo']/method[@name='getPosition' and count(parameter)=0]"
			[Register ("getPosition", "()I", "GetGetPositionHandler")]
			get {
				if (id_getPosition == IntPtr.Zero)
					id_getPosition = JNIEnv.GetMethodID (class_ref, "getPosition", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPosition);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPosition", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='FingerInfo']/method[@name='setPosition' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPosition", "(I)V", "GetSetPosition_IHandler")]
			set {
				if (id_setPosition_I == IntPtr.Zero)
					id_setPosition_I = JNIEnv.GetMethodID (class_ref, "setPosition", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPosition_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPosition", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getBytes;
#pragma warning disable 0169
		static Delegate GetGetBytesHandler ()
		{
			if (cb_getBytes == null)
				cb_getBytes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetBytes);
			return cb_getBytes;
		}

		static IntPtr n_GetBytes (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.FingerInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetBytes ());
		}
#pragma warning restore 0169

		static IntPtr id_getBytes;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='FingerInfo']/method[@name='getBytes' and count(parameter)=0]"
		[Register ("getBytes", "()[B", "GetGetBytesHandler")]
		public virtual unsafe byte[] GetBytes ()
		{
			if (id_getBytes == IntPtr.Zero)
				id_getBytes = JNIEnv.GetMethodID (class_ref, "getBytes", "()[B");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBytes), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBytes", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_setBytes_arrayB;
#pragma warning disable 0169
		static Delegate GetSetBytes_arrayBHandler ()
		{
			if (cb_setBytes_arrayB == null)
				cb_setBytes_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetBytes_arrayB);
			return cb_setBytes_arrayB;
		}

		static void n_SetBytes_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_bytes)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.FingerInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bytes = (byte[]) JNIEnv.GetArray (native_bytes, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetBytes (bytes);
			if (bytes != null)
				JNIEnv.CopyArray (bytes, native_bytes);
		}
#pragma warning restore 0169

		static IntPtr id_setBytes_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='FingerInfo']/method[@name='setBytes' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setBytes", "([B)V", "GetSetBytes_arrayBHandler")]
		public virtual unsafe void SetBytes (byte[] bytes)
		{
			if (id_setBytes_arrayB == IntPtr.Zero)
				id_setBytes_arrayB = JNIEnv.GetMethodID (class_ref, "setBytes", "([B)V");
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_bytes);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBytes_arrayB, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBytes", "([B)V"), __args);
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
			}
		}

		static Delegate cb_setHeight_I;
#pragma warning disable 0169
		static Delegate GetSetHeight_IHandler ()
		{
			if (cb_setHeight_I == null)
				cb_setHeight_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetHeight_I);
			return cb_setHeight_I;
		}

		static void n_SetHeight_I (IntPtr jnienv, IntPtr native__this, int height)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.FingerInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetHeight (height);
		}
#pragma warning restore 0169

		static IntPtr id_setHeight_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='FingerInfo']/method[@name='setHeight' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setHeight", "(I)V", "GetSetHeight_IHandler")]
		public virtual unsafe void SetHeight (int height)
		{
			if (id_setHeight_I == IntPtr.Zero)
				id_setHeight_I = JNIEnv.GetMethodID (class_ref, "setHeight", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (height);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHeight_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHeight", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setWidth_I;
#pragma warning disable 0169
		static Delegate GetSetWidth_IHandler ()
		{
			if (cb_setWidth_I == null)
				cb_setWidth_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetWidth_I);
			return cb_setWidth_I;
		}

		static void n_SetWidth_I (IntPtr jnienv, IntPtr native__this, int width)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Icao.FingerInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetWidth (width);
		}
#pragma warning restore 0169

		static IntPtr id_setWidth_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.icao']/class[@name='FingerInfo']/method[@name='setWidth' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setWidth", "(I)V", "GetSetWidth_IHandler")]
		public virtual unsafe void SetWidth (int width)
		{
			if (id_setWidth_I == IntPtr.Zero)
				id_setWidth_I = JNIEnv.GetMethodID (class_ref, "setWidth", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (width);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setWidth_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWidth", "(I)V"), __args);
			} finally {
			}
		}

	}
}
