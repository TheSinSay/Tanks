using UnityEngine;
using System.Collections;

public class Mina : MonoBehaviour {
	public bool colid;
	void OnTriggerEnter(Collider other) {
		colid = true;
	}
	void Start () {
	
	}
	void Update () {
	}
}
