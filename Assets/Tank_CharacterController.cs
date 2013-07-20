using UnityEngine;
using System.Collections;

public class Tank_CharacterController : MonoBehaviour {
	public Camera cam;
	public GameObject prefab;
	public Transform tank;
	public Transform Basnyapart1;
	public Transform Basnyapart2;
	public Transform bulletSpawn;
	void Start () {
	}
	void Update () {
		/*Ray ray = cam.ScreenPointToRay (Input.mousePosition);
        RaycastHit hit = new RaycastHit();
        if (Physics.Raycast (ray, out hit))
        {
            Vector3 rot = transform.eulerAngles;
            tank.GetChild(2).LookAt(hit.point);
            tank.GetChild(2).eulerAngles = new Vector3(rot.x, transform.eulerAngles.y-90, rot.z);
        }*/
		//if (Input.GetMouseButtonDown(0))
		//	Shoot();
		if(Input.GetKey(KeyCode.W))
		{
			tank.Translate(0.025f,0,0);
		}
		if(Input.GetKey(KeyCode.A))
		{
			tank.Rotate(0,0,-1);
		}
		if(Input.GetKey(KeyCode.S))
		{
			tank.Translate(-0.025f,0,0);
		}
		if(Input.GetKey(KeyCode.D))
		{
			tank.Rotate(0,0,1);
		}
	} 
	public void Shoot()
	{
		Instantiate(prefab,bulletSpawn.position,transform.rotation);
	}
}
