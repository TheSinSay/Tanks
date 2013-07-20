using UnityEngine;
using System.Collections;

public class InsertPref : MonoBehaviour
{
	public Transform pref;
	public bool isCreated = false;
	Transform TPref;
	public int f = 0;
	
	public void insPref()
	{
		if (f == 0) {
			f = 1;
			return;
		}
		if (f == 1) {
			Vector3 inputPos = Input.mousePosition;
			Ray ray = Camera.main.ScreenPointToRay (inputPos);
			RaycastHit rh;
			//if (Physics.Raycast (ray, out rh)) {
			if (Physics.Raycast (ray,out rh)){
				
				if (pref && !isCreated) {
					TPref = Instantiate (pref, rh.point, Quaternion.identity) as Transform;
					isCreated = true;
					
				} else if (isCreated)
					TPref.position = rh.point;
			}
			if (Input.GetMouseButtonDown (0)) {
				if (isCreated)
					isCreated = false;
				f = 0;
			}
		}
	}
	
	void Start()
	{
	}

	void Update ()
	{
		//insPref();
	}
}
