package mono.com.credenceid.biometrics;


public class Biometrics_EPassportReaderStatusListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.credenceid.biometrics.Biometrics.EPassportReaderStatusListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onEPassportReaderClosed:(Lcom/credenceid/biometrics/Biometrics$ResultCode;Lcom/credenceid/biometrics/Biometrics$CloseReasonCode;)V:GetOnEPassportReaderClosed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_Handler:Com.Credenceid.Biometrics.IBiometricsEPassportReaderStatusListenerInvoker, CredenceBindings\n" +
			"n_onEPassportReaderOpen:(Lcom/credenceid/biometrics/Biometrics$ResultCode;)V:GetOnEPassportReaderOpen_Lcom_credenceid_biometrics_Biometrics_ResultCode_Handler:Com.Credenceid.Biometrics.IBiometricsEPassportReaderStatusListenerInvoker, CredenceBindings\n" +
			"";
		mono.android.Runtime.register ("Com.Credenceid.Biometrics.IBiometricsEPassportReaderStatusListenerImplementor, CredenceBindings", Biometrics_EPassportReaderStatusListenerImplementor.class, __md_methods);
	}


	public Biometrics_EPassportReaderStatusListenerImplementor ()
	{
		super ();
		if (getClass () == Biometrics_EPassportReaderStatusListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Credenceid.Biometrics.IBiometricsEPassportReaderStatusListenerImplementor, CredenceBindings", "", this, new java.lang.Object[] {  });
	}


	public void onEPassportReaderClosed (com.credenceid.biometrics.Biometrics.ResultCode p0, com.credenceid.biometrics.Biometrics.CloseReasonCode p1)
	{
		n_onEPassportReaderClosed (p0, p1);
	}

	private native void n_onEPassportReaderClosed (com.credenceid.biometrics.Biometrics.ResultCode p0, com.credenceid.biometrics.Biometrics.CloseReasonCode p1);


	public void onEPassportReaderOpen (com.credenceid.biometrics.Biometrics.ResultCode p0)
	{
		n_onEPassportReaderOpen (p0);
	}

	private native void n_onEPassportReaderOpen (com.credenceid.biometrics.Biometrics.ResultCode p0);

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
