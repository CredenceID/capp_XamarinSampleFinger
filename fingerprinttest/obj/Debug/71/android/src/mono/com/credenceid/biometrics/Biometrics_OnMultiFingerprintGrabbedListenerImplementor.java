package mono.com.credenceid.biometrics;


public class Biometrics_OnMultiFingerprintGrabbedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.credenceid.biometrics.Biometrics.OnMultiFingerprintGrabbedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCloseFingerprintReader:(Lcom/credenceid/biometrics/Biometrics$ResultCode;Lcom/credenceid/biometrics/Biometrics$CloseReasonCode;)V:GetOnCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_Handler:Com.Credenceid.Biometrics.IBiometricsOnMultiFingerprintGrabbedListenerInvoker, CredenceBindings\n" +
			"n_onFingerprintGrabbed:(Lcom/credenceid/biometrics/Biometrics$ResultCode;Landroid/graphics/Bitmap;[Landroid/graphics/Bitmap;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)V:GetOnFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_arrayLandroid_graphics_Bitmap_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Handler:Com.Credenceid.Biometrics.IBiometricsOnMultiFingerprintGrabbedListenerInvoker, CredenceBindings\n" +
			"";
		mono.android.Runtime.register ("Com.Credenceid.Biometrics.IBiometricsOnMultiFingerprintGrabbedListenerImplementor, CredenceBindings", Biometrics_OnMultiFingerprintGrabbedListenerImplementor.class, __md_methods);
	}


	public Biometrics_OnMultiFingerprintGrabbedListenerImplementor ()
	{
		super ();
		if (getClass () == Biometrics_OnMultiFingerprintGrabbedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Credenceid.Biometrics.IBiometricsOnMultiFingerprintGrabbedListenerImplementor, CredenceBindings", "", this, new java.lang.Object[] {  });
	}


	public void onCloseFingerprintReader (com.credenceid.biometrics.Biometrics.ResultCode p0, com.credenceid.biometrics.Biometrics.CloseReasonCode p1)
	{
		n_onCloseFingerprintReader (p0, p1);
	}

	private native void n_onCloseFingerprintReader (com.credenceid.biometrics.Biometrics.ResultCode p0, com.credenceid.biometrics.Biometrics.CloseReasonCode p1);


	public void onFingerprintGrabbed (com.credenceid.biometrics.Biometrics.ResultCode p0, android.graphics.Bitmap p1, android.graphics.Bitmap[] p2, java.lang.String p3, java.lang.String[] p4, java.lang.String p5)
	{
		n_onFingerprintGrabbed (p0, p1, p2, p3, p4, p5);
	}

	private native void n_onFingerprintGrabbed (com.credenceid.biometrics.Biometrics.ResultCode p0, android.graphics.Bitmap p1, android.graphics.Bitmap[] p2, java.lang.String p3, java.lang.String[] p4, java.lang.String p5);

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
