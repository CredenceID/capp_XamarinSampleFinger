using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Credenceid.Face {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.credenceid.face']/class[@name='AnalyzeFaceSyncResponse']"
	[global::Android.Runtime.Register ("com/credenceid/face/AnalyzeFaceSyncResponse", DoNotGenerateAcw=true)]
	public partial class AnalyzeFaceSyncResponse : global::Java.Lang.Object {


		static IntPtr age_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.face']/class[@name='AnalyzeFaceSyncResponse']/field[@name='age']"
		[Register ("age")]
		public int Age {
			get {
				if (age_jfieldId == IntPtr.Zero)
					age_jfieldId = JNIEnv.GetFieldID (class_ref, "age", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, age_jfieldId);
			}
			set {
				if (age_jfieldId == IntPtr.Zero)
					age_jfieldId = JNIEnv.GetFieldID (class_ref, "age", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, age_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr dominantEmotion_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.face']/class[@name='AnalyzeFaceSyncResponse']/field[@name='dominantEmotion']"
		[Register ("dominantEmotion")]
		public global::Com.Credenceid.Face.FaceEngineEmotion DominantEmotion {
			get {
				if (dominantEmotion_jfieldId == IntPtr.Zero)
					dominantEmotion_jfieldId = JNIEnv.GetFieldID (class_ref, "dominantEmotion", "Lcom/credenceid/face/FaceEngine$Emotion;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, dominantEmotion_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.FaceEngineEmotion> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (dominantEmotion_jfieldId == IntPtr.Zero)
					dominantEmotion_jfieldId = JNIEnv.GetFieldID (class_ref, "dominantEmotion", "Lcom/credenceid/face/FaceEngine$Emotion;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, dominantEmotion_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr faceRect_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.face']/class[@name='AnalyzeFaceSyncResponse']/field[@name='faceRect']"
		[Register ("faceRect")]
		public global::Android.Graphics.RectF FaceRect {
			get {
				if (faceRect_jfieldId == IntPtr.Zero)
					faceRect_jfieldId = JNIEnv.GetFieldID (class_ref, "faceRect", "Landroid/graphics/RectF;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, faceRect_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (faceRect_jfieldId == IntPtr.Zero)
					faceRect_jfieldId = JNIEnv.GetFieldID (class_ref, "faceRect", "Landroid/graphics/RectF;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, faceRect_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr gender_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.face']/class[@name='AnalyzeFaceSyncResponse']/field[@name='gender']"
		[Register ("gender")]
		public global::Com.Credenceid.Face.FaceEngineGender Gender {
			get {
				if (gender_jfieldId == IntPtr.Zero)
					gender_jfieldId = JNIEnv.GetFieldID (class_ref, "gender", "Lcom/credenceid/face/FaceEngine$Gender;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, gender_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.FaceEngineGender> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (gender_jfieldId == IntPtr.Zero)
					gender_jfieldId = JNIEnv.GetFieldID (class_ref, "gender", "Lcom/credenceid/face/FaceEngine$Gender;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, gender_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr hasGlasses_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.face']/class[@name='AnalyzeFaceSyncResponse']/field[@name='hasGlasses']"
		[Register ("hasGlasses")]
		public bool HasGlasses {
			get {
				if (hasGlasses_jfieldId == IntPtr.Zero)
					hasGlasses_jfieldId = JNIEnv.GetFieldID (class_ref, "hasGlasses", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, hasGlasses_jfieldId);
			}
			set {
				if (hasGlasses_jfieldId == IntPtr.Zero)
					hasGlasses_jfieldId = JNIEnv.GetFieldID (class_ref, "hasGlasses", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, hasGlasses_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr headPoseDirections_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.face']/class[@name='AnalyzeFaceSyncResponse']/field[@name='headPoseDirections']"
		[Register ("headPoseDirections")]
		public IList<Com.Credenceid.Face.FaceEngineHeadPoseDirection> HeadPoseDirections {
			get {
				if (headPoseDirections_jfieldId == IntPtr.Zero)
					headPoseDirections_jfieldId = JNIEnv.GetFieldID (class_ref, "headPoseDirections", "[Lcom/credenceid/face/FaceEngine$HeadPoseDirection;");
				return global::Android.Runtime.JavaArray<global::Com.Credenceid.Face.FaceEngineHeadPoseDirection>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, headPoseDirections_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (headPoseDirections_jfieldId == IntPtr.Zero)
					headPoseDirections_jfieldId = JNIEnv.GetFieldID (class_ref, "headPoseDirections", "[Lcom/credenceid/face/FaceEngine$HeadPoseDirection;");
				IntPtr native_value = global::Android.Runtime.JavaArray<global::Com.Credenceid.Face.FaceEngineHeadPoseDirection>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, headPoseDirections_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr headPoseEstimations_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.face']/class[@name='AnalyzeFaceSyncResponse']/field[@name='headPoseEstimations']"
		[Register ("headPoseEstimations")]
		public IList<float> HeadPoseEstimations {
			get {
				if (headPoseEstimations_jfieldId == IntPtr.Zero)
					headPoseEstimations_jfieldId = JNIEnv.GetFieldID (class_ref, "headPoseEstimations", "[F");
				return global::Android.Runtime.JavaArray<float>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, headPoseEstimations_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (headPoseEstimations_jfieldId == IntPtr.Zero)
					headPoseEstimations_jfieldId = JNIEnv.GetFieldID (class_ref, "headPoseEstimations", "[F");
				IntPtr native_value = global::Android.Runtime.JavaArray<float>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, headPoseEstimations_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr imageQuality_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.face']/class[@name='AnalyzeFaceSyncResponse']/field[@name='imageQuality']"
		[Register ("imageQuality")]
		public int ImageQuality {
			get {
				if (imageQuality_jfieldId == IntPtr.Zero)
					imageQuality_jfieldId = JNIEnv.GetFieldID (class_ref, "imageQuality", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, imageQuality_jfieldId);
			}
			set {
				if (imageQuality_jfieldId == IntPtr.Zero)
					imageQuality_jfieldId = JNIEnv.GetFieldID (class_ref, "imageQuality", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, imageQuality_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr landmark5_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.face']/class[@name='AnalyzeFaceSyncResponse']/field[@name='landmark5']"
		[Register ("landmark5")]
		public global::System.Collections.IList Landmark5 {
			get {
				if (landmark5_jfieldId == IntPtr.Zero)
					landmark5_jfieldId = JNIEnv.GetFieldID (class_ref, "landmark5", "Ljava/util/ArrayList;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, landmark5_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (landmark5_jfieldId == IntPtr.Zero)
					landmark5_jfieldId = JNIEnv.GetFieldID (class_ref, "landmark5", "Ljava/util/ArrayList;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, landmark5_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr landmark68_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.face']/class[@name='AnalyzeFaceSyncResponse']/field[@name='landmark68']"
		[Register ("landmark68")]
		public global::System.Collections.IList Landmark68 {
			get {
				if (landmark68_jfieldId == IntPtr.Zero)
					landmark68_jfieldId = JNIEnv.GetFieldID (class_ref, "landmark68", "Ljava/util/ArrayList;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, landmark68_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (landmark68_jfieldId == IntPtr.Zero)
					landmark68_jfieldId = JNIEnv.GetFieldID (class_ref, "landmark68", "Ljava/util/ArrayList;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, landmark68_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr resultCode_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.face']/class[@name='AnalyzeFaceSyncResponse']/field[@name='resultCode']"
		[Register ("resultCode")]
		public global::Com.Credenceid.Biometrics.BiometricsResultCode ResultCode {
			get {
				if (resultCode_jfieldId == IntPtr.Zero)
					resultCode_jfieldId = JNIEnv.GetFieldID (class_ref, "resultCode", "Lcom/credenceid/biometrics/Biometrics$ResultCode;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, resultCode_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsResultCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (resultCode_jfieldId == IntPtr.Zero)
					resultCode_jfieldId = JNIEnv.GetFieldID (class_ref, "resultCode", "Lcom/credenceid/biometrics/Biometrics$ResultCode;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, resultCode_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/credenceid/face/AnalyzeFaceSyncResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AnalyzeFaceSyncResponse); }
		}

		protected AnalyzeFaceSyncResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_credenceid_biometrics_Biometrics_ResultCode_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.face']/class[@name='AnalyzeFaceSyncResponse']/constructor[@name='AnalyzeFaceSyncResponse' and count(parameter)=1 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ResultCode']]"
		[Register (".ctor", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;)V", "")]
		public unsafe AnalyzeFaceSyncResponse (global::Com.Credenceid.Biometrics.BiometricsResultCode resultCode)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (resultCode);
				if (((object) this).GetType () != typeof (AnalyzeFaceSyncResponse)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/credenceid/biometrics/Biometrics$ResultCode;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/credenceid/biometrics/Biometrics$ResultCode;)V", __args);
					return;
				}

				if (id_ctor_Lcom_credenceid_biometrics_Biometrics_ResultCode_ == IntPtr.Zero)
					id_ctor_Lcom_credenceid_biometrics_Biometrics_ResultCode_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_credenceid_biometrics_Biometrics_ResultCode_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_credenceid_biometrics_Biometrics_ResultCode_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_RectF_Ljava_util_ArrayList_Ljava_util_ArrayList_arrayFarrayLcom_credenceid_face_FaceEngine_HeadPoseDirection_Lcom_credenceid_face_FaceEngine_Gender_ILcom_credenceid_face_FaceEngine_Emotion_ZI;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.face']/class[@name='AnalyzeFaceSyncResponse']/constructor[@name='AnalyzeFaceSyncResponse' and count(parameter)=11 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ResultCode'] and parameter[2][@type='android.graphics.RectF'] and parameter[3][@type='java.util.ArrayList&lt;android.graphics.PointF&gt;'] and parameter[4][@type='java.util.ArrayList&lt;android.graphics.PointF&gt;'] and parameter[5][@type='float[]'] and parameter[6][@type='com.credenceid.face.FaceEngine.HeadPoseDirection[]'] and parameter[7][@type='com.credenceid.face.FaceEngine.Gender'] and parameter[8][@type='int'] and parameter[9][@type='com.credenceid.face.FaceEngine.Emotion'] and parameter[10][@type='boolean'] and parameter[11][@type='int']]"
		[Register (".ctor", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Landroid/graphics/RectF;Ljava/util/ArrayList;Ljava/util/ArrayList;[F[Lcom/credenceid/face/FaceEngine$HeadPoseDirection;Lcom/credenceid/face/FaceEngine$Gender;ILcom/credenceid/face/FaceEngine$Emotion;ZI)V", "")]
		public unsafe AnalyzeFaceSyncResponse (global::Com.Credenceid.Biometrics.BiometricsResultCode resultCode, global::Android.Graphics.RectF faceRect, global::System.Collections.Generic.IList<global::Android.Graphics.PointF> landmark5, global::System.Collections.Generic.IList<global::Android.Graphics.PointF> landmark68, float[] headPoseEstimations, global::Com.Credenceid.Face.FaceEngineHeadPoseDirection[] headPoseDirections, global::Com.Credenceid.Face.FaceEngineGender gender, int age, global::Com.Credenceid.Face.FaceEngineEmotion dominantEmotion, bool hasGlasses, int imageQuality)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_landmark5 = global::Android.Runtime.JavaList<global::Android.Graphics.PointF>.ToLocalJniHandle (landmark5);
			IntPtr native_landmark68 = global::Android.Runtime.JavaList<global::Android.Graphics.PointF>.ToLocalJniHandle (landmark68);
			IntPtr native_headPoseEstimations = JNIEnv.NewArray (headPoseEstimations);
			IntPtr native_headPoseDirections = JNIEnv.NewArray (headPoseDirections);
			try {
				JValue* __args = stackalloc JValue [11];
				__args [0] = new JValue (resultCode);
				__args [1] = new JValue (faceRect);
				__args [2] = new JValue (native_landmark5);
				__args [3] = new JValue (native_landmark68);
				__args [4] = new JValue (native_headPoseEstimations);
				__args [5] = new JValue (native_headPoseDirections);
				__args [6] = new JValue (gender);
				__args [7] = new JValue (age);
				__args [8] = new JValue (dominantEmotion);
				__args [9] = new JValue (hasGlasses);
				__args [10] = new JValue (imageQuality);
				if (((object) this).GetType () != typeof (AnalyzeFaceSyncResponse)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Landroid/graphics/RectF;Ljava/util/ArrayList;Ljava/util/ArrayList;[F[Lcom/credenceid/face/FaceEngine$HeadPoseDirection;Lcom/credenceid/face/FaceEngine$Gender;ILcom/credenceid/face/FaceEngine$Emotion;ZI)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Landroid/graphics/RectF;Ljava/util/ArrayList;Ljava/util/ArrayList;[F[Lcom/credenceid/face/FaceEngine$HeadPoseDirection;Lcom/credenceid/face/FaceEngine$Gender;ILcom/credenceid/face/FaceEngine$Emotion;ZI)V", __args);
					return;
				}

				if (id_ctor_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_RectF_Ljava_util_ArrayList_Ljava_util_ArrayList_arrayFarrayLcom_credenceid_face_FaceEngine_HeadPoseDirection_Lcom_credenceid_face_FaceEngine_Gender_ILcom_credenceid_face_FaceEngine_Emotion_ZI == IntPtr.Zero)
					id_ctor_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_RectF_Ljava_util_ArrayList_Ljava_util_ArrayList_arrayFarrayLcom_credenceid_face_FaceEngine_HeadPoseDirection_Lcom_credenceid_face_FaceEngine_Gender_ILcom_credenceid_face_FaceEngine_Emotion_ZI = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Landroid/graphics/RectF;Ljava/util/ArrayList;Ljava/util/ArrayList;[F[Lcom/credenceid/face/FaceEngine$HeadPoseDirection;Lcom/credenceid/face/FaceEngine$Gender;ILcom/credenceid/face/FaceEngine$Emotion;ZI)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_RectF_Ljava_util_ArrayList_Ljava_util_ArrayList_arrayFarrayLcom_credenceid_face_FaceEngine_HeadPoseDirection_Lcom_credenceid_face_FaceEngine_Gender_ILcom_credenceid_face_FaceEngine_Emotion_ZI, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_RectF_Ljava_util_ArrayList_Ljava_util_ArrayList_arrayFarrayLcom_credenceid_face_FaceEngine_HeadPoseDirection_Lcom_credenceid_face_FaceEngine_Gender_ILcom_credenceid_face_FaceEngine_Emotion_ZI, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_landmark5);
				JNIEnv.DeleteLocalRef (native_landmark68);
				if (headPoseEstimations != null) {
					JNIEnv.CopyArray (native_headPoseEstimations, headPoseEstimations);
					JNIEnv.DeleteLocalRef (native_headPoseEstimations);
				}
				if (headPoseDirections != null) {
					JNIEnv.CopyArray (native_headPoseDirections, headPoseDirections);
					JNIEnv.DeleteLocalRef (native_headPoseDirections);
				}
			}
		}

	}
}
