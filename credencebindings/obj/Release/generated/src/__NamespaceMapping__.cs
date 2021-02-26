using System;

[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.credenceid", Managed="Com.Credenceid")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.credenceid.biometrics", Managed="Com.Credenceid.Biometrics")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.credenceid.constants", Managed="Com.Credenceid.Constants")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.credenceid.database", Managed="Com.Credenceid.Database")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.credenceid.face", Managed="Com.Credenceid.Face")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.credenceid.icao", Managed="Com.Credenceid.Icao")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.util", Managed="Com.Util")]

delegate sbyte _JniMarshal_PP_B (IntPtr jnienv, IntPtr klass);
delegate int _JniMarshal_PP_I (IntPtr jnienv, IntPtr klass);
delegate IntPtr _JniMarshal_PP_L (IntPtr jnienv, IntPtr klass);
delegate void _JniMarshal_PP_V (IntPtr jnienv, IntPtr klass);
delegate bool _JniMarshal_PP_Z (IntPtr jnienv, IntPtr klass);
delegate IntPtr _JniMarshal_PPI_L (IntPtr jnienv, IntPtr klass, int p0);
delegate void _JniMarshal_PPI_V (IntPtr jnienv, IntPtr klass, int p0);
delegate bool _JniMarshal_PPI_Z (IntPtr jnienv, IntPtr klass, int p0);
delegate void _JniMarshal_PPII_V (IntPtr jnienv, IntPtr klass, int p0, int p1);
delegate void _JniMarshal_PPIIII_V (IntPtr jnienv, IntPtr klass, int p0, int p1, int p2, int p3);
delegate void _JniMarshal_PPIIL_V (IntPtr jnienv, IntPtr klass, int p0, int p1, IntPtr p2);
delegate void _JniMarshal_PPIL_V (IntPtr jnienv, IntPtr klass, int p0, IntPtr p1);
delegate void _JniMarshal_PPILI_V (IntPtr jnienv, IntPtr klass, int p0, IntPtr p1, int p2);
delegate void _JniMarshal_PPILL_V (IntPtr jnienv, IntPtr klass, int p0, IntPtr p1, IntPtr p2);
delegate void _JniMarshal_PPILLLL_V (IntPtr jnienv, IntPtr klass, int p0, IntPtr p1, IntPtr p2, IntPtr p3, IntPtr p4);
delegate int _JniMarshal_PPL_I (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate IntPtr _JniMarshal_PPL_L (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate void _JniMarshal_PPL_V (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate bool _JniMarshal_PPL_Z (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate void _JniMarshal_PPLBBL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, sbyte p1, sbyte p2, IntPtr p3);
delegate void _JniMarshal_PPLF_V (IntPtr jnienv, IntPtr klass, IntPtr p0, float p1);
delegate void _JniMarshal_PPLFL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, float p1, IntPtr p2);
delegate IntPtr _JniMarshal_PPLI_L (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1);
delegate void _JniMarshal_PPLI_V (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1);
delegate void _JniMarshal_PPLII_V (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, int p2);
delegate IntPtr _JniMarshal_PPLIII_L (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, int p2, int p3);
delegate void _JniMarshal_PPLIIL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, int p2, IntPtr p3);
delegate void _JniMarshal_PPLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate bool _JniMarshal_PPLL_Z (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate IntPtr _JniMarshal_PPLLI_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, int p2);
delegate bool _JniMarshal_PPLLI_Z (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, int p2);
delegate void _JniMarshal_PPLLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2);
delegate IntPtr _JniMarshal_PPLLLI_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, int p3);
delegate void _JniMarshal_PPLLLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, IntPtr p3);
delegate void _JniMarshal_PPLLLLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, IntPtr p3, IntPtr p4);
delegate void _JniMarshal_PPLLLLLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, IntPtr p3, IntPtr p4, IntPtr p5);
delegate void _JniMarshal_PPLLLLLLI_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, IntPtr p3, IntPtr p4, IntPtr p5, int p6);
delegate void _JniMarshal_PPLLLLLLLILZI_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, IntPtr p3, IntPtr p4, IntPtr p5, IntPtr p6, int p7, IntPtr p8, bool p9, int p10);
delegate void _JniMarshal_PPLLLLLLLLLLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, IntPtr p3, IntPtr p4, IntPtr p5, IntPtr p6, IntPtr p7, IntPtr p8, IntPtr p9, IntPtr p10);
delegate void _JniMarshal_PPLLLLZL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2, IntPtr p3, bool p4, IntPtr p5);
delegate void _JniMarshal_PPLLZL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, bool p2, IntPtr p3);
delegate IntPtr _JniMarshal_PPLSSSSI_L (IntPtr jnienv, IntPtr klass, IntPtr p0, short p1, short p2, short p3, short p4, int p5);
delegate void _JniMarshal_PPLSSSSL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, short p1, short p2, short p3, short p4, IntPtr p5);
delegate IntPtr _JniMarshal_PPLZ_L (IntPtr jnienv, IntPtr klass, IntPtr p0, bool p1);
delegate IntPtr _JniMarshal_PPLZI_L (IntPtr jnienv, IntPtr klass, IntPtr p0, bool p1, int p2);
delegate void _JniMarshal_PPLZL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, bool p1, IntPtr p2);
delegate void _JniMarshal_PPZ_V (IntPtr jnienv, IntPtr klass, bool p0);
delegate bool _JniMarshal_PPZ_Z (IntPtr jnienv, IntPtr klass, bool p0);
delegate void _JniMarshal_PPZL_V (IntPtr jnienv, IntPtr klass, bool p0, IntPtr p1);
