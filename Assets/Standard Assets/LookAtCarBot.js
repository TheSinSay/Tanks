var Bullet:GameObject;
var Bullet1:GameObject;
var Bul:GameObject;
var Bul1:GameObject;
var bulletSpawn1:Transform;
var bulletSpawn2:Transform;
var target : Transform;
var damping = 6.0;
var smooth = true;
var k:int=0;
private var curDistance:float=0.0;
// Тег для поиска цели,присваивается в инспекторе
var searchTag = "Respawn";
 
// Частота сканирования ближайшей цели в секундах
// устанавливается в инспекторе
var scanFrequency = 1.0;
var isOneTurret:boolean=false;
var isTwoTurret:boolean=true;
var isLazerTurret:boolean=false; 
var isElectricTurret:boolean=false; 
var isRocketTurret:boolean=false;
var isGoldGenerator:boolean=false;
var isWall:boolean=false;
var isCollider:boolean=true;
var is_Net:boolean=false;


//для апгрейда здания
var clicked : boolean = false;
var hit : RaycastHit;
var xOffsetx: float;
var yOffsety: float;
var CameraMain:GameObject;
var UpgradedWindow : GameObject;
var fromlevel:int=1;
var cash:int=0;
var cashes:int[];
var powerstart:int=0;
var powerend:int=0;
var nearestDistanceSqr:float=0.0;
var fastpower:int=30;
var genStart:float=0;
var genEnd:float=6;
var clickUpgrade:boolean=false;
var select:boolean=false;
var select1:boolean=false;
var currObj:boolean=false;
var inpSign:Transform;

 
 
function Start() {
    // Сканирование новых объектов
    InvokeRepeating("ScanForTarget", 0, scanFrequency );
}
 
