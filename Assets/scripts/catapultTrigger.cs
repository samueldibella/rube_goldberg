using UnityEngine;
using System.Collections;

public class catapultTrigger : MonoBehaviour {
	
	//public vars for camera objects
	public Camera grondCamera;
	public Camera catapultCamera;
	
	//text objects
	public GameObject catapultText;
	public GameObject grondText;
	public GameObject fanText;
	
	//moves active camera onto next
	void OnTriggerEnter(Collider other) {
		grondCamera.enabled = false;
		catapultCamera.enabled = true;
		catapultText.GetComponent<TextMesh>().text = "The Catapult";
		grondText.GetComponent<TextMesh>().text = "";
		fanText.GetComponent<TextMesh>().text = "";
	}
}
