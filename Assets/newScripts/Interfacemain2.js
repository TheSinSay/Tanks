var git0:Texture2D;
var git00:Texture2D;
var git:Texture2D;
var git001:Texture2D;
var git01:Texture2D;
var git02:Texture2D;

var font : Font;
var b:boolean=false;
var l:boolean=true;
var t:boolean=true;
var tb:boolean=true;
var k:boolean=true;
var k1:boolean=true;
var time:float=0;
var x:float=0;
var y:float=0;
var x1:float=0;
var y1:float=0;
var y2:float=0;
var y3:float=0;
var y4:float=0;
var y5:float=0;

//////////////////////////git01 coords

var gx:float=0;

var gxt:float=0;
var gyt:float=0;
var gity:float=0;


//////////////////////////mainmenuwords coords

var mx:float=0;
var fx:float=0;
var my:float=0;
var fmx:float=0;
var fmx1:float=0;
var m1y:float=0;
var m2y:float=0;
var m3y:float=0;
var m4y:float=0;

var fade : float = 1.0f;
var life:Texture2D;
var life1:Texture2D;
var bool:boolean=false;
var bool1:boolean=false;

var strmes:String="";
var but1:boolean=false;
var but2:boolean=false;
var but3:boolean=false;
var but4:boolean=false;
var but7:boolean=false;
var but8:boolean=false;
var firstmach:boolean=true;
var change:boolean=false;
var online:boolean=false;
var options:boolean=false;
var mission:boolean=false;

function Awake() {
   //RefreshAspect();
}
 
function RefreshAspect() {
   var aspect: float = 1/Camera.main.aspect;
   transform.localScale.x = transform.localScale.y * aspect * guiElement.texture.width/guiElement.texture.height;
   transform.position = transform.localPosition;
}

function Update()
{
if (k){
if (!bool) {fade +=  Time.deltaTime*2;
if (fade>=1) {
if (but7){options=false;online=false;change=false;mission=false;CHANGEMENU();firstmach=true;}
if (but8){change=true;CHANGEMENU();mission=false;}
if (but1){firstmach=false;mission=false;CHANGEMENU();change=true;}
if (but2){firstmach=false;mission=false;CHANGEMENU();online=true;}
if (but3){firstmach=false;mission=false;CHANGEMENU();options=true;}
if (but4){change=false;CHANGEMENU();mission=true;}
} 
if (fade>=1.5){fade=1.02;bool=true;}
}
if (bool) {fade -= Time.deltaTime*2;if (fade<=0.1){fade=0;bool=false;k=false;}
}
}
}

var BigFontStyle : GUIStyle;
var SFontStyle : GUIStyle;
var LFontStyle : GUIStyle;

