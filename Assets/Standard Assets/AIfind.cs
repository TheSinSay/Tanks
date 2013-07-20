using UnityEngine;
using System.Collections;

public class AIfind : MonoBehaviour {
	public NavMeshAgent navAgent;
	public Transform target;
	public bool shoot;
	public GameObject Bullet;
	public Transform bulletSpawn;
	public GameObject Turret;
	private int timeSpeed; //начальное время поражения
	public int timeWantedSpeed=20; //конечное время поражения зависит от лвл эл вышки
	// чем выше лвл вышки тем больше это значение
	private float BasicSpeed=2.0F; //для каждого уровня каждой волны разная базовая скорость езды
	public float ElPowLvl=1.0F; //сила замедления в зависимости от лвл эл вышки
	public bool Electric=false; //если цель поражена током
	private PlayerEnemy Ascript;
	private ApacheLook Bscript;
	public bool is_Air=false;
	public bool is_Jeep=false;
	//private bool Janim=false;
	public GameObject ApacheAnim;
	public float distanceAgent=0.0F;
	//public GameObject JeepAnim;
	
	
	void Start()
	{
		navAgent.stoppingDistance=Random.Range(9.0F,11.0F);
		distanceAgent=navAgent.stoppingDistance+5;
//		if (!is_Air)
//		target=GameObject.Find("MainBuilding").transform;
		if (is_Air)
		target=GameObject.Find("ApacheTargetFollow").transform;
//		navAgent=(NavMeshAgent)this.GetComponent("NavMeshAgent");
	}
	
	public Transform GetNearestTaggedObject() {
    // and finally the actual process for finding the nearest object:
 
    var nearestDistanceSqr = Mathf.Infinity;
    var taggedGameObjects = GameObject.FindGameObjectsWithTag("Player");
		
    Transform nearestObj = null;
 
    // loop through each tagged object, remembering nearest one found
    foreach (var obj in taggedGameObjects) {
 
        var objectPos = obj.transform.position;
        var distanceSqr = (objectPos - transform.position).sqrMagnitude;
        if (distanceSqr < nearestDistanceSqr) {
            nearestObj = obj.transform;
            nearestDistanceSqr = distanceSqr;
        }
    }
    return nearestObj;
}
	
	void Update () {
	if(!is_Air) target=GetNearestTaggedObject();
		//GameObject.Find("MainBuilding").transform;
	if (Electric){
		navAgent.speed=ElPowLvl;
		timeSpeed+=1;
		if (timeSpeed>=timeWantedSpeed){
				navAgent.speed=BasicSpeed;
				timeSpeed=0;
				Electric=false;
			}
		}
	
	navAgent.SetDestination(target.transform.position);
	float dist = Vector3.Distance(target.position, transform.position); 
//		if (dist<20)
//			if (is_Jeep && Janim){
//				foreach (Transform animObjects  in transform){
//					if (animObjects.name=="Jeep") animObjects.gameObject.animation.Play();
//					}
//					Janim=false;
//			}
		if (dist<distanceAgent) {
			
		if (!is_Air){
			//go.GetComponent<A>();
		Ascript = Turret.gameObject.GetComponent<PlayerEnemy>();
        Ascript.enabled=true;
			}
		if (is_Air){
		//animation["ApacheStop"].wrapMode = WrapMode.Once;
		ApacheAnim.animation.Play("ApacheStop");
		Bscript = Turret.gameObject.GetComponent<ApacheLook>();
        Bscript.enabled=true;
			}
//			i=i+1;
//			if (i==300) {
//				Instantiate(Bullet,bulletSpawn.position,bulletSpawn.rotation);
//				i=0;
//			}
		} else 
			if (dist>12){
			//Janim=true;
		if (is_Air){
		//animation["ApacheForward"].wrapMode = WrapMode.Once;
		ApacheAnim.animation.Play("ApacheForward");
			}
		}
	}
	
}
