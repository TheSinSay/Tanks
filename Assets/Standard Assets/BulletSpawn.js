#pragma strict

var TagEnemy:String;
var explosion:GameObject;
var explosion1:GameObject;
var fakebul:boolean=false;
var RockLaunch:boolean=false;
var Bot:boolean=false;
var MainCamera:GameObject;
var cWave:int=0;
var powerstart:int=0;
var powerend:int=0;


function Start () {
if (!fakebul && !RockLaunch && Bot){
MainCamera=GameObject.Find("Main Camera");
var curWave:MainWaves=MainCamera.GetComponent("MainWaves");
cWave=curWave.genWaves;
yield WaitForSeconds(0.5);       /// 1 секунда и пуля удаляется
Instantiate(explosion1,transform.position,transform.rotation);
Destroy(gameObject);
}
//if (!RockLaunch && Bot)	{
//
//}
if (fakebul){					/// 1 секунда и пуля удаляется
yield WaitForSeconds(0.5);
Destroy(gameObject);
}
if (RockLaunch && !fakebul){	/// 1 секунда и ракета удаляется
yield WaitForSeconds(5);
Instantiate(explosion1,transform.position,transform.rotation);
Destroy(gameObject);
}
}

function Update () {
if (!RockLaunch)           ////Если пуля не ракета,то пуля летит вперед постоянно
transform.Translate(1,0,0);
}

function OnTriggerEnter (other : Collider) {
if (other.CompareTag (TagEnemy) || other.CompareTag ("Detected")) {
if (!fakebul){                                       //////Если пуля не фейк
var Lifescript:Life=other.gameObject.GetComponent("Life");
Lifescript.enabled=true;
Lifescript.shooting=true;
Lifescript.time_shoot=0;
if (RockLaunch) {                                     ////Если галочка стоит что пуля от ракетницы
Lifescript.life=Lifescript.life-Random.Range(powerstart,powerend);
Lifescript.shooting=true;
Lifescript.time_shoot=0;
}
if (!RockLaunch){                                    ////Если галочка стоит что пуля не от ракетницы
Lifescript.life=Lifescript.life-Random.Range(powerstart,powerend);
Lifescript.shooting=true;
Lifescript.time_shoot=0;
//Destroy(gameObject);
}
if (!RockLaunch && Bot)	{					////Если галочка стоит что пуля не от ракетницы и стреляет бот
Lifescript.life=Lifescript.life-Random.Range(20*cWave,40*cWave);
Lifescript.shooting=true;
Lifescript.time_shoot=0;
} //Сила бота в зависимости от номера волны
////////////////////////////////////////////////////////Главное тело создания взрыва при коллизии
Instantiate(explosion,transform.position,transform.rotation);
//transform.tag="Killed";
Destroy(gameObject);
}
if (fakebul){
Destroy(gameObject);
}
}
}