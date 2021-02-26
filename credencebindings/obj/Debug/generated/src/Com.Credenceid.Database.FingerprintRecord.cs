using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Credenceid.Database {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.credenceid.database']/class[@name='FingerprintRecord']"
	[global::Android.Runtime.Register ("com/credenceid/database/FingerprintRecord", DoNotGenerateAcw=true)]
	public partial class FingerprintRecord : global::Com.Credenceid.Database.BiometricData {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.credenceid.database']/class[@name='FingerprintRecord.Position']"
		[global::Android.Runtime.Register ("com/credenceid/database/FingerprintRecord$Position", DoNotGenerateAcw=true)]
		public sealed partial class Position : global::Java.Lang.Enum {


			static IntPtr LEFT_INDEX_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.database']/class[@name='FingerprintRecord.Position']/field[@name='LEFT_INDEX']"
			[Register ("LEFT_INDEX")]
			public static global::Com.Credenceid.Database.FingerprintRecord.Position LeftIndex {
				get {
					if (LEFT_INDEX_jfieldId == IntPtr.Zero)
						LEFT_INDEX_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LEFT_INDEX", "Lcom/credenceid/database/FingerprintRecord$Position;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LEFT_INDEX_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.FingerprintRecord.Position> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr LEFT_LITTLE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.database']/class[@name='FingerprintRecord.Position']/field[@name='LEFT_LITTLE']"
			[Register ("LEFT_LITTLE")]
			public static global::Com.Credenceid.Database.FingerprintRecord.Position LeftLittle {
				get {
					if (LEFT_LITTLE_jfieldId == IntPtr.Zero)
						LEFT_LITTLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LEFT_LITTLE", "Lcom/credenceid/database/FingerprintRecord$Position;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LEFT_LITTLE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.FingerprintRecord.Position> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr LEFT_MIDDLE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.database']/class[@name='FingerprintRecord.Position']/field[@name='LEFT_MIDDLE']"
			[Register ("LEFT_MIDDLE")]
			public static global::Com.Credenceid.Database.FingerprintRecord.Position LeftMiddle {
				get {
					if (LEFT_MIDDLE_jfieldId == IntPtr.Zero)
						LEFT_MIDDLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LEFT_MIDDLE", "Lcom/credenceid/database/FingerprintRecord$Position;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LEFT_MIDDLE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.FingerprintRecord.Position> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr LEFT_RING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.database']/class[@name='FingerprintRecord.Position']/field[@name='LEFT_RING']"
			[Register ("LEFT_RING")]
			public static global::Com.Credenceid.Database.FingerprintRecord.Position LeftRing {
				get {
					if (LEFT_RING_jfieldId == IntPtr.Zero)
						LEFT_RING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LEFT_RING", "Lcom/credenceid/database/FingerprintRecord$Position;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LEFT_RING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.FingerprintRecord.Position> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr LEFT_THUMB_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.database']/class[@name='FingerprintRecord.Position']/field[@name='LEFT_THUMB']"
			[Register ("LEFT_THUMB")]
			public static global::Com.Credenceid.Database.FingerprintRecord.Position LeftThumb {
				get {
					if (LEFT_THUMB_jfieldId == IntPtr.Zero)
						LEFT_THUMB_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LEFT_THUMB", "Lcom/credenceid/database/FingerprintRecord$Position;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LEFT_THUMB_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.FingerprintRecord.Position> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr RIGHT_INDEX_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.database']/class[@name='FingerprintRecord.Position']/field[@name='RIGHT_INDEX']"
			[Register ("RIGHT_INDEX")]
			public static global::Com.Credenceid.Database.FingerprintRecord.Position RightIndex {
				get {
					if (RIGHT_INDEX_jfieldId == IntPtr.Zero)
						RIGHT_INDEX_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RIGHT_INDEX", "Lcom/credenceid/database/FingerprintRecord$Position;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RIGHT_INDEX_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.FingerprintRecord.Position> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr RIGHT_LITTLE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.database']/class[@name='FingerprintRecord.Position']/field[@name='RIGHT_LITTLE']"
			[Register ("RIGHT_LITTLE")]
			public static global::Com.Credenceid.Database.FingerprintRecord.Position RightLittle {
				get {
					if (RIGHT_LITTLE_jfieldId == IntPtr.Zero)
						RIGHT_LITTLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RIGHT_LITTLE", "Lcom/credenceid/database/FingerprintRecord$Position;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RIGHT_LITTLE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.FingerprintRecord.Position> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr RIGHT_MIDDLE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.database']/class[@name='FingerprintRecord.Position']/field[@name='RIGHT_MIDDLE']"
			[Register ("RIGHT_MIDDLE")]
			public static global::Com.Credenceid.Database.FingerprintRecord.Position RightMiddle {
				get {
					if (RIGHT_MIDDLE_jfieldId == IntPtr.Zero)
						RIGHT_MIDDLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RIGHT_MIDDLE", "Lcom/credenceid/database/FingerprintRecord$Position;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RIGHT_MIDDLE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.FingerprintRecord.Position> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr RIGHT_RING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.database']/class[@name='FingerprintRecord.Position']/field[@name='RIGHT_RING']"
			[Register ("RIGHT_RING")]
			public static global::Com.Credenceid.Database.FingerprintRecord.Position RightRing {
				get {
					if (RIGHT_RING_jfieldId == IntPtr.Zero)
						RIGHT_RING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RIGHT_RING", "Lcom/credenceid/database/FingerprintRecord$Position;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RIGHT_RING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.FingerprintRecord.Position> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr RIGHT_THUMB_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.database']/class[@name='FingerprintRecord.Position']/field[@name='RIGHT_THUMB']"
			[Register ("RIGHT_THUMB")]
			public static global::Com.Credenceid.Database.FingerprintRecord.Position RightThumb {
				get {
					if (RIGHT_THUMB_jfieldId == IntPtr.Zero)
						RIGHT_THUMB_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RIGHT_THUMB", "Lcom/credenceid/database/FingerprintRecord$Position;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RIGHT_THUMB_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.FingerprintRecord.Position> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr UNKNOWN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.database']/class[@name='FingerprintRecord.Position']/field[@name='UNKNOWN']"
			[Register ("UNKNOWN")]
			public static global::Com.Credenceid.Database.FingerprintRecord.Position Unknown {
				get {
					if (UNKNOWN_jfieldId == IntPtr.Zero)
						UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN", "Lcom/credenceid/database/FingerprintRecord$Position;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNKNOWN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.FingerprintRecord.Position> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/credenceid/database/FingerprintRecord$Position", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Position); }
			}

			internal Position (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getValue;
			public unsafe int Value {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/class[@name='FingerprintRecord.Position']/method[@name='getValue' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/class[@name='FingerprintRecord.Position']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("valueOf", "(I)Lcom/credenceid/database/FingerprintRecord$Position;", "")]
			public static unsafe global::Com.Credenceid.Database.FingerprintRecord.Position ValueOf (int val)
			{
				if (id_valueOf_I == IntPtr.Zero)
					id_valueOf_I = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(I)Lcom/credenceid/database/FingerprintRecord$Position;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (val);
					return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.FingerprintRecord.Position> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_I, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/class[@name='FingerprintRecord.Position']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/credenceid/database/FingerprintRecord$Position;", "")]
			public static unsafe global::Com.Credenceid.Database.FingerprintRecord.Position ValueOf (string name)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/credenceid/database/FingerprintRecord$Position;");
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_name);
					global::Com.Credenceid.Database.FingerprintRecord.Position __ret = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.FingerprintRecord.Position> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/class[@name='FingerprintRecord.Position']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/credenceid/database/FingerprintRecord$Position;", "")]
			public static unsafe global::Com.Credenceid.Database.FingerprintRecord.Position[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/credenceid/database/FingerprintRecord$Position;");
				try {
					return (global::Com.Credenceid.Database.FingerprintRecord.Position[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Credenceid.Database.FingerprintRecord.Position));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/credenceid/database/FingerprintRecord", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FingerprintRecord); }
		}

		protected FingerprintRecord (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.database']/class[@name='FingerprintRecord']/constructor[@name='FingerprintRecord' and count(parameter)=1 and parameter[1][@type='com.credenceid.database.FingerprintRecord.Position']]"
		[Register (".ctor", "(Lcom/credenceid/database/FingerprintRecord$Position;)V", "")]
		public unsafe FingerprintRecord (global::Com.Credenceid.Database.FingerprintRecord.Position position)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (position);
				if (((object) this).GetType () != typeof (FingerprintRecord)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/credenceid/database/FingerprintRecord$Position;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/credenceid/database/FingerprintRecord$Position;)V", __args);
					return;
				}

				if (id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_ == IntPtr.Zero)
					id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/credenceid/database/FingerprintRecord$Position;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.database']/class[@name='FingerprintRecord']/constructor[@name='FingerprintRecord' and count(parameter)=2 and parameter[1][@type='com.credenceid.database.FingerprintRecord.Position'] and parameter[2][@type='android.graphics.Bitmap']]"
		[Register (".ctor", "(Lcom/credenceid/database/FingerprintRecord$Position;Landroid/graphics/Bitmap;)V", "")]
		public unsafe FingerprintRecord (global::Com.Credenceid.Database.FingerprintRecord.Position position, global::Android.Graphics.Bitmap imageOne)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (position);
				__args [1] = new JValue (imageOne);
				if (((object) this).GetType () != typeof (FingerprintRecord)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/credenceid/database/FingerprintRecord$Position;Landroid/graphics/Bitmap;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/credenceid/database/FingerprintRecord$Position;Landroid/graphics/Bitmap;)V", __args);
					return;
				}

				if (id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Landroid_graphics_Bitmap_ == IntPtr.Zero)
					id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/credenceid/database/FingerprintRecord$Position;Landroid/graphics/Bitmap;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Landroid_graphics_Bitmap_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Landroid_graphics_Bitmap_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.database']/class[@name='FingerprintRecord']/constructor[@name='FingerprintRecord' and count(parameter)=3 and parameter[1][@type='com.credenceid.database.FingerprintRecord.Position'] and parameter[2][@type='android.graphics.Bitmap'] and parameter[3][@type='android.graphics.Bitmap']]"
		[Register (".ctor", "(Lcom/credenceid/database/FingerprintRecord$Position;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;)V", "")]
		public unsafe FingerprintRecord (global::Com.Credenceid.Database.FingerprintRecord.Position position, global::Android.Graphics.Bitmap imageOne, global::Android.Graphics.Bitmap imageTwo)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (position);
				__args [1] = new JValue (imageOne);
				__args [2] = new JValue (imageTwo);
				if (((object) this).GetType () != typeof (FingerprintRecord)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/credenceid/database/FingerprintRecord$Position;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/credenceid/database/FingerprintRecord$Position;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;)V", __args);
					return;
				}

				if (id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_ == IntPtr.Zero)
					id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/credenceid/database/FingerprintRecord$Position;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.database']/class[@name='FingerprintRecord']/constructor[@name='FingerprintRecord' and count(parameter)=4 and parameter[1][@type='com.credenceid.database.FingerprintRecord.Position'] and parameter[2][@type='android.graphics.Bitmap'] and parameter[3][@type='android.graphics.Bitmap'] and parameter[4][@type='android.graphics.Bitmap']]"
		[Register (".ctor", "(Lcom/credenceid/database/FingerprintRecord$Position;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;)V", "")]
		public unsafe FingerprintRecord (global::Com.Credenceid.Database.FingerprintRecord.Position position, global::Android.Graphics.Bitmap imageOne, global::Android.Graphics.Bitmap imageTwo, global::Android.Graphics.Bitmap imageThree)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (position);
				__args [1] = new JValue (imageOne);
				__args [2] = new JValue (imageTwo);
				__args [3] = new JValue (imageThree);
				if (((object) this).GetType () != typeof (FingerprintRecord)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/credenceid/database/FingerprintRecord$Position;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/credenceid/database/FingerprintRecord$Position;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;)V", __args);
					return;
				}

				if (id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_ == IntPtr.Zero)
					id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/credenceid/database/FingerprintRecord$Position;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Landroid_graphics_Bitmap_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.database']/class[@name='FingerprintRecord']/constructor[@name='FingerprintRecord' and count(parameter)=3 and parameter[1][@type='com.credenceid.database.FingerprintRecord.Position'] and parameter[2][@type='android.graphics.Bitmap'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Lcom/credenceid/database/FingerprintRecord$Position;Landroid/graphics/Bitmap;I)V", "")]
		public unsafe FingerprintRecord (global::Com.Credenceid.Database.FingerprintRecord.Position position, global::Android.Graphics.Bitmap imageOne, int imageOneDPI)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (position);
				__args [1] = new JValue (imageOne);
				__args [2] = new JValue (imageOneDPI);
				if (((object) this).GetType () != typeof (FingerprintRecord)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/credenceid/database/FingerprintRecord$Position;Landroid/graphics/Bitmap;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/credenceid/database/FingerprintRecord$Position;Landroid/graphics/Bitmap;I)V", __args);
					return;
				}

				if (id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Landroid_graphics_Bitmap_I == IntPtr.Zero)
					id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Landroid_graphics_Bitmap_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/credenceid/database/FingerprintRecord$Position;Landroid/graphics/Bitmap;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Landroid_graphics_Bitmap_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Landroid_graphics_Bitmap_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Landroid_graphics_Bitmap_ILandroid_graphics_Bitmap_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.database']/class[@name='FingerprintRecord']/constructor[@name='FingerprintRecord' and count(parameter)=5 and parameter[1][@type='com.credenceid.database.FingerprintRecord.Position'] and parameter[2][@type='android.graphics.Bitmap'] and parameter[3][@type='int'] and parameter[4][@type='android.graphics.Bitmap'] and parameter[5][@type='int']]"
		[Register (".ctor", "(Lcom/credenceid/database/FingerprintRecord$Position;Landroid/graphics/Bitmap;ILandroid/graphics/Bitmap;I)V", "")]
		public unsafe FingerprintRecord (global::Com.Credenceid.Database.FingerprintRecord.Position position, global::Android.Graphics.Bitmap imageOne, int imageOneDPI, global::Android.Graphics.Bitmap imageTwo, int imageTwoDPI)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (position);
				__args [1] = new JValue (imageOne);
				__args [2] = new JValue (imageOneDPI);
				__args [3] = new JValue (imageTwo);
				__args [4] = new JValue (imageTwoDPI);
				if (((object) this).GetType () != typeof (FingerprintRecord)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/credenceid/database/FingerprintRecord$Position;Landroid/graphics/Bitmap;ILandroid/graphics/Bitmap;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/credenceid/database/FingerprintRecord$Position;Landroid/graphics/Bitmap;ILandroid/graphics/Bitmap;I)V", __args);
					return;
				}

				if (id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Landroid_graphics_Bitmap_ILandroid_graphics_Bitmap_I == IntPtr.Zero)
					id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Landroid_graphics_Bitmap_ILandroid_graphics_Bitmap_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/credenceid/database/FingerprintRecord$Position;Landroid/graphics/Bitmap;ILandroid/graphics/Bitmap;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Landroid_graphics_Bitmap_ILandroid_graphics_Bitmap_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Landroid_graphics_Bitmap_ILandroid_graphics_Bitmap_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Landroid_graphics_Bitmap_ILandroid_graphics_Bitmap_ILandroid_graphics_Bitmap_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.database']/class[@name='FingerprintRecord']/constructor[@name='FingerprintRecord' and count(parameter)=7 and parameter[1][@type='com.credenceid.database.FingerprintRecord.Position'] and parameter[2][@type='android.graphics.Bitmap'] and parameter[3][@type='int'] and parameter[4][@type='android.graphics.Bitmap'] and parameter[5][@type='int'] and parameter[6][@type='android.graphics.Bitmap'] and parameter[7][@type='int']]"
		[Register (".ctor", "(Lcom/credenceid/database/FingerprintRecord$Position;Landroid/graphics/Bitmap;ILandroid/graphics/Bitmap;ILandroid/graphics/Bitmap;I)V", "")]
		public unsafe FingerprintRecord (global::Com.Credenceid.Database.FingerprintRecord.Position position, global::Android.Graphics.Bitmap imageOne, int imageOneDPI, global::Android.Graphics.Bitmap imageTwo, int imageTwoDPI, global::Android.Graphics.Bitmap imageThree, int imageThreeDPI)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (position);
				__args [1] = new JValue (imageOne);
				__args [2] = new JValue (imageOneDPI);
				__args [3] = new JValue (imageTwo);
				__args [4] = new JValue (imageTwoDPI);
				__args [5] = new JValue (imageThree);
				__args [6] = new JValue (imageThreeDPI);
				if (((object) this).GetType () != typeof (FingerprintRecord)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/credenceid/database/FingerprintRecord$Position;Landroid/graphics/Bitmap;ILandroid/graphics/Bitmap;ILandroid/graphics/Bitmap;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/credenceid/database/FingerprintRecord$Position;Landroid/graphics/Bitmap;ILandroid/graphics/Bitmap;ILandroid/graphics/Bitmap;I)V", __args);
					return;
				}

				if (id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Landroid_graphics_Bitmap_ILandroid_graphics_Bitmap_ILandroid_graphics_Bitmap_I == IntPtr.Zero)
					id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Landroid_graphics_Bitmap_ILandroid_graphics_Bitmap_ILandroid_graphics_Bitmap_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/credenceid/database/FingerprintRecord$Position;Landroid/graphics/Bitmap;ILandroid/graphics/Bitmap;ILandroid/graphics/Bitmap;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Landroid_graphics_Bitmap_ILandroid_graphics_Bitmap_ILandroid_graphics_Bitmap_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Landroid_graphics_Bitmap_ILandroid_graphics_Bitmap_ILandroid_graphics_Bitmap_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.database']/class[@name='FingerprintRecord']/constructor[@name='FingerprintRecord' and count(parameter)=2 and parameter[1][@type='com.credenceid.database.FingerprintRecord.Position'] and parameter[2][@type='byte[]']]"
		[Register (".ctor", "(Lcom/credenceid/database/FingerprintRecord$Position;[B)V", "")]
		public unsafe FingerprintRecord (global::Com.Credenceid.Database.FingerprintRecord.Position position, byte[] imageOne)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_imageOne = JNIEnv.NewArray (imageOne);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (position);
				__args [1] = new JValue (native_imageOne);
				if (((object) this).GetType () != typeof (FingerprintRecord)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/credenceid/database/FingerprintRecord$Position;[B)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/credenceid/database/FingerprintRecord$Position;[B)V", __args);
					return;
				}

				if (id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_arrayB == IntPtr.Zero)
					id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_arrayB = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/credenceid/database/FingerprintRecord$Position;[B)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_arrayB, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_arrayB, __args);
			} finally {
				if (imageOne != null) {
					JNIEnv.CopyArray (native_imageOne, imageOne);
					JNIEnv.DeleteLocalRef (native_imageOne);
				}
			}
		}

		static IntPtr id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_arrayBarrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.database']/class[@name='FingerprintRecord']/constructor[@name='FingerprintRecord' and count(parameter)=3 and parameter[1][@type='com.credenceid.database.FingerprintRecord.Position'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
		[Register (".ctor", "(Lcom/credenceid/database/FingerprintRecord$Position;[B[B)V", "")]
		public unsafe FingerprintRecord (global::Com.Credenceid.Database.FingerprintRecord.Position position, byte[] imageOne, byte[] imageTwo)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_imageOne = JNIEnv.NewArray (imageOne);
			IntPtr native_imageTwo = JNIEnv.NewArray (imageTwo);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (position);
				__args [1] = new JValue (native_imageOne);
				__args [2] = new JValue (native_imageTwo);
				if (((object) this).GetType () != typeof (FingerprintRecord)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/credenceid/database/FingerprintRecord$Position;[B[B)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/credenceid/database/FingerprintRecord$Position;[B[B)V", __args);
					return;
				}

				if (id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_arrayBarrayB == IntPtr.Zero)
					id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_arrayBarrayB = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/credenceid/database/FingerprintRecord$Position;[B[B)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_arrayBarrayB, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_arrayBarrayB, __args);
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

		static IntPtr id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_arrayBarrayBarrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.database']/class[@name='FingerprintRecord']/constructor[@name='FingerprintRecord' and count(parameter)=4 and parameter[1][@type='com.credenceid.database.FingerprintRecord.Position'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]']]"
		[Register (".ctor", "(Lcom/credenceid/database/FingerprintRecord$Position;[B[B[B)V", "")]
		public unsafe FingerprintRecord (global::Com.Credenceid.Database.FingerprintRecord.Position position, byte[] imageOne, byte[] imageTwo, byte[] imageThree)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_imageOne = JNIEnv.NewArray (imageOne);
			IntPtr native_imageTwo = JNIEnv.NewArray (imageTwo);
			IntPtr native_imageThree = JNIEnv.NewArray (imageThree);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (position);
				__args [1] = new JValue (native_imageOne);
				__args [2] = new JValue (native_imageTwo);
				__args [3] = new JValue (native_imageThree);
				if (((object) this).GetType () != typeof (FingerprintRecord)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/credenceid/database/FingerprintRecord$Position;[B[B[B)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/credenceid/database/FingerprintRecord$Position;[B[B[B)V", __args);
					return;
				}

				if (id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_arrayBarrayBarrayB == IntPtr.Zero)
					id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_arrayBarrayBarrayB = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/credenceid/database/FingerprintRecord$Position;[B[B[B)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_arrayBarrayBarrayB, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_arrayBarrayBarrayB, __args);
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

		static IntPtr id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_arrayBI;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.database']/class[@name='FingerprintRecord']/constructor[@name='FingerprintRecord' and count(parameter)=3 and parameter[1][@type='com.credenceid.database.FingerprintRecord.Position'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Lcom/credenceid/database/FingerprintRecord$Position;[BI)V", "")]
		public unsafe FingerprintRecord (global::Com.Credenceid.Database.FingerprintRecord.Position position, byte[] imageOne, int imageOneDPI)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_imageOne = JNIEnv.NewArray (imageOne);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (position);
				__args [1] = new JValue (native_imageOne);
				__args [2] = new JValue (imageOneDPI);
				if (((object) this).GetType () != typeof (FingerprintRecord)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/credenceid/database/FingerprintRecord$Position;[BI)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/credenceid/database/FingerprintRecord$Position;[BI)V", __args);
					return;
				}

				if (id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_arrayBI == IntPtr.Zero)
					id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_arrayBI = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/credenceid/database/FingerprintRecord$Position;[BI)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_arrayBI, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_arrayBI, __args);
			} finally {
				if (imageOne != null) {
					JNIEnv.CopyArray (native_imageOne, imageOne);
					JNIEnv.DeleteLocalRef (native_imageOne);
				}
			}
		}

		static IntPtr id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_arrayBIarrayBI;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.database']/class[@name='FingerprintRecord']/constructor[@name='FingerprintRecord' and count(parameter)=5 and parameter[1][@type='com.credenceid.database.FingerprintRecord.Position'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='int']]"
		[Register (".ctor", "(Lcom/credenceid/database/FingerprintRecord$Position;[BI[BI)V", "")]
		public unsafe FingerprintRecord (global::Com.Credenceid.Database.FingerprintRecord.Position position, byte[] imageOne, int imageOneDPI, byte[] imageTwo, int imageTwoDPI)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_imageOne = JNIEnv.NewArray (imageOne);
			IntPtr native_imageTwo = JNIEnv.NewArray (imageTwo);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (position);
				__args [1] = new JValue (native_imageOne);
				__args [2] = new JValue (imageOneDPI);
				__args [3] = new JValue (native_imageTwo);
				__args [4] = new JValue (imageTwoDPI);
				if (((object) this).GetType () != typeof (FingerprintRecord)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/credenceid/database/FingerprintRecord$Position;[BI[BI)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/credenceid/database/FingerprintRecord$Position;[BI[BI)V", __args);
					return;
				}

				if (id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_arrayBIarrayBI == IntPtr.Zero)
					id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_arrayBIarrayBI = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/credenceid/database/FingerprintRecord$Position;[BI[BI)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_arrayBIarrayBI, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_arrayBIarrayBI, __args);
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

		static IntPtr id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_arrayBIarrayBIarrayBI;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.database']/class[@name='FingerprintRecord']/constructor[@name='FingerprintRecord' and count(parameter)=7 and parameter[1][@type='com.credenceid.database.FingerprintRecord.Position'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='int'] and parameter[6][@type='byte[]'] and parameter[7][@type='int']]"
		[Register (".ctor", "(Lcom/credenceid/database/FingerprintRecord$Position;[BI[BI[BI)V", "")]
		public unsafe FingerprintRecord (global::Com.Credenceid.Database.FingerprintRecord.Position position, byte[] imageOne, int imageOneDPI, byte[] imageTwo, int imageTwoDPI, byte[] imageThree, int imageThreeDPI)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_imageOne = JNIEnv.NewArray (imageOne);
			IntPtr native_imageTwo = JNIEnv.NewArray (imageTwo);
			IntPtr native_imageThree = JNIEnv.NewArray (imageThree);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (position);
				__args [1] = new JValue (native_imageOne);
				__args [2] = new JValue (imageOneDPI);
				__args [3] = new JValue (native_imageTwo);
				__args [4] = new JValue (imageTwoDPI);
				__args [5] = new JValue (native_imageThree);
				__args [6] = new JValue (imageThreeDPI);
				if (((object) this).GetType () != typeof (FingerprintRecord)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/credenceid/database/FingerprintRecord$Position;[BI[BI[BI)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/credenceid/database/FingerprintRecord$Position;[BI[BI[BI)V", __args);
					return;
				}

				if (id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_arrayBIarrayBIarrayBI == IntPtr.Zero)
					id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_arrayBIarrayBIarrayBI = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/credenceid/database/FingerprintRecord$Position;[BI[BI[BI)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_arrayBIarrayBIarrayBI, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_arrayBIarrayBIarrayBI, __args);
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

		static IntPtr id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.database']/class[@name='FingerprintRecord']/constructor[@name='FingerprintRecord' and count(parameter)=2 and parameter[1][@type='com.credenceid.database.FingerprintRecord.Position'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/credenceid/database/FingerprintRecord$Position;Ljava/lang/String;)V", "")]
		public unsafe FingerprintRecord (global::Com.Credenceid.Database.FingerprintRecord.Position position, string imageOneAbsPath)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_imageOneAbsPath = JNIEnv.NewString (imageOneAbsPath);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (position);
				__args [1] = new JValue (native_imageOneAbsPath);
				if (((object) this).GetType () != typeof (FingerprintRecord)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/credenceid/database/FingerprintRecord$Position;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/credenceid/database/FingerprintRecord$Position;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/credenceid/database/FingerprintRecord$Position;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_imageOneAbsPath);
			}
		}

		static IntPtr id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Ljava_lang_String_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.database']/class[@name='FingerprintRecord']/constructor[@name='FingerprintRecord' and count(parameter)=3 and parameter[1][@type='com.credenceid.database.FingerprintRecord.Position'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Lcom/credenceid/database/FingerprintRecord$Position;Ljava/lang/String;I)V", "")]
		public unsafe FingerprintRecord (global::Com.Credenceid.Database.FingerprintRecord.Position position, string imageOneAbsPath, int imageOneDPI)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_imageOneAbsPath = JNIEnv.NewString (imageOneAbsPath);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (position);
				__args [1] = new JValue (native_imageOneAbsPath);
				__args [2] = new JValue (imageOneDPI);
				if (((object) this).GetType () != typeof (FingerprintRecord)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/credenceid/database/FingerprintRecord$Position;Ljava/lang/String;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/credenceid/database/FingerprintRecord$Position;Ljava/lang/String;I)V", __args);
					return;
				}

				if (id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Ljava_lang_String_I == IntPtr.Zero)
					id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/credenceid/database/FingerprintRecord$Position;Ljava/lang/String;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Ljava_lang_String_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Ljava_lang_String_I, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_imageOneAbsPath);
			}
		}

		static IntPtr id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Ljava_lang_String_ILjava_lang_String_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.database']/class[@name='FingerprintRecord']/constructor[@name='FingerprintRecord' and count(parameter)=5 and parameter[1][@type='com.credenceid.database.FingerprintRecord.Position'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='int']]"
		[Register (".ctor", "(Lcom/credenceid/database/FingerprintRecord$Position;Ljava/lang/String;ILjava/lang/String;I)V", "")]
		public unsafe FingerprintRecord (global::Com.Credenceid.Database.FingerprintRecord.Position position, string imageOneAbsPath, int imageOneDPI, string imageTwoAbsPath, int imageTwoDPI)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_imageOneAbsPath = JNIEnv.NewString (imageOneAbsPath);
			IntPtr native_imageTwoAbsPath = JNIEnv.NewString (imageTwoAbsPath);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (position);
				__args [1] = new JValue (native_imageOneAbsPath);
				__args [2] = new JValue (imageOneDPI);
				__args [3] = new JValue (native_imageTwoAbsPath);
				__args [4] = new JValue (imageTwoDPI);
				if (((object) this).GetType () != typeof (FingerprintRecord)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/credenceid/database/FingerprintRecord$Position;Ljava/lang/String;ILjava/lang/String;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/credenceid/database/FingerprintRecord$Position;Ljava/lang/String;ILjava/lang/String;I)V", __args);
					return;
				}

				if (id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Ljava_lang_String_ILjava_lang_String_I == IntPtr.Zero)
					id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Ljava_lang_String_ILjava_lang_String_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/credenceid/database/FingerprintRecord$Position;Ljava/lang/String;ILjava/lang/String;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Ljava_lang_String_ILjava_lang_String_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Ljava_lang_String_ILjava_lang_String_I, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_imageOneAbsPath);
				JNIEnv.DeleteLocalRef (native_imageTwoAbsPath);
			}
		}

		static IntPtr id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Ljava_lang_String_ILjava_lang_String_ILjava_lang_String_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.database']/class[@name='FingerprintRecord']/constructor[@name='FingerprintRecord' and count(parameter)=7 and parameter[1][@type='com.credenceid.database.FingerprintRecord.Position'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='int'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='int']]"
		[Register (".ctor", "(Lcom/credenceid/database/FingerprintRecord$Position;Ljava/lang/String;ILjava/lang/String;ILjava/lang/String;I)V", "")]
		public unsafe FingerprintRecord (global::Com.Credenceid.Database.FingerprintRecord.Position position, string imageOneAbsPath, int imageOneDPI, string imageTwoAbsPath, int imageTwoDPI, string imageThreeAbsPath, int imageThreeDPI)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_imageOneAbsPath = JNIEnv.NewString (imageOneAbsPath);
			IntPtr native_imageTwoAbsPath = JNIEnv.NewString (imageTwoAbsPath);
			IntPtr native_imageThreeAbsPath = JNIEnv.NewString (imageThreeAbsPath);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (position);
				__args [1] = new JValue (native_imageOneAbsPath);
				__args [2] = new JValue (imageOneDPI);
				__args [3] = new JValue (native_imageTwoAbsPath);
				__args [4] = new JValue (imageTwoDPI);
				__args [5] = new JValue (native_imageThreeAbsPath);
				__args [6] = new JValue (imageThreeDPI);
				if (((object) this).GetType () != typeof (FingerprintRecord)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/credenceid/database/FingerprintRecord$Position;Ljava/lang/String;ILjava/lang/String;ILjava/lang/String;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/credenceid/database/FingerprintRecord$Position;Ljava/lang/String;ILjava/lang/String;ILjava/lang/String;I)V", __args);
					return;
				}

				if (id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Ljava_lang_String_ILjava_lang_String_ILjava_lang_String_I == IntPtr.Zero)
					id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Ljava_lang_String_ILjava_lang_String_ILjava_lang_String_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/credenceid/database/FingerprintRecord$Position;Ljava/lang/String;ILjava/lang/String;ILjava/lang/String;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Ljava_lang_String_ILjava_lang_String_ILjava_lang_String_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Ljava_lang_String_ILjava_lang_String_ILjava_lang_String_I, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_imageOneAbsPath);
				JNIEnv.DeleteLocalRef (native_imageTwoAbsPath);
				JNIEnv.DeleteLocalRef (native_imageThreeAbsPath);
			}
		}

		static IntPtr id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.database']/class[@name='FingerprintRecord']/constructor[@name='FingerprintRecord' and count(parameter)=3 and parameter[1][@type='com.credenceid.database.FingerprintRecord.Position'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/credenceid/database/FingerprintRecord$Position;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe FingerprintRecord (global::Com.Credenceid.Database.FingerprintRecord.Position position, string imageOneAbsPath, string imageTwoAbsPath)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_imageOneAbsPath = JNIEnv.NewString (imageOneAbsPath);
			IntPtr native_imageTwoAbsPath = JNIEnv.NewString (imageTwoAbsPath);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (position);
				__args [1] = new JValue (native_imageOneAbsPath);
				__args [2] = new JValue (native_imageTwoAbsPath);
				if (((object) this).GetType () != typeof (FingerprintRecord)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/credenceid/database/FingerprintRecord$Position;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/credenceid/database/FingerprintRecord$Position;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/credenceid/database/FingerprintRecord$Position;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_imageOneAbsPath);
				JNIEnv.DeleteLocalRef (native_imageTwoAbsPath);
			}
		}

		static IntPtr id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.database']/class[@name='FingerprintRecord']/constructor[@name='FingerprintRecord' and count(parameter)=4 and parameter[1][@type='com.credenceid.database.FingerprintRecord.Position'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/credenceid/database/FingerprintRecord$Position;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe FingerprintRecord (global::Com.Credenceid.Database.FingerprintRecord.Position position, string imageOneAbsPath, string imageTwoAbsPath, string imageThreeAbsPath)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_imageOneAbsPath = JNIEnv.NewString (imageOneAbsPath);
			IntPtr native_imageTwoAbsPath = JNIEnv.NewString (imageTwoAbsPath);
			IntPtr native_imageThreeAbsPath = JNIEnv.NewString (imageThreeAbsPath);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (position);
				__args [1] = new JValue (native_imageOneAbsPath);
				__args [2] = new JValue (native_imageTwoAbsPath);
				__args [3] = new JValue (native_imageThreeAbsPath);
				if (((object) this).GetType () != typeof (FingerprintRecord)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/credenceid/database/FingerprintRecord$Position;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/credenceid/database/FingerprintRecord$Position;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/credenceid/database/FingerprintRecord$Position;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_credenceid_database_FingerprintRecord_Position_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_imageOneAbsPath);
				JNIEnv.DeleteLocalRef (native_imageTwoAbsPath);
				JNIEnv.DeleteLocalRef (native_imageThreeAbsPath);
			}
		}

		static Delegate cb_getImageDPIs;
#pragma warning disable 0169
		static Delegate GetGetImageDPIsHandler ()
		{
			if (cb_getImageDPIs == null)
				cb_getImageDPIs = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetImageDPIs);
			return cb_getImageDPIs;
		}

		static IntPtr n_GetImageDPIs (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.FingerprintRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Java.Lang.Integer>.ToLocalJniHandle (__this.ImageDPIs);
		}
#pragma warning restore 0169

		static IntPtr id_getImageDPIs;
		public virtual unsafe global::System.Collections.Generic.IList<global::Java.Lang.Integer> ImageDPIs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/class[@name='FingerprintRecord']/method[@name='getImageDPIs' and count(parameter)=0]"
			[Register ("getImageDPIs", "()Ljava/util/List;", "GetGetImageDPIsHandler")]
			get {
				if (id_getImageDPIs == IntPtr.Zero)
					id_getImageDPIs = JNIEnv.GetMethodID (class_ref, "getImageDPIs", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Java.Lang.Integer>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getImageDPIs), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Java.Lang.Integer>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImageDPIs", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getImageDPI_Lcom_credenceid_database_ImageIndex_;
#pragma warning disable 0169
		static Delegate GetGetImageDPI_Lcom_credenceid_database_ImageIndex_Handler ()
		{
			if (cb_getImageDPI_Lcom_credenceid_database_ImageIndex_ == null)
				cb_getImageDPI_Lcom_credenceid_database_ImageIndex_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_GetImageDPI_Lcom_credenceid_database_ImageIndex_);
			return cb_getImageDPI_Lcom_credenceid_database_ImageIndex_;
		}

		static int n_GetImageDPI_Lcom_credenceid_database_ImageIndex_ (IntPtr jnienv, IntPtr native__this, IntPtr native_index)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.FingerprintRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var index = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.ImageIndex> (native_index, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetImageDPI (index);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getImageDPI_Lcom_credenceid_database_ImageIndex_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/class[@name='FingerprintRecord']/method[@name='getImageDPI' and count(parameter)=1 and parameter[1][@type='com.credenceid.database.ImageIndex']]"
		[Register ("getImageDPI", "(Lcom/credenceid/database/ImageIndex;)I", "GetGetImageDPI_Lcom_credenceid_database_ImageIndex_Handler")]
		public virtual unsafe int GetImageDPI (global::Com.Credenceid.Database.ImageIndex index)
		{
			if (id_getImageDPI_Lcom_credenceid_database_ImageIndex_ == IntPtr.Zero)
				id_getImageDPI_Lcom_credenceid_database_ImageIndex_ = JNIEnv.GetMethodID (class_ref, "getImageDPI", "(Lcom/credenceid/database/ImageIndex;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (index);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getImageDPI_Lcom_credenceid_database_ImageIndex_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImageDPI", "(Lcom/credenceid/database/ImageIndex;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getPosition;
#pragma warning disable 0169
		static Delegate GetGetPositionHandler ()
		{
			if (cb_getPosition == null)
				cb_getPosition = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPosition);
			return cb_getPosition;
		}

		static IntPtr n_GetPosition (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.FingerprintRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetPosition ());
		}
#pragma warning restore 0169

		static IntPtr id_getPosition;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/class[@name='FingerprintRecord']/method[@name='getPosition' and count(parameter)=0]"
		[Register ("getPosition", "()Lcom/credenceid/database/FingerprintRecord$Position;", "GetGetPositionHandler")]
		public virtual unsafe global::Com.Credenceid.Database.FingerprintRecord.Position GetPosition ()
		{
			if (id_getPosition == IntPtr.Zero)
				id_getPosition = JNIEnv.GetMethodID (class_ref, "getPosition", "()Lcom/credenceid/database/FingerprintRecord$Position;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.FingerprintRecord.Position> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPosition), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.FingerprintRecord.Position> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPosition", "()Lcom/credenceid/database/FingerprintRecord$Position;")), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.FingerprintRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetTemplate ());
		}
#pragma warning restore 0169

		static IntPtr id_getTemplate;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/class[@name='FingerprintRecord']/method[@name='getTemplate' and count(parameter)=0]"
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

		static Delegate cb_setDPI_Lcom_credenceid_database_ImageIndex_I;
#pragma warning disable 0169
		static Delegate GetSetDPI_Lcom_credenceid_database_ImageIndex_IHandler ()
		{
			if (cb_setDPI_Lcom_credenceid_database_ImageIndex_I == null)
				cb_setDPI_Lcom_credenceid_database_ImageIndex_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_SetDPI_Lcom_credenceid_database_ImageIndex_I);
			return cb_setDPI_Lcom_credenceid_database_ImageIndex_I;
		}

		static void n_SetDPI_Lcom_credenceid_database_ImageIndex_I (IntPtr jnienv, IntPtr native__this, IntPtr native_index, int DPI)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.FingerprintRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var index = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.ImageIndex> (native_index, JniHandleOwnership.DoNotTransfer);
			__this.SetDPI (index, DPI);
		}
#pragma warning restore 0169

		static IntPtr id_setDPI_Lcom_credenceid_database_ImageIndex_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/class[@name='FingerprintRecord']/method[@name='setDPI' and count(parameter)=2 and parameter[1][@type='com.credenceid.database.ImageIndex'] and parameter[2][@type='int']]"
		[Register ("setDPI", "(Lcom/credenceid/database/ImageIndex;I)V", "GetSetDPI_Lcom_credenceid_database_ImageIndex_IHandler")]
		public virtual unsafe void SetDPI (global::Com.Credenceid.Database.ImageIndex index, int DPI)
		{
			if (id_setDPI_Lcom_credenceid_database_ImageIndex_I == IntPtr.Zero)
				id_setDPI_Lcom_credenceid_database_ImageIndex_I = JNIEnv.GetMethodID (class_ref, "setDPI", "(Lcom/credenceid/database/ImageIndex;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (index);
				__args [1] = new JValue (DPI);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDPI_Lcom_credenceid_database_ImageIndex_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDPI", "(Lcom/credenceid/database/ImageIndex;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setImage_Lcom_credenceid_database_ImageIndex_Landroid_graphics_Bitmap_I;
#pragma warning disable 0169
		static Delegate GetSetImage_Lcom_credenceid_database_ImageIndex_Landroid_graphics_Bitmap_IHandler ()
		{
			if (cb_setImage_Lcom_credenceid_database_ImageIndex_Landroid_graphics_Bitmap_I == null)
				cb_setImage_Lcom_credenceid_database_ImageIndex_Landroid_graphics_Bitmap_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLI_Z) n_SetImage_Lcom_credenceid_database_ImageIndex_Landroid_graphics_Bitmap_I);
			return cb_setImage_Lcom_credenceid_database_ImageIndex_Landroid_graphics_Bitmap_I;
		}

		static bool n_SetImage_Lcom_credenceid_database_ImageIndex_Landroid_graphics_Bitmap_I (IntPtr jnienv, IntPtr native__this, IntPtr native_index, IntPtr native_image, int DPI)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.FingerprintRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var index = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.ImageIndex> (native_index, JniHandleOwnership.DoNotTransfer);
			var image = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_image, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetImage (index, image, DPI);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setImage_Lcom_credenceid_database_ImageIndex_Landroid_graphics_Bitmap_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/class[@name='FingerprintRecord']/method[@name='setImage' and count(parameter)=3 and parameter[1][@type='com.credenceid.database.ImageIndex'] and parameter[2][@type='android.graphics.Bitmap'] and parameter[3][@type='int']]"
		[Register ("setImage", "(Lcom/credenceid/database/ImageIndex;Landroid/graphics/Bitmap;I)Z", "GetSetImage_Lcom_credenceid_database_ImageIndex_Landroid_graphics_Bitmap_IHandler")]
		public virtual unsafe bool SetImage (global::Com.Credenceid.Database.ImageIndex index, global::Android.Graphics.Bitmap image, int DPI)
		{
			if (id_setImage_Lcom_credenceid_database_ImageIndex_Landroid_graphics_Bitmap_I == IntPtr.Zero)
				id_setImage_Lcom_credenceid_database_ImageIndex_Landroid_graphics_Bitmap_I = JNIEnv.GetMethodID (class_ref, "setImage", "(Lcom/credenceid/database/ImageIndex;Landroid/graphics/Bitmap;I)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (index);
				__args [1] = new JValue (image);
				__args [2] = new JValue (DPI);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_setImage_Lcom_credenceid_database_ImageIndex_Landroid_graphics_Bitmap_I, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setImage", "(Lcom/credenceid/database/ImageIndex;Landroid/graphics/Bitmap;I)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setImage_Lcom_credenceid_database_ImageIndex_arrayBI;
#pragma warning disable 0169
		static Delegate GetSetImage_Lcom_credenceid_database_ImageIndex_arrayBIHandler ()
		{
			if (cb_setImage_Lcom_credenceid_database_ImageIndex_arrayBI == null)
				cb_setImage_Lcom_credenceid_database_ImageIndex_arrayBI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLI_Z) n_SetImage_Lcom_credenceid_database_ImageIndex_arrayBI);
			return cb_setImage_Lcom_credenceid_database_ImageIndex_arrayBI;
		}

		static bool n_SetImage_Lcom_credenceid_database_ImageIndex_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_index, IntPtr native_image, int DPI)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.FingerprintRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var index = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.ImageIndex> (native_index, JniHandleOwnership.DoNotTransfer);
			var image = (byte[]) JNIEnv.GetArray (native_image, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.SetImage (index, image, DPI);
			if (image != null)
				JNIEnv.CopyArray (image, native_image);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setImage_Lcom_credenceid_database_ImageIndex_arrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/class[@name='FingerprintRecord']/method[@name='setImage' and count(parameter)=3 and parameter[1][@type='com.credenceid.database.ImageIndex'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
		[Register ("setImage", "(Lcom/credenceid/database/ImageIndex;[BI)Z", "GetSetImage_Lcom_credenceid_database_ImageIndex_arrayBIHandler")]
		public virtual unsafe bool SetImage (global::Com.Credenceid.Database.ImageIndex index, byte[] image, int DPI)
		{
			if (id_setImage_Lcom_credenceid_database_ImageIndex_arrayBI == IntPtr.Zero)
				id_setImage_Lcom_credenceid_database_ImageIndex_arrayBI = JNIEnv.GetMethodID (class_ref, "setImage", "(Lcom/credenceid/database/ImageIndex;[BI)Z");
			IntPtr native_image = JNIEnv.NewArray (image);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (index);
				__args [1] = new JValue (native_image);
				__args [2] = new JValue (DPI);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_setImage_Lcom_credenceid_database_ImageIndex_arrayBI, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setImage", "(Lcom/credenceid/database/ImageIndex;[BI)Z"), __args);
				return __ret;
			} finally {
				if (image != null) {
					JNIEnv.CopyArray (native_image, image);
					JNIEnv.DeleteLocalRef (native_image);
				}
			}
		}

		static Delegate cb_setImage_Lcom_credenceid_database_ImageIndex_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetSetImage_Lcom_credenceid_database_ImageIndex_Ljava_lang_String_IHandler ()
		{
			if (cb_setImage_Lcom_credenceid_database_ImageIndex_Ljava_lang_String_I == null)
				cb_setImage_Lcom_credenceid_database_ImageIndex_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLI_Z) n_SetImage_Lcom_credenceid_database_ImageIndex_Ljava_lang_String_I);
			return cb_setImage_Lcom_credenceid_database_ImageIndex_Ljava_lang_String_I;
		}

		static bool n_SetImage_Lcom_credenceid_database_ImageIndex_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_index, IntPtr native_imageAbsFilePath, int DPI)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.FingerprintRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var index = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.ImageIndex> (native_index, JniHandleOwnership.DoNotTransfer);
			var imageAbsFilePath = JNIEnv.GetString (native_imageAbsFilePath, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetImage (index, imageAbsFilePath, DPI);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setImage_Lcom_credenceid_database_ImageIndex_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/class[@name='FingerprintRecord']/method[@name='setImage' and count(parameter)=3 and parameter[1][@type='com.credenceid.database.ImageIndex'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("setImage", "(Lcom/credenceid/database/ImageIndex;Ljava/lang/String;I)Z", "GetSetImage_Lcom_credenceid_database_ImageIndex_Ljava_lang_String_IHandler")]
		public virtual unsafe bool SetImage (global::Com.Credenceid.Database.ImageIndex index, string imageAbsFilePath, int DPI)
		{
			if (id_setImage_Lcom_credenceid_database_ImageIndex_Ljava_lang_String_I == IntPtr.Zero)
				id_setImage_Lcom_credenceid_database_ImageIndex_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "setImage", "(Lcom/credenceid/database/ImageIndex;Ljava/lang/String;I)Z");
			IntPtr native_imageAbsFilePath = JNIEnv.NewString (imageAbsFilePath);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (index);
				__args [1] = new JValue (native_imageAbsFilePath);
				__args [2] = new JValue (DPI);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_setImage_Lcom_credenceid_database_ImageIndex_Ljava_lang_String_I, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setImage", "(Lcom/credenceid/database/ImageIndex;Ljava/lang/String;I)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_imageAbsFilePath);
			}
		}

		static Delegate cb_setPosition_Lcom_credenceid_database_FingerprintRecord_Position_;
#pragma warning disable 0169
		static Delegate GetSetPosition_Lcom_credenceid_database_FingerprintRecord_Position_Handler ()
		{
			if (cb_setPosition_Lcom_credenceid_database_FingerprintRecord_Position_ == null)
				cb_setPosition_Lcom_credenceid_database_FingerprintRecord_Position_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetPosition_Lcom_credenceid_database_FingerprintRecord_Position_);
			return cb_setPosition_Lcom_credenceid_database_FingerprintRecord_Position_;
		}

		static void n_SetPosition_Lcom_credenceid_database_FingerprintRecord_Position_ (IntPtr jnienv, IntPtr native__this, IntPtr native_position)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.FingerprintRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var position = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.FingerprintRecord.Position> (native_position, JniHandleOwnership.DoNotTransfer);
			__this.SetPosition (position);
		}
#pragma warning restore 0169

		static IntPtr id_setPosition_Lcom_credenceid_database_FingerprintRecord_Position_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/class[@name='FingerprintRecord']/method[@name='setPosition' and count(parameter)=1 and parameter[1][@type='com.credenceid.database.FingerprintRecord.Position']]"
		[Register ("setPosition", "(Lcom/credenceid/database/FingerprintRecord$Position;)V", "GetSetPosition_Lcom_credenceid_database_FingerprintRecord_Position_Handler")]
		public virtual unsafe void SetPosition (global::Com.Credenceid.Database.FingerprintRecord.Position position)
		{
			if (id_setPosition_Lcom_credenceid_database_FingerprintRecord_Position_ == IntPtr.Zero)
				id_setPosition_Lcom_credenceid_database_FingerprintRecord_Position_ = JNIEnv.GetMethodID (class_ref, "setPosition", "(Lcom/credenceid/database/FingerprintRecord$Position;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (position);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPosition_Lcom_credenceid_database_FingerprintRecord_Position_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPosition", "(Lcom/credenceid/database/FingerprintRecord$Position;)V"), __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.FingerprintRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var template = (byte[]) JNIEnv.GetArray (native_template, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetTemplate (template);
			if (template != null)
				JNIEnv.CopyArray (template, native_template);
		}
#pragma warning restore 0169

		static IntPtr id_setTemplate_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/class[@name='FingerprintRecord']/method[@name='setTemplate' and count(parameter)=1 and parameter[1][@type='byte[]']]"
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

	}
}
