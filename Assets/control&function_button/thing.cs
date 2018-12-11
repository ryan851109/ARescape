using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class thing : MonoBehaviour {

	public GameObject[] item = new GameObject[20];
	public Image image;
	public Sprite ball,gameboy,sofa,piano,cupboard,shelf,knife,knife2;
	// Use this for initialization
	void Start () {
		for (int i = 0; i < 20; i++) {
			if (DB.bag_Object[i] != "") {
				switch(DB.bag_Object[i]){
				case "desk":
					image = item[i].GetComponent<Image>();
					image.sprite = ball;
					break;
				case "gameboy":
					image = item[i].GetComponent<Image>();
					image.sprite = gameboy;
					break;
				case "sofa":
					image = item[i].GetComponent<Image>();
					image.sprite = sofa;
					break;
				case "piano":
					image = item[i].GetComponent<Image>();
					image.sprite = piano;
					break;
				case "cupboard":
					image = item[i].GetComponent<Image>();
					image.sprite = cupboard;
					break;
				case "shelf":
					image = item[i].GetComponent<Image>();
					image.sprite = shelf;
					break;
				case "knife":
					image = item[i].GetComponent<Image>();
					image.sprite = knife;
					break;
				case "knifeinfiredoor":
					image = item[i].GetComponent<Image>();
					image.sprite = knife2;
					break;
				}
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
		
}
