using UnityEngine;
using System.Collections;

public class gearMovement : MonoBehaviour {

	Rigidbody body;
	
	// Update is called once per frame
	//fixes gear in place and allows for a single axis of rotation
	void Update () {
		body = GetComponent<Rigidbody>();
		body.constraints = RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezePosition;
	}
}
