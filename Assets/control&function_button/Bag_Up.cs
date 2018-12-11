using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI; 

public class Bag_Up : MonoBehaviour, IPointerDownHandler {

	public GameObject item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12, item13, item14, item15, item16, item17, item18, item19, item20;	
	public Image image;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnPointerDown(PointerEventData eventData)
	{
		if (!DB.window_mode) {
			if (DB.Bag_position == "") {
				DB.Bag_position = "1";	
				image = item1.GetComponent<Image> ();
				Color yellow = image.color;
				yellow.a = 0.2f;
				image.color	= yellow;
			} else if (DB.Bag_position == "6") {
				DB.Bag_position = "1";
				image = item1.GetComponent<Image> ();
				Color yellow = image.color;
				yellow.a = 0.2f;
				image.color	= yellow;
				image = item6.GetComponent<Image> ();
				yellow = image.color;
				yellow.a = 0;
				image.color	= yellow;
			} else if (DB.Bag_position == "7") {
				DB.Bag_position = "2";
				image = item2.GetComponent<Image> ();
				Color yellow = image.color;
				yellow.a = 0.2f;
				image.color	= yellow;
				image = item7.GetComponent<Image> ();
				yellow = image.color;
				yellow.a = 0;
				image.color	= yellow;
			} else if (DB.Bag_position == "8") {
				DB.Bag_position = "3";
				image = item3.GetComponent<Image> ();
				Color yellow = image.color;
				yellow.a = 0.2f;
				image.color	= yellow;
				image = item8.GetComponent<Image> ();
				yellow = image.color;
				yellow.a = 0;
				image.color	= yellow;
			} else if (DB.Bag_position == "9") {
				DB.Bag_position = "4";
				image = item4.GetComponent<Image> ();
				Color yellow = image.color;
				yellow.a = 0.2f;
				image.color	= yellow;
				image = item9.GetComponent<Image> ();
				yellow = image.color;
				yellow.a = 0;
				image.color	= yellow;
			} else if (DB.Bag_position == "10") {
				DB.Bag_position = "5";
				image = item5.GetComponent<Image> ();
				Color yellow = image.color;
				yellow.a = 0.2f;
				image.color	= yellow;
				image = item10.GetComponent<Image> ();
				yellow = image.color;
				yellow.a = 0;
				image.color	= yellow;
			} else if (DB.Bag_position == "11") {
				DB.Bag_position = "6";
				image = item6.GetComponent<Image> ();
				Color yellow = image.color;
				yellow.a = 0.2f;
				image.color	= yellow;
				image = item11.GetComponent<Image> ();
				yellow = image.color;
				yellow.a = 0;
				image.color	= yellow;
			} else if (DB.Bag_position == "12") {
				DB.Bag_position = "7";
				image = item7.GetComponent<Image> ();
				Color yellow = image.color;
				yellow.a = 0.2f;
				image.color	= yellow;
				image = item12.GetComponent<Image> ();
				yellow = image.color;
				yellow.a = 0;
				image.color	= yellow;
			} else if (DB.Bag_position == "13") {
				DB.Bag_position = "8";
				image = item8.GetComponent<Image> ();
				Color yellow = image.color;
				yellow.a = 0.2f;
				image.color	= yellow;
				image = item13.GetComponent<Image> ();
				yellow = image.color;
				yellow.a = 0;
				image.color	= yellow;
			} else if (DB.Bag_position == "14") {
				DB.Bag_position = "9";
				image = item9.GetComponent<Image> ();
				Color yellow = image.color;
				yellow.a = 0.2f;
				image.color	= yellow;
				image = item14.GetComponent<Image> ();
				yellow = image.color;
				yellow.a = 0;
				image.color	= yellow;
			} else if (DB.Bag_position == "15") {
				DB.Bag_position = "10";
				image = item10.GetComponent<Image> ();
				Color yellow = image.color;
				yellow.a = 0.2f;
				image.color	= yellow;
				image = item15.GetComponent<Image> ();
				yellow = image.color;
				yellow.a = 0;
				image.color	= yellow;
			} else if (DB.Bag_position == "16") {
				DB.Bag_position = "11";
				image = item11.GetComponent<Image> ();
				Color yellow = image.color;
				yellow.a = 0.2f;
				image.color	= yellow;
				image = item16.GetComponent<Image> ();
				yellow = image.color;
				yellow.a = 0;
				image.color	= yellow;
			} else if (DB.Bag_position == "17") {
				DB.Bag_position = "12";
				image = item12.GetComponent<Image> ();
				Color yellow = image.color;
				yellow.a = 0.2f;
				image.color	= yellow;
				image = item17.GetComponent<Image> ();
				yellow = image.color;
				yellow.a = 0;
				image.color	= yellow;
			} else if (DB.Bag_position == "18") {
				DB.Bag_position = "13";
				image = item13.GetComponent<Image> ();
				Color yellow = image.color;
				yellow.a = 0.2f;
				image.color	= yellow;
				image = item18.GetComponent<Image> ();
				yellow = image.color;
				yellow.a = 0;
				image.color	= yellow;
			} else if (DB.Bag_position == "19") {
				DB.Bag_position = "14";
				image = item14.GetComponent<Image> ();
				Color yellow = image.color;
				yellow.a = 0.2f;
				image.color	= yellow;
				image = item19.GetComponent<Image> ();
				yellow = image.color;
				yellow.a = 0;
				image.color	= yellow;
			} else if (DB.Bag_position == "20") {
				DB.Bag_position = "15";
				image = item15.GetComponent<Image> ();
				Color yellow = image.color;
				yellow.a = 0.2f;
				image.color	= yellow;
				image = item20.GetComponent<Image> ();
				yellow = image.color;
				yellow.a = 0;
				image.color	= yellow;
			}
		} 
		else {
			DB.window_left = true;
		}
	}
}
