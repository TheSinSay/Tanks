using UnityEngine;
using System.Collections;

public class Interface : MonoBehaviour {
	private bool Military = false;
	private bool Commercial = true;
	private bool Citizen = false;
	public GUISkin guiskin;
	private bool[] MilBuilds = new bool[17];
	private bool[] ComBuilds = new bool[17];
	private bool[] CitBuilds = new bool[17];
	public bool startMission = false;
	private bool knopka = false;
	public bool vverx = false;
	public GUIStyle guistl;
	public Texture2D textur;
	public Texture2D StartMission;
	private bool[] CubArray = new bool[6];
	
	public Transform placementPlanesRoot;
	public Material eror;
	public Material hoverMat;
	public LayerMask placementLayerMask = new LayerMask();
	public LayerMask BuildsLayer = new LayerMask();
	Material originalMat;
	private GameObject lastHitObj;
	private GameObject lastHitObj2;
	
	private float hSliderValue = 0.0f;
	private float RatingsSliderValue = 0.0f;
	private float UpgradesSliderValue = 0.0f;
	
	private bool vniz = false;
	private float coor = 430.0f;
	private int coor1 = 570;
	private int coor2 = 570;
	private float widthper;
	private float heightper;
	private int i = 10;
	private bool ratings = false;
	private bool upgrades = false;
	
	private Transform TPref;
	public GameObject camera;
	public Transform pref;
	public Transform pref2;
	private bool StratMod = false;
	public Camera cam = new Camera();
	
	//Блок переменных связанных с сеткой
	
	private bool Create = false;
	public bool canCreate = false;
	
	private float dlinnaScrolla = 0.0f;
	private int collichestvo_knopok = 0;
	
	private GameObject lastHitBuild;
	
	private string Name_Build;
	private string Opisanie_Build;
	private bool Opisanie_GUI;
	
	private bool Zdanie = true;
	private bool NewTechnology = false;
	
	private float wSliderValue = 0.0f;
	private float Build_dlinnaScrolla = 0.0f;
	private int Build_collichestvo_knopok;
	public Texture2D textur_niz_bar;
	public Texture2D texture_upgrads;
	private int fmx = 72;
	
	public Texture2D Player_avatar_text;
	public Texture2D Level_Bar_text;
	public Texture2D Rating_Box_text;
	public Texture2D Rating_Box_Box_text;
	public Texture2D Upgrades_Box_Box_text;
	public Texture2D Upgrades_Box_Box_Kartinka_text;
	
	public Texture2D Build_Panel_Military_Build1_text;
	private int q_pub = 0;
	private int CompletedGames = 0;
	
	private float StartMissionSliderValue = 0;
	
	public Texture2D neGalka;
	public Texture2D Galka;
	public Texture2D StartMissionBox;
	
	public bool Gui_narisovan = false;
	
	private bool isHovering2 = false;
	private bool isHovering1 = false;
	public Camera cShapeGUIcamera;
	
	private bool isHovering = false;
	
	private bool isDown = false;
	
	private Ray ray_startMission;
	
	private RaycastHit hit_startMission;
	
	private bool zadaniya = false;
	
	private bool info_1 = false;
	private bool info_2 = false;
	
	private float ZadaniyzSliderValue = 0;
	
	//Булевые переменные доступности кнопок
	private bool knopka_1_dostypna = true;
	private bool knopka_2_dostypna = true;
	private bool knopka_3_dostypna = true;
	private bool knopka_4_dostypna = true;
	private bool knopka_5_dostypna = true;
	//Текстуры для доступных кнопок
	public Texture2D knopka_zdanyi_1_dostypna;
	public Texture2D knopka_zdanyi_2_dostypna;
	public Texture2D knopka_zdanyi_3_dostypna;
	public Texture2D knopka_zdanyi_4_dostypna;
	public Texture2D knopka_zdanyi_5_dostypna;
	//Текстуры для недоступных кнопок
	public Texture2D knopka_zdanyi_1_nedostypna;
	public Texture2D knopka_zdanyi_2_nedostypna;
	public Texture2D knopka_zdanyi_3_nedostypna;
	public Texture2D knopka_zdanyi_4_nedostypna;
	public Texture2D knopka_zdanyi_5_nedostypna;
	//Текстуры для кнопок
	private Texture2D knopka_zdanyi_1;
	private Texture2D knopka_zdanyi_2;
	private Texture2D knopka_zdanyi_3;
	private Texture2D knopka_zdanyi_4;
	private Texture2D knopka_zdanyi_5;
	
	private float UpgradesDlinna = 0;
	private int Upgrades_collichestvo_knopok = 0;
	
	private float Ratings_dlinna = 0;
	private int Ratings_collichestvo_knopok = 0;
	
	public bool Spell = true;
	
