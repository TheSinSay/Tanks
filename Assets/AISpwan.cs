using UnityEngine;
using System.Collections;

public class AISpwan : MonoBehaviour {
	
	public GameObject target;
	void Start () {
		target = GameObject.FindGameObjectWithTag("Enemy");
	}
	
	void Update () {
		Vector3 rot = transform.eulerAngles;
		transform.LookAt(target.transform);
		transform.eulerAngles = new Vector3(rot.x, transform.eulerAngles.y-90, rot.z);
	}
}
