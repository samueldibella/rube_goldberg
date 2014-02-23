using UnityEngine;
using System.Collections;

//directs camera activation based on how far along the machine is
public class cameraControl : MonoBehaviour {
	
	//public vars for camera objects
	public Camera firstCamera;
	public Camera gearCamera;
	public Camera grondCamera;
	public Camera catapultCamera;
	
	// Use this for initialization
	void Start () {
		firstCamera.enabled = true;
		gearCamera.enabled = false;
		grondCamera.enabled = false;
		catapultCamera.enabled = false;
	}
	
	// Update is called once per frame
	//allows level reset
	void Update () {
	
		if(Input.GetKeyDown(KeyCode.R)) {
			Application.LoadLevel("level1");
		}

	}
}
