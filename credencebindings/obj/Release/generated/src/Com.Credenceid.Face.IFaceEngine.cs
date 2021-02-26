using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Credenceid.Face {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.credenceid.face']/class[@name='FaceEngine.Emotion']"
	[global::Android.Runtime.Register ("com/credenceid/face/FaceEngine$Emotion", DoNotGenerateAcw=true)]
	public sealed partial class FaceEngineEmotion : global::Java.Lang.Enum {


		static IntPtr ANGER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.face']/class[@name='FaceEngine.Emotion']/field[@name='ANGER']"
		[Register ("ANGER")]
		public static global::Com.Credenceid.Face.FaceEngineEmotion Anger {
			get {
				if (ANGER_jfieldId == IntPtr.Zero)
					ANGER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ANGER", "Lcom/credenceid/face/FaceEngine$Emotion;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ANGER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.FaceEngineEmotion> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr DISGUST_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.face']/class[@name='FaceEngine.Emotion']/field[@name='DISGUST']"
		[Register ("DISGUST")]
		public static global::Com.Credenceid.Face.FaceEngineEmotion Disgust {
			get {
				if (DISGUST_jfieldId == IntPtr.Zero)
					DISGUST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DISGUST", "Lcom/credenceid/face/FaceEngine$Emotion;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DISGUST_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.FaceEngineEmotion> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr FEAR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.face']/class[@name='FaceEngine.Emotion']/field[@name='FEAR']"
		[Register ("FEAR")]
		public static global::Com.Credenceid.Face.FaceEngineEmotion Fear {
			get {
				if (FEAR_jfieldId == IntPtr.Zero)
					FEAR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FEAR", "Lcom/credenceid/face/FaceEngine$Emotion;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FEAR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.FaceEngineEmotion> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr HAPPY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.face']/class[@name='FaceEngine.Emotion']/field[@name='HAPPY']"
		[Register ("HAPPY")]
		public static global::Com.Credenceid.Face.FaceEngineEmotion Happy {
			get {
				if (HAPPY_jfieldId == IntPtr.Zero)
					HAPPY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HAPPY", "Lcom/credenceid/face/FaceEngine$Emotion;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HAPPY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.FaceEngineEmotion> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NEUTRAL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.face']/class[@name='FaceEngine.Emotion']/field[@name='NEUTRAL']"
		[Register ("NEUTRAL")]
		public static global::Com.Credenceid.Face.FaceEngineEmotion Neutral {
			get {
				if (NEUTRAL_jfieldId == IntPtr.Zero)
					NEUTRAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NEUTRAL", "Lcom/credenceid/face/FaceEngine$Emotion;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NEUTRAL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.FaceEngineEmotion> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SAD_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.face']/class[@name='FaceEngine.Emotion']/field[@name='SAD']"
		[Register ("SAD")]
		public static global::Com.Credenceid.Face.FaceEngineEmotion Sad {
			get {
				if (SAD_jfieldId == IntPtr.Zero)
					SAD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SAD", "Lcom/credenceid/face/FaceEngine$Emotion;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SAD_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.FaceEngineEmotion> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SURPRISED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.face']/class[@name='FaceEngine.Emotion']/field[@name='SURPRISED']"
		[Register ("SURPRISED")]
		public static global::Com.Credenceid.Face.FaceEngineEmotion Surprised {
			get {
				if (SURPRISED_jfieldId == IntPtr.Zero)
					SURPRISED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SURPRISED", "Lcom/credenceid/face/FaceEngine$Emotion;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SURPRISED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.FaceEngineEmotion> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UNKNOWN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.face']/class[@name='FaceEngine.Emotion']/field[@name='UNKNOWN']"
		[Register ("UNKNOWN")]
		public static global::Com.Credenceid.Face.FaceEngineEmotion Unknown {
			get {
				if (UNKNOWN_jfieldId == IntPtr.Zero)
					UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN", "Lcom/credenceid/face/FaceEngine$Emotion;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNKNOWN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.FaceEngineEmotion> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/credenceid/face/FaceEngine$Emotion", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FaceEngineEmotion); }
		}

		internal FaceEngineEmotion (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getValue;
		public unsafe int Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.face']/class[@name='FaceEngine.Emotion']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()I", "")]
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getValue);
				} finally {
				}
			}
		}

		static IntPtr id_valueOf_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.face']/class[@name='FaceEngine.Emotion']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("valueOf", "(I)Lcom/credenceid/face/FaceEngine$Emotion;", "")]
		public static unsafe global::Com.Credenceid.Face.FaceEngineEmotion ValueOf (int value)
		{
			if (id_valueOf_I == IntPtr.Zero)
				id_valueOf_I = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(I)Lcom/credenceid/face/FaceEngine$Emotion;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.FaceEngineEmotion> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.face']/class[@name='FaceEngine.Emotion']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/credenceid/face/FaceEngine$Emotion;", "")]
		public static unsafe global::Com.Credenceid.Face.FaceEngineEmotion ValueOf (string name)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/credenceid/face/FaceEngine$Emotion;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::Com.Credenceid.Face.FaceEngineEmotion __ret = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.FaceEngineEmotion> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.face']/class[@name='FaceEngine.Emotion']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/credenceid/face/FaceEngine$Emotion;", "")]
		public static unsafe global::Com.Credenceid.Face.FaceEngineEmotion[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/credenceid/face/FaceEngine$Emotion;");
			try {
				return (global::Com.Credenceid.Face.FaceEngineEmotion[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Credenceid.Face.FaceEngineEmotion));
			} finally {
			}
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='com.credenceid.face']/class[@name='FaceEngine.Gender']"
	[global::Android.Runtime.Register ("com/credenceid/face/FaceEngine$Gender", DoNotGenerateAcw=true)]
	public sealed partial class FaceEngineGender : global::Java.Lang.Enum {


		static IntPtr FEMALE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.face']/class[@name='FaceEngine.Gender']/field[@name='FEMALE']"
		[Register ("FEMALE")]
		public static global::Com.Credenceid.Face.FaceEngineGender Female {
			get {
				if (FEMALE_jfieldId == IntPtr.Zero)
					FEMALE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FEMALE", "Lcom/credenceid/face/FaceEngine$Gender;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FEMALE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.FaceEngineGender> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr MALE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.face']/class[@name='FaceEngine.Gender']/field[@name='MALE']"
		[Register ("MALE")]
		public static global::Com.Credenceid.Face.FaceEngineGender Male {
			get {
				if (MALE_jfieldId == IntPtr.Zero)
					MALE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MALE", "Lcom/credenceid/face/FaceEngine$Gender;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MALE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.FaceEngineGender> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UNKNOWN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.face']/class[@name='FaceEngine.Gender']/field[@name='UNKNOWN']"
		[Register ("UNKNOWN")]
		public static global::Com.Credenceid.Face.FaceEngineGender Unknown {
			get {
				if (UNKNOWN_jfieldId == IntPtr.Zero)
					UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN", "Lcom/credenceid/face/FaceEngine$Gender;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNKNOWN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.FaceEngineGender> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/credenceid/face/FaceEngine$Gender", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FaceEngineGender); }
		}

		internal FaceEngineGender (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getValue;
		public unsafe int Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.face']/class[@name='FaceEngine.Gender']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()I", "")]
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getValue);
				} finally {
				}
			}
		}

		static IntPtr id_valueOf_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.face']/class[@name='FaceEngine.Gender']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("valueOf", "(I)Lcom/credenceid/face/FaceEngine$Gender;", "")]
		public static unsafe global::Com.Credenceid.Face.FaceEngineGender ValueOf (int value)
		{
			if (id_valueOf_I == IntPtr.Zero)
				id_valueOf_I = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(I)Lcom/credenceid/face/FaceEngine$Gender;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.FaceEngineGender> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.face']/class[@name='FaceEngine.Gender']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/credenceid/face/FaceEngine$Gender;", "")]
		public static unsafe global::Com.Credenceid.Face.FaceEngineGender ValueOf (string name)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/credenceid/face/FaceEngine$Gender;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::Com.Credenceid.Face.FaceEngineGender __ret = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.FaceEngineGender> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.face']/class[@name='FaceEngine.Gender']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/credenceid/face/FaceEngine$Gender;", "")]
		public static unsafe global::Com.Credenceid.Face.FaceEngineGender[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/credenceid/face/FaceEngine$Gender;");
			try {
				return (global::Com.Credenceid.Face.FaceEngineGender[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Credenceid.Face.FaceEngineGender));
			} finally {
			}
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='com.credenceid.face']/class[@name='FaceEngine.HeadPoseDirection']"
	[global::Android.Runtime.Register ("com/credenceid/face/FaceEngine$HeadPoseDirection", DoNotGenerateAcw=true)]
	public sealed partial class FaceEngineHeadPoseDirection : global::Java.Lang.Enum {


		static IntPtr DOWN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.face']/class[@name='FaceEngine.HeadPoseDirection']/field[@name='DOWN']"
		[Register ("DOWN")]
		public static global::Com.Credenceid.Face.FaceEngineHeadPoseDirection Down {
			get {
				if (DOWN_jfieldId == IntPtr.Zero)
					DOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DOWN", "Lcom/credenceid/face/FaceEngine$HeadPoseDirection;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DOWN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.FaceEngineHeadPoseDirection> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr LEFT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.face']/class[@name='FaceEngine.HeadPoseDirection']/field[@name='LEFT']"
		[Register ("LEFT")]
		public static global::Com.Credenceid.Face.FaceEngineHeadPoseDirection Left {
			get {
				if (LEFT_jfieldId == IntPtr.Zero)
					LEFT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LEFT", "Lcom/credenceid/face/FaceEngine$HeadPoseDirection;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LEFT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.FaceEngineHeadPoseDirection> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr RIGHT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.face']/class[@name='FaceEngine.HeadPoseDirection']/field[@name='RIGHT']"
		[Register ("RIGHT")]
		public static global::Com.Credenceid.Face.FaceEngineHeadPoseDirection Right {
			get {
				if (RIGHT_jfieldId == IntPtr.Zero)
					RIGHT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RIGHT", "Lcom/credenceid/face/FaceEngine$HeadPoseDirection;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RIGHT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.FaceEngineHeadPoseDirection> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr STRAIGHT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.face']/class[@name='FaceEngine.HeadPoseDirection']/field[@name='STRAIGHT']"
		[Register ("STRAIGHT")]
		public static global::Com.Credenceid.Face.FaceEngineHeadPoseDirection Straight {
			get {
				if (STRAIGHT_jfieldId == IntPtr.Zero)
					STRAIGHT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STRAIGHT", "Lcom/credenceid/face/FaceEngine$HeadPoseDirection;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STRAIGHT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.FaceEngineHeadPoseDirection> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TILT_LEFT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.face']/class[@name='FaceEngine.HeadPoseDirection']/field[@name='TILT_LEFT']"
		[Register ("TILT_LEFT")]
		public static global::Com.Credenceid.Face.FaceEngineHeadPoseDirection TiltLeft {
			get {
				if (TILT_LEFT_jfieldId == IntPtr.Zero)
					TILT_LEFT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TILT_LEFT", "Lcom/credenceid/face/FaceEngine$HeadPoseDirection;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TILT_LEFT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.FaceEngineHeadPoseDirection> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TILT_RIGHT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.face']/class[@name='FaceEngine.HeadPoseDirection']/field[@name='TILT_RIGHT']"
		[Register ("TILT_RIGHT")]
		public static global::Com.Credenceid.Face.FaceEngineHeadPoseDirection TiltRight {
			get {
				if (TILT_RIGHT_jfieldId == IntPtr.Zero)
					TILT_RIGHT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TILT_RIGHT", "Lcom/credenceid/face/FaceEngine$HeadPoseDirection;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TILT_RIGHT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.FaceEngineHeadPoseDirection> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UNKNOWN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.face']/class[@name='FaceEngine.HeadPoseDirection']/field[@name='UNKNOWN']"
		[Register ("UNKNOWN")]
		public static global::Com.Credenceid.Face.FaceEngineHeadPoseDirection Unknown {
			get {
				if (UNKNOWN_jfieldId == IntPtr.Zero)
					UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN", "Lcom/credenceid/face/FaceEngine$HeadPoseDirection;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNKNOWN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.FaceEngineHeadPoseDirection> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UP_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.face']/class[@name='FaceEngine.HeadPoseDirection']/field[@name='UP']"
		[Register ("UP")]
		public static global::Com.Credenceid.Face.FaceEngineHeadPoseDirection Up {
			get {
				if (UP_jfieldId == IntPtr.Zero)
					UP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UP", "Lcom/credenceid/face/FaceEngine$HeadPoseDirection;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UP_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.FaceEngineHeadPoseDirection> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/credenceid/face/FaceEngine$HeadPoseDirection", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FaceEngineHeadPoseDirection); }
		}

		internal FaceEngineHeadPoseDirection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getValue;
		public unsafe int Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.face']/class[@name='FaceEngine.HeadPoseDirection']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()I", "")]
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getValue);
				} finally {
				}
			}
		}

		static IntPtr id_valueOf_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.face']/class[@name='FaceEngine.HeadPoseDirection']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("valueOf", "(I)Lcom/credenceid/face/FaceEngine$HeadPoseDirection;", "")]
		public static unsafe global::Com.Credenceid.Face.FaceEngineHeadPoseDirection ValueOf (int value)
		{
			if (id_valueOf_I == IntPtr.Zero)
				id_valueOf_I = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(I)Lcom/credenceid/face/FaceEngine$HeadPoseDirection;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.FaceEngineHeadPoseDirection> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.face']/class[@name='FaceEngine.HeadPoseDirection']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/credenceid/face/FaceEngine$HeadPoseDirection;", "")]
		public static unsafe global::Com.Credenceid.Face.FaceEngineHeadPoseDirection ValueOf (string name)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/credenceid/face/FaceEngine$HeadPoseDirection;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::Com.Credenceid.Face.FaceEngineHeadPoseDirection __ret = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.FaceEngineHeadPoseDirection> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.face']/class[@name='FaceEngine.HeadPoseDirection']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/credenceid/face/FaceEngine$HeadPoseDirection;", "")]
		public static unsafe global::Com.Credenceid.Face.FaceEngineHeadPoseDirection[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/credenceid/face/FaceEngine$HeadPoseDirection;");
			try {
				return (global::Com.Credenceid.Face.FaceEngineHeadPoseDirection[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Credenceid.Face.FaceEngineHeadPoseDirection));
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.credenceid.face']/interface[@name='FaceEngine.OnAnalyzeFaceImageListener']"
	[Register ("com/credenceid/face/FaceEngine$OnAnalyzeFaceImageListener", "", "Com.Credenceid.Face.IFaceEngineOnAnalyzeFaceImageListenerInvoker")]
	public partial interface IFaceEngineOnAnalyzeFaceImageListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.face']/interface[@name='FaceEngine.OnAnalyzeFaceImageListener']/method[@name='onFaceAnalyzed' and count(parameter)=11 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ResultCode'] and parameter[2][@type='android.graphics.RectF'] and parameter[3][@type='java.util.ArrayList&lt;android.graphics.PointF&gt;'] and parameter[4][@type='java.util.ArrayList&lt;android.graphics.PointF&gt;'] and parameter[5][@type='float[]'] and parameter[6][@type='com.credenceid.face.FaceEngine.HeadPoseDirection[]'] and parameter[7][@type='com.credenceid.face.FaceEngine.Gender'] and parameter[8][@type='int'] and parameter[9][@type='com.credenceid.face.FaceEngine.Emotion'] and parameter[10][@type='boolean'] and parameter[11][@type='int']]"
		[Register ("onFaceAnalyzed", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Landroid/graphics/RectF;Ljava/util/ArrayList;Ljava/util/ArrayList;[F[Lcom/credenceid/face/FaceEngine$HeadPoseDirection;Lcom/credenceid/face/FaceEngine$Gender;ILcom/credenceid/face/FaceEngine$Emotion;ZI)V", "GetOnFaceAnalyzed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_RectF_Ljava_util_ArrayList_Ljava_util_ArrayList_arrayFarrayLcom_credenceid_face_FaceEngine_HeadPoseDirection_Lcom_credenceid_face_FaceEngine_Gender_ILcom_credenceid_face_FaceEngine_Emotion_ZIHandler:Com.Credenceid.Face.IFaceEngineOnAnalyzeFaceImageListenerInvoker, CredenceBindings")]
		void OnFaceAnalyzed (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Android.Graphics.RectF p1, global::System.Collections.Generic.IList<global::Android.Graphics.PointF> p2, global::System.Collections.Generic.IList<global::Android.Graphics.PointF> p3, float[] p4, global::Com.Credenceid.Face.FaceEngineHeadPoseDirection[] p5, global::Com.Credenceid.Face.FaceEngineGender p6, int p7, global::Com.Credenceid.Face.FaceEngineEmotion p8, bool p9, int p10);

	}

	[global::Android.Runtime.Register ("com/credenceid/face/FaceEngine$OnAnalyzeFaceImageListener", DoNotGenerateAcw=true)]
	internal partial class IFaceEngineOnAnalyzeFaceImageListenerInvoker : global::Java.Lang.Object, IFaceEngineOnAnalyzeFaceImageListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/credenceid/face/FaceEngine$OnAnalyzeFaceImageListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IFaceEngineOnAnalyzeFaceImageListenerInvoker); }
		}

		IntPtr class_ref;

		public static IFaceEngineOnAnalyzeFaceImageListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFaceEngineOnAnalyzeFaceImageListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.credenceid.face.FaceEngine.OnAnalyzeFaceImageListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFaceEngineOnAnalyzeFaceImageListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onFaceAnalyzed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_RectF_Ljava_util_ArrayList_Ljava_util_ArrayList_arrayFarrayLcom_credenceid_face_FaceEngine_HeadPoseDirection_Lcom_credenceid_face_FaceEngine_Gender_ILcom_credenceid_face_FaceEngine_Emotion_ZI;
#pragma warning disable 0169
		static Delegate GetOnFaceAnalyzed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_RectF_Ljava_util_ArrayList_Ljava_util_ArrayList_arrayFarrayLcom_credenceid_face_FaceEngine_HeadPoseDirection_Lcom_credenceid_face_FaceEngine_Gender_ILcom_credenceid_face_FaceEngine_Emotion_ZIHandler ()
		{
			if (cb_onFaceAnalyzed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_RectF_Ljava_util_ArrayList_Ljava_util_ArrayList_arrayFarrayLcom_credenceid_face_FaceEngine_HeadPoseDirection_Lcom_credenceid_face_FaceEngine_Gender_ILcom_credenceid_face_FaceEngine_Emotion_ZI == null)
				cb_onFaceAnalyzed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_RectF_Ljava_util_ArrayList_Ljava_util_ArrayList_arrayFarrayLcom_credenceid_face_FaceEngine_HeadPoseDirection_Lcom_credenceid_face_FaceEngine_Gender_ILcom_credenceid_face_FaceEngine_Emotion_ZI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLLLLILZI_V) n_OnFaceAnalyzed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_RectF_Ljava_util_ArrayList_Ljava_util_ArrayList_arrayFarrayLcom_credenceid_face_FaceEngine_HeadPoseDirection_Lcom_credenceid_face_FaceEngine_Gender_ILcom_credenceid_face_FaceEngine_Emotion_ZI);
			return cb_onFaceAnalyzed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_RectF_Ljava_util_ArrayList_Ljava_util_ArrayList_arrayFarrayLcom_credenceid_face_FaceEngine_HeadPoseDirection_Lcom_credenceid_face_FaceEngine_Gender_ILcom_credenceid_face_FaceEngine_Emotion_ZI;
		}

		static void n_OnFaceAnalyzed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_RectF_Ljava_util_ArrayList_Ljava_util_ArrayList_arrayFarrayLcom_credenceid_face_FaceEngine_HeadPoseDirection_Lcom_credenceid_face_FaceEngine_Gender_ILcom_credenceid_face_FaceEngine_Emotion_ZI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5, IntPtr native_p6, int p7, IntPtr native_p8, bool p9, int p10)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.IFaceEngineOnAnalyzeFaceImageListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsResultCode> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaList<global::Android.Graphics.PointF>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Android.Runtime.JavaList<global::Android.Graphics.PointF>.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
			var p4 = (float[]) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (float));
			var p5 = (global::Com.Credenceid.Face.FaceEngineHeadPoseDirection[]) JNIEnv.GetArray (native_p5, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Credenceid.Face.FaceEngineHeadPoseDirection));
			var p6 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.FaceEngineGender> (native_p6, JniHandleOwnership.DoNotTransfer);
			var p8 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.FaceEngineEmotion> (native_p8, JniHandleOwnership.DoNotTransfer);
			__this.OnFaceAnalyzed (p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10);
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
			if (p5 != null)
				JNIEnv.CopyArray (p5, native_p5);
		}
#pragma warning restore 0169

		IntPtr id_onFaceAnalyzed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_RectF_Ljava_util_ArrayList_Ljava_util_ArrayList_arrayFarrayLcom_credenceid_face_FaceEngine_HeadPoseDirection_Lcom_credenceid_face_FaceEngine_Gender_ILcom_credenceid_face_FaceEngine_Emotion_ZI;
		public unsafe void OnFaceAnalyzed (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Android.Graphics.RectF p1, global::System.Collections.Generic.IList<global::Android.Graphics.PointF> p2, global::System.Collections.Generic.IList<global::Android.Graphics.PointF> p3, float[] p4, global::Com.Credenceid.Face.FaceEngineHeadPoseDirection[] p5, global::Com.Credenceid.Face.FaceEngineGender p6, int p7, global::Com.Credenceid.Face.FaceEngineEmotion p8, bool p9, int p10)
		{
			if (id_onFaceAnalyzed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_RectF_Ljava_util_ArrayList_Ljava_util_ArrayList_arrayFarrayLcom_credenceid_face_FaceEngine_HeadPoseDirection_Lcom_credenceid_face_FaceEngine_Gender_ILcom_credenceid_face_FaceEngine_Emotion_ZI == IntPtr.Zero)
				id_onFaceAnalyzed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_RectF_Ljava_util_ArrayList_Ljava_util_ArrayList_arrayFarrayLcom_credenceid_face_FaceEngine_HeadPoseDirection_Lcom_credenceid_face_FaceEngine_Gender_ILcom_credenceid_face_FaceEngine_Emotion_ZI = JNIEnv.GetMethodID (class_ref, "onFaceAnalyzed", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Landroid/graphics/RectF;Ljava/util/ArrayList;Ljava/util/ArrayList;[F[Lcom/credenceid/face/FaceEngine$HeadPoseDirection;Lcom/credenceid/face/FaceEngine$Gender;ILcom/credenceid/face/FaceEngine$Emotion;ZI)V");
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::Android.Graphics.PointF>.ToLocalJniHandle (p2);
			IntPtr native_p3 = global::Android.Runtime.JavaList<global::Android.Graphics.PointF>.ToLocalJniHandle (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			IntPtr native_p5 = JNIEnv.NewArray (p5);
			JValue* __args = stackalloc JValue [11];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (native_p4);
			__args [5] = new JValue (native_p5);
			__args [6] = new JValue (p6);
			__args [7] = new JValue (p7);
			__args [8] = new JValue (p8);
			__args [9] = new JValue (p9);
			__args [10] = new JValue (p10);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFaceAnalyzed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_RectF_Ljava_util_ArrayList_Ljava_util_ArrayList_arrayFarrayLcom_credenceid_face_FaceEngine_HeadPoseDirection_Lcom_credenceid_face_FaceEngine_Gender_ILcom_credenceid_face_FaceEngine_Emotion_ZI, __args);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
			if (p4 != null) {
				JNIEnv.CopyArray (native_p4, p4);
				JNIEnv.DeleteLocalRef (native_p4);
			}
			if (p5 != null) {
				JNIEnv.CopyArray (native_p5, p5);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

	}

	// event args for com.credenceid.face.FaceEngine.OnAnalyzeFaceImageListener.onFaceAnalyzed
	public partial class FaceEngineOnAnalyzeFaceImageEventArgs : global::System.EventArgs {

		public FaceEngineOnAnalyzeFaceImageEventArgs (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Android.Graphics.RectF p1, global::System.Collections.Generic.IList<global::Android.Graphics.PointF> p2, global::System.Collections.Generic.IList<global::Android.Graphics.PointF> p3, float[] p4, global::Com.Credenceid.Face.FaceEngineHeadPoseDirection[] p5, global::Com.Credenceid.Face.FaceEngineGender p6, int p7, global::Com.Credenceid.Face.FaceEngineEmotion p8, bool p9, int p10)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
			this.p4 = p4;
			this.p5 = p5;
			this.p6 = p6;
			this.p7 = p7;
			this.p8 = p8;
			this.p9 = p9;
			this.p10 = p10;
		}

		global::Com.Credenceid.Biometrics.BiometricsResultCode p0;
		public global::Com.Credenceid.Biometrics.BiometricsResultCode P0 {
			get { return p0; }
		}

		global::Android.Graphics.RectF p1;
		public global::Android.Graphics.RectF P1 {
			get { return p1; }
		}

		global::System.Collections.Generic.IList<global::Android.Graphics.PointF> p2;
		public global::System.Collections.Generic.IList<global::Android.Graphics.PointF> P2 {
			get { return p2; }
		}

		global::System.Collections.Generic.IList<global::Android.Graphics.PointF> p3;
		public global::System.Collections.Generic.IList<global::Android.Graphics.PointF> P3 {
			get { return p3; }
		}

		float[] p4;
		public float[] P4 {
			get { return p4; }
		}

		global::Com.Credenceid.Face.FaceEngineHeadPoseDirection[] p5;
		public global::Com.Credenceid.Face.FaceEngineHeadPoseDirection[] P5 {
			get { return p5; }
		}

		global::Com.Credenceid.Face.FaceEngineGender p6;
		public global::Com.Credenceid.Face.FaceEngineGender P6 {
			get { return p6; }
		}

		int p7;
		public int P7 {
			get { return p7; }
		}

		global::Com.Credenceid.Face.FaceEngineEmotion p8;
		public global::Com.Credenceid.Face.FaceEngineEmotion P8 {
			get { return p8; }
		}

		bool p9;
		public bool P9 {
			get { return p9; }
		}

		int p10;
		public int P10 {
			get { return p10; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/credenceid/face/FaceEngine_OnAnalyzeFaceImageListenerImplementor")]
	internal sealed partial class IFaceEngineOnAnalyzeFaceImageListenerImplementor : global::Java.Lang.Object, IFaceEngineOnAnalyzeFaceImageListener {

		object sender;

		public IFaceEngineOnAnalyzeFaceImageListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/credenceid/face/FaceEngine_OnAnalyzeFaceImageListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<FaceEngineOnAnalyzeFaceImageEventArgs> Handler;
#pragma warning restore 0649

		public void OnFaceAnalyzed (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Android.Graphics.RectF p1, global::System.Collections.Generic.IList<global::Android.Graphics.PointF> p2, global::System.Collections.Generic.IList<global::Android.Graphics.PointF> p3, float[] p4, global::Com.Credenceid.Face.FaceEngineHeadPoseDirection[] p5, global::Com.Credenceid.Face.FaceEngineGender p6, int p7, global::Com.Credenceid.Face.FaceEngineEmotion p8, bool p9, int p10)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new FaceEngineOnAnalyzeFaceImageEventArgs (p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10));
		}

		internal static bool __IsEmpty (IFaceEngineOnAnalyzeFaceImageListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.credenceid.face']/interface[@name='FaceEngine.OnCreateFaceTemplateListener']"
	[Register ("com/credenceid/face/FaceEngine$OnCreateFaceTemplateListener", "", "Com.Credenceid.Face.IFaceEngineOnCreateFaceTemplateListenerInvoker")]
	public partial interface IFaceEngineOnCreateFaceTemplateListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.face']/interface[@name='FaceEngine.OnCreateFaceTemplateListener']/method[@name='onCreateFaceTemplate' and count(parameter)=2 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ResultCode'] and parameter[2][@type='byte[]']]"
		[Register ("onCreateFaceTemplate", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;[B)V", "GetOnCreateFaceTemplate_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayBHandler:Com.Credenceid.Face.IFaceEngineOnCreateFaceTemplateListenerInvoker, CredenceBindings")]
		void OnCreateFaceTemplate (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, byte[] p1);

	}

	[global::Android.Runtime.Register ("com/credenceid/face/FaceEngine$OnCreateFaceTemplateListener", DoNotGenerateAcw=true)]
	internal partial class IFaceEngineOnCreateFaceTemplateListenerInvoker : global::Java.Lang.Object, IFaceEngineOnCreateFaceTemplateListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/credenceid/face/FaceEngine$OnCreateFaceTemplateListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IFaceEngineOnCreateFaceTemplateListenerInvoker); }
		}

		IntPtr class_ref;

		public static IFaceEngineOnCreateFaceTemplateListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFaceEngineOnCreateFaceTemplateListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.credenceid.face.FaceEngine.OnCreateFaceTemplateListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFaceEngineOnCreateFaceTemplateListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onCreateFaceTemplate_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayB;
#pragma warning disable 0169
		static Delegate GetOnCreateFaceTemplate_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayBHandler ()
		{
			if (cb_onCreateFaceTemplate_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayB == null)
				cb_onCreateFaceTemplate_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnCreateFaceTemplate_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayB);
			return cb_onCreateFaceTemplate_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayB;
		}

		static void n_OnCreateFaceTemplate_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.IFaceEngineOnCreateFaceTemplateListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsResultCode> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnCreateFaceTemplate (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		IntPtr id_onCreateFaceTemplate_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayB;
		public unsafe void OnCreateFaceTemplate (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, byte[] p1)
		{
			if (id_onCreateFaceTemplate_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayB == IntPtr.Zero)
				id_onCreateFaceTemplate_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayB = JNIEnv.GetMethodID (class_ref, "onCreateFaceTemplate", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;[B)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCreateFaceTemplate_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayB, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}

	// event args for com.credenceid.face.FaceEngine.OnCreateFaceTemplateListener.onCreateFaceTemplate
	public partial class FaceEngineOnCreateFaceTemplateEventArgs : global::System.EventArgs {

		public FaceEngineOnCreateFaceTemplateEventArgs (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, byte[] p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Credenceid.Biometrics.BiometricsResultCode p0;
		public global::Com.Credenceid.Biometrics.BiometricsResultCode P0 {
			get { return p0; }
		}

		byte[] p1;
		public byte[] P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/credenceid/face/FaceEngine_OnCreateFaceTemplateListenerImplementor")]
	internal sealed partial class IFaceEngineOnCreateFaceTemplateListenerImplementor : global::Java.Lang.Object, IFaceEngineOnCreateFaceTemplateListener {

		object sender;

		public IFaceEngineOnCreateFaceTemplateListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/credenceid/face/FaceEngine_OnCreateFaceTemplateListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<FaceEngineOnCreateFaceTemplateEventArgs> Handler;
#pragma warning restore 0649

		public void OnCreateFaceTemplate (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, byte[] p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new FaceEngineOnCreateFaceTemplateEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IFaceEngineOnCreateFaceTemplateListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.credenceid.face']/interface[@name='FaceEngine.OnDetectFaceListener']"
	[Register ("com/credenceid/face/FaceEngine$OnDetectFaceListener", "", "Com.Credenceid.Face.IFaceEngineOnDetectFaceListenerInvoker")]
	public partial interface IFaceEngineOnDetectFaceListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.face']/interface[@name='FaceEngine.OnDetectFaceListener']/method[@name='onDetectFace' and count(parameter)=2 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ResultCode'] and parameter[2][@type='android.graphics.RectF']]"
		[Register ("onDetectFace", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Landroid/graphics/RectF;)V", "GetOnDetectFace_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_RectF_Handler:Com.Credenceid.Face.IFaceEngineOnDetectFaceListenerInvoker, CredenceBindings")]
		void OnDetectFace (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Android.Graphics.RectF p1);

	}

	[global::Android.Runtime.Register ("com/credenceid/face/FaceEngine$OnDetectFaceListener", DoNotGenerateAcw=true)]
	internal partial class IFaceEngineOnDetectFaceListenerInvoker : global::Java.Lang.Object, IFaceEngineOnDetectFaceListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/credenceid/face/FaceEngine$OnDetectFaceListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IFaceEngineOnDetectFaceListenerInvoker); }
		}

		IntPtr class_ref;

		public static IFaceEngineOnDetectFaceListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFaceEngineOnDetectFaceListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.credenceid.face.FaceEngine.OnDetectFaceListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFaceEngineOnDetectFaceListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onDetectFace_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_RectF_;
#pragma warning disable 0169
		static Delegate GetOnDetectFace_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_RectF_Handler ()
		{
			if (cb_onDetectFace_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_RectF_ == null)
				cb_onDetectFace_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_RectF_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnDetectFace_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_RectF_);
			return cb_onDetectFace_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_RectF_;
		}

		static void n_OnDetectFace_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_RectF_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.IFaceEngineOnDetectFaceListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsResultCode> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnDetectFace (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onDetectFace_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_RectF_;
		public unsafe void OnDetectFace (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Android.Graphics.RectF p1)
		{
			if (id_onDetectFace_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_RectF_ == IntPtr.Zero)
				id_onDetectFace_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_RectF_ = JNIEnv.GetMethodID (class_ref, "onDetectFace", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;Landroid/graphics/RectF;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDetectFace_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_RectF_, __args);
		}

	}

	// event args for com.credenceid.face.FaceEngine.OnDetectFaceListener.onDetectFace
	public partial class FaceEngineOnDetectFaceEventArgs : global::System.EventArgs {

		public FaceEngineOnDetectFaceEventArgs (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Android.Graphics.RectF p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Credenceid.Biometrics.BiometricsResultCode p0;
		public global::Com.Credenceid.Biometrics.BiometricsResultCode P0 {
			get { return p0; }
		}

		global::Android.Graphics.RectF p1;
		public global::Android.Graphics.RectF P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/credenceid/face/FaceEngine_OnDetectFaceListenerImplementor")]
	internal sealed partial class IFaceEngineOnDetectFaceListenerImplementor : global::Java.Lang.Object, IFaceEngineOnDetectFaceListener {

		object sender;

		public IFaceEngineOnDetectFaceListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/credenceid/face/FaceEngine_OnDetectFaceListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<FaceEngineOnDetectFaceEventArgs> Handler;
#pragma warning restore 0649

		public void OnDetectFace (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, global::Android.Graphics.RectF p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new FaceEngineOnDetectFaceEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IFaceEngineOnDetectFaceListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.credenceid.face']/interface[@name='FaceEngine.OnMatchFaceTemplatesListener']"
	[Register ("com/credenceid/face/FaceEngine$OnMatchFaceTemplatesListener", "", "Com.Credenceid.Face.IFaceEngineOnMatchFaceTemplatesListenerInvoker")]
	public partial interface IFaceEngineOnMatchFaceTemplatesListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.face']/interface[@name='FaceEngine.OnMatchFaceTemplatesListener']/method[@name='onMatchFaceTemplates' and count(parameter)=2 and parameter[1][@type='com.credenceid.biometrics.Biometrics.ResultCode'] and parameter[2][@type='int']]"
		[Register ("onMatchFaceTemplates", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;I)V", "GetOnMatchFaceTemplates_Lcom_credenceid_biometrics_Biometrics_ResultCode_IHandler:Com.Credenceid.Face.IFaceEngineOnMatchFaceTemplatesListenerInvoker, CredenceBindings")]
		void OnMatchFaceTemplates (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, int p1);

	}

	[global::Android.Runtime.Register ("com/credenceid/face/FaceEngine$OnMatchFaceTemplatesListener", DoNotGenerateAcw=true)]
	internal partial class IFaceEngineOnMatchFaceTemplatesListenerInvoker : global::Java.Lang.Object, IFaceEngineOnMatchFaceTemplatesListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/credenceid/face/FaceEngine$OnMatchFaceTemplatesListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IFaceEngineOnMatchFaceTemplatesListenerInvoker); }
		}

		IntPtr class_ref;

		public static IFaceEngineOnMatchFaceTemplatesListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFaceEngineOnMatchFaceTemplatesListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.credenceid.face.FaceEngine.OnMatchFaceTemplatesListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFaceEngineOnMatchFaceTemplatesListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onMatchFaceTemplates_Lcom_credenceid_biometrics_Biometrics_ResultCode_I;
#pragma warning disable 0169
		static Delegate GetOnMatchFaceTemplates_Lcom_credenceid_biometrics_Biometrics_ResultCode_IHandler ()
		{
			if (cb_onMatchFaceTemplates_Lcom_credenceid_biometrics_Biometrics_ResultCode_I == null)
				cb_onMatchFaceTemplates_Lcom_credenceid_biometrics_Biometrics_ResultCode_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_OnMatchFaceTemplates_Lcom_credenceid_biometrics_Biometrics_ResultCode_I);
			return cb_onMatchFaceTemplates_Lcom_credenceid_biometrics_Biometrics_ResultCode_I;
		}

		static void n_OnMatchFaceTemplates_Lcom_credenceid_biometrics_Biometrics_ResultCode_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.IFaceEngineOnMatchFaceTemplatesListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Biometrics.BiometricsResultCode> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnMatchFaceTemplates (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onMatchFaceTemplates_Lcom_credenceid_biometrics_Biometrics_ResultCode_I;
		public unsafe void OnMatchFaceTemplates (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, int p1)
		{
			if (id_onMatchFaceTemplates_Lcom_credenceid_biometrics_Biometrics_ResultCode_I == IntPtr.Zero)
				id_onMatchFaceTemplates_Lcom_credenceid_biometrics_Biometrics_ResultCode_I = JNIEnv.GetMethodID (class_ref, "onMatchFaceTemplates", "(Lcom/credenceid/biometrics/Biometrics$ResultCode;I)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMatchFaceTemplates_Lcom_credenceid_biometrics_Biometrics_ResultCode_I, __args);
		}

	}

	// event args for com.credenceid.face.FaceEngine.OnMatchFaceTemplatesListener.onMatchFaceTemplates
	public partial class FaceEngineOnMatchFaceTemplatesEventArgs : global::System.EventArgs {

		public FaceEngineOnMatchFaceTemplatesEventArgs (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, int p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Credenceid.Biometrics.BiometricsResultCode p0;
		public global::Com.Credenceid.Biometrics.BiometricsResultCode P0 {
			get { return p0; }
		}

		int p1;
		public int P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/credenceid/face/FaceEngine_OnMatchFaceTemplatesListenerImplementor")]
	internal sealed partial class IFaceEngineOnMatchFaceTemplatesListenerImplementor : global::Java.Lang.Object, IFaceEngineOnMatchFaceTemplatesListener {

		object sender;

		public IFaceEngineOnMatchFaceTemplatesListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/credenceid/face/FaceEngine_OnMatchFaceTemplatesListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<FaceEngineOnMatchFaceTemplatesEventArgs> Handler;
#pragma warning restore 0649

		public void OnMatchFaceTemplates (global::Com.Credenceid.Biometrics.BiometricsResultCode p0, int p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new FaceEngineOnMatchFaceTemplatesEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IFaceEngineOnMatchFaceTemplatesListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.credenceid.face']/interface[@name='FaceEngine']"
	[Register ("com/credenceid/face/FaceEngine", "", "Com.Credenceid.Face.IFaceEngineInvoker")]
	public partial interface IFaceEngine : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.face']/interface[@name='FaceEngine']/method[@name='analyzeFace' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='com.credenceid.face.FaceEngine.OnAnalyzeFaceImageListener']]"
		[Register ("analyzeFace", "(Landroid/graphics/Bitmap;Lcom/credenceid/face/FaceEngine$OnAnalyzeFaceImageListener;)V", "GetAnalyzeFace_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnAnalyzeFaceImageListener_Handler:Com.Credenceid.Face.IFaceEngineInvoker, CredenceBindings")]
		void AnalyzeFace (global::Android.Graphics.Bitmap p0, global::Com.Credenceid.Face.IFaceEngineOnAnalyzeFaceImageListener p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.face']/interface[@name='FaceEngine']/method[@name='analyzeFace' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='com.credenceid.face.FaceEngine.OnAnalyzeFaceImageListener']]"
		[Register ("analyzeFace", "([BIILcom/credenceid/face/FaceEngine$OnAnalyzeFaceImageListener;)V", "GetAnalyzeFace_arrayBIILcom_credenceid_face_FaceEngine_OnAnalyzeFaceImageListener_Handler:Com.Credenceid.Face.IFaceEngineInvoker, CredenceBindings")]
		void AnalyzeFace (byte[] p0, int p1, int p2, global::Com.Credenceid.Face.IFaceEngineOnAnalyzeFaceImageListener p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.face']/interface[@name='FaceEngine']/method[@name='analyzeFaceSync' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='int']]"
		[Register ("analyzeFaceSync", "(Landroid/graphics/Bitmap;I)Lcom/credenceid/face/AnalyzeFaceSyncResponse;", "GetAnalyzeFaceSync_Landroid_graphics_Bitmap_IHandler:Com.Credenceid.Face.IFaceEngineInvoker, CredenceBindings")]
		global::Com.Credenceid.Face.AnalyzeFaceSyncResponse AnalyzeFaceSync (global::Android.Graphics.Bitmap p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.face']/interface[@name='FaceEngine']/method[@name='analyzeFaceSync' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("analyzeFaceSync", "([BIII)Lcom/credenceid/face/AnalyzeFaceSyncResponse;", "GetAnalyzeFaceSync_arrayBIIIHandler:Com.Credenceid.Face.IFaceEngineInvoker, CredenceBindings")]
		global::Com.Credenceid.Face.AnalyzeFaceSyncResponse AnalyzeFaceSync (byte[] p0, int p1, int p2, int p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.face']/interface[@name='FaceEngine']/method[@name='compareFace' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='com.credenceid.face.FaceEngine.OnMatchFaceTemplatesListener']]"
		[Register ("compareFace", "([B[BLcom/credenceid/face/FaceEngine$OnMatchFaceTemplatesListener;)V", "GetCompareFace_arrayBarrayBLcom_credenceid_face_FaceEngine_OnMatchFaceTemplatesListener_Handler:Com.Credenceid.Face.IFaceEngineInvoker, CredenceBindings")]
		void CompareFace (byte[] p0, byte[] p1, global::Com.Credenceid.Face.IFaceEngineOnMatchFaceTemplatesListener p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.face']/interface[@name='FaceEngine']/method[@name='compareFaceSync' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
		[Register ("compareFaceSync", "([B[BI)Lcom/credenceid/face/CompareFaceSyncResponse;", "GetCompareFaceSync_arrayBarrayBIHandler:Com.Credenceid.Face.IFaceEngineInvoker, CredenceBindings")]
		global::Com.Credenceid.Face.CompareFaceSyncResponse CompareFaceSync (byte[] p0, byte[] p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.face']/interface[@name='FaceEngine']/method[@name='createFaceTemplate' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='com.credenceid.face.FaceEngine.OnCreateFaceTemplateListener']]"
		[Register ("createFaceTemplate", "(Landroid/graphics/Bitmap;Lcom/credenceid/face/FaceEngine$OnCreateFaceTemplateListener;)V", "GetCreateFaceTemplate_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnCreateFaceTemplateListener_Handler:Com.Credenceid.Face.IFaceEngineInvoker, CredenceBindings")]
		void CreateFaceTemplate (global::Android.Graphics.Bitmap p0, global::Com.Credenceid.Face.IFaceEngineOnCreateFaceTemplateListener p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.face']/interface[@name='FaceEngine']/method[@name='createFaceTemplate' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='com.credenceid.face.FaceEngine.OnCreateFaceTemplateListener']]"
		[Register ("createFaceTemplate", "([BIILcom/credenceid/face/FaceEngine$OnCreateFaceTemplateListener;)V", "GetCreateFaceTemplate_arrayBIILcom_credenceid_face_FaceEngine_OnCreateFaceTemplateListener_Handler:Com.Credenceid.Face.IFaceEngineInvoker, CredenceBindings")]
		void CreateFaceTemplate (byte[] p0, int p1, int p2, global::Com.Credenceid.Face.IFaceEngineOnCreateFaceTemplateListener p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.face']/interface[@name='FaceEngine']/method[@name='createFaceTemplateSync' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='int']]"
		[Register ("createFaceTemplateSync", "(Landroid/graphics/Bitmap;I)Lcom/credenceid/face/CreateFaceTemplateSyncResponse;", "GetCreateFaceTemplateSync_Landroid_graphics_Bitmap_IHandler:Com.Credenceid.Face.IFaceEngineInvoker, CredenceBindings")]
		global::Com.Credenceid.Face.CreateFaceTemplateSyncResponse CreateFaceTemplateSync (global::Android.Graphics.Bitmap p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.face']/interface[@name='FaceEngine']/method[@name='createFaceTemplateSync' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("createFaceTemplateSync", "([BIII)Lcom/credenceid/face/CreateFaceTemplateSyncResponse;", "GetCreateFaceTemplateSync_arrayBIIIHandler:Com.Credenceid.Face.IFaceEngineInvoker, CredenceBindings")]
		global::Com.Credenceid.Face.CreateFaceTemplateSyncResponse CreateFaceTemplateSync (byte[] p0, int p1, int p2, int p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.face']/interface[@name='FaceEngine']/method[@name='detectFace' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='com.credenceid.face.FaceEngine.OnDetectFaceListener']]"
		[Register ("detectFace", "(Landroid/graphics/Bitmap;Lcom/credenceid/face/FaceEngine$OnDetectFaceListener;)V", "GetDetectFace_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnDetectFaceListener_Handler:Com.Credenceid.Face.IFaceEngineInvoker, CredenceBindings")]
		void DetectFace (global::Android.Graphics.Bitmap p0, global::Com.Credenceid.Face.IFaceEngineOnDetectFaceListener p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.face']/interface[@name='FaceEngine']/method[@name='detectFace' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='com.credenceid.face.FaceEngine.OnDetectFaceListener']]"
		[Register ("detectFace", "([BIILcom/credenceid/face/FaceEngine$OnDetectFaceListener;)V", "GetDetectFace_arrayBIILcom_credenceid_face_FaceEngine_OnDetectFaceListener_Handler:Com.Credenceid.Face.IFaceEngineInvoker, CredenceBindings")]
		void DetectFace (byte[] p0, int p1, int p2, global::Com.Credenceid.Face.IFaceEngineOnDetectFaceListener p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.face']/interface[@name='FaceEngine']/method[@name='detectFaceSync' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='int']]"
		[Register ("detectFaceSync", "(Landroid/graphics/Bitmap;I)Lcom/credenceid/face/DetectFaceSyncResponse;", "GetDetectFaceSync_Landroid_graphics_Bitmap_IHandler:Com.Credenceid.Face.IFaceEngineInvoker, CredenceBindings")]
		global::Com.Credenceid.Face.DetectFaceSyncResponse DetectFaceSync (global::Android.Graphics.Bitmap p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.face']/interface[@name='FaceEngine']/method[@name='detectFaceSync' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("detectFaceSync", "([BIII)Lcom/credenceid/face/DetectFaceSyncResponse;", "GetDetectFaceSync_arrayBIIIHandler:Com.Credenceid.Face.IFaceEngineInvoker, CredenceBindings")]
		global::Com.Credenceid.Face.DetectFaceSyncResponse DetectFaceSync (byte[] p0, int p1, int p2, int p3);

	}

	[global::Android.Runtime.Register ("com/credenceid/face/FaceEngine", DoNotGenerateAcw=true)]
	internal partial class IFaceEngineInvoker : global::Java.Lang.Object, IFaceEngine {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/credenceid/face/FaceEngine");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IFaceEngineInvoker); }
		}

		IntPtr class_ref;

		public static IFaceEngine GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFaceEngine> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.credenceid.face.FaceEngine"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFaceEngineInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_analyzeFace_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnAnalyzeFaceImageListener_;
#pragma warning disable 0169
		static Delegate GetAnalyzeFace_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnAnalyzeFaceImageListener_Handler ()
		{
			if (cb_analyzeFace_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnAnalyzeFaceImageListener_ == null)
				cb_analyzeFace_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnAnalyzeFaceImageListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_AnalyzeFace_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnAnalyzeFaceImageListener_);
			return cb_analyzeFace_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnAnalyzeFaceImageListener_;
		}

		static void n_AnalyzeFace_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnAnalyzeFaceImageListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.IFaceEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Credenceid.Face.IFaceEngineOnAnalyzeFaceImageListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.IFaceEngineOnAnalyzeFaceImageListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AnalyzeFace (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_analyzeFace_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnAnalyzeFaceImageListener_;
		public unsafe void AnalyzeFace (global::Android.Graphics.Bitmap p0, global::Com.Credenceid.Face.IFaceEngineOnAnalyzeFaceImageListener p1)
		{
			if (id_analyzeFace_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnAnalyzeFaceImageListener_ == IntPtr.Zero)
				id_analyzeFace_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnAnalyzeFaceImageListener_ = JNIEnv.GetMethodID (class_ref, "analyzeFace", "(Landroid/graphics/Bitmap;Lcom/credenceid/face/FaceEngine$OnAnalyzeFaceImageListener;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_analyzeFace_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnAnalyzeFaceImageListener_, __args);
		}

		static Delegate cb_analyzeFace_arrayBIILcom_credenceid_face_FaceEngine_OnAnalyzeFaceImageListener_;
#pragma warning disable 0169
		static Delegate GetAnalyzeFace_arrayBIILcom_credenceid_face_FaceEngine_OnAnalyzeFaceImageListener_Handler ()
		{
			if (cb_analyzeFace_arrayBIILcom_credenceid_face_FaceEngine_OnAnalyzeFaceImageListener_ == null)
				cb_analyzeFace_arrayBIILcom_credenceid_face_FaceEngine_OnAnalyzeFaceImageListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIL_V) n_AnalyzeFace_arrayBIILcom_credenceid_face_FaceEngine_OnAnalyzeFaceImageListener_);
			return cb_analyzeFace_arrayBIILcom_credenceid_face_FaceEngine_OnAnalyzeFaceImageListener_;
		}

		static void n_AnalyzeFace_arrayBIILcom_credenceid_face_FaceEngine_OnAnalyzeFaceImageListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.IFaceEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p3 = (global::Com.Credenceid.Face.IFaceEngineOnAnalyzeFaceImageListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.IFaceEngineOnAnalyzeFaceImageListener> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.AnalyzeFace (p0, p1, p2, p3);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_analyzeFace_arrayBIILcom_credenceid_face_FaceEngine_OnAnalyzeFaceImageListener_;
		public unsafe void AnalyzeFace (byte[] p0, int p1, int p2, global::Com.Credenceid.Face.IFaceEngineOnAnalyzeFaceImageListener p3)
		{
			if (id_analyzeFace_arrayBIILcom_credenceid_face_FaceEngine_OnAnalyzeFaceImageListener_ == IntPtr.Zero)
				id_analyzeFace_arrayBIILcom_credenceid_face_FaceEngine_OnAnalyzeFaceImageListener_ = JNIEnv.GetMethodID (class_ref, "analyzeFace", "([BIILcom/credenceid/face/FaceEngine$OnAnalyzeFaceImageListener;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_analyzeFace_arrayBIILcom_credenceid_face_FaceEngine_OnAnalyzeFaceImageListener_, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_analyzeFaceSync_Landroid_graphics_Bitmap_I;
#pragma warning disable 0169
		static Delegate GetAnalyzeFaceSync_Landroid_graphics_Bitmap_IHandler ()
		{
			if (cb_analyzeFaceSync_Landroid_graphics_Bitmap_I == null)
				cb_analyzeFaceSync_Landroid_graphics_Bitmap_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_L) n_AnalyzeFaceSync_Landroid_graphics_Bitmap_I);
			return cb_analyzeFaceSync_Landroid_graphics_Bitmap_I;
		}

		static IntPtr n_AnalyzeFaceSync_Landroid_graphics_Bitmap_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.IFaceEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AnalyzeFaceSync (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_analyzeFaceSync_Landroid_graphics_Bitmap_I;
		public unsafe global::Com.Credenceid.Face.AnalyzeFaceSyncResponse AnalyzeFaceSync (global::Android.Graphics.Bitmap p0, int p1)
		{
			if (id_analyzeFaceSync_Landroid_graphics_Bitmap_I == IntPtr.Zero)
				id_analyzeFaceSync_Landroid_graphics_Bitmap_I = JNIEnv.GetMethodID (class_ref, "analyzeFaceSync", "(Landroid/graphics/Bitmap;I)Lcom/credenceid/face/AnalyzeFaceSyncResponse;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.AnalyzeFaceSyncResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_analyzeFaceSync_Landroid_graphics_Bitmap_I, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_analyzeFaceSync_arrayBIII;
#pragma warning disable 0169
		static Delegate GetAnalyzeFaceSync_arrayBIIIHandler ()
		{
			if (cb_analyzeFaceSync_arrayBIII == null)
				cb_analyzeFaceSync_arrayBIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIII_L) n_AnalyzeFaceSync_arrayBIII);
			return cb_analyzeFaceSync_arrayBIII;
		}

		static IntPtr n_AnalyzeFaceSync_arrayBIII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.IFaceEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AnalyzeFaceSync (p0, p1, p2, p3));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_analyzeFaceSync_arrayBIII;
		public unsafe global::Com.Credenceid.Face.AnalyzeFaceSyncResponse AnalyzeFaceSync (byte[] p0, int p1, int p2, int p3)
		{
			if (id_analyzeFaceSync_arrayBIII == IntPtr.Zero)
				id_analyzeFaceSync_arrayBIII = JNIEnv.GetMethodID (class_ref, "analyzeFaceSync", "([BIII)Lcom/credenceid/face/AnalyzeFaceSyncResponse;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.AnalyzeFaceSyncResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_analyzeFaceSync_arrayBIII, __args), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_compareFace_arrayBarrayBLcom_credenceid_face_FaceEngine_OnMatchFaceTemplatesListener_;
#pragma warning disable 0169
		static Delegate GetCompareFace_arrayBarrayBLcom_credenceid_face_FaceEngine_OnMatchFaceTemplatesListener_Handler ()
		{
			if (cb_compareFace_arrayBarrayBLcom_credenceid_face_FaceEngine_OnMatchFaceTemplatesListener_ == null)
				cb_compareFace_arrayBarrayBLcom_credenceid_face_FaceEngine_OnMatchFaceTemplatesListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_CompareFace_arrayBarrayBLcom_credenceid_face_FaceEngine_OnMatchFaceTemplatesListener_);
			return cb_compareFace_arrayBarrayBLcom_credenceid_face_FaceEngine_OnMatchFaceTemplatesListener_;
		}

		static void n_CompareFace_arrayBarrayBLcom_credenceid_face_FaceEngine_OnMatchFaceTemplatesListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.IFaceEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p2 = (global::Com.Credenceid.Face.IFaceEngineOnMatchFaceTemplatesListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.IFaceEngineOnMatchFaceTemplatesListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.CompareFace (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		IntPtr id_compareFace_arrayBarrayBLcom_credenceid_face_FaceEngine_OnMatchFaceTemplatesListener_;
		public unsafe void CompareFace (byte[] p0, byte[] p1, global::Com.Credenceid.Face.IFaceEngineOnMatchFaceTemplatesListener p2)
		{
			if (id_compareFace_arrayBarrayBLcom_credenceid_face_FaceEngine_OnMatchFaceTemplatesListener_ == IntPtr.Zero)
				id_compareFace_arrayBarrayBLcom_credenceid_face_FaceEngine_OnMatchFaceTemplatesListener_ = JNIEnv.GetMethodID (class_ref, "compareFace", "([B[BLcom/credenceid/face/FaceEngine$OnMatchFaceTemplatesListener;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_compareFace_arrayBarrayBLcom_credenceid_face_FaceEngine_OnMatchFaceTemplatesListener_, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_compareFaceSync_arrayBarrayBI;
#pragma warning disable 0169
		static Delegate GetCompareFaceSync_arrayBarrayBIHandler ()
		{
			if (cb_compareFaceSync_arrayBarrayBI == null)
				cb_compareFaceSync_arrayBarrayBI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLI_L) n_CompareFaceSync_arrayBarrayBI);
			return cb_compareFaceSync_arrayBarrayBI;
		}

		static IntPtr n_CompareFaceSync_arrayBarrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.IFaceEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CompareFaceSync (p0, p1, p2));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_compareFaceSync_arrayBarrayBI;
		public unsafe global::Com.Credenceid.Face.CompareFaceSyncResponse CompareFaceSync (byte[] p0, byte[] p1, int p2)
		{
			if (id_compareFaceSync_arrayBarrayBI == IntPtr.Zero)
				id_compareFaceSync_arrayBarrayBI = JNIEnv.GetMethodID (class_ref, "compareFaceSync", "([B[BI)Lcom/credenceid/face/CompareFaceSyncResponse;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.CompareFaceSyncResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_compareFaceSync_arrayBarrayBI, __args), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate cb_createFaceTemplate_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnCreateFaceTemplateListener_;
#pragma warning disable 0169
		static Delegate GetCreateFaceTemplate_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnCreateFaceTemplateListener_Handler ()
		{
			if (cb_createFaceTemplate_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnCreateFaceTemplateListener_ == null)
				cb_createFaceTemplate_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnCreateFaceTemplateListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_CreateFaceTemplate_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnCreateFaceTemplateListener_);
			return cb_createFaceTemplate_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnCreateFaceTemplateListener_;
		}

		static void n_CreateFaceTemplate_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnCreateFaceTemplateListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.IFaceEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Credenceid.Face.IFaceEngineOnCreateFaceTemplateListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.IFaceEngineOnCreateFaceTemplateListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.CreateFaceTemplate (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_createFaceTemplate_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnCreateFaceTemplateListener_;
		public unsafe void CreateFaceTemplate (global::Android.Graphics.Bitmap p0, global::Com.Credenceid.Face.IFaceEngineOnCreateFaceTemplateListener p1)
		{
			if (id_createFaceTemplate_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnCreateFaceTemplateListener_ == IntPtr.Zero)
				id_createFaceTemplate_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnCreateFaceTemplateListener_ = JNIEnv.GetMethodID (class_ref, "createFaceTemplate", "(Landroid/graphics/Bitmap;Lcom/credenceid/face/FaceEngine$OnCreateFaceTemplateListener;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_createFaceTemplate_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnCreateFaceTemplateListener_, __args);
		}

		static Delegate cb_createFaceTemplate_arrayBIILcom_credenceid_face_FaceEngine_OnCreateFaceTemplateListener_;
#pragma warning disable 0169
		static Delegate GetCreateFaceTemplate_arrayBIILcom_credenceid_face_FaceEngine_OnCreateFaceTemplateListener_Handler ()
		{
			if (cb_createFaceTemplate_arrayBIILcom_credenceid_face_FaceEngine_OnCreateFaceTemplateListener_ == null)
				cb_createFaceTemplate_arrayBIILcom_credenceid_face_FaceEngine_OnCreateFaceTemplateListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIL_V) n_CreateFaceTemplate_arrayBIILcom_credenceid_face_FaceEngine_OnCreateFaceTemplateListener_);
			return cb_createFaceTemplate_arrayBIILcom_credenceid_face_FaceEngine_OnCreateFaceTemplateListener_;
		}

		static void n_CreateFaceTemplate_arrayBIILcom_credenceid_face_FaceEngine_OnCreateFaceTemplateListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.IFaceEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p3 = (global::Com.Credenceid.Face.IFaceEngineOnCreateFaceTemplateListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.IFaceEngineOnCreateFaceTemplateListener> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.CreateFaceTemplate (p0, p1, p2, p3);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_createFaceTemplate_arrayBIILcom_credenceid_face_FaceEngine_OnCreateFaceTemplateListener_;
		public unsafe void CreateFaceTemplate (byte[] p0, int p1, int p2, global::Com.Credenceid.Face.IFaceEngineOnCreateFaceTemplateListener p3)
		{
			if (id_createFaceTemplate_arrayBIILcom_credenceid_face_FaceEngine_OnCreateFaceTemplateListener_ == IntPtr.Zero)
				id_createFaceTemplate_arrayBIILcom_credenceid_face_FaceEngine_OnCreateFaceTemplateListener_ = JNIEnv.GetMethodID (class_ref, "createFaceTemplate", "([BIILcom/credenceid/face/FaceEngine$OnCreateFaceTemplateListener;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_createFaceTemplate_arrayBIILcom_credenceid_face_FaceEngine_OnCreateFaceTemplateListener_, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_createFaceTemplateSync_Landroid_graphics_Bitmap_I;
#pragma warning disable 0169
		static Delegate GetCreateFaceTemplateSync_Landroid_graphics_Bitmap_IHandler ()
		{
			if (cb_createFaceTemplateSync_Landroid_graphics_Bitmap_I == null)
				cb_createFaceTemplateSync_Landroid_graphics_Bitmap_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_L) n_CreateFaceTemplateSync_Landroid_graphics_Bitmap_I);
			return cb_createFaceTemplateSync_Landroid_graphics_Bitmap_I;
		}

		static IntPtr n_CreateFaceTemplateSync_Landroid_graphics_Bitmap_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.IFaceEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateFaceTemplateSync (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_createFaceTemplateSync_Landroid_graphics_Bitmap_I;
		public unsafe global::Com.Credenceid.Face.CreateFaceTemplateSyncResponse CreateFaceTemplateSync (global::Android.Graphics.Bitmap p0, int p1)
		{
			if (id_createFaceTemplateSync_Landroid_graphics_Bitmap_I == IntPtr.Zero)
				id_createFaceTemplateSync_Landroid_graphics_Bitmap_I = JNIEnv.GetMethodID (class_ref, "createFaceTemplateSync", "(Landroid/graphics/Bitmap;I)Lcom/credenceid/face/CreateFaceTemplateSyncResponse;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.CreateFaceTemplateSyncResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createFaceTemplateSync_Landroid_graphics_Bitmap_I, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_createFaceTemplateSync_arrayBIII;
#pragma warning disable 0169
		static Delegate GetCreateFaceTemplateSync_arrayBIIIHandler ()
		{
			if (cb_createFaceTemplateSync_arrayBIII == null)
				cb_createFaceTemplateSync_arrayBIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIII_L) n_CreateFaceTemplateSync_arrayBIII);
			return cb_createFaceTemplateSync_arrayBIII;
		}

		static IntPtr n_CreateFaceTemplateSync_arrayBIII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.IFaceEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateFaceTemplateSync (p0, p1, p2, p3));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_createFaceTemplateSync_arrayBIII;
		public unsafe global::Com.Credenceid.Face.CreateFaceTemplateSyncResponse CreateFaceTemplateSync (byte[] p0, int p1, int p2, int p3)
		{
			if (id_createFaceTemplateSync_arrayBIII == IntPtr.Zero)
				id_createFaceTemplateSync_arrayBIII = JNIEnv.GetMethodID (class_ref, "createFaceTemplateSync", "([BIII)Lcom/credenceid/face/CreateFaceTemplateSyncResponse;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.CreateFaceTemplateSyncResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createFaceTemplateSync_arrayBIII, __args), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_detectFace_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnDetectFaceListener_;
#pragma warning disable 0169
		static Delegate GetDetectFace_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnDetectFaceListener_Handler ()
		{
			if (cb_detectFace_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnDetectFaceListener_ == null)
				cb_detectFace_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnDetectFaceListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_DetectFace_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnDetectFaceListener_);
			return cb_detectFace_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnDetectFaceListener_;
		}

		static void n_DetectFace_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnDetectFaceListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.IFaceEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Credenceid.Face.IFaceEngineOnDetectFaceListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.IFaceEngineOnDetectFaceListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.DetectFace (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_detectFace_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnDetectFaceListener_;
		public unsafe void DetectFace (global::Android.Graphics.Bitmap p0, global::Com.Credenceid.Face.IFaceEngineOnDetectFaceListener p1)
		{
			if (id_detectFace_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnDetectFaceListener_ == IntPtr.Zero)
				id_detectFace_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnDetectFaceListener_ = JNIEnv.GetMethodID (class_ref, "detectFace", "(Landroid/graphics/Bitmap;Lcom/credenceid/face/FaceEngine$OnDetectFaceListener;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_detectFace_Landroid_graphics_Bitmap_Lcom_credenceid_face_FaceEngine_OnDetectFaceListener_, __args);
		}

		static Delegate cb_detectFace_arrayBIILcom_credenceid_face_FaceEngine_OnDetectFaceListener_;
#pragma warning disable 0169
		static Delegate GetDetectFace_arrayBIILcom_credenceid_face_FaceEngine_OnDetectFaceListener_Handler ()
		{
			if (cb_detectFace_arrayBIILcom_credenceid_face_FaceEngine_OnDetectFaceListener_ == null)
				cb_detectFace_arrayBIILcom_credenceid_face_FaceEngine_OnDetectFaceListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIL_V) n_DetectFace_arrayBIILcom_credenceid_face_FaceEngine_OnDetectFaceListener_);
			return cb_detectFace_arrayBIILcom_credenceid_face_FaceEngine_OnDetectFaceListener_;
		}

		static void n_DetectFace_arrayBIILcom_credenceid_face_FaceEngine_OnDetectFaceListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.IFaceEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p3 = (global::Com.Credenceid.Face.IFaceEngineOnDetectFaceListener)global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.IFaceEngineOnDetectFaceListener> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.DetectFace (p0, p1, p2, p3);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_detectFace_arrayBIILcom_credenceid_face_FaceEngine_OnDetectFaceListener_;
		public unsafe void DetectFace (byte[] p0, int p1, int p2, global::Com.Credenceid.Face.IFaceEngineOnDetectFaceListener p3)
		{
			if (id_detectFace_arrayBIILcom_credenceid_face_FaceEngine_OnDetectFaceListener_ == IntPtr.Zero)
				id_detectFace_arrayBIILcom_credenceid_face_FaceEngine_OnDetectFaceListener_ = JNIEnv.GetMethodID (class_ref, "detectFace", "([BIILcom/credenceid/face/FaceEngine$OnDetectFaceListener;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_detectFace_arrayBIILcom_credenceid_face_FaceEngine_OnDetectFaceListener_, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_detectFaceSync_Landroid_graphics_Bitmap_I;
#pragma warning disable 0169
		static Delegate GetDetectFaceSync_Landroid_graphics_Bitmap_IHandler ()
		{
			if (cb_detectFaceSync_Landroid_graphics_Bitmap_I == null)
				cb_detectFaceSync_Landroid_graphics_Bitmap_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_L) n_DetectFaceSync_Landroid_graphics_Bitmap_I);
			return cb_detectFaceSync_Landroid_graphics_Bitmap_I;
		}

		static IntPtr n_DetectFaceSync_Landroid_graphics_Bitmap_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.IFaceEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DetectFaceSync (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_detectFaceSync_Landroid_graphics_Bitmap_I;
		public unsafe global::Com.Credenceid.Face.DetectFaceSyncResponse DetectFaceSync (global::Android.Graphics.Bitmap p0, int p1)
		{
			if (id_detectFaceSync_Landroid_graphics_Bitmap_I == IntPtr.Zero)
				id_detectFaceSync_Landroid_graphics_Bitmap_I = JNIEnv.GetMethodID (class_ref, "detectFaceSync", "(Landroid/graphics/Bitmap;I)Lcom/credenceid/face/DetectFaceSyncResponse;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.DetectFaceSyncResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_detectFaceSync_Landroid_graphics_Bitmap_I, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_detectFaceSync_arrayBIII;
#pragma warning disable 0169
		static Delegate GetDetectFaceSync_arrayBIIIHandler ()
		{
			if (cb_detectFaceSync_arrayBIII == null)
				cb_detectFaceSync_arrayBIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIII_L) n_DetectFaceSync_arrayBIII);
			return cb_detectFaceSync_arrayBIII;
		}

		static IntPtr n_DetectFaceSync_arrayBIII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.IFaceEngine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DetectFaceSync (p0, p1, p2, p3));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_detectFaceSync_arrayBIII;
		public unsafe global::Com.Credenceid.Face.DetectFaceSyncResponse DetectFaceSync (byte[] p0, int p1, int p2, int p3)
		{
			if (id_detectFaceSync_arrayBIII == IntPtr.Zero)
				id_detectFaceSync_arrayBIII = JNIEnv.GetMethodID (class_ref, "detectFaceSync", "([BIII)Lcom/credenceid/face/DetectFaceSyncResponse;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Face.DetectFaceSyncResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_detectFaceSync_arrayBIII, __args), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

	}

}
