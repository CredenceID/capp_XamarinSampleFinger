package mono.com.credenceid.biometrics;


public class Biometrics_MRZStatusListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.credenceid.biometrics.Biometrics.MRZStatusListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onMRZClose:(Lcom/credenceid/biometrics/Biometrics$ResultCode;Lcom/credenceid/biometrics/Biometrics$CloseReasonCode;)V:GetOnMRZClose_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_Handler:Com.Credenceid.Biometrics.IBiometricsMRZStatusListenerInvoker, CredenceBindings\n" +
			"n_onMRZOpen:(Lcom/credenceid/biometrics/Biometrics$ResultCode;)V:GetOnMRZOpen_Lcom_credenceid_biometrics_Biometrics_ResultCode_Handler:Com.Credenceid.Biometrics.IBiometricsMRZStatusListenerInvoker, CredenceBindings\n" +
			"";
		mono.android.Runtime.register ("Com.Credenceid.Biometrics.IBiometricsMRZStatusListenerImplementor, CredenceBindings", Biometrics_MRZStatusListenerImplementor.class, __md_methods);
	}


	public Biometrics_MRZStatusListenerImplementor ()
	{
		super ();
		if (getClass () == Biometrics_MRZStatusListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Credenceid.Biometrics.IBiometricsMRZStatusListenerImplementor, CredenceBindings", "", this, new java.lang.Object[] {  });
	}


	public void onMRZClose (com.credenceid.biometrics.Biometrics.ResultCode p0, com.credenceid.biometrics.Biometrics.CloseReasonCode p1)
	{
		n_onMRZClose (p0, p1);
	}

	private native void n_onMRZClose (com.credenceid.biometrics.Biometrics.ResultCode p0, com.credenceid.biometrics.Biometrics.CloseReasonCode p1);


	public void onMRZOpen (com.credenceid.biometrics.Biometrics.ResultCode p0)
	{
		n_onMRZOpen (p0);
	}

	private native void n_onMRZOpen (com.credenceid.biometrics.Biometrics.ResultCode p0);

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