function Update() {
UpgradedWindow=GameObject.Find("UpgradeWindow");
	//if (target==null) 
	if (Bul==null)
	Bul=Bullet;
	if(isLazerTurret)
	if (transform.parent.tag=="Active")
	{
	transform.tag="Active";
	}
    // Поворот в сторону найденной цели
    if (transform.tag=="Active"){
    if (isRocketTurret && target==null) { 
			                        //Электрическая вышка один элемент
    		for (var childRockBul : Transform in transform)
    		if (childRockBul.gameObject.name=="SpawnRocket")
    		childRockBul.active=false;
			}
    if (target != null) {
        var rot:Vector3 = transform.eulerAngles;
		if (isOneTurret || isTwoTurret || isRocketTurret){
		var targetPoint = target.transform.position;
            var targetRotation = Quaternion.LookRotation(targetPoint - transform.position, Vector3.up);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 9.0);   
		//transform.LookAt(target.transform*Vector3.up);
		//transform.eulerAngles = new Vector3(rot.x, transform.eulerAngles.y-90, rot.z);
		} else 
		if (isLazerTurret) transform.LookAt(target.transform);		
		 if (isOneTurret) { 
		 
    		                                    //Миниган с одним дулом
		 k=k+1;
		 if (k>=fastpower){
			Instantiate(Bullet,bulletSpawn1.position,bulletSpawn1.rotation);
			k=0;
			}
			Bul=Bullet;
    }
    	if (isTwoTurret) {   
    		                                 //Пушка с двумя дулами
		 k=k+1;
		 if (k>=fastpower){
			Instantiate(Bullet,bulletSpawn1.position,bulletSpawn1.rotation);
			Instantiate(Bullet1,bulletSpawn2.position,bulletSpawn2.rotation);
			k=0;
			}
			Bul=Bullet;
			Bul1=Bullet1;
    }
    		 if (isLazerTurret) {                          //Лазерная вышка один элемент
    		 //k=k+1;
    		for (var childBul : Transform in transform)
    		if (childBul.gameObject.name=="Sphere001")
    		childBul.active=false;//gameObject.GetComponent("LookAtCarBot").enabled=true;
    		//if (k>=fastpower){ 
			Bul=Instantiate(Bullet,bulletSpawn1.position,bulletSpawn1.rotation);
//			k=0;
//			}
			}
			
			 if (isElectricTurret) {   
			                        //Электрическая вышка один элемент
    		for (var childElBul in transform)
    		if (childElBul.name=="lightningBoltBase")
    		childElBul.active=true;
			}
			
			if (isRocketTurret) { 
			                        //Электрическая вышка один элемент
    		for (var childRockBul : Transform in transform)
    		if (childRockBul.gameObject.name=="SpawnRocket")
    		childRockBul.active=true;
			}
    }
    		
    	////////////////////////////////////////Цены на пушки
		 if (isOneTurret) { 
		 var curBul:BulletSpawn=Bul.GetComponent("BulletSpawn");
    		 curBul.powerstart=powerstart;
    		 curBul.powerend=powerend;
		 if(fromlevel==1) cash=cashes[0];
    		 if(fromlevel==2) cash=cashes[1];
    		 if(fromlevel==3) cash=cashes[2];
    		 if(fromlevel==4) cash=cashes[3];
    		 if(fromlevel==5) cash=cashes[4];
    		 if (fromlevel==1){powerstart=4;powerend=6;nearestDistanceSqr=150;}
			if (fromlevel==2){powerstart=10;powerend=12;nearestDistanceSqr=160;fastpower=6;}
			if (fromlevel==3){powerstart=13;powerend=17;nearestDistanceSqr=170;fastpower=5;}
			if (fromlevel==4){powerstart=20;powerend=26;nearestDistanceSqr=200;fastpower=4;}
			if (fromlevel==5){powerstart=29;powerend=34;nearestDistanceSqr=220;fastpower=3;}
			if (fromlevel==6){powerstart=40;powerend=45;nearestDistanceSqr=240;fastpower=2;}
                                  //Миниган с одним дулом
    }
    	if (isTwoTurret) {   
    		                               //Пушка с двумя дулами
    		 var curBulTwo:BulletSpawn=Bul.GetComponent("BulletSpawn");
    		 curBulTwo.powerstart=powerstart;
    		 curBulTwo.powerend=powerend;
    		 var curBulTwo1:BulletSpawn=Bul1.GetComponent("BulletSpawn");
    		 curBulTwo1.powerstart=powerstart;
    		 curBulTwo1.powerend=powerend;
		 if(fromlevel==1) cash=cashes[0];
    		 if(fromlevel==2) cash=cashes[1];
    		 if(fromlevel==3) cash=cashes[2];
    		 if(fromlevel==4) cash=cashes[3];
    		 if(fromlevel==5) cash=cashes[4];
    		 if (fromlevel==1){powerstart=4;powerend=6;nearestDistanceSqr=150;}
			if (fromlevel==2){powerstart=12;powerend=20;nearestDistanceSqr=160;fastpower=26;}
			if (fromlevel==3){powerstart=30;powerend=35;nearestDistanceSqr=170;fastpower=21;}
			if (fromlevel==4){powerstart=40;powerend=47;nearestDistanceSqr=200;fastpower=17;}
			if (fromlevel==5){powerstart=48;powerend=55;nearestDistanceSqr=220;fastpower=14;}
			if (fromlevel==6){powerstart=56;powerend=60;nearestDistanceSqr=240;fastpower=10;}
		
    }
    		 if (isLazerTurret) {                          //Лазерная вышка один элемент
    		 var curBulLaser:BulletSpawn=Bul.GetComponent("BulletSpawn");
    		 curBulLaser.powerstart=powerstart;
    		 curBulLaser.powerend=powerend;
    		 if(fromlevel==1) cash=cashes[0];
    		 if(fromlevel==2) cash=cashes[1];
    		 if(fromlevel==3) cash=cashes[2];
    		 if(fromlevel==4) cash=cashes[3];
    		 if(fromlevel==5) cash=cashes[4];
    		 if (fromlevel==1){powerstart=1;powerend=2;nearestDistanceSqr=180;}
			if (fromlevel==2){powerstart=3;powerend=4;nearestDistanceSqr=210;}
			if (fromlevel==3){powerstart=5;powerend=7;nearestDistanceSqr=240;}
			if (fromlevel==4){powerstart=10;powerend=12;nearestDistanceSqr=280;}
			if (fromlevel==5){powerstart=14;powerend=16;nearestDistanceSqr=310;}
			if (fromlevel==6){powerstart=20;powerend=30;nearestDistanceSqr=340;}
			}
			
			 if (isElectricTurret) {   
			                         //Электрическая вышка один элемент
			 if(fromlevel==1) cash=cashes[0];
    		 if(fromlevel==2) cash=cashes[1];
    		 if(fromlevel==3) cash=cashes[2];
    		 if(fromlevel==4) cash=cashes[3];
    		 if(fromlevel==5) cash=cashes[4];
    		 //if (fromlevel==1) 
			if (fromlevel==2){
			for(var chLight in transform)
    		 if (chLight.transform.name=="lightningBoltBase") //chLight.transform.active=false;
    		 {
    		 var chLit:FindCloser=chLight.GetComponent("FindCloser");
    		 chLit.ElPowLvl=0.9;
    		 chLit.timeWantedSpeed=40;
    		 }
  			}
			if (fromlevel==3){
			for(var chLight in transform)
    		 if (chLight.transform.name=="lightningBoltBase") //chLight.transform.active=false;
    		 {
    		 var chLit1:FindCloser=chLight.GetComponent("FindCloser");
    		 chLit1.ElPowLvl=0.9;
    		 chLit1.timeWantedSpeed=50;
    		 }
			}
			if (fromlevel==4){
			for(var chLight in transform)
    		 if (chLight.transform.name=="lightningBoltBase") //chLight.transform.active=false;
    		 {
    		 var chLit2:FindCloser=chLight.GetComponent("FindCloser");
    		 chLit2.ElPowLvl=0.9;
    		 chLit2.timeWantedSpeed=60;
    		 }
			}
			if (fromlevel==5){
			for(var chLight in transform)
    		 if (chLight.transform.name=="lightningBoltBase") //chLight.transform.active=false;
    		 {
    		 var chLit3:FindCloser=chLight.GetComponent("FindCloser");
    		 chLit3.ElPowLvl=0.9;
    		 chLit3.timeWantedSpeed=100;
    		 }
			}
			if (fromlevel==6){
			for(var chLight in transform)
    		 if (chLight.transform.name=="lightningBoltBase") //chLight.transform.active=false;
    		 {
    		 var chLit4:FindCloser=chLight.GetComponent("FindCloser");
    		 chLit4.ElPowLvl=0.9;
    		 chLit4.timeWantedSpeed=150;
    		 }
			}
    		
			}
			
			if (isRocketTurret) { 
			                         //Электрическая вышка один элем
			 for (var childRockB : Transform in transform)
    		if (childRockB.gameObject.name=="SpawnRocket"){
			 var curBulRocket:MissleLaunch=childRockB.GetComponent("MissleLaunch");
    		 curBulRocket.powerstart=powerstart;
    		 curBulRocket.powerend=powerend;
    		 curBulRocket.genStart=genStart;
    		 curBulRocket.genEnd=genEnd;
    		 }

    		 if(fromlevel==1) cash=cashes[0];
    		 if(fromlevel==2) cash=cashes[1];
    		 if(fromlevel==3) cash=cashes[2];
    		 if(fromlevel==4) cash=cashes[3];
    		 if(fromlevel==5) cash=cashes[4];
    		 if (fromlevel==1){powerstart=10;powerend=12;genStart=5;genEnd=8;}
			if (fromlevel==2){powerstart=15;powerend=30;genStart=4;genEnd=7;}
			if (fromlevel==3){powerstart=45;powerend=55;genStart=3;genEnd=6;}
			if (fromlevel==4){powerstart=60;powerend=80;genStart=2;genEnd=4;}
			if (fromlevel==5){powerstart=90;powerend=120;genStart=1;genEnd=3;}
			if (fromlevel==6){powerstart=150;powerend=160;genStart=0.5;genEnd=2;}
			}
			
			if (isGoldGenerator){
			var scrGoldUpg:GeneratorGold=transform.GetComponent("GeneratorGold");
			if(fromlevel==1) cash=cashes[0];
    		 if(fromlevel==2) cash=cashes[1];
    		 if(fromlevel==3) cash=cashes[2];
    		 if(fromlevel==4) cash=cashes[3];
    		 if(fromlevel==5) cash=cashes[4];
    		 if (fromlevel==1){scrGoldUpg.secAvailable=30;scrGoldUpg.AvailableGold=1;}
			if (fromlevel==2){scrGoldUpg.secAvailable=25;scrGoldUpg.AvailableGold=1;}
			if (fromlevel==3){scrGoldUpg.secAvailable=20;scrGoldUpg.AvailableGold=2;}
			if (fromlevel==4){scrGoldUpg.secAvailable=20;scrGoldUpg.AvailableGold=3;}
			if (fromlevel==5){scrGoldUpg.secAvailable=15;scrGoldUpg.AvailableGold=7;}
			if (fromlevel==6){scrGoldUpg.secAvailable=10;scrGoldUpg.AvailableGold=10;}
			}
			
			if (isWall){
			var scrWallupg:BotImputWall=transform.GetComponent("BotImputWall");
			if(fromlevel==1) cash=cashes[0];
    		 if(fromlevel==2) cash=cashes[1];
    		 if(fromlevel==3) cash=cashes[2];
    		 if(fromlevel==4) cash=cashes[3];
    		 if(fromlevel==5) cash=cashes[4];
    		 if (fromlevel==1){scrWallupg.wallStrength=5;scrWallupg.AfterWallSpeed=0.5;}
			if (fromlevel==2){scrWallupg.wallStrength=15;scrWallupg.AfterWallSpeed=0.5;}
			if (fromlevel==3){scrWallupg.wallStrength=30;scrWallupg.AfterWallSpeed=0.5;}
			if (fromlevel==4){scrWallupg.wallStrength=80;scrWallupg.AfterWallSpeed=0.5;}
			if (fromlevel==5){scrWallupg.wallStrength=100;scrWallupg.AfterWallSpeed=0.5;}
			if (fromlevel==6){scrWallupg.wallStrength=150;scrWallupg.AfterWallSpeed=0.5;}
			}
    
    if (isCollider)
    {
    SetTrigger();
    isCollider=false;
    }
    
    //////Проверка если нажата кнопка мыши на здании
    if (fromlevel<=5){
    if (collider.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), hit,
                        Mathf.Infinity)){
    if (isLazerTurret){
    for(inpSign in transform.parent){
    if (inpSign.name=="InputSign") inpSign.active=true;
    if (currObj){
    for(var inpSignDist:Transform in inpSign)
    if (inpSignDist.name=="InputSignDistance") {
    inpSignDist.active=true; inpSignDist.transform.localScale = Vector3(nearestDistanceSqr/16,nearestDistanceSqr/16,nearestDistanceSqr/13);
    }
	select1=false;
    } else {
    for(inpSignDist in inpSign)
    if (inpSignDist.name=="InputSignDistance") 
    inpSignDist.active=false;
    }
    }
    }
    if (isGoldGenerator){
    for(inpSign in transform){
    if (inpSign.name=="InputSign") inpSign.active=true;
    if (currObj){
    for(var inpSignDist:Transform in inpSign)
    if (inpSignDist.name=="InputSignDistance") {
    inpSignDist.active=true; inpSignDist.transform.localScale = Vector3(nearestDistanceSqr/25.77,nearestDistanceSqr/25.77,nearestDistanceSqr/25.77);
    }

	select1=false;
    } else {
    for(inpSignDist in inpSign)
    if (inpSignDist.name=="InputSignDistance") 
    inpSignDist.active=false;

    }
    }
    }
    if (isRocketTurret) { 
    for(inpSign in transform){
    if (inpSign.name=="InputSign") inpSign.active=true;
    if (currObj){
    for(var inpSignDist:Transform in inpSign)
    if (inpSignDist.name=="InputSignDistance") {
    inpSignDist.active=true; inpSignDist.transform.localScale = Vector3(nearestDistanceSqr/25.77,nearestDistanceSqr/25.77,nearestDistanceSqr/25.77);
    }

	select1=false;
    } else {
    for(inpSignDist in inpSign)
    if (inpSignDist.name=="InputSignDistance") 
    inpSignDist.active=false;

    }
    }
    }
    
    if (isWall){
    for(inpSign in transform){
    if (inpSign.name=="InputSign") inpSign.active=true;
    if (currObj){
    for(var inpSignDist:Transform in inpSign)
    if (inpSignDist.name=="InputSignDistance") {
    inpSignDist.active=true; inpSignDist.transform.localScale = Vector3(nearestDistanceSqr/25.77,nearestDistanceSqr/25.77,nearestDistanceSqr/25.77);
    }

	select1=false;
    } else {
    for(inpSignDist in inpSign)
    if (inpSignDist.name=="InputSignDistance") 
    inpSignDist.active=false;

    }
    }
    }
    if (isOneTurret) { 
    for(inpSign in transform){
    if (inpSign.name=="InputSign") inpSign.active=true;
    if (currObj){
    for(var inpSignDist:Transform in inpSign)
    if (inpSignDist.name=="InputSignDistance") {
    inpSignDist.active=true; inpSignDist.transform.localScale = Vector3(nearestDistanceSqr/25.77,nearestDistanceSqr/25.77,nearestDistanceSqr/25.77);
    }

	select1=false;
    } else {
    for(inpSignDist in inpSign)
    if (inpSignDist.name=="InputSignDistance") 
    inpSignDist.active=false;

    }
    }
    }
    if (isElectricTurret){
    for(inpSign in transform){
    if (inpSign.name=="InputSign") inpSign.active=true;
    if (currObj){
    for(var inpSignDist:Transform in inpSign)
    if (inpSignDist.name=="InputSignDistance") {
    inpSignDist.active=true; inpSignDist.transform.localScale = Vector3(nearestDistanceSqr/25.77,nearestDistanceSqr/25.77,nearestDistanceSqr/25.77);
    }

	select1=false;
    } else {
    for(inpSignDist in inpSign)
    if (inpSignDist.name=="InputSignDistance") 
    inpSignDist.active=false;

    }
    }
    }
    if (isTwoTurret){
    for(inpSign in transform){
    if (inpSign.name=="InputSign") inpSign.active=true;
    if (currObj){
    for(var inpSignDist:Transform in inpSign)
    if (inpSignDist.name=="InputSignDistance") {
    inpSignDist.active=true; inpSignDist.transform.localScale = Vector3(nearestDistanceSqr/25.77,nearestDistanceSqr/25.77,nearestDistanceSqr/25.77);
    }

	select1=false;
    } else {
    for(inpSignDist in inpSign)
    if (inpSignDist.name=="InputSignDistance") 
    inpSignDist.active=false;

    }
    }
    }
    } else
    {
    if (isLazerTurret){
    for(inpSign in transform.parent)
    if (inpSign.name=="InputSign") inpSign.active=false;
    currObj=false;
    clicked=false;
    if (!select1){
    var setUpgrade:UpgradesBuilds=UpgradedWindow.GetComponent("UpgradesBuilds");
    setUpgrade.clicked=false;
    setUpgrade.select=false;
    select1=true;
    }
    } 
    if (isTwoTurret){
    for(inpSign in transform)
    if (inpSign.name=="InputSign") inpSign.active=false;
    currObj=false;
    clicked=false;
    if (!select1){
    var setUpgrade1:UpgradesBuilds=UpgradedWindow.GetComponent("UpgradesBuilds");
    setUpgrade1.clicked=false;
    setUpgrade1.select=false;
    select1=true;
    }
    } 
    if (isGoldGenerator){
    for(inpSign in transform)
    if (inpSign.name=="InputSign") inpSign.active=false;
    currObj=false;
    clicked=false;
    if (!select1){
    var setUpgrade2:UpgradesBuilds=UpgradedWindow.GetComponent("UpgradesBuilds");
    setUpgrade2.clicked=false;
    setUpgrade2.select=false;
    select1=true;
    }
    } 
    if (isRocketTurret) { 
    for(inpSign in transform)
    if (inpSign.name=="InputSign") inpSign.active=false;
    currObj=false;
    clicked=false;
    if (!select1){
    var setUpgrade6:UpgradesBuilds=UpgradedWindow.GetComponent("UpgradesBuilds");
    setUpgrade6.clicked=false;
    setUpgrade6.select=false;
    select1=true;
    }
    }
    if (isWall){
    for(inpSign in transform)
    if (inpSign.name=="InputSign") inpSign.active=false;
    currObj=false;
    clicked=false;
    if (!select1){
    var setUpgrade5:UpgradesBuilds=UpgradedWindow.GetComponent("UpgradesBuilds");
    setUpgrade5.clicked=false;
    setUpgrade5.select=false;
    select1=true;
    }
    }
    if (isOneTurret) { 
    for(inpSign in transform)
    if (inpSign.name=="InputSign") inpSign.active=false;
    currObj=false;
    clicked=false;
    if (!select1){
    var setUpgrade4:UpgradesBuilds=UpgradedWindow.GetComponent("UpgradesBuilds");
    setUpgrade4.clicked=false;
    setUpgrade4.select=false;
    select1=true;
    }
    }
    if (isElectricTurret){
    for(inpSign in transform)
    if (inpSign.name=="InputSign") inpSign.active=false;
    currObj=false;
    clicked=false;
    if (!select1){
    var setUpgrade3:UpgradesBuilds=UpgradedWindow.GetComponent("UpgradesBuilds");
    setUpgrade3.clicked=false;
    setUpgrade3.select=false;
    select1=true;
    }
    }
    }  
   
     if(Input.GetMouseButtonDown(0) &&
       collider.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), hit,
                        Mathf.Infinity)) {
        clicked = !clicked;
        currObj=true;
        if (clicked){
       // for(inpSign in transform)
//    	if (inpSign.name=="InputSignDistance") inpSign.active=true;
        CameraMain=GameObject.Find("Main Camera");
        var screenPos:Vector3 = CameraMain.camera.WorldToScreenPoint (transform.position);
 		rectX=screenPos.x - xOffsetx; // x offset
 		rectY=Screen.height - screenPos.y - yOffsety; // y offset
 		var scrUp:UpgradesBuilds=UpgradedWindow.GetComponent("UpgradesBuilds");
 		scrUp.fromlevel=fromlevel;
 		scrUp.cash=cash;
 		scrUp.recti=0;
		scrUp.rectj=0;
		scrUp.rectX=rectX;
		scrUp.rectY=rectY;
		scrUp.CurrentBuild[0]=gameObject;
		scrUp.clicked=true;
		scrUp.select=false;
		//clicked=false;
    }
    }
