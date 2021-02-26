package mono.com.credenceid.biometrics;


public class Biometrics_OnEPassportStatusListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.credenceid.biometrics.Biometrics.OnEPassportStatusListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onEPassportCardStatusChange:(II)V:GetOnEPassportCardStatusChange_IIHandler:Com.Credenceid.Biometrics.IBiometricsOnEPassportStatusListenerInvoker, CredenceBindings\n" +
			"";
		mono.android.Runtime.register ("Com.Credenceid.Biometrics.IBiometricsOnEPassportStatusListenerImplementor, CredenceBindings", Biometrics_OnEPassportStatusListenerImplementor.class, __md_methods);
	}


	public Biometrics_OnEPassportStatusListenerImplementor ()
	{
		super ();
		if (getClass () == Biometrics_OnEPassportStatusListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Credenceid.Biometrics.IBiometricsOnEPassportStatusListenerImplementor, CredenceBindings", "", this, new java.lang.Object[] {  });
	}


	public void onEPassportCardStatusChange (int p0, int p1)
	{
		n_onEPassportCardStatusChange (p0, p1);
	}

	private native void n_onEPassportCardStatusChange (int p0, int p1);

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
