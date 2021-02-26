package mono.com.credenceid.biometrics;


public class Biometrics_OnMRZReaderListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.credenceid.biometrics.Biometrics.OnMRZReaderListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onMRZRead:(Lcom/credenceid/biometrics/Biometrics$ResultCode;Ljava/lang/String;[BLjava/lang/String;Ljava/lang/String;)V:GetOnMRZRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_arrayBLjava_lang_String_Ljava_lang_String_Handler:Com.Credenceid.Biometrics.IBiometricsOnMRZReaderListenerInvoker, CredenceBindings\n" +
			"";
		mono.android.Runtime.register ("Com.Credenceid.Biometrics.IBiometricsOnMRZReaderListenerImplementor, CredenceBindings", Biometrics_OnMRZReaderListenerImplementor.class, __md_methods);
	}


	public Biometrics_OnMRZReaderListenerImplementor ()
	{
		super ();
		if (getClass () == Biometrics_OnMRZReaderListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Credenceid.Biometrics.IBiometricsOnMRZReaderListenerImplementor, CredenceBindings", "", this, new java.lang.Object[] {  });
	}


	public void onMRZRead (com.credenceid.biometrics.Biometrics.ResultCode p0, java.lang.String p1, byte[] p2, java.lang.String p3, java.lang.String p4)
	{
		n_onMRZRead (p0, p1, p2, p3, p4);
	}

	private native void n_onMRZRead (com.credenceid.biometrics.Biometrics.ResultCode p0, java.lang.String p1, byte[] p2, java.lang.String p3, java.lang.String p4);

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
