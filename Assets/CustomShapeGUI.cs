///////////////////////////////////////////////////////////////////////
//                                                   41 Post                                       //
// Non-Rectangular GUI Buttons - Part 3                                            //
// Created by DimasTheDriver in 17/Jan/2011                                      //
// Part of the 'Non-Rectangular GUI Buttons' post series.                    //
// Availiable at:       http://www.41post.com/?p=2561                            //
/////////////////////////////////////////////////////////////////////

using UnityEngine;
using System.Collections;

public class CustomShapeGUI : MonoBehaviour 
{
	public bool isHovering1 = false;
	public bool isHovering2 = false;
	public Camera cam;
	public float widthper;
	public float heightper;
	//a variable to store the GUISkin
	public GUISkin guiskin;
	//a variable to store the GUI camera
	public Camera cShapeGUIcamera;
	
	//a variable that is used to check if the mouse is over the button
	private bool isHovering = false;
	
	//a variable that is used to check if the mouse has been clicked
	private bool isDown = false;
	
	//a ray to be cast
	private Ray ray;
	
	//create a RaycastHit to query information about the collisions
	private RaycastHit hit;
	
	void Update()
	{
		widthper = Screen.width / (float)100;
		heightper = Screen.height / (float)100;
		//cast a ray based on the mouse position on the screen
		ray = cShapeGUIcamera.ScreenPointToRay(Input.mousePosition);
		
		//Check for raycast collisions with anything
        if (Physics.Raycast(ray, out hit, 10)) 
		{
			//if the name of what we have collided is "irregular_shape"
			if(hit.transform.name=="irregular_shape")
			{
				//set collided variable to true
				isHovering = true;
			
				//if the mouse buton have been pressed while the cursor was over the button
				if(Input.GetButton("Fire1")) 
				{
					//if clicked, mouse button is down
					isDown = true;
				}
				else
				{
					//the mouse button have been released
					isDown = false;
				}
			}
        }
		if (Physics.Raycast(ray, out hit, 10)) 
		{
			//if the name of what we have collided is "irregular_shape"
			if(hit.transform.name=="Button")
			{
				//set collided variable to true
				isHovering1 = true;
			}
			if(hit.transform.name=="Button1")
			{
				//set collided variable to true
				isHovering2 = true;
				GameInterface gi = (GameInterface)cam.GetComponent("GameInterface");
				gi.StratMod = true;
			}
        }
		else //ray is not colliding,
		{
			//set collided to false
			isHovering = false;
			isHovering1 = false;
			
			isHovering2 = false;
			GameInterface ginter = (GameInterface)cam.GetComponent("GameInterface");
			ginter.interfaceusing = false;
			ginter.StratMod = false;
		}
	}
	
	void OnGUI()
	{
		if (isHovering1)
		{
			GameInterface ginter = (GameInterface)cam.GetComponent("GameInterface");
			ginter.vverx = true;
		}
		if (isHovering2)
		{
			GameInterface ginter = (GameInterface)cam.GetComponent("GameInterface");
			ginter.interfaceusing = true;
		}
		//if mouse cursor is not inside the button area
		/*if(!isHovering)
		{
			//draws the normal state
			GUI.Label(new Rect(widthper * (480 / (float)10.9),heightper * ( 0 / (float)7.3),widthper *( 100/ (float)10.9),heightper * (80/ (float)7.3)),"",guiskin.customStyles[0]);
			
			//set mouse click down to false
			isDown = false;
		}
		else //mouse is inside the button area
		{
			//draws the hover state
			GUI.Label(new Rect(widthper * (480 / (float)10.9),heightper * ( 0 / (float)7.3),widthper *( 100/ (float)10.9),heightper * (80/ (float)7.3)),"",guiskin.customStyles[1]);
			
			//if the mouse has been clicked while the cursor was over the button
			if(isDown)
			{
				//draws the 'Pressed' state
				GUI.Label(new Rect(widthper * (480 / (float)10.9),heightper * ( 0 / (float)7.3),widthper *( 100/ (float)10.9),heightper * (80/ (float)7.3)),"",guiskin.customStyles[2]);
				GameInterface ginter = (GameInterface)cam.GetComponent("GameInterface");
				//ginter.startMission = true;
				//GameInterface gi = (GameInterface)camera.GetComponent("GameInterface");
			}
		}*/
	}
}
