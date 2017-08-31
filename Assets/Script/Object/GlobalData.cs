using UnityEngine;
using System;
using System.Collections.Generic;

public class GlobalData: MonoBehaviour {
	public static GlobalData instance;

	public void Awake()  
	{  
		GlobalData.instance = this;  
	}

	public static string accountCreatedTime;
	//int playTime;
	public static int playCreateCount;
	public static int playWeekCount;
	public static int playEndingCount;

	public static List<CharacterData> characterDataList = new List<CharacterData>();

	public static int sound;
	//bool speed;

	public GlobalData ()
	{
	}

}

