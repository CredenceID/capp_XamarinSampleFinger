package mono.com.credenceid.biometrics;


public class Biometrics_OnCardCommandListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.credenceid.biometrics.Biometrics.OnCardCommandListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCardCommandComplete:(Lcom/credenceid/biometrics/Biometrics$ResultCode;BB[B)V:GetOnCardCommandComplete_Lcom_credenceid_biometrics_Biometrics_ResultCode_BBarrayBHandler:Com.Credenceid.Biometrics.IBiometricsOnCardCommandListenerInvoker, CredenceBindings\n" +
			"";
		mono.android.Runtime.register ("Com.Credenceid.Biometrics.IBiometricsOnCardCommandListenerImplementor, CredenceBindings", Biometrics_OnCardCommandListenerImplementor.class, __md_methods);
	}


	public Biometrics_OnCardCommandListenerImplementor ()
	{
		super ();
		if (getClass () == Biometrics_OnCardCommandListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Credenceid.Biometrics.IBiometricsOnCardCommandListenerImplementor, CredenceBindings", "", this, new java.lang.Object[] {  });
	}


	public void onCardCommandComplete (com.credenceid.biometrics.Biometrics.ResultCode p0, byte p1, byte p2, byte[] p3)
	{
		n_onCardCommandComplete (p0, p1, p2, p3);
	}

	private native void n_onCardCommandComplete (com.credenceid.biometrics.Biometrics.ResultCode p0, byte p1, byte p2, byte[] p3);

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
