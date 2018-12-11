using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class first_start2 : MonoBehaviour {
	public Flowchart talkflowchart;
	public static Flowchart flowchartManager;

	// Use this for initialization
	void Start () {
		if (DB.startgame1) {
			if (Application.loadedLevel == 2) {
				flowchartManager = GameObject.Find ("speakcontrol2").GetComponent<Flowchart> ();
			}
			DB.cango = false;
			Block targetBlock = talkflowchart.FindBlock ("start");
			talkflowchart.ExecuteBlock (targetBlock);
			Block targetBlock2 = talkflowchart.FindBlock ("start2");
			talkflowchart.ExecuteBlock (targetBlock2);
			DB.startgame1 = false;
		}

	}

	// Update is called once per frame
	void Update () {
		if(Application.loadedLevel == 2)
		if (!flowchartManager.GetBooleanVariable ("istalking"))
			DB.cango = true;
	}
}
