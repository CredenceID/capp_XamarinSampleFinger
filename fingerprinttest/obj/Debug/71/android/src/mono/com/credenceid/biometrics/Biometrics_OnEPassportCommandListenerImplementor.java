package mono.com.credenceid.biometrics;


public class Biometrics_OnEPassportCommandListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.credenceid.biometrics.Biometrics.OnEPassportCommandListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onEPassportCommandComplete:(Lcom/credenceid/biometrics/Biometrics$ResultCode;BB[B)V:GetOnEPassportCommandComplete_Lcom_credenceid_biometrics_Biometrics_ResultCode_BBarrayBHandler:Com.Credenceid.Biometrics.IBiometricsOnEPassportCommandListenerInvoker, CredenceBindings\n" +
			"";
		mono.android.Runtime.register ("Com.Credenceid.Biometrics.IBiometricsOnEPassportCommandListenerImplementor, CredenceBindings", Biometrics_OnEPassportCommandListenerImplementor.class, __md_methods);
	}


	public Biometrics_OnEPassportCommandListenerImplementor ()
	{
		super ();
		if (getClass () == Biometrics_OnEPassportCommandListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Credenceid.Biometrics.IBiometricsOnEPassportCommandListenerImplementor, CredenceBindings", "", this, new java.lang.Object[] {  });
	}


	public void onEPassportCommandComplete (com.credenceid.biometrics.Biometrics.ResultCode p0, byte p1, byte p2, byte[] p3)
	{
		n_onEPassportCommandComplete (p0, p1, p2, p3);
	}

	private native void n_onEPassportCommandComplete (com.credenceid.biometrics.Biometrics.ResultCode p0, byte p1, byte p2, byte[] p3);

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
