using UnityEngine;
using System.Collections;

//Grabber.cs for Unity by klasik1da

public class Grabber : MonoBehaviour {

	public static int screenW; //Use "Grabber.screenW" for screen width
	public static int screenH; //Use "Grabber.screenH" for screen height

	void Update ()
	//My Unity games play in either Portrait or Landscape mode so i use the Update function
	//I know i can just use the Start function and find dimensions once but thats MY PROBLEM
	{
		screenW = Screen.width;
		screenH = Screen.height;
	}
}
