using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Credenceid.Face {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.credenceid.face']/class[@name='FaceView']"
	[global::Android.Runtime.Register ("com/credenceid/face/FaceView", DoNotGenerateAcw=true)]
	public partial class FaceView : global::Android.Widget.ImageView {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/credenceid/face/FaceView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FaceView); }
		}

		protected FaceView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.face']/class[@name='FaceView']/constructor[@name='FaceView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe FaceView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (context);
				__args [1] = new JValue (attrs);
				if (((object) this).GetType () != typeof (FaceView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args);
			} finally {
			}
		}

		static Delegate cb_clearFaceLandmarks;
#pragma warning disable 0169
		static Delegate GetClearFaceLandmarksHandler ()
		{
			if (cb_clearFaceLandmarks == null)
				cb_clearFaceLandmarks = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ClearFaceLandmarks);
			return cb_clearFaceLandmarks;
		}

		static void n_ClearFaceLandmarks (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.FaceView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearFaceLandmarks ();
		}
#pragma warning restore 0169

		static IntPtr id_clearFaceLandmarks;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.face']/class[@name='FaceView']/method[@name='clearFaceLandmarks' and count(parameter)=0]"
		[Register ("clearFaceLandmarks", "()V", "GetClearFaceLandmarksHandler")]
		public virtual unsafe void ClearFaceLandmarks ()
		{
			if (id_clearFaceLandmarks == IntPtr.Zero)
				id_clearFaceLandmarks = JNIEnv.GetMethodID (class_ref, "clearFaceLandmarks", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearFaceLandmarks);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearFaceLandmarks", "()V"));
			} finally {
			}
		}

		static Delegate cb_configureDrawPaint_Landroid_graphics_Paint_;
#pragma warning disable 0169
		static Delegate GetConfigureDrawPaint_Landroid_graphics_Paint_Handler ()
		{
			if (cb_configureDrawPaint_Landroid_graphics_Paint_ == null)
				cb_configureDrawPaint_Landroid_graphics_Paint_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ConfigureDrawPaint_Landroid_graphics_Paint_);
			return cb_configureDrawPaint_Landroid_graphics_Paint_;
		}

		static void n_ConfigureDrawPaint_Landroid_graphics_Paint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_paint)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.FaceView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var paint = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (native_paint, JniHandleOwnership.DoNotTransfer);
			__this.ConfigureDrawPaint (paint);
		}
#pragma warning restore 0169

		static IntPtr id_configureDrawPaint_Landroid_graphics_Paint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.face']/class[@name='FaceView']/method[@name='configureDrawPaint' and count(parameter)=1 and parameter[1][@type='android.graphics.Paint']]"
		[Register ("configureDrawPaint", "(Landroid/graphics/Paint;)V", "GetConfigureDrawPaint_Landroid_graphics_Paint_Handler")]
		public virtual unsafe void ConfigureDrawPaint (global::Android.Graphics.Paint paint)
		{
			if (id_configureDrawPaint_Landroid_graphics_Paint_ == IntPtr.Zero)
				id_configureDrawPaint_Landroid_graphics_Paint_ = JNIEnv.GetMethodID (class_ref, "configureDrawPaint", "(Landroid/graphics/Paint;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (paint);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_configureDrawPaint_Landroid_graphics_Paint_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "configureDrawPaint", "(Landroid/graphics/Paint;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_configureDrawPaint_ILandroid_graphics_Paint_Style_I;
#pragma warning disable 0169
		static Delegate GetConfigureDrawPaint_ILandroid_graphics_Paint_Style_IHandler ()
		{
			if (cb_configureDrawPaint_ILandroid_graphics_Paint_Style_I == null)
				cb_configureDrawPaint_ILandroid_graphics_Paint_Style_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPILI_V) n_ConfigureDrawPaint_ILandroid_graphics_Paint_Style_I);
			return cb_configureDrawPaint_ILandroid_graphics_Paint_Style_I;
		}

		static void n_ConfigureDrawPaint_ILandroid_graphics_Paint_Style_I (IntPtr jnienv, IntPtr native__this, int paintColor, IntPtr native_paintStyle, int strokeWidth)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.FaceView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var paintStyle = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint.Style> (native_paintStyle, JniHandleOwnership.DoNotTransfer);
			__this.ConfigureDrawPaint (paintColor, paintStyle, strokeWidth);
		}
