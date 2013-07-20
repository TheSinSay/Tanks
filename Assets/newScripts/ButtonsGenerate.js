#pragma strict

function Start () {

}

function OnGUI () {
for (var i:int=0;i<10;i++) {if (GUI.Button(Rect(0+i*80,20,70,30),"кнопка"+i)){}
}
}