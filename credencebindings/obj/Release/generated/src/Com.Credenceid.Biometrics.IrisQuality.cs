using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Credenceid.Biometrics {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='IrisQuality']"
	[global::Android.Runtime.Register ("com/credenceid/biometrics/IrisQuality", DoNotGenerateAcw=true)]
	public partial class IrisQuality : global::Java.Lang.Object {


		static IntPtr grayLevelSpread_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='IrisQuality']/field[@name='grayLevelSpread']"
		[Register ("grayLevelSpread")]
		public int GrayLevelSpread {
			get {
				if (grayLevelSpread_jfieldId == IntPtr.Zero)
					grayLevelSpread_jfieldId = JNIEnv.GetFieldID (class_ref, "grayLevelSpread", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, grayLevelSpread_jfieldId);
			}
			set {
				if (grayLevelSpread_jfieldId == IntPtr.Zero)
					grayLevelSpread_jfieldId = JNIEnv.GetFieldID (class_ref, "grayLevelSpread", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, grayLevelSpread_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr interlace_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='IrisQuality']/field[@name='interlace']"
		[Register ("interlace")]
		public int Interlace {
			get {
				if (interlace_jfieldId == IntPtr.Zero)
					interlace_jfieldId = JNIEnv.GetFieldID (class_ref, "interlace", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, interlace_jfieldId);
			}
			set {
				if (interlace_jfieldId == IntPtr.Zero)
					interlace_jfieldId = JNIEnv.GetFieldID (class_ref, "interlace", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, interlace_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr irisPupilBoundaryShape_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='IrisQuality']/field[@name='irisPupilBoundaryShape']"
		[Register ("irisPupilBoundaryShape")]
		public int IrisPupilBoundaryShape {
			get {
				if (irisPupilBoundaryShape_jfieldId == IntPtr.Zero)
					irisPupilBoundaryShape_jfieldId = JNIEnv.GetFieldID (class_ref, "irisPupilBoundaryShape", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, irisPupilBoundaryShape_jfieldId);
			}
			set {
				if (irisPupilBoundaryShape_jfieldId == IntPtr.Zero)
					irisPupilBoundaryShape_jfieldId = JNIEnv.GetFieldID (class_ref, "irisPupilBoundaryShape", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, irisPupilBoundaryShape_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr irisPupilContrast_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='IrisQuality']/field[@name='irisPupilContrast']"
		[Register ("irisPupilContrast")]
		public int IrisPupilContrast {
			get {
				if (irisPupilContrast_jfieldId == IntPtr.Zero)
					irisPupilContrast_jfieldId = JNIEnv.GetFieldID (class_ref, "irisPupilContrast", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, irisPupilContrast_jfieldId);
			}
			set {
				if (irisPupilContrast_jfieldId == IntPtr.Zero)
					irisPupilContrast_jfieldId = JNIEnv.GetFieldID (class_ref, "irisPupilContrast", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, irisPupilContrast_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr irisScleraBoundaryShape_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='IrisQuality']/field[@name='irisScleraBoundaryShape']"
		[Register ("irisScleraBoundaryShape")]
		public int IrisScleraBoundaryShape {
			get {
				if (irisScleraBoundaryShape_jfieldId == IntPtr.Zero)
					irisScleraBoundaryShape_jfieldId = JNIEnv.GetFieldID (class_ref, "irisScleraBoundaryShape", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, irisScleraBoundaryShape_jfieldId);
			}
			set {
				if (irisScleraBoundaryShape_jfieldId == IntPtr.Zero)
					irisScleraBoundaryShape_jfieldId = JNIEnv.GetFieldID (class_ref, "irisScleraBoundaryShape", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, irisScleraBoundaryShape_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr irisScleraContrast_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='IrisQuality']/field[@name='irisScleraContrast']"
		[Register ("irisScleraContrast")]
		public int IrisScleraContrast {
			get {
				if (irisScleraContrast_jfieldId == IntPtr.Zero)
					irisScleraContrast_jfieldId = JNIEnv.GetFieldID (class_ref, "irisScleraContrast", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, irisScleraContrast_jfieldId);
			}
			set {
				if (irisScleraContrast_jfieldId == IntPtr.Zero)
					irisScleraContrast_jfieldId = JNIEnv.GetFieldID (class_ref, "irisScleraContrast", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, irisScleraContrast_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr irisSize_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='IrisQuality']/field[@name='irisSize']"
		[Register ("irisSize")]
		public int IrisSize {
			get {
				if (irisSize_jfieldId == IntPtr.Zero)
					irisSize_jfieldId = JNIEnv.GetFieldID (class_ref, "irisSize", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, irisSize_jfieldId);
			}
			set {
				if (irisSize_jfieldId == IntPtr.Zero)
					irisSize_jfieldId = JNIEnv.GetFieldID (class_ref, "irisSize", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, irisSize_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr margin_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='IrisQuality']/field[@name='margin']"
		[Register ("margin")]
		public int Margin {
			get {
				if (margin_jfieldId == IntPtr.Zero)
					margin_jfieldId = JNIEnv.GetFieldID (class_ref, "margin", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, margin_jfieldId);
			}
			set {
				if (margin_jfieldId == IntPtr.Zero)
					margin_jfieldId = JNIEnv.GetFieldID (class_ref, "margin", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, margin_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr pupilIrisRatio_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='IrisQuality']/field[@name='pupilIrisRatio']"
		[Register ("pupilIrisRatio")]
		public int PupilIrisRatio {
			get {
				if (pupilIrisRatio_jfieldId == IntPtr.Zero)
					pupilIrisRatio_jfieldId = JNIEnv.GetFieldID (class_ref, "pupilIrisRatio", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, pupilIrisRatio_jfieldId);
			}
			set {
				if (pupilIrisRatio_jfieldId == IntPtr.Zero)
					pupilIrisRatio_jfieldId = JNIEnv.GetFieldID (class_ref, "pupilIrisRatio", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, pupilIrisRatio_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr quality_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='IrisQuality']/field[@name='quality']"
		[Register ("quality")]
		public int Quality {
			get {
				if (quality_jfieldId == IntPtr.Zero)
					quality_jfieldId = JNIEnv.GetFieldID (class_ref, "quality", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, quality_jfieldId);
			}
			set {
				if (quality_jfieldId == IntPtr.Zero)
					quality_jfieldId = JNIEnv.GetFieldID (class_ref, "quality", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, quality_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr sharpness_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='IrisQuality']/field[@name='sharpness']"
		[Register ("sharpness")]
		public int Sharpness {
			get {
				if (sharpness_jfieldId == IntPtr.Zero)
					sharpness_jfieldId = JNIEnv.GetFieldID (class_ref, "sharpness", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, sharpness_jfieldId);
			}
			set {
				if (sharpness_jfieldId == IntPtr.Zero)
					sharpness_jfieldId = JNIEnv.GetFieldID (class_ref, "sharpness", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, sharpness_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr signalToNoiseRatio_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='IrisQuality']/field[@name='signalToNoiseRatio']"
		[Register ("signalToNoiseRatio")]
		public int SignalToNoiseRatio {
			get {
				if (signalToNoiseRatio_jfieldId == IntPtr.Zero)
					signalToNoiseRatio_jfieldId = JNIEnv.GetFieldID (class_ref, "signalToNoiseRatio", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, signalToNoiseRatio_jfieldId);
			}
			set {
				if (signalToNoiseRatio_jfieldId == IntPtr.Zero)
					signalToNoiseRatio_jfieldId = JNIEnv.GetFieldID (class_ref, "signalToNoiseRatio", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, signalToNoiseRatio_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr usableIrisArea_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='IrisQuality']/field[@name='usableIrisArea']"
		[Register ("usableIrisArea")]
		public int UsableIrisArea {
			get {
				if (usableIrisArea_jfieldId == IntPtr.Zero)
					usableIrisArea_jfieldId = JNIEnv.GetFieldID (class_ref, "usableIrisArea", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, usableIrisArea_jfieldId);
			}
			set {
				if (usableIrisArea_jfieldId == IntPtr.Zero)
					usableIrisArea_jfieldId = JNIEnv.GetFieldID (class_ref, "usableIrisArea", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, usableIrisArea_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/credenceid/biometrics/IrisQuality", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IrisQuality); }
		}

		protected IrisQuality (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='IrisQuality']/constructor[@name='IrisQuality' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe IrisQuality ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (IrisQuality)) {
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

		static IntPtr id_fromArray_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='IrisQuality']/method[@name='fromArray' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("fromArray", "([I)Lcom/credenceid/biometrics/IrisQuality;", "")]
		public static unsafe global::Com.Credenceid.Biometrics.IrisQuality FromArray (int[] a)
		{
			if (id_fromArray_arrayI == IntPtr.Zero)
				id_fromArray_arrayI = JNIEnv.GetStaticMethodID (class_ref, "fromArray", "([I)Lcom/credenceid/biometrics/IrisQuality;");
			IntPtr native_a = JNIEnv.NewArray (a);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_a);
				global::Com.Credenceid.Biometrics.IrisQuality __ret = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IrisQuality> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromArray_arrayI, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (a != null) {
					JNIEnv.CopyArray (native_a, a);
					JNIEnv.DeleteLocalRef (native_a);
				}
			}
		}

		static Delegate cb_toArray;
#pragma warning disable 0169
		static Delegate GetToArrayHandler ()
		{
			if (cb_toArray == null)
				cb_toArray = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToArray);
			return cb_toArray;
		}

		static IntPtr n_ToArray (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.IrisQuality> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ToArray ());
		}
#pragma warning restore 0169

		static IntPtr id_toArray;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.biometrics']/class[@name='IrisQuality']/method[@name='toArray' and count(parameter)=0]"
		[Register ("toArray", "()[I", "GetToArrayHandler")]
		public virtual unsafe int[] ToArray ()
		{
			if (id_toArray == IntPtr.Zero)
				id_toArray = JNIEnv.GetMethodID (class_ref, "toArray", "()[I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toArray), JniHandleOwnership.TransferLocalRef, typeof (int));
				else
					return (int[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toArray", "()[I")), JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

	}
}
