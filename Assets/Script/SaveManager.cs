using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class SaveManager : MonoBehaviour {


	public static SaveManager instance;

	public void Awake()  
	{  
		SaveManager.instance = this;
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    public static bool InitData()
    {
        //Debug.Log(CharacterData.instance.examList);
        //CharacterData.instance.examList.Add(new Exam("TOEIC", 1, 1, "eng", 2, 400, true));
        //CharacterData.instance.examList.Add(new Exam("TOEFL", 2, 1, "eng", 3, 400, true));

        //Debug.Log("InitData Loaded!");

        return false;
    }

    public static bool CheckGlobalData(){

		if (ES2.Exists ("chui/GlobalData")) {
			Debug.Log ("GlobalData found!");

			//input global data to Globaldata object
			GlobalData.accountCreatedTime = ES2.Load<string>("chui/GlobalData?tag=accountCreatedTime");
			GlobalData.playCreateCount = ES2.Load<int>("chui/GlobalData?tag=playCreateCount");
			GlobalData.playWeekCount = ES2.Load<int>("chui/GlobalData?tag=playWeekCount");
			GlobalData.playEndingCount = ES2.Load<int>("chui/GlobalData?tag=playEndingCount");
			//GlobalData.sound = ES2.Load<int>("chui/GlobalData?tag=sound");

			//GlobalData.characterDataList = JsonUtility.FromJson<List<CharacterData>> (ES2.Load<string> ("chui/GlobalData?tag=characterDataList"));

			return true;
		} else {
			Debug.Log ("Create New Data!");

			ES2.Save(DateTime.Now.ToString("yyyyMMddHHmmss"),  "chui/GlobalData?tag=accountCreatedTime&encrypt=true");
			ES2.Save(0,  "chui/GlobalData?tag=playCreateCount&encrypt=true");
			ES2.Save(0,  "chui/GlobalData?tag=playWeekCount&encrypt=true");
			ES2.Save(0,  "chui/GlobalData?tag=playEndingCount&encrypt=true");
			ES2.Save("{}",  "chui/GlobalData?tag=characterDataList&encrypt=true");
			//ES2.Save(1,  "chui/GlobalData?tag=sound&encrypt=true");

			//create static global ojbect & init

			return false;
		}
	}

	public static bool CheckCharacterData(){


		if (ES2.Exists ("chui/CharacterData")) {
			Debug.Log ("CharacterData found!");

			//input character data to CharacterData Object
			CharacterData.instance.name = ES2.Load<string> ("chui/CharacterData?tag=name");
			CharacterData.instance.playWeek = ES2.Load<int> ("chui/CharacterData?tag=playWeek");
			CharacterData.instance.characterCreatedTime = ES2.Load<string> ("chui/CharacterData?tag=characterCreatedTime");
			CharacterData.instance.characterType = ES2.Load<int> ("chui/CharacterData?tag=characterType");
			CharacterData.instance.endurance = ES2.Load<int> ("chui/CharacterData?tag=endurance");
			CharacterData.instance.telent = ES2.Load<int> ("chui/CharacterData?tag=telent");
			CharacterData.instance.effort = ES2.Load<int> ("chui/CharacterData?tag=effort");
			CharacterData.instance.crisisControl = ES2.Load<int> ("chui/CharacterData?tag=crisisControl");
			CharacterData.instance.attraction = ES2.Load<int> ("chui/CharacterData?tag=attraction");
			CharacterData.instance.engReading = ES2.Load<int> ("chui/CharacterData?tag=engReading");
			CharacterData.instance.engListening = ES2.Load<int> ("chui/CharacterData?tag=engListening");
			CharacterData.instance.engVoca = ES2.Load<int> ("chui/CharacterData?tag=engVoca");
			CharacterData.instance.engSpeaking = ES2.Load<int> ("chui/CharacterData?tag=engSpeaking");
			CharacterData.instance.inteliSpeaking = ES2.Load<int> ("chui/CharacterData?tag=inteliSpeaking");
			CharacterData.instance.inteliWriting = ES2.Load<int> ("chui/CharacterData?tag=inteliWriting");
			CharacterData.instance.computerSkill = ES2.Load<int> ("chui/CharacterData?tag=computerSkill");
			CharacterData.instance.jobAbility = ES2.Load<int> ("chui/CharacterData?tag=jobAbility");
			CharacterData.instance.documentWriting = ES2.Load<int> ("chui/CharacterData?tag=documentWriting");
			CharacterData.instance.history = ES2.Load<int> ("chui/CharacterData?tag=history");
			CharacterData.instance.leadership = ES2.Load<int> ("chui/CharacterData?tag=leadership");
			CharacterData.instance.logical = ES2.Load<int> ("chui/CharacterData?tag=logical");
			CharacterData.instance.analytical = ES2.Load<int> ("chui/CharacterData?tag=analytical");
			CharacterData.instance.friendship = ES2.Load<int> ("chui/CharacterData?tag=friendship");
			CharacterData.instance.totalMoney = ES2.Load<int> ("chui/CharacterData?tag=totalMoney");
			CharacterData.instance.nowMoney = ES2.Load<int> ("chui/CharacterData?tag=nowMoney");
			CharacterData.instance.totalStamina = ES2.Load<int> ("chui/CharacterData?tag=totalStamina");
			CharacterData.instance.nowStamina = ES2.Load<int> ("chui/CharacterData?tag=nowStamina");
			CharacterData.instance.condition = ES2.Load<int> ("chui/CharacterData?tag=condition");
			CharacterData.instance.luck = ES2.Load<int> ("chui/CharacterData?tag=luck");
			CharacterData.instance.tryCount = ES2.Load<int> ("chui/CharacterData?tag=tryCount");

			// messageList JSON 처리
			CharacterData.instance.examList.Clear();
			string tmpExamListStr = ES2.Load<string>("chui/CharacterData?tag=examList");
			if(tmpExamListStr!="")
				foreach (var item in tmpExamListStr.Split('|')){
					CharacterData.instance.examList.Add(JsonUtility.FromJson<Exam>(item));
				}


			// qualificationList JSON 처리
			CharacterData.instance.qualificationList.Clear();
			string tmpQualificationListStr = ES2.Load<string>("chui/CharacterData?tag=qualificationList");
			if(tmpQualificationListStr!="")
				foreach (var item in tmpQualificationListStr.Split('|')){
					CharacterData.instance.qualificationList.Add(JsonUtility.FromJson<Qualification>(item));
				}
					

			// winContestActivityList JSON 처리
			CharacterData.instance.winContestActivityList.Clear();
			string tmpWinInterActivityListStr = ES2.Load<string>("chui/CharacterData?tag=winContestActivityList");
			if(tmpWinInterActivityListStr!="")
				foreach (var item in tmpWinInterActivityListStr.Split('|')){
					CharacterData.instance.winContestActivityList.Add(JsonUtility.FromJson<WinContestActivity>(item));
				}


			// winInterActivityList JSON 처리
			CharacterData.instance.winInterActivityList.Clear();
			string tmpWinContestActivityListStr = ES2.Load<string>("chui/CharacterData?tag=winInterActivityList");
			if(tmpWinContestActivityListStr!="")
				foreach (var item in tmpWinContestActivityListStr.Split('|')){
					CharacterData.instance.winInterActivityList.Add(JsonUtility.FromJson<WinInterActivity>(item));
				}

			CharacterData.instance.resumeList = JsonUtility.FromJson<List<Resume>> (ES2.Load<string> ("chui/CharacterData?tag=resumeList"));
            CharacterData.instance.tryingList = JsonUtility.FromJson<List<Trying>>(ES2.Load<string>("chui/CharacterData?tag=tryingList"));

            CharacterData.instance.interActivity = ES2.Load<string> ("chui/CharacterData?tag=interActivity");
			CharacterData.instance.contestActivity = ES2.Load<string> ("chui/CharacterData?tag=contestActivity");

			return true;
		} else {
			Debug.Log ("There is no CharacterData. Make new one");
			return false;
		}
	}

	public static bool CreateCharacterData(string name){
		ES2.Save(name,  "chui/CharacterData?tag=name&encrypt=true");
		ES2.Save(0,  "chui/CharacterData?tag=playWeek&encrypt=true");
		ES2.Save(DateTime.Now.ToString("yyyyMMddHHmmss"),  "chui/CharacterData?tag=characterCreatedTime&encrypt=true");
		ES2.Save(1,  "chui/CharacterData?tag=characterType&encrypt=true");
		ES2.Save(1,  "chui/CharacterData?tag=endurance&encrypt=true");
		ES2.Save(10, "chui/CharacterData?tag=telent&encrypt=true");
		ES2.Save(0,  "chui/CharacterData?tag=effort&encrypt=true");
		ES2.Save(0,  "chui/CharacterData?tag=crisisControl&encrypt=true");
		ES2.Save(0,  "chui/CharacterData?tag=attraction&encrypt=true");
		ES2.Save(0,  "chui/CharacterData?tag=engReading&encrypt=true");
		ES2.Save(0,  "chui/CharacterData?tag=engListening&encrypt=true");
		ES2.Save(0,  "chui/CharacterData?tag=engVoca&encrypt=true");
		ES2.Save(0,  "chui/CharacterData?tag=engSpeaking&encrypt=true");
		ES2.Save(0,  "chui/CharacterData?tag=inteliSpeaking&encrypt=true");
		ES2.Save(0,  "chui/CharacterData?tag=inteliWriting&encrypt=true");
		ES2.Save(0,  "chui/CharacterData?tag=computerSkill&encrypt=true");
		ES2.Save(0,  "chui/CharacterData?tag=jobAbility&encrypt=true");
		ES2.Save(0,  "chui/CharacterData?tag=documentWriting&encrypt=true");
		ES2.Save(0,  "chui/CharacterData?tag=history&encrypt=true");
		ES2.Save(0,  "chui/CharacterData?tag=leadership&encrypt=true");
		ES2.Save(0,  "chui/CharacterData?tag=logical&encrypt=true");
		ES2.Save(0,  "chui/CharacterData?tag=analytical&encrypt=true");
		ES2.Save(0,  "chui/CharacterData?tag=friendship&encrypt=true");
		ES2.Save(100000,  "chui/CharacterData?tag=totalMoney&encrypt=true");
		ES2.Save(100000,  "chui/CharacterData?tag=nowMoney&encrypt=true");
		ES2.Save(1000,  "chui/CharacterData?tag=totalStamina&encrypt=true");
		ES2.Save(1000,  "chui/CharacterData?tag=nowStamina&encrypt=true");
		ES2.Save(100,  "chui/CharacterData?tag=condition&encrypt=true");
		ES2.Save(100,  "chui/CharacterData?tag=luck&encrypt=true");
		ES2.Save(0,  "chui/CharacterData?tag=tryCount&encrypt=true");
		ES2.Save("",  "chui/CharacterData?tag=examList&encrypt=true");
		ES2.Save("",  "chui/CharacterData?tag=qualificationList&encrypt=true");
		ES2.Save("",  "chui/CharacterData?tag=interActivity&encrypt=true");
		ES2.Save("",  "chui/CharacterData?tag=contestActivity&encrypt=true");
		ES2.Save("",  "chui/CharacterData?tag=winInterActivityList&encrypt=true");
		ES2.Save("",  "chui/CharacterData?tag=winContestActivityList&encrypt=true");
		ES2.Save("{}",  "chui/CharacterData?tag=resumeList&encrypt=true");
		ES2.Save("{}",  "chui/CharacterData?tag=tryingList&encrypt=true");
		ES2.Save("{\"messageId\":0,\"receiveDate\":1,\"messageType\":\"system\",\"messageTitle\":\"환영합니다!\",\"messageContents\":\"취준생의 세계에 오신 여러분을 환영합니다. 건승을 기원합니다!\",\"messageSender\":\"시스템\",\"readFlag\":false}|{ \"messageId\":1,\"receiveDate\":2,\"messageType\":\"system\",\"messageTitle\":\"여기는 메시지창입니다\",\"messageContents\":\"메시지 창에서는 여러분에게 유용한 정보와 취업정보, 합격소식을 받아보실 수 있습니다. 놓치지 마세요!\",\"messageSender\":\"system\",\"readFlag\":false}", "chui/CharacterData?tag=messageList&encrypt=true");

		CheckCharacterData();

		return true;
	}
    
	public bool SaveGlobalData(){

		ES2.Save(GlobalData.playCreateCount,  "chui/GlobalData?tag=playCreateCount&encrypt=true");
		ES2.Save(GlobalData.playWeekCount,  "chui/GlobalData?tag=playWeekCount&encrypt=true");
		ES2.Save(GlobalData.playEndingCount,  "chui/GlobalData?tag=playEndingCount&encrypt=true");
		ES2.Save("{}",  "chui/GlobalData?tag=characterDataList&encrypt=true");
		ES2.Save(GlobalData.sound,  "chui/GlobalData?tag=sound&encrypt=true");

		return true;
	}

	public bool SaveCharacterData(){
		ES2.Save(CharacterData.instance.playWeek,  "chui/CharacterData?tag=playWeek&encrypt=true");
		ES2.Save(CharacterData.instance.endurance,  "chui/CharacterData?tag=endurance&encrypt=true");
		ES2.Save(CharacterData.instance.telent, "chui/CharacterData?tag=telent&encrypt=true");
		ES2.Save(CharacterData.instance.effort,  "chui/CharacterData?tag=effort&encrypt=true");
		ES2.Save(CharacterData.instance.crisisControl,  "chui/CharacterData?tag=crisisControl&encrypt=true");
		ES2.Save(CharacterData.instance.attraction,  "chui/CharacterData?tag=attraction&encrypt=true");
		ES2.Save(CharacterData.instance.engReading,  "chui/CharacterData?tag=engReading&encrypt=true");
		ES2.Save(CharacterData.instance.engListening,  "chui/CharacterData?tag=engListening&encrypt=true");
		ES2.Save(CharacterData.instance.engVoca,  "chui/CharacterData?tag=engVoca&encrypt=true");
		ES2.Save(CharacterData.instance.engSpeaking,  "chui/CharacterData?tag=engSpeaking&encrypt=true");
		ES2.Save(CharacterData.instance.inteliSpeaking,  "chui/CharacterData?tag=inteliSpeaking&encrypt=true");
		ES2.Save(CharacterData.instance.inteliWriting,  "chui/CharacterData?tag=inteliWriting&encrypt=true");
		ES2.Save(CharacterData.instance.computerSkill,  "chui/CharacterData?tag=computerSkill&encrypt=true");
		ES2.Save(CharacterData.instance.jobAbility,  "chui/CharacterData?tag=jobAbility&encrypt=true");
		ES2.Save(CharacterData.instance.documentWriting,  "chui/CharacterData?tag=documentWriting&encrypt=true");
		ES2.Save(CharacterData.instance.history,  "chui/CharacterData?tag=history&encrypt=true");
		ES2.Save(CharacterData.instance.leadership,  "chui/CharacterData?tag=leadership&encrypt=true");
		ES2.Save(CharacterData.instance.logical,  "chui/CharacterData?tag=logical&encrypt=true");
		ES2.Save(CharacterData.instance.analytical,  "chui/CharacterData?tag=analytical&encrypt=true");
		ES2.Save(CharacterData.instance.friendship,  "chui/CharacterData?tag=friendship&encrypt=true");
		ES2.Save(CharacterData.instance.totalMoney,  "chui/CharacterData?tag=totalMoney&encrypt=true");
		ES2.Save(CharacterData.instance.nowMoney,  "chui/CharacterData?tag=nowMoney&encrypt=true");
		ES2.Save(CharacterData.instance.totalStamina,  "chui/CharacterData?tag=totalStamina&encrypt=true");
		ES2.Save(CharacterData.instance.nowStamina,  "chui/CharacterData?tag=nowStamina&encrypt=true");
		ES2.Save(CharacterData.instance.condition,  "chui/CharacterData?tag=condition&encrypt=true");
		ES2.Save(CharacterData.instance.luck,  "chui/CharacterData?tag=luck&encrypt=true");
		ES2.Save(CharacterData.instance.tryCount,  "chui/CharacterData?tag=tryCount&encrypt=true");

        // messageList JSON 처리
        string tmpExamListStr = "";
        foreach (var item in CharacterData.instance.examList){
            tmpExamListStr = tmpExamListStr + JsonUtility.ToJson(item) + "|";
        }
        if (tmpExamListStr != ""){
            tmpExamListStr = tmpExamListStr.Substring(0, tmpExamListStr.Length - 1);
        }
        ES2.Save(tmpExamListStr,  "chui/CharacterData?tag=examList&encrypt=true");

		// qualificationList JSON 처리
		string tmpQualificationListStr = "";
		foreach (var item in CharacterData.instance.qualificationList){
			tmpQualificationListStr = tmpQualificationListStr + JsonUtility.ToJson(item) + "|";
		}
		if (tmpQualificationListStr != ""){
			tmpQualificationListStr = tmpQualificationListStr.Substring(0, tmpQualificationListStr.Length - 1);
		}
		ES2.Save(tmpQualificationListStr,  "chui/CharacterData?tag=qualificationList&encrypt=true");

		// winInterActivityList JSON 처리
		string tmpWinInterActivityListStr = "";
		foreach (var item in CharacterData.instance.winInterActivityList){
			tmpWinInterActivityListStr = tmpWinInterActivityListStr + JsonUtility.ToJson(item) + "|";
		}
		if (tmpWinInterActivityListStr != ""){
			tmpWinInterActivityListStr = tmpWinInterActivityListStr.Substring(0, tmpWinInterActivityListStr.Length - 1);
		}
		ES2.Save(tmpWinInterActivityListStr,  "chui/CharacterData?tag=winInterActivityList&encrypt=true");

		// winContestActivityList JSON 처리
		string tmpWinContestActivityListStr = "";
		foreach (var item in CharacterData.instance.winContestActivityList){
			tmpWinContestActivityListStr = tmpWinContestActivityListStr + JsonUtility.ToJson(item) + "|";
		}
		if (tmpWinContestActivityListStr != ""){
			tmpWinContestActivityListStr = tmpWinContestActivityListStr.Substring(0, tmpWinContestActivityListStr.Length - 1);
		}
		ES2.Save(tmpWinContestActivityListStr,  "chui/CharacterData?tag=winContestActivityList&encrypt=true");


		ES2.Save(CharacterData.instance.interActivity,  "chui/CharacterData?tag=interActivity&encrypt=true");
		ES2.Save(CharacterData.instance.contestActivity,  "chui/CharacterData?tag=contestActivity&encrypt=true");

		ES2.Save("{}",  "chui/CharacterData?tag=resumeList&encrypt=true");
		ES2.Save("{}",  "chui/CharacterData?tag=tryingList&encrypt=true");
        
		CheckCharacterData();

		return true;
	}

    public bool ResetGlobalData()
    {
        if (ES2.Exists("chui/GlobalData"))
        {
            Debug.Log("GlobalData found! This data will delete");
            ES2.Delete("chui/GlobalData");
        }

        return true;
    }

    public bool ResetCharacterData()
    {
        if (ES2.Exists("chui/CharacterData"))
        {
            Debug.Log("CharacterData found! This data will delete");
            ES2.Delete("chui/CharacterData");
        }
        return true;
    }
}
