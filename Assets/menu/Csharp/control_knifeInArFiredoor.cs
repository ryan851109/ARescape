using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control_knifeInArFiredoor : MonoBehaviour {
	public GameObject knife;
	Vector3 init;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		knife.transform.Rotate(0, 0, 50*Time.deltaTime); 
	}
}
