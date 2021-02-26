package mono.com.credenceid.biometrics;


public class Biometrics_OnCompressToWSQListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.credenceid.biometrics.Biometrics.OnCompressToWSQListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onConvertToWsq:(Lcom/credenceid/biometrics/Biometrics$ResultCode;Ljava/lang/String;)V:GetOnConvertToWsq_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_Handler:Com.Credenceid.Biometrics.IBiometricsOnCompressToWSQListenerInvoker, CredenceBindings\n" +
			"";
		mono.android.Runtime.register ("Com.Credenceid.Biometrics.IBiometricsOnCompressToWSQListenerImplementor, CredenceBindings", Biometrics_OnCompressToWSQListenerImplementor.class, __md_methods);
	}


	public Biometrics_OnCompressToWSQListenerImplementor ()
	{
		super ();
		if (getClass () == Biometrics_OnCompressToWSQListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Credenceid.Biometrics.IBiometricsOnCompressToWSQListenerImplementor, CredenceBindings", "", this, new java.lang.Object[] {  });
	}


	public void onConvertToWsq (com.credenceid.biometrics.Biometrics.ResultCode p0, java.lang.String p1)
	{
		n_onConvertToWsq (p0, p1);
	}

	private native void n_onConvertToWsq (com.credenceid.biometrics.Biometrics.ResultCode p0, java.lang.String p1);

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
