package mono.com.credenceid.biometrics;


public class Biometrics_OnCardCommandSyncResultListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.credenceid.biometrics.Biometrics.OnCardCommandSyncResultListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Com.Credenceid.Biometrics.IBiometricsOnCardCommandSyncResultListenerImplementor, CredenceBindings", Biometrics_OnCardCommandSyncResultListenerImplementor.class, __md_methods);
	}


	public Biometrics_OnCardCommandSyncResultListenerImplementor ()
	{
		super ();
		if (getClass () == Biometrics_OnCardCommandSyncResultListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Credenceid.Biometrics.IBiometricsOnCardCommandSyncResultListenerImplementor, CredenceBindings", "", this, new java.lang.Object[] {  });
	}

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
