using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using Fungus;

public class window_CHECK : MonoBehaviour, IPointerDownHandler 
{
	public Flowchart talkflowchart;
	public static Flowchart flowchartManager;

	// Use this for initialization
	void Start () {
		if (Application.loadedLevel == 6) {
			flowchartManager = GameObject.Find ("speakcontrol").GetComponent<Flowchart> ();
		}
	}

	public void OnPointerDown(PointerEventData eventData)
	{
		if (DB.window_mode) {
			if (DB.window_left) {
				DB.window_mode = false;
				DB.show = false;

				if (DB.getgameboy && DB.bag_Object [int.Parse (DB.Bag_position) - 1] != "gameboy" && DB.bag_Object [int.Parse (DB.Bag_position) - 1] == "piano") {
					DB.cango = false;
					Block targetBlock = talkflowchart.FindBlock ("knife");
					talkflowchart.ExecuteBlock (targetBlock);
					for (int i = int.Parse (DB.Bag_position) - 1; i < 20; i++) {
						if (i == 19)
							DB.bag_Object [i] = "";
						else
							DB.bag_Object [i] = DB.bag_Object [i + 1];
					}
					for (int i = 0; i < 20; i++) {
						if (DB.bag_Object [i] == "gameboy"){
							DB.bag_Object [i] = "knife";
						}
					}
					//DB.backpack_mode = false;
					//這邊要加判斷 物件是否會成功使用，成功就跳回，失敗就留在背包
					//SceneManager.LoadScene (DB.pre_scense);
					DB.knife = true;
					StartCoroutine(WaitAndPrint (1.0f));
				} else {
					DB.cango = false;
					Block targetBlock = talkflowchart.FindBlock ("nothing");
					talkflowchart.ExecuteBlock (targetBlock);
				}
			} 
			else {
				DB.window_mode = false;
				DB.show = false;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(Application.loadedLevel == 6)
		if (!flowchartManager.GetBooleanVariable ("istalking"))
			DB.cango = true;
	}

	private IEnumerator WaitAndPrint(float waitTime)
	{
		yield return new WaitForSeconds(waitTime);
		SceneManager.LoadScene (6);
	}
}
