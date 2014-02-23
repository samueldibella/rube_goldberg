using UnityEngine;
using System.Collections;

//activates gearCamera and switches off first camera
public class gearTrigger : MonoBehaviour {

	//public vars for camera objects
	public Camera firstCamera;
	public Camera gearCamera;
	
	//text objects
	public GameObject reloadText;
	public GameObject rampText;
	public GameObject bucketText;
	public GameObject gearText;
	
	void OnTriggerEnter(Collider other) {
		firstCamera.enabled = false;
		gearCamera.enabled = true;
		bucketText.GetComponent<TextMesh>().text = "The Bucket";
		gearText.GetComponent<TextMesh>().text = "The Gear";
		reloadText.GetComponent<TextMesh>().text = "";
		rampText.GetComponent<TextMesh>().text = "";
	}
}
