package mono.com.credenceid.biometrics;


public class Biometrics_OnFMDToCCFConversionListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.credenceid.biometrics.Biometrics.OnFMDToCCFConversionListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onFMDToCCFConversion:(Lcom/credenceid/biometrics/Biometrics$ResultCode;[B)V:GetOnFMDToCCFConversion_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayBHandler:Com.Credenceid.Biometrics.IBiometricsOnFMDToCCFConversionListenerInvoker, CredenceBindings\n" +
			"";
		mono.android.Runtime.register ("Com.Credenceid.Biometrics.IBiometricsOnFMDToCCFConversionListenerImplementor, CredenceBindings", Biometrics_OnFMDToCCFConversionListenerImplementor.class, __md_methods);
	}


	public Biometrics_OnFMDToCCFConversionListenerImplementor ()
	{
		super ();
		if (getClass () == Biometrics_OnFMDToCCFConversionListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Credenceid.Biometrics.IBiometricsOnFMDToCCFConversionListenerImplementor, CredenceBindings", "", this, new java.lang.Object[] {  });
	}


	public void onFMDToCCFConversion (com.credenceid.biometrics.Biometrics.ResultCode p0, byte[] p1)
	{
		n_onFMDToCCFConversion (p0, p1);
	}

	private native void n_onFMDToCCFConversion (com.credenceid.biometrics.Biometrics.ResultCode p0, byte[] p1);

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
