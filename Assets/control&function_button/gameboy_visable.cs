using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameboy_visable : MonoBehaviour {
	public GameObject gameboyobject;

	// Use this for initialization
	void Start () {
		if (DB.getgameboy) {
			Destroy (gameboyobject);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
