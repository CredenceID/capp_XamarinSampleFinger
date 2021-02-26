package mono.com.credenceid.face;


public class FaceEngine_OnCreateFaceTemplateListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.credenceid.face.FaceEngine.OnCreateFaceTemplateListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreateFaceTemplate:(Lcom/credenceid/biometrics/Biometrics$ResultCode;[B)V:GetOnCreateFaceTemplate_Lcom_credenceid_biometrics_Biometrics_ResultCode_arrayBHandler:Com.Credenceid.Face.IFaceEngineOnCreateFaceTemplateListenerInvoker, CredenceBindings\n" +
			"";
		mono.android.Runtime.register ("Com.Credenceid.Face.IFaceEngineOnCreateFaceTemplateListenerImplementor, CredenceBindings", FaceEngine_OnCreateFaceTemplateListenerImplementor.class, __md_methods);
	}


	public FaceEngine_OnCreateFaceTemplateListenerImplementor ()
	{
		super ();
		if (getClass () == FaceEngine_OnCreateFaceTemplateListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Credenceid.Face.IFaceEngineOnCreateFaceTemplateListenerImplementor, CredenceBindings", "", this, new java.lang.Object[] {  });
	}


	public void onCreateFaceTemplate (com.credenceid.biometrics.Biometrics.ResultCode p0, byte[] p1)
	{
		n_onCreateFaceTemplate (p0, p1);
	}

	private native void n_onCreateFaceTemplate (com.credenceid.biometrics.Biometrics.ResultCode p0, byte[] p1);

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
