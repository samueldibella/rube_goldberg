using UnityEngine;
using System.Collections;

public class grondTrigger : MonoBehaviour {
	
	//public vars for camera objects
	public Camera gearCamera;
	public Camera grondCamera;
	
	void OnTriggerEnter(Collider other) {
		gearCamera.enabled = false;
		grondCamera.enabled = true;
	}
}
