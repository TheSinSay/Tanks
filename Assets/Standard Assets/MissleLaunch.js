#pragma strict

var Missle:Transform;
var timeRockets:int=0;
var RandR:float=0.0;
var genStart:float=3;
var genEnd:float=6;
var powerstart:int=0;
var powerend:int=0;
var Rocket:Transform;

function Start () {

}

function Update () {
timeRockets+=1;
if (timeRockets==100){
RandR=Random.Range(genStart,genEnd);
InstRock();
timeRockets=0;
}
}

function InstRock()
{
yield WaitForSeconds(RandR);
Rocket=Instantiate(Missle,transform.position,transform.rotation);
var setRocPow:BulletSpawn=Rocket.GetComponent("BulletSpawn");
setRocPow.powerstart=powerstart;
setRocPow.powerend=powerend;
}