//Инструкция: Создать префаб объекта с названными подобъектами обязательно 1,2,3,4-это 4 этапа постройки
//закрепить данный скрипт на префабе.


private var startTime = 0;			//Глобальное время
var BuildingTime : float = 10.0f;		//Время постройки в секундах
private var QuantitySteps : int = 3;
private var divisionTime : float = 0.0f;
private var is_upgraded : String="Ожидание: ";
private var i:int=0;

private var textMesh : Transform;			//3д текст

private var ModChangeStep : Transform[];   //Этапы постройки-массив моделей

function Start() {
	ModChangeStep = new Transform[4];
	for (i=0;i<4;i++){
   		for (var child : Transform in transform) {
   			if(child.gameObject.name == "1") { ModChangeStep[0]=child.transform; child.transform.active=false; }  //Если подобъект называется 1 то его перенести в массив
   			if(child.gameObject.name == "2") { ModChangeStep[1]=child.transform; child.transform.active=false; }	//Если подобъект называется 2 то его перенести в массив
   			if(child.gameObject.name == "3") { ModChangeStep[2]=child.transform; child.transform.active=false; }
   			if(child.gameObject.name == "4") { ModChangeStep[3]=child.transform; child.transform.active=false; }
   			if(child.gameObject.name == "Timer") textMesh=child.transform;
		}
	yield;
	}
   startTime = Time.time;
   ModChangeStep[0].active=true;            //Основание постройки-земля
   if (QuantitySteps==3) {divisionTime=BuildingTime/2; 
   		QuantitySteps = QuantitySteps - 1;}
}

function Update()
{
BuildingTime -= Time.deltaTime;					//Обратный отсчет

	if (BuildingTime<divisionTime && QuantitySteps==2){
	
		ModChangeStep[0].active=false;
		ModChangeStep[1].active=true; //Основание постройки-каркас на земле
		divisionTime=BuildingTime/2; 
		QuantitySteps = QuantitySteps - 1;
	
	}
	
	if (BuildingTime<divisionTime && QuantitySteps==1){
		
		ModChangeStep[1].active=false;
		ModChangeStep[2].active=true; //Постройка второго этажа
		divisionTime=BuildingTime/3; 
		QuantitySteps = QuantitySteps - 1;
	
	}
	
	if (BuildingTime<divisionTime && QuantitySteps==0){
		
		ModChangeStep[2].active=false;
		ModChangeStep[3].active=true; //Завершение постройки
		divisionTime=BuildingTime/4;
		
	}
	
    if (BuildingTime < 0.0f)
    {
    	BuildingTime = 0;
    	textMesh.GetComponent(TextMesh).text = "Завершено";
    	
    } else 
    		if (BuildingTime > 0.0)
    			textMesh.GetComponent(TextMesh).text = is_upgraded + ConvertTimeToString().ToString();
}

function ConvertTimeToString()			//Конвертация времени
{
    
    var minutes:int = Mathf.FloorToInt((BuildingTime % 3600) / 60);
    var seconds:int = Mathf.FloorToInt(BuildingTime) % 60;
    return (minutes.ToString("00") + ":" + seconds.ToString("00"));
}