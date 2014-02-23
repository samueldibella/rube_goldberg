using UnityEngine;
using System.Collections;

public class theSun : MonoBehaviour {
	
	public GameObject sunText;
	public GameObject catapultText;
	Rigidbody body;
	
	//drops sun and displays text on sphere collision
	void OnTriggerEnter(Collider other) {
		Destroy(other.gameObject);
		body = GetComponent<Rigidbody>();
		body.useGravity = true;
		sunText.GetComponent<TextMesh>().text = "YOU HAVE ANGERED\n THE SUN GOD";
		catapultText.GetComponent<TextMesh>().text = "";
	}
}
