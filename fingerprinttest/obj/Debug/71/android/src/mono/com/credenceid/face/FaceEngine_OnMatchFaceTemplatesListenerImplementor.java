package mono.com.credenceid.face;


public class FaceEngine_OnMatchFaceTemplatesListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.credenceid.face.FaceEngine.OnMatchFaceTemplatesListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onMatchFaceTemplates:(Lcom/credenceid/biometrics/Biometrics$ResultCode;I)V:GetOnMatchFaceTemplates_Lcom_credenceid_biometrics_Biometrics_ResultCode_IHandler:Com.Credenceid.Face.IFaceEngineOnMatchFaceTemplatesListenerInvoker, CredenceBindings\n" +
			"";
		mono.android.Runtime.register ("Com.Credenceid.Face.IFaceEngineOnMatchFaceTemplatesListenerImplementor, CredenceBindings", FaceEngine_OnMatchFaceTemplatesListenerImplementor.class, __md_methods);
	}


	public FaceEngine_OnMatchFaceTemplatesListenerImplementor ()
	{
		super ();
		if (getClass () == FaceEngine_OnMatchFaceTemplatesListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Credenceid.Face.IFaceEngineOnMatchFaceTemplatesListenerImplementor, CredenceBindings", "", this, new java.lang.Object[] {  });
	}


	public void onMatchFaceTemplates (com.credenceid.biometrics.Biometrics.ResultCode p0, int p1)
	{
		n_onMatchFaceTemplates (p0, p1);
	}

	private native void n_onMatchFaceTemplates (com.credenceid.biometrics.Biometrics.ResultCode p0, int p1);

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
