package mono.com.credenceid.biometrics;


public class Biometrics_OnGetFingerQualityListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.credenceid.biometrics.Biometrics.OnGetFingerQualityListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onGetFingerQuality:(Lcom/credenceid/biometrics/Biometrics$ResultCode;I)V:GetOnGetFingerQuality_Lcom_credenceid_biometrics_Biometrics_ResultCode_IHandler:Com.Credenceid.Biometrics.IBiometricsOnGetFingerQualityListenerInvoker, CredenceBindings\n" +
			"";
		mono.android.Runtime.register ("Com.Credenceid.Biometrics.IBiometricsOnGetFingerQualityListenerImplementor, CredenceBindings", Biometrics_OnGetFingerQualityListenerImplementor.class, __md_methods);
	}


	public Biometrics_OnGetFingerQualityListenerImplementor ()
	{
		super ();
		if (getClass () == Biometrics_OnGetFingerQualityListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Credenceid.Biometrics.IBiometricsOnGetFingerQualityListenerImplementor, CredenceBindings", "", this, new java.lang.Object[] {  });
	}


	public void onGetFingerQuality (com.credenceid.biometrics.Biometrics.ResultCode p0, int p1)
	{
		n_onGetFingerQuality (p0, p1);
	}

	private native void n_onGetFingerQuality (com.credenceid.biometrics.Biometrics.ResultCode p0, int p1);

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
