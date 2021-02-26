package mono.com.credenceid.biometrics;


public class Biometrics_OnIrisesCapturedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.credenceid.biometrics.Biometrics.OnIrisesCapturedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCloseIrisScanner:(Lcom/credenceid/biometrics/Biometrics$ResultCode;Lcom/credenceid/biometrics/Biometrics$CloseReasonCode;)V:GetOnCloseIrisScanner_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_Handler:Com.Credenceid.Biometrics.IBiometricsOnIrisesCapturedListenerInvoker, CredenceBindings\n" +
			"n_onIrisesCaptured:(Lcom/credenceid/biometrics/Biometrics$ResultCode;Landroid/graphics/Bitmap;Landroid/graphics/Bitmap;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V:GetOnIrisesCaptured_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_Landroid_graphics_Bitmap_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Com.Credenceid.Biometrics.IBiometricsOnIrisesCapturedListenerInvoker, CredenceBindings\n" +
			"";
		mono.android.Runtime.register ("Com.Credenceid.Biometrics.IBiometricsOnIrisesCapturedListenerImplementor, CredenceBindings", Biometrics_OnIrisesCapturedListenerImplementor.class, __md_methods);
	}


	public Biometrics_OnIrisesCapturedListenerImplementor ()
	{
		super ();
		if (getClass () == Biometrics_OnIrisesCapturedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Credenceid.Biometrics.IBiometricsOnIrisesCapturedListenerImplementor, CredenceBindings", "", this, new java.lang.Object[] {  });
	}


	public void onCloseIrisScanner (com.credenceid.biometrics.Biometrics.ResultCode p0, com.credenceid.biometrics.Biometrics.CloseReasonCode p1)
	{
		n_onCloseIrisScanner (p0, p1);
	}

	private native void n_onCloseIrisScanner (com.credenceid.biometrics.Biometrics.ResultCode p0, com.credenceid.biometrics.Biometrics.CloseReasonCode p1);


	public void onIrisesCaptured (com.credenceid.biometrics.Biometrics.ResultCode p0, android.graphics.Bitmap p1, android.graphics.Bitmap p2, java.lang.String p3, java.lang.String p4, java.lang.String p5)
	{
		n_onIrisesCaptured (p0, p1, p2, p3, p4, p5);
	}

	private native void n_onIrisesCaptured (com.credenceid.biometrics.Biometrics.ResultCode p0, android.graphics.Bitmap p1, android.graphics.Bitmap p2, java.lang.String p3, java.lang.String p4, java.lang.String p5);

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
