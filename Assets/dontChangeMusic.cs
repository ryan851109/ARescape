using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontChangeMusic : MonoBehaviour {

	// Use this for initialization
	public static dontChangeMusic instance;
	// Use this for initialization
	void Start()
	{
		StartCoroutine(WaitAndPrint (47.0f));
	}
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
	void Update () {

		if(Application.loadedLevel != 0 && Application.loadedLevel != 1)
		{
			Destroy(gameObject);
		}

	}

	private IEnumerator WaitAndPrint(float waitTime)
	{
		yield return new WaitForSeconds(waitTime);
	}
}