package mono.com.credenceid.biometrics;


public class Biometrics_OnGetProviderDetailsListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.credenceid.biometrics.Biometrics.OnGetProviderDetailsListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onGetProviderDetails:(Lcom/credenceid/biometrics/Biometrics$ResultCode;Ljava/lang/String;)V:GetOnGetProviderDetails_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_Handler:Com.Credenceid.Biometrics.IBiometricsOnGetProviderDetailsListenerInvoker, CredenceBindings\n" +
			"";
		mono.android.Runtime.register ("Com.Credenceid.Biometrics.IBiometricsOnGetProviderDetailsListenerImplementor, CredenceBindings", Biometrics_OnGetProviderDetailsListenerImplementor.class, __md_methods);
	}


	public Biometrics_OnGetProviderDetailsListenerImplementor ()
	{
		super ();
		if (getClass () == Biometrics_OnGetProviderDetailsListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Credenceid.Biometrics.IBiometricsOnGetProviderDetailsListenerImplementor, CredenceBindings", "", this, new java.lang.Object[] {  });
	}


	public void onGetProviderDetails (com.credenceid.biometrics.Biometrics.ResultCode p0, java.lang.String p1)
	{
		n_onGetProviderDetails (p0, p1);
	}

	private native void n_onGetProviderDetails (com.credenceid.biometrics.Biometrics.ResultCode p0, java.lang.String p1);

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
