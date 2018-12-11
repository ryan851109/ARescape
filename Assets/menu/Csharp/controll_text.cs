using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controll_text : MonoBehaviour {
	Vector3 init, pos;
	// Use this for initialization
	void Start () {
		init = GetComponent<Transform> ().position;
		pos = init;
	}
	
	// Update is called once per frame
	void Update () {
		if (pos.y > 18) {
			pos = init;
		}
		pos.y += 0.03f;
		GetComponent<Transform> ().position = pos;
	}
}
