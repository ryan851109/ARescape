using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class set_position : MonoBehaviour {

    public GameObject leader,b_button;
    public Animator animator;
    // Use this for initialization
    void Start () {
        leader.transform.position = DB.leader_position;
        animator.GetComponent<Animator>().SetFloat("MoveX", DB.leader_direction.x);
        animator.GetComponent<Animator>().SetFloat("MoveY", DB.leader_direction.y);
    }
	
	// Update is called once per frame
	void Update () {
        DB.leader_position = leader.transform.position;
    }
}
