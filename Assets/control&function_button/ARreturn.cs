using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARreturn : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Return_Button()
    {
		Application.LoadLevel(DB.arprescene);
    }
}
