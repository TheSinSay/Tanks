using UnityEngine;
using System.Collections;

public class Build_MainScreen : MonoBehaviour {
	public GameObject mainCamera;
	public bool active_My = false;
	public bool a1 = false;
	public string Name = "Issledovatelskiy Centr";
	public string Opisanie = "";
	void OnTriggerStay(Collider other)
	{
		if(!active_My)
		{
			if(other.CompareTag("PlacementPlane_Taken"))
			{
				Interface gi = (Interface)mainCamera.GetComponent("Interface");
				gi.canCreate = false;
				a1 = true;
			}
			if(other.CompareTag("PlacementPlane_Open"))
			{
				Interface gi = (Interface)mainCamera.GetComponent("Interface");
				gi.canCreate = true;
				a1 = false;
			}
			if(other.CompareTag("Build"))
			{
				Interface gi = (Interface)mainCamera.GetComponent("Interface");
				gi.canCreate = false;
				a1 = true;
			}
			if(other.CompareTag("PlacementPlane_Taken"))
			{
				Interface gi = (Interface)mainCamera.GetComponent("Interface");
				gi.canCreate = false;
				a1 = true;
			}
		}
	}
	void Start () {
		Opisanie = "Opisanie";
		Name = "Name_Build";
		mainCamera = GameObject.Find("Main Camera");
	}
	void Update () {
		if (a1)
		{
			Interface gi = (Interface)mainCamera.GetComponent("Interface");
			gi.canCreate = false;
		}
		if (!a1)
		{
			Interface gi = (Interface)mainCamera.GetComponent("Interface");
			gi.canCreate = true;
		}
	}
}
