using UnityEngine;
using System;
using System.Collections.Generic;

public class WinContestActivity{

	public string contestName;
	public int contestId;
	public int contestWeek; //시험 본 주차
	public string contestType;
	public int contestStatus; //1:시험접수,2:채점중,3:합격
	public bool contestWinFlag;
	public int contestPrize; //1st prize,2nd prize..

	public WinContestActivity()
	{

	}

	public WinContestActivity(string contestName, int contestId, int contestWeek, string contestType, int contestStatus, bool contestWinFlag, int contestPrize)
	{
		this.contestName = contestName;
		this.contestId = contestId;
		this.contestWeek = contestWeek;
		this.contestType = contestType;
		this.contestStatus = contestStatus;
		this.contestWinFlag = contestWinFlag;
		this.contestPrize = contestPrize;
	}
}
