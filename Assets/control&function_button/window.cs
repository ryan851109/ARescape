using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class window : MonoBehaviour, IPointerDownHandler
{
	private Rect windowPosition;//儲存不可被拖曳的window的位置
	private Rect windowPositionMove;//儲存可被拖曳的window的位置
	private Rect buttonPosition;//儲存button在window內的位置
	private Rect buttonPosition2;//儲存button在window內的位置
	//public Font font;
	public GUISkin choose;
	public GUISkin mySkin;

	public void OnPointerDown(PointerEventData eventData)
	{
		if ( DB.bag_Object[int.Parse(DB.Bag_position)-1] != "" && DB.cango) {
			DB.show = true;
		}
	}
	void Start()
	{
		setWindowPosition ();
		setButtonPosition ();
	}

	private void setWindowPosition()//設定window的位置
	{
		float windowWidth = 1000f;
		float windowHeight = 500f;
		float windowLeft = Screen.width * 0.5f - windowWidth * 0.5f;//window和Game左邊的距離，目前設定的值會讓window顯示在螢幕正中央
		float windowTop = Screen.height * 0.5f - windowHeight * 0.5f;//window和Game上面的距離，目前設定的值會讓window顯示在螢幕正中央
		windowPositionMove = new Rect(windowLeft, windowTop, windowWidth, windowHeight);//將可被拖曳的視窗設定在Game中央

		windowPosition = new Rect(550,250 , windowWidth, windowHeight);//將不可被拖曳的window設定在Game左上角
	}

	private void setButtonPosition()//設定windows內的button位置
	{
		float buttonWidth = 100f;//按鈕的寬度
		float buttonHeight = 50f;//按鈕的高度
		float buttonLeft = windowPosition.width * 0.25f - buttonWidth * 0.25f;//按鈕和window左邊的距離，目前的值會讓button顯示在window的正中央
		float buttonTop = windowPosition.height * 0.75f - buttonHeight * 0.75f;//按鈕和window上面的距離，目前的值會讓button顯示在window的正中央

		buttonPosition = new Rect(buttonLeft, buttonTop, buttonWidth, buttonHeight);//button將會顯示在window正中央
		float buttonLeft2 = windowPosition.width * 0.75f - buttonWidth * 0.25f;//按鈕和window左邊的距離，目前的值會讓button顯示在window的正中央
		float buttonTop2 = windowPosition.height * 0.75f - buttonHeight * 0.75f;//按鈕和window上面的距離，目前的值會讓button顯示在window的正中央

		buttonPosition2 = new Rect(buttonLeft2, buttonTop2, buttonWidth, buttonHeight);//button將會顯示在window正中央
	}

	private void OnGUI()
	{
		GUI.skin = mySkin;
		if (DB.show) {
			DB.window_mode = true;
			if (DB.getgameboy && DB.bag_Object[int.Parse(DB.Bag_position)-1] != "gameboy" && !DB.knife) {
				if (DB.window_left)
					GUI.Window (0, windowPosition, windowEvent_left, "是否對gameboy使用?");
				else
					GUI.Window (0, windowPosition, windowEvent_right, "是否對gameboy使用?");
			} 
			else {
				if (DB.window_left)
					GUI.Window (0, windowPosition, windowEvent_left, "是否使用?");
				else
					GUI.Window (0, windowPosition, windowEvent_right, "是否使用?");
			}
		}

	}

	private void windowEvent_left(int id)//處理視窗裡面要顯示的文字、按鈕、事件處理。必須要有一個為int的傳入參數
	{
		GUI.skin = choose;
		if (GUI.Button(buttonPosition, "確認"))//在window上顯示按鈕
		{
			Debug.Log("確認");
		}
		GUI.skin = mySkin;
		if (GUI.Button(buttonPosition2, "取消"))//在window上顯示按鈕
		{
			Debug.Log("取消");
		}
	}

	private void windowEvent_right(int id)//處理視窗裡面要顯示的文字、按鈕、事件處理。必須要有一個為int的傳入參數
	{
		GUI.skin = mySkin;
		if (GUI.Button(buttonPosition, "確認"))//在window上顯示按鈕
		{
			Debug.Log("確認");
		}
		GUI.skin = choose;
		if (GUI.Button(buttonPosition2, "取消"))//在window上顯示按鈕
		{
			Debug.Log("取消");
		}
	}
}
