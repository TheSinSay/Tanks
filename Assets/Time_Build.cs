using UnityEngine;
using System.Collections;

public class Time_Build : MonoBehaviour {
	public float skrittime = 10.0f;
	public GameObject Cub1;
	public GameObject Cub2;
	public GameObject Cub3;
	public GameObject Timer;
	public bool step2 = false;
	public bool step3 = false;
	public int i = 0;
	void Start () {
		TextMesh tm = (TextMesh)Timer.GetComponent("Text Mesh");
		tm.text = "Hi";
		skrittime = 10.0f;
		Cub2.SetActive(false);
		Cub3.SetActive(false);
	}
	
	void Update () {
		//GameInterface gi = (GameInterface)cam.GetComponent("GameInterface");
		TextMesh tm = (TextMesh)Timer.GetComponent("Text Mesh");
		if (skrittime > 0)
		{
			skrittime -= Time.deltaTime;
		}
		if (skrittime < 0)
			skrittime = 0;
		if (skrittime == 0)
		{
			if (!step2)
			{
				step2 = true;
				skrittime = 10.0f;
			}
			i++;
			if (i == 2)
			{
				if (step2)
				{
					step3 = true;
					skrittime = 0;
				}
			}
		}
		if (step2)
		{
			Cub2.SetActive(true);
		}
		if (step3)
		{
			Cub3.SetActive(true);
		}
	}
}

