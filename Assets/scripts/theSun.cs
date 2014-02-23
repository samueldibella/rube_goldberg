using UnityEngine;
using System.Collections;

public class theSun : MonoBehaviour {

	public ParticleSystem corona1;
	public ParticleSystem corona2;
	public ParticleSystem corona3;
	
	void OnTriggerEnter(Collider other) {
		Destroy(other);
		corona1.enableEmission = true;
		corona2.enableEmission = true;
		corona3.enableEmission = true;
	}
}