#pragma warning restore 0169

		static IntPtr id_configureDrawPaint_ILandroid_graphics_Paint_Style_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.face']/class[@name='FaceView']/method[@name='configureDrawPaint' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='android.graphics.Paint.Style'] and parameter[3][@type='int']]"
		[Register ("configureDrawPaint", "(ILandroid/graphics/Paint$Style;I)V", "GetConfigureDrawPaint_ILandroid_graphics_Paint_Style_IHandler")]
		public virtual unsafe void ConfigureDrawPaint (int paintColor, global::Android.Graphics.Paint.Style paintStyle, int strokeWidth)
		{
			if (id_configureDrawPaint_ILandroid_graphics_Paint_Style_I == IntPtr.Zero)
				id_configureDrawPaint_ILandroid_graphics_Paint_Style_I = JNIEnv.GetMethodID (class_ref, "configureDrawPaint", "(ILandroid/graphics/Paint$Style;I)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (paintColor);
				__args [1] = new JValue (paintStyle);
				__args [2] = new JValue (strokeWidth);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_configureDrawPaint_ILandroid_graphics_Paint_Style_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "configureDrawPaint", "(ILandroid/graphics/Paint$Style;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_drawFaceData_Z;
#pragma warning disable 0169
		static Delegate GetDrawFaceData_ZHandler ()
		{
			if (cb_drawFaceData_Z == null)
				cb_drawFaceData_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_DrawFaceData_Z);
			return cb_drawFaceData_Z;
		}

		static void n_DrawFaceData_Z (IntPtr jnienv, IntPtr native__this, bool hasFace)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.FaceView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DrawFaceData (hasFace);
		}
#pragma warning restore 0169

		static IntPtr id_drawFaceData_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.face']/class[@name='FaceView']/method[@name='drawFaceData' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("drawFaceData", "(Z)V", "GetDrawFaceData_ZHandler")]
		public virtual unsafe void DrawFaceData (bool hasFace)
		{
			if (id_drawFaceData_Z == IntPtr.Zero)
				id_drawFaceData_Z = JNIEnv.GetMethodID (class_ref, "drawFaceData", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (hasFace);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_drawFaceData_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "drawFaceData", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onDraw_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetOnDraw_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_onDraw_Landroid_graphics_Canvas_ == null)
				cb_onDraw_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnDraw_Landroid_graphics_Canvas_);
			return cb_onDraw_Landroid_graphics_Canvas_;
		}

		static void n_OnDraw_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_canvas)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.FaceView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var canvas = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_canvas, JniHandleOwnership.DoNotTransfer);
			__this.OnDraw (canvas);
		}
#pragma warning restore 0169

		static IntPtr id_onDraw_Landroid_graphics_Canvas_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.face']/class[@name='FaceView']/method[@name='onDraw' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("onDraw", "(Landroid/graphics/Canvas;)V", "GetOnDraw_Landroid_graphics_Canvas_Handler")]
		public virtual unsafe void OnDraw (global::Android.Graphics.Canvas canvas)
		{
			if (id_onDraw_Landroid_graphics_Canvas_ == IntPtr.Zero)
				id_onDraw_Landroid_graphics_Canvas_ = JNIEnv.GetMethodID (class_ref, "onDraw", "(Landroid/graphics/Canvas;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (canvas);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDraw_Landroid_graphics_Canvas_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDraw", "(Landroid/graphics/Canvas;)V"), __args);
			} finally {
			}
		}

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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.FaceView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bitmap = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_bitmap, JniHandleOwnership.DoNotTransfer);
			__this.SetBitmap (bitmap);
		}
