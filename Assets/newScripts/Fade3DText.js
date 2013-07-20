#pragma strict

function Start () {
//Fade.use.Alpha(GetComponent(TextMesh).renderer.material, 0.0, 1.0, 1.0);
//yield WaitForSeconds(0.4);
var colors = [Color.yellow, Color.yellow];
Fade.use.Alpha(GetComponent(TextMesh).renderer.material, 1.0, 0.0, 1.3);
Fade.use.Colors(GetComponent(TextMesh).renderer.material, colors, 0.0, false);
yield WaitForSeconds(2);
Destroy(transform.parent.gameObject);
//
//transform.parent.tag="Killed";
}

function Update () {

}