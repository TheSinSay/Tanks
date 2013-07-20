using UnityEngine;
using System.Collections;

public class BOOM : MonoBehaviour {
	public UnityEngine.Object obj;
	// Use this for initialization
	public void BOOOOM()
	{
		Destroy(obj);
	}
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(0,0,0.01f);
	}
}
