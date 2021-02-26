package com.biometricstest.mobile.FingerprintTest;


public class MainActivity_ConvertToFMDListener
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.credenceid.biometrics.Biometrics.OnConvertToFMDListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onConvertToFMD:(Lcom/credenceid/biometrics/Biometrics$ResultCode;[B)V:GetOnConvertToFMD_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayBHandler:Com.Credenceid.Biometrics.IBiometricsOnConvertToFMDListenerInvoker, CredenceBindings\n" +
			"";
		mono.android.Runtime.register ("FingerprintTest.MainActivity+ConvertToFMDListener, SampleFingerprint", MainActivity_ConvertToFMDListener.class, __md_methods);
	}


	public MainActivity_ConvertToFMDListener ()
	{
		super ();
		if (getClass () == MainActivity_ConvertToFMDListener.class)
			mono.android.TypeManager.Activate ("FingerprintTest.MainActivity+ConvertToFMDListener, SampleFingerprint", "", this, new java.lang.Object[] {  });
	}


	public void onConvertToFMD (com.credenceid.biometrics.Biometrics.ResultCode p0, byte[] p1)
	{
		n_onConvertToFMD (p0, p1);
	}

	private native void n_onConvertToFMD (com.credenceid.biometrics.Biometrics.ResultCode p0, byte[] p1);

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
