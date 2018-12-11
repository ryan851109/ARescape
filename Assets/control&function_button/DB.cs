using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DB
{
    public static int now_scense, pre_scense;
    public static bool backpack_mode = false;
    public static Vector3 leader_position = new Vector3((float)-0.05976188, (float)-4.370385,0);
    public static Vector3 leader_direction = new Vector3(0, 0, 0);
	public static bool aButton = false, bButton = false;
	public static string curTag = "";
	public static string Bag_position = "";
	public static bool myTrackable = false;
	public static string[] bag_Object = new string[20]{"","","","","","","","","","","","","","","","","","","",""};
	public static bool cango = true;
	public static bool window_mode = false;
	public static bool window_left = true;
	public static bool item_use = false;
	public static bool show = false;
	public static bool[] is_touch = new bool[20]{false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false};
	public static bool getgameboy = false,ball = false,sofa = false,shelf = false,piano = false,cupboard = false, knigeINfiredoor = false,knife = false;
	public static bool hastalkto_oldman = false;
	public static int arprescene;
	public static bool startgame1 = true;
	public static bool startgame2 = true;
	public static bool movie_start = false;
	public static bool firstEnter = true;
}
