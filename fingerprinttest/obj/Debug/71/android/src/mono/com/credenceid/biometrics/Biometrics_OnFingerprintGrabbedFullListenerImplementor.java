package mono.com.credenceid.biometrics;


public class Biometrics_OnFingerprintGrabbedFullListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.credenceid.biometrics.Biometrics.OnFingerprintGrabbedFullListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCloseFingerprintReader:(Lcom/credenceid/biometrics/Biometrics$ResultCode;Lcom/credenceid/biometrics/Biometrics$CloseReasonCode;)V:GetOnCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_Handler:Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedFullListenerInvoker, CredenceBindings\n" +
			"n_onFingerprintGrabbed:(Lcom/credenceid/biometrics/Biometrics$ResultCode;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;[B[B[BLjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V:GetOnFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_arrayBarrayBarrayBLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedFullListenerInvoker, CredenceBindings\n" +
			"";
		mono.android.Runtime.register ("Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedFullListenerImplementor, CredenceBindings", Biometrics_OnFingerprintGrabbedFullListenerImplementor.class, __md_methods);
	}


	public Biometrics_OnFingerprintGrabbedFullListenerImplementor ()
	{
		super ();
		if (getClass () == Biometrics_OnFingerprintGrabbedFullListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedFullListenerImplementor, CredenceBindings", "", this, new java.lang.Object[] {  });
	}


	public void onCloseFingerprintReader (com.credenceid.biometrics.Biometrics.ResultCode p0, com.credenceid.biometrics.Biometrics.CloseReasonCode p1)
	{
		n_onCloseFingerprintReader (p0, p1);
	}

	private native void n_onCloseFingerprintReader (com.credenceid.biometrics.Biometrics.ResultCode p0, com.credenceid.biometrics.Biometrics.CloseReasonCode p1);


	public void onFingerprintGrabbed (com.credenceid.biometrics.Biometrics.ResultCode p0, android.graphics.Bitmap p1, android.graphics.Bitmap p2, android.graphics.Bitmap p3, byte[] p4, byte[] p5, byte[] p6, java.lang.String p7, java.lang.String p8, java.lang.String p9, java.lang.String p10)
	{
		n_onFingerprintGrabbed (p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10);
	}

	private native void n_onFingerprintGrabbed (com.credenceid.biometrics.Biometrics.ResultCode p0, android.graphics.Bitmap p1, android.graphics.Bitmap p2, android.graphics.Bitmap p3, byte[] p4, byte[] p5, byte[] p6, java.lang.String p7, java.lang.String p8, java.lang.String p9, java.lang.String p10);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}