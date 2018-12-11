using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class backpack : MonoBehaviour, IPointerClickHandler
{
    // Use this for initialization
    void Start()
    {
        
    }

    public void OnPointerClick(PointerEventData eventData)
    {
		if (!DB.window_mode) {
			DB.now_scense = Application.loadedLevel;
			if (DB.now_scense != 6) {
				DB.Bag_position = "";
				DB.backpack_mode = true;
				DB.pre_scense = Application.loadedLevel;
				SceneManager.LoadScene (6);
			} else {
				DB.backpack_mode = false;
				SceneManager.LoadScene (DB.pre_scense);
			}
		}
    }

    // Update is called once per frame
    void Update () {
		
	}
}