//    if(Input.GetMouseButtonDown(0) && !clicked){
//    var scrUp3:UpgradesBuilds=UpgradedWindow.GetComponent("UpgradesBuilds");
//    scrUp3.clicked=false;
//    scrUp3.select=false;
//    clicked=false;
//    }
    if (!clicked && currObj) {
    var scrUp1:UpgradesBuilds=UpgradedWindow.GetComponent("UpgradesBuilds");
    scrUp1.select=true;
    }
    } else {
    if (isRocketTurret) {
    for(var inpSignClose in transform)
    if (inpSignClose.name=="InputSign") inpSignClose.active=false;
    }
    if (isOneTurret) { 
    for(var inpSignClose in transform)
    if (inpSignClose.name=="InputSign") inpSignClose.active=false;
    }
    if (isWall){
    for(var inpSignClose in transform)
    if (inpSignClose.name=="InputSign") inpSignClose.active=false;
    }
    if (isElectricTurret){
    for(var inpSignClose in transform)
    if (inpSignClose.name=="InputSign") inpSignClose.active=false;
    }
     if (isTwoTurret){
    for(var inpSignClose in transform)
    if (inpSignClose.name=="InputSign") inpSignClose.active=false;
    }
    if (isGoldGenerator){
    for(var inpSignClose in transform)
    if (inpSignClose.name=="InputSign") inpSignClose.active=false;
    }
    if (isLazerTurret){
    for(var inpSignLClose in transform.parent)
    if (inpSignLClose.name=="InputSign") inpSignLClose.active=false;
    }
    }
    }
    

}



