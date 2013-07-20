using UnityEngine;
using System.Collections;

public class DetectNets : MonoBehaviour {
	public bool b = false;
	public bool b1 = false;
	public GameObject CurrentPref;
	/*void OnTriggerEnter(Collider other)
	{
		b = true;
		if(other.CompareTag("Build"))
		{
			AI aim = (AI)other.GetComponent("AI");
			if(aim.active_My)
			{
				this.gameObject.tag = "PlacementPlane_Taken";
			}
		}
	}*/
	
	void Update(){
	if (CurrentPref==null){
				this.tag = "PlacementPlane_Open";
				//b1 = false;
				}
		if (CurrentPref!=null){
				this.tag = "PlacementPlane_Taken";
				//b1 = true;
				}
	}
	
	void OnTriggerEnter(Collider other)
	{
		
		b = true;
		if(other.CompareTag("Active"))
		{
			print ("На сетке стоит куб");
			CurrentPref=other.gameObject;
//			foreach (Transform childMat in other.transform)
//						if (childMat.name=="TransRed") childMat.active=true;
			Build bild = (Build)other.GetComponent("Build");
			if(bild.active_My)
			{
//				if (!CurrentPref==null){
//				this.tag = "PlacementPlane_Taken";
//				b1 = true;
//				}
				
			}
		} 
	}
	
	void Start () {
	}
	
}
