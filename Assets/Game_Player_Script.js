public var play:boolean = true; 
public var speed: int = 10; 
public var moveDirection: Vector3; 
public var grounded: boolean = true;
public var gravity: int = 1; 

function Update () { 
  if(play){ 
  if(Input.GetKey(KeyCode.Escape)){ 
  Application.Quit(); 
  } 
   
  if(grounded){ 
  moveDirection = transform.TransformDirection(Vector3.forward); 
  moveDirection *= speed; 
  } 
  moveDirection.y -= gravity * Time.deltaTime; 
  if(Input.GetMouseButton(1)){ 
  var dx: int = Input.mousePosition.x - Screen.width / 2.0; 
  var dy: int = Input.mousePosition.y - Screen.height / 2.0; 
  var strawRadians: float = Mathf.Atan2(dx,dy); 
  var strawDigrees:float = 360.0 * strawRadians/(2.0*Mathf.PI); 
  transform.rotation.eulerAngles.y = strawDigrees; 
  var controller : CharacterController = GetComponent(CharacterController); 
  var flags = controller.Move(moveDirection * Time.deltaTime); 
  grounded = (flags & CollisionFlags.CollidedBelow) != 0; 
  } 
  } 
}