/*
	This script is placed in public domain. The author takes no responsibility for any possible harm.
	Contributed by Jonathan Czeck
*/
using UnityEngine;
using System.Collections;

public class LightningBolt : MonoBehaviour
{
	public Transform target;
	public Transform ElectroPref;
	public Transform TPref;
	public int zigs = 100;
	public float speed = 1f;
	public float scale = 1f;
	public Light startLight;
	public Light endLight;
	//public Transform ChainPref;
	float distance;
	public bool level2;
	//GameObject[] gos;
	//public string myTestTag = "enemy";
	public int t=0;
	public int t1=0; //Скорость стрельбы,этот коэф уменьшается если уровень эл вышки повышается.
	public int t2=0; //Этот коэф уменьшается если уровень эл вышки повышается.
	public float ElPowLvl=1.0F; //сила замедления в зависимости от лвл эл вышки
	public bool Electric=false; //если цель поражена током
	public int timeWantedSpeed=20; //на сколько медленней будет двигаться бот зависит от лвл эл вышки
	// чем выше лвл вышки тем больше это значение

	
	Perlin noise;
	float oneOverZigs;
	
	private Particle[] particles;
	
	void Start()
	{
		oneOverZigs = 1f / (float)zigs;
		particleEmitter.emit = false;

		particleEmitter.Emit(zigs);
		particles = particleEmitter.particles;
			
		
	}
	
	
	
	public Transform GetNearestTaggedObject() {
    // and finally the actual process for finding the nearest object:
 
    var nearestDistanceSqr = 300.0F;
    var taggedGameObjects = GameObject.FindGameObjectsWithTag("Enemy");
		
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
	
//	void RenamedTag()
//	{
//	gos = GameObject.FindGameObjectsWithTag(myTestTag);
//	for (int i=0;i<gos.Length;i++)
//		{
//			
//			if (k){
//			if (gos[0].tag==myTestTag)
//			{
//				
//				gos[0].tag="Detected";
//				target=gos[0].transform;
//				TPref = Instantiate(ElectroPref, transform.position, transform.rotation) as Transform;
//				
//			}
//			
//				k=false;
//			}
//			
//			
//		}
//	}
	
//	void TimeCollapsed()
//	{
//	
//		if (tk){
//		if (target.tag=="Killed" && target==null) tk=false; 
//		t=t+1;
//		if (t==50) 
//		{GetComponent<ParticleRenderer>().enabled = true; t=0;} 
//		else { if (t==20) GetComponent<ParticleRenderer>().enabled = false;
//		} 
//		}
//		if (!tk) {GetComponent<ParticleRenderer>().enabled = false; 
//			if (t==0){
//			TPref = Instantiate(ElectroPref, transform.position, transform.rotation) as Transform;
//			Destroy(gameObject);
//			}
//			}
//		
//	}
	
	void Update ()
	{
		
		target=GetNearestTaggedObject();
		
//		if (a){
//		ElectroPref = Instantiate(ElectroPref, transform.position, transform.rotation) as Transform;
//			a=false;}
		
//		if (!baseStation){
//		RenamedTag();
//		TimeCollapsed();
		if (target==null){
		GetComponent<ParticleRenderer>().enabled = false; 
		//particleEmitter.enabled = false;
			return;
		} else
		if (target!=null){
		//target.gameObject.GetComponent<NavMeshAgent>().speed=0.5F;
		
		AIfind playerScript = target.parent.GetComponent<AIfind>();
        playerScript.Electric=true;
		playerScript.ElPowLvl=ElPowLvl;
		playerScript.timeWantedSpeed=timeWantedSpeed;
		t=t+1;
		if (t==t1) 
		{GetComponent<ParticleRenderer>().enabled = true;gameObject.audio.Play(); t=0;} 
		else { if (t==t2) {GetComponent<ParticleRenderer>().enabled = false;gameObject.audio.Stop();}
		} 
		}
		
		if (noise == null)
			noise = new Perlin();
			
		float timex = Time.time * speed * 0.1365143f;
		float timey = Time.time * speed * 1.21688f;
		float timez = Time.time * speed * 2.5564f;
		
		for (int i=0; i < particles.Length; i++)
		{
			Vector3 position = Vector3.Lerp(transform.position, target.position, oneOverZigs * (float)i);
			Vector3 offset = new Vector3(noise.Noise(timex + position.x, timex + position.y, timex + position.z),
										noise.Noise(timey + position.x, timey + position.y, timey + position.z),
										noise.Noise(timez + position.x, timez + position.y, timez + position.z));
			position += (offset * scale * ((float)i * oneOverZigs));
			
			particles[i].position = position;
			particles[i].color = Color.white;
			particles[i].energy = 1f;
		}
		
		particleEmitter.particles = particles;
		
		if (particleEmitter.particleCount >= 2)
		{
			if (startLight)
				startLight.transform.position = particles[0].position;
			if (endLight)
				endLight.transform.position = particles[particles.Length - 1].position;
//			if (level2){
//		for (int abc=0;abc<3;abc++)
//		ElectroPref = Instantiate(ElectroPref, endLight.transform.position, endLight.transform.rotation) as Transform;
//		level2=false;
//		}
		}
		//}

		
	}	
}