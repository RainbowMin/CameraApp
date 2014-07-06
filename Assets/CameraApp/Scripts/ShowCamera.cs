using UnityEngine;
using System.Collections;

public class ShowCamera : MonoBehaviour {

	public Texture2D _texture;
	public GameObject _object;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		MeshRenderer renderer = _object.GetComponent<MeshRenderer> ();
		renderer.material.mainTexture = _texture;
	}
}
