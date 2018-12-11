using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControlMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Button_start()
    {
        Application.LoadLevel(1);
    }

    public void Button_Back()
    {
        Application.LoadLevel(0);
    }

    public void Button_first()
    {
		DB.startgame1 = true;
        Application.LoadLevel(15);
    }

    public void Button_second()
    {
		DB.startgame2 = true;
        Application.LoadLevel(3);
    }
    public void Button_third()
    {
        Application.LoadLevel(4);
    }

    public void Button_cast()
    {
        Application.LoadLevel(5);
    }
}
