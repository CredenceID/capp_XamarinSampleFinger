package com.biometricstest.mobile.FingerprintTest;


public class MainActivity_GrabFingerTwoListener
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.credenceid.biometrics.Biometrics.OnFingerprintGrabbedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCloseFingerprintReader:(Lcom/credenceid/biometrics/Biometrics$ResultCode;Lcom/credenceid/biometrics/Biometrics$CloseReasonCode;)V:GetOnCloseFingerprintReader_Lcom_credenceid_biometrics_Biometrics_ResultCode_Lcom_credenceid_biometrics_Biometrics_CloseReasonCode_Handler:Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedListenerInvoker, CredenceBindings\n" +
			"n_onFingerprintGrabbed:(Lcom/credenceid/biometrics/Biometrics$ResultCode;Landroid/graphics/Bitmap;[BLjava/lang/String;Ljava/lang/String;)V:GetOnFingerprintGrabbed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_Bitmap_arrayBLjava_lang_String_Ljava_lang_String_Handler:Com.Credenceid.Biometrics.IBiometricsOnFingerprintGrabbedListenerInvoker, CredenceBindings\n" +
			"";
		mono.android.Runtime.register ("FingerprintTest.MainActivity+GrabFingerTwoListener, SampleFingerprint", MainActivity_GrabFingerTwoListener.class, __md_methods);
	}


	public MainActivity_GrabFingerTwoListener ()
	{
		super ();
		if (getClass () == MainActivity_GrabFingerTwoListener.class)
			mono.android.TypeManager.Activate ("FingerprintTest.MainActivity+GrabFingerTwoListener, SampleFingerprint", "", this, new java.lang.Object[] {  });
	}


	public void onCloseFingerprintReader (com.credenceid.biometrics.Biometrics.ResultCode p0, com.credenceid.biometrics.Biometrics.CloseReasonCode p1)
	{
		n_onCloseFingerprintReader (p0, p1);
	}

	private native void n_onCloseFingerprintReader (com.credenceid.biometrics.Biometrics.ResultCode p0, com.credenceid.biometrics.Biometrics.CloseReasonCode p1);


	public void onFingerprintGrabbed (com.credenceid.biometrics.Biometrics.ResultCode p0, android.graphics.Bitmap p1, byte[] p2, java.lang.String p3, java.lang.String p4)
	{
		n_onFingerprintGrabbed (p0, p1, p2, p3, p4);
	}

	private native void n_onFingerprintGrabbed (com.credenceid.biometrics.Biometrics.ResultCode p0, android.graphics.Bitmap p1, byte[] p2, java.lang.String p3, java.lang.String p4);

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
