using UnityEngine;
using System.Collections;

public class GameInterface : MonoBehaviour {
	private bool ibool = false;
	private float cooltime = 0.0f;
	private float skrittime = 0.0f;
	private float pausetime = 0.0f;
	private float pausetimesum = 0.0f;
	public bool interfaceusing = false;
	private Transform TPref;
	private float widthper;
	private float heightper;
	private bool Box1 = false;
	private bool[] Builds_Button_Array = new bool[12];
	private GameObject camera;
	public Transform pref;
	public Transform pref2;
	public Transform pref3;
	public Transform pref4;
	public Transform pref5;
	public Transform pref6;
	public Transform pref7;
	public Transform pref8;
	public Transform pref9;
	public Transform pref10;
	public Transform pref11;
	public Transform pref12;
	public bool StratMod = false;
	private bool Military = false;
	private bool Commercial = true;
	private bool Citizen = false;
	private Camera cam = new Camera();
	private float mouse_x;
	private float mouse_y;
	
	private Transform placementPlanesRoot;
	public Material eror;
	public Material hoverMat;
	public LayerMask placementLayerMask = new LayerMask();
	Material originalMat;
	private GameObject lastHitObj;
	
	Color onColor;
	Color offColor;
	GameObject[] allStructures;
	private int structureIndex = 0;
	
	
	private bool knopka = false;
	public bool vverx = false;
	private GUIStyle guistl;
	private Texture2D textur;
	private float hSliderValue = 0.0f;
	private bool vniz = false;
	private float coor = 430.0f;
	private int coor1 = 570;
	private int coor2 = 570;
	private int i = 10;
	
	public Texture2D infopanel;
	
	private bool test;
	private int testint;
	
	public bool canCreate = true;
	
	private bool Create = false;
	private bool Pause = false;
	private bool EndMission = false;
	private bool End = false;
	private int score = 0;
	private int voznagrazdenie = 0;
	private int vragov = 0;
	public Texture2D pause;
//	public Texture2D pause_text_1;
//	public Texture2D pause_text_2;
//	public Texture2D pause_text_3;
	public Texture2D text;
	public GUISkin guiskin;
	//private bool Restart = false;
	
	public Texture2D BarExit;
	public Texture2D InfoBar;
	public Texture2D SpellPanel;
	
	private int fmx = 72;
	private int fmx1 = 16;
	public int fmx2=72;
	
	public Texture2D Builds_Bar;
	
	private int enemy_kills = 0;
	
	private bool Builds = true;
	private bool Friends = false;
	
	public int collichestvo_knopok = 0;
	private float dlinnaScrolla = 0;
	//Булевые переменные доступности кнопок
	private bool knopka_1_dostypna = true;
	private bool knopka_2_dostypna = true;
	private bool knopka_3_dostypna = true;
	private bool knopka_4_dostypna = true;
	private bool knopka_5_dostypna = true;
	private bool knopka_6_dostypna = true;
	private bool knopka_7_dostypna = true;
	private bool knopka_8_dostypna = true;
	private bool knopka_9_dostypna = false;
	private bool knopka_10_dostypna = false;
	private bool knopka_11_dostypna = false;
	private bool knopka_12_dostypna = false;
	//Текстуры для доступных кнопок
	public Texture2D knopka_zdanyi_1_dostypna;
	public Texture2D knopka_zdanyi_2_dostypna;
	public Texture2D knopka_zdanyi_3_dostypna;
	public Texture2D knopka_zdanyi_4_dostypna;
	public Texture2D knopka_zdanyi_5_dostypna;
	public Texture2D knopka_zdanyi_6_dostypna;
	public Texture2D knopka_zdanyi_7_dostypna;
	public Texture2D knopka_zdanyi_8_dostypna;
	public Texture2D knopka_zdanyi_9_dostypna;
	public Texture2D knopka_zdanyi_10_dostypna;
	public Texture2D knopka_zdanyi_11_dostypna;
	public Texture2D knopka_zdanyi_12_dostypna;
	//Текстуры для недоступных кнопок
	public Texture2D knopka_zdanyi_1_nedostypna;
	public Texture2D knopka_zdanyi_2_nedostypna;
	public Texture2D knopka_zdanyi_3_nedostypna;
	public Texture2D knopka_zdanyi_4_nedostypna;
	public Texture2D knopka_zdanyi_5_nedostypna;
	public Texture2D knopka_zdanyi_6_nedostypna;
	public Texture2D knopka_zdanyi_7_nedostypna;
	public Texture2D knopka_zdanyi_8_nedostypna;
	public Texture2D knopka_zdanyi_9_nedostypna;
	public Texture2D knopka_zdanyi_10_nedostypna;
	public Texture2D knopka_zdanyi_11_nedostypna;
	public Texture2D knopka_zdanyi_12_nedostypna;
	//Текстуры для кнопок
	private Texture2D knopka_zdanyi_1;
	private Texture2D knopka_zdanyi_2;
	private Texture2D knopka_zdanyi_3;
	private Texture2D knopka_zdanyi_4;
	private Texture2D knopka_zdanyi_5;
	private Texture2D knopka_zdanyi_6;
	private Texture2D knopka_zdanyi_7;
	private Texture2D knopka_zdanyi_8;
	private Texture2D knopka_zdanyi_9;
	private Texture2D knopka_zdanyi_10;
	private Texture2D knopka_zdanyi_11;
	private Texture2D knopka_zdanyi_12;
	//Переменные спеллов
	public bool spell_1 = false;
	public bool	spell_2 = false;
	public bool spell_3 = false;
	
	private bool[] ButtonArray_Navodka = new bool[14];
	
	private bool Scaling=false;
	public GameObject[] DeEnemies;
	public bool Aud=true;
	
	public int currentColor  = 0;
    public float changeTime = 0;
    public Color[] colors;
	public Color colorED = Color.white;
	private int timerScaling=0;
	public bool pressedBtnPause=false;
	public Transform GlobalRocket;
	public Transform ExplosionBody;
	public Transform Rock;
	public Transform Body;
	private bool GlobalExplosion=false;
	//отрисовка с учетом аспектов
	private float asprat=0.0f;
	private float coordx=0.0f; //для времени
	private float coordy=0.0f;	//для времени
	private float coordy1=0.0f;	//для волны
	private float coordy2=0.0f;	//для волны 
	private float coordx1=0.0f;	//для денег
	private float coordx2=0.0f;
	private int coordy3=0;	//для волны
	private float coordy4=0.0f;	//для волны 
	public float panLx=0.0f;	//для денег
	public float panLy=0.0f;
	
