package mono.com.credenceid.biometrics;


public class Biometrics_OnEktpCardReadListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.credenceid.biometrics.Biometrics.OnEktpCardReadListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_OnEktpCardRead:(Lcom/credenceid/biometrics/Biometrics$ResultCode;Ljava/lang/String;[B)V:GetOnEktpCardRead_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_arrayBHandler:Com.Credenceid.Biometrics.IBiometricsOnEktpCardReadListenerInvoker, CredenceBindings\n" +
			"";
		mono.android.Runtime.register ("Com.Credenceid.Biometrics.IBiometricsOnEktpCardReadListenerImplementor, CredenceBindings", Biometrics_OnEktpCardReadListenerImplementor.class, __md_methods);
	}


	public Biometrics_OnEktpCardReadListenerImplementor ()
	{
		super ();
		if (getClass () == Biometrics_OnEktpCardReadListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Credenceid.Biometrics.IBiometricsOnEktpCardReadListenerImplementor, CredenceBindings", "", this, new java.lang.Object[] {  });
	}


	public void OnEktpCardRead (com.credenceid.biometrics.Biometrics.ResultCode p0, java.lang.String p1, byte[] p2)
	{
		n_OnEktpCardRead (p0, p1, p2);
	}

	private native void n_OnEktpCardRead (com.credenceid.biometrics.Biometrics.ResultCode p0, java.lang.String p1, byte[] p2);

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
