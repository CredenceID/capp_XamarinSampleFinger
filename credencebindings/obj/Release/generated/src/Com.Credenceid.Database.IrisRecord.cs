using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Credenceid.Database {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.credenceid.database']/class[@name='IrisRecord']"
	[global::Android.Runtime.Register ("com/credenceid/database/IrisRecord", DoNotGenerateAcw=true)]
	public partial class IrisRecord : global::Com.Credenceid.Database.BiometricData {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.credenceid.database']/class[@name='IrisRecord.Position']"
		[global::Android.Runtime.Register ("com/credenceid/database/IrisRecord$Position", DoNotGenerateAcw=true)]
		public sealed partial class Position : global::Java.Lang.Enum {


			static IntPtr LEFT_EYE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.database']/class[@name='IrisRecord.Position']/field[@name='LEFT_EYE']"
			[Register ("LEFT_EYE")]
			public static global::Com.Credenceid.Database.IrisRecord.Position LeftEye {
				get {
					if (LEFT_EYE_jfieldId == IntPtr.Zero)
						LEFT_EYE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LEFT_EYE", "Lcom/credenceid/database/IrisRecord$Position;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LEFT_EYE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.IrisRecord.Position> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr RIGHT_EYE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.database']/class[@name='IrisRecord.Position']/field[@name='RIGHT_EYE']"
			[Register ("RIGHT_EYE")]
			public static global::Com.Credenceid.Database.IrisRecord.Position RightEye {
				get {
					if (RIGHT_EYE_jfieldId == IntPtr.Zero)
						RIGHT_EYE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RIGHT_EYE", "Lcom/credenceid/database/IrisRecord$Position;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RIGHT_EYE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.IrisRecord.Position> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TOTAL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.database']/class[@name='IrisRecord.Position']/field[@name='TOTAL']"
			[Register ("TOTAL")]
			public static global::Com.Credenceid.Database.IrisRecord.Position Total {
				get {
					if (TOTAL_jfieldId == IntPtr.Zero)
						TOTAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TOTAL", "Lcom/credenceid/database/IrisRecord$Position;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TOTAL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.IrisRecord.Position> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr UNKNOWN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.credenceid.database']/class[@name='IrisRecord.Position']/field[@name='UNKNOWN']"
			[Register ("UNKNOWN")]
			public static global::Com.Credenceid.Database.IrisRecord.Position Unknown {
				get {
					if (UNKNOWN_jfieldId == IntPtr.Zero)
						UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN", "Lcom/credenceid/database/IrisRecord$Position;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNKNOWN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.IrisRecord.Position> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/credenceid/database/IrisRecord$Position", ref java_class_handle);
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
				// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/class[@name='IrisRecord.Position']/method[@name='getValue' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/class[@name='IrisRecord.Position']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("valueOf", "(I)Lcom/credenceid/database/IrisRecord$Position;", "")]
			public static unsafe global::Com.Credenceid.Database.IrisRecord.Position ValueOf (int val)
			{
				if (id_valueOf_I == IntPtr.Zero)
					id_valueOf_I = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(I)Lcom/credenceid/database/IrisRecord$Position;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (val);
					return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.IrisRecord.Position> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_I, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/class[@name='IrisRecord.Position']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/credenceid/database/IrisRecord$Position;", "")]
			public static unsafe global::Com.Credenceid.Database.IrisRecord.Position ValueOf (string name)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/credenceid/database/IrisRecord$Position;");
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_name);
					global::Com.Credenceid.Database.IrisRecord.Position __ret = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.IrisRecord.Position> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/class[@name='IrisRecord.Position']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/credenceid/database/IrisRecord$Position;", "")]
			public static unsafe global::Com.Credenceid.Database.IrisRecord.Position[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/credenceid/database/IrisRecord$Position;");
				try {
					return (global::Com.Credenceid.Database.IrisRecord.Position[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Credenceid.Database.IrisRecord.Position));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/credenceid/database/IrisRecord", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IrisRecord); }
		}

		protected IrisRecord (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_credenceid_database_IrisRecord_Position_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.database']/class[@name='IrisRecord']/constructor[@name='IrisRecord' and count(parameter)=1 and parameter[1][@type='com.credenceid.database.IrisRecord.Position']]"
		[Register (".ctor", "(Lcom/credenceid/database/IrisRecord$Position;)V", "")]
		public unsafe IrisRecord (global::Com.Credenceid.Database.IrisRecord.Position position)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (position);
				if (((object) this).GetType () != typeof (IrisRecord)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/credenceid/database/IrisRecord$Position;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/credenceid/database/IrisRecord$Position;)V", __args);
					return;
				}

				if (id_ctor_Lcom_credenceid_database_IrisRecord_Position_ == IntPtr.Zero)
					id_ctor_Lcom_credenceid_database_IrisRecord_Position_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/credenceid/database/IrisRecord$Position;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_credenceid_database_IrisRecord_Position_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_credenceid_database_IrisRecord_Position_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lcom_credenceid_database_IrisRecord_Position_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.database']/class[@name='IrisRecord']/constructor[@name='IrisRecord' and count(parameter)=2 and parameter[1][@type='com.credenceid.database.IrisRecord.Position'] and parameter[2][@type='android.graphics.Bitmap']]"
		[Register (".ctor", "(Lcom/credenceid/database/IrisRecord$Position;Landroid/graphics/Bitmap;)V", "")]
		public unsafe IrisRecord (global::Com.Credenceid.Database.IrisRecord.Position position, global::Android.Graphics.Bitmap imageOne)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (position);
				__args [1] = new JValue (imageOne);
				if (((object) this).GetType () != typeof (IrisRecord)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/credenceid/database/IrisRecord$Position;Landroid/graphics/Bitmap;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/credenceid/database/IrisRecord$Position;Landroid/graphics/Bitmap;)V", __args);
					return;
				}

				if (id_ctor_Lcom_credenceid_database_IrisRecord_Position_Landroid_graphics_Bitmap_ == IntPtr.Zero)
					id_ctor_Lcom_credenceid_database_IrisRecord_Position_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/credenceid/database/IrisRecord$Position;Landroid/graphics/Bitmap;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_credenceid_database_IrisRecord_Position_Landroid_graphics_Bitmap_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_credenceid_database_IrisRecord_Position_Landroid_graphics_Bitmap_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lcom_credenceid_database_IrisRecord_Position_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.database']/class[@name='IrisRecord']/constructor[@name='IrisRecord' and count(parameter)=3 and parameter[1][@type='com.credenceid.database.IrisRecord.Position'] and parameter[2][@type='android.graphics.Bitmap'] and parameter[3][@type='android.graphics.Bitmap']]"
		[Register (".ctor", "(Lcom/credenceid/database/IrisRecord$Position;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;)V", "")]
		public unsafe IrisRecord (global::Com.Credenceid.Database.IrisRecord.Position position, global::Android.Graphics.Bitmap imageOne, global::Android.Graphics.Bitmap imageTwo)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (position);
				__args [1] = new JValue (imageOne);
				__args [2] = new JValue (imageTwo);
				if (((object) this).GetType () != typeof (IrisRecord)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/credenceid/database/IrisRecord$Position;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/credenceid/database/IrisRecord$Position;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;)V", __args);
					return;
				}

				if (id_ctor_Lcom_credenceid_database_IrisRecord_Position_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_ == IntPtr.Zero)
					id_ctor_Lcom_credenceid_database_IrisRecord_Position_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/credenceid/database/IrisRecord$Position;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_credenceid_database_IrisRecord_Position_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_credenceid_database_IrisRecord_Position_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lcom_credenceid_database_IrisRecord_Position_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.database']/class[@name='IrisRecord']/constructor[@name='IrisRecord' and count(parameter)=4 and parameter[1][@type='com.credenceid.database.IrisRecord.Position'] and parameter[2][@type='android.graphics.Bitmap'] and parameter[3][@type='android.graphics.Bitmap'] and parameter[4][@type='android.graphics.Bitmap']]"
		[Register (".ctor", "(Lcom/credenceid/database/IrisRecord$Position;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;)V", "")]
		public unsafe IrisRecord (global::Com.Credenceid.Database.IrisRecord.Position position, global::Android.Graphics.Bitmap imageOne, global::Android.Graphics.Bitmap imageTwo, global::Android.Graphics.Bitmap imageThree)
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
				if (((object) this).GetType () != typeof (IrisRecord)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/credenceid/database/IrisRecord$Position;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/credenceid/database/IrisRecord$Position;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;)V", __args);
					return;
				}

				if (id_ctor_Lcom_credenceid_database_IrisRecord_Position_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_ == IntPtr.Zero)
					id_ctor_Lcom_credenceid_database_IrisRecord_Position_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/credenceid/database/IrisRecord$Position;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_credenceid_database_IrisRecord_Position_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_credenceid_database_IrisRecord_Position_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lcom_credenceid_database_IrisRecord_Position_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.database']/class[@name='IrisRecord']/constructor[@name='IrisRecord' and count(parameter)=2 and parameter[1][@type='com.credenceid.database.IrisRecord.Position'] and parameter[2][@type='byte[]']]"
		[Register (".ctor", "(Lcom/credenceid/database/IrisRecord$Position;[B)V", "")]
		public unsafe IrisRecord (global::Com.Credenceid.Database.IrisRecord.Position position, byte[] imageOne)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_imageOne = JNIEnv.NewArray (imageOne);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (position);
				__args [1] = new JValue (native_imageOne);
				if (((object) this).GetType () != typeof (IrisRecord)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/credenceid/database/IrisRecord$Position;[B)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/credenceid/database/IrisRecord$Position;[B)V", __args);
					return;
				}

				if (id_ctor_Lcom_credenceid_database_IrisRecord_Position_arrayB == IntPtr.Zero)
					id_ctor_Lcom_credenceid_database_IrisRecord_Position_arrayB = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/credenceid/database/IrisRecord$Position;[B)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_credenceid_database_IrisRecord_Position_arrayB, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_credenceid_database_IrisRecord_Position_arrayB, __args);
			} finally {
				if (imageOne != null) {
					JNIEnv.CopyArray (native_imageOne, imageOne);
					JNIEnv.DeleteLocalRef (native_imageOne);
				}
			}
		}

		static IntPtr id_ctor_Lcom_credenceid_database_IrisRecord_Position_arrayBarrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.database']/class[@name='IrisRecord']/constructor[@name='IrisRecord' and count(parameter)=3 and parameter[1][@type='com.credenceid.database.IrisRecord.Position'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
		[Register (".ctor", "(Lcom/credenceid/database/IrisRecord$Position;[B[B)V", "")]
		public unsafe IrisRecord (global::Com.Credenceid.Database.IrisRecord.Position position, byte[] imageOne, byte[] imageTwo)
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
				if (((object) this).GetType () != typeof (IrisRecord)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/credenceid/database/IrisRecord$Position;[B[B)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/credenceid/database/IrisRecord$Position;[B[B)V", __args);
					return;
				}

				if (id_ctor_Lcom_credenceid_database_IrisRecord_Position_arrayBarrayB == IntPtr.Zero)
					id_ctor_Lcom_credenceid_database_IrisRecord_Position_arrayBarrayB = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/credenceid/database/IrisRecord$Position;[B[B)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_credenceid_database_IrisRecord_Position_arrayBarrayB, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_credenceid_database_IrisRecord_Position_arrayBarrayB, __args);
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

		static IntPtr id_ctor_Lcom_credenceid_database_IrisRecord_Position_arrayBarrayBarrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.database']/class[@name='IrisRecord']/constructor[@name='IrisRecord' and count(parameter)=4 and parameter[1][@type='com.credenceid.database.IrisRecord.Position'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]']]"
		[Register (".ctor", "(Lcom/credenceid/database/IrisRecord$Position;[B[B[B)V", "")]
		public unsafe IrisRecord (global::Com.Credenceid.Database.IrisRecord.Position position, byte[] imageOne, byte[] imageTwo, byte[] imageThree)
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
				if (((object) this).GetType () != typeof (IrisRecord)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/credenceid/database/IrisRecord$Position;[B[B[B)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/credenceid/database/IrisRecord$Position;[B[B[B)V", __args);
					return;
				}

				if (id_ctor_Lcom_credenceid_database_IrisRecord_Position_arrayBarrayBarrayB == IntPtr.Zero)
					id_ctor_Lcom_credenceid_database_IrisRecord_Position_arrayBarrayBarrayB = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/credenceid/database/IrisRecord$Position;[B[B[B)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_credenceid_database_IrisRecord_Position_arrayBarrayBarrayB, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_credenceid_database_IrisRecord_Position_arrayBarrayBarrayB, __args);
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

		static IntPtr id_ctor_Lcom_credenceid_database_IrisRecord_Position_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.database']/class[@name='IrisRecord']/constructor[@name='IrisRecord' and count(parameter)=2 and parameter[1][@type='com.credenceid.database.IrisRecord.Position'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/credenceid/database/IrisRecord$Position;Ljava/lang/String;)V", "")]
		public unsafe IrisRecord (global::Com.Credenceid.Database.IrisRecord.Position position, string imageOneAbsPath)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_imageOneAbsPath = JNIEnv.NewString (imageOneAbsPath);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (position);
				__args [1] = new JValue (native_imageOneAbsPath);
				if (((object) this).GetType () != typeof (IrisRecord)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/credenceid/database/IrisRecord$Position;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/credenceid/database/IrisRecord$Position;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Lcom_credenceid_database_IrisRecord_Position_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Lcom_credenceid_database_IrisRecord_Position_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/credenceid/database/IrisRecord$Position;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_credenceid_database_IrisRecord_Position_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_credenceid_database_IrisRecord_Position_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_imageOneAbsPath);
			}
		}

		static IntPtr id_ctor_Lcom_credenceid_database_IrisRecord_Position_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.database']/class[@name='IrisRecord']/constructor[@name='IrisRecord' and count(parameter)=3 and parameter[1][@type='com.credenceid.database.IrisRecord.Position'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/credenceid/database/IrisRecord$Position;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe IrisRecord (global::Com.Credenceid.Database.IrisRecord.Position position, string imageOneAbsPath, string imageTwoAbsPath)
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
				if (((object) this).GetType () != typeof (IrisRecord)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/credenceid/database/IrisRecord$Position;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/credenceid/database/IrisRecord$Position;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Lcom_credenceid_database_IrisRecord_Position_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Lcom_credenceid_database_IrisRecord_Position_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/credenceid/database/IrisRecord$Position;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_credenceid_database_IrisRecord_Position_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_credenceid_database_IrisRecord_Position_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_imageOneAbsPath);
				JNIEnv.DeleteLocalRef (native_imageTwoAbsPath);
			}
		}

		static IntPtr id_ctor_Lcom_credenceid_database_IrisRecord_Position_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.credenceid.database']/class[@name='IrisRecord']/constructor[@name='IrisRecord' and count(parameter)=4 and parameter[1][@type='com.credenceid.database.IrisRecord.Position'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/credenceid/database/IrisRecord$Position;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe IrisRecord (global::Com.Credenceid.Database.IrisRecord.Position position, string imageOneAbsPath, string imageTwoAbsPath, string imageThreeAbsPath)
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
				if (((object) this).GetType () != typeof (IrisRecord)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/credenceid/database/IrisRecord$Position;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/credenceid/database/IrisRecord$Position;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Lcom_credenceid_database_IrisRecord_Position_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Lcom_credenceid_database_IrisRecord_Position_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/credenceid/database/IrisRecord$Position;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_credenceid_database_IrisRecord_Position_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_credenceid_database_IrisRecord_Position_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_imageOneAbsPath);
				JNIEnv.DeleteLocalRef (native_imageTwoAbsPath);
				JNIEnv.DeleteLocalRef (native_imageThreeAbsPath);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.IrisRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetPosition ());
		}
#pragma warning restore 0169

		static IntPtr id_getPosition;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/class[@name='IrisRecord']/method[@name='getPosition' and count(parameter)=0]"
		[Register ("getPosition", "()Lcom/credenceid/database/IrisRecord$Position;", "GetGetPositionHandler")]
		public virtual unsafe global::Com.Credenceid.Database.IrisRecord.Position GetPosition ()
		{
			if (id_getPosition == IntPtr.Zero)
				id_getPosition = JNIEnv.GetMethodID (class_ref, "getPosition", "()Lcom/credenceid/database/IrisRecord$Position;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.IrisRecord.Position> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPosition), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.IrisRecord.Position> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPosition", "()Lcom/credenceid/database/IrisRecord$Position;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setPosition_Lcom_credenceid_database_IrisRecord_Position_;
#pragma warning disable 0169
		static Delegate GetSetPosition_Lcom_credenceid_database_IrisRecord_Position_Handler ()
		{
			if (cb_setPosition_Lcom_credenceid_database_IrisRecord_Position_ == null)
				cb_setPosition_Lcom_credenceid_database_IrisRecord_Position_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetPosition_Lcom_credenceid_database_IrisRecord_Position_);
			return cb_setPosition_Lcom_credenceid_database_IrisRecord_Position_;
		}

		static void n_SetPosition_Lcom_credenceid_database_IrisRecord_Position_ (IntPtr jnienv, IntPtr native__this, IntPtr native_position)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.IrisRecord> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var position = global::Java.Lang.Object.GetObject<global::Com.Credenceid.Database.IrisRecord.Position> (native_position, JniHandleOwnership.DoNotTransfer);
			__this.SetPosition (position);
		}
#pragma warning restore 0169

		static IntPtr id_setPosition_Lcom_credenceid_database_IrisRecord_Position_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.credenceid.database']/class[@name='IrisRecord']/method[@name='setPosition' and count(parameter)=1 and parameter[1][@type='com.credenceid.database.IrisRecord.Position']]"
		[Register ("setPosition", "(Lcom/credenceid/database/IrisRecord$Position;)V", "GetSetPosition_Lcom_credenceid_database_IrisRecord_Position_Handler")]
		public virtual unsafe void SetPosition (global::Com.Credenceid.Database.IrisRecord.Position position)
		{
			if (id_setPosition_Lcom_credenceid_database_IrisRecord_Position_ == IntPtr.Zero)
				id_setPosition_Lcom_credenceid_database_IrisRecord_Position_ = JNIEnv.GetMethodID (class_ref, "setPosition", "(Lcom/credenceid/database/IrisRecord$Position;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (position);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPosition_Lcom_credenceid_database_IrisRecord_Position_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPosition", "(Lcom/credenceid/database/IrisRecord$Position;)V"), __args);
			} finally {
			}
		}

	}
}
