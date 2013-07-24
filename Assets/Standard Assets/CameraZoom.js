var zoom : int = 20;
var normal : int = 60;
var smooth : float = 5;
var target:Transform;
private var isZoomed = false;
var mainCameraZValue:float=0.0f;
var originPosition:Vector3;
var originRotation:Quaternion;
var shake:boolean=false;
//var glob:boolean=false;
 
var shake_decay: float;
var shake_intensity: float;
var xSpeed:float=0.0;
var spell:boolean=false;

var UpgradedWindow:GameObject;

function Start()
{
UpgradedWindow=GameObject.Find("UpgradeWindow");
}
//////

function Update () {
var scrUpg:UpgradesBuilds=UpgradedWindow.GetComponent("UpgradesBuilds");
     if(Input.GetAxis("Mouse ScrollWheel") > 0.0){
     
	//scrUpg.clicked=false;
          isZoomed = true; 
     }
     
     if(Input.GetAxis("Mouse ScrollWheel") < 0.0){
  
	//scrUpg.clicked=false;
          isZoomed = false; 
     }
 
     if(isZoomed == true){
          camera.fieldOfView = Mathf.Lerp(camera.fieldOfView,zoom,Time.deltaTime*smooth);
     }
     else{
        camera.fieldOfView = Mathf.Lerp(camera.fieldOfView,normal,Time.deltaTime*smooth);
     }
     if (shake){
     Shake();
     shake=false;
     }
if(shake_intensity > 0){
        transform.position = originPosition + Random.insideUnitSphere * shake_intensity;
        transform.rotation =  Quaternion(
                        originRotation.x + Random.Range(-shake_intensity,shake_intensity)*.2,
                        originRotation.y + Random.Range(-shake_intensity,shake_intensity)*.2,
                        originRotation.z + Random.Range(-shake_intensity,shake_intensity)*.2,
                        originRotation.w + Random.Range(-shake_intensity,shake_intensity)*.2);
        shake_intensity -= shake_decay;
    }
  
  var factor = 0.1f; // change this depending on interval to move camera 
  if(Input.GetKey(KeyCode.LeftArrow)) {
	
	scrUpg.clicked=false;
  transform.position.x -= xSpeed * factor;
  if (transform.position.x<-15) transform.position.x=-15;
  }
  else if(Input.GetKey(KeyCode.RightArrow)) {
  
	scrUpg.clicked=false;
  transform.position.x += xSpeed * factor;
  if (transform.position.x>15) transform.position.x=15;
  }
  if(Input.GetKey(KeyCode.UpArrow)) {
 
	scrUpg.clicked=false;
  transform.position.z += xSpeed * factor;
  if (transform.position.z>10) transform.position.z=10;
  }
  else if(Input.GetKey(KeyCode.DownArrow)) {

	scrUpg.clicked=false;
  transform.position.z -= xSpeed * factor;
  if (transform.position.z<-16) transform.position.z=-16;
  }

}
 
function Shake(){
    originPosition = transform.position;
    originRotation = transform.rotation;
    if (spell){
    shake_intensity = .3;//.1
    shake_decay = 0.009;//0.009
    } 
    if (!spell){
    shake_intensity = 0;//.1
    shake_decay = 0;//0.009
    }
}