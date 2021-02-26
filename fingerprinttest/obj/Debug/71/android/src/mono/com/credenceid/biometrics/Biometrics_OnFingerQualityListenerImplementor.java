package mono.com.credenceid.biometrics;


public class Biometrics_OnFingerQualityListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.credenceid.biometrics.Biometrics.OnFingerQualityListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onGetFingerQuality:(Lcom/credenceid/biometrics/Biometrics$ResultCode;Lcom/credenceid/biometrics/FingerQuality;)V:GetOnGetFingerQuality_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_FingerQuality_Handler:Com.Credenceid.Biometrics.IBiometricsOnFingerQualityListenerInvoker, CredenceBindings\n" +
			"";
		mono.android.Runtime.register ("Com.Credenceid.Biometrics.IBiometricsOnFingerQualityListenerImplementor, CredenceBindings", Biometrics_OnFingerQualityListenerImplementor.class, __md_methods);
	}


	public Biometrics_OnFingerQualityListenerImplementor ()
	{
		super ();
		if (getClass () == Biometrics_OnFingerQualityListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Credenceid.Biometrics.IBiometricsOnFingerQualityListenerImplementor, CredenceBindings", "", this, new java.lang.Object[] {  });
	}


	public void onGetFingerQuality (com.credenceid.biometrics.Biometrics.ResultCode p0, com.credenceid.biometrics.FingerQuality p1)
	{
		n_onGetFingerQuality (p0, p1);
	}

	private native void n_onGetFingerQuality (com.credenceid.biometrics.Biometrics.ResultCode p0, com.credenceid.biometrics.FingerQuality p1);

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
