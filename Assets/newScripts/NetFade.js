private var myRenderer : Renderer;
var fade:boolean=false;
var ftime:float=0.0f;
 
function Start () {
    myRenderer = renderer;
    ftime=Random.Range(0.5,0.9);
myRenderer.material.color.a=ftime;
}
 
function Update () {
if (!fade){
        myRenderer.material.color.a -=ftime*Time.deltaTime; //Fade out over 1 second
        if (myRenderer.material.color.a<=0) {
        fade=true;
        }
        }
        
if (fade){
        myRenderer.material.color.a +=ftime*Time.deltaTime; //Fade out over 1 second
        if (myRenderer.material.color.a>=1) {
        fade=false;
        }
        }
}