using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class second_start : MonoBehaviour {
	public Flowchart talkflowchart;
	public static Flowchart flowchartManager;

	// Use this for initialization
	void Start () {
		if (DB.startgame2) {
			if (Application.loadedLevel == 3) {
				flowchartManager = GameObject.Find ("speakcontrol").GetComponent<Flowchart> ();
			}
			DB.cango = false;
			Block targetBlock = talkflowchart.FindBlock ("childtalk");
			talkflowchart.ExecuteBlock (targetBlock);
			DB.startgame2 = false;
		}

	}
	
	// Update is called once per frame
	void Update () {
		if(Application.loadedLevel == 3)
		if (!flowchartManager.GetBooleanVariable ("istalking"))
			DB.cango = true;
	}
}
