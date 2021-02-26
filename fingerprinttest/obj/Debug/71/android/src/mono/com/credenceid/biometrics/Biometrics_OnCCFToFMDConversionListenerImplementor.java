package mono.com.credenceid.biometrics;


public class Biometrics_OnCCFToFMDConversionListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.credenceid.biometrics.Biometrics.OnCCFToFMDConversionListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCCFToFMDConversion:(Lcom/credenceid/biometrics/Biometrics$ResultCode;[B)V:GetOnCCFToFMDConversion_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayBHandler:Com.Credenceid.Biometrics.IBiometricsOnCCFToFMDConversionListenerInvoker, CredenceBindings\n" +
			"";
		mono.android.Runtime.register ("Com.Credenceid.Biometrics.IBiometricsOnCCFToFMDConversionListenerImplementor, CredenceBindings", Biometrics_OnCCFToFMDConversionListenerImplementor.class, __md_methods);
	}


	public Biometrics_OnCCFToFMDConversionListenerImplementor ()
	{
		super ();
		if (getClass () == Biometrics_OnCCFToFMDConversionListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Credenceid.Biometrics.IBiometricsOnCCFToFMDConversionListenerImplementor, CredenceBindings", "", this, new java.lang.Object[] {  });
	}


	public void onCCFToFMDConversion (com.credenceid.biometrics.Biometrics.ResultCode p0, byte[] p1)
	{
		n_onCCFToFMDConversion (p0, p1);
	}

	private native void n_onCCFToFMDConversion (com.credenceid.biometrics.Biometrics.ResultCode p0, byte[] p1);

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
