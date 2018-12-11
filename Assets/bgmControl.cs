using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgmControl : MonoBehaviour {

    // Use this for initialization
    public static bgmControl instance;
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
        if (Application.loadedLevel != 6 && Application.loadedLevel != 3)
        {
            Destroy(gameObject);
        }

    }
}
