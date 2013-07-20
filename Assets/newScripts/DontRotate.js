#pragma strict

var rotation:Quaternion;

function Awake () {
 rotation = transform.rotation;
}

function LateUpdate () {
 transform.rotation = rotation;
}