#pragma strict
private var startTime = 0;
private var TimeGen : float = 0.0f;
var timeSum:float = 0;
var tgen:boolean=false;
var secAvailable:int=3;
var AvailableGold:int=1;
var UpgWin:GameObject;

function Start () {
startTime = Time.time;
UpgWin=GameObject.Find("UpgradeWindow");
}

function ConvertTime()			//Конвертация времени для золота
{
    var seconds:int = Mathf.FloorToInt(TimeGen) % secAvailable;
    return (seconds);
}

function Update () {
TimeGen = Time.time + startTime;
timeSum=ConvertTime();
if (transform.tag=="Active"){
if (timeSum==secAvailable-1) {
var scriptUpgrades:UpgradesBuilds=UpgWin.GetComponent("UpgradesBuilds");
scriptUpgrades.gold_sum=scriptUpgrades.gold_sum+AvailableGold;
}
//if (timeSum==0) tgen=false;
}
}