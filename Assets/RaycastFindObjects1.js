#pragma strict

var target:Transform;
var gos : GameObject[];
var closest : GameObject; 
private var curDistance:float=0.0;
var tgtext:Texture2D;
var tgx:float=0.0;
var tgy:float=0.0;
var tgx1:float=0.0;
var tgy1:float=0.0;
var back:boolean=false;
var act:boolean=true;

//function FindClosestEnemy () : GameObject {
//    // Find all game objects with tag Enemy
//    
//    gos = GameObject.FindGameObjectsWithTag("Enemy"); 
//    var distance = Mathf.Infinity;
//    var position = transform.position; 
//    // Iterate through them and find the closest one
//    for (var go : GameObject in gos)  { 
//        var diff = (go.transform.position - position);
//        curDistance = diff.sqrMagnitude; 
//        if (curDistance < 60000) { 
//        var forward = transform.TransformDirection(Vector3.forward);
//        var toOther = go.transform.position - transform.position;
//        var toObj0 = gos[0].transform.position - transform.position;
//        if ((Vector3.Dot(forward,toOther) > 0)&&(Vector3.Dot(forward,toOther) < 500)){
//        closest = go;
//            distance = curDistance;} else
//            if (Vector3.Dot(forward,toOther) < 0) {
//        for (var i:int=0; i<gos.Length;i++) i=i;
//        i=i-1;
//        go=gos[i];
//	if (Vector3.Dot(forward,toObj0) < 0) {closest=null; target=null;}
//            }
//        } 
//    } 
//    //print(Vector3.Dot(forward,toOther));
//    return closest;   
//}

function Start()
{
}

//function OnDrawGizmosSelected (){
//Gizmos.color = Color.red;
//    var direction : Vector3 = transform.TransformDirection (Vector3.forward)*10;
//    Gizmos.DrawRay (transform.position, direction);
//}

function Update()
{
var direction : Vector3 = transform.TransformDirection (Vector3.forward)*30;
	var ray : Ray = new Ray(transform.position, direction);
   	var hit : RaycastHit;
    if (Physics.Raycast (ray, hit, 10.0)) {
     act=false;
    } else act=true;
//target=FindClosestEnemy().transform; 
var screenPos : Vector3 = camera.WorldToScreenPoint (target.position);
//tgx=screenPos.x;
//tgy=Screen.height - screenPos.y-20;
Debug.DrawRay(transform.position,direction);
        print ("target is " + screenPos.x + " pixels from the left");
}

function OnGUI()
{
if (act)
GUI.Label(Rect(tgx,tgy,Screen.width/tgx1,Screen.height/tgy1),tgtext);
}