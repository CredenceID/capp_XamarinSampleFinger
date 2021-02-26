using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"com/credenceid/biometrics",
						"com/credenceid/database",
						"com/credenceid/face",
					},
					new Converter<string, Type>[]{
						lookup_com_credenceid_biometrics_package,
						lookup_com_credenceid_database_package,
						lookup_com_credenceid_face_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

		static Type Lookup (string[] mappings, string javaType)
		{
			var managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_com_credenceid_biometrics_mappings;
		static Type lookup_com_credenceid_biometrics_package (string klass)
		{
			if (package_com_credenceid_biometrics_mappings == null) {
				package_com_credenceid_biometrics_mappings = new string[]{
					"com/credenceid/biometrics/Biometrics$CloseReasonCode:Com.Credenceid.Biometrics.BiometricsCloseReasonCode",
					"com/credenceid/biometrics/Biometrics$EyeSelection:Com.Credenceid.Biometrics.BiometricsEyeSelection",
					"com/credenceid/biometrics/Biometrics$FingerprintScannerType:Com.Credenceid.Biometrics.BiometricsFingerprintScannerType",
					"com/credenceid/biometrics/Biometrics$FMDFormat:Com.Credenceid.Biometrics.BiometricsFMDFormat",
					"com/credenceid/biometrics/Biometrics$ResultCode:Com.Credenceid.Biometrics.BiometricsResultCode",
					"com/credenceid/biometrics/Biometrics$ScanType:Com.Credenceid.Biometrics.BiometricsScanType",
				};
			}

			return Lookup (package_com_credenceid_biometrics_mappings, klass);
		}

		static string[] package_com_credenceid_database_mappings;
		static Type lookup_com_credenceid_database_package (string klass)
		{
			if (package_com_credenceid_database_mappings == null) {
				package_com_credenceid_database_mappings = new string[]{
					"com/credenceid/database/BiometricDatabase$Status:Com.Credenceid.Database.BiometricDatabaseStatus",
				};
			}

			return Lookup (package_com_credenceid_database_mappings, klass);
		}

		static string[] package_com_credenceid_face_mappings;
		static Type lookup_com_credenceid_face_package (string klass)
		{
			if (package_com_credenceid_face_mappings == null) {
				package_com_credenceid_face_mappings = new string[]{
					"com/credenceid/face/FaceEngine$Emotion:Com.Credenceid.Face.FaceEngineEmotion",
					"com/credenceid/face/FaceEngine$Gender:Com.Credenceid.Face.FaceEngineGender",
					"com/credenceid/face/FaceEngine$HeadPoseDirection:Com.Credenceid.Face.FaceEngineHeadPoseDirection",
				};
			}

			return Lookup (package_com_credenceid_face_mappings, klass);
		}
	}
}
