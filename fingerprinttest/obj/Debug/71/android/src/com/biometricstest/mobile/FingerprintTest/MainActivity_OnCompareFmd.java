package com.biometricstest.mobile.FingerprintTest;


public class MainActivity_OnCompareFmd
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.credenceid.biometrics.Biometrics.OnCompareFMDListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCompareFMD:(Lcom/credenceid/biometrics/Biometrics$ResultCode;F)V:GetOnCompareFMD_Lcom_credenceid_biometrics_Biometrics_ResultCode_FHandler:Com.Credenceid.Biometrics.IBiometricsOnCompareFMDListenerInvoker, CredenceBindings\n" +
			"";
		mono.android.Runtime.register ("FingerprintTest.MainActivity+OnCompareFmd, SampleFingerprint", MainActivity_OnCompareFmd.class, __md_methods);
	}


	public MainActivity_OnCompareFmd ()
	{
		super ();
		if (getClass () == MainActivity_OnCompareFmd.class)
			mono.android.TypeManager.Activate ("FingerprintTest.MainActivity+OnCompareFmd, SampleFingerprint", "", this, new java.lang.Object[] {  });
	}


	public void onCompareFMD (com.credenceid.biometrics.Biometrics.ResultCode p0, float p1)
	{
		n_onCompareFMD (p0, p1);
	}

	private native void n_onCompareFMD (com.credenceid.biometrics.Biometrics.ResultCode p0, float p1);

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
