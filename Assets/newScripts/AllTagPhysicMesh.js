#pragma strict

private var i:int=0;
var addcollision:boolean=false;

function Start () {
//gameObject.AddComponent("MeshCollider");
var kids = GetComponentsInChildren( MeshRenderer, true );
for ( var child : Component in kids ) {
if (addcollision)
  child.gameObject.AddComponent("BoxCollider");
  child.gameObject.AddComponent("Rigidbody");
}
}

function Update () {
}