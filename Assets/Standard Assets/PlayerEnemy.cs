using UnityEngine;
using System.Collections;

public class PlayerEnemy : MonoBehaviour {
	
	public GameObject BulletTanks ;
	public GameObject Flash ;
	public Transform bulletSpawnTanks;
	public Transform target;
	public float enemyTime=0;
	public float frequency=0;

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
		enemyTime+=1;
		if (enemyTime==frequency){
		gameObject.audio.Play();
		Instantiate(Flash,bulletSpawnTanks.position,bulletSpawnTanks.rotation);
		Instantiate(BulletTanks,bulletSpawnTanks.position,bulletSpawnTanks.rotation);
				enemyTime=0;
		}
        Vector3 rot = transform.eulerAngles;
		transform.LookAt(target.transform);
		transform.eulerAngles = new Vector3(rot.x, transform.eulerAngles.y-90, rot.z);
		 
    }
	}
}