function OnGUI()
{
x=Random.Range(-6.0,6.0);
y=Random.Range(-6.0,6.0);

if (t)
{
CICLE();
tb=true;
t=false;
}
if (l){
time=Random.Range(0.1,0.2);
SHOWLINES();
l=false;
}
GUI.DrawTexture(Rect(0,gity,Screen.width,Screen.height), git0, ScaleMode.StretchToFill,true, 0.0f);
//if (k1) GUI.DrawTexture(Rect(0,gity1,Screen.width,Screen.height), git00, ScaleMode.StretchToFill, true, 0.0f);
GUI.DrawTexture(Rect(0,0,Screen.width,Screen.height), git, ScaleMode.StretchToFill, true, 0.0f);
GUI.DrawTexture(Rect(gx,Screen.height/gxt,4096,Screen.height/gyt), git001, ScaleMode.StretchToFill, true, 0.0f);
GUI.DrawTexture(Rect(0,0,Screen.width,Screen.height), git01, ScaleMode.StretchToFill, true, 0.0f);
GUI.DrawTexture(Rect(0,0,Screen.width,Screen.height), git02, ScaleMode.StretchToFill, true, 0.0f);
//GUI.DrawTexture(Rect(git03x,0,Screen.width,Screen.height), git03, ScaleMode.StretchToFill, true, 0.0f);
BigFontStyle.fontSize=Screen.width/fx;
SFontStyle.fontSize=Screen.width/fmx;
LFontStyle.fontSize=Screen.width/fmx1;
//SFontStyle=GUI.skin.button;
GUI.skin.font = font;
GUI.Label(Rect(Screen.width/mx,Screen.height/my,300,50),strmes, BigFontStyle);

if (firstmach){
if (GUI.Button(Rect(Screen.width/mx,Screen.height/m1y,150,25),"Новая игра", SFontStyle))
{
fade=0;
k=true;
but1=true;           //////////newgame
but2=false;          //////////online
but3=false;
but7=false;         //////////exit  from ng
but8=false;
}
if (GUI.Button(Rect(Screen.width/mx,Screen.height/m2y,150,25),"Онлайн", SFontStyle))
{
fade=0;
k=true;
but1=false;        ////////newgame
but2=true;           ///////online
but3=false; 
but7=false;          /////////exit from ng
but8=false;
}
if (GUI.Button(Rect(Screen.width/mx,Screen.height/m3y,150,25),"Настройки", SFontStyle))
{
fade=0;
k=true;
but1=false;        ////////newgame
but2=false;
but3=true;           ///////online
but7=false;          /////////exit from ng
but8=false;
}
if (GUI.Button(Rect(Screen.width/mx,Screen.height/m4y,150,25),"Выход", SFontStyle))
{}
}
///////////////////////////first newgameoptions
if (change)
{
m3y=2.06;
my=3.65;

if (GUI.Button(Rect(Screen.width/mx,Screen.height/m1y,150,25),"Загрузка", SFontStyle))
{

}
if (GUI.Button(Rect(Screen.width/mx,Screen.height/m2y,150,25),"Выбор миссии", SFontStyle))
{
fade=0;
k=true;
but1=false;           //////////newgame
but2=false;          //////////online
but3=false;
but4=true;
but7=false;         //////////exit  from ng
but8=false;
}
if (GUI.Button(Rect(Screen.width/mx,Screen.height/m3y,150,25),"Назад", SFontStyle))
{
fade=0;
k=true;
but1=false;
but2=false;
but3=false;
but7=true;
but8=false;
}
}
///////////////////////////mission select
if (mission)
{
///////////////////////////draw mission border
m3y=1.11;
my=17.14;

GUI.Label(Rect(Screen.width/x1+300,Screen.height/y1,150,25),"-",LFontStyle);
if (GUI.Button(Rect(Screen.width/x1,Screen.height/y1,150,25),"25 кадр - док",LFontStyle))
{
} 
GUI.Label(Rect(Screen.width/x1+300,Screen.height/y2,150,25),"-",LFontStyle);
if (GUI.Button(Rect(Screen.width/x1,Screen.height/y2,150,25),"Подземка",LFontStyle))
{
} 
GUI.Label(Rect(Screen.width/x1+300,Screen.height/y3,150,25),"-",LFontStyle);
if (GUI.Button(Rect(Screen.width/x1,Screen.height/y3,150,25),"Дорога в ад",LFontStyle))
{
} 
GUI.Label(Rect(Screen.width/x1+300,Screen.height/y4,150,25),"-",LFontStyle);
if (GUI.Button(Rect(Screen.width/x1,Screen.height/y4,150,25),"Вулканическая болезнь",LFontStyle))
{
} 
GUI.Label(Rect(Screen.width/x1+300,Screen.height/y5,150,25),"-",LFontStyle);
if (GUI.Button(Rect(Screen.width/x1,Screen.height/y5,150,25),"Ядерная атака",LFontStyle))
{
} 
///////////////////////////
if (GUI.Button(Rect(Screen.width/mx,Screen.height/m3y,150,25),"Назад", SFontStyle))
{
fade=0;
k=true;
but1=false;
but2=false;
but3=false;
but4=false;
but7=false;
but8=true;          //////exit from mission
}
}

///////////////////////////first onlineoptions
if (online)
{
if (GUI.Button(Rect(Screen.width/mx,Screen.height/m1y,150,25),"Рейтинг", SFontStyle))
{

}
if (GUI.Button(Rect(Screen.width/mx,Screen.height/m2y,150,25),"Пользовательская", SFontStyle))
{}
if (GUI.Button(Rect(Screen.width/mx,Screen.height/m3y,150,25),"Назад", SFontStyle))
{
fade=0;
k=true;
but1=false;
but2=false;
but3=false;
but7=true;
but8=false;
//but8=true;          //////exit from online
}
}
///////////////////////////first options
if (options)
{
if (GUI.Button(Rect(Screen.width/mx,Screen.height/m1y,150,25),"Видео", SFontStyle))
{

}
if (GUI.Button(Rect(Screen.width/mx,Screen.height/m2y,150,25),"Аудио", SFontStyle))
{}
if (GUI.Button(Rect(Screen.width/mx,Screen.height/m3y,150,25),"Назад", SFontStyle))
{
fade=0;
k=true;
but1=false;
but2=false;
but3=false;
but7=true;
but8=false;
//but8=true;          //////exit from online
}
}

if (b){
GUI.Label(Rect(Screen.width/mx+x,Screen.height/my+y,150,50),strmes, BigFontStyle);
}
//GUI.DrawTexture(Rect(20,0,Screen.width,Screen.height), git02, ScaleMode.StretchToFill, true, 0.0f);
//GUI.DrawTexture(Rect(Screen.width/cx,cy,Screen.width/cx1,Screen.height/cy1), pictureset, ScaleMode.StretchToFill, true, 0.0f);
//GUI.DrawTexture(Rect(Screen.width/cx,cy,Screen.width/cx1,Screen.height/cy1), pictureset1, ScaleMode.StretchToFill, true, 0.0f);
//GUI.DrawTexture(Rect(Screen.width/cx,cy,Screen.width/cx1,Screen.height/cy1), camerabox, ScaleMode.StretchToFill, true, 0.0f);
//GUI.DrawTexture(Rect(Screen.width/lx,ly,Screen.width/lx1,Screen.height/ly1), logo, ScaleMode.StretchToFill, true, 0.0f);
//if (b){
//GUI.DrawTexture(Rect(x,y,Screen.width/2,Screen.height), git1, ScaleMode.StretchToFill, true, 0.0f);
//GUI.DrawTexture(Rect(x,y,Screen.width/2,Screen.height), git2, ScaleMode.StretchToFill, true, 0.0f);
//GUI.DrawTexture(Rect(x,y,Screen.width/2,Screen.height), git3, ScaleMode.StretchToFill, true, 0.0f);
//GUI.DrawTexture(Rect(x,y,Screen.width/2,Screen.height), git4, ScaleMode.StretchToFill, true, 0.0f);
//}
if (fade >= 0 || fade <=1.5)
    {
        GUI.color = Color.white;
        GUI.color.a = fade;
        GUI.DrawTexture(Rect(0, 0, Screen.width, Screen.height), life);
		//GUI.skin.font=FT;
        GUI.color = Color.white;
    }
}

//function FASTMOVE_0()
//{
//k=false;
//k1=true;
//for (gity=0;gity<Screen.height;gity+=50)yield;
//}
//
//function FASTMOVE_1()
//{
//for (gity1=-500;gity1<0;gity1+=50)yield;
//}

//function FASTMOVE_2()
//{
//for (git03x=0;git03x>-1000;git03x-=150)yield;
//}

function CHANGEMENU()
{
if (but1 || but8) {strmes="Новая игра";}
if (but2) {strmes="Онлайн";}
if (but3) {strmes="Настройки";}
if (but4) {strmes="Выбор миссии";}
if (but7) {strmes="Главное меню";}
}

function CICLE()
{
if (tb){
for(gx=-3200;gx<Screen.width;gx+=20*Time.deltaTime) 
{
yield;
if (gx>=-100) {gx=-3200;t=true;tb=false;}
}
}
}

function SHOWLINES()
{
if(!b){
yield WaitForSeconds(5);
b=true;
}
if (b){
yield WaitForSeconds(time);
b=false;
l=true;
}
}