package mono.com.credenceid.biometrics;


public class Biometrics_OnMobileDataChangedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.credenceid.biometrics.Biometrics.OnMobileDataChangedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onMobileDataChange:(Lcom/credenceid/biometrics/Biometrics$ResultCode;Ljava/lang/String;)V:GetOnMobileDataChange_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_Handler:Com.Credenceid.Biometrics.IBiometricsOnMobileDataChangedListenerInvoker, CredenceBindings\n" +
			"";
		mono.android.Runtime.register ("Com.Credenceid.Biometrics.IBiometricsOnMobileDataChangedListenerImplementor, CredenceBindings", Biometrics_OnMobileDataChangedListenerImplementor.class, __md_methods);
	}


	public Biometrics_OnMobileDataChangedListenerImplementor ()
	{
		super ();
		if (getClass () == Biometrics_OnMobileDataChangedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Credenceid.Biometrics.IBiometricsOnMobileDataChangedListenerImplementor, CredenceBindings", "", this, new java.lang.Object[] {  });
	}


	public void onMobileDataChange (com.credenceid.biometrics.Biometrics.ResultCode p0, java.lang.String p1)
	{
		n_onMobileDataChange (p0, p1);
	}

	private native void n_onMobileDataChange (com.credenceid.biometrics.Biometrics.ResultCode p0, java.lang.String p1);

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
