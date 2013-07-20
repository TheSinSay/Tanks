#pragma strict
var free:boolean=false;

function Start () {

}

function Update () {
if (free){
transform.parent.gameObject.tag="PlacementPlane_Open";
}
}