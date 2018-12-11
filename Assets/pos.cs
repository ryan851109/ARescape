using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pos : MonoBehaviour {
	public GameObject my;
	// Use this for initialization
	void Start () {
		if (!DB.firstEnter)
			my.transform.position = DB.leader_position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
