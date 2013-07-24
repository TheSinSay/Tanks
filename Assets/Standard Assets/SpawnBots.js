#pragma strict
var BotPrefabMain:Transform;
var BotPrefab1:Transform;
var BotPrefab2:Transform;
var BotPrefab3:Transform;
var MainBuild:GameObject;
var numbot:int=0;
var numstr:String;
var CreatedObjects:GameObject[];
var hand:Transform[];
var i:int=0;
var QuantObjects:int=0;
var allow:boolean=true;
var t:GameObject;
var c:Component;
var ti:int=0;
var currentWave:int=0;
var randBot:int=0;

//Группа объектов
function Generate () {
QuantObjects=Random.Range(1,4);
hand=new Transform[QuantObjects];
CreatedObjects = new GameObject[QuantObjects];
for (i=0;i<QuantObjects;i++){                                      
hand[i]=Instantiate(BotPrefabMain,transform.position,transform.rotation);
numbot=Random.Range(10,2567);
numstr=numbot.ToString();
hand[i].gameObject.name=hand[i].gameObject.name+numstr;
for (var childbody:Transform in hand[i].transform)
if (childbody.name=="Body") {
var LfBots:Life=childbody.GetComponent("Life");
LfBots.life=80*currentWave;
LfBots.percent=80*currentWave;
LfBots.gold=12*currentWave;
}
CreatedObjects[i]=hand[i].gameObject;
yield WaitForSeconds(3);
}
}

function Update () {
if (allow){
randBot=Random.Range(0,3);
if (randBot==0) BotPrefabMain=BotPrefab1;
if (randBot==1) BotPrefabMain=BotPrefab2;
if (randBot==2) BotPrefabMain=BotPrefab3;
if (randBot==3) BotPrefabMain=BotPrefab1;
Generate ();
allow=false;
}
//if (QuantObjects==0){
//hand=new Transform[0];
//CreatedObjects=new CreatedObjects[0];
//}
//CreatedObjects = new GameObject[go+1];
//CreatedObjects[go]=GameObject.FindGameObjectWithTag("Enemy");
////
}