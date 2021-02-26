package mono.com.credenceid.face;


public class FaceEngine_OnAnalyzeFaceImageListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.credenceid.face.FaceEngine.OnAnalyzeFaceImageListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onFaceAnalyzed:(Lcom/credenceid/biometrics/Biometrics$ResultCode;Landroid/graphics/RectF;Ljava/util/ArrayList;Ljava/util/ArrayList;[F[Lcom/credenceid/face/FaceEngine$HeadPoseDirection;Lcom/credenceid/face/FaceEngine$Gender;ILcom/credenceid/face/FaceEngine$Emotion;ZI)V:GetOnFaceAnalyzed_Lcom_credenceid_biometrics_Biometrics_ResultCode_Landroid_graphics_RectF_Ljava_util_ArrayList_Ljava_util_ArrayList_arrayFarrayLcom_credenceid_face_FaceEngine_HeadPoseDirection_Lcom_credenceid_face_FaceEngine_Gender_ILcom_credenceid_face_FaceEngine_Emotion_ZIHandler:Com.Credenceid.Face.IFaceEngineOnAnalyzeFaceImageListenerInvoker, CredenceBindings\n" +
			"";
		mono.android.Runtime.register ("Com.Credenceid.Face.IFaceEngineOnAnalyzeFaceImageListenerImplementor, CredenceBindings", FaceEngine_OnAnalyzeFaceImageListenerImplementor.class, __md_methods);
	}


	public FaceEngine_OnAnalyzeFaceImageListenerImplementor ()
	{
		super ();
		if (getClass () == FaceEngine_OnAnalyzeFaceImageListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Credenceid.Face.IFaceEngineOnAnalyzeFaceImageListenerImplementor, CredenceBindings", "", this, new java.lang.Object[] {  });
	}


	public void onFaceAnalyzed (com.credenceid.biometrics.Biometrics.ResultCode p0, android.graphics.RectF p1, java.util.ArrayList p2, java.util.ArrayList p3, float[] p4, com.credenceid.face.FaceEngine.HeadPoseDirection[] p5, com.credenceid.face.FaceEngine.Gender p6, int p7, com.credenceid.face.FaceEngine.Emotion p8, boolean p9, int p10)
	{
		n_onFaceAnalyzed (p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10);
	}

	private native void n_onFaceAnalyzed (com.credenceid.biometrics.Biometrics.ResultCode p0, android.graphics.RectF p1, java.util.ArrayList p2, java.util.ArrayList p3, float[] p4, com.credenceid.face.FaceEngine.HeadPoseDirection[] p5, com.credenceid.face.FaceEngine.Gender p6, int p7, com.credenceid.face.FaceEngine.Emotion p8, boolean p9, int p10);

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
