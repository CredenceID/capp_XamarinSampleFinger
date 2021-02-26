package mono.com.credenceid.biometrics;


public class Biometrics_OnDecompressWSQListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.credenceid.biometrics.Biometrics.OnDecompressWSQListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onDecompressWsq:(Lcom/credenceid/biometrics/Biometrics$ResultCode;[B)V:GetOnDecompressWsq_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayBHandler:Com.Credenceid.Biometrics.IBiometricsOnDecompressWSQListenerInvoker, CredenceBindings\n" +
			"";
		mono.android.Runtime.register ("Com.Credenceid.Biometrics.IBiometricsOnDecompressWSQListenerImplementor, CredenceBindings", Biometrics_OnDecompressWSQListenerImplementor.class, __md_methods);
	}


	public Biometrics_OnDecompressWSQListenerImplementor ()
	{
		super ();
		if (getClass () == Biometrics_OnDecompressWSQListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Credenceid.Biometrics.IBiometricsOnDecompressWSQListenerImplementor, CredenceBindings", "", this, new java.lang.Object[] {  });
	}


	public void onDecompressWsq (com.credenceid.biometrics.Biometrics.ResultCode p0, byte[] p1)
	{
		n_onDecompressWsq (p0, p1);
	}

	private native void n_onDecompressWsq (com.credenceid.biometrics.Biometrics.ResultCode p0, byte[] p1);

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
