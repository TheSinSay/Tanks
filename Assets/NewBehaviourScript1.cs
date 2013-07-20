
using UnityEngine;
using System.Collections;

public class NewBehaviourScript1 : MonoBehaviour {
	public Camera cam;
	public GameObject prefab;
	public Transform bulletSpawn;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		GameInterface gi = (GameInterface)cam.GetComponent("GameInterface");
		Ray ray = cam.ScreenPointToRay (Input.mousePosition);
        RaycastHit hit = new RaycastHit();
        if (Physics.Raycast (ray, out hit))
        {
            Vector3 rot = transform.eulerAngles;
            transform.LookAt(hit.point);
            transform.eulerAngles = new Vector3(rot.x, transform.eulerAngles.y-90, rot.z);
        }
		if (!gi.StratMod)
		{
			if (Input.GetMouseButtonDown(0))
			{
				Shoot();
			}
		}
	}
	public void Shoot()
	{
		Instantiate(prefab,bulletSpawn.position,bulletSpawn.rotation);
	}
}
