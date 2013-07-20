#pragma strict

var rectX:float = 0.0; 
var rectY:float =0.0; 
var clicked:boolean=false;
var recti:float=0;
var rectj:float=0;
var cash:int=0;
var fromlevel:int=0;
var tolevel:int=0;
var CurrentBuild:GameObject[];
var gold:int=0;
var gold_sum:int=0;
var g_sum:String;
var has_killed:boolean=false;
private var can_buy:boolean=true;
var time_show:int=0;
var select:boolean=false;
private var CamInterface:GameObject;
var purchased:boolean=false;
var accept:boolean=true;
var denied:boolean=false;

function Start () {
CamInterface=GameObject.Find("Main Camera");
}

function Update () {
var scrgi:MainWaves=CamInterface.GetComponent("MainWaves");
scrgi.currGold=g_sum;
if (has_killed){
gold_sum=gold_sum+gold;
has_killed=false;
}
g_sum=gold_sum.ToString();
}

function OnGUI(){
//GUI.Label(Rect(300,50,100,20),"$ "+g_sum);
if (!can_buy) {
time_show+=1;
if (time_show>250) { time_show=250; }
if (time_show==40) denied=false;
if (time_show<249)
GUI.Label(Rect(400,50,200,20),"Недостаточно средств");
}
//CamMain=GameObject.Find("Main Camera");
//var scrGI:GameInterface=CamMain.GetComponent("GameInterface");
//clicked=scrGI.clicked;
if (!clicked){
recti-=5;
rectj-=7;
if (recti<=1){tolevel=fromlevel-1;recti=0;}
if (rectj<=1){rectj=0;}
if (recti>1 && rectj>1){
GUI.BeginGroup(new Rect (rectX,rectY, 150, 90));
       GUI.Box(Rect (0,0, recti, rectj), "Апгрейд");
    GUI.EndGroup();
}

}

if (clicked) {
recti+=5;
rectj+=5.5;
if (recti>=89){tolevel=fromlevel+1;recti=90;}
if (rectj>=149){rectj=150;}
GUI.BeginGroup(new Rect (rectX,rectY, 150, 90));
       GUI.Box(Rect (0,0, recti, rectj), "Апгрейд");
 
       GUI.BeginGroup(new Rect(5,25, 144, 87));
         GUI.Label(Rect(0,0, 150, 40), "Ур."+fromlevel+" ---> Ур."+tolevel);
       GUI.EndGroup();
       
       GUI.BeginGroup(new Rect(5,45, 144, 87));
         GUI.Label(Rect(0,0, 150, 40), "Стоим. "+cash+"$");
       GUI.EndGroup();
       
       GUI.BeginGroup(new Rect(5,65, 145, 20));
         //if (GUI.Button(Rect(0,0, 80, 20), "Купить"))
         if (select)
         {
        if (cash>gold_sum){
        time_show=0;
        clicked=false;
		can_buy=false;
		}
		if (cash<gold_sum){
		gold_sum=gold_sum-cash;
		can_buy=true;
		}
		if (can_buy){
         var curScr:LookAtCarBot=CurrentBuild[0].GetComponent("LookAtCarBot");
         curScr.fromlevel=tolevel;
         clicked=false;
         //curScr.fromlevel=tolevel;
         }
         select=false;
         }
       GUI.EndGroup();
    GUI.EndGroup();
    
}
if (purchased){
if (cash>gold_sum){
        time_show=0;
        clicked=false;
		can_buy=false;
		denied=true;
		accept=false;
		}
if (cash<gold_sum){
		denied=false;
		gold_sum=gold_sum-cash;
		can_buy=true;
		}
if (can_buy){
         accept=true;
         accept=false;
         }
purchased=false;
}
}