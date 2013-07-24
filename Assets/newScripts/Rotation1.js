var directionY:boolean=true;

function Update() {
// Slowly rotate the object around its X axis at 1 degree/second.
//transform.Rotate(Vector3.right * Time.deltaTime);

// ... at the same time as spinning relative to the global
// Y axis at the same speed.
if (directionY)
transform.Rotate(0, 0, 2000*Time.deltaTime); else
transform.Rotate(-100*Time.deltaTime,0 , 0);
}