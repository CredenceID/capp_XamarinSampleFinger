package mono.com.credenceid.biometrics;


public class Biometrics_ICAODocumentReadListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.credenceid.biometrics.Biometrics.ICAODocumentReadListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onICAODocumentRead:(Lcom/credenceid/biometrics/Biometrics$ResultCode;Lcom/credenceid/icao/ICAOReadIntermediateCode;Ljava/lang/String;Lcom/credenceid/icao/ICAODocumentData;)V:GetOnICAODocumentRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_icao_ICAOReadIntermediateCode_Ljava_lang_String_Lcom_credenceid_icao_ICAODocumentData_Handler:Com.Credenceid.Biometrics.IBiometricsCAODocumentReadListenerInvoker, CredenceBindings\n" +
			"";
		mono.android.Runtime.register ("Com.Credenceid.Biometrics.IBiometricsCAODocumentReadListenerImplementor, CredenceBindings", Biometrics_ICAODocumentReadListenerImplementor.class, __md_methods);
	}


	public Biometrics_ICAODocumentReadListenerImplementor ()
	{
		super ();
		if (getClass () == Biometrics_ICAODocumentReadListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Credenceid.Biometrics.IBiometricsCAODocumentReadListenerImplementor, CredenceBindings", "", this, new java.lang.Object[] {  });
	}


	public void onICAODocumentRead (com.credenceid.biometrics.Biometrics.ResultCode p0, com.credenceid.icao.ICAOReadIntermediateCode p1, java.lang.String p2, com.credenceid.icao.ICAODocumentData p3)
	{
		n_onICAODocumentRead (p0, p1, p2, p3);
	}

	private native void n_onICAODocumentRead (com.credenceid.biometrics.Biometrics.ResultCode p0, com.credenceid.icao.ICAOReadIntermediateCode p1, java.lang.String p2, com.credenceid.icao.ICAODocumentData p3);

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