	void OnGUI()
	{
		if(Spell)
		{
			GUI.BeginGroup(new Rect(widthper * (410/(float)10.9),heightper * (130/(float)7.3),widthper * (250/(float)10.9),heightper * (150/(float)7.3)));
			GUI.Box(new Rect(widthper * (0/(float)10.9),heightper * (0/(float)7.3),widthper * (250/(float)10.9),heightper * (150/(float)7.3)),"");
			GUI.Label(new Rect(widthper * (70/(float)10.9),heightper * (10/(float)7.3),widthper * (110/(float)10.9),heightper * (20/(float)7.3)),"Умение",guiskin.customStyles[11]);
			GUI.Label(new Rect(widthper * (30/(float)10.9),heightper * (40/(float)7.3),widthper * (190/(float)10.9),heightper * (40/(float)7.3)),"Описаниеafij \n wechper.xhpdfsojgcs[pkgpox/[phxp,d.f/['phv/kdpouv[codthjpx['dfovyie[orc'[d9ivd[",guiskin.customStyles[13]);
			GUI.Box(new Rect(widthper * (30/(float)10.9),heightper * (90/(float)7.3),widthper * (60/(float)10.9),heightper * (50/(float)7.3)),"");
			if(GUI.Button(new Rect(widthper * (100/(float)10.9),heightper * (90/(float)7.3),widthper * (120/(float)10.9),heightper * (50/(float)7.3)),"Установить",guiskin.customStyles[11]))
			{
				
			}
			GUI.EndGroup();
		}
		GUI.Box(new Rect(widthper * (0 /(float)10.9),heightper * (0 /(float)7.3),Screen.width,heightper * (120 /(float)7.3)),"");
		if(startMission)
		{
			GUI.BeginGroup(new Rect(widthper * (275/(float)10.9),heightper * (100/(float)7.3),widthper * (550/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect(widthper * (0/(float)10.9),0,widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"");
			GUI.Label(new Rect(widthper * (180/(float)10.9),7,widthper * (100/(float)10.9),heightper * (20/(float)7.3)),"Start Mission",guiskin.customStyles[11]);
			GUI.BeginGroup(new Rect(widthper * (0/(float)10.9),heightper * (30/(float)7.3),widthper * (550/(float)10.9),heightper * (450/(float)7.3)));
			for (int q = -1;q<254;q++) 
			{
				q_pub = q + 2;
				if (q_pub < CompletedGames)
				{
					guiskin.customStyles[11].normal.textColor = Color.yellow;
					guiskin.customStyles[11].hover.textColor = Color.yellow;
					StartMissionBox = Galka;
				}
				if(q_pub == CompletedGames)
				{
					guiskin.customStyles[11].normal.textColor = Color.grey;
					guiskin.customStyles[11].hover.textColor = Color.grey;
					StartMissionBox = neGalka;
				}
				if (GUI.Button(new Rect(widthper * (10/(float)10.9),heightper * (6.5f + (47 * q) /(float)7.3) - StartMissionSliderValue ,widthper * (425/(float)10.9),heightper * (40/(float)7.3)),"Game :" + " " + q_pub.ToString(),guiskin.customStyles[11]))
				{
				}
				GUI.Box(new Rect(widthper * (445/(float)10.9),heightper * (6.5f + 47 * q/(float)7.3) - StartMissionSliderValue ,widthper * (40/(float)10.9),heightper * (40/(float)7.3)),StartMissionBox);
				if(q_pub == 255)
				{
					guiskin.customStyles[11].normal.textColor = Color.white;
					guiskin.customStyles[11].hover.textColor = Color.white;
				}
					
			}
			GUI.EndGroup();
			if (GUI.Button(new Rect(widthper * (475/(float)10.9),0,widthper * (25/(float)10.9),heightper * (25/(float)7.3)),"X",guiskin.customStyles[11]))
			{
				startMission = false;
			}
			StartMissionSliderValue = GUI.VerticalSlider(new Rect(widthper * (487.5f/(float)10.9),heightper * (30/(float)7.3),widthper * (1010/(float)10.9),heightper * (415/(float)7.3)),StartMissionSliderValue,0.0f,0);
			GUI.EndGroup();
		}
		if(zadaniya)
		{
			GUI.BeginGroup(new Rect(widthper * (275/(float)10.9),heightper * (100/(float)7.3),widthper * (550/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect(widthper * (0/(float)10.9),0,widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"");
			GUI.BeginGroup(new Rect(widthper * (0/(float)10.9),heightper * (30/(float)7.3),widthper * (550/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect(widthper * (10/(float)10.9),heightper * (0/(float)7.3) - StartMissionSliderValue ,widthper * (470/(float)10.9),heightper * (60/(float)7.3)),StartMissionBox);
			if(GUI.Button(new Rect(widthper * (20/(float)10.9),heightper * (10/(float)7.3) - StartMissionSliderValue ,widthper * (40/(float)10.9),heightper * (40/(float)7.3)),"i",guiskin.customStyles[11]))
			{
				info_1 = true;
			}
			GUI.Label(new Rect(widthper * (70/(float)10.9),heightper * (10/(float)7.3) - StartMissionSliderValue,widthper * (350/(float)10.9),heightper * (40/(float)7.3)),"Bla bla bla bla bla",guiskin.customStyles[11]);
			if(GUI.Button(new Rect(widthper * (430/(float)10.9),heightper * (10/(float)7.3) - StartMissionSliderValue ,widthper * (40/(float)10.9),heightper * (40/(float)7.3)),"GO!",guiskin.customStyles[11]))
			{
				
			}
			
			GUI.Box(new Rect(widthper * (10/(float)10.9),heightper * (70/(float)7.3) - StartMissionSliderValue ,widthper * (470/(float)10.9),heightper * (60/(float)7.3)),StartMissionBox);
			if(GUI.Button(new Rect(widthper * (20/(float)10.9),heightper * (80/(float)7.3) - StartMissionSliderValue ,widthper * (40/(float)10.9),heightper * (40/(float)7.3)),"i",guiskin.customStyles[11]))
			{
				
			}
			GUI.Label(new Rect(widthper * (70/(float)10.9),heightper * (80/(float)7.3) - StartMissionSliderValue,widthper * (350/(float)10.9),heightper * (40/(float)7.3)),"Bla bla bla bla bla",guiskin.customStyles[11]);
			if(GUI.Button(new Rect(widthper * (430/(float)10.9),heightper * (80/(float)7.3) - StartMissionSliderValue ,widthper * (40/(float)10.9),heightper * (40/(float)7.3)),"GO!",guiskin.customStyles[11]))
			{
				
			}
			GUI.EndGroup();
			if (GUI.Button(new Rect(widthper * (475/(float)10.9),0,widthper * (25/(float)10.9),heightper * (25/(float)7.3)),"X",guiskin.customStyles[11]))
			{
				zadaniya = false;
			}
			StartMissionSliderValue = GUI.VerticalSlider(new Rect(widthper * (487.5f/(float)10.9),heightper * (30/(float)7.3),widthper * (13.5f/(float)10.9),heightper * (415/(float)7.3)),StartMissionSliderValue,0.0f,11560.0f);
			GUI.EndGroup();
			if (info_1)
			{
				GUI.BeginGroup(new Rect(widthper * (250/(float)10.9),heightper * (175/(float)7.3),widthper * (650/(float)10.9),heightper * (450/(float)7.3)));
				GUI.Box(new Rect(widthper * (0/(float)10.9),0,widthper * (550/(float)10.9),heightper * (300/(float)7.3)),"");
				if (GUI.Button(new Rect(widthper * (525/(float)10.9),0,widthper * (25/(float)10.9),heightper * (25/(float)7.3)),"X",guiskin.customStyles[11]))
				{
					info_1 = false;
				}
				GUI.Box(new Rect(widthper * (10/(float)10.9),heightper * (5/(float)7.3),widthper * (150/(float)10.9),heightper * (30/(float)7.3)),"");
				GUI.Label(new Rect(widthper * (10/(float)10.9),heightper * (5/(float)7.3),widthper * (150/(float)10.9),heightper * (30/(float)7.3)),"Bla bla bla bla bla",guiskin.customStyles[11]);
				GUI.Box(new Rect(widthper * (10/(float)10.9),heightper * (45/(float)7.3),widthper * (530/(float)10.9),heightper * (110/(float)7.3)),"");
				GUI.Label(new Rect(widthper * (10/(float)10.9),heightper * (45/(float)7.3),widthper * (530/(float)10.9),heightper * (110/(float)7.3)),"Bla bla bla bla bla bla bla bla bla bla bla bla bla bla",guiskin.customStyles[11]);
				GUI.Box(new Rect(widthper * (10/(float)10.9),heightper * (165/(float)7.3),widthper * (530/(float)10.9),heightper * (120/(float)7.3)),"");
				GUI.Label(new Rect(widthper * (10/(float)10.9),heightper * (165/(float)7.3),widthper * (520/(float)10.9),heightper * (40/(float)7.3)),"Zadanie : Bla bla bla",guiskin.customStyles[11]);
				GUI.Label(new Rect(widthper * (10/(float)10.9),heightper * (205/(float)7.3),widthper * (520/(float)10.9),heightper * (40/(float)7.3)),"Voznagrazdenie : $1500",guiskin.customStyles[11]);
				GUI.Label(new Rect(widthper * (10/(float)10.9),heightper * (245/(float)7.3),widthper * (520/(float)10.9),heightper * (40/(float)7.3)),"Vozmozni dop nagradi",guiskin.customStyles[11]);
				GUI.EndGroup();
			}
		}
		if(Opisanie_GUI)
		{
			GUI.BeginGroup(new Rect(widthper * (325/(float)10.9),heightper * (100/(float)7.3),widthper * (400/(float)10.9),heightper * (500/(float)7.3)));
			GUI.Box(new Rect(widthper * (50/(float)10.9),0,widthper * (300/(float)10.9),heightper * (40/(float)7.3)),"");
			GUI.Label(new Rect(widthper * (60/(float)10.9),heightper * (5/(float)7.3),widthper * (270/(float)10.9),heightper * (30/(float)7.3)),Name_Build,guiskin.customStyles[11]);
			GUI.Box(new Rect(0,heightper * (40/(float)7.3),widthper * (400/(float)10.9),heightper * (380/(float)7.3)),"");
			if (Zdanie)
			{
				GUI.Box(new Rect(0,heightper * (40/(float)7.3),widthper * (400/(float)10.9),heightper * (100/(float)7.3)),"");
				GUI.Label(new Rect(widthper * (0/(float)10.9),heightper * (40/(float)7.3),widthper * (400/(float)10.9),heightper * (100/(float)7.3)),Opisanie_Build,guiskin.customStyles[11]);
				GUI.Box(new Rect(0,heightper * (140/(float)7.3),widthper * (400/(float)10.9),heightper * (100/(float)7.3)),"");
				GUI.Label(new Rect(widthper * (170/(float)10.9),heightper * (140/(float)7.3),widthper * (60/(float)10.9),heightper * (20/(float)7.3)),"Level 2",guiskin.customStyles[11]);
				GUI.Label(new Rect(widthper * (0/(float)10.9),heightper * (160/(float)7.3),widthper * (290/(float)10.9),heightper * (80/(float)7.3)),"Bla bla bla",guiskin.customStyles[11]);
				if (GUI.Button(new Rect(widthper * (290/(float)10.9),heightper * (170/(float)7.3),widthper * (100/(float)10.9),heightper * (60/(float)7.3)),"Upgrade",guiskin.customStyles[11]))
				{
					
				}
				GUI.Box(new Rect(0,heightper * (240/(float)7.3),widthper * (400/(float)10.9),heightper * (100/(float)7.3)),"");
				GUI.Label(new Rect(widthper * (170/(float)10.9),heightper * (240/(float)7.3),widthper * (60/(float)10.9),heightper * (20/(float)7.3)),"Level 3",guiskin.customStyles[11]);
				GUI.Label(new Rect(widthper * (0/(float)10.9),heightper * (260/(float)7.3),widthper * (290/(float)10.9),heightper * (80/(float)7.3)),"Bla bla bla",guiskin.customStyles[11]);
				if (GUI.Button(new Rect(widthper * (290/(float)10.9),heightper * (270/(float)7.3),widthper * (100/(float)10.9),heightper * (60/(float)7.3)),"Upgrade",guiskin.customStyles[11]))
				{
					
				}
				GUI.Box(new Rect(0,heightper * (340/(float)7.3),widthper * (400/(float)10.9),heightper * (140/(float)7.3)),"");
			}
			if (NewTechnology)
			{
				wSliderValue = GUI.VerticalSlider(new Rect(widthper * (389/(float)10.9),heightper * (70/(float)7.3),widthper * (20/(float)10.9),heightper * (350/(float)7.3)),wSliderValue,0.0f,Build_dlinnaScrolla);
				GUI.Box(new Rect(0,heightper * (40/(float)7.3),widthper * (400/(float)10.9),heightper * (30/(float)7.3)),"");
				GUI.Label(new Rect(widthper * (0/(float)10.9),heightper * (40/(float)7.3),widthper * (400/(float)10.9),heightper * (30/(float)7.3)),"New Techology",guiskin.customStyles[11]);
				GUI.BeginGroup(new Rect(0,heightper * (70/(float)7.3),widthper * (400/(float)10.9),heightper * (400/(float)7.3)));
				GUI.Box(new Rect(0,heightper * (0/(float)7.3) - wSliderValue,widthper * (290/(float)10.9),heightper * (50/(float)7.3)),"");
				GUI.Box(new Rect(widthper * (290/(float)10.9),heightper * (0/(float)7.3) - wSliderValue,widthper * (100/(float)10.9),heightper * (50/(float)7.3)),"");
				GUI.Label(new Rect(widthper * (0/(float)10.9),heightper * (0/(float)7.3) - wSliderValue,widthper * (290/(float)10.9),heightper * (50/(float)7.3)),"Bla bla bla",guiskin.customStyles[11]);
				if (GUI.Button(new Rect(widthper * (300/(float)10.9),heightper * (5/(float)7.3) - wSliderValue,widthper * (80/(float)10.9),heightper * (40/(float)7.3)),"100500",guiskin.customStyles[11]))
				{
					
				}
				GUI.Box(new Rect(0,heightper * (50/(float)7.3) - wSliderValue,widthper * (290/(float)10.9),heightper * (50/(float)7.3)),"");
				GUI.Box(new Rect(widthper * (290/(float)10.9),heightper * (50/(float)7.3) - wSliderValue,widthper * (100/(float)10.9),heightper * (50/(float)7.3)),"");
				GUI.Label(new Rect(widthper * (0/(float)10.9),heightper * (50/(float)7.3) - wSliderValue,widthper * (290/(float)10.9),heightper * (50/(float)7.3)),"Bla bla bla",guiskin.customStyles[11]);
				if (GUI.Button(new Rect(widthper * (300/(float)10.9),heightper * (55/(float)7.3) - wSliderValue,widthper * (80/(float)10.9),heightper * (40/(float)7.3)),"100500",guiskin.customStyles[11]))
				{
					
				}
				GUI.Box(new Rect(0,heightper * (100/(float)7.3) - wSliderValue,widthper * (290/(float)10.9),heightper * (50/(float)7.3)),"");
				GUI.Box(new Rect(widthper * (290/(float)10.9),heightper * (100/(float)7.3) - wSliderValue,widthper * (100/(float)10.9),heightper * (50/(float)7.3)),"");
				GUI.Label(new Rect(widthper * (0/(float)10.9),heightper * (100/(float)7.3) - wSliderValue,widthper * (290/(float)10.9),heightper * (50/(float)7.3)),"Bla bla bla",guiskin.customStyles[11]);
				if (GUI.Button(new Rect(widthper * (300/(float)10.9),heightper * (105/(float)7.3) - wSliderValue,widthper * (80/(float)10.9),heightper * (40/(float)7.3)),"100500",guiskin.customStyles[11]))
				{
					
				}
				GUI.Box(new Rect(0,heightper * (150/(float)7.3) - wSliderValue,widthper * (290/(float)10.9),heightper * (50/(float)7.3)),"");
				GUI.Box(new Rect(widthper * (290/(float)10.9),heightper * (150/(float)7.3) - wSliderValue,widthper * (100/(float)10.9),heightper * (50/(float)7.3)),"");
				GUI.Label(new Rect(widthper * (0/(float)10.9),heightper * (150/(float)7.3) - wSliderValue,widthper * (290/(float)10.9),heightper * (50/(float)7.3)),"Bla bla bla",guiskin.customStyles[11]);
				if (GUI.Button(new Rect(widthper * (300/(float)10.9),heightper * (155/(float)7.3) - wSliderValue,widthper * (80/(float)10.9),heightper * (40/(float)7.3)),"100500",guiskin.customStyles[11]))
				{
					
				}
				GUI.Box(new Rect(0,heightper * (200/(float)7.3) - wSliderValue,widthper * (290/(float)10.9),heightper * (50/(float)7.3)),"");
				GUI.Box(new Rect(widthper * (290/(float)10.9),heightper * (200/(float)7.3) - wSliderValue,widthper * (100/(float)10.9),heightper * (50/(float)7.3)),"");
				GUI.Label(new Rect(widthper * (0/(float)10.9),heightper * (200/(float)7.3) - wSliderValue,widthper * (290/(float)10.9),heightper * (50/(float)7.3)),"Bla bla bla",guiskin.customStyles[11]);
				if (GUI.Button(new Rect(widthper * (300/(float)10.9),heightper * (205/(float)7.3) - wSliderValue,widthper * (80/(float)10.9),heightper * (40/(float)7.3)),"100500",guiskin.customStyles[11]))
				{
					
				}
				GUI.Box(new Rect(0,heightper * (250/(float)7.3) - wSliderValue,widthper * (290/(float)10.9),heightper * (50/(float)7.3)),"");
				GUI.Box(new Rect(widthper * (290/(float)10.9),heightper * (250/(float)7.3) - wSliderValue,widthper * (100/(float)10.9),heightper * (50/(float)7.3)),"");
				GUI.Label(new Rect(widthper * (0/(float)10.9),heightper * (250/(float)7.3) - wSliderValue,widthper * (290/(float)10.9),heightper * (50/(float)7.3)),"Bla bla bla",guiskin.customStyles[11]);
				if (GUI.Button(new Rect(widthper * (300/(float)10.9),heightper * (255/(float)7.3) - wSliderValue,widthper * (80/(float)10.9),heightper * (40/(float)7.3)),"100500",guiskin.customStyles[11]))
				{
					
				}
				GUI.Box(new Rect(0,heightper * (300/(float)7.3) - wSliderValue,widthper * (290/(float)10.9),heightper * (50/(float)7.3)),"");
				GUI.Box(new Rect(widthper * (290/(float)10.9),heightper * (300/(float)7.3) - wSliderValue,widthper * (100/(float)10.9),heightper * (50/(float)7.3)),"");
				GUI.Label(new Rect(widthper * (0/(float)10.9),heightper * (300/(float)7.3) - wSliderValue,widthper * (290/(float)10.9),heightper * (50/(float)7.3)),"Bla bla bla",guiskin.customStyles[11]);
				if (GUI.Button(new Rect(widthper * (300/(float)10.9),heightper * (305/(float)7.3) - wSliderValue,widthper * (80/(float)10.9),heightper * (40/(float)7.3)),"100500",guiskin.customStyles[11]))
				{
					
				}
				GUI.EndGroup();
			}
			if (GUI.Button(new Rect(0,heightper * (420/(float)7.3),widthper * (200/(float)10.9),heightper * (60/(float)7.3)),"Zdanie",guiskin.customStyles[11]))
			{
				Zdanie = true;
				NewTechnology = false;
			}
			if (GUI.Button(new Rect(widthper * (200/(float)10.9),heightper * (420/(float)7.3),widthper * (200/(float)10.9),heightper * (60/(float)7.3)),"Novie Techonologii",guiskin.customStyles[11]))
			{
				Zdanie = false;
				NewTechnology = true;
			}
			if (GUI.Button(new Rect(widthper * (330/(float)10.9),0,widthper * (20/(float)10.9),heightper * (20/(float)7.3)),"X",guiskin.customStyles[11]))
			{
				Opisanie_GUI = false;
				Zdanie = true;
				NewTechnology = false;
			}
			GUI.EndGroup();
		}
		GUI.BeginGroup(new Rect(Screen.width /2 - widthper * (300/(float)10.9),heightper * (150/(float)7.3),widthper * (600/(float)10.9),heightper * (300/(float)7.3)));
		GUI.Box(new Rect(0,0,widthper * (600/(float)10.9),heightper * (300/(float)7.3)),textur,guistl);
		GUI.EndGroup();
		GUI.Box(new Rect(widthper * (0 /(float)10.9),heightper * (0 /(float)7.3),widthper * (100 /(float)10.9),heightper * (100 /(float)7.3)),Player_avatar_text);
		GUI.Box(new Rect(widthper * ( 990/ (float)10.9),heightper * (0 / (float)7.3),widthper * (100 / (float)10.9),heightper * (100/ (float)7.3)),"");
		GUI.Label(new Rect(widthper * (990 / (float)10.9),heightper * (0 / (float)7.3),widthper *(100 / (float)10.9),heightper * (25 / (float)7.3)),"Player Name",guiskin.customStyles[11]);
		GUI.Box(new Rect(widthper * ( 990/ (float)10.9),heightper * ( 20 / (float)7.3),widthper * (100 / (float)10.9),heightper * (30/ (float)7.3)),Level_Bar_text);
		GUI.Label(new Rect(widthper * (1020 / (float)10.9),heightper * (20/ (float)7.3),widthper * (40/ (float)10.9),heightper * (30 / (float)7.3)), "5 lvl",guiskin.customStyles[11]);
		GUI.Label(new Rect(widthper * (990 / (float)10.9),heightper * (50 / (float)7.3),widthper * (70 / (float)7.3),heightper * (25/ (float)7.3)),"$35600",guiskin.customStyles[11]);
		GUI.Label(new Rect(widthper * (990/ (float)10.9),heightper * ( 75 / (float)7.3),widthper * (70/ (float)7.3),heightper * (25/ (float)7.3)),"@260",guiskin.customStyles[11]);
		if (GUI.Button(new Rect(widthper * (220 / (float)10.9),heightper * (15 / (float)7.3),widthper * (250 / (float)10.9),heightper * ( 50 / (float)7.3)), "Rating",guiskin.customStyles[11]))
		{
			ratings = true;
		}
		if (GUI.Button(new Rect(widthper * (590/ (float)10.9),heightper * (15 / (float)7.3),widthper * (250 / (float)10.9),heightper * (50/ (float)7.3)),"Upgrads",guiskin.customStyles[11]))
		{
			upgrades = true;
		}
		if (ratings)
		{
			GUI.BeginGroup(new Rect(widthper * (150 / (float)10.9),heightper * (100 / (float)7.3),widthper * (320 / (float)10.9),heightper * ( 450 / (float)7.3)));
			GUI.DrawTexture(new Rect(0,0,widthper * (320 / (float)10.9),heightper * (450 / (float)7.3)),Rating_Box_text);
			GUI.BeginGroup(new Rect(widthper * (0 / (float)10.9),heightper * (5 / (float)7.3),widthper * (320 / (float)10.9),heightper * ( 440 / (float)7.3)));
			if (GUI.Button(new Rect(widthper * (295 / (float)10.9),heightper * (0 / (float)7.3),widthper * (25 / (float)10.9),heightper * (25 / (float)7.3)),"X",guiskin.customStyles[11]))
			{
				ratings = false;
			}
			GUI.BeginGroup(new Rect(0,0,widthper * (320 / (float)10.9),heightper * (450 / (float)7.3)));
			
			GUI.Box(new Rect(widthper *(10/(float)10.9),heightper *(10/(float)7.3)- RatingsSliderValue,widthper * (280 / (float)10.9),heightper * (52 / (float)7.3)),Rating_Box_Box_text);
			GUI.Label(new Rect(widthper *(20/(float)10.9),heightper *(25/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Name",guiskin.customStyles[11]);
			GUI.Label(new Rect(widthper *(110/(float)10.9),heightper *(25/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Opisanie",guiskin.customStyles[11]);
			GUI.Label(new Rect(widthper *(200/(float)10.9),heightper *(25/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Level",guiskin.customStyles[11]);
			
			GUI.Box(new Rect(widthper *(10/(float)10.9),heightper *(72/(float)7.3)- RatingsSliderValue,widthper * (280 / (float)10.9),heightper * (52 / (float)7.3)),Rating_Box_Box_text);
			GUI.Label(new Rect(widthper *(20/(float)10.9),heightper *(87/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Name",guiskin.customStyles[11]);
			GUI.Label(new Rect(widthper *(110/(float)10.9),heightper *(87/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Opisanie",guiskin.customStyles[11]);
			GUI.Label(new Rect(widthper *(200/(float)10.9),heightper *(87/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Level",guiskin.customStyles[11]);
			
			GUI.Box(new Rect(widthper *(10/(float)10.9),heightper *(134/(float)7.3)- RatingsSliderValue,widthper * (280 / (float)10.9),heightper * (52 / (float)7.3)),Rating_Box_Box_text);
			GUI.Label(new Rect(widthper *(20/(float)10.9),heightper *(149/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Name",guiskin.customStyles[11]);
			GUI.Label(new Rect(widthper *(110/(float)10.9),heightper *(149/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Opisanie",guiskin.customStyles[11]);
			GUI.Label(new Rect(widthper *(200/(float)10.9),heightper *(149/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Level",guiskin.customStyles[11]);
			
			GUI.Box(new Rect(widthper *(10/(float)10.9),heightper *(196/(float)7.3)- RatingsSliderValue,widthper * (280 / (float)10.9),heightper * (52 / (float)7.3)),Rating_Box_Box_text);
			GUI.Label(new Rect(widthper *(20/(float)10.9),heightper *(211/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Name",guiskin.customStyles[11]);
			GUI.Label(new Rect(widthper *(110/(float)10.9),heightper *(211/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Opisanie",guiskin.customStyles[11]);
			GUI.Label(new Rect(widthper *(200/(float)10.9),heightper *(211/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Level",guiskin.customStyles[11]);
			
			GUI.Box(new Rect(widthper *(10/(float)10.9),heightper *(258/(float)7.3)- RatingsSliderValue,widthper * (280 / (float)10.9),heightper * (52 / (float)7.3)),Rating_Box_Box_text);
			GUI.Label(new Rect(widthper *(20/(float)10.9),heightper *(273/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Name",guiskin.customStyles[11]);
			GUI.Label(new Rect(widthper *(110/(float)10.9),heightper *(273/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Opisanie",guiskin.customStyles[11]);
			GUI.Label(new Rect(widthper *(200/(float)10.9),heightper *(273/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Level",guiskin.customStyles[11]);
			
			GUI.Box(new Rect(widthper *(10/(float)10.9),heightper *(320/(float)7.3)- RatingsSliderValue,widthper * (280 / (float)10.9),heightper * (52 / (float)7.3)),Rating_Box_Box_text);
			GUI.Label(new Rect(widthper *(20/(float)10.9),heightper *(335/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Name",guiskin.customStyles[11]);
			GUI.Label(new Rect(widthper *(110/(float)10.9),heightper *(335/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Opisanie",guiskin.customStyles[11]);
			GUI.Label(new Rect(widthper *(200/(float)10.9),heightper *(335/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Level",guiskin.customStyles[11]);
			
			GUI.Box(new Rect(widthper *(10/(float)10.9),heightper *(382/(float)7.3)- RatingsSliderValue,widthper * (280 / (float)10.9),heightper * (52 / (float)7.3)),Rating_Box_Box_text);
			GUI.Label(new Rect(widthper *(20/(float)10.9),heightper *(397/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Name",guiskin.customStyles[11]);
			GUI.Label(new Rect(widthper *(110/(float)10.9),heightper *(397/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Opisanie",guiskin.customStyles[11]);
			GUI.Label(new Rect(widthper *(200/(float)10.9),heightper *(397/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Level",guiskin.customStyles[11]);
			
			GUI.Box(new Rect(widthper *(10/(float)10.9),heightper *(444/(float)7.3)- RatingsSliderValue,widthper * (280 / (float)10.9),heightper * (52 / (float)7.3)),Rating_Box_Box_text);
			GUI.Label(new Rect(widthper *(20/(float)10.9),heightper *(459/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Name",guiskin.customStyles[11]);
			GUI.Label(new Rect(widthper *(110/(float)10.9),heightper *(459/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Opisanie",guiskin.customStyles[11]);
			GUI.Label(new Rect(widthper *(200/(float)10.9),heightper *(459/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Level",guiskin.customStyles[11]);
			
			GUI.Box(new Rect(widthper *(10/(float)10.9),heightper *(506/(float)7.3)- RatingsSliderValue,widthper * (280 / (float)10.9),heightper * (52 / (float)7.3)),Rating_Box_Box_text);
			GUI.Label(new Rect(widthper *(20/(float)10.9),heightper *(521/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Name",guiskin.customStyles[11]);
			GUI.Label(new Rect(widthper *(110/(float)10.9),heightper *(521/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Opisanie",guiskin.customStyles[11]);
			GUI.Label(new Rect(widthper *(200/(float)10.9),heightper *(521/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Level",guiskin.customStyles[11]);
			
			GUI.Box(new Rect(widthper *(10/(float)10.9),heightper *(568/(float)7.3)- RatingsSliderValue,widthper * (280 / (float)10.9),heightper * (52 / (float)7.3)),Rating_Box_Box_text);
			GUI.Label(new Rect(widthper *(20/(float)10.9),heightper *(583/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Name",guiskin.customStyles[11]);
			GUI.Label(new Rect(widthper *(110/(float)10.9),heightper *(583/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Opisanie",guiskin.customStyles[11]);
			GUI.Label(new Rect(widthper *(200/(float)10.9),heightper *(583/(float)7.3)- RatingsSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Level",guiskin.customStyles[11]);
			GUI.EndGroup();
			GUI.EndGroup();
			RatingsSliderValue = GUI.VerticalSlider(new Rect(widthper * (310/(float)10.9),heightper * (30/(float)7.3),widthper * (1010/(float)10.9),heightper * (410/(float)7.3)),RatingsSliderValue,0.0f,Ratings_dlinna);
			GUI.EndGroup();
		}
		if (upgrades)
		{
			GUI.BeginGroup(new Rect(widthper * (590 / (float)10.9),heightper * (100 / (float)7.3),widthper * (320 / (float)10.9),heightper * ( 450 / (float)7.3)));
			GUI.DrawTexture(new Rect(0,0,widthper * (320 / (float)10.9),heightper * (450 / (float)7.3)),texture_upgrads);
			GUI.BeginGroup(new Rect(widthper * (0 / (float)10.9),heightper * (5 / (float)7.3),widthper * (320 / (float)10.9),heightper * ( 440 / (float)7.3)));
			if (GUI.Button(new Rect(widthper * (295 / (float)10.9),heightper * (0 / (float)7.3),widthper * (25 / (float)10.9),heightper * (25 / (float)7.3)),"X",guiskin.customStyles[11]))
			{
				upgrades = false;
			}
			GUI.BeginGroup(new Rect(0,0,widthper * (320 / (float)10.9),heightper * (450 / (float)7.3)));
			
			GUI.Box(new Rect(widthper *(10/(float)10.9),heightper *(10/(float)7.3)- UpgradesSliderValue,widthper * (280 / (float)10.9),heightper * (75 / (float)7.3)),Upgrades_Box_Box_text);
			GUI.Box(new Rect(widthper *(15/(float)10.9), heightper * (15/(float)7.3)-UpgradesSliderValue,widthper * (80/(float)10.9),heightper * (65 / (float)7.3)),Upgrades_Box_Box_Kartinka_text);
			GUI.Label(new Rect(widthper *(110/(float)10.9),heightper *(35/(float)7.3)- UpgradesSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Opisanie",guiskin.customStyles[11]);
			if (GUI.Button(new Rect(widthper *(200/(float)10.9),heightper *(35/(float)7.3)- UpgradesSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Buy",guiskin.customStyles[11]))
			{
				
			}
			
			GUI.Box(new Rect(widthper *(10/(float)10.9),heightper *(98/(float)7.3)- UpgradesSliderValue,widthper * (280 / (float)10.9),heightper * (75 / (float)7.3)),Upgrades_Box_Box_text);
			GUI.Label(new Rect(widthper *(110/(float)10.9),heightper *(123/(float)7.3)- UpgradesSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Opisanie",guiskin.customStyles[11]);
			GUI.Box(new Rect(widthper *(15/(float)10.9), heightper * (103/(float)7.3)-UpgradesSliderValue,widthper * (80/(float)10.9),heightper * (65 / (float)7.3)),Upgrades_Box_Box_Kartinka_text);
			if (GUI.Button(new Rect(widthper *(200/(float)10.9),heightper *(123/(float)7.3)- UpgradesSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Buy",guiskin.customStyles[11]))
			{
				
			}
			
			GUI.Box(new Rect(widthper *(10/(float)10.9),heightper *(186/(float)7.3)- UpgradesSliderValue,widthper * (280 / (float)10.9),heightper * (75 / (float)7.3)),Upgrades_Box_Box_text);
			GUI.Label(new Rect(widthper *(110/(float)10.9),heightper *(211/(float)7.3)- UpgradesSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Opisanie",guiskin.customStyles[11]);
			GUI.Box(new Rect(widthper *(15/(float)10.9), heightper * (191/(float)7.3)-UpgradesSliderValue,widthper * (80/(float)10.9),heightper * (65 / (float)7.3)),Upgrades_Box_Box_Kartinka_text);
			if (GUI.Button(new Rect(widthper *(200/(float)10.9),heightper *(211/(float)7.3)- UpgradesSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Buy",guiskin.customStyles[11]))
			{
				
			}
			
			GUI.Box(new Rect(widthper *(10/(float)10.9),heightper *(274/(float)7.3)- UpgradesSliderValue,widthper * (280 / (float)10.9),heightper * (75 / (float)7.3)),Upgrades_Box_Box_text);
			GUI.Label(new Rect(widthper *(110/(float)10.9),heightper *(299/(float)7.3)- UpgradesSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Opisanie",guiskin.customStyles[11]);
			GUI.Box(new Rect(widthper *(15/(float)10.9), heightper * (279/(float)7.3)-UpgradesSliderValue,widthper * (80/(float)10.9),heightper * (65 / (float)7.3)),Upgrades_Box_Box_Kartinka_text);
			if (GUI.Button(new Rect(widthper *(200/(float)10.9),heightper *(299/(float)7.3)- UpgradesSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Buy",guiskin.customStyles[11]))
			{
				
			}
			
			GUI.Box(new Rect(widthper *(10/(float)10.9),heightper *(362/(float)7.3)- UpgradesSliderValue,widthper * (280 / (float)10.9),heightper * (75 / (float)7.3)),Upgrades_Box_Box_text);
			GUI.Label(new Rect(widthper *(110/(float)10.9),heightper *(387/(float)7.3)- UpgradesSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Opisanie",guiskin.customStyles[11]);
			GUI.Box(new Rect(widthper *(15/(float)10.9), heightper * (367/(float)7.3)-UpgradesSliderValue,widthper * (80/(float)10.9),heightper * (65 / (float)7.3)),Upgrades_Box_Box_Kartinka_text);
			if (GUI.Button(new Rect(widthper *(200/(float)10.9),heightper *(387/(float)7.3)- UpgradesSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Buy",guiskin.customStyles[11]))
			{
				
			}
			
			GUI.Box(new Rect(widthper *(10/(float)10.9),heightper *(450/(float)7.3)- UpgradesSliderValue,widthper * (280 / (float)10.9),heightper * (75 / (float)7.3)),Upgrades_Box_Box_text);
			GUI.Label(new Rect(widthper *(110/(float)10.9),heightper *(475/(float)7.3)- UpgradesSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Opisanie",guiskin.customStyles[11]);
			GUI.Box(new Rect(widthper *(15/(float)10.9), heightper * (455/(float)7.3)-UpgradesSliderValue,widthper * (80/(float)10.9),heightper * (65 / (float)7.3)),Upgrades_Box_Box_Kartinka_text);
			if (GUI.Button(new Rect(widthper *(200/(float)10.9),heightper *(475/(float)7.3)- UpgradesSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Buy",guiskin.customStyles[11]))
			{
				
			}
			
			GUI.Box(new Rect(widthper *(10/(float)10.9),heightper *(538/(float)7.3)- UpgradesSliderValue,widthper * (280 / (float)10.9),heightper * (75 / (float)7.3)),Upgrades_Box_Box_text);
			GUI.Label(new Rect(widthper *(110/(float)10.9),heightper *(563/(float)7.3)- UpgradesSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Opisanie",guiskin.customStyles[11]);
			GUI.Box(new Rect(widthper *(15/(float)10.9), heightper * (543/(float)7.3)-UpgradesSliderValue,widthper * (80/(float)10.9),heightper * (65 / (float)7.3)),Upgrades_Box_Box_Kartinka_text);
			if (GUI.Button(new Rect(widthper *(200/(float)10.9),heightper *(563/(float)7.3)- UpgradesSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Buy",guiskin.customStyles[11]))
			{
				
			}
			
			GUI.Box(new Rect(widthper *(10/(float)10.9),heightper *(626/(float)7.3)- UpgradesSliderValue,widthper * (280 / (float)10.9),heightper * (75 / (float)7.3)),Upgrades_Box_Box_text);
			GUI.Label(new Rect(widthper *(110/(float)10.9),heightper *(651/(float)7.3)- UpgradesSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Opisanie",guiskin.customStyles[11]);
			GUI.Box(new Rect(widthper *(15/(float)10.9), heightper * (631/(float)7.3)-UpgradesSliderValue,widthper * (80/(float)10.9),heightper * (65 / (float)7.3)),Upgrades_Box_Box_Kartinka_text);
			if (GUI.Button(new Rect(widthper *(200/(float)10.9),heightper *(651/(float)7.3)- UpgradesSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Buy",guiskin.customStyles[11]))
			{
				
			}
			
			GUI.Box(new Rect(widthper *(10/(float)10.9),heightper *(714/(float)7.3)- UpgradesSliderValue,widthper * (280 / (float)10.9),heightper * (75 / (float)7.3)),Upgrades_Box_Box_text);
			GUI.Label(new Rect(widthper *(110/(float)10.9),heightper *(739/(float)7.3)- UpgradesSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Opisanie",guiskin.customStyles[11]);
			GUI.Box(new Rect(widthper *(15/(float)10.9), heightper * (719/(float)7.3)-UpgradesSliderValue,widthper * (80/(float)10.9),heightper * (65 / (float)7.3)),Upgrades_Box_Box_Kartinka_text);
			if (GUI.Button(new Rect(widthper *(200/(float)10.9),heightper *(739/(float)7.3)- UpgradesSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Buy",guiskin.customStyles[11]))
			{
				
			}
			
			GUI.Box(new Rect(widthper *(10/(float)10.9),heightper *(802/(float)7.3)- UpgradesSliderValue,widthper * (280 / (float)10.9),heightper * (75 / (float)7.3)),Upgrades_Box_Box_text);
			GUI.Label(new Rect(widthper *(110/(float)10.9),heightper *(827/(float)7.3)- UpgradesSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Opisanie",guiskin.customStyles[11]);
			GUI.Box(new Rect(widthper *(15/(float)10.9), heightper * (807/(float)7.3)-UpgradesSliderValue,widthper * (80/(float)10.9),heightper * (65 / (float)7.3)),Upgrades_Box_Box_Kartinka_text);
			if (GUI.Button(new Rect(widthper *(200/(float)10.9),heightper *(827/(float)7.3)- UpgradesSliderValue,widthper * (80 / (float)10.9),heightper * (25 / (float)7.3)),"Buy",guiskin.customStyles[11]))
			{
				
			}
			
			GUI.EndGroup();
			GUI.EndGroup();
			UpgradesSliderValue = GUI.VerticalSlider(new Rect(widthper * (310/(float)10.9),heightper * (30/(float)7.3),widthper * (1010/(float)10.9),heightper * (410/(float)7.3)),UpgradesSliderValue,0.0f,UpgradesDlinna);
			GUI.EndGroup();
		}
		GUI.BeginGroup(new Rect(widthper * (0 /(float)10.9),heightper * (coor /(float)7.3),widthper * (1090 /(float)10.9),heightper * (1000/(float)7.3)));
		if (GUI.Button(new Rect(widthper * (1010 / (float)10.9),heightper * (160 /(float)7.3),widthper * (80 /(float)10.9),heightper * (40/(float)7.3)),"Skrit",guiskin.customStyles[11]))
		{
			vniz = true;
		}
		if (GUI.Button(new Rect(0,heightper * (140/(float)7.3),widthper * (40 /(float)10.9),heightper * (40/(float)7.3)),"1",guiskin.customStyles[11]))
		{
			
		}
		if (GUI.Button(new Rect(widthper * (40/(float)10.9),heightper * (140/(float)7.3),widthper * (40/(float)10.9),heightper * (40/(float)7.3)),"2",guiskin.customStyles[11]))
		{
			
		}
		if (GUI.Button(new Rect(0,heightper * (180/(float)7.3),widthper * (80 /(float)10.9),heightper * (40/(float)7.3)),"Military",guiskin.customStyles[11]))
		{
			Military = true;
			Commercial = false;
			Citizen = false;
		}
		if (GUI.Button(new Rect(0,heightper * (220/(float)7.3),widthper * (80/(float)10.9),heightper * (40/(float)7.3)),"Commercial",guiskin.customStyles[11]))
		{
			Military = false;
			Commercial = true;
			Citizen = false;
		}
		if (GUI.Button(new Rect(0,heightper * (260/(float)7.3),widthper * (80/(float)10.9),heightper * (40/(float)7.3)),"Citizen",guiskin.customStyles[11]))
		{
			Military = false;
			Commercial = false;
			Citizen = true;
		}
		if (Military)
		{
			GUI.Label(new Rect(widthper * (0 /(float)10.9),heightper * (120/(float)7.3),widthper * (150/(float)10.9),heightper * (20/(float)7.3)),"MilitaryBuilds",guiskin.customStyles[11]);
		}
		if (Commercial)
		{
			GUI.Label(new Rect(widthper * (0 /(float)10.9),heightper * (120/(float)7.3),widthper * (150/(float)10.9),heightper * (20/(float)7.3)),"CommercialBuilds",guiskin.customStyles[11]);
		}
		if (Citizen)
		{
			GUI.Label(new Rect(widthper * (0 /(float)10.9),heightper * (120/(float)7.3),widthper * (150/(float)10.9),heightper * (20/(float)7.3)),"CitizenBuilds",guiskin.customStyles[11]);
		}
		GUI.BeginGroup(new Rect(widthper * (80 /(float)10.9),heightper * (100/(float)7.3),widthper * (1010/(float)10.9),heightper * (200/(float)7.3)));
		GUI.DrawTexture(new Rect(widthper * (0 /(float)10.9),heightper * (100/(float)7.3),widthper * (1010/(float)10.9),heightper * (100/(float)7.3)),textur_niz_bar);
		GUI.BeginGroup(new Rect(widthper * (0 /(float)10.9),heightper * (0/(float)7.3),widthper * (1010/(float)10.9),heightper * (200/(float)7.3)));
		GUI.BeginGroup(new Rect(widthper * (8 /(float)10.9),heightper * (0/(float)7.3),widthper * (999/(float)10.9),heightper * (200/(float)7.3)));
		if (Military)
		{
			if (GUI.Button(new Rect(widthper * (10 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),Build_Panel_Military_Build1_text,guiskin.customStyles[11]))
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
				for (int i = 0; i < 5; i++)
				{
					CubArray[i] = false;
				}
				CubArray[0] = true;
				StratMod = true;
				
			}
			if(new Rect(widthper * (10 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
			Debug.Log("rect1");
			if(widthper * (10 /(float)10.9) - hSliderValue > 0 && widthper * (10 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (10 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (10 /(float)10.9) - hSliderValue > 0)) && widthper * (10 /(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (10 /(float)10.9) - hSliderValue > 0 && (!(widthper * (10 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
			if (GUI.Button(new Rect(widthper * (110 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"",guiskin.customStyles[10]))
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
			if(new Rect(widthper * (110 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
			Debug.Log("rect2");
				if(widthper * (110 /(float)10.9) - hSliderValue > 0 && widthper * (110 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (110 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (110 /(float)10.9) - hSliderValue > 0)) && widthper * (110 /(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (110 /(float)10.9) - hSliderValue > 0 && (!(widthper * (110 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
			if (GUI.Button(new Rect(widthper * (210 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"",guiskin.customStyles[9]))
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
			if(new Rect(widthper * (210 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
			Debug.Log("rect3");
			if(widthper * (210 /(float)10.9) - hSliderValue > 0 && widthper * (210 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (210 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (210 /(float)10.9) - hSliderValue > 0)) && widthper * (210 /(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (210 /(float)10.9) - hSliderValue > 0 && (!(widthper * (210 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
			if (GUI.Button(new Rect(widthper * (310 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"",guiskin.customStyles[10]))
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
			if(new Rect(widthper * (310 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
			Debug.Log("rect4");
			if(widthper * (310 /(float)10.9) - hSliderValue > 0 && widthper * (310 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (310 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (310 /(float)10.9) - hSliderValue > 0)) && widthper * (310 /(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (310 /(float)10.9) - hSliderValue > 0 && (!(widthper * (310 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
			if (GUI.Button(new Rect(widthper * (410 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"",guiskin.customStyles[9]))
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
			if(new Rect(widthper * (410 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
			Debug.Log("rect5");
			if(widthper * (410 /(float)10.9) - hSliderValue > 0 && widthper * (410 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (410 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (410 /(float)10.9) - hSliderValue > 0)) && widthper * (410 /(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (410 /(float)10.9) - hSliderValue > 0 && (!(widthper * (410 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
			if (GUI.Button(new Rect(widthper * (510 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"",guiskin.customStyles[10]))
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
			if(new Rect(widthper * (510 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
			Debug.Log("rect6");
			if(widthper * (510 /(float)10.9) - hSliderValue > 0 && widthper * (510 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (510 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (510 /(float)10.9) - hSliderValue > 0)) && widthper * (510 /(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (510 /(float)10.9) - hSliderValue > 0 && (!(widthper * (510 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
			if (GUI.Button(new Rect(widthper * (610 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"",guiskin.customStyles[9]))
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
			if(new Rect(widthper * (610 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
			Debug.Log("rect7");
			if(widthper * (610 /(float)10.9) - hSliderValue > 0 && widthper * (610 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (610 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (610 /(float)10.9) - hSliderValue > 0)) && widthper * (610 /(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (610 /(float)10.9) - hSliderValue > 0 && (!(widthper * (610 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
			if (GUI.Button(new Rect(widthper * (710 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"",guiskin.customStyles[10]))
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
			if(new Rect(widthper * (710 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
			Debug.Log("rect8");
			if(widthper * (710 /(float)10.9) - hSliderValue > 0 && widthper * (710 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (710 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (710 /(float)10.9) - hSliderValue > 0)) && widthper * (710 /(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (710 /(float)10.9) - hSliderValue > 0 && (!(widthper * (710 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
			if (GUI.Button(new Rect(widthper * (810 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"",guiskin.customStyles[9]))
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
			if(new Rect(widthper * (810 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
			Debug.Log("rect9");
			if(widthper * (810 /(float)10.9) - hSliderValue > 0 && widthper * (810 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (810 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (810 /(float)10.9) - hSliderValue > 0)) && widthper * (810 /(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (810 /(float)10.9) - hSliderValue > 0 && (!(widthper * (810 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
			if (GUI.Button(new Rect(widthper * (910 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"",guiskin.customStyles[10]))
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
			if(new Rect(widthper * (910 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
			Debug.Log("rect10");
			if(widthper * (910 /(float)10.9) - hSliderValue > 0 && widthper * (910 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (910 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (910 /(float)10.9) - hSliderValue > 0)) && widthper * (910 /(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (910 /(float)10.9) - hSliderValue > 0 && (!(widthper * (910 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
			if (GUI.Button(new Rect(widthper * (1010 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"MilBuild11",guiskin.customStyles[11]))
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
			if(new Rect(widthper * (1010 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
			Debug.Log("rect10");
			if(widthper * (1010 /(float)10.9) - hSliderValue > 0 && widthper * (1010 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (1010 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (1010 /(float)10.9) - hSliderValue > 0)) && widthper * (1010 /(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (1010 /(float)10.9) - hSliderValue > 0 && (!(widthper * (1010/(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
			if (GUI.Button(new Rect(widthper * (1110 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"MilBuild12",guiskin.customStyles[11]))
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
			if(new Rect(widthper * (1110 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
			Debug.Log("rect10");
			if(widthper * (1110 /(float)10.9) - hSliderValue > 0 && widthper * (1110 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (1110 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (1110 /(float)10.9) - hSliderValue > 0)) && widthper * (1110 /(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (1110 /(float)10.9) - hSliderValue > 0 && (!(widthper * (1110 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
			if (GUI.Button(new Rect(widthper * (1210 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"MilBuild13",guiskin.customStyles[11]))
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
			if(new Rect(widthper * (1210 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
			Debug.Log("rect10");
			if(widthper * (1210 /(float)10.9) - hSliderValue > 0 && widthper * (1210 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (1210 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (1210 /(float)10.9) - hSliderValue > 0)) && widthper * (1210 /(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (1210 /(float)10.9) - hSliderValue > 0 && (!(widthper * (1210 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
			if (GUI.Button(new Rect(widthper * (1310 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"MilBuild14",guiskin.customStyles[11]))
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
			if(new Rect(widthper * (1310 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
			Debug.Log("rect10");
			if(widthper * (1310 /(float)10.9) - hSliderValue > 0 && widthper * (1310 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (1310 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (1310 /(float)10.9) - hSliderValue > 0)) && widthper * (1310 /(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (1310 /(float)10.9) - hSliderValue > 0 && (!(widthper * (1310 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
			if (GUI.Button(new Rect(widthper * (1410 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"MilBuild15",guiskin.customStyles[11]))
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
			if(new Rect(widthper * (1410 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
			Debug.Log("rect10");
			if(widthper * (1410 /(float)10.9) - hSliderValue > 0 && widthper * (1410 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (1410 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (1410 /(float)10.9) - hSliderValue > 0)) && widthper * (1410 /(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (1410 /(float)10.9) - hSliderValue > 0 && (!(widthper * (1410 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
			if (GUI.Button(new Rect(widthper * (1510 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"MilBuild16",guiskin.customStyles[11]))
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
			if(new Rect(widthper * (1510 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
			Debug.Log("rect10");
			if(widthper * (1510 /(float)10.9) - hSliderValue > 0 && widthper * (1510 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (1510 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (1510 /(float)10.9) - hSliderValue > 0)) && widthper * (1510 /(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (1510 /(float)10.9) - hSliderValue > 0 && (!(widthper * (1510 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
			if (GUI.Button(new Rect(widthper * (1610 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"MilBuild17",guiskin.customStyles[11]))
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
			if(new Rect(widthper * (1610 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
			Debug.Log("rect10");
			if(widthper * (1610 /(float)10.9) - hSliderValue > 0 && widthper * (1610 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (1610 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (1610 /(float)10.9) - hSliderValue > 0)) && widthper * (1610 /(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (1610 /(float)10.9) - hSliderValue > 0 && (!(widthper * (1610 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
		}
		if (Commercial)
		{
			if (GUI.Button(new Rect(widthper * (10 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"ComBuild1",guiskin.customStyles[11]))
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
			if(new Rect(widthper * (10 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
			Debug.Log("rect10");
			if(widthper * (10 /(float)10.9) - hSliderValue > 0 && widthper * (10 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (10 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (10 /(float)10.9) - hSliderValue > 0)) && widthper * (10 /(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (10 /(float)10.9) - hSliderValue > 0 && (!(widthper * (10 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
			if (GUI.Button(new Rect(widthper * (110 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"ComBuild2",guiskin.customStyles[11]))
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
			if(new Rect(widthper * (110 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
			Debug.Log("rect10");
			if(widthper * (110 /(float)10.9) - hSliderValue > 0 && widthper * (110 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (110 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (110 /(float)10.9) - hSliderValue > 0)) && widthper * (110 /(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (110 /(float)10.9) - hSliderValue > 0 && (!(widthper * (110 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
			if (GUI.Button(new Rect(widthper * (210 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"ComBuild3",guiskin.customStyles[11]))
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
			if(new Rect(widthper * (210 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
			Debug.Log("rect10");
			if(widthper * (210 /(float)10.9) - hSliderValue > 0 && widthper * (2110 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (210 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (210 /(float)10.9) - hSliderValue > 0)) && widthper * (210 /(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (210 /(float)10.9) - hSliderValue > 0 && (!(widthper * (210 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
			if (GUI.Button(new Rect(widthper * (310 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"ComBuild4",guiskin.customStyles[11]))
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
			if(new Rect(widthper * (310 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
			Debug.Log("rect10");
			if(widthper * (310 /(float)10.9) - hSliderValue > 0 && widthper * (310 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (310 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (310 /(float)10.9) - hSliderValue > 0)) && widthper * (310 /(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (310 /(float)10.9) - hSliderValue > 0 && (!(widthper * (310 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
			if (GUI.Button(new Rect(widthper * (410 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"ComBuild5",guiskin.customStyles[11]))
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
			if(new Rect(widthper * (410 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
			Debug.Log("rect10");
			if(widthper * (410 /(float)10.9) - hSliderValue > 0 && widthper * (410 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (410 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (410 /(float)10.9) - hSliderValue > 0)) && widthper * (410 /(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (410 /(float)10.9) - hSliderValue > 0 && (!(widthper * (410 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
			if (GUI.Button(new Rect(widthper * (510 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"ComBuild6",guiskin.customStyles[11]))
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
			if(new Rect(widthper * (510 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
			Debug.Log("rect10");
			if(widthper * (510 /(float)10.9) - hSliderValue > 0 && widthper * (510 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (510 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (510 /(float)10.9) - hSliderValue > 0)) && widthper * (510 /(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (510 /(float)10.9) - hSliderValue > 0 && (!(widthper * (510 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
			if (GUI.Button(new Rect(widthper * (610 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"ComBuild7",guiskin.customStyles[11]))
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
			if(new Rect(widthper * (610 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
			Debug.Log("rect10");
			if(widthper * (610 /(float)10.9) - hSliderValue > 0 && widthper * (610 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (610 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (610 /(float)10.9) - hSliderValue > 0)) && widthper * (610 /(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (610 /(float)10.9) - hSliderValue > 0 && (!(widthper * (610 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
			if (GUI.Button(new Rect(widthper * (710 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"ComBuild8",guiskin.customStyles[11]))
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
			if(new Rect(widthper * (710 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
			Debug.Log("rect10");
			if(widthper * (710 /(float)10.9) - hSliderValue > 0 && widthper * (710 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (710 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (710 /(float)10.9) - hSliderValue > 0)) && widthper * (710 /(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (710 /(float)10.9) - hSliderValue > 0 && (!(widthper * (710 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
			if (GUI.Button(new Rect(widthper * (810 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"ComBuild9",guiskin.customStyles[11]))
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
			if(new Rect(widthper * (810 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
			Debug.Log("rect10");
			if(widthper * (810 /(float)10.9) - hSliderValue > 0 && widthper * (810 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (810 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (810 /(float)10.9) - hSliderValue > 0)) && widthper * (810 /(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (810 /(float)10.9) - hSliderValue > 0 && (!(widthper * (810 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
			if (GUI.Button(new Rect(widthper * (910 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"ComBuild10",guiskin.customStyles[11]))
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
			if(new Rect(widthper * (910 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
			Debug.Log("rect10");
			if(widthper * (910 /(float)10.9) - hSliderValue > 0 && widthper * (910 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (910 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (910 /(float)10.9) - hSliderValue > 0)) && widthper * (910 /(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (910 /(float)10.9) - hSliderValue > 0 && (!(widthper * (910 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
			if (GUI.Button(new Rect(widthper * (1010 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"ComBuild11",guiskin.customStyles[11]))
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
			if(new Rect(widthper * (1010 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
			Debug.Log("rect10");
			if(widthper * (1010 /(float)10.9) - hSliderValue > 0 && widthper * (1010 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (1010 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (1010 /(float)10.9) - hSliderValue > 0)) && widthper * (1010 /(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (1010 /(float)10.9) - hSliderValue > 0 && (!(widthper * (1010 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
			if (GUI.Button(new Rect(widthper * (1110 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"ComBuild12",guiskin.customStyles[11]))
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
			if(new Rect(widthper * (1110 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
			Debug.Log("rect10");
			if(widthper * (1110 /(float)10.9) - hSliderValue > 0 && widthper * (1110 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (1110 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (1110 /(float)10.9) - hSliderValue > 0)) && widthper * (1110 /(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (1110 /(float)10.9) - hSliderValue > 0 && (!(widthper * (1110 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
			if (GUI.Button(new Rect(widthper * (1210 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"ComBuild13",guiskin.customStyles[11]))
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
			if(new Rect(widthper * (1210 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
			Debug.Log("rect10");
			if(widthper * (1210 /(float)10.9) - hSliderValue > 0 && widthper * (1210 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (1210 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (1210 /(float)10.9) - hSliderValue > 0)) && widthper * (1210 /(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (1210 /(float)10.9) - hSliderValue > 0 && (!(widthper * (1210 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
			if (GUI.Button(new Rect(widthper * (1310 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"ComBuild14",guiskin.customStyles[11]))
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
			if(new Rect(widthper * (1310 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
			Debug.Log("rect10");
			if(widthper * (1310 /(float)10.9) - hSliderValue > 0 && widthper * (1310 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (1310 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (1310 /(float)10.9) - hSliderValue > 0)) && widthper * (1310 /(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (1310 /(float)10.9) - hSliderValue > 0 && (!(widthper * (1310 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
			if (GUI.Button(new Rect(widthper * (1410 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"ComBuild15",guiskin.customStyles[11]))
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
			if(new Rect(widthper * (1410 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
			Debug.Log("rect10");
			if(widthper * (1410 /(float)10.9) - hSliderValue > 0 && widthper * (1410 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (1410 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (1410 /(float)10.9) - hSliderValue > 0)) && widthper * (1410 /(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (1410 /(float)10.9) - hSliderValue > 0 && (!(widthper * (1410 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
			if (GUI.Button(new Rect(widthper * (1510 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"ComBuild16",guiskin.customStyles[11]))
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
			if(new Rect(widthper * (1510 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
			Debug.Log("rect10");
			if(widthper * (1510 /(float)10.9) - hSliderValue > 0 && widthper * (1510 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (1510 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (1510 /(float)10.9) - hSliderValue > 0)) && widthper * (1510 /(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (1510 /(float)10.9) - hSliderValue > 0 && (!(widthper * (1510 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
			if (GUI.Button(new Rect(widthper * (1610 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"ComBuild17",guiskin.customStyles[11]))
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
			if(new Rect(widthper * (1610 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
			Debug.Log("rect10");
			if(widthper * (1610 /(float)10.9) - hSliderValue > 0 && widthper * (1610 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (1610 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (1610 /(float)10.9) - hSliderValue > 0)) && widthper * (1610 /(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (1610 /(float)10.9) - hSliderValue > 0 && (!(widthper * (1610 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
		}
		if (Citizen)
		{
			if (GUI.Button(new Rect(widthper * (10 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"CitBuild1",guiskin.customStyles[11]))
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
			if(new Rect(widthper * (10 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
			Debug.Log("rect10");
			if(widthper * (10 /(float)10.9) - hSliderValue > 0 && widthper * (10 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (10 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (10 /(float)10.9) - hSliderValue > 0)) && widthper * (10 /(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (10 /(float)10.9) - hSliderValue > 0 && (!(widthper * (10 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
			if (GUI.Button(new Rect(widthper * (110 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"CitBuild2",guiskin.customStyles[11]))
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
			if(new Rect(widthper * (110 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
			Debug.Log("rect10");
			if(widthper * (110 /(float)10.9) - hSliderValue > 0 && widthper * (110 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (110 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (110 /(float)10.9) - hSliderValue > 0)) && widthper * (110 /(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (110 /(float)10.9) - hSliderValue > 0 && (!(widthper * (110 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
			if (GUI.Button(new Rect(widthper * (210 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"CitBuild3",guiskin.customStyles[11]))
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
			if(new Rect(widthper * (210 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
			Debug.Log("rect10");
			if(widthper * (210 /(float)10.9) - hSliderValue > 0 && widthper * (210 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (210 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (210 /(float)10.9) - hSliderValue > 0)) && widthper * (210 /(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (210 /(float)10.9) - hSliderValue > 0 && (!(widthper * (210 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
			if (GUI.Button(new Rect(widthper * (310 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"CitBuild4",guiskin.customStyles[11]))
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
			if(new Rect(widthper * (310 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
			Debug.Log("rect10");
			if(widthper * (310 /(float)10.9) - hSliderValue > 0 && widthper * (310 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (310 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (310 /(float)10.9) - hSliderValue > 0)) && widthper * (310 /(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (310 /(float)10.9) - hSliderValue > 0 && (!(widthper * (310 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
			if (GUI.Button(new Rect(widthper * (410 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"CitBuild5",guiskin.customStyles[11]))
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
			if(new Rect(widthper * (410 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
			Debug.Log("rect10");
			if(widthper * (410 /(float)10.9) - hSliderValue > 0 && widthper * (410 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (410 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (410 /(float)10.9) - hSliderValue > 0)) && widthper * (410 /(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (410 /(float)10.9) - hSliderValue > 0 && (!(widthper * (410 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
			if (GUI.Button(new Rect(widthper * (510 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"CitBuild6",guiskin.customStyles[11]))
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
			if(new Rect(widthper * (510 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
			Debug.Log("rect10");
			if(widthper * (510 /(float)10.9) - hSliderValue > 0 && widthper * (510 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (510 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (510 /(float)10.9) - hSliderValue > 0)) && widthper * (510 /(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (510 /(float)10.9) - hSliderValue > 0 && (!(widthper * (510 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
			if (GUI.Button(new Rect(widthper * (610 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"CitBuild7",guiskin.customStyles[11]))
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
			if(new Rect(widthper * (610 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
			Debug.Log("rect10");
			if(widthper * (610 /(float)10.9) - hSliderValue > 0 && widthper * (610 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (610 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (610 /(float)10.9) - hSliderValue > 0)) && widthper * (610 /(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (610 /(float)10.9) - hSliderValue > 0 && (!(widthper * (610 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
			if (GUI.Button(new Rect(widthper * (710 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"CitBuild8",guiskin.customStyles[11]))
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
			if(new Rect(widthper * (710 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
			Debug.Log("rect10");
			if(widthper * (710 /(float)10.9) - hSliderValue > 0 && widthper * (710 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (710 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (710 /(float)10.9) - hSliderValue > 0)) && widthper * (710 /(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (710 /(float)10.9) - hSliderValue > 0 && (!(widthper * (710 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
			if (GUI.Button(new Rect(widthper * (810 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"CitBuild9",guiskin.customStyles[11]))
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
			if(new Rect(widthper * (810 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
			Debug.Log("rect10");
			if(widthper * (810 /(float)10.9) - hSliderValue > 0 && widthper * (810 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (810 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (810 /(float)10.9) - hSliderValue > 0)) && widthper * (810 /(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (810 /(float)10.9) - hSliderValue > 0 && (!(widthper * (810 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
			if (GUI.Button(new Rect(widthper * (910 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"CitBuild10",guiskin.customStyles[11]))
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
			if(new Rect(widthper * (910 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
			Debug.Log("rect10");
			if(widthper * (910 /(float)10.9) - hSliderValue > 0 && widthper * (910 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (910 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (910 /(float)10.9) - hSliderValue > 0)) && widthper * (910 /(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (910 /(float)10.9) - hSliderValue > 0 && (!(widthper * (910 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
			if (GUI.Button(new Rect(widthper * (1010 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"CitBuild11"))
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
			if(new Rect(widthper * (1010 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
			Debug.Log("rect10");
			if(widthper * (1010 /(float)10.9) - hSliderValue > 0 && widthper * (1010 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (1010 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (1010 /(float)10.9) - hSliderValue > 0)) && widthper * (1010 /(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (1010 /(float)10.9) - hSliderValue > 0 && (!(widthper * (1010 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
			if (GUI.Button(new Rect(widthper * (1110 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"CitBuild12",guiskin.customStyles[11]))
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
			if(new Rect(widthper * (1110 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
			Debug.Log("rect10");
			if(widthper * (1110 /(float)10.9) - hSliderValue > 0 && widthper * (1110 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (1110 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (1110 /(float)10.9) - hSliderValue > 0)) && widthper * (1110 /(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (1110 /(float)10.9) - hSliderValue > 0 && (!(widthper * (1110 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
			if (GUI.Button(new Rect(widthper * (1210 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"CitBuild13",guiskin.customStyles[11]))
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
			if(new Rect(widthper * (1210 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
			Debug.Log("rect10");
			if(widthper * (1210 /(float)10.9) - hSliderValue > 0 && widthper * (1210 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (1210 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (1210 /(float)10.9) - hSliderValue > 0)) && widthper * (1210 /(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (1210 /(float)10.9) - hSliderValue > 0 && (!(widthper * (1210 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
			if (GUI.Button(new Rect(widthper * (1310 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"CitBuild14",guiskin.customStyles[11]))
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
			if(new Rect(widthper * (1310 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
			Debug.Log("rect10");
			if(widthper * (1310 /(float)10.9) - hSliderValue > 0 && widthper * (1310 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (1310 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (1310 /(float)10.9) - hSliderValue > 0)) && widthper * (1310 /(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (1310 /(float)10.9) - hSliderValue > 0 && (!(widthper * (1310 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
			if (GUI.Button(new Rect(widthper * (1410 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"CitBuild15",guiskin.customStyles[11]))
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
			if(new Rect(widthper * (1410 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
			Debug.Log("rect10");
			if(widthper * (1410 /(float)10.9) - hSliderValue > 0 && widthper * (1410 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (1410 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (1410 /(float)10.9) - hSliderValue > 0)) && widthper * (1410 /(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (1410 /(float)10.9) - hSliderValue > 0 && (!(widthper * (1410 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
			if (GUI.Button(new Rect(widthper * (1510 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"CitBuild16",guiskin.customStyles[11]))
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
			if(new Rect(widthper * (1510 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
			Debug.Log("rect10");
			if(widthper * (1510 /(float)10.9) - hSliderValue > 0 && widthper * (1510 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (1510 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (1510 /(float)10.9) - hSliderValue > 0)) && widthper * (1510 /(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (1510 /(float)10.9) - hSliderValue > 0 && (!(widthper * (1510 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
			if (GUI.Button(new Rect(widthper * (1610 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)),"CitBuild17",guiskin.customStyles[11]))
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
			if(new Rect(widthper * (1610 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (90/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
			Debug.Log("rect10");
			if(widthper * (1610 /(float)10.9) - hSliderValue > 0 && widthper * (1610 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (1610 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (1610 /(float)10.9) - hSliderValue > 0)) && widthper * (1610 /(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (1610 /(float)10.9) - hSliderValue > 0 && (!(widthper * (1610 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
		}
		GUI.EndGroup();
		GUI.EndGroup();
		GUI.EndGroup();
		hSliderValue = GUI.HorizontalSlider(new Rect(widthper * (80/(float)10.9),heightper * (290/(float)7.3),widthper * (1010/(float)10.9),heightper * (20/(float)7.3)),hSliderValue,0.0f,dlinnaScrolla);
		GUI.EndGroup();
		if (MilBuilds[0])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"MilBuild1");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X",guiskin.customStyles[11]))
			{
				MilBuilds[0] = false;
			}
			GUI.EndGroup();
		}
		if (MilBuilds[1])
		{
			
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"MilBuild2");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X",guiskin.customStyles[11]))
			{
				MilBuilds[1] = false;
			}
			GUI.EndGroup();
		}
		if (MilBuilds[2])
		{
			
			
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"MilBuild3");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X",guiskin.customStyles[11]))
			{
				MilBuilds[2] = false;
			}
			GUI.EndGroup();
		}
		if (MilBuilds[3])
		{
			
			
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"MilBuild4");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X",guiskin.customStyles[11]))
			{
				MilBuilds[3] = false;
			}
			GUI.EndGroup();
		}
		if (MilBuilds[4])
		{
			
			
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"MilBuild5");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X",guiskin.customStyles[11]))
			{
				MilBuilds[4] = false;
			}
			GUI.EndGroup();
		}
		if (MilBuilds[5])
		{
			
			
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"MilBuild6");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X",guiskin.customStyles[11]))
			{
				MilBuilds[5] = false;
			}
			GUI.EndGroup();
		}
		if (MilBuilds[6])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"MilBuild7");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X",guiskin.customStyles[11]))
			{
				MilBuilds[6] = false;
			}
			GUI.EndGroup();
		}
		if (MilBuilds[7])
		{
			
			
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"MilBuild8");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X",guiskin.customStyles[11]))
			{
				MilBuilds[7] = false;
			}
			GUI.EndGroup();
		}
		if (MilBuilds[8])
		{
			
			
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"MilBuild9");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X",guiskin.customStyles[11]))
			{
				MilBuilds[8] = false;
			}
			GUI.EndGroup();
		}
		if (MilBuilds[9])
		{
			
			
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"MilBuild10");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X",guiskin.customStyles[11]))
			{
				MilBuilds[9] = false;
			}
			GUI.EndGroup();
		}
		if (MilBuilds[10])
		{
			
			
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"MilBuild11");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X",guiskin.customStyles[11]))
			{
				MilBuilds[10] = false;
			}
			GUI.EndGroup();
		}
		if (MilBuilds[11])
		{
			
			
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"MilBuild12");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X",guiskin.customStyles[11]))
			{
				MilBuilds[11] = false;
			}
			GUI.EndGroup();
		}
		if (MilBuilds[12])
		{
			
			
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"MilBuild13");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X",guiskin.customStyles[11]))
			{
				MilBuilds[12] = false;
			}
			GUI.EndGroup();
		}
		if (MilBuilds[13])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"MilBuild14");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X",guiskin.customStyles[11]))
			{
				MilBuilds[13] = false;
			}
			GUI.EndGroup();
		}
		if (MilBuilds[14])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"MilBuild15");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X",guiskin.customStyles[11]))
			{
				MilBuilds[14] = false;
			}
			GUI.EndGroup();
		}
		if (MilBuilds[15])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"MilBuild16");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X",guiskin.customStyles[11]))
			{
				MilBuilds[15] = false;
			}
			GUI.EndGroup();
		}
		if (MilBuilds[16])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"MilBuild17");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X",guiskin.customStyles[11]))
			{
				MilBuilds[16] = false;
			}
			GUI.EndGroup();
		}
		if (ComBuilds[0])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"ComBuild1");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X",guiskin.customStyles[11]))
			{
				ComBuilds[0] = false;
			}
			GUI.EndGroup();
		}
		if (ComBuilds[1])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"ComBuild2");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X",guiskin.customStyles[11]))
			{
				ComBuilds[1] = false;
			}
			GUI.EndGroup();
		}
		if (ComBuilds[2])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"ComBuild3");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X",guiskin.customStyles[11]))
			{
				ComBuilds[2] = false;
			}
			GUI.EndGroup();
		}
		if (ComBuilds[3])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"ComBuild4");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X",guiskin.customStyles[11]))
			{
				ComBuilds[3] = false;
			}
			GUI.EndGroup();
		}
		if (ComBuilds[4])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"ComBuild5");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X",guiskin.customStyles[11]))
			{
				ComBuilds[4] = false;
			}
			GUI.EndGroup();
		}
		if (ComBuilds[5])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"ComBuild6");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X",guiskin.customStyles[11]))
			{
				ComBuilds[5] = false;
			}
			GUI.EndGroup();
		}
		if (ComBuilds[6])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"ComBuild7");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X",guiskin.customStyles[11]))
			{
				ComBuilds[6] = false;
			}
			GUI.EndGroup();
		}
		if (ComBuilds[7])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"ComBuild8");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X",guiskin.customStyles[11]))
			{
				ComBuilds[7] = false;
			}
			GUI.EndGroup();
		}
		if (ComBuilds[8])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"ComBuild9");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X",guiskin.customStyles[11]))
			{
				ComBuilds[8] = false;
			}
			GUI.EndGroup();
		}
		if (ComBuilds[9])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"ComBuild10");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X",guiskin.customStyles[11]))
			{
				ComBuilds[9] = false;
			}
			GUI.EndGroup();
		}
		if (ComBuilds[10])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"ComBuild11");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X",guiskin.customStyles[11]))
			{
				ComBuilds[10] = false;
			}
			GUI.EndGroup();
		}
		if (ComBuilds[11])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"ComBuild12");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X",guiskin.customStyles[11]))
			{
				ComBuilds[11] = false;
			}
			GUI.EndGroup();
		}
		if (ComBuilds[12])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"ComBuild13");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X",guiskin.customStyles[11]))
			{
				ComBuilds[12] = false;
			}
			GUI.EndGroup();
		}
		if (ComBuilds[13])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"ComBuild14");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X",guiskin.customStyles[11]))
			{
				ComBuilds[13] = false;
			}
			GUI.EndGroup();
		}
		if (ComBuilds[14])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"ComBuild15");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X",guiskin.customStyles[11]))
			{
				ComBuilds[14] = false;
			}
			GUI.EndGroup();
		}
		if (ComBuilds[15])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"ComBuild16");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X",guiskin.customStyles[11]))
			{
				ComBuilds[15] = false;
			}
			GUI.EndGroup();
		}
		if (ComBuilds[16])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"ComBuild17");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X",guiskin.customStyles[11]))
			{
				ComBuilds[16] = false;
			}
			GUI.EndGroup();
		}
		if (CitBuilds[0])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"CitBuild1");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X",guiskin.customStyles[11]))
			{
				CitBuilds[0] = false;
			}
			GUI.EndGroup();
		}
		if (CitBuilds[1])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"CitBuild2");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X",guiskin.customStyles[11]))
			{
				CitBuilds[1] = false;
			}
			GUI.EndGroup();
		}
		if (CitBuilds[2])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"CitBuild3");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X",guiskin.customStyles[11]))
			{
				CitBuilds[2] = false;
			}
			GUI.EndGroup();
		}
		if (CitBuilds[3])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"CitBuild4");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X",guiskin.customStyles[11]))
			{
				CitBuilds[3] = false;
			}
			GUI.EndGroup();
		}
		if (CitBuilds[4])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"CitBuild5");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X",guiskin.customStyles[11]))
			{
				CitBuilds[4] = false;
			}
			GUI.EndGroup();
		}
		if (CitBuilds[5])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"CitBuild6");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X",guiskin.customStyles[11]))
			{
				CitBuilds[5] = false;
			}
			GUI.EndGroup();
		}
		if (CitBuilds[6])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"CitBuild7");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X",guiskin.customStyles[11]))
			{
				CitBuilds[6] = false;
			}
			GUI.EndGroup();
		}
		if (CitBuilds[7])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"CitBuild8");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X",guiskin.customStyles[11]))
			{
				CitBuilds[7] = false;
			}
			GUI.EndGroup();
		}
		if (CitBuilds[8])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"CitBuild9");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X",guiskin.customStyles[11]))
			{
				CitBuilds[8] = false;
			}
			GUI.EndGroup();
		}
		if (CitBuilds[9])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"CitBuild10");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X",guiskin.customStyles[11]))
			{
				CitBuilds[9] = false;
			}
			GUI.EndGroup();
		}
		if (CitBuilds[10])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"CitBuild11");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X",guiskin.customStyles[11]))
			{
				CitBuilds[10] = false;
			}
			GUI.EndGroup();
		}
		if (CitBuilds[11])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"CitBuild12");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X",guiskin.customStyles[11]))
			{
				CitBuilds[11] = false;
			}
			GUI.EndGroup();
		}
		if (CitBuilds[12])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"CitBuild13");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X",guiskin.customStyles[11]))
			{
				CitBuilds[12] = false;
			}
			GUI.EndGroup();
		}
		if (CitBuilds[13])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"CitBuild14");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X",guiskin.customStyles[11]))
			{
				CitBuilds[13] = false;
			}
			GUI.EndGroup();
		}
		if (CitBuilds[14])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"CitBuild15");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X",guiskin.customStyles[11]))
			{
				CitBuilds[14] = false;
			}
			GUI.EndGroup();
		}
		if (CitBuilds[15])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"CitBuild16");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X",guiskin.customStyles[11]))
			{
				CitBuilds[15] = false;
			}
			GUI.EndGroup();
		}
		if (CitBuilds[16])
		{
			GUI.BeginGroup(new Rect(widthper * (300 / (float)10.9),heightper * ( 120 / (float)7.3),widthper * (500/(float)10.9),heightper * (450/(float)7.3)));
			GUI.Box(new Rect ( 0, 0, widthper * (500/(float)10.9),heightper * (450/(float)7.3)),"CitBuild17");
			if (GUI.Button(new Rect(widthper * (480/(float)10.9),0,widthper * (20/(float)10.9),heightper*(20/(float)7.3)),"X",guiskin.customStyles[11]))
			{
				CitBuilds[16] = false; 
			}
			GUI.EndGroup();
		}
		Gui_narisovan = true;
		Interface inter1 = (Interface)cam.GetComponent("Interface");
		if (inter1.Gui_narisovan)
		{
			if (isHovering1)
			{
				Interface inter = (Interface)cam.GetComponent("Interface");
				inter.vverx = true;
			}
			if (isHovering2)
			{
				Interface inter = (Interface)cam.GetComponent("Interface");
			}
			if(!isHovering)
			{
				GUI.Label(new Rect(widthper * (480 / (float)10.9),heightper * ( 0 / (float)7.3),widthper *( 100/ (float)10.9),heightper * (80/ (float)7.3)),"",guiskin.customStyles[3]);
				
				isDown = false;
			}
			else
			{
				GUI.Label(new Rect(widthper * (480 / (float)10.9),heightper * ( 0 / (float)7.3),widthper *( 100/ (float)10.9),heightper * (80/ (float)7.3)),"",guiskin.customStyles[4]);
				
				if(isDown)
				{
					GUI.Label(new Rect(widthper * (480 / (float)10.9),heightper * ( 0 / (float)7.3),widthper *( 100/ (float)10.9),heightper * (80/ (float)7.3)),"",guiskin.customStyles[5]);
					Interface inter = (Interface)cam.GetComponent("Interface");
					inter.startMission = true;
				}
			}
		}
	}
	private void dostypnost_knopok ()
	{
		if(knopka_1_dostypna)
		{
			knopka_zdanyi_1 = knopka_zdanyi_1_dostypna;
		}
		else
		{
			knopka_zdanyi_1 = knopka_zdanyi_1_nedostypna;
		}
		if(knopka_2_dostypna)
		{
			knopka_zdanyi_2 = knopka_zdanyi_2_dostypna;
		}
		else
		{
			knopka_zdanyi_2 = knopka_zdanyi_2_nedostypna;
		}
		if(knopka_3_dostypna)
		{
			knopka_zdanyi_3 = knopka_zdanyi_3_dostypna;
		}
		else
		{
			knopka_zdanyi_3 = knopka_zdanyi_3_nedostypna;
		}
		if(knopka_4_dostypna)
		{
			knopka_zdanyi_4 = knopka_zdanyi_4_dostypna;
		}
		else
		{
			knopka_zdanyi_4 = knopka_zdanyi_4_nedostypna;
		}
		if(knopka_5_dostypna)
		{
			knopka_zdanyi_5 = knopka_zdanyi_5_dostypna;
		}
		else
		{
			knopka_zdanyi_5 = knopka_zdanyi_5_nedostypna;
		}
	}
	void Start () {
		Gui_narisovan = false;
		fmx = 72;
		Zdanie = true;
		collichestvo_knopok = 17;
		coor = 430;
	}
	private void StartMission_knopka()
	{
		ray_startMission = cShapeGUIcamera.ScreenPointToRay(Input.mousePosition);
		
        if (Physics.Raycast(ray_startMission, out hit_startMission, 10)) 
		{
			if(hit_startMission.transform.name=="irregular_shape")
			{
				isHovering = true;
			
				if(Input.GetButton("Fire1")) 
				{
					isDown = true;
				}
				else
				{
					isDown = false;
				}
			}
        }
		if (Physics.Raycast(ray_startMission, out hit_startMission, 10)) 
		{
			if(hit_startMission.transform.name=="Button")
			{
				isHovering1 = true;
			}
			if(hit_startMission.transform.name=="Button1")
			{
				isHovering2 = true;
			}
			
        }
		else
		{
			isHovering = false;
			isHovering1 = false;
			
			isHovering2 = false;
			Interface inter = (Interface)cam.GetComponent("Interface");

		}
	}
	private void Rachet_scrolla_paneli_zdaniy()
	{
		if (collichestvo_knopok > 10)
		{
			dlinnaScrolla = (widthper * (90/(float)10.9) * (collichestvo_knopok - 10)) - 15;
		}
		if (collichestvo_knopok <= 10)
		{
			dlinnaScrolla = 0.01f;
		}
	}
	private void Rachet_scrolla_paneli_upgrades()
	{
		if (Upgrades_collichestvo_knopok > 5)
		{
			UpgradesDlinna = (widthper * (95/(float)10.9) * (Upgrades_collichestvo_knopok - 5)) + widthper * (7/(float)10.9);
		}
		if (Upgrades_collichestvo_knopok <= 5)
		{
			UpgradesDlinna = 0.1f;
		}
	}
	private void Rachet_scrolla_paneli_ratings()
	{
		if (Ratings_collichestvo_knopok > 7)
		{
			Ratings_dlinna = (widthper * (66/(float)10.9) * (Ratings_collichestvo_knopok - 7));
		}
		if (Ratings_collichestvo_knopok <= 7)
		{
			Ratings_dlinna = 0.1f;
		}
	}
	private void skritie_panely_zdaniy()
	{
		if (coor < 730)
		{
			GameObject.Find("Button").collider.enabled = false;
		}
		if (coor > 440)
			GameObject.Find("Button1").collider.enabled = false;
		if (coor < 440)
			GameObject.Find("Button1").collider.enabled = true;
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
			coor += 3;
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
			coor -= 3;
			if (coor < 430)
			{
				vverx = false;
				coor = 430;
			}
			if (coor == 430)
			{
				vverx = false;
				knopka = false;
			}
		}
	}
	private void Rachet_widthper_heightper_and_shrift ()
	{
		widthper = Screen.width / (float)100;
		heightper = Screen.height / (float)100;
		guiskin.customStyles[11].fontSize=Screen.width/fmx;
		guiskin.customStyles[13].fontSize=Screen.width/fmx;
	}
	private void Rachet_scrolla_Issledovatelskogo_zdaniya()
	{
		if (Build_collichestvo_knopok > 7)
		{
			Build_dlinnaScrolla = (widthper * (50/(float)10.9) * (Build_collichestvo_knopok - 7));
		}
		if (Build_collichestvo_knopok <= 7)
		{
			Build_dlinnaScrolla = 0.01f;
		}
	}
	private void Opisanie_zdaniy()
	{
		Ray ray_Build = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit_Build;
		if(!StratMod)
		{
			if(Physics.Raycast(ray_Build, out hit_Build,1000,BuildsLayer))
			{
				lastHitBuild = hit_Build.collider.gameObject;
				if (lastHitBuild.tag == "Issledovaniya_Build" && Input.GetMouseButtonDown(0))
				{
					Build_MainScreen B_MS = (Build_MainScreen)lastHitBuild.GetComponent("Build_MainScreen");
					Name_Build = B_MS.Name;
					Opisanie_Build = B_MS.Opisanie;
					Opisanie_GUI = true;
				}
				if (lastHitBuild.tag == "Quests_Build" && Input.GetMouseButtonDown(0))
				{
					zadaniya = true;
				}
			}
		}
	}
	private void Setka_i_deystviya_knopok_panely_zdaniy()
	{
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
		}
		else
		{
			if (lastHitObj)
			{
				lastHitObj.renderer.material = originalMat;
				lastHitObj = null;
			}
		}
		if (lastHitObj&&CubArray[0])
		{
			if (pref && !Create) {
					StratMod = true;
					TPref = Instantiate (pref, hit.point, Quaternion.identity) as Transform;
					Build_MainScreen bild = (Build_MainScreen)TPref.GetComponent("Build_MainScreen");
					bild.active_My = false;
					Create = true;
			}
			else if (Create)
				{
					if(lastHitObj)
						TPref.position = lastHitObj.transform.position;
					if(Input.GetAxis("Mouse ScrollWheel")>0.0)
					{
						TPref.Rotate(0,90.0f,0);
					}
					if(Input.GetAxis("Mouse ScrollWheel")<0.0)
					{
						TPref.Rotate(0,-90.0f,0);
					}
				}
			if(lastHitObj.tag == "PlacementPlane_Open")
			{
				if (Input.GetMouseButtonDown(0) && canCreate)
				{
					Build_MainScreen bild = (Build_MainScreen)TPref.GetComponent("Build_MainScreen");
					bild.active_My = true;
					lastHitObj.tag = "PlacementPlane_Taken";
					Create = false;
					CubArray[0] = false;
					StratMod = false;
				}
			}
		}	
	
	}
	void Update () {
		Rachet_scrolla_paneli_upgrades();
		Rachet_scrolla_paneli_ratings();
		Opisanie_zdaniy();
		Setka_i_deystviya_knopok_panely_zdaniy();
		Rachet_scrolla_Issledovatelskogo_zdaniya();
		Rachet_widthper_heightper_and_shrift();
		Rachet_scrolla_paneli_zdaniy();
		skritie_panely_zdaniy();
		StartMission_knopka();
		
		
	}
}