function SetTrigger()
{
yield WaitForSeconds(1);    //через 1 секунду объект на сетке включает триггер
collider.isTrigger=true;
}

//function OnTriggerEnter (buildingSet : Collider) {
//
////if (is_Net && transform.tag=="PlacementPlane_Taken")
////if (buildingSet.CompareTag ("Untagged")) {
////for (var childMat:Transform in buildingSet.transform){
////if (childMat.name=="TransRed") childMat.active=true;
////if (childMat.name=="TransWhite") childMat.active=false;
////}
////}
////
////if (is_Net && transform.tag=="PlacementPlane_Open")
////if (buildingSet.CompareTag ("Untagged")) {
////for (var childMat:Transform in buildingSet.transform){
////if (childMat.name=="TransRed") childMat.active=false;
////if (childMat.name=="TransWhite") childMat.active=true;
////}
////}
//if (!is_Net && transform.tag=="Active")
//if (buildingSet.CompareTag ("Untagged")) {
//for (var childMat1:Transform in buildingSet.transform){
//if (childMat1.name=="TransRed") childMat1.active=true;
//if (childMat1.name=="TransWhite") childMat1.active=false;
//}
//CameraMain.GetComponent("GameInterface").SendMessage ("ApplyDamage", false);
//}
//}
//
//function OnTriggerExit (buildingSet : Collider) {
//if (!is_Net)
//if (buildingSet.CompareTag ("Untagged")) {
//for (var childMat1:Transform in buildingSet.transform){
//if (childMat1.name=="TransRed") childMat1.active=false;
//if (childMat1.name=="TransWhite") childMat1.active=true;
//}
////CameraMain.GetComponent("GameInterface").SendMessage ("Access", true);
//}
//}
//
//function OnTriggerStay (buildingSet : Collider) {
//if (!is_Net)
//if (buildingSet.CompareTag ("Untagged")) {
//for (var childMat1:Transform in buildingSet.transform){
//if (childMat1.name=="TransRed") childMat1.active=true;
//if (childMat1.name=="TransWhite") childMat1.active=false;
//}
////CameraMain.GetComponent("GameInterface").SendMessage ("Access", false);
//}
//}


 
function ScanForTarget() {
    // Если тэг объекта Active(присваивается из скрипта GameInterface),производится поиск
    //ближайшей цели 
    if (transform.tag=="Active")
    target = GetNearestTaggedObject();
 
}
 
function GetNearestTaggedObject() : Transform {
    // Процесс нахождения ближайшей цели
// 	if (!isRocketTurret)
//    nearestDistanceSqr = 150.0;
    if (isRocketTurret)
    nearestDistanceSqr = 300.0;
    var EnemySimple = new Array (GameObject.FindGameObjectsWithTag (searchTag) );
	var EnemyDetected = new Array (GameObject.FindGameObjectsWithTag ("Detected") );
	var taggedGameObjects = EnemySimple.Concat(EnemyDetected).ToBuiltin(GameObject);
    var nearestObj : Transform = null;
 
    for (var obj : GameObject in taggedGameObjects) {
 
        var objectPos = obj.transform.position;
        var distanceSqr = (objectPos - transform.position).sqrMagnitude;
 
        if (distanceSqr < nearestDistanceSqr) {
            nearestObj = obj.transform;
            nearestDistanceSqr = distanceSqr;
			
    }
        }
    return nearestObj;
}