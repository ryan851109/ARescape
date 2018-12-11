using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioControl : MonoBehaviour {

    public static audioControl instance;
    // Use this for initialization
    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(transform.gameObject);
        }
    }


    // Update is called once per frame
    void Update()
    {

        if (Application.loadedLevel != 6 && Application.loadedLevel != 2)
        {
            Destroy(gameObject);
        }

    }
}