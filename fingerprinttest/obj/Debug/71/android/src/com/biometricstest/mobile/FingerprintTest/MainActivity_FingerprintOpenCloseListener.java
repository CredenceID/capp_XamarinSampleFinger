package com.biometricstest.mobile.FingerprintTest;


public class MainActivity_FingerprintOpenCloseListener
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.credenceid.biometrics.Biometrics.FingerprintReaderStatusListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCloseFingerprintReader:(Lcom/credenceid/biometrics/Biometrics$ResultCode;Lcom/credenceid/biometrics/Biometrics$CloseReasonCode;)V:GetOnCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_Handler:Com.Credenceid.Biometrics.IBiometricsFingerprintReaderStatusListenerInvoker, CredenceBindings\n" +
			"n_onOpenFingerprintReader:(Lcom/credenceid/biometrics/Biometrics$ResultCode;Ljava/lang/String;)V:GetOnOpenFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Ljava_lang_String_Handler:Com.Credenceid.Biometrics.IBiometricsFingerprintReaderStatusListenerInvoker, CredenceBindings\n" +
			"";
		mono.android.Runtime.register ("FingerprintTest.MainActivity+FingerprintOpenCloseListener, SampleFingerprint", MainActivity_FingerprintOpenCloseListener.class, __md_methods);
	}


	public MainActivity_FingerprintOpenCloseListener ()
	{
		super ();
		if (getClass () == MainActivity_FingerprintOpenCloseListener.class)
			mono.android.TypeManager.Activate ("FingerprintTest.MainActivity+FingerprintOpenCloseListener, SampleFingerprint", "", this, new java.lang.Object[] {  });
	}


	public void onCloseFingerprintReader (com.credenceid.biometrics.Biometrics.ResultCode p0, com.credenceid.biometrics.Biometrics.CloseReasonCode p1)
	{
		n_onCloseFingerprintReader (p0, p1);
	}

	private native void n_onCloseFingerprintReader (com.credenceid.biometrics.Biometrics.ResultCode p0, com.credenceid.biometrics.Biometrics.CloseReasonCode p1);


	public void onOpenFingerprintReader (com.credenceid.biometrics.Biometrics.ResultCode p0, java.lang.String p1)
	{
		n_onOpenFingerprintReader (p0, p1);
	}

	private native void n_onOpenFingerprintReader (com.credenceid.biometrics.Biometrics.ResultCode p0, java.lang.String p1);

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
