using UnityEngine;
using System;
using System.Collections.Generic;

public class Qualification{

	public string qualificationName;
	public int qualificationId;
	public int qualificationWeek; //시험 본 주차
	public string qualificationType; //eng:영어관련
	public int qualificationStatus; //1:시험접수,2:채점중,3:합격
	public int qualificationScore;
	public bool qualificationPassFlag;

	public Qualification()
	{

	}

	public Qualification(string qualificationName, int qualificationId, int qualificationWeek, string qualificationType, int qualificationStatus, int qualificationScore, bool qualificationPassFlag)
	{
		this.qualificationName = qualificationName;
		this.qualificationId = qualificationId;
		this.qualificationWeek = qualificationWeek;
		this.qualificationType = qualificationType;
		this.qualificationStatus = qualificationStatus;
		this.qualificationScore = qualificationScore;
		this.qualificationPassFlag = qualificationPassFlag;
	}
}
