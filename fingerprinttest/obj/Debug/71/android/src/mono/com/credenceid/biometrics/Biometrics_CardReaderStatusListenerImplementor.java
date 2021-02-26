package mono.com.credenceid.biometrics;


public class Biometrics_CardReaderStatusListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.credenceid.biometrics.Biometrics.CardReaderStatusListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCardReaderClosed:(Lcom/credenceid/biometrics/Biometrics$ResultCode;Lcom/credenceid/biometrics/Biometrics$CloseReasonCode;)V:GetOnCardReaderClosed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_Handler:Com.Credenceid.Biometrics.IBiometricsCardReaderStatusListenerInvoker, CredenceBindings\n" +
			"n_onCardReaderOpen:(Lcom/credenceid/biometrics/Biometrics$ResultCode;)V:GetOnCardReaderOpen_Lcom_credenceid_biometrics_Biometrics_ResultCode_Handler:Com.Credenceid.Biometrics.IBiometricsCardReaderStatusListenerInvoker, CredenceBindings\n" +
			"";
		mono.android.Runtime.register ("Com.Credenceid.Biometrics.IBiometricsCardReaderStatusListenerImplementor, CredenceBindings", Biometrics_CardReaderStatusListenerImplementor.class, __md_methods);
	}


	public Biometrics_CardReaderStatusListenerImplementor ()
	{
		super ();
		if (getClass () == Biometrics_CardReaderStatusListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Credenceid.Biometrics.IBiometricsCardReaderStatusListenerImplementor, CredenceBindings", "", this, new java.lang.Object[] {  });
	}


	public void onCardReaderClosed (com.credenceid.biometrics.Biometrics.ResultCode p0, com.credenceid.biometrics.Biometrics.CloseReasonCode p1)
	{
		n_onCardReaderClosed (p0, p1);
	}

	private native void n_onCardReaderClosed (com.credenceid.biometrics.Biometrics.ResultCode p0, com.credenceid.biometrics.Biometrics.CloseReasonCode p1);


	public void onCardReaderOpen (com.credenceid.biometrics.Biometrics.ResultCode p0)
	{
		n_onCardReaderOpen (p0);
	}

	private native void n_onCardReaderOpen (com.credenceid.biometrics.Biometrics.ResultCode p0);

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
