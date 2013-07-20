var hand:GameObject;
var Explosion:GameObject;
var time_not_collided:float=0.0;
var CameraMain:GameObject;
var MainCamera:GameObject;


function Update()
{
//time_not_collided=time_not_collided+0.01*Time.deltaTime;
//if (time_not_collided>=0.1) GO();
}

function Start()
{
CameraMain=GameObject.Find("Main Camera");
MainCamera = GameObject.Find("Main Camera");
}

function OnTriggerEnter (other : Collider) {
if (other.CompareTag ("Enemy")) {
collider.enabled = false;
var shakescript:CameraZoom=CameraMain.GetComponent("CameraZoom");
shakescript.shake=true;
Instantiate(Explosion,transform.position,transform.rotation);
//print("Has collided"+other.transform.parent.gameObject.name);
hand=GameObject.Find(other.transform.parent.gameObject.name);
audio.Play();
//hand1=hand.transform.parent.gameObject;
for (var child : Transform in hand.transform) {
child.rigidbody.isKinematic = false;
child.GetComponent("Delete").enabled=true;
}
control=hand.GetComponent("NavMeshAgent");
control.enabled=false; 
control=hand.GetComponent("Delete");
control.enabled=true; 
//GetComponent("Detonator").enabled=true;
var freecell:FreeCell=transform.parent.gameObject.GetComponent("FreeCell");
freecell.free=true;
yield WaitForSeconds(1);
shakescript.shake=false;
var scr:MainWaves=MainCamera.GetComponent("MainWaves");
scr.b=true;
scr.lastFromMines=true;
Destroy(hand);
//yield WaitForSeconds(1);
Destroy(transform.parent.gameObject);
//GO();
//
}
}

function GO()
{
yield WaitForSeconds(1);

}