#pragma warning restore 0169

		static IntPtr id_setBitmap_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.face']/class[@name='FaceView']/method[@name='setBitmap' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("setBitmap", "(Landroid/graphics/Bitmap;)V", "GetSetBitmap_Landroid_graphics_Bitmap_Handler")]
		public virtual unsafe void SetBitmap (global::Android.Graphics.Bitmap bitmap)
		{
			if (id_setBitmap_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_setBitmap_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "setBitmap", "(Landroid/graphics/Bitmap;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (bitmap);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBitmap_Landroid_graphics_Bitmap_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBitmap", "(Landroid/graphics/Bitmap;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setFaceLandmarks_arrayFarrayF;
#pragma warning disable 0169
		static Delegate GetSetFaceLandmarks_arrayFarrayFHandler ()
		{
			if (cb_setFaceLandmarks_arrayFarrayF == null)
				cb_setFaceLandmarks_arrayFarrayF = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_Z) n_SetFaceLandmarks_arrayFarrayF);
			return cb_setFaceLandmarks_arrayFarrayF;
		}

		static bool n_SetFaceLandmarks_arrayFarrayF (IntPtr jnienv, IntPtr native__this, IntPtr native_x, IntPtr native_y)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.FaceView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var x = (float[]) JNIEnv.GetArray (native_x, JniHandleOwnership.DoNotTransfer, typeof (float));
			var y = (float[]) JNIEnv.GetArray (native_y, JniHandleOwnership.DoNotTransfer, typeof (float));
			bool __ret = __this.SetFaceLandmarks (x, y);
			if (x != null)
				JNIEnv.CopyArray (x, native_x);
			if (y != null)
				JNIEnv.CopyArray (y, native_y);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setFaceLandmarks_arrayFarrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.face']/class[@name='FaceView']/method[@name='setFaceLandmarks' and count(parameter)=2 and parameter[1][@type='float[]'] and parameter[2][@type='float[]']]"
		[Register ("setFaceLandmarks", "([F[F)Z", "GetSetFaceLandmarks_arrayFarrayFHandler")]
		public virtual unsafe bool SetFaceLandmarks (float[] x, float[] y)
		{
			if (id_setFaceLandmarks_arrayFarrayF == IntPtr.Zero)
				id_setFaceLandmarks_arrayFarrayF = JNIEnv.GetMethodID (class_ref, "setFaceLandmarks", "([F[F)Z");
			IntPtr native_x = JNIEnv.NewArray (x);
			IntPtr native_y = JNIEnv.NewArray (y);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_x);
				__args [1] = new JValue (native_y);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_setFaceLandmarks_arrayFarrayF, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFaceLandmarks", "([F[F)Z"), __args);
				return __ret;
			} finally {
				if (x != null) {
					JNIEnv.CopyArray (native_x, x);
					JNIEnv.DeleteLocalRef (native_x);
				}
				if (y != null) {
					JNIEnv.CopyArray (native_y, y);
					JNIEnv.DeleteLocalRef (native_y);
				}
			}
		}

		static Delegate cb_setFaceLandmarks_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetSetFaceLandmarks_Ljava_util_ArrayList_Handler ()
		{
			if (cb_setFaceLandmarks_Ljava_util_ArrayList_ == null)
				cb_setFaceLandmarks_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_SetFaceLandmarks_Ljava_util_ArrayList_);
			return cb_setFaceLandmarks_Ljava_util_ArrayList_;
		}

		static bool n_SetFaceLandmarks_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_landmarks)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.FaceView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var landmarks = global::Android.Runtime.JavaList<global::Android.Graphics.PointF>.FromJniHandle (native_landmarks, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetFaceLandmarks (landmarks);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setFaceLandmarks_Ljava_util_ArrayList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.face']/class[@name='FaceView']/method[@name='setFaceLandmarks' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;android.graphics.PointF&gt;']]"
		[Register ("setFaceLandmarks", "(Ljava/util/ArrayList;)Z", "GetSetFaceLandmarks_Ljava_util_ArrayList_Handler")]
		public virtual unsafe bool SetFaceLandmarks (global::System.Collections.Generic.IList<global::Android.Graphics.PointF> landmarks)
		{
			if (id_setFaceLandmarks_Ljava_util_ArrayList_ == IntPtr.Zero)
				id_setFaceLandmarks_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "setFaceLandmarks", "(Ljava/util/ArrayList;)Z");
			IntPtr native_landmarks = global::Android.Runtime.JavaList<global::Android.Graphics.PointF>.ToLocalJniHandle (landmarks);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_landmarks);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_setFaceLandmarks_Ljava_util_ArrayList_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFaceLandmarks", "(Ljava/util/ArrayList;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_landmarks);
			}
		}

		static Delegate cb_setFaceRect_IIII;
#pragma warning disable 0169
		static Delegate GetSetFaceRect_IIIIHandler ()
		{
			if (cb_setFaceRect_IIII == null)
				cb_setFaceRect_IIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIII_V) n_SetFaceRect_IIII);
			return cb_setFaceRect_IIII;
		}

		static void n_SetFaceRect_IIII (IntPtr jnienv, IntPtr native__this, int left, int top, int right, int bottom)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.FaceView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetFaceRect (left, top, right, bottom);
		}
#pragma warning restore 0169

		static IntPtr id_setFaceRect_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.face']/class[@name='FaceView']/method[@name='setFaceRect' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("setFaceRect", "(IIII)V", "GetSetFaceRect_IIIIHandler")]
		public virtual unsafe void SetFaceRect (int left, int top, int right, int bottom)
		{
			if (id_setFaceRect_IIII == IntPtr.Zero)
				id_setFaceRect_IIII = JNIEnv.GetMethodID (class_ref, "setFaceRect", "(IIII)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (left);
				__args [1] = new JValue (top);
				__args [2] = new JValue (right);
				__args [3] = new JValue (bottom);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFaceRect_IIII, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFaceRect", "(IIII)V"), __args);
			} finally {
			}
		}

	}
}
