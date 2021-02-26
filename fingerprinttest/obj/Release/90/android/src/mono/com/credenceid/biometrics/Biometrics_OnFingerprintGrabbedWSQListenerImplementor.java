package mono.com.credenceid.biometrics;


public class Biometrics_OnFingerprintGrabbedWSQListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.credenceid.biometrics.Biometrics.OnFingerprintGrabbedWSQListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCloseFingerprintReader:(Lcom/credenceid/biometrics/Biometrics$ResultCode;Lcom/credenceid/biometrics/Biometrics$CloseReasonCode;)V:GetOnCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_Handler:Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedWSQListenerInvoker, CredenceBindings\n" +
			"n_onFingerprintGrabbed:(Lcom/credenceid/biometrics/Biometrics$ResultCode;Landroid/graphics/Bitmap;[BLjava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V:GetOnFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_arrayBLjava_lang_String_Ljava_lang_String_Ljava_lang_String_IHandler:Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedWSQListenerInvoker, CredenceBindings\n" +
			"";
		mono.android.Runtime.register ("Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedWSQListenerImplementor, CredenceBindings", Biometrics_OnFingerprintGrabbedWSQListenerImplementor.class, __md_methods);
	}


	public Biometrics_OnFingerprintGrabbedWSQListenerImplementor ()
	{
		super ();
		if (getClass () == Biometrics_OnFingerprintGrabbedWSQListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedWSQListenerImplementor, CredenceBindings", "", this, new java.lang.Object[] {  });
	}


	public void onCloseFingerprintReader (com.credenceid.biometrics.Biometrics.ResultCode p0, com.credenceid.biometrics.Biometrics.CloseReasonCode p1)
	{
		n_onCloseFingerprintReader (p0, p1);
	}

	private native void n_onCloseFingerprintReader (com.credenceid.biometrics.Biometrics.ResultCode p0, com.credenceid.biometrics.Biometrics.CloseReasonCode p1);


	public void onFingerprintGrabbed (com.credenceid.biometrics.Biometrics.ResultCode p0, android.graphics.Bitmap p1, byte[] p2, java.lang.String p3, java.lang.String p4, java.lang.String p5, int p6)
	{
		n_onFingerprintGrabbed (p0, p1, p2, p3, p4, p5, p6);
	}

	private native void n_onFingerprintGrabbed (com.credenceid.biometrics.Biometrics.ResultCode p0, android.graphics.Bitmap p1, byte[] p2, java.lang.String p3, java.lang.String p4, java.lang.String p5, int p6);

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
