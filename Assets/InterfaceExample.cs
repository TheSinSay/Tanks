using UnityEngine;
using System.Collections;

public class InterfaceExample : MonoBehaviour {
	
	public bool submitPressed = false;
	public GUIStyle MyGUIStyle;
	void OnGUI()
	{
		GUI.Label(new Rect(300,0,100,50),"Menu");
		if (GUI.Button(new Rect(300,30,100,50),"Play",MyGUIStyle))
		{
		}
		if (GUI.Button(new Rect(300,90,100,20),"Pause"))
		{
			submitPressed = true;
		}
		if (GUI.Button(new Rect(300,240,100,20),"Unpause"))
		{
			submitPressed = false;
		}
		if(submitPressed)
		{
			GUI.Box(new Rect(200,120,320,110),"Game is paused");
		}
		
	}
	void Start () {
	
	}
	
	void Update () {
	}
}
