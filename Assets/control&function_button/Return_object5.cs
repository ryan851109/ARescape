﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Return_object5 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void Object_return() {
		if (DB.myTrackable == true) {
			for (int i = 0; i < 20; i++) {
				/*if (DB.bag_Object[i] == "cupboard") {
					break;
				}*/
				if (DB.bag_Object[i] == "") {
					DB.bag_Object[i] = "cupboard";
					DB.cupboard = true;
					break;
				}
			}
			DB.myTrackable = false;
			Application.LoadLevel(DB.now_scense);
		}
	}
}
