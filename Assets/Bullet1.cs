using UnityEngine;
using System.Collections;

public class Bullet1 : MonoBehaviour {

	public GameObject target;
	void Start () {
	
	}
	
	void Update () {
		Vector3 rot = transform.eulerAngles;
		transform.LookAt(target.transform);
		transform.eulerAngles = new Vector3(rot.x, transform.eulerAngles.y-90, rot.z);
	}
}
