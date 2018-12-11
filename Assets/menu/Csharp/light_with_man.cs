using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light_with_man : MonoBehaviour {
	public GameObject man, light;
	Vector3 manpos, lightpos;
	// Use this for initialization
	void Start () {
		lightpos = light.GetComponent<Transform> ().position;
	}
	
	// Update is called once per frame
	void Update () {
		manpos = man.GetComponent<Transform> ().position;
		lightpos.x = manpos.x;
		lightpos.y = manpos.y;

		light.GetComponent<Transform> ().position = lightpos;
	}
}
