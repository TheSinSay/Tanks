var life:float=100;
var percent:float=100;
var bs:boolean=true;
var CameraMain:GameObject;
private var UpgradeWindow:GameObject;
//var MainCamera:GameObject;
var isNavMesh:boolean=false;
var is_Air:boolean=false;
var Bot:boolean=false;
var Build:boolean=false;
var AnimApache:GameObject;
var Explo:GameObject;
var GoldPref:GameObject;
var GPref:GameObject;
var gold:int=0;
var maxLife:int=7000;


var xOffset: float;

var yOffset: float;
var x:float = 0.0; 
var y:float =0.0; 
var clockBG : Texture2D;
var clockFG : Texture2D;
var clockFGMaxWidth : float; //the starting width of the foreground bar
var currentHealth:float;
var zagl:boolean=true;//заглушка
var zaglplayer:boolean=false;//заглушка
var shooting:boolean=false;
var isGlobalExp:boolean=false;
var time_shoot:int=0;

function Start(){
//yield WaitForSeconds(4);
CameraMain=GameObject.Find("Main Camera");
clockFGMaxWidth = 60;
//currentHealth = 100;
}

function Update(){
if (!is_Air && !Bot && Build) //////Если тег здания игрока родителя Active,то трансформ тег=Player
if (zaglplayer) if (transform.parent.tag=="Active") {transform.tag="Player";zaglplayer=false;}
if (life<=0){
if (is_Air) {               ////////////Если жизнь вертолета
Instantiate(Explo,transform.position,transform.rotation);
transform.parent.GetComponent("AIfind").enabled=false;
AnimApache.animation.Play("ApacheDownfall");
is_Air=false;
}

if (!is_Air && Bot && !Build){ ////////////Если жизнь бота
 if (zagl){
 UpgradeWindow=GameObject.Find("UpgradeWindow");	//Поиск UpgradesBuilds в инспекторе
 var sendGold:UpgradesBuilds=UpgradeWindow.GetComponent("UpgradesBuilds");
 sendGold.gold=gold;			///Передается значение gold в UpgradesBuilds
 sendGold.has_killed=true;   ///Если бот убит передается переменная в скрипт UpgradesBuilds
 Instantiate(Explo,transform.position,transform.rotation);
 GPref=Instantiate(GoldPref,transform.position+Vector3(0,2,0),Quaternion.identity);
 var goldStr:String=gold.ToString();
 for (var textGold:Transform in GPref.transform){
 if (textGold.name=="Gold"){                     //Дочерний объект с именем Gold
 textGold.GetComponent(TextMesh).text="+"+goldStr; ///прием значения голда в 2раза больше goldStr
 break;
 }
 }
  zagl=false; 
  }
  if (isGlobalExp){
for(var planeScale in transform)
if (planeScale.gameObject.name=="plane") planeScale.transform.localScale+= Vector3(0.3,0.3,0.3);
}
  }
  
if (!is_Air && !Bot && Build) ////////////Если жизнь равна 0 здания\вышки,то взрыв
if (zagl){
 Instantiate(Explo,transform.position,transform.rotation);
  zagl=false;
  }
  
transform.tag="Killed";
if (bs){
Shake();
bs=false;
}

for (var child : Transform in transform.parent) {
//child.rigidbody.isKinematic = false;
if (isNavMesh){
transform.parent.GetComponent("NavMeshAgent").enabled=false;
if (child.gameObject.name=="Turret"){
child.GetComponent("LookAtPlayer").enabled=false;
}
}
transform.parent.GetComponent("Delete").enabled=true;
child.GetComponent("Delete").enabled=true;
}
}

 var screenPos:Vector3 = CameraMain.camera.WorldToScreenPoint (transform.position);
 x=screenPos.x - xOffset; // x offset
 y=Screen.height - screenPos.y - yOffset; // y offset
   // print ("x=" + x + "; y=" + y);

}

function OnGUI()
{

//if (is_Air){
if (life>0){
if (shooting){
var newBarWidth:float = (life/percent) * clockFGMaxWidth;
 
    //Debug.Log("current health " + currentHealth);
 
    //a spacing variable to help us position the clock
    var gap:int = 100;
 
    GUI.BeginGroup(new Rect (x,y, 100, 100));
       GUI.Label(Rect (0,0, 60, 90), clockBG);
 
       GUI.BeginGroup(new Rect(1,2, newBarWidth, 42));
         GUI.Label(Rect(0,0, 56, 90), clockFG);
       GUI.EndGroup();
    GUI.EndGroup();
time_shoot+=1;
if (time_shoot>=100) {shooting=false;time_shoot=0;}
    }
 }
  //  }
}

function Shake(){
isGlobal=true;
var shakescript:CameraZoom=CameraMain.GetComponent("CameraZoom");
if (isGlobalExp){
shakescript.spell=true;
}
shakescript.shake=true;
yield WaitForSeconds(1);
shakescript.shake=false;
var scr:MainWaves=CameraMain.GetComponent("MainWaves");
scr.b=true;
scr.lastFromTurret=true;
}