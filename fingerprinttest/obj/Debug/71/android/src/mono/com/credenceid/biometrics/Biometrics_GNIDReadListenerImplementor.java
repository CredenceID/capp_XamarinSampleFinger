package mono.com.credenceid.biometrics;


public class Biometrics_GNIDReadListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.credenceid.biometrics.Biometrics.GNIDReadListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onGIDRead:(Lcom/credenceid/biometrics/Biometrics$ResultCode;Lcom/credenceid/icao/ICAOReadIntermediateCode;Ljava/lang/String;Lcom/credenceid/icao/GIdData;)V:GetOnGIDRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_icao_ICAOReadIntermediateCode_Ljava_lang_String_Lcom_credenceid_icao_GIdData_Handler:Com.Credenceid.Biometrics.IBiometricsGNIDReadListenerInvoker, CredenceBindings\n" +
			"";
		mono.android.Runtime.register ("Com.Credenceid.Biometrics.IBiometricsGNIDReadListenerImplementor, CredenceBindings", Biometrics_GNIDReadListenerImplementor.class, __md_methods);
	}


	public Biometrics_GNIDReadListenerImplementor ()
	{
		super ();
		if (getClass () == Biometrics_GNIDReadListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Credenceid.Biometrics.IBiometricsGNIDReadListenerImplementor, CredenceBindings", "", this, new java.lang.Object[] {  });
	}


	public void onGIDRead (com.credenceid.biometrics.Biometrics.ResultCode p0, com.credenceid.icao.ICAOReadIntermediateCode p1, java.lang.String p2, com.credenceid.icao.GIdData p3)
	{
		n_onGIDRead (p0, p1, p2, p3);
	}

	private native void n_onGIDRead (com.credenceid.biometrics.Biometrics.ResultCode p0, com.credenceid.icao.ICAOReadIntermediateCode p1, java.lang.String p2, com.credenceid.icao.GIdData p3);

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
