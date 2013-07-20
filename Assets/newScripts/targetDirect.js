var xSpeed:float=0.0;


function Update () {
  
  var factor = 0.1f; // change this depending on interval to move camera 
  if(Input.GetKey(KeyCode.LeftArrow)) transform.position.x -= xSpeed * factor;
  else if(Input.GetKey(KeyCode.RightArrow)) transform.position.x += xSpeed * factor;
  if(Input.GetKey(KeyCode.UpArrow)) transform.position.z += xSpeed * factor;
  else if(Input.GetKey(KeyCode.DownArrow)) transform.position.z -= xSpeed * factor;

}