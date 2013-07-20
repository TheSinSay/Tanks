#pragma strict

var lat:int=0;
var latend:int=0;
var koef:int=0;
var koefdrag:float=0.0;
var drugon:boolean=true;
var activate:boolean=false;
var time:int=0;
var Speed:float;
var Turn:float;
var SizeRound:float=0;
var gos : GameObject[];
var closest : GameObject; 
private var curDistance:float=0.0;
var changeSpeed:boolean=false;
var tagEnemy:String="Enemy";
var Global:boolean=false;


function Start () {
//rigidbody.AddForce(transform.forward * 5000);
//yield WaitForSeconds(0.5);
if (!changeSpeed)
Speed=Random.Range(20,50);
}



function Update () {

if (closest==null) transform.Translate((Vector3.forward * 40*Time.deltaTime)+(Vector3.right * 1*Time.deltaTime));
if (!changeSpeed){
SizeRound+=0.1;
if (SizeRound<100) Turn=SizeRound; else if (SizeRound>=100) SizeRound=1;
time=time+1;
if (time>=30){time=30; Destroy(rigidbody);activate=true;}
}
if (activate){
if (Global)
tagEnemy="Global";
//var targets:GameObject[]=GameObject.FindGameObjectsWithTag("Enemy");
//var closest:GameObject;
//var closestDist=Mathf.Infinity;
//
//for (Target in targets) {
//var dist = (transform.position-Target.transform.position).sqrMagnitude;
//if (dist<closestDist){
//closestDist=dist;
//closest=Target;
//}
//}
    gos = GameObject.FindGameObjectsWithTag(tagEnemy); 
    var distance = Mathf.Infinity;
    var position = transform.position; 
    for (var go : GameObject in gos)  { 
        var diff = (go.transform.position - position);
        curDistance = diff.sqrMagnitude; 
        if (curDistance < distance) { 
        closest = go; 
        distance = curDistance; 
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
//	if (Vector3.Dot(forward,toObj0) < 0) {activate=false;}
//            }
        } 
    } 
transform.rotation=Quaternion.Slerp(transform.rotation,Quaternion.LookRotation(closest.transform.position-transform.position),Turn*Time.deltaTime);
transform.position+=transform.forward*Speed*Time.deltaTime;
}
if (!activate){
gameObject.AddComponent("Rigidbody");
lat=lat+koef;
rigidbody.drag +=koefdrag*Time.deltaTime ;
if (drugon)
if (rigidbody.drag>=30) {rigidbody.drag=0;rigidbody.mass=50;rigidbody.useGravity=false;drugon=false;}
if (lat>=latend) {lat=latend;}
rigidbody.AddForce(transform.forward * lat);
}
}