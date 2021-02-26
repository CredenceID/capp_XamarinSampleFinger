package mono.com.credenceid.biometrics;


public class Biometrics_generateTerminalIsCertificateListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.credenceid.biometrics.Biometrics.generateTerminalIsCertificateListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onGenerateCertificate:(Lcom/credenceid/biometrics/Biometrics$ResultCode;Ljava/lang/String;)V:GetOnGenerateCertificate_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_Handler:Com.Credenceid.Biometrics.IBiometricsGenerateTerminalIsCertificateListenerInvoker, CredenceBindings\n" +
			"";
		mono.android.Runtime.register ("Com.Credenceid.Biometrics.IBiometricsGenerateTerminalIsCertificateListenerImplementor, CredenceBindings", Biometrics_generateTerminalIsCertificateListenerImplementor.class, __md_methods);
	}


	public Biometrics_generateTerminalIsCertificateListenerImplementor ()
	{
		super ();
		if (getClass () == Biometrics_generateTerminalIsCertificateListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Credenceid.Biometrics.IBiometricsGenerateTerminalIsCertificateListenerImplementor, CredenceBindings", "", this, new java.lang.Object[] {  });
	}


	public void onGenerateCertificate (com.credenceid.biometrics.Biometrics.ResultCode p0, java.lang.String p1)
	{
		n_onGenerateCertificate (p0, p1);
	}

	private native void n_onGenerateCertificate (com.credenceid.biometrics.Biometrics.ResultCode p0, java.lang.String p1);

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
