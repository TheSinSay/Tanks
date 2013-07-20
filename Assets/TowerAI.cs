using UnityEngine;
using System.Collections;

public class TowerAI : MonoBehaviour {
	public GameObject myProjectile;
	public float reloadTime = 1f;
	public float turnSpeed = 5f;
	public float firePauseTime = 0.25f;
	public GameObject muzzleEffect;
	public float errorAmount = 0.001f;
	public Transform myTarget;
	public Transform[] muzzlePositions;
	public Transform turretBall;
	
	private float nextFireTime;
	private float nextMoveTime;
	private Quaternion desiredRotation;
	private float aimError;
	void Start () {		
	}

	public Vector3 CalculateAimPosition(Vector3 targetPos)
	{
		//Vector3 aimPoint = Vector3(targetPos.x + aimError, targetPos.y + aimError, target.Pos.z + aimError);
		Vector3 aimPoint = new Vector3(targetPos.x, targetPos.y, targetPos.z);
		desiredRotation = Quaternion.LookRotation(aimPoint);
		Debug.DrawLine(transform.position,aimPoint);
		return aimPoint;
	}
	
	public void CalculateAimError()
	{
		//aimError = Random.Range(-errorAmount, errorAmount);
	}
	public void FireProjectile()
	{
		//audio.Play();
		nextFireTime = Time.time + reloadTime;
		nextMoveTime = Time.time + firePauseTime;
		//CalculateAimError();
		if (nextFireTime == 0)
			Instantiate(myProjectile, transform.position, transform.rotation);
		/*foreach(Transform theMuzzlePos in muzzlePositions)
		{
			//Instantiate(myProjectile, theMuzzlePos.position, theMuzzlePos.rotation);
			//Instantiate(muzzleEffect,theMuzzlePos.position, theMuzzlePos.rotation);
		}*/
	}
	public void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Enemy")
		{
			nextFireTime = Time.time + (reloadTime*0.5f);
			myTarget = other.gameObject.transform;
		}
	}
	public void OnTriggerExit(Collider other)
	{
		if(other.gameObject.transform == myTarget)
		{
			myTarget = null;
		}
	}
	void Update () {
		print(nextFireTime.ToString());
		if(myTarget)
		{
			if(Time.time >= nextMoveTime)
			{
				Vector3 point = CalculateAimPosition(myTarget.position);
				//turretBall.rotation = Quaternion.Lerp(turretBall.rotation, desiredRotation, Time.deltaTime*turnSpeed);
				Vector3 rot = transform.eulerAngles;
            	transform.LookAt(point);
            	transform.eulerAngles = new Vector3(rot.x, transform.eulerAngles.y-90, rot.z);
			}
			if (Time.time >= nextFireTime)
			{
				FireProjectile();
			}
		}
	}
}
