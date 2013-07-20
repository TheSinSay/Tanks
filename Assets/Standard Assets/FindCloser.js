#pragma strict
var target:Transform;
var nearestDistanceSqr:float=0.0;
var inPref:Transform;
startTime = Time.time;
private var TimeGen : float = 0.0f;
var timeSum:float = 0;
var sound:boolean=true;
//var tgen:boolean=false;
var secAvailable:int=2;
private var startTime = 0;

	var ElPowLvl:float=1; //сила замедления в зависимости от лвл эл вышки
	var Electric:boolean=false; //если цель поражена током
	var timeWantedSpeed:int=20; //на сколько медленней будет двигаться бот зависит от лвл эл вышки
	// чем выше лвл вышки тем больше это значение

function Start () {
startTime = Time.time;

}

function playAudio()
{
if (sound){
gameObject.audio.Play();
sound=false;
}
}

function ConvertTime()			//Конвертация времени для золота
{
    var seconds:int = Mathf.FloorToInt(TimeGen) % secAvailable;
    return (seconds);
}

function Update () {
ScanForTarget();
transform.LookAt(target);
}

function ScanForTarget() {
if (target==null){gameObject.audio.Stop();inPref.active=false;}
    // Если тэг объекта Active(присваивается из скрипта GameInterface),производится поиск
    //ближайшей цели 
    //if (transform.tag=="Active")
    target = GetNearestTaggedObject();
    if (target!=null) {
    TimeGen = Time.time + startTime;
	timeSum=ConvertTime();
	if (timeSum==secAvailable-1) {playAudio();}
	if (timeSum==0) {sound=true;}
    var playerScript1:FromElectric = target.parent.GetComponent("FromElectric");
        playerScript1.Electric=true;
		playerScript1.ElPowLvl=ElPowLvl;
		playerScript1.timeWantedSpeed=timeWantedSpeed;
    inPref.active=true;
	for (var targets:Transform in target.transform.parent)
	if (targets.gameObject.name=="lightningExplosionBase") targets.active=true;
	}
    
}

function GetNearestTaggedObject() : Transform {
    nearestDistanceSqr = 300.0;
    var EnemySimple = new Array (GameObject.FindGameObjectsWithTag ("Enemy") );
	var EnemyDetected = new Array (GameObject.FindGameObjectsWithTag ("Detected") );
	var taggedGameObjects = EnemySimple.Concat(EnemyDetected).ToBuiltin(GameObject);
    var nearestObj : Transform = null;
 
    for (var obj : GameObject in taggedGameObjects) {
 
        var objectPos = obj.transform.position;
        var distanceSqr = (objectPos - transform.position).sqrMagnitude;
 
        if (distanceSqr < nearestDistanceSqr) {
            nearestObj = obj.transform;
            nearestDistanceSqr = distanceSqr;
			
    }
        }
    return nearestObj;
}