#pragma strict

function Start () {

}

function Update () {

}

function OnTriggerEnter(bot : Collider){
if (bot.CompareTag("Enemy")){
var scrLifeBot:Life=bot.GetComponent("Life");
scrLifeBot.life=-1;
}
}