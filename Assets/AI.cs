using UnityEngine;
using System.Collections;

public class AI : MonoBehaviour {
	public Object obj;
	public GameObject target;
	public float skrittime = 0;
	public bool shoot = false;
	public GameObject prefab;
	public Transform bulletSpawn1;
	public Transform bulletSpawn2;
	void Start () {
		skrittime = 0.5f;
		target = GameObject.FindGameObjectWithTag("Enemy");
	}
	void Update () {
		Vector3 rot = transform.eulerAngles;
		transform.LookAt(target.transform);
		transform.eulerAngles = new Vector3(rot.x, transform.eulerAngles.y-90, rot.z);
		if (skrittime > 0)
				skrittime -= Time.deltaTime;
			if (skrittime < 0)
			{
				Shoot();
				skrittime = 0.5f;
			}
			if (skrittime == 0)
			{
				Shoot();
			}
	}
	public void Shoot()
	{
		Instantiate(prefab,bulletSpawn1.position,bulletSpawn1.rotation);
		Instantiate(prefab,bulletSpawn2.position,bulletSpawn2.rotation);
	}
	public void Destr()
	{
		Destroy(obj);
	}
}
