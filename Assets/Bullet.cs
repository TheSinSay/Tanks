using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	public float bulletSpeed;
	public Object obj;
	void OnTriggerEnter(Collider collision) {
		collision.gameObject.SendMessage("Destr");
		GameObject.Destroy(obj);
	}
	void Start () {
		bulletSpeed = 100;
	}
	
	IEnumerator SomeCoroutine () {
		yield return new WaitForSeconds(1);
		Destroy(gameObject);
		}
	
	void Update () {
		transform.Translate(1f,0,0);
	}
}
