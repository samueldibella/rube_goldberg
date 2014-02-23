using UnityEngine;
using System.Collections;

//activates gearCamera and switches off first camera
public class gearTrigger : MonoBehaviour {

	//public vars for camera objects
	public Camera firstCamera;
	public Camera gearCamera;

	void OnTriggerEnter(Collider other) {
		firstCamera.enabled = false;
		gearCamera.enabled = true;
	}
}
