#pragma strict
var rand:int=0;
var is_noObj:boolean=false;

function Start () {
if (is_noObj) {
yield WaitForSeconds(rand);
Destroy(gameObject);
} else
Destroy(gameObject);
}

function Update () {

}