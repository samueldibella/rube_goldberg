using UnityEngine;
using System.Collections;

public class grondTrigger : MonoBehaviour {
	
	//public vars for camera objects
	public Camera gearCamera;
	public Camera grondCamera;
	
	//text object alterations
	public GameObject grondText;
	public GameObject bucketText;
	public GameObject gearText;
	public GameObject fanText;
	
	void OnTriggerEnter(Collider other) {
		gearCamera.enabled = false;
		grondCamera.enabled = true;
		grondText.GetComponent<TextMesh>().text = "GROND";
		bucketText.GetComponent<TextMesh>().text = "";
		gearText.GetComponent<TextMesh>().text = "";
		fanText.GetComponent<TextMesh>().text = "The Fan";
	}
}
