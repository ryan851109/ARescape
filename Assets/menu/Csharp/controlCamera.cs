using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class controlCamera : MonoBehaviour {
	//public GameObject MAINcam, ARcam; //兩個不同的攝影機
	// Use this for initialization
	public GameObject ARcam;
	void Start () {
		if (Application.loadedLevel == 14||Application.loadedLevel == 13||Application.loadedLevel == 8||Application.loadedLevel == 9||Application.loadedLevel == 10||Application.loadedLevel == 11||Application.loadedLevel == 7) {
			VuforiaARController vuforia = VuforiaARController.Instance;

			if (vuforia != null)
				vuforia.RegisterVuforiaStartedCallback(SetAutofocus);
			ARcam.SetActive (true);

		} else {
			ARcam.SetActive (false);
		}
		//MAINcamera_off ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}



	void OnApplicationPause(bool pause)
	{
		if (!pause)
		{
			// App resumed
			//if (mVuforiaStarted)
			//{
				// App resumed and vuforia already started
				// but lets start it again...
				SetAutofocus(); // This is done because some android devices lose the auto focus after resume
				// this was a bug in vuforia 4 and 5. I haven't checked 6, but the code is harmless anyway
			//}
		}
	}

	private void SetAutofocus()
	{
		if (CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO))
		{
			Debug.Log("Autofocus set");
		}
		else
		{
			// never actually seen a device that doesn't support this, but just in case
			Debug.Log("this device doesn't support auto focus");
		}
	}

	/*
	private void SearchforGames()
	{
		if (playerPrefabIndex == 0)
		{
			TeacherVersion = true;
			VuforiaRuntime.Instance.InitVuforia(); // This is how you turn vuforia on!
			matchMaker.CreateMatch(GameName, GameSize, true, "", "", "", 0, 0, OnMatchCreate);
		}
		else
		{
			matchName = GameName;
			matchMaker.JoinMatch((UnityEngine.Networking.Types.NetworkID)GameID, "", "", "", 0, 0, OnMatchJoined);
		}
	}*/

	/*void ARcamera_off(){
		ARcam.SetActive (false);
		MAINcam.SetActive (true);
	}
	void MAINcamera_off(){
		ARcam.SetActive (true);
		MAINcam.SetActive (false);
	}*/
}
