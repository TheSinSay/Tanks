#pragma strict

var Electric:boolean=false; //если цель поражена током
var timeWantedSpeed:int=20;
var ElPowLvl:float=1;
var BasicSpeed:float=2;
var timeSpeed:int;

function Start () {

}

function Update () {
if (Electric){
	var Ag:NavMeshAgent=transform.GetComponent("NavMeshAgent");
	Ag.speed=ElPowLvl;
		timeSpeed+=1;
		if (timeSpeed>=timeWantedSpeed){
				Ag.speed=BasicSpeed;
				timeSpeed=0;
				Electric=false;
			}
		}
}