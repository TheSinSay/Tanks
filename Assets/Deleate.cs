using UnityEngine;
using System.Collections;

public class Deleate : MonoBehaviour {
	public GameObject cub;
	public int i = 0;
	void Start () {
	
	}
	
	void Update () {
		//print(i.ToString());
		//if (i == 1)
			//Destroy(cub);
	}
	public void Destr()
	{
		//i = 1;
		Destroy(cub);
	}
}
