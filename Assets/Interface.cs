using UnityEngine;
using System.Collections;

//Никита
//Никита

public class Interface : MonoBehaviour {
	public float cooltime = 2.0f;
	public float skrittime = 2.0f;
	public bool interfaceusing = false;
	public bool Military = false;
	public bool Commercial = true;
	public bool Citizen = false;
	public GUISkin guiskin;
	public bool[] MilBuilds = new bool[17];
	public bool[] ComBuilds = new bool[17];
	public bool[] CitBuilds = new bool[17];
	public Texture2D textur1;
	public bool startMission = false;
	public bool knopka = false;
	public bool vverx = false;
	public GUIStyle guistl;
	public Texture2D textur;
	public Texture2D StartMission;
	public bool[] CubArray = new bool[6];
	
	public Transform placementPlanesRoot;
	public Material eror;
	public Material hoverMat;
	public LayerMask placementLayerMask = new LayerMask();
	Material originalMat;
	GameObject lastHitObj;
	
	public float hSliderValue = 0.0f;
	public float RatingsSliderValue = 0.0f;
	public float UpgradesSliderValue = 0.0f;
	
	public bool vniz = false;
	public float coor = 530.0f;
	public int coor1 = 570;
	public int coor2 = 570;
	public float widthper;
	public float heightper;
	public int i = 10;
	public float fade = 0.0f;
	public Texture2D theTexture;
	public bool Bool = false;
	public Font FT;
	public GUIStyle guistl1;
	public bool ratings = false;
	public bool upgrades = false;
	
	public bool ibool = false;
	public float pausetime = 0.0f;
	public float pausetimesum = 0.0f;
	public Transform TPref;
	public bool Box1 = false;
	public GameObject camera;
	public Transform pref;
	public Transform pref2;
	public bool StratMod = false;
	public Camera cam = new Camera();
	public float mouse_x;
	public float mouse_y;
	public GameObject prefab;
	public GameObject prefab2;
	
	//Блок переменных связанных с сеткой
	
	Color onColor;
	Color offColor;
	GameObject[] allStructures;
	private int structureIndex = 0;
	
