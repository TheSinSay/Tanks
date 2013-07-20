using UnityEngine;
using System.Collections;

public class AspectGuiPanel : MonoBehaviour {

private GUITexture myGUITexture;
public float coor_x=0.0f;
public float coor_x1=0.0f;
public float coor_y=0;
public float size_x=0.0f;
public float size_y=0.0f;
public Camera cam;
	private float asp=0.0f; 
	public bool is_wavePan=false;
//	private GUILayer test;
 
void Awake()
{
    myGUITexture = this.gameObject.GetComponent("GUITexture") as GUITexture;
	//asp=Mathf.Round(cam.aspect);
}
 
// Use this for initialization
void Update()
{
	asp = Mathf.Round(cam.aspect * 100.0f) / 100.0f;
    // Position the billboard in the center, 
    // but respect the picture aspect ratio
    int textureHeight = guiTexture.texture.height;
    int textureWidth = guiTexture.texture.width;
    int screenHeight = Screen.height;
    int screenWidth = Screen.width;
 
    int screenAspectRatio = (screenWidth / screenHeight);
    int textureAspectRatio = (textureWidth / textureHeight);
 
    int scaledHeight;
    int scaledWidth;
    if (textureAspectRatio <= screenAspectRatio)
    {
        // The scaled size is based on the height
        scaledHeight = screenHeight;
        scaledWidth = (screenHeight * textureAspectRatio);
    }
    else
    {
        // The scaled size is based on the width
        scaledWidth = screenWidth;
        scaledHeight = (scaledWidth / textureAspectRatio);
    }
    float xPosition = screenWidth / coor_x + (scaledWidth / coor_x1);
		if (is_wavePan){
		if (asp==1.25f) {coor_x=-17.88f;coor_x1=7.36f;coor_y=6.61f;size_x=2.4f;size_y=1.77f;}
		if (asp==1.33f) {coor_x=-17.88f;coor_x1=7.36f;coor_y=9.75f;size_x=2.4f;size_y=1.77f;}
		if (asp==1.5f) {coor_x=-20.8f;coor_x1=7.26f;coor_y=41.9f;size_x=2.4f;size_y=1.77f;}
		if (asp==1.6f) {coor_x=-20.8f;coor_x1=7.26f;coor_y=41.9f;size_x=2.4f;size_y=1.77f;}
		if (asp==1.78f) {coor_x=1.7f;coor_x1=-2;coor_y=-25.87f;size_x=2.4f;size_y=1.77f;}
		}
//		if (is_butBar){
//		if (asp==1.25f) { coor_x=-2;coor_x1=190.27f;coor_y=3.33f;size_x=5;size_y=3.32f;}
//    	if (asp==1.33f) {coor_x=-2;coor_x1=7.3f;coor_y=-4.53f;size_x=18.4f;size_y=9.84f;}
//		if (asp==1.5f) {coor_x=-2;coor_x1=7.3f;coor_y=-4.53f;size_x=18.4f;size_y=9.84f;}
//		if (asp==1.6f) {coor_x=-2;coor_x1=7.3f;coor_y=-5.1f;size_x=18.4f;size_y=9.84f;}
//		if (asp==1.78f) {coor_x=-2;coor_x1=7.3f;coor_y=-5.13f;size_x=18.4f;size_y=9.84f;}
//		}
			myGUITexture.pixelInset = 
        new Rect(screenWidth / coor_x+screenWidth / coor_x1,scaledHeight/coor_y+scaledHeight/cam.aspect, 
        scaledWidth/size_x, scaledHeight/size_y);
	
//		 if (test.HitTest(Input.mousePosition) != null)
//            Debug.Log(test.HitTest(Input.mousePosition).name);
//}
//	 void Example() {
//        test = cam.main.GetComponent<GUILayer>();
   }
}
