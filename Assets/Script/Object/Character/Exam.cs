using UnityEngine;
using System;
using System.Collections.Generic;

public class Exam{

    public string examName;
    public int examId;
    public int examWeek; //시험 본 주차
    public string examType; //eng:영어관련
    public int examStatus; //1:시험접수,2:채점중,3:합격
	public int examScore;
	public int examRCScore;
	public int examLCScore;
    public bool examPassFlag;

    public Exam()
    {

    }

	public Exam(string examName, int examId, int examWeek, string examType, int examStatus, int examScore, int examRCScore, int examLCScore, bool examPassFlag)
    {
        this.examName = examName;
        this.examId = examId;
        this.examWeek = examWeek;
        this.examType = examType;
		this.examStatus = examStatus;
		this.examScore = examScore;
		this.examRCScore = examRCScore;
		this.examLCScore = examLCScore;
        this.examPassFlag = examPassFlag;
    }
    
}