	public string currWave=""; //из скрипта UpgradesBuilds в MainWaves далее в GameInterface
	public string currGold="";
	public string currTime="";
	
	public Color TextColor = Color.white;
	public Color anyTextColor = Color.white;
	
	public int cash =150;
	public bool purchased = false;
	public bool accept = true;
	public bool denied = false;
	//public bool result = false;
	//public bool recept=false;
	
	//Метод отчистки
	private void Ochistka_Massiva_Navodki ()
	{
		for (int ite = 0; ite <= 11 ; ite++)
			ButtonArray_Navodka[ite] = false;
	}
	
	void NextColor(){
    if(currentColor>=colors.Length-1){
        currentColor = 0;
    }else{
        currentColor +=1;
    }
}
	void SetChangeTime(float ct){
    changeTime = ct;
}
	
	//ГУИ
	void OnGUI()
	{
		//if (!accept) purchased=false;
		
		asprat = Mathf.Round(gameObject.camera.aspect * 100.0f) / 100.0f;
		
		if (asprat==1.25f) {coordx=10.5f;coordy=6.75f;coordy1=5.45f;coordy2=9.9f;coordx1=6.29f;coordx2=21.2f;coordy3=30;coordy4=11f;}
		if (asprat==1.33f) {coordx=10.5f;coordy=6.2f;coordy1=5f;coordy2=9.1f;coordx1=6.29f;coordx2=21.4f;coordy3=30;coordy4=11f;}
		if (asprat==1.5f) {coordx=10.35f;coordy=5.65f;coordy1=4.5f;coordy2=8.3f;coordx1=6.15f;coordx2=20.14f;coordy3=17;coordy4=9f;}
		if (asprat==1.6f) {coordx=10.25f;coordy=6.23f;coordy1=4.7f;coordy2=9.04f;coordx1=6.15f;coordx2=20.14f;coordy3=17;coordy4=9f;}
		if (asprat==1.78f) {coordx=10.35f;coordy=5.5f;coordy1=4.2f;coordy2=8.1f;coordx1=6.21f;coordx2=20.14f;coordy3=0;coordy4=7.3f;}
//		
		RenderSettings.ambientLight = Color.Lerp (RenderSettings.ambientLight, colors[currentColor], changeTime*Time.deltaTime);
		
		GUI.BeginGroup(new Rect(widthper * (1010/(float)10.9),heightper * (370/(float)7.3),widthper * (80/(float)10.9),heightper * (220/(float)7.3)));
		GUI.DrawTexture(new Rect(0,0,widthper * (80/(float)10.9),heightper * (220/(float)7)),SpellPanel);
		if (GUI.Button(new Rect (widthper * (10/(float)10.9),heightper * (10/(float)5),widthper * (60/(float)10.9),heightper * (60/(float)7.3)),"1",guiskin.customStyles[11]))
		{
			spell_1 = true;
			spell_2 = false;
			spell_3 = false;
			Scaling=true;
		}
		if (GUI.Button(new Rect (widthper * (10/(float)10.9),heightper * (80/(float)7),widthper * (60/(float)10.9),heightper * (60/(float)7.3)),"2",guiskin.customStyles[11]))
		{
			spell_1 = false;
			spell_2 = true;
			spell_3 = false;
			GlobalExplosion=true;
		}
		if (GUI.Button(new Rect (widthper * (10/(float)10.9),heightper * (150/(float)7.2),widthper * (60/(float)10.9),heightper * (60/(float)7.3)),"3",guiskin.customStyles[11]))
		{	
			spell_1 = false;
			spell_2 = false;
			spell_3 = true;
		}
		GUI.EndGroup();
//		//Панель умений
//		GUI.BeginGroup(new Rect(widthper * (870/panLx),heightper * (200/panLy),widthper * (200/(float)10.9),heightper * (110/(float)7.3)));
//		GUI.DrawTexture(new Rect(0,0,widthper * (200/(float)10.9),heightper * (110/(float)7.3)),SpellPanel);
//		if (GUI.Button(new Rect (widthper * (70/(float)10.9),heightper * (10/(float)7.3),widthper * (60/(float)10.9),heightper * (40/(float)7.3)),"1",guiskin.customStyles[11]))
//		{
//			Scaling=true;
//		}
//		if (GUI.Button(new Rect (widthper * (35/(float)10.9),heightper * (60/(float)7.3),widthper * (60/(float)10.9),heightper * (40/(float)7.3)),"2",guiskin.customStyles[11]))
//		{
//			
//		}
//		if (GUI.Button(new Rect (widthper * (105/(float)10.9),heightper * (60/(float)7.3),widthper * (60/(float)10.9),heightper * (40/(float)7.3)),"3",guiskin.customStyles[11]))
//		{
//			
//		}
//		GUI.EndGroup();
		
		//Панель заданий
		GUI.BeginGroup(new Rect(widthper * (525/(float)10.9),heightper * (0/(float)7.3),widthper * (575/(float)10.9),heightper * (175/(float)7.3)));
		guiskin.customStyles[0].normal.textColor = TextColor;
		guiskin.customStyles[0].hover.textColor = TextColor;
		//GUI.color = Color.yellow;
		//GUI.DrawTexture(new Rect(widthper * (0/(float)10.9),heightper * (0/(float)7.3),widthper * (575/(float)10.9),heightper * (175/(float)7.3)),infopanel);
		GUI.Label(new Rect(widthper * (435/coordx),heightper * (60/coordy),widthper * (80/(float)10.9),heightper * (20/(float)7.3)),currTime,guiskin.customStyles[0]);
		GUI.Label(new Rect(widthper * (435/coordx2),heightper * (100/coordy2),widthper * (80/(float)10.9),heightper * (20/(float)7.3)),currGold,guiskin.customStyles[0]);
		GUI.Label(new Rect(widthper * (275/coordx1),heightper * (70/coordy1),widthper * (40/(float)10.9),heightper * (20/(float)7.3)),currWave,guiskin.customStyles[0]);
		GUI.EndGroup();
		//Пауза и последующие после неё меню
		guiskin.customStyles[11].normal.textColor = anyTextColor;
		guiskin.customStyles[11].hover.textColor = anyTextColor;
		if (Pause)
		{
			if (!EndMission)
			{
				GUI.BeginGroup (new Rect (widthper *(400/(float)10.9),heightper*(200/(float)7.3),widthper*(250/(float)10.9),heightper*(100/(float)7.3)));
				//GUI.Label(new Rect(widthper * (90/(float)10.9),heightper*(5/(float)7.3),widthper * (80/(float)10.9),heightper*(20/(float)7.3)),"Pause",guiskin.customStyles[11]);
				GUI.DrawTexture(new Rect(0,heightper * (30/(float)7.3),widthper * (250/(float)10.9),heightper * (50/(float)7.3)),BarExit);
				if (GUI.Button(new Rect (widthper * (200/(float)10.9),heightper * (45/(float)7.3),widthper * (40/(float)10.9),heightper * (20/(float)7.3)),"",guiskin.customStyles[6]))
				{
					EndMission = true;
				}
				GUI.EndGroup();
			}
			if(EndMission)
			{
				GUI.BeginGroup(new Rect(widthper * (300/(float)10.9),heightper * (180/(float)7.3),widthper * (500/(float)10.9),heightper * (350/(float)7.3)));
				GUI.DrawTexture(new Rect(0,heightper * (30/(float)7.3),widthper * (300/(float)7.3),heightper * (300/(float)7.3)),InfoBar);
				guiskin.customStyles[7].normal.textColor = Color.white;
				guiskin.customStyles[7].hover.textColor = Color.white;
				GUI.Label(new Rect(widthper * (22.5f/(float)10.9),heightper * (110/(float)7.3),widthper * (130/(float)10.9),heightper *(100/(float)7.3)),score.ToString(),guiskin.customStyles[12]);
				GUI.Label(new Rect(widthper * (150/(float)10.9),heightper * (110/(float)7.3),widthper * (140/(float)10.9),heightper *(100/(float)7.3)),voznagrazdenie.ToString().ToString(),guiskin.customStyles[12]);
				GUI.Label(new Rect(widthper * (290/(float)10.9),heightper * (110/(float)7.3),widthper * (130/(float)10.9),heightper *(100/(float)7.3)),enemy_kills.ToString(),guiskin.customStyles[12]);
				GUI.Label(new Rect(widthper * (22.5f/(float)10.9),heightper * (235/(float)7.3),widthper * (270/(float)10.9),heightper *(70/(float)7.3)),"Nety :c",guiskin.customStyles[12]);
				if (GUI.Button(new Rect(widthper * (320/(float)10.9),heightper * (235/(float)7.3),widthper * (85/(float)10.9),heightper * (70/(float)7.3)),"",guiskin.customStyles[6]))
				{
					End = true;
				}
				GUI.EndGroup();
			}
		}
		if (End)
		{
			Application.LoadLevel(0);
		}
		GUI.BeginGroup(new Rect(0,40,widthper * (328/(float)10.9),heightper * (100/(float)7.3)));
		//GUI.DrawTexture(new Rect(0,0,widthper * (280/(float)10.9),heightper * (78/(float)7.3)),pause);
		if (pressedBtnPause)
		{
			Pause = true;
			Time.timeScale = 0.0f;
		}
		if (!pressedBtnPause)
		{
			if(!EndMission)
			{
				Pause = false;
				Time.timeScale = 1.0f;
			}
		}
//		if (GUI.Button(new Rect(widthper * (187/(float)10.9),heightper * (10/(float)7.3),widthper * (75/(float)10.9),heightper * (55/(float)7.3)),"",guiskin.customStyles[0]))
//		{
//			Restart = true;
//		}
		GUI.EndGroup();
		//Нижняя панель
		GUI.BeginGroup(new Rect(widthper * (0 /(float)10.9),heightper * (coor /(float)7.3),widthper * (1090 /(float)10.9),heightper * (1080/(float)7.3)));
		//Кнопка сокрытия
		if (GUI.Button(new Rect(widthper * (1010 / (float)10.9),heightper * (160 /(float)7.3),widthper * (80 /(float)10.9),heightper * (40/(float)7.3)),"Скрыть",guiskin.customStyles[11]))
		{
			vniz = true;
		}
		//Кнопка зданий
//		if (GUI.Button(new Rect(0,heightper * (160/(float)7.3),widthper * (40 /(float)10.9),heightper * (40/(float)7.3)),"1",guiskin.customStyles[11]))
//		{
//			Builds = true;
//			Friends = false;
//		}
		//Кнопка друзей
//		if (GUI.Button(new Rect(widthper * (40/(float)10.9),heightper * (160/(float)7.3),widthper * (40/(float)10.9),heightper * (40/(float)7.3)),"2",guiskin.customStyles[11]))
//		{
//			Builds = false;
//			Friends = true;
//		}
		GUI.BeginGroup(new Rect(widthper * (0 /(float)10.9),heightper * (100/(float)7.3),widthper * (1090/(float)10.9),heightper * (200/(float)6)));
		GUI.DrawTexture(new Rect(widthper * (0 /(float)10.9),heightper * (100/(float)12),widthper * (1090/(float)10.9),heightper * (120/(float)6)),Builds_Bar);
		GUI.BeginGroup(new Rect(widthper * (8 /(float)10.9),heightper * (0/(float)7.3),widthper * (1077.5f/(float)10.9),heightper * (300/(float)7.3)));
		
		//Кнопки со зданиями
		if(Builds)
		{
			if (GUI.Button(new Rect(widthper * (10 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (88/(float)10.9),heightper * (80/(float)7.3)),knopka_zdanyi_1,guiskin.customStyles[11]))
			{	
				//Изменено проверка на доступность
				if(knopka_1_dostypna)
				{
//					for (int i = 0; i < 6; i++)
//					{
//						Builds_Button_Array[i] = false;
//					}
					cash=300;
					//accept=true;
					Builds_Button_Array[0] = true;
					StratMod = true;
				}
			}
			if(new Rect(widthper * (10 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (88/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
				Ochistka_Massiva_Navodki();
				ButtonArray_Navodka[0] = true;
				//Debug.Log("rect1");
				if(widthper * (10 /(float)10.9) - hSliderValue > 0 && widthper * (10 /(float)10.9) - hSliderValue < 709)
				{
					
					GUI.Box(new Rect(widthper * (10 /(float)10.9) - hSliderValue,heightper * (coordy3/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)coordy4)),"\n      Миниган:  Ур.1  300$\n     Стрельба: 0.9сек\n     Сила: 1.2\n     Атака: наземные цели",guiskin.customStyles[1]);
				}
				if((!(widthper * (10 /(float)10.9) - hSliderValue > 0)) && widthper * (10 /(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (coordy3/(float)7.3),widthper * (190/(float)10.9),heightper * (100/coordy4)),"\n      Миниган:  Ур.1  300$\n     Стрельба: 0.9сек\n     Сила: 1.2\n     Атака: наземные цели",guiskin.customStyles[1]);
				if(widthper * (10 /(float)10.9) - hSliderValue > 0 && (!(widthper * (10 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (coordy3/(float)7.3),widthper * (190/(float)10.9),heightper * (100/coordy4)),"\n      Миниган:  Ур.1  300$\n     Стрельба: 0.9сек\n     Сила: 1.2\n     Атака: наземные цели",guiskin.customStyles[1]);
			}
			
			if (GUI.Button(new Rect(widthper * (108 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (88/(float)10.9),heightper * (80/(float)7.3)),knopka_zdanyi_2,guiskin.customStyles[11]))
			{
				//Изменено проверка на доступность
				if(knopka_2_dostypna)
				{
//					for (int i = 0; i < 6; i++)
//					{
//						Builds_Button_Array[i] = false;
//					}
					Builds_Button_Array[1] = true;
					StratMod = true;
				}
				
			}
			if(new Rect(widthper * (108 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (88/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
				
				Ochistka_Massiva_Navodki();
				ButtonArray_Navodka[1] = true;
				//Debug.Log("rect2");
				if(widthper * (108 /(float)10.9) - hSliderValue > 0 && widthper * (108 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (108 /(float)10.9) - hSliderValue,heightper * (coordy3/(float)7.3),widthper * (190/(float)10.9),heightper * (100/coordy4)),"\n      Двустволка:  Ур.1  420$\n     Стрельба: 1сек\n     Сила: 1.7\n     Атака: наземные цели",guiskin.customStyles[1]);
				}
				if((!(widthper * (108 /(float)10.9) - hSliderValue > 0)) && widthper * (108/(float)10.9) - hSliderValue < 709){
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (coordy3/(float)7.3),widthper * (190/(float)10.9),heightper * (100/coordy4)),"rect2");}
				if(widthper * (108 /(float)10.9) - hSliderValue > 0 && (!(widthper * (108 /(float)10.9) - hSliderValue < 709))){
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (coordy3/(float)7.3),widthper * (190/(float)10.9),heightper * (100/coordy4)),"rect2");}
			
			}
			if (GUI.Button(new Rect(widthper * (205 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (88/(float)10.9),heightper * (80/(float)7.3)),knopka_zdanyi_3,guiskin.customStyles[11]))
			{
				//Изменено проверка на доступность
				if(knopka_3_dostypna)
				{
//					for (int i = 0; i < 6; i++)
//					{
//						Builds_Button_Array[i] = false;
//					}
					Builds_Button_Array[2] = true;
					StratMod = true;
				}
			}
			if(new Rect(widthper * (205 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (88/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
				Ochistka_Massiva_Navodki();
				ButtonArray_Navodka[2] = true;
				//Debug.Log("rect3");
				if(widthper * (205 /(float)10.9) - hSliderValue > 0 && widthper * (205 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (205 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (205 /(float)10.9) - hSliderValue > 0)) && widthper * (205/(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (205 /(float)10.9) - hSliderValue > 0 && (!(widthper * (205 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
			
			if (GUI.Button(new Rect(widthper * (302 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (88/(float)10.9),heightper * (80/(float)7.3)),knopka_zdanyi_4,guiskin.customStyles[11]))
			{
				//Изменено проверка на доступность
				if(knopka_4_dostypna)
				{
//					for (int i = 0; i < 6; i++)
//					{
//						Builds_Button_Array[i] = false;
//					}
					Builds_Button_Array[3] = true;
					StratMod = true;
				}
			}
			if(new Rect(widthper * (302 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (88/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
				Ochistka_Massiva_Navodki();
				ButtonArray_Navodka[3] = true;
				//Debug.Log("rect4");
				if(widthper * (302 /(float)10.9) - hSliderValue > 0 && widthper * (302 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (302 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (302 /(float)10.9) - hSliderValue > 0)) && widthper * (302/(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (302 /(float)10.9) - hSliderValue > 0 && (!(widthper * (302 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
			if (GUI.Button(new Rect(widthper * (399 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (88/(float)10.9),heightper * (80/(float)7.3)),knopka_zdanyi_5,guiskin.customStyles[11]))
			{
				//Изменено проверка на доступность
				if(knopka_5_dostypna)
				{
//					for (int i = 0; i <= 6; i++)
//					{
//						Builds_Button_Array[i] = false;
//					}
					Builds_Button_Array[4] = true;
					StratMod = true;
				}
			}
			if(new Rect(widthper * (399 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (88/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
				Ochistka_Massiva_Navodki();
				ButtonArray_Navodka[4] = true;
				//Debug.Log("rect5");
				if(widthper * (399 /(float)10.9) - hSliderValue > 0 && widthper * (399 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (399 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (399 /(float)10.9) - hSliderValue > 0)) && widthper * (399/(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (399 /(float)10.9) - hSliderValue > 0 && (!(widthper * (399 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
			if (GUI.Button(new Rect(widthper * (496 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (88/(float)10.9),heightper * (80/(float)7.3)),knopka_zdanyi_6,guiskin.customStyles[11]))
			{
				//Изменено проверка на доступность
				if(knopka_6_dostypna)
				{
//					for (int i = 0; i <= 6; i++)
//					{
//						Builds_Button_Array[i] = false;
//					}
					Builds_Button_Array[5] = true;
					StratMod = true;
				}
			}
			if(new Rect(widthper * (496 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (88/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
				Ochistka_Massiva_Navodki();
				ButtonArray_Navodka[5] = true;
				//Debug.Log("rect6");
				if(widthper * (496 /(float)10.9) - hSliderValue > 0 && widthper * (496 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (496 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (496 /(float)10.9) - hSliderValue > 0)) && widthper * (496/(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (496 /(float)10.9) - hSliderValue > 0 && (!(widthper * (496 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
			if (GUI.Button(new Rect(widthper * (593 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (88/(float)10.9),heightper * (80/(float)7.3)),knopka_zdanyi_7,guiskin.customStyles[11]))
			{
				//Изменено проверка на доступность
				if(knopka_7_dostypna)
				{
//					for (int i = 0; i <= 6; i++)
//					{
//						Builds_Button_Array[i] = false;
//					}
					Builds_Button_Array[6] = true;
					StratMod = true;
				}
			}
			if(new Rect(widthper * (593 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (88/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
				Ochistka_Massiva_Navodki();
				ButtonArray_Navodka[6] = true;
				//Debug.Log("rect7");
				if(widthper * (593 /(float)10.9) - hSliderValue > 0 && widthper * (593 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (593 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (593 /(float)10.9) - hSliderValue > 0)) && widthper * (593/(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (593 /(float)10.9) - hSliderValue > 0 && (!(widthper * (593 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
			if (GUI.Button(new Rect(widthper * (690 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (88/(float)10.9),heightper * (80/(float)7.3)),knopka_zdanyi_8,guiskin.customStyles[11]))
			{
				//Изменено проверка на доступность
				if(knopka_8_dostypna)
				{
//					for (int i = 0; i <= 6; i++)
//					{
//						Builds_Button_Array[i] = false;
//					}
					Builds_Button_Array[7] = true;
					StratMod = true;
				}
			}
			if(new Rect(widthper * (690 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (88/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
				Ochistka_Massiva_Navodki();
				ButtonArray_Navodka[7] = true;
				//Debug.Log("rect8");
				if(widthper * (690 /(float)10.9) - hSliderValue > 0 && widthper * (690 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (690 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (690 /(float)10.9) - hSliderValue > 0)) && widthper * (690/(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (690 /(float)10.9) - hSliderValue > 0 && (!(widthper * (690 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
			if (GUI.Button(new Rect(widthper * (787 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (88/(float)10.9),heightper * (80/(float)7.3)),knopka_zdanyi_9,guiskin.customStyles[11]))
			{
				//Изменено проверка на доступность
				if(knopka_9_dostypna)
				{
//					for (int i = 0; i <= 6; i++)
//					{
//						Builds_Button_Array[i] = false;
//					}
					Builds_Button_Array[8] = true;
					StratMod = true;
				}
			}
			if(new Rect(widthper * (787 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (88/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
				Ochistka_Massiva_Navodki();
				ButtonArray_Navodka[8] = true;
				//Debug.Log("rect9");
				if(widthper * (787 /(float)10.9) - hSliderValue > 0 && widthper * (787 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (787 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (787 /(float)10.9) - hSliderValue > 0)) && widthper * (787/(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (787 /(float)10.9) - hSliderValue > 0 && (!(widthper * (787 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
			if (GUI.Button(new Rect(widthper * (884 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (88/(float)10.9),heightper * (80/(float)7.3)),knopka_zdanyi_10,guiskin.customStyles[11]))
			{
				//Изменено проверка на доступность
				if(knopka_10_dostypna)
				{
//					for (int i = 0; i <= 6; i++)
//					{
//						Builds_Button_Array[i] = false;
//					}
					Builds_Button_Array[9] = true;
					StratMod = true;
				}
			}
			if(new Rect(widthper * (884 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (88/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
				Ochistka_Massiva_Navodki();
				ButtonArray_Navodka[9] = true;
				//Debug.Log("rect10");
				if(widthper * (884 /(float)10.9) - hSliderValue > 0 && widthper * (884 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (884 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (884 /(float)10.9) - hSliderValue > 0)) && widthper * (884/(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (884 /(float)10.9) - hSliderValue > 0 && (!(widthper * (884 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
			if (GUI.Button(new Rect(widthper * (981 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (88/(float)10.9),heightper * (80/(float)7.3)),knopka_zdanyi_11,guiskin.customStyles[11]))
			{
				//Изменено проверка на доступность
				if(knopka_11_dostypna)
				{
//					for (int i = 0; i <= 6; i++)
//					{
//						Builds_Button_Array[i] = false;
//					}
					Builds_Button_Array[10] = true;
					StratMod = true;
				}
			}
			if(new Rect(widthper * (981 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (88/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
				Ochistka_Massiva_Navodki();
				ButtonArray_Navodka[10] = true;
				//Debug.Log("rect11");
				if(widthper * (981 /(float)10.9) - hSliderValue > 0 && widthper * (981 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (981 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (981 /(float)10.9) - hSliderValue > 0)) && widthper * (981/(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (981 /(float)10.9) - hSliderValue > 0 && (!(widthper * (981 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
			if (GUI.Button(new Rect(widthper * (1078 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (88/(float)10.9),heightper * (80/(float)7.3)),knopka_zdanyi_12,guiskin.customStyles[11]))
			{
				//Изменено проверка на доступность
				if(knopka_12_dostypna)
				{
//					for (int i = 0; i <= 6; i++)
//					{
//						Builds_Button_Array[i] = false;
//					}
					Builds_Button_Array[11] = true;
					StratMod = true;
				}
			}
			if(new Rect(widthper * (1078 /(float)10.9) - hSliderValue,heightper * (110/(float)7.3),widthper * (88/(float)10.9),heightper * (80/(float)7.3)).Contains(Event.current.mousePosition))
			{
				Ochistka_Massiva_Navodki();
				ButtonArray_Navodka[11] = true;
				//Debug.Log("rect12");
				if(widthper * (1078 /(float)10.9) - hSliderValue > 0 && widthper * (1078 /(float)10.9) - hSliderValue < 709)
				{
					GUI.Box(new Rect(widthper * (1078 /(float)10.9) - hSliderValue,heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				}
				if((!(widthper * (1078 /(float)10.9) - hSliderValue > 0)) && widthper * (1078/(float)10.9) - hSliderValue < 709)
					GUI.Box(new Rect(widthper * (10 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
				if(widthper * (1078 /(float)10.9) - hSliderValue > 0 && (!(widthper * (1078 /(float)10.9) - hSliderValue < 709)))
					GUI.Box(new Rect(widthper * (810 /(float)10.9),heightper * (0/(float)7.3),widthper * (190/(float)10.9),heightper * (100/(float)7.3)),"rect2");
			}
		}
		GUI.EndGroup();
		GUI.EndGroup();
		//Скролл
		hSliderValue = GUI.HorizontalSlider(new Rect(widthper * (10/(float)10.9),heightper * (290/(float)7.3),widthper * (1080/(float)10.9),heightper * (20/(float)7.3)),hSliderValue,0.0f,dlinnaScrolla);
		GUI.EndGroup();
	if (Scaling) {
			timerScaling+=1;
			DeEnemies=GameObject.FindGameObjectsWithTag("Enemy");
		var EmiObjects = GameObject.FindGameObjectsWithTag("EMI");
			foreach (var Emi in EmiObjects) {
 			if (Emi.gameObject.name=="plane") {Emi.transform.localScale +=new Vector3(0.3F,0.3F,0.3F);
				if (Aud){
				NextColor();
				Emi.audio.Play();
					Aud=false;
					}
				}
			}
			foreach (var GoEnemies in DeEnemies) {
			AIfind foo = GoEnemies.transform.parent.GetComponent("AIfind") as AIfind;
				foo.Electric=true;
				foo.ElPowLvl=0.0f;
			}
			if (timerScaling==150) NextColor();
			if (timerScaling>=220){
			timerScaling=0;
				Scaling=false;
			}
		}
		if (GlobalExplosion) {
			
//	if (GlobalExplosion) {
			Instantiate(GlobalRocket, Rock.transform.position, Quaternion.identity);
			Instantiate(ExplosionBody, Body.transform.position, Quaternion.identity);
				GlobalExplosion=false;
			//}
				GlobalExplosion=false;
			//}
		}
	}
	
	void Start () {
		dlinnaScrolla=80.0f;
		knopka_zdanyi_1 = knopka_zdanyi_1_dostypna;
		knopka_zdanyi_2 = knopka_zdanyi_2_dostypna;
		knopka_zdanyi_3 = knopka_zdanyi_3_dostypna;
		knopka_zdanyi_4 = knopka_zdanyi_4_dostypna;
		knopka_zdanyi_5 = knopka_zdanyi_5_dostypna;
		knopka_zdanyi_6 = knopka_zdanyi_6_dostypna;
		knopka_zdanyi_7 = knopka_zdanyi_7_dostypna;
		knopka_zdanyi_8 = knopka_zdanyi_8_dostypna;
		knopka_zdanyi_9 = knopka_zdanyi_9_dostypna;
		knopka_zdanyi_10 = knopka_zdanyi_10_dostypna;
		knopka_zdanyi_11 = knopka_zdanyi_11_dostypna;
		knopka_zdanyi_12 = knopka_zdanyi_12_dostypna;
		
		Builds = true;
		Friends = false;
		Ochistka_Massiva_Navodki();
		fmx = 72;
		fmx1 = 16;
		test = true;
		skrittime = 2;
		if (cooltime == 0)
		{
			cooltime = 2.0f;
		}
		structureIndex = 0;
		for (int i = 0;i < 11;i++)
		{
			Builds_Button_Array[i] = false;
		}
	}
	//Метод выполняет скрытие и возобновление панели со зданиями
	private void skrivanie()
	{
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
			if (coor < 730)
			{
				GameObject.Find("Button").collider.enabled = false;
			}
			if (coor > 540)
				GameObject.Find("Button1").collider.enabled = false;
			if (coor < 540)
				GameObject.Find("Button1").collider.enabled = true;
	}
	//Рассчёт переменной для скролла в барзе со зданиями
//	private void rachet_collichestvo_knopok()
//	{
//		if (collichestvo_knopok > 11)
//		{
//			dlinnaScrolla = ((widthper * (105/(float)10.9) * (collichestvo_knopok - 11)) - 15);
//		}
//		if (collichestvo_knopok <= 11)
//		{
//			dlinnaScrolla = 0.01f;
//		}
//	}
	//Сетка и действия для кнопок с панели зданий (Через массив Builds_Button_Array)
	private void Setka_and_Knopki_Zdanyi()
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
		if (lastHitObj&&Builds_Button_Array[0])
		{
			
			
			
			if (pref && !Create) {
				TPref = Instantiate (pref, hit.point, Quaternion.Euler (0, 45.0f, 0)) as Transform;
				Build bild = (Build)TPref.GetComponent("Build");
				bild.active_My = false;
				TPref.gameObject.tag="Untagged";
				Create = true;
					
			} else if (Create)
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
			
			
			if (Input.GetMouseButtonDown(1) && Create)
			{
				Destroy(TPref.gameObject);
				Create = false;
				Builds_Button_Array[0] = false;
			}
			
			
			
			
			if(lastHitObj.tag == "PlacementPlane_Open")
			{
				if (Input.GetMouseButtonDown(0) && canCreate && !denied && !accept){
				purchased=true;
				}				
				
			}
			if (accept){
					foreach (Transform childMat in TPref)
						if (childMat.name=="TransWhite") childMat.active=false;
					Build bild = (Build)TPref.GetComponent("Build");
					bild.active_My = true;
					TPref.collider.isTrigger = false;
					lastHitObj.tag = "PlacementPlane_Taken";
					Create = false;
					TPref.active=false;
					TPref.gameObject.tag="Active";
					TPref.active=true;
					Builds_Button_Array[0] = false;
				accept=false;
					} 
			if (denied){
				Destroy(TPref.gameObject);
				Create = false;
			Builds_Button_Array[0] = false;
				}
			
		
		}
		
		
		
		
		
		if (lastHitObj&&Builds_Button_Array[1])//проследить
		{
			if (pref && !Create) {
				TPref = Instantiate (pref2, hit.point, Quaternion.Euler (0, 45.0f, 0)) as Transform;//проследить pref
				Build bild = (Build)TPref.GetComponent("Build");
				bild.active_My = false;
				TPref.gameObject.tag="Untagged";
				Create = true;
					
			} else if (Create)
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
			if (Input.GetMouseButtonDown(1) && Create)
			{
				Destroy(TPref.gameObject);
				Create = false;
				Builds_Button_Array[1] = false;//проследить
			}
			if(lastHitObj.tag == "PlacementPlane_Open")
			{
				if (Input.GetMouseButtonDown(0) && canCreate)
				{
					foreach (Transform childMat in TPref)
						if (childMat.name=="TransWhite") childMat.active=false;
					Build bild = (Build)TPref.GetComponent("Build");
					bild.active_My = true;
					TPref.collider.isTrigger = false;
					lastHitObj.tag = "PlacementPlane_Taken";
					Create = false;
					TPref.active=false;
					TPref.gameObject.tag="Active";
					TPref.active=true;
					Builds_Button_Array[1] = false; //проследить
				}
			}
		}
		
		if (lastHitObj&&Builds_Button_Array[2])//проследить
		{
			if (pref && !Create) {
				TPref = Instantiate (pref3, hit.point, Quaternion.Euler (0, 45.0f, 0)) as Transform;//проследить pref
				Build bild = (Build)TPref.GetComponent("Build");
				bild.active_My = false;
				TPref.gameObject.tag="Untagged";
				Create = true;
					
			} else if (Create)
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
			if (Input.GetMouseButtonDown(1) && Create)
			{
				Destroy(TPref.gameObject);
				Create = false;
				Builds_Button_Array[2] = false;//проследить
			}
			if(lastHitObj.tag == "PlacementPlane_Open")
			{
				if (Input.GetMouseButtonDown(0) && canCreate)
				{
					foreach (Transform childMat in TPref)
						if (childMat.name=="TransWhite") childMat.active=false;
					Build bild = (Build)TPref.GetComponent("Build");
					bild.active_My = true;
					TPref.collider.isTrigger = false;
					lastHitObj.tag = "PlacementPlane_Taken";
					Create = false;
					TPref.active=false;
					TPref.gameObject.tag="Active";
					TPref.active=true;
					Builds_Button_Array[2] = false; //проследить
				}
			}
		}
		
		if (lastHitObj&&Builds_Button_Array[3])//проследить
		{
			if (pref && !Create) {
				TPref = Instantiate (pref4, hit.point, Quaternion.Euler (0, 45.0f, 0)) as Transform;//проследить pref
				Build bild = (Build)TPref.GetComponent("Build");
				bild.active_My = false;
				TPref.gameObject.tag="Untagged";
				Create = true;
					
			} else if (Create)
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
			if (Input.GetMouseButtonDown(1) && Create)
			{
				Destroy(TPref.gameObject);
				Create = false;
				Builds_Button_Array[3] = false;//проследить
			}
			if(lastHitObj.tag == "PlacementPlane_Open")
			{
				if (Input.GetMouseButtonDown(0) && canCreate)
				{
					foreach (Transform childMat in TPref)
						if (childMat.name=="TransWhite") childMat.active=false;
					Build bild = (Build)TPref.GetComponent("Build");
					bild.active_My = true;
					TPref.collider.isTrigger = false;
					lastHitObj.tag = "PlacementPlane_Taken";
					Create = false;
					TPref.active=false;
					TPref.gameObject.tag="Active";
					TPref.active=true;
					Builds_Button_Array[3] = false; //проследить
				}
			}
		}
		if (lastHitObj&&Builds_Button_Array[4])//проследить
		{
			if (pref && !Create) {
				TPref = Instantiate (pref5, hit.point, Quaternion.Euler (0, 45.0f, 0)) as Transform;//проследить pref
				Build bild = (Build)TPref.GetComponent("Build");
				bild.active_My = false;
				TPref.gameObject.tag="Untagged";
				Create = true;
					
			} else if (Create)
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
			if (Input.GetMouseButtonDown(1) && Create)
			{
				Destroy(TPref.gameObject);
				Create = false;
				Builds_Button_Array[4] = false;//проследить
			}
			if(lastHitObj.tag == "PlacementPlane_Open")
			{
				if (Input.GetMouseButtonDown(0) && canCreate)
				{
					foreach (Transform childMat in TPref)
						if (childMat.name=="TransWhite") childMat.active=false;
					Build bild = (Build)TPref.GetComponent("Build");
					bild.active_My = true;
					TPref.collider.isTrigger = false;
					lastHitObj.tag = "PlacementPlane_Taken";
					Create = false;
					TPref.active=false;
					TPref.gameObject.tag="Active";
					TPref.active=true;
					Builds_Button_Array[4] = false; //проследить
				}
			}
		}
		if (lastHitObj&&Builds_Button_Array[5])
		{
			if (pref && !Create) {
				TPref = Instantiate (pref6, hit.point, Quaternion.Euler (0, 45.0f, 0)) as Transform;
				Build bild = (Build)TPref.GetComponent("Build");
				bild.active_My = false;
				TPref.gameObject.tag="Untagged";
				Create = true;
			} else if (Create)
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
			if (Input.GetMouseButtonDown(1) && Create)
			{
				Destroy(TPref.gameObject);
				Create = false;
				Builds_Button_Array[5] = false;
			}
			if(lastHitObj.tag == "PlacementPlane_Open")
			{
				if (Input.GetMouseButtonDown(0) && canCreate)
				{
					Build bild = (Build)TPref.GetComponent("Build");
					bild.active_My = true;
					lastHitObj.tag = "PlacementPlane_Taken";
					Create = false;
					TPref.active=false;
					TPref.gameObject.tag="Active";
					TPref.active=true;
					Builds_Button_Array[5] = false;
				}
			}
		}
		if (lastHitObj&&Builds_Button_Array[6])
		{
			if (pref && !Create) {
				TPref = Instantiate (pref7, hit.point, Quaternion.Euler (0, 45.0f, 0)) as Transform;
				Build bild = (Build)TPref.GetComponent("Build");
				bild.active_My = false;
				TPref.gameObject.tag="Untagged";
				Create = true;
			} else if (Create)
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
			if (Input.GetMouseButtonDown(1) && Create)
			{
				Destroy(TPref.gameObject);
				Create = false;
				Builds_Button_Array[6] = false;
			}
			if(lastHitObj.tag == "PlacementPlane_Open")
			{
				if (Input.GetMouseButtonDown(0) && canCreate)
				{
					Build bild = (Build)TPref.GetComponent("Build");
					bild.active_My = true;
					lastHitObj.tag = "PlacementPlane_Taken";
					Create = false;
					TPref.active=false;
					TPref.gameObject.tag="Active";
					TPref.active=true;
					Builds_Button_Array[6] = false;
				}
			}
		}
		if (lastHitObj&&Builds_Button_Array[7])
		{
			if (pref && !Create) {
				TPref = Instantiate (pref8, hit.point, Quaternion.Euler (0, 45.0f, 0)) as Transform;
				Build bild = (Build)TPref.GetComponent("Build");
				bild.active_My = false;
				TPref.gameObject.tag="Untagged";
				Create = true;
			} else if (Create)
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
			if (Input.GetMouseButtonDown(1) && Create)
			{
				Destroy(TPref.gameObject);
				Create = false;
				Builds_Button_Array[7] = false;
			}
			if(lastHitObj.tag == "PlacementPlane_Open")
			{
				if (Input.GetMouseButtonDown(0) && canCreate)
				{
					Build bild = (Build)TPref.GetComponent("Build");
					bild.active_My = true;
					lastHitObj.tag = "PlacementPlane_Taken";
					Create = false;
					TPref.active=false;
					TPref.gameObject.tag="Active";
					TPref.active=true;
					Builds_Button_Array[7] = false;
				}
			}
		}
		if (lastHitObj&&Builds_Button_Array[8])
		{
			if (pref && !Create) {
				TPref = Instantiate (pref9, hit.point, Quaternion.Euler (0, 45.0f, 0)) as Transform;
				Build bild = (Build)TPref.GetComponent("Build");
				bild.active_My = false;
				TPref.gameObject.tag="Untagged";
				Create = true;
			} else if (Create)
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
			if (Input.GetMouseButtonDown(1) && Create)
			{
				Destroy(TPref.gameObject);
				Create = false;
				Builds_Button_Array[8] = false;
			}
			if(lastHitObj.tag == "PlacementPlane_Open")
			{
				if (Input.GetMouseButtonDown(0) && canCreate)
				{
					Build bild = (Build)TPref.GetComponent("Build");
					bild.active_My = true;
					lastHitObj.tag = "PlacementPlane_Taken";
					Create = false;
					TPref.active=false;
					TPref.gameObject.tag="Active";
					TPref.active=true;
					Builds_Button_Array[8] = false;
				}
			}
		}
		if (lastHitObj&&Builds_Button_Array[9])
		{
			if (pref && !Create) {
				TPref = Instantiate (pref10, hit.point, Quaternion.Euler (0, 45.0f, 0)) as Transform;
				Build bild = (Build)TPref.GetComponent("Build");
				bild.active_My = false;
				TPref.gameObject.tag="Untagged";
				Create = true;
			} else if (Create)
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
			if (Input.GetMouseButtonDown(1) && Create)
			{
				Destroy(TPref.gameObject);
				Create = false;
				Builds_Button_Array[9] = false;
			}
			if(lastHitObj.tag == "PlacementPlane_Open")
			{
				if (Input.GetMouseButtonDown(0) && canCreate)
				{
					Build bild = (Build)TPref.GetComponent("Build");
					bild.active_My = true;
					lastHitObj.tag = "PlacementPlane_Taken";
					Create = false;
					TPref.active=false;
					TPref.gameObject.tag="Active";
					TPref.active=true;
					Builds_Button_Array[9] = false;
				}
			}
		}
		if (lastHitObj&&Builds_Button_Array[10])
		{
			if (pref && !Create) {
				TPref = Instantiate (pref11, hit.point, Quaternion.Euler (0, 45.0f, 0)) as Transform;
				Build bild = (Build)TPref.GetComponent("Build");
				bild.active_My = false;
				TPref.gameObject.tag="Untagged";
				Create = true;
			} else if (Create)
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
			if (Input.GetMouseButtonDown(1) && Create)
			{
				Destroy(TPref.gameObject);
				Create = false;
				Builds_Button_Array[10] = false;
			}
			if(lastHitObj.tag == "PlacementPlane_Open")
			{
				if (Input.GetMouseButtonDown(0) && canCreate)
				{
					Build bild = (Build)TPref.GetComponent("Build");
					bild.active_My = true;
					lastHitObj.tag = "PlacementPlane_Taken";
					Create = false;
					TPref.active=false;
					TPref.gameObject.tag="Active";
					TPref.active=true;
					Builds_Button_Array[10] = false;
				}
			}
		}
		if (lastHitObj&&Builds_Button_Array[11])
		{
			if (pref && !Create) {
				TPref = Instantiate (pref12, hit.point, Quaternion.Euler (0, 45.0f, 0)) as Transform;
				Build bild = (Build)TPref.GetComponent("Build");
				bild.active_My = false;
				TPref.gameObject.tag="Untagged";
				Create = true;
			} else if (Create)
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
			if (Input.GetMouseButtonDown(1) && Create)
			{
				Destroy(TPref.gameObject);
				Create = false;
				Builds_Button_Array[11] = false;
			}
			if(lastHitObj.tag == "PlacementPlane_Open")
			{
				if (Input.GetMouseButtonDown(0) && canCreate)
				{
					Build bild = (Build)TPref.GetComponent("Build");
					bild.active_My = true;
					lastHitObj.tag = "PlacementPlane_Taken";
					Create = false;
					TPref.active=false;
					TPref.gameObject.tag="Active";
					TPref.active=true;
					Builds_Button_Array[11] = false;
				}
			}
		}

	}
	//Автоматическое вставка текстур для кнопок взависимости от доступности
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
		if(knopka_6_dostypna)
		{
			knopka_zdanyi_6 = knopka_zdanyi_6_dostypna;
		}
		else
		{
			knopka_zdanyi_6 = knopka_zdanyi_6_nedostypna;
		}
		if(knopka_7_dostypna)
		{
			knopka_zdanyi_7 = knopka_zdanyi_7_dostypna;
		}
		else
		{
			knopka_zdanyi_7 = knopka_zdanyi_7_nedostypna;
		}
		if(knopka_8_dostypna)
		{
			knopka_zdanyi_8 = knopka_zdanyi_8_dostypna;
		}
		else
		{
			knopka_zdanyi_8 = knopka_zdanyi_8_nedostypna;
		}
		if(knopka_9_dostypna)
		{
			knopka_zdanyi_9 = knopka_zdanyi_9_dostypna;
		}
		else
		{
			knopka_zdanyi_9 = knopka_zdanyi_9_nedostypna;
		}
		if(knopka_10_dostypna)
		{
			knopka_zdanyi_10 = knopka_zdanyi_10_dostypna;
		}
		else
		{
			knopka_zdanyi_10 = knopka_zdanyi_10_nedostypna;
		}
		if(knopka_11_dostypna)
		{
			knopka_zdanyi_11 = knopka_zdanyi_11_dostypna;
		}
		else
		{
			knopka_zdanyi_11 = knopka_zdanyi_11_nedostypna;
		}
		if(knopka_12_dostypna)
		{
			knopka_zdanyi_12 = knopka_zdanyi_12_dostypna;
		}
		else
		{
			knopka_zdanyi_12 = knopka_zdanyi_12_nedostypna;
		}
	}
	void Update () {
		dostypnost_knopok ();
		Setka_and_Knopki_Zdanyi();
		skrivanie();
		//rachet_collichestvo_knopok();
		guiskin.customStyles[12].fontSize=Screen.width/fmx1;
		guiskin.customStyles[11].fontSize=Screen.width/fmx;
		guiskin.customStyles[0].fontSize=Screen.width/fmx;
		guiskin.customStyles[1].fontSize=Screen.width/fmx2;
//		if (Restart)
//		{
//			Application.LoadLevel(1);
//		}
		widthper = Screen.width / (float)100;
		heightper = Screen.height / (float)100;
	}
}
