using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour 
{
	public bool isHovering2 = false;
	public bool isHovering1 = false;
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
			}
			
        }
		else //ray is not colliding,
		{
			//set collided to false
			isHovering = false;
			isHovering1 = false;
			
			isHovering2 = false;
			Interface inter = (Interface)cam.GetComponent("Interface");

		}
	}
	
	void OnGUI()
	{
		if (isHovering1)
		{
			Interface inter = (Interface)cam.GetComponent("Interface");
			inter.vverx = true;
		}
		//if mouse cursor is not inside the button area*/
		if (isHovering2)
		{
			Interface inter = (Interface)cam.GetComponent("Interface");
		}
		if(!isHovering)
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
				Interface inter = (Interface)cam.GetComponent("Interface");
				inter.startMission = true;
				//GameInterface gi = (GameInterface)camera.GetComponent("GameInterface");
			}
		}
	}
}
