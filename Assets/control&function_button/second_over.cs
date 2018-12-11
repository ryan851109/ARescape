using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fungus;

public class second_over : MonoBehaviour {
	public Flowchart talkflowchart;
	public static Flowchart flowchartManager;
	// Use this for initialization
	void Start () {
		if (Application.loadedLevel == 3) {
			flowchartManager = GameObject.Find ("speakcontrol").GetComponent<Flowchart> ();
		}

		if (DB.knife) {
			for (int i = 0; i < 20; i++) {
				DB.bag_Object [i] = "";
			}
			DB.cango = false;
			Block targetBlock = talkflowchart.FindBlock ("findknife");
			talkflowchart.ExecuteBlock (targetBlock);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(Application.loadedLevel == 3)
			if (!flowchartManager.GetBooleanVariable ("istalking"))
				DB.cango = true;

		if(flowchartManager.GetBooleanVariable ("jump"))
			SceneManager.LoadScene (4);
	}
}
