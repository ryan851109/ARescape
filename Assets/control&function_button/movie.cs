using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movie : MonoBehaviour {
	public GameObject background;
	// Use this for initialization
	void Start () {
		if (!DB.movie_start) {
			StartCoroutine (WaitAndPrint (1.0f));
			DB.movie_start = true;
		}
		else
			Destroy (background);
	}
	
	// Update is called once per frame
	void Update () {

	}

	private IEnumerator WaitAndPrint(float waitTime)
	{
		Handheld.PlayFullScreenMovie("Produce.mp4", Color.black, FullScreenMovieControlMode.CancelOnInput);
		yield return new WaitForSeconds(waitTime);
		Destroy (background);
	}
}
