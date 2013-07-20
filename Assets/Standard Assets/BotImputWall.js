#pragma strict

var wallStrength:int=20;
var AfterWallSpeed:float=0.5;
var prefWall:Transform;
//var navAgent:NavMeshAgent;

function Start () {
}

function Update () {

}

function OnTriggerEnter (buildingSet : Collider) {
if (buildingSet.CompareTag ("Enemy") || buildingSet.CompareTag ("Killed")) {
var compLife:Life=buildingSet.GetComponent("Life");
compLife.life=compLife.life-wallStrength;
compLife.shooting=true;
var Ag:NavMeshAgent=buildingSet.transform.parent.GetComponent("NavMeshAgent");
Ag.speed=AfterWallSpeed;
Instantiate(prefWall,transform.position,Quaternion.identity);
Destroy(gameObject);
}
}