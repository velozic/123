using UnityEngine;
using System;
using System.Collections.Generic;

public class WinInterActivity{

	public string interName;
	public int interId;
	public int interWeek; //시험 본 주차
	public string interType;
	public int interPrize; //1st prize,2nd prize..

	public WinInterActivity()
	{

	}

	public WinInterActivity(string interName, int interId, int interWeek, string interType, int interPrize)
	{
		this.interName = interName;
		this.interId = interId;
		this.interWeek = interWeek;
		this.interType = interType;
		this.interPrize = interPrize;
	}
}
