package mono.com.credenceid.biometrics;


public class Biometrics_OnCardStatusListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.credenceid.biometrics.Biometrics.OnCardStatusListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCardStatusChange:(Ljava/lang/String;II)V:GetOnCardStatusChange_Ljava_lang_String_IIHandler:Com.Credenceid.Biometrics.IBiometricsOnCardStatusListenerInvoker, CredenceBindings\n" +
			"";
		mono.android.Runtime.register ("Com.Credenceid.Biometrics.IBiometricsOnCardStatusListenerImplementor, CredenceBindings", Biometrics_OnCardStatusListenerImplementor.class, __md_methods);
	}


	public Biometrics_OnCardStatusListenerImplementor ()
	{
		super ();
		if (getClass () == Biometrics_OnCardStatusListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Credenceid.Biometrics.IBiometricsOnCardStatusListenerImplementor, CredenceBindings", "", this, new java.lang.Object[] {  });
	}


	public void onCardStatusChange (java.lang.String p0, int p1, int p2)
	{
		n_onCardStatusChange (p0, p1, p2);
	}

	private native void n_onCardStatusChange (java.lang.String p0, int p1, int p2);

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
