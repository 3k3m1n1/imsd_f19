using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrackeysPortalTextureSetup : MonoBehaviour {

	public Camera portalCamera;

	public Material portalCameraMat;

	// Use this for initialization
	void Start () {
		if (portalCamera.targetTexture != null)
		{
			portalCamera.targetTexture.Release();
		}
		portalCamera.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
		portalCameraMat.mainTexture = portalCamera.targetTexture;

	}
	
}
