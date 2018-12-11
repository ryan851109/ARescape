using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Fungus;

public class check : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
	public Flowchart talkflowchart;
	public static Flowchart flowchartManager;
	public Flowchart talkflowchart2;
	public static Flowchart flowchartManager2;
	public GameObject gameboyobject;
	public GameObject human;
	// Use this for initialization
	void Start(){
		/*if (DB.firstEnter) {
			DB.leader_position = new Vector3((float)-0.05976188, (float)-4.370385,0);
			DB.firstEnter = true;
		}*/	
	}
	void Awake () {
		if (Application.loadedLevel == 3) {
			flowchartManager = GameObject.Find ("speakcontrol").GetComponent<Flowchart> ();
		}
		if (Application.loadedLevel == 2) {
			flowchartManager2 = GameObject.Find ("speakcontrol2").GetComponent<Flowchart> ();
		}
	}

    public void OnPointerDown(PointerEventData eventData)
    {
        if (DB.aButton == true)
        {
			DB.arprescene = Application.loadedLevel;
			DB.now_scense = Application.loadedLevel;
            //-----------------------------------------------------------------
			if (DB.curTag == "desk" && !DB.backpack_mode && !DB.ball)
            {
                Application.LoadLevel(7);
            }
			if (DB.curTag == "sofa" && !DB.backpack_mode && !DB.sofa)
            {
				Application.LoadLevel(8);
            }
			if (DB.curTag == "stone" && !DB.backpack_mode && Application.loadedLevel == 3) 
			{
					DB.cango = false;
					Block targetBlock = talkflowchart.FindBlock ("stonesay");
					talkflowchart.ExecuteBlock (targetBlock);
			}
			if (DB.curTag == "gameboy" && !DB.backpack_mode) 
			{
				DB.cango = false;
				Block targetBlock = talkflowchart.FindBlock ("gameboy");
				talkflowchart.ExecuteBlock (targetBlock);
				DB.getgameboy = true;
				for (int i = 0; i < 20; i++) {
					if (DB.bag_Object[i] == "gameboy") {
						break;
					}
					if (DB.curTag == "gameboy" && DB.bag_Object[i] == "") {
						DB.bag_Object[i] = "gameboy";
						break;
					}
				}
				Destroy (gameboyobject);
			}
			if (DB.curTag == "shelf" && !DB.backpack_mode && !DB.shelf) 
			{
				DB.firstEnter = false;
				Application.LoadLevel(9);
			}
			if (DB.curTag == "piano" && !DB.backpack_mode && !DB.piano) 
			{
				DB.firstEnter = false;
				Application.LoadLevel(10);
			}
			if (DB.curTag == "stone2" && !DB.backpack_mode && Application.loadedLevel == 3) 
			{
					DB.cango = false;
					Block targetBlock = talkflowchart.FindBlock ("stonesay");
					talkflowchart.ExecuteBlock (targetBlock);
			}
			if (DB.curTag == "cupboard" && !DB.backpack_mode && !DB.cupboard) 
			{
				DB.firstEnter = false;
				Application.LoadLevel(11);
			}
			if (DB.curTag == "door" && !DB.backpack_mode) 
			{
				Block targetBlock = talkflowchart.FindBlock ("door");
				talkflowchart.ExecuteBlock (targetBlock);
			}
			if (DB.curTag == "oldman" && !DB.backpack_mode) 
			{
				DB.firstEnter = false;
				DB.hastalkto_oldman = true;	
				Block targetBlock = talkflowchart2.FindBlock ("oldmantalk");
				if (DB.knigeINfiredoor == false) {
					talkflowchart2.ExecuteBlock (targetBlock);
				}
				if (DB.knigeINfiredoor == true) { // talk to old men with knife
					DB.bag_Object[0] = "";
					targetBlock = talkflowchart2.FindBlock ("finding");
					talkflowchart2.ExecuteBlock (targetBlock);
				}
			}
			if (DB.curTag == "bone" && !DB.backpack_mode && DB.hastalkto_oldman && !DB.knigeINfiredoor) 
			{
				DB.firstEnter = false;
				Application.LoadLevel(13);
			}
			if (DB.curTag == "halfbone" && !DB.backpack_mode && DB.hastalkto_oldman) 
			{
				DB.firstEnter = false;
				Application.LoadLevel(14);
			}
            //-----------------------------------------------------------------
        }

    }

    public void OnPointerUp(PointerEventData eventData)
    {
        //Debug.Log("Up");
    }

    // Update is called once per frame
    void Update () {
		if (Application.loadedLevel == 3)
			if (!flowchartManager.GetBooleanVariable ("istalking"))
				DB.cango = true;
		if (Application.loadedLevel == 2)
			if (!flowchartManager2.GetBooleanVariable ("istalking"))
				DB.cango = true;
		if (Application.loadedLevel == 2) {
			if (flowchartManager2.GetBooleanVariable ("jump")) {
				DB.firstEnter = false;
				DB.startgame2 = true;
				DB.leader_position = new Vector3((float)-0.05976188, (float)-4.370385,0);
				//human.transform.position = DB.leader_position;
				//human.GetComponent<Animator>().SetFloat("MoveX", DB.leader_direction.x);
				//human.GetComponent<Animator>().SetFloat("MoveY", DB.leader_direction.y);
				Application.LoadLevel (3);
			}
		}
	}
}
