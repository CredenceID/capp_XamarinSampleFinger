package mono.com.credenceid.face;


public class FaceEngine_OnDetectFaceListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.credenceid.face.FaceEngine.OnDetectFaceListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onDetectFace:(Lcom/credenceid/biometrics/Biometrics$ResultCode;Landroid/graphics/RectF;)V:GetOnDetectFace_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_RectF_Handler:Com.Credenceid.Face.IFaceEngineOnDetectFaceListenerInvoker, CredenceBindings\n" +
			"";
		mono.android.Runtime.register ("Com.Credenceid.Face.IFaceEngineOnDetectFaceListenerImplementor, CredenceBindings", FaceEngine_OnDetectFaceListenerImplementor.class, __md_methods);
	}


	public FaceEngine_OnDetectFaceListenerImplementor ()
	{
		super ();
		if (getClass () == FaceEngine_OnDetectFaceListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Credenceid.Face.IFaceEngineOnDetectFaceListenerImplementor, CredenceBindings", "", this, new java.lang.Object[] {  });
	}


	public void onDetectFace (com.credenceid.biometrics.Biometrics.ResultCode p0, android.graphics.RectF p1)
	{
		n_onDetectFace (p0, p1);
	}

	private native void n_onDetectFace (com.credenceid.biometrics.Biometrics.ResultCode p0, android.graphics.RectF p1);

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
