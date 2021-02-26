package mono.com.credenceid.biometrics;


public class Biometrics_OnInitializedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.credenceid.biometrics.Biometrics.OnInitializedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onInitialized:(Lcom/credenceid/biometrics/Biometrics$ResultCode;Ljava/lang/String;Ljava/lang/String;)V:GetOnInitialized_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_Ljava_lang_String_Handler:Com.Credenceid.Biometrics.IBiometricsOnInitializedListenerInvoker, CredenceBindings\n" +
			"";
		mono.android.Runtime.register ("Com.Credenceid.Biometrics.IBiometricsOnInitializedListenerImplementor, CredenceBindings", Biometrics_OnInitializedListenerImplementor.class, __md_methods);
	}


	public Biometrics_OnInitializedListenerImplementor ()
	{
		super ();
		if (getClass () == Biometrics_OnInitializedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Credenceid.Biometrics.IBiometricsOnInitializedListenerImplementor, CredenceBindings", "", this, new java.lang.Object[] {  });
	}


	public void onInitialized (com.credenceid.biometrics.Biometrics.ResultCode p0, java.lang.String p1, java.lang.String p2)
	{
		n_onInitialized (p0, p1, p2);
	}

	private native void n_onInitialized (com.credenceid.biometrics.Biometrics.ResultCode p0, java.lang.String p1, java.lang.String p2);

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