	void OnGUI()
	{
		GUI.BeginGroup(new Rect(Screen.width /2 - widthper * (300/(float)10.9),heightper * (150/(float)7.3),widthper * (600/(float)10.9),heightper * (300/(float)7.3)));
		GUI.Box(new Rect(0,0,widthper * (600/(float)10.9),heightper * (300/(float)7.3)),textur,guistl);
		GUI.EndGroup();
		GUI.Box(new Rect(widthper * (0 /(float)10.9),heightper * (0 /(float)7.3),widthper * (100 /(float)10.9),heightper * (110 /(float)7.3)),"Player avatar");
		GUI.Label(new Rect(widthper * (110 / (float)10.9),heightper * (0 / (float)7.3),widthper *(100 / (float)10.9),heightper * (30 / (float)7.3)),"Player Name");
		GUI.Box(new Rect(widthper * ( 110/ (float)10.9),heightper * ( 40 / (float)7.3),widthper * (100 / (float)10.9),heightper * (30/ (float)7.3)),"Level bar");
		GUI.Label(new Rect(widthper * (110 / (float)10.9),heightper * (80/ (float)7.3),widthper * (100/ (float)10.9),heightper * (30 / (float)7.3)), "Player Level");
		if (GUI.Button(new Rect(widthper * (220 / (float)10.9),heightper * (0 / (float)7.3),widthper * (250 / (float)10.9),heightper * ( 50 / (float)7.3)), "Rating"))
		{
			ratings = true;
		}
		/*if (GUI.Button(new Rect(widthper * (480 / (float)10.9),heightper * ( 0 / (float)7.3),widthper *( 100/ (float)10.9),heightper * (100/ (float)7.3)),StartMission,guistl))
		{
			startMission = true;
		}*/
		if (GUI.Button(new Rect(widthper * (590/ (float)10.9),heightper * (0 / (float)7.3),widthper * (250 / (float)10.9),heightper * (50/ (float)7.3)),"Upgrads"))
		{
			upgrades = true;
		}
		GUI.Label(new Rect(widthper * (880 / (float)10.9),heightper * ( 0 / (float)7.3),widthper * (100 / (float)7.3),heightper * (30/ (float)7.3)),"$35600");
		GUI.Label(new Rect(widthper * (990/ (float)10.9),heightper * ( 0 / (float)7.3),widthper * (100/ (float)7.3),heightper * (30/ (float)7.3)),"@260");
		if (ratings)
		{
			GUI.BeginGroup(new Rect(widthper * (150 / (float)10.9),heightper * (100 / (float)7.3),widthper * (320 / (float)10.9),heightper * ( 450 / (float)7.3)));
			GUI.Box(new Rect(0,0,widthper * (320 / (float)10.9),heightper * (450 / (float)7.3)),"");
			if (GUI.Button(new Rect(widthper * (295 / (float)10.9),heightper * (0 / (float)7.3),widthper * (25 / (float)10.9),heightper * (25 / (float)7.3)),"X"))
			{
				ratings = false;
			}
			GUI.BeginGroup(new Rect(0,0,widthper * (320 / (float)10.9),heightper * (450 / (float)7.3)));
			
			GUI.Box(new Rect(widthper *(10/(float)10.9),heightper *(10/(float)7.3)- RatingsSliderValue,widthper * (280 / (float)10.9),heightper * (50 / (float)7.3)),"");
			GUI.Label(new Rect(widthper *(20/(float)10.9),heightper *(25/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Name");
			GUI.Label(new Rect(widthper *(110/(float)10.9),heightper *(25/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Opisanie");
			GUI.Label(new Rect(widthper *(230/(float)10.9),heightper *(25/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Level");
			
			GUI.Box(new Rect(widthper *(10/(float)10.9),heightper *(70/(float)7.3)- RatingsSliderValue,widthper * (280 / (float)10.9),heightper * (50 / (float)7.3)),"");
			GUI.Label(new Rect(widthper *(20/(float)10.9),heightper *(85/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Name");
			GUI.Label(new Rect(widthper *(110/(float)10.9),heightper *(85/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Opisanie");
			GUI.Label(new Rect(widthper *(230/(float)10.9),heightper *(85/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Level");
			
			GUI.Box(new Rect(widthper *(10/(float)10.9),heightper *(130/(float)7.3)- RatingsSliderValue,widthper * (280 / (float)10.9),heightper * (50 / (float)7.3)),"");
			GUI.Label(new Rect(widthper *(20/(float)10.9),heightper *(145/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Name");
			GUI.Label(new Rect(widthper *(110/(float)10.9),heightper *(145/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Opisanie");
			GUI.Label(new Rect(widthper *(230/(float)10.9),heightper *(145/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Level");
			
			GUI.Box(new Rect(widthper *(10/(float)10.9),heightper *(190/(float)7.3)- RatingsSliderValue,widthper * (280 / (float)10.9),heightper * (50 / (float)7.3)),"");
			GUI.Label(new Rect(widthper *(20/(float)10.9),heightper *(205/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Name");
			GUI.Label(new Rect(widthper *(110/(float)10.9),heightper *(205/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Opisanie");
			GUI.Label(new Rect(widthper *(230/(float)10.9),heightper *(205/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Level");
			
			GUI.Box(new Rect(widthper *(10/(float)10.9),heightper *(250/(float)7.3)- RatingsSliderValue,widthper * (280 / (float)10.9),heightper * (50 / (float)7.3)),"");
			GUI.Label(new Rect(widthper *(20/(float)10.9),heightper *(265/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Name");
			GUI.Label(new Rect(widthper *(110/(float)10.9),heightper *(265/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Opisanie");
			GUI.Label(new Rect(widthper *(230/(float)10.9),heightper *(265/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Level");
			
			GUI.Box(new Rect(widthper *(10/(float)10.9),heightper *(310/(float)7.3)- RatingsSliderValue,widthper * (280 / (float)10.9),heightper * (50 / (float)7.3)),"");
			GUI.Label(new Rect(widthper *(20/(float)10.9),heightper *(325/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Name");
			GUI.Label(new Rect(widthper *(110/(float)10.9),heightper *(325/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Opisanie");
			GUI.Label(new Rect(widthper *(230/(float)10.9),heightper *(325/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Level");
			
			GUI.Box(new Rect(widthper *(10/(float)10.9),heightper *(370/(float)7.3)- RatingsSliderValue,widthper * (280 / (float)10.9),heightper * (50 / (float)7.3)),"");
			GUI.Label(new Rect(widthper *(20/(float)10.9),heightper *(385/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Name");
			GUI.Label(new Rect(widthper *(110/(float)10.9),heightper *(385/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Opisanie");
			GUI.Label(new Rect(widthper *(230/(float)10.9),heightper *(385/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Level");
			
			GUI.Box(new Rect(widthper *(10/(float)10.9),heightper *(430/(float)7.3)- RatingsSliderValue,widthper * (280 / (float)10.9),heightper * (50 / (float)7.3)),"");
			GUI.Label(new Rect(widthper *(20/(float)10.9),heightper *(445/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Name");
			GUI.Label(new Rect(widthper *(110/(float)10.9),heightper *(445/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Opisanie");
			GUI.Label(new Rect(widthper *(230/(float)10.9),heightper *(445/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Level");
			
			GUI.Box(new Rect(widthper *(10/(float)10.9),heightper *(490/(float)7.3)- RatingsSliderValue,widthper * (280 / (float)10.9),heightper * (50 / (float)7.3)),"");
			GUI.Label(new Rect(widthper *(20/(float)10.9),heightper *(505/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Name");
			GUI.Label(new Rect(widthper *(110/(float)10.9),heightper *(505/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Opisanie");
			GUI.Label(new Rect(widthper *(230/(float)10.9),heightper *(505/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Level");
			
			GUI.Box(new Rect(widthper *(10/(float)10.9),heightper *(550/(float)7.3)- RatingsSliderValue,widthper * (280 / (float)10.9),heightper * (50 / (float)7.3)),"");
			GUI.Label(new Rect(widthper *(20/(float)10.9),heightper *(565/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Name");
			GUI.Label(new Rect(widthper *(110/(float)10.9),heightper *(565/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Opisanie");
			GUI.Label(new Rect(widthper *(230/(float)10.9),heightper *(565/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Level");
			GUI.EndGroup();
			RatingsSliderValue = GUI.VerticalSlider(new Rect(widthper * (310/(float)10.9),heightper * (30/(float)7.3),widthper * (1010/(float)10.9),heightper * (410/(float)7.3)),RatingsSliderValue,0.0f,410.0f);
			GUI.EndGroup();
		}
		if (upgrades)
		{
			GUI.BeginGroup(new Rect(widthper * (590 / (float)10.9),heightper * (100 / (float)7.3),widthper * (320 / (float)10.9),heightper * ( 450 / (float)7.3)));
			GUI.Box(new Rect(0,0,widthper * (320 / (float)10.9),heightper * (450 / (float)7.3)),"");
			if (GUI.Button(new Rect(widthper * (295 / (float)10.9),heightper * (0 / (float)7.3),widthper * (25 / (float)10.9),heightper * (25 / (float)7.3)),"X"))
			{
				upgrades = false;
			}
			GUI.BeginGroup(new Rect(0,0,widthper * (320 / (float)10.9),heightper * (450 / (float)7.3)));
			
			GUI.Box(new Rect(widthper *(10/(float)10.9),heightper *(10/(float)7.3)- UpgradesSliderValue,widthper * (280 / (float)10.9),heightper * (75 / (float)7.3)),"");
			GUI.Box(new Rect(widthper *(15/(float)10.9), heightper * (15/(float)7.3)-UpgradesSliderValue,widthper * (80/(float)10.9),heightper * (65 / (float)7.3)),"Kartinka");
			GUI.Label(new Rect(widthper *(110/(float)10.9),heightper *(35/(float)7.3)- UpgradesSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Opisanie");
			if (GUI.Button(new Rect(widthper *(200/(float)10.9),heightper *(35/(float)7.3)- UpgradesSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Buy"))
			{
				
			}
			
			GUI.Box(new Rect(widthper *(10/(float)10.9),heightper *(105/(float)7.3)- UpgradesSliderValue,widthper * (280 / (float)10.9),heightper * (75 / (float)7.3)),"");
			GUI.Label(new Rect(widthper *(110/(float)10.9),heightper *(130/(float)7.3)- UpgradesSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Opisanie");
			GUI.Box(new Rect(widthper *(15/(float)10.9), heightper * (110/(float)7.3)-UpgradesSliderValue,widthper * (80/(float)10.9),heightper * (65 / (float)7.3)),"Kartinka");
			if (GUI.Button(new Rect(widthper *(200/(float)10.9),heightper *(130/(float)7.3)- UpgradesSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Buy"))
			{
				
			}
			
			GUI.Box(new Rect(widthper *(10/(float)10.9),heightper *(195/(float)7.3)- UpgradesSliderValue,widthper * (280 / (float)10.9),heightper * (75 / (float)7.3)),"");
			GUI.Label(new Rect(widthper *(110/(float)10.9),heightper *(220/(float)7.3)- UpgradesSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Opisanie");
			GUI.Box(new Rect(widthper *(15/(float)10.9), heightper * (200/(float)7.3)-UpgradesSliderValue,widthper * (80/(float)10.9),heightper * (65 / (float)7.3)),"Kartinka");
			if (GUI.Button(new Rect(widthper *(200/(float)10.9),heightper *(220/(float)7.3)- UpgradesSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Buy"))
			{
				
			}
			
			GUI.Box(new Rect(widthper *(10/(float)10.9),heightper *(285/(float)7.3)- UpgradesSliderValue,widthper * (280 / (float)10.9),heightper * (75 / (float)7.3)),"");
			GUI.Label(new Rect(widthper *(110/(float)10.9),heightper *(310/(float)7.3)- UpgradesSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Opisanie");
			GUI.Box(new Rect(widthper *(15/(float)10.9), heightper * (290/(float)7.3)-UpgradesSliderValue,widthper * (80/(float)10.9),heightper * (65 / (float)7.3)),"Kartinka");
			if (GUI.Button(new Rect(widthper *(200/(float)10.9),heightper *(310/(float)7.3)- UpgradesSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Buy"))
			{
				
			}
			
			GUI.Box(new Rect(widthper *(10/(float)10.9),heightper *(375/(float)7.3)- UpgradesSliderValue,widthper * (280 / (float)10.9),heightper * (75 / (float)7.3)),"");
			GUI.Label(new Rect(widthper *(110/(float)10.9),heightper *(400/(float)7.3)- UpgradesSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Opisanie");
			GUI.Box(new Rect(widthper *(15/(float)10.9), heightper * (380/(float)7.3)-UpgradesSliderValue,widthper * (80/(float)10.9),heightper * (65 / (float)7.3)),"Kartinka");
			if (GUI.Button(new Rect(widthper *(200/(float)10.9),heightper *(400/(float)7.3)- UpgradesSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Buy"))
			{
				
			}
			
			GUI.Box(new Rect(widthper *(10/(float)10.9),heightper *(465/(float)7.3)- UpgradesSliderValue,widthper * (280 / (float)10.9),heightper * (75 / (float)7.3)),"");
			GUI.Label(new Rect(widthper *(110/(float)10.9),heightper *(490/(float)7.3)- UpgradesSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Opisanie");
			GUI.Box(new Rect(widthper *(15/(float)10.9), heightper * (470/(float)7.3)-UpgradesSliderValue,widthper * (80/(float)10.9),heightper * (65 / (float)7.3)),"Kartinka");
			if (GUI.Button(new Rect(widthper *(200/(float)10.9),heightper *(490/(float)7.3)- UpgradesSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Buy"))
			{
				
			}
			
			GUI.Box(new Rect(widthper *(10/(float)10.9),heightper *(555/(float)7.3)- UpgradesSliderValue,widthper * (280 / (float)10.9),heightper * (75 / (float)7.3)),"");
			GUI.Label(new Rect(widthper *(110/(float)10.9),heightper *(580/(float)7.3)- UpgradesSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Opisanie");
			GUI.Box(new Rect(widthper *(15/(float)10.9), heightper * (560/(float)7.3)-UpgradesSliderValue,widthper * (80/(float)10.9),heightper * (65 / (float)7.3)),"Kartinka");
			if (GUI.Button(new Rect(widthper *(200/(float)10.9),heightper *(580/(float)7.3)- UpgradesSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Buy"))
			{
				
			}
			
			GUI.Box(new Rect(widthper *(10/(float)10.9),heightper *(645/(float)7.3)- UpgradesSliderValue,widthper * (280 / (float)10.9),heightper * (75 / (float)7.3)),"");
			GUI.Label(new Rect(widthper *(110/(float)10.9),heightper *(670/(float)7.3)- UpgradesSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Opisanie");
			GUI.Box(new Rect(widthper *(15/(float)10.9), heightper * (650/(float)7.3)-UpgradesSliderValue,widthper * (80/(float)10.9),heightper * (65 / (float)7.3)),"Kartinka");
			if (GUI.Button(new Rect(widthper *(200/(float)10.9),heightper *(670/(float)7.3)- UpgradesSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Buy"))
			{
				
			}
			
			GUI.Box(new Rect(widthper *(10/(float)10.9),heightper *(735/(float)7.3)- UpgradesSliderValue,widthper * (280 / (float)10.9),heightper * (75 / (float)7.3)),"");
			GUI.Label(new Rect(widthper *(110/(float)10.9),heightper *(760/(float)7.3)- UpgradesSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Opisanie");
			GUI.Box(new Rect(widthper *(15/(float)10.9), heightper * (740/(float)7.3)-UpgradesSliderValue,widthper * (80/(float)10.9),heightper * (65 / (float)7.3)),"Kartinka");
			if (GUI.Button(new Rect(widthper *(200/(float)10.9),heightper *(760/(float)7.3)- UpgradesSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Buy"))
			{
				
			}
			
			GUI.Box(new Rect(widthper *(10/(float)10.9),heightper *(825/(float)7.3)- UpgradesSliderValue,widthper * (280 / (float)10.9),heightper * (75 / (float)7.3)),"");
			GUI.Label(new Rect(widthper *(110/(float)10.9),heightper *(850/(float)7.3)- UpgradesSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Opisanie");
			GUI.Box(new Rect(widthper *(15/(float)10.9), heightper * (830/(float)7.3)-UpgradesSliderValue,widthper * (80/(float)10.9),heightper * (65 / (float)7.3)),"Kartinka");
			if (GUI.Button(new Rect(widthper *(200/(float)10.9),heightper *(850/(float)7.3)- UpgradesSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Buy"))
			{
				
			}
			
			GUI.EndGroup();
			UpgradesSliderValue = GUI.VerticalSlider(new Rect(widthper * (310/(float)10.9),heightper * (30/(float)7.3),widthper * (1010/(float)10.9),heightper * (410/(float)7.3)),UpgradesSliderValue,0.0f,610.0f);
			GUI.EndGroup();
		}
		if (knopka)
		{
			/*if (GUI.Button(new Rect(widthper * (0 /(float)10.9),heightper * (690 / (float)7.3),Screen.width,heightper * (40 / (float)7.3)),"",guistl))
			{
				
				vverx = true;
			}*/
		}
		GUI.BeginGroup(new Rect(widthper * (0 /(float)10.9),heightper * (coor /(float)7.3),widthper * (1090 /(float)10.9),heightper * (1000/(float)7.3)));
		if (GUI.Button(new Rect(widthper * (1010 / (float)10.9),heightper * (60 /(float)7.3),widthper * (80 /(float)10.9),heightper * (40/(float)7.3)),"Skrit"))
		{
			vniz = true;
		}
		if (GUI.Button(new Rect(0,heightper * (40/(float)7.3),widthper * (40 /(float)10.9),heightper * (40/(float)7.3)),"1"))
		{
			
		}
		if (GUI.Button(new Rect(widthper * (40/(float)10.9),heightper * (40/(float)7.3),widthper * (40/(float)10.9),heightper * (40/(float)7.3)),"2"))
		{
			
		}
		if (GUI.Button(new Rect(0,heightper * (80/(float)7.3),widthper * (80 /(float)10.9),heightper * (40/(float)7.3)),"Military"))
		{
			Military = true;
			Commercial = false;
			Citizen = false;
		}
		if (GUI.Button(new Rect(0,heightper * (120/(float)7.3),widthper * (80/(float)10.9),heightper * (40/(float)7.3)),"Commercial"))
		{
			Military = false;
			Commercial = true;
			Citizen = false;
		}
		if (GUI.Button(new Rect(0,heightper * (160/(float)7.3),widthper * (80/(float)10.9),heightper * (40/(float)7.3)),"Citizen"))
		{
			Military = false;
			Commercial = false;
			Citizen = true;
		}
		if (Military)
		{
			GUI.Label(new Rect(widthper * (90 /(float)10.9),heightper * (60/(float)7.3),widthper * (80/(float)10.9),heightper * (40/(float)7.3)),"MilitaryBuilds");
		}
		if (Commercial)
		{
			GUI.Label(new Rect(widthper * (90 /(float)10.9),heightper * (60/(float)7.3),widthper * (80/(float)10.9),heightper * (40/(float)7.3)),"CommercialBuilds");
		}
		if (Citizen)
		{
			GUI.Label(new Rect(widthper * (90 /(float)10.9),heightper * (60/(float)7.3),widthper * (80/(float)10.9),heightper * (40/(float)7.3)),"CitizenBuilds");
		}
		GUI.BeginGroup(new Rect(widthper * (80 /(float)10.9),heightper * (100/(float)7.3),widthper * (1010/(float)10.9),heightper * (200/(float)7.3)));
		GUI.Box(new Rect(widthper * (0 /(float)10.9),heightper * (0/(float)7.3),widthper * (1010/(float)10.9),heightper * (120/(float)7.3)),"");
		GUI.BeginGroup(new Rect(widthper * (0 /(float)10.9),heightper * (0/(float)7.3),widthper * (1010/(float)10.9),heightper * (200/(float)7.3)));
		if (Military)
		{
			if (GUI.Button(new Rect(widthper * (10 /(float)10.9) - hSliderValue,heightper * (10/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"MilBuild1"))
			{
				for (int i = 0; i <= 16; i++)
				{
					MilBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					ComBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					CitBuilds[i] = false;
				}
				//MilBuilds[0] = true;
				for (int i = 0; i < 5; i++)
				{
					CubArray[i] = false;
				}
				CubArray[0] = true;
				StratMod = true;
			}
			if (GUI.Button(new Rect(widthper * (110 /(float)10.9) - hSliderValue,heightper * (10/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"MilBuild2"))
			{
				for (int i = 0; i <= 16; i++)
				{
					MilBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					ComBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					CitBuilds[i] = false;
				}
				MilBuilds[1] = true;
			}
			if (GUI.Button(new Rect(widthper * (210 /(float)10.9) - hSliderValue,heightper * (10/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"MilBuild3"))
			{
				for (int i = 0; i <= 16; i++)
				{
					MilBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					ComBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					CitBuilds[i] = false;
				}
				MilBuilds[2] = true;
			}
			if (GUI.Button(new Rect(widthper * (310 /(float)10.9) - hSliderValue,heightper * (10/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"MilBuild4"))
			{
				for (int i = 0; i <= 16; i++)
				{
					MilBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					ComBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					CitBuilds[i] = false;
				}
				MilBuilds[3] = true;
			}
			if (GUI.Button(new Rect(widthper * (410 /(float)10.9) - hSliderValue,heightper * (10/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"MilBuild5"))
			{
				for (int i = 0; i <= 16; i++)
				{
					MilBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					ComBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					CitBuilds[i] = false;
				}
				MilBuilds[4] = true;
			}
			if (GUI.Button(new Rect(widthper * (510 /(float)10.9) - hSliderValue,heightper * (10/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"MilBuild6"))
			{
				for (int i = 0; i <= 16; i++)
				{
					MilBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					ComBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					CitBuilds[i] = false;
				}
				MilBuilds[5] = true;
			}
			if (GUI.Button(new Rect(widthper * (610 /(float)10.9) - hSliderValue,heightper * (10/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"MilBuild7"))
			{
				for (int i = 0; i <= 16; i++)
				{
					MilBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					ComBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					CitBuilds[i] = false;
				}
				MilBuilds[6] = true;
			}
			if (GUI.Button(new Rect(widthper * (710 /(float)10.9) - hSliderValue,heightper * (10/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"MilBuild8"))
			{
				for (int i = 0; i <= 16; i++)
				{
					MilBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					ComBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					CitBuilds[i] = false;
				}
				MilBuilds[7] = true;
			}
			if (GUI.Button(new Rect(widthper * (810 /(float)10.9) - hSliderValue,heightper * (10/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"MilBuild9"))
			{
				for (int i = 0; i <= 16; i++)
				{
					MilBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					ComBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					CitBuilds[i] = false;
				}
				MilBuilds[8] = true;
			}
			if (GUI.Button(new Rect(widthper * (910 /(float)10.9) - hSliderValue,heightper * (10/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"MilBuild10"))
			{
				for (int i = 0; i <= 16; i++)
				{
					MilBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					ComBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					CitBuilds[i] = false;
				}
				MilBuilds[9] = true;
			}
			if (GUI.Button(new Rect(widthper * (1010 /(float)10.9) - hSliderValue,heightper * (10/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"MilBuild11"))
			{
				for (int i = 0; i <= 16; i++)
				{
					MilBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					ComBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					CitBuilds[i] = false;
				}
				MilBuilds[10] = true;
			}
			if (GUI.Button(new Rect(widthper * (1110 /(float)10.9) - hSliderValue,heightper * (10/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"MilBuild12"))
			{
				for (int i = 0; i <= 16; i++)
				{
					MilBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					ComBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					CitBuilds[i] = false;
				}
				MilBuilds[11] = true;
			}
			if (GUI.Button(new Rect(widthper * (1210 /(float)10.9) - hSliderValue,heightper * (10/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"MilBuild13"))
			{
				for (int i = 0; i <= 16; i++)
				{
					MilBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					ComBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					CitBuilds[i] = false;
				}
				MilBuilds[12] = true;
			}
			if (GUI.Button(new Rect(widthper * (1310 /(float)10.9) - hSliderValue,heightper * (10/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"MilBuild14"))
			{
				for (int i = 0; i <= 16; i++)
				{
					MilBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					ComBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					CitBuilds[i] = false;
				}
				MilBuilds[13] = true;
			}
			if (GUI.Button(new Rect(widthper * (1410 /(float)10.9) - hSliderValue,heightper * (10/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"MilBuild15"))
			{
				for (int i = 0; i <= 16; i++)
				{
					MilBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					ComBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					CitBuilds[i] = false;
				}
				MilBuilds[14] = true;
			}
			if (GUI.Button(new Rect(widthper * (1510 /(float)10.9) - hSliderValue,heightper * (10/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"MilBuild16"))
			{
				for (int i = 0; i <= 16; i++)
				{
					MilBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					ComBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					CitBuilds[i] = false;
				}
				MilBuilds[15] = true;
			}
			if (GUI.Button(new Rect(widthper * (1610 /(float)10.9) - hSliderValue,heightper * (10/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"MilBuild17"))
			{
				for (int i = 0; i <= 16; i++)
				{
					MilBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					ComBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					CitBuilds[i] = false;
				}
				MilBuilds[16] = true;
			}
		}
		if (Commercial)
		{
			//GUI.Box(new Rect(widthper * (10 /(float)10.9) - hSliderValue,heightper * (10/(float)7.3),widthper * (90/(float)10.9),heightper * (100/(float)7.3)),"");
			FadeCoroutine();
			if (fade >= 0 || fade <=1)
	    	{
	        //GUI.color = Color.white;
	        //GUI.color.a = fade;
			Color thisColor = GUI.color;
			thisColor.a = 0.5f;
			GUI.color = thisColor;
	        //GUI.Label(Rect(Screen.width/x, Screen.height/y, 400, 200), mes);
	  		GUI.skin.font=FT;
	  		//GUI.DrawTexture(new Rect(widthper * (3 /(float)10.9) - hSliderValue,heightper * (3/(float)7.3),widthper * (102/(float)10.9),heightper * (112/(float)7.3)), theTexture);
	        GUI.color = Color.white;
	    	}
			if (GUI.Button(new Rect(widthper * (10 /(float)10.9) - hSliderValue,heightper * (10/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),textur1,guistl))
			{
				for (int i = 0; i <= 16; i++)
				{
					MilBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					ComBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					CitBuilds[i] = false;
				}
				ComBuilds[0] = true;
			}
			if (GUI.Button(new Rect(widthper * (110 /(float)10.9) - hSliderValue,heightper * (10/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"ComBuild2"))
			{
				for (int i = 0; i <= 16; i++)
				{
					MilBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					ComBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					CitBuilds[i] = false;
				}
				ComBuilds[1] = true;
			}
			if (GUI.Button(new Rect(widthper * (210 /(float)10.9) - hSliderValue,heightper * (10/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"ComBuild3"))
			{
				for (int i = 0; i <= 16; i++)
				{
					MilBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					ComBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					CitBuilds[i] = false;
				}
				ComBuilds[2] = true;
			}
			if (GUI.Button(new Rect(widthper * (310 /(float)10.9) - hSliderValue,heightper * (10/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"ComBuild4"))
			{
				for (int i = 0; i <= 16; i++)
				{
					MilBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					ComBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					CitBuilds[i] = false;
				}
				ComBuilds[3] = true;
			}
			if (GUI.Button(new Rect(widthper * (410 /(float)10.9) - hSliderValue,heightper * (10/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"ComBuild5"))
			{
				for (int i = 0; i <= 16; i++)
				{
					MilBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					ComBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					CitBuilds[i] = false;
				}
				ComBuilds[4] = true;
			}
			if (GUI.Button(new Rect(widthper * (510 /(float)10.9) - hSliderValue,heightper * (10/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"ComBuild6"))
			{
				for (int i = 0; i <= 16; i++)
				{
					MilBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					ComBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					CitBuilds[i] = false;
				}
				ComBuilds[5] = true;
			}
			if (GUI.Button(new Rect(widthper * (610 /(float)10.9) - hSliderValue,heightper * (10/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"ComBuild7"))
			{
				for (int i = 0; i <= 16; i++)
				{
					MilBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					ComBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					CitBuilds[i] = false;
				}
				ComBuilds[6] = true;
			}
			if (GUI.Button(new Rect(widthper * (710 /(float)10.9) - hSliderValue,heightper * (10/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"ComBuild8"))
			{
				for (int i = 0; i <= 16; i++)
				{
					MilBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					ComBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					CitBuilds[i] = false;
				}
				ComBuilds[7] = true;
			}
			if (GUI.Button(new Rect(widthper * (810 /(float)10.9) - hSliderValue,heightper * (10/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"ComBuild9"))
			{
				for (int i = 0; i <= 16; i++)
				{
					MilBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					ComBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					CitBuilds[i] = false;
				}
				ComBuilds[8] = true;
			}
			if (GUI.Button(new Rect(widthper * (910 /(float)10.9) - hSliderValue,heightper * (10/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"ComBuild10"))
			{
				for (int i = 0; i <= 16; i++)
				{
					MilBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					ComBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					CitBuilds[i] = false;
				}
				ComBuilds[9] = true;
			}
			if (GUI.Button(new Rect(widthper * (1010 /(float)10.9) - hSliderValue,heightper * (10/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"ComBuild11"))
			{
				for (int i = 0; i <= 16; i++)
				{
					MilBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					ComBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					CitBuilds[i] = false;
				}
				ComBuilds[10] = true;
			}
			if (GUI.Button(new Rect(widthper * (1110 /(float)10.9) - hSliderValue,heightper * (10/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"ComBuild12"))
			{
				for (int i = 0; i <= 16; i++)
				{
					MilBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					ComBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					CitBuilds[i] = false;
				}
				ComBuilds[11] = true;
			}
			if (GUI.Button(new Rect(widthper * (1210 /(float)10.9) - hSliderValue,heightper * (10/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"ComBuild13"))
			{
				for (int i = 0; i <= 16; i++)
				{
					MilBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					ComBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					CitBuilds[i] = false;
				}
				ComBuilds[12] = true;
			}
			if (GUI.Button(new Rect(widthper * (1310 /(float)10.9) - hSliderValue,heightper * (10/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"ComBuild14"))
			{
				for (int i = 0; i <= 16; i++)
				{
					MilBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					ComBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					CitBuilds[i] = false;
				}
				ComBuilds[13] = true;
			}
			if (GUI.Button(new Rect(widthper * (1410 /(float)10.9) - hSliderValue,heightper * (10/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"ComBuild15"))
			{
				for (int i = 0; i <= 16; i++)
				{
					MilBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					ComBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					CitBuilds[i] = false;
				}
				ComBuilds[14] = true;
			}
			if (GUI.Button(new Rect(widthper * (1510 /(float)10.9) - hSliderValue,heightper * (10/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"ComBuild16"))
			{
				for (int i = 0; i <= 16; i++)
				{
					MilBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					ComBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					CitBuilds[i] = false;
				}
				ComBuilds[15] = true;
			}
			if (GUI.Button(new Rect(widthper * (1610 /(float)10.9) - hSliderValue,heightper * (10/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"ComBuild17"))
			{
				for (int i = 0; i <= 16; i++)
				{
					MilBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					ComBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					CitBuilds[i] = false;
				}
				ComBuilds[16] = true;
			}
		}
		if (Citizen)
		{
			if (GUI.Button(new Rect(widthper * (10 /(float)10.9) - hSliderValue,heightper * (10/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"CitBuild1"))
			{
				for (int i = 0; i <= 16; i++)
				{
					MilBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					ComBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					CitBuilds[i] = false;
				}
				CitBuilds[0] = true;
			}
			if (GUI.Button(new Rect(widthper * (110 /(float)10.9) - hSliderValue,heightper * (10/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"CitBuild2"))
			{
				for (int i = 0; i <= 16; i++)
				{
					MilBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					ComBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					CitBuilds[i] = false;
				}
				CitBuilds[1] = true;
			}
			if (GUI.Button(new Rect(widthper * (210 /(float)10.9) - hSliderValue,heightper * (10/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"CitBuild3"))
			{
				for (int i = 0; i <= 16; i++)
				{
					MilBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					ComBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					CitBuilds[i] = false;
				}
				CitBuilds[2] = true;
			}
			if (GUI.Button(new Rect(widthper * (310 /(float)10.9) - hSliderValue,heightper * (10/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"CitBuild4"))
			{
				for (int i = 0; i <= 16; i++)
				{
					MilBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					ComBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					CitBuilds[i] = false;
				}
				CitBuilds[3] = true;
			}
			if (GUI.Button(new Rect(widthper * (410 /(float)10.9) - hSliderValue,heightper * (10/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"CitBuild5"))
			{
				for (int i = 0; i <= 16; i++)
				{
					MilBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					ComBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					CitBuilds[i] = false;
				}
				CitBuilds[4] = true;
			}
			if (GUI.Button(new Rect(widthper * (510 /(float)10.9) - hSliderValue,heightper * (10/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"CitBuild6"))
			{
				for (int i = 0; i <= 16; i++)
				{
					MilBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					ComBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					CitBuilds[i] = false;
				}
				CitBuilds[5] = true;
			}
			if (GUI.Button(new Rect(widthper * (610 /(float)10.9) - hSliderValue,heightper * (10/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"CitBuild7"))
			{
				for (int i = 0; i <= 16; i++)
				{
					MilBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					ComBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					CitBuilds[i] = false;
				}
				CitBuilds[6] = true;
			}
			if (GUI.Button(new Rect(widthper * (710 /(float)10.9) - hSliderValue,heightper * (10/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"CitBuild8"))
			{
				for (int i = 0; i <= 16; i++)
				{
					MilBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					ComBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					CitBuilds[i] = false;
				}
				CitBuilds[7] = true;
			}
			if (GUI.Button(new Rect(widthper * (810 /(float)10.9) - hSliderValue,heightper * (10/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"CitBuild9"))
			{
				for (int i = 0; i <= 16; i++)
				{
					MilBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					ComBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					CitBuilds[i] = false;
				}
				CitBuilds[8] = true;
			}
			if (GUI.Button(new Rect(widthper * (910 /(float)10.9) - hSliderValue,heightper * (10/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"CitBuild10"))
			{
				for (int i = 0; i <= 16; i++)
				{
					MilBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					ComBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					CitBuilds[i] = false;
				}
				CitBuilds[9] = true;
			}
			if (GUI.Button(new Rect(widthper * (1010 /(float)10.9) - hSliderValue,heightper * (10/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"CitBuild11"))
			{
				for (int i = 0; i <= 16; i++)
				{
					MilBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					ComBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					CitBuilds[i] = false;
				}
				CitBuilds[10] = true;
			}
			if (GUI.Button(new Rect(widthper * (1110 /(float)10.9) - hSliderValue,heightper * (10/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"CitBuild12"))
			{
				for (int i = 0; i <= 16; i++)
				{
					MilBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					ComBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					CitBuilds[i] = false;
				}
				CitBuilds[11] = true;
			}
			if (GUI.Button(new Rect(widthper * (1210 /(float)10.9) - hSliderValue,heightper * (10/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"CitBuild13"))
			{
				for (int i = 0; i <= 16; i++)
				{
					MilBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					ComBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					CitBuilds[i] = false;
				}
				CitBuilds[12] = true;
			}
			if (GUI.Button(new Rect(widthper * (1310 /(float)10.9) - hSliderValue,heightper * (10/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"CitBuild14"))
			{
				for (int i = 0; i <= 16; i++)
				{
					MilBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					ComBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					CitBuilds[i] = false;
				}
				CitBuilds[13] = true;
			}
			if (GUI.Button(new Rect(widthper * (1410 /(float)10.9) - hSliderValue,heightper * (10/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"CitBuild15"))
			{
				for (int i = 0; i <= 16; i++)
				{
					MilBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					ComBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					CitBuilds[i] = false;
				}
				CitBuilds[14] = true;
			}
			if (GUI.Button(new Rect(widthper * (1510 /(float)10.9) - hSliderValue,heightper * (10/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"CitBuild16"))
			{
				for (int i = 0; i <= 16; i++)
				{
					MilBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					ComBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					CitBuilds[i] = false;
				}
				CitBuilds[15] = true;
			}
			if (GUI.Button(new Rect(widthper * (1610 /(float)10.9) - hSliderValue,heightper * (10/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"CitBuild17"))
			{
				for (int i = 0; i <= 16; i++)
				{
					MilBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					ComBuilds[i] = false;
				}
				for (int i = 0; i <= 16; i++)
				{
					CitBuilds[i] = false;
				}
				CitBuilds[16] = true;
			}
		}
		GUI.EndGroup();
		GUI.EndGroup();
		hSliderValue = GUI.HorizontalSlider(new Rect(widthper * (80/(float)10.9),heightper * (190/(float)7.3),widthper * (1010/(float)10.9),heightper * (20/(float)7.3)),hSliderValue,0.0f,1010.0f);
		GUI.EndGroup();
		if (MilBuilds[0])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"MilBuild1");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X"))
			{
				MilBuilds[0] = false;
			}
			GUI.EndGroup();
		}
		if (MilBuilds[1])
		{
			
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"MilBuild2");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X"))
			{
				MilBuilds[1] = false;
			}
			GUI.EndGroup();
		}
		if (MilBuilds[2])
		{
			
			
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"MilBuild3");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X"))
			{
				MilBuilds[2] = false;
			}
			GUI.EndGroup();
		}
		if (MilBuilds[3])
		{
			
			
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"MilBuild4");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X"))
			{
				MilBuilds[3] = false;
			}
			GUI.EndGroup();
		}
		if (MilBuilds[4])
		{
			
			
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"MilBuild5");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X"))
			{
				MilBuilds[4] = false;
			}
			GUI.EndGroup();
		}
		if (MilBuilds[5])
		{
			
			
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"MilBuild6");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X"))
			{
				MilBuilds[5] = false;
			}
			GUI.EndGroup();
		}
		if (MilBuilds[6])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"MilBuild7");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X"))
			{
				MilBuilds[6] = false;
			}
			GUI.EndGroup();
		}
		if (MilBuilds[7])
		{
			
			
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"MilBuild8");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X"))
			{
				MilBuilds[7] = false;
			}
			GUI.EndGroup();
		}
		if (MilBuilds[8])
		{
			
			
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"MilBuild9");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X"))
			{
				MilBuilds[8] = false;
			}
			GUI.EndGroup();
		}
		if (MilBuilds[9])
		{
			
			
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"MilBuild10");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X"))
			{
				MilBuilds[9] = false;
			}
			GUI.EndGroup();
		}
		if (MilBuilds[10])
		{
			
			
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"MilBuild11");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X"))
			{
				MilBuilds[10] = false;
			}
			GUI.EndGroup();
		}
		if (MilBuilds[11])
		{
			
			
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"MilBuild12");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X"))
			{
				MilBuilds[11] = false;
			}
			GUI.EndGroup();
		}
		if (MilBuilds[12])
		{
			
			
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"MilBuild13");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X"))
			{
				MilBuilds[12] = false;
			}
			GUI.EndGroup();
		}
		if (MilBuilds[13])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"MilBuild14");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X"))
			{
				MilBuilds[13] = false;
			}
			GUI.EndGroup();
		}
		if (MilBuilds[14])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"MilBuild15");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X"))
			{
				MilBuilds[14] = false;
			}
			GUI.EndGroup();
		}
		if (MilBuilds[15])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"MilBuild16");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X"))
			{
				MilBuilds[15] = false;
			}
			GUI.EndGroup();
		}
		if (MilBuilds[16])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"MilBuild17");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X"))
			{
				MilBuilds[16] = false;
			}
			GUI.EndGroup();
		}
		if (ComBuilds[0])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"ComBuild1");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X"))
			{
				ComBuilds[0] = false;
			}
			GUI.EndGroup();
		}
		if (ComBuilds[1])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"ComBuild2");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X"))
			{
				ComBuilds[1] = false;
			}
			GUI.EndGroup();
		}
		if (ComBuilds[2])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"ComBuild3");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X"))
			{
				ComBuilds[2] = false;
			}
			GUI.EndGroup();
		}
		if (ComBuilds[3])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"ComBuild4");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X"))
			{
				ComBuilds[3] = false;
			}
			GUI.EndGroup();
		}
		if (ComBuilds[4])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"ComBuild5");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X"))
			{
				ComBuilds[4] = false;
			}
			GUI.EndGroup();
		}
		if (ComBuilds[5])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"ComBuild6");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X"))
			{
				ComBuilds[5] = false;
			}
			GUI.EndGroup();
		}
		if (ComBuilds[6])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"ComBuild7");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X"))
			{
				ComBuilds[6] = false;
			}
			GUI.EndGroup();
		}
		if (ComBuilds[7])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"ComBuild8");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X"))
			{
				ComBuilds[7] = false;
			}
			GUI.EndGroup();
		}
		if (ComBuilds[8])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"ComBuild9");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X"))
			{
				ComBuilds[8] = false;
			}
			GUI.EndGroup();
		}
		if (ComBuilds[9])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"ComBuild10");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X"))
			{
				ComBuilds[9] = false;
			}
			GUI.EndGroup();
		}
		if (ComBuilds[10])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"ComBuild11");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X"))
			{
				ComBuilds[10] = false;
			}
			GUI.EndGroup();
		}
		if (ComBuilds[11])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"ComBuild12");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X"))
			{
				ComBuilds[11] = false;
			}
			GUI.EndGroup();
		}
		if (ComBuilds[12])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"ComBuild13");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X"))
			{
				ComBuilds[12] = false;
			}
			GUI.EndGroup();
		}
		if (ComBuilds[13])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"ComBuild14");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X"))
			{
				ComBuilds[13] = false;
			}
			GUI.EndGroup();
		}
		if (ComBuilds[14])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"ComBuild15");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X"))
			{
				ComBuilds[14] = false;
			}
			GUI.EndGroup();
		}
		if (ComBuilds[15])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"ComBuild16");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X"))
			{
				ComBuilds[15] = false;
			}
			GUI.EndGroup();
		}
		if (ComBuilds[16])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"ComBuild17");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X"))
			{
				ComBuilds[16] = false;
			}
			GUI.EndGroup();
		}
		if (CitBuilds[0])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"CitBuild1");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X"))
			{
				CitBuilds[0] = false;
			}
			GUI.EndGroup();
		}
		if (CitBuilds[1])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"CitBuild2");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X"))
			{
				CitBuilds[1] = false;
			}
			GUI.EndGroup();
		}
		if (CitBuilds[2])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"CitBuild3");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X"))
			{
				CitBuilds[2] = false;
			}
			GUI.EndGroup();
		}
		if (CitBuilds[3])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"CitBuild4");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X"))
			{
				CitBuilds[3] = false;
			}
			GUI.EndGroup();
		}
		if (CitBuilds[4])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"CitBuild5");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X"))
			{
				CitBuilds[4] = false;
			}
			GUI.EndGroup();
		}
		if (CitBuilds[5])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"CitBuild6");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X"))
			{
				CitBuilds[5] = false;
			}
			GUI.EndGroup();
		}
		if (CitBuilds[6])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"CitBuild7");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X"))
			{
				CitBuilds[6] = false;
			}
			GUI.EndGroup();
		}
		if (CitBuilds[7])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"CitBuild8");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X"))
			{
				CitBuilds[7] = false;
			}
			GUI.EndGroup();
		}
		if (CitBuilds[8])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"CitBuild9");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X"))
			{
				CitBuilds[8] = false;
			}
			GUI.EndGroup();
		}
		if (CitBuilds[9])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"CitBuild10");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X"))
			{
				CitBuilds[9] = false;
			}
			GUI.EndGroup();
		}
		if (CitBuilds[10])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"CitBuild11");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X"))
			{
				CitBuilds[10] = false;
			}
			GUI.EndGroup();
		}
		if (CitBuilds[11])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"CitBuild12");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X"))
			{
				CitBuilds[11] = false;
			}
			GUI.EndGroup();
		}
		if (CitBuilds[12])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"CitBuild13");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X"))
			{
				CitBuilds[12] = false;
			}
			GUI.EndGroup();
		}
		if (CitBuilds[13])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"CitBuild14");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X"))
			{
				CitBuilds[13] = false;
			}
			GUI.EndGroup();
		}
		if (CitBuilds[14])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"CitBuild15");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X"))
			{
				CitBuilds[14] = false;
			}
			GUI.EndGroup();
		}
		if (CitBuilds[15])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"CitBuild16");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X"))
			{
				CitBuilds[15] = false;
			}
			GUI.EndGroup();
		}
		if (CitBuilds[16])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"CitBuild17");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X"))
			{
				CitBuilds[16] = false;
			}
			GUI.EndGroup();
		}
		
	}
	
	public void FadeCoroutine()
	{
		if (!Bool)
		{
			fade += Time.deltaTime/3;
			if (fade>=1)
			{
				fade = 1.02f;
				Bool = true;
			}
		}
		if (Bool)
		{
			fade -= Time.deltaTime/5;
			if (fade < 0.1f)
			{
				fade = 0;
				Bool = false;
			}
		}
	}
	/*var fade : float = 0.0f;
	var theTexture : Texture2D;
	var bool:boolean=false;
	var FT:Font;

	function FadeCoroutine()
	{
	if (!bool)
	{
	fade +=  Time.deltaTime/3;
	if (fade>=1) 
	{
	fade=1.02; 
	bool=true;
	}
	}

	if (bool) {
	fade -= Time.deltaTime/5;
	if (fade<0.1) {fade=0;bool=false;
	}
	}
	}

	function OnGUI()
	{
  	FadeCoroutine();
 	if (fade >= 0 || fade <=1)
    	{
        	//GUI.color = Color.white;
        	GUI.color.a = fade;
        	//GUI.Label(Rect(Screen.width/x, Screen.height/y, 400, 200), mes);
  	GUI.skin.font=FT;
  	GUI.DrawTexture(Rect(0,0,Screen.width, Screen.height), theTexture);
        GUI.color = Color.white;
    	}
    }*/
	void Start () {
		skrittime = 2.0f;
		cooltime = 2.0f;
	}
	
	void Update () {
		if (interfaceusing)
			skrittime = 2.0f;
		if (!vniz && !(coor == 730) && !vverx && !interfaceusing)
		{
			if (skrittime > 0)
				skrittime -= Time.deltaTime;
			if (skrittime < 0)
				skrittime = 0;
			if (skrittime == 0)
			{
				vniz = true;
			}
		}
		if (coor < 730)
		{
			GameObject.Find("Button").collider.enabled = false;
		}
		if (coor > 540)
			GameObject.Find("Button1").collider.enabled = false;
		if (coor < 540)
			GameObject.Find("Button1").collider.enabled = true;
		if (startMission)
			Application.LoadLevel("Interface1");
		print(hSliderValue);
		widthper = Screen.width / (float)100;
		heightper = Screen.height / (float)100;
		if (coor == 730)
		{
			knopka = true;
		}
		if (vniz)
		{
			if (vverx = true)
			{
				vverx = false;
			}
			coor += 1;
			if (coor == 730)
			{
				vniz = false;
				GameObject.Find("Button").collider.enabled = true;
			}
		}
		if (vverx)
		{
			if (vniz = true)
			{
				vniz = false;
			}
			coor -= 1;
			if (coor < 530)
			{
				vverx = false;
				coor = 530;
			}
			if (coor == 530)
			{
				vverx = false;
				knopka = false;
			}
		}
		
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
	
	if(Physics.Raycast(ray,out hit,1000,placementLayerMask))
		{
			if (lastHitObj)
			{
				lastHitObj.renderer.material = originalMat;
			}
			lastHitObj = hit.collider.gameObject;
			originalMat = lastHitObj.renderer.material;
			lastHitObj.renderer.material = hoverMat;
			
			if (lastHitObj.tag == "PlacementPlane_Taken" && StratMod)
			{
				lastHitObj.renderer.material = eror;
			}
			if (Input.GetMouseButtonDown(0) && lastHitObj.tag == "PlacementPlane_Taken")
			{
				if (StratMod == false)
				{
					Box1 = true;
					Vector3 screenPos = cam.WorldToScreenPoint(lastHitObj.transform.position);
					mouse_x = screenPos.x;
					mouse_y = screenPos.y;
				}
			}
		}
		else
		{
			if (lastHitObj)
			{
				lastHitObj.renderer.material = originalMat;
				lastHitObj = null;
			}
		}
		if (Input.GetMouseButtonDown(0)&&lastHitObj&&CubArray[0])
		{
			if(lastHitObj.tag == "PlacementPlane_Open")
			{
				//GameObject newStructure = Instantiate(allStructures[structureIndex],lastHitObj.transform.position,Quaternion.identity);
				lastHitObj.tag = "PlacementPlane_Taken";
				TPref = Instantiate(pref,lastHitObj.transform.position,Quaternion.identity) as Transform;
				CubArray[0] = false;
				StratMod = false;
			}
		}	
	
	}
}
