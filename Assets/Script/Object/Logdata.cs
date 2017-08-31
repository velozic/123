using UnityEngine;
using System;
using System.Collections.Generic;

public class LogData{

	public static LogData instance;

	public void Awake()  
	{  
		LogData.instance = this;  
	}

	public static List<ExamLog> examLogList;
	public static List<TryingLog> tryingLogList;
	public static List<MoneyLog> moneyLogList;
	public static List<ActionLog> actionLogList;


	public LogData ()
	{

	}
}
