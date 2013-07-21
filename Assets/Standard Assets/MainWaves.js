public var genWaves:int=0;
var showmessage:boolean=false;
var Spawns:GameObject[];
var SpawnLastBot:Transform;
var lastbot:Transform;
var lastwave:boolean=false;
var wv:boolean=true;
var strmessage:String="WAVE: ";
var currWave:String="";
var currGold:String="";
var currTime:String="";
var Count:int=0;
var Count1:int=0;
var ToWaves:int=0;
var SparksBullets : GameObject[];
//var gos1 : GameObject[];
var c:boolean=false;
var Zaglushka:boolean=false;
var lastFromTurret:boolean=false;
var lastFromMines:boolean=false;
var font : Font;
var style : GUIStyle;
var x1:float=0;	var xx1:float=0;//var xxx1:float=0;
var x2:float=0;	//var xx2:float=0;//var xxx2:float=0;
var y1:float=0;	var yy1:float=0;//var yyy1:float=0;
var y2:float=0;	//var yy2:float=0;//var yyy2:float=0;
var x3:float=0;	var xx3:float=0;//var xxx3:float=0;
private var startTime = 0;			//Глобальное время
var WaveTime : float = 0.0f;		//Время постройки в секундах
var cash:int=0;
var purchased:boolean = false;
var canBuy:boolean = false;
var accept:boolean = true;
var denied:boolean = false;
var zaglushkaGI:boolean=false;
var UpgWindow:GameObject;
var LifeUp:boolean=false;
private var millitaries:GameObject[];
var notEnough:boolean=false;
//var goTime:boolean=false;
//var st:boolean=true;
//var tex:Texture2D;
    
function Start(){
startTime =  Time.timeSinceLevelLoad;
UpgWindow=GameObject.Find("UpgradeWindow");
}

function ChangeWaves () {
showmessage=true;wv=true;
var SF : SmoothFollow = gameObject.GetComponent("SmoothFollow");
SF.enabled=true;
}

function Update () {
	
}

function ConvertTimeToString()			//Конвертация времени
{
    
    var minutes:int = Mathf.FloorToInt((WaveTime % 3600) / 60);
    var seconds:int = Mathf.FloorToInt(WaveTime) % 60;
    //var ms:int=Time.time*100;
    //if (ms>99) ms=0;
    var ms:int = Mathf.FloorToInt((WaveTime * 100) %99);
    return (minutes.ToString("00") + ":" + seconds.ToString("00") + ":" + ms.ToString("00"));
}

function OnGUI()
{
millitaries=GameObject.FindGameObjectsWithTag("Player"); 
var scrUpgWin:UpgradesBuilds=UpgWindow.GetComponent("UpgradesBuilds");
WaveTime = Time.timeSinceLevelLoad + startTime;
currTime=ConvertTimeToString().ToString();
currWave=genWaves.ToString();
notEnough=scrUpgWin.notEnough;                            //проверка на достаточность средств и передача сообщения в GameInterface
LifeUp=transform.GetComponent("GameInterface").LifeUp;    //Спелл для максимального увеличения жизни пушек
transform.GetComponent("GameInterface").currWave=currWave;
transform.GetComponent("GameInterface").currGold=currGold;
transform.GetComponent("GameInterface").currTime=currTime;
transform.GetComponent("GameInterface").notEnough=notEnough;
if (!zaglushkaGI){
cash=transform.GetComponent("GameInterface").cash;
purchased=transform.GetComponent("GameInterface").purchased;
}
if (purchased){
scrUpgWin.cash=cash;
scrUpgWin.accept=true;
scrUpgWin.purchased=purchased;
zaglushkaGI=true;
//print("Заглушка сработала");
purchased=false;
}
accept=scrUpgWin.accept;
denied=scrUpgWin.denied;
//transform.GetComponent("GameInterface").purchased=purchased;
if (accept){
transform.GetComponent("GameInterface").accept=true;
transform.GetComponent("GameInterface").denied=false;
//transform.GetComponent("GameInterface").recept=true;
transform.GetComponent("GameInterface").purchased=false;
zaglushkaGI=false;
//transform.GetComponent("GameInterface").accept=false;
//print("Вторая сработала");
accept=false;
}
if (denied){
transform.GetComponent("GameInterface").accept=false;
transform.GetComponent("GameInterface").denied=true;
//transform.GetComponent("GameInterface").recept=true;
transform.GetComponent("GameInterface").purchased=false;
zaglushkaGI=false;
//print("Третья сработала");
//denied=false;
}
if (!denied) transform.GetComponent("GameInterface").denied=false;
//scrUpgWin.cash=cash;
//GUIText.font = font;
if (!lastwave){
if (Count==0 && Zaglushka){
	genWaves+=1;
 ChangeWaves ();  
 SparksBullets=GameObject.FindGameObjectsWithTag ("Killed");
 for (var sparks in SparksBullets)
 Destroy(sparks);
 Zaglushka=false;
 }
var EnemySimple = new Array (GameObject.FindGameObjectsWithTag ("Enemy") );
	var EnemyDetected = new Array (GameObject.FindGameObjectsWithTag ("Detected") );
	var taggedGameObjects = EnemySimple.Concat(EnemyDetected).ToBuiltin(GameObject);
	Count=taggedGameObjects.length;
if (showmessage){
goTime=false;
style.font = font;
x3=x3+0.1;
x1=x3;
if (x3>=30) {x3=30;
xx3=xx3+0.05;
xx1=xx3;
if (xx3>=30) xx3=30;
}
//GUI.DrawTexture(Rect(Screen.width/xx1,Screen.width/yy1,Screen.width/xx2,Screen.width/yy2), tex, ScaleMode.ScaleToFit, true, 10.0f);
GUI.Label(Rect(Screen.width/x1,Screen.width/y1,Screen.width/x2,Screen.width/y2),strmessage+genWaves+" из " + ToWaves,style);
GUI.Label(Rect(Screen.width/xx1,Screen.width/yy1,Screen.width/x2,Screen.width/y2)," Броневые танки",style);
if (wv){
audio.Play();
GO();
wv=false;
}
}
}
if (LifeUp){
for (var millitary:GameObject in millitaries) 
{
var compLife:Life=millitary.GetComponent("Life");
compLife.life=compLife.maxLife;
compLife.percent=compLife.maxLife;
compLife.shooting=true;
}
transform.GetComponent("GameInterface").LifeUp=false;
}
}

function GO()
{
if (genWaves==ToWaves) {strmessage="Последняя волна: ";
yield WaitForSeconds(10);
lastwave=true;
}
if (!lastwave){
yield WaitForSeconds(1);
var camZoom:CameraZoom=transform.GetComponent("CameraZoom");
camZoom.spell=false;
var SF : SmoothFollow = gameObject.GetComponent("SmoothFollow");
SF.enabled=false;

yield WaitForSeconds(9);
for (var i=0;i<Spawns.Length;i++){
//Spawns[i].active=true;
var ot:SpawnBots=Spawns[i].GetComponent("SpawnBots");
ot.allow=true;
ot.currentWave=genWaves;
showmessage=false;

}
yield WaitForSeconds(10);
Zaglushka=true;
x3=0;
xx3=0;
xx1=0;
}

if (lastwave){
//SpawnLastBot.position=Vector3(Random.Range(-170,170),0,Random.Range(-100,170));
//yield WaitForSeconds(5);
//SF.enabled=false;
Instantiate(lastbot,SpawnLastBot.position,SpawnLastBot.rotation);
yield WaitForSeconds(10);
showmessage=false;
Zaglushka=true;
}
}