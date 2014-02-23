using UnityEngine;
using System.Collections;

public class catapultTrigger : MonoBehaviour {
	
	//public vars for camera objects
	public Camera grondCamera;
	public Camera catapultCamera;
	
	void OnTriggerEnter(Collider other) {
		grondCamera.enabled = false;
		catapultCamera.enabled = true;
	}
}
