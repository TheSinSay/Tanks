using UnityEngine;
using System.Collections;

public class Trigger : MonoBehaviour {

	public GameObject camera;
	public bool mes = false;
	
	void OnTriggerEnter(Collider other)
	{
		if (other.collider.tag == "Cub")
			mes = true;
	}
	
	void Start () {
		camera = GameObject.Find("Main Camera");
	}
	
	void Update () {
		//InsertPref ip = (InsertPref)camera.GetComponent("InsertPref");
		GameInterface gi = (GameInterface)camera.GetComponent("GameInterface");
	}
}
