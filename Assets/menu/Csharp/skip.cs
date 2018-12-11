using UnityEngine;
using UnityEngine.UI;

public class skip : MonoBehaviour
{
	public int pressTime = 1;
	public GameObject background;
	public Image image;
	public Sprite image1, image2, image3, image4, image5, image6;

	// Use this for initialization
	void Start()
	{
		image = background.GetComponent<Image>();
		image.sprite = image1;
	}

	// Update is called once per frame
	void Update()
	{

	}
	public void Skip_Button()
	{
		pressTime++;
		switch (pressTime)
		{
		case 1:
			image = background.GetComponent<Image>();
			image.sprite = image2;
			break;
		case 2:
			image = background.GetComponent<Image>();
			image.sprite = image3;
			break;
		case 3:
			image = background.GetComponent<Image>();
			image.sprite = image4;
			break;
		case 4:
			image = background.GetComponent<Image>();
			image.sprite = image5;
			break;
		case 5:
			image = background.GetComponent<Image>();
			image.sprite = image6;
			break;
		case 6:
			Application.LoadLevel(2);
			break;
		}
	}
}