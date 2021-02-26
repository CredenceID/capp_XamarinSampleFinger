package mono.com.credenceid.biometrics;


public class Biometrics_OnMRZDocumentStatusListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.credenceid.biometrics.Biometrics.OnMRZDocumentStatusListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onMRZDocumentStatusChange:(II)V:GetOnMRZDocumentStatusChange_IIHandler:Com.Credenceid.Biometrics.IBiometricsOnMRZDocumentStatusListenerInvoker, CredenceBindings\n" +
			"";
		mono.android.Runtime.register ("Com.Credenceid.Biometrics.IBiometricsOnMRZDocumentStatusListenerImplementor, CredenceBindings", Biometrics_OnMRZDocumentStatusListenerImplementor.class, __md_methods);
	}


	public Biometrics_OnMRZDocumentStatusListenerImplementor ()
	{
		super ();
		if (getClass () == Biometrics_OnMRZDocumentStatusListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Credenceid.Biometrics.IBiometricsOnMRZDocumentStatusListenerImplementor, CredenceBindings", "", this, new java.lang.Object[] {  });
	}


	public void onMRZDocumentStatusChange (int p0, int p1)
	{
		n_onMRZDocumentStatusChange (p0, p1);
	}

	private native void n_onMRZDocumentStatusChange (int p0, int p1);

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
