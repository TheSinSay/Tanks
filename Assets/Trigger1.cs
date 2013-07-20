using UnityEngine;
using System.Collections;

public class Trigger1 : MonoBehaviour {
	void OnTriggerEnter(Collider collision) {
		Destroy(collision.gameObject);
	}
	void Start () {
	
	}
	void Update () {
	
	}
}
