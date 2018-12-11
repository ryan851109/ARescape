using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manControll : MonoBehaviour {
	// Use this for initialization

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay2D(Collider2D col){
		if (col.tag == "desk") {
			DB.aButton = true;
			DB.curTag = "desk";
		}
        if (col.tag == "sofa")
        {
            DB.aButton = true;
            DB.curTag = "sofa";
        }
		if (col.tag == "stone")
		{
			DB.aButton = true;
			DB.curTag = "stone";
		}
		if (col.tag == "gameboy")
		{
			DB.aButton = true;
			DB.curTag = "gameboy";
		}
		if (col.tag == "shelf")
		{
			DB.aButton = true;
			DB.curTag = "shelf";
		}
		if (col.tag == "piano")
		{
			DB.aButton = true;
			DB.curTag = "piano";
		}
		if (col.tag == "stone2")
		{
			DB.aButton = true;
			DB.curTag = "stone2";
		}
		if (col.tag == "cupboard")
		{
			DB.aButton = true;
			DB.curTag = "cupboard";
		}
		if (col.tag == "oldman")
		{
			DB.aButton = true;
			DB.curTag = "oldman";
		}
		if (col.tag == "bone")
		{
			DB.aButton = true;
			DB.curTag = "bone";
		}
		if (col.tag == "halfbone")
		{
			DB.aButton = true;
			DB.curTag = "halfbone";
		}
		if (col.tag == "door")
		{
			DB.aButton = true;
			DB.curTag = "door";
		}
    }

	void OnTriggerExit2D(Collider2D other)
	{
		DB.aButton = false;
		DB.curTag = "";
	}
}
