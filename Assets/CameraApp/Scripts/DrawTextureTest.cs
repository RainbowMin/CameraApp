using UnityEngine;
using System.Collections;

public class DrawTextureTest : MonoBehaviour {

	//public Texture2D _texture;
	//public Rect _rect;
	public CameraPreviewVideo _cameraVideo;
	public GameObject _object;

	// Use this for initialization
	void Start () 
	{
		_cameraVideo = gameObject.GetComponent<CameraPreviewVideo>();
	}
	
	// Update is called once per frame
	void Update () {
		MeshRenderer renderer = _object.GetComponent<MeshRenderer> ();
		renderer.material.mainTexture = _cameraVideo.webCamTexture;

	}

	void OnGUI()
	{
		//GUI.DrawTexture (_rect, _texture);
	}
}