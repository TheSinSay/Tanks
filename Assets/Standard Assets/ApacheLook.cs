using UnityEngine;
using System.Collections;

public class ApacheLook : MonoBehaviour {
	
	public GameObject Bullet ;
	public Transform bulletSpawn1;
	public Transform target;
	public int ttime=0;
	public float x1=0.0f;
	public float y1=0.0f;
	public float z1=0.0f;

	// Use this for initialization
	void Start () {
	}
	
	public Transform GetNearestTaggedObject() {
    // and finally the actual process for finding the nearest object:
 
    var nearestDistanceSqr = Mathf.Infinity;
    var taggedGameObjects = GameObject.FindGameObjectsWithTag("Player");
		
    Transform nearestObj = null;
 
    // loop through each tagged object, remembering nearest one found
    foreach (var obj in taggedGameObjects) {
 
        var objectPos = obj.transform.position;
        var distanceSqr = (objectPos - transform.position).sqrMagnitude;
        if (distanceSqr < nearestDistanceSqr) {
            nearestObj = obj.transform;
            nearestDistanceSqr = distanceSqr;
        }
    }
    return nearestObj;
}
	
	// Update is called once per frame
	void Update () {
		
		target = GetNearestTaggedObject();
		
	if (target != null) {
		ttime+=1;
		if (ttime==30){
		Instantiate(Bullet,bulletSpawn1.position,bulletSpawn1.rotation);
				ttime=0;
		}
        Vector3 rot = transform.eulerAngles;
		transform.LookAt(target.transform);
		//transform.eulerAngles = new Vector3(transform.eulerAngles.y+x1, transform.eulerAngles.y+y1, transform.eulerAngles.y+z1);
		 
    }
	}
}
