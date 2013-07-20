
//var destroyTime:float=5;
private var startTime = 0;
private var TimeGen : float = 0.0f;
var timeSum:float = 0;
//var tgen:boolean=false;
var secAvailable:int=3;

function Start () {
//Destroy (gameObject, destroyTime);
startTime = Time.time;
}

function ConvertTime()			//Конвертация времени для золота
{
    var seconds:int = Mathf.FloorToInt(TimeGen) % secAvailable;
    return (seconds);
}

function Update () {
TimeGen = Time.time + startTime;
timeSum=ConvertTime();
if (timeSum==secAvailable-1) gameObject.active=false;
}