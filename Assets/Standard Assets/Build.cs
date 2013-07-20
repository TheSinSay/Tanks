using UnityEngine;
using System.Collections;

public class Build : MonoBehaviour {
	public GameObject mainCamera;
	public bool active_My = false;
	public bool a1 = false;
	
	void OnTriggerEnter(Collider other)
	{
		
		if(!active_My)
		{
			if(other.CompareTag("PlacementPlane_Taken"))
			{
				GameInterface gi = (GameInterface)mainCamera.GetComponent("GameInterface");
				gi.canCreate = false;
				a1 = true;
			}
			if(other.CompareTag("PlacementPlane_Open"))
			{
				GameInterface gi = (GameInterface)mainCamera.GetComponent("GameInterface");
				gi.canCreate = true;
				a1 = false;
			}
			
			if(other.CompareTag("Active"))
			{
				//print("Нельзя сотворить здесь!");
				GameInterface gi = (GameInterface)mainCamera.GetComponent("GameInterface");
				gi.canCreate = false;
				a1 = true;
			}
			
			if(other.CompareTag("PlacementPlane_Taken"))
			{
				GameInterface gi = (GameInterface)mainCamera.GetComponent("GameInterface");
				gi.canCreate = false;
				a1 = true;
			}
		}
	}
	void Start () {
		mainCamera = GameObject.Find("Main Camera");
		GameInterface gi = (GameInterface)mainCamera.GetComponent("GameInterface");
	}
	
	void Update () {
//		if (a1)
//		{
			//print("Нельзя сотворить здесь!");
			//GameInterface gi = (GameInterface)mainCamera.GetComponent("GameInterface");
			//gi.canCreate = false;
//			foreach (Transform childMat1 in transform){
//			if (childMat1.name=="TransRed") childMat1.active=true;
//			if (childMat1.name=="TransWhite") childMat1.active=false;
//			}
//		}
//		if (!a1)
//		{
			//print("Можно сотворить здесь!");
			//GameInterface gi = (GameInterface)mainCamera.GetComponent("GameInterface");
			//gi.canCreate = true;
//			foreach (Transform childMat1 in transform){
//			if (childMat1.name=="TransRed") childMat1.active=false;
//			if (childMat1.name=="TransWhite") childMat1.active=false;
//			}
		//}
	}
}
