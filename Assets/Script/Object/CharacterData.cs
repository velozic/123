using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class CharacterData: MonoBehaviour{

	public static CharacterData instance;

	public void Awake()  
	{  
		CharacterData.instance = this;  
	}

	public string name;
	public int playWeek;
	public string characterCreatedTime;
	public int characterType;
	public int endurance;
	public int telent;
	public int effort;
	public int crisisControl;
	public int attraction;
	public int engReading;
	public int engListening;
	public int engVoca;
	public int engSpeaking;
	public int inteliSpeaking;
	public int inteliWriting;
	public int computerSkill;
	public int jobAbility;
	public int documentWriting;
	public int history;
	public int leadership;
	public int logical;
	public int analytical;
	public int friendship;
	public int totalMoney;
	public int nowMoney;
	public int totalStamina;
	public int nowStamina;
	public int condition;
	public int luck;
	public int tryCount;
	public List<Exam> examList;
	public List<Qualification> qualificationList;
	public string interActivity;
	public string contestActivity;
	public List<WinInterActivity> winInterActivityList;
	public List<WinContestActivity> winContestActivityList;
	public List<Resume> resumeList;
	public List<Trying> tryingList;
    
    public CharacterData ()
	{
        examList = new List<Exam>();
        qualificationList = new List<Qualification>();
        winInterActivityList = new List<WinInterActivity>();
		winContestActivityList = new List<WinContestActivity>();
        resumeList = new List<Resume>();
        tryingList = new List<Trying>();

        Debug.Log("init CharacterData");
    }

	/*
     증가 감소 제어 함수
     현재 스테미나는 0~총 스테미나값
     돈이 증가할때마다 누적금액도 변경되어야한다.
      */

	public string NowMoneyChange(bool plusminus,int minValue, int maxValue)
	{
		int valueChange = UnityEngine.Random.Range(minValue, maxValue);

		if (plusminus == true)
		{
			CharacterData.instance.nowMoney += valueChange;
			return("돈이" + valueChange + "원 늘었다\n");
		}
		else{
			CharacterData.instance.nowMoney -= valueChange;
			return ("돈이" + valueChange + "원 줄었다.\n");
		}
	}
	public string EnduranceChange(bool plusminus, int minValue, int maxValue)
	{
		int valueChange = UnityEngine.Random.Range(minValue, maxValue);
		if (plusminus == true)
		{
			CharacterData.instance.endurance += valueChange;
			return ("인내력이 " + valueChange + " 만큼 늘었다\n");
		}
		else
		{
			CharacterData.instance.endurance -= valueChange;
			return ("인내력이" + valueChange + " 만큼 줄었다.\n");
		}
	}
	public string TelentChange(bool plusminus, int minValue, int maxValue)
	{
		int valueChange = UnityEngine.Random.Range(minValue, maxValue);
		if (plusminus == true)
		{
			CharacterData.instance.telent += valueChange;
			return ("재능이 " + valueChange + " 만큼 늘었다\n");
		}
		else
		{
			CharacterData.instance.telent -= valueChange;
			return ("재능이 " + valueChange + " 만큼 줄었다.\n");
		}
	}
	public string EffortChange(bool plusminus, int minValue, int maxValue)
	{
		int valueChange = UnityEngine.Random.Range(minValue, maxValue);
		if (plusminus == true)
		{
			CharacterData.instance.effort += valueChange;
			return ("노력이 " + valueChange + " 만큼 늘었다\n");
		}
		else
		{
			CharacterData.instance.effort -= valueChange;
			return ("노력이" + valueChange + " 만큼 줄었다.\n");
		}
	}
	public string CrisisControlChange(bool plusminus, int minValue, int maxValue)
	{
		int valueChange = UnityEngine.Random.Range(minValue, maxValue);
		if (plusminus == true)
		{
			CharacterData.instance.crisisControl += valueChange;
			return ("위기대처능력이 " + valueChange + " 만큼 늘었다\n");
		}
		else
		{
			CharacterData.instance.crisisControl -= valueChange;
			return ("위기대처능력이 " + valueChange + " 만큼 줄었다.\n");
		}
	}
	public string AttractionChange(bool plusminus, int minValue, int maxValue)
	{
		int valueChange = UnityEngine.Random.Range(minValue, maxValue);
		if (plusminus == true)
		{
			CharacterData.instance.attraction += valueChange;
			return ("매력이 " + valueChange + " 만큼 늘었다\n");
		}
		else
		{
			CharacterData.instance.attraction -= valueChange;
			return ("매력이 " + valueChange + " 만큼 줄었다.\n");
		}
	}
	public string EngReadingChange(bool plusminus, int minValue, int maxValue)
	{
		int valueChange = UnityEngine.Random.Range(minValue, maxValue);
		if (plusminus == true)
		{
			CharacterData.instance.engReading += valueChange;
			return ("RC가 " + valueChange + " 만큼 늘었다\n");
		}
		else
		{
			CharacterData.instance.engReading -= valueChange;
			return ("RC가 " + valueChange + " 만큼 줄었다.\n");
		}
	}
	public string EngLitheningChange(bool plusminus, int minValue, int maxValue)
	{
		int valueChange = UnityEngine.Random.Range(minValue, maxValue);
		if (plusminus == true)
		{
			CharacterData.instance.engListening += valueChange;
			return ("LC가 " + valueChange + " 만큼 늘었다\n");
		}
		else
		{
			CharacterData.instance.engListening -= valueChange;
			return ("LC가 " + valueChange + " 만큼 줄었다.\n");
		}
	}
	public string EngVocaChange(bool plusminus, int minValue, int maxValue)
	{
		int valueChange = UnityEngine.Random.Range(minValue, maxValue);
		if (plusminus == true)
		{
			CharacterData.instance.engVoca += valueChange;
			return ("보카가 " + valueChange + " 만큼 늘었다\n");
		}
		else
		{
			CharacterData.instance.engVoca -= valueChange;
			return ("보카가 " + valueChange + " 만큼 줄었다.\n");
		}
	}
	public string EngSpeakingChange(bool plusminus, int minValue, int maxValue)
	{
		int valueChange = UnityEngine.Random.Range(minValue, maxValue);
		if (plusminus == true)
		{
			CharacterData.instance.engSpeaking += valueChange;
			return ("스피킹이 " + valueChange + " 만큼 늘었다\n");
		}
		else
		{
			CharacterData.instance.engSpeaking -= valueChange;
			return ("스피킹이 " + valueChange + " 만큼 줄었다.\n");
		}
	}
	public string InteliSpeakingChange(bool plusminus, int minValue, int maxValue)
	{
		int valueChange = UnityEngine.Random.Range(minValue, maxValue);
		if (plusminus == true)
		{
			CharacterData.instance.inteliSpeaking += valueChange;
			return ("화법이 " + valueChange + " 만큼 늘었다\n");
		}
		else
		{
			CharacterData.instance.inteliSpeaking -= valueChange;
			return ("화법이 " + valueChange + " 만큼 줄었다.\n");
		}
	}
	public string InteliWritingChange(bool plusminus, int minValue, int maxValue)
	{
		int valueChange = UnityEngine.Random.Range(minValue, maxValue);
		if (plusminus == true)
		{
			CharacterData.instance.inteliWriting += valueChange;
			return ("글쓰기가 " + valueChange + " 만큼 늘었다\n");
		}
		else
		{
			CharacterData.instance.inteliWriting -= valueChange;
			return ("글쓰기가 " + valueChange + " 만큼 줄었다.\n");
		}
	}
	public string ComputerSkillChange(bool plusminus, int minValue, int maxValue)
	{
		int valueChange = UnityEngine.Random.Range(minValue, maxValue);
		if (plusminus == true)
		{
			CharacterData.instance.computerSkill += valueChange;
			return ("컴퓨터활용능력이 " + valueChange + " 만큼 늘었다\n");
		}
		else
		{
			CharacterData.instance.computerSkill -= valueChange;
			return ("컴퓨터활용능력이 " + valueChange + " 만큼 줄었다.\n");
		}
	}
	public string JobAbilityChange(bool plusminus, int minValue, int maxValue)
	{
		int valueChange = UnityEngine.Random.Range(minValue, maxValue);
		if (plusminus == true)
		{
			CharacterData.instance.jobAbility += valueChange;
			return ("직무역량이 " + valueChange + " 만큼 늘었다\n");
		}
		else
		{
			CharacterData.instance.jobAbility -= valueChange;
			return ("직무역량이 " + valueChange + " 만큼 줄었다.\n");
		}
	}
	public string DocumentWritingChange(bool plusminus, int minValue, int maxValue)
	{
		int valueChange = UnityEngine.Random.Range(minValue, maxValue);
		if (plusminus == true)
		{
			CharacterData.instance.documentWriting += valueChange;
			return ("문서작성능력이 " + valueChange + " 만큼 늘었다\n");
		}
		else
		{
			CharacterData.instance.documentWriting -= valueChange;
			return ("문서작성능력이 " + valueChange + " 만큼 줄었다.\n");
		}
	}
	public string HistoryChange(bool plusminus, int minValue, int maxValue)
	{
		int valueChange = UnityEngine.Random.Range(minValue, maxValue);
		if (plusminus == true)
		{
			CharacterData.instance.history += valueChange;
			return ("한국사가 " + valueChange + " 만큼 늘었다\n");
		}
		else
		{
			CharacterData.instance.history -= valueChange;
			return ("한국사가 " + valueChange + " 만큼 줄었다.\n");
		}
	}
	public string LeadershipChange(bool plusminus, int minValue, int maxValue)
	{
		int valueChange = UnityEngine.Random.Range(minValue, maxValue);
		if (plusminus == true)
		{
			CharacterData.instance.leadership += valueChange;
			return ("리더십이 " + valueChange + " 만큼 늘었다\n");
		}
		else
		{
			CharacterData.instance.leadership -= valueChange;
			return ("리더십이 " + valueChange + " 만큼 줄었다.\n");
		}
	}
	public string LogicalChange(bool plusminus, int minValue, int maxValue)
	{
		int valueChange = UnityEngine.Random.Range(minValue, maxValue);
		if (plusminus == true)
		{
			CharacterData.instance.logical += valueChange;
			return ("사고력이 " + valueChange + " 만큼 늘었다\n");
		}
		else
		{
			CharacterData.instance.logical -= valueChange;
			return ("사고력이 " + valueChange + " 만큼 줄었다.\n");
		}
	}
	public string AnalyticalChange(bool plusminus, int minValue, int maxValue)
	{
		int valueChange = UnityEngine.Random.Range(minValue, maxValue);
		if (plusminus == true)
		{
			CharacterData.instance.analytical += valueChange;
			return ("분석능력이 " + valueChange + " 만큼 늘었다\n");
		}
		else
		{
			CharacterData.instance.analytical -= valueChange;
			return ("분석능력이 " + valueChange + " 만큼 줄었다.\n");
		}
	}
	public string Friendship(bool plusminus, int minValue, int maxValue)
	{
		int valueChange = UnityEngine.Random.Range(minValue, maxValue);
		if (plusminus == true)
		{
			CharacterData.instance.friendship += valueChange;
			return ("친화력이 " + valueChange + " 만큼 늘었다\n");
		}
		else
		{
			CharacterData.instance.friendship -= valueChange;
			return ("친화력이 " + valueChange + " 만큼 줄었다.\n");
		}
	}
	public string TotalMoneyChange(bool plusminus, int minValue, int maxValue)
	{
		int valueChange = UnityEngine.Random.Range(minValue, maxValue);
		if (plusminus == true)
		{
			CharacterData.instance.totalMoney += valueChange;
			return ("누적 돈이 " + valueChange + " 만큼 늘었다\n");
		}
		else
		{
			CharacterData.instance.totalMoney -= valueChange;
			return ("누적 돈이 " + valueChange + " 만큼 줄었다.\n");
		}
	}
	public string TotalStaminaChange(bool plusminus, int minValue, int maxValue)
	{
		int valueChange = UnityEngine.Random.Range(minValue, maxValue);

		if (plusminus == true)
		{
			CharacterData.instance.totalStamina += valueChange;
			return ("총 스테미너가 " + valueChange + " 만큼 늘었다\n");
		}
		else
		{
			CharacterData.instance.totalStamina -= valueChange;
			return ("총 스테미너가 " + valueChange + " 만큼 줄었다.\n");
		}
	}
	public string NowStaminaChange(bool plusminus, int minValue, int maxValue)
	{
		int valueChange = UnityEngine.Random.Range(minValue, maxValue);
		int variation = (plusminus) ? 1 : -1;

		if(CharacterData.instance.nowStamina+valueChange*variation > CharacterData.instance.totalStamina){
			valueChange = valueChange - (CharacterData.instance.nowStamina + valueChange - CharacterData.instance.totalStamina);
		}

		if (plusminus == true)
		{
			CharacterData.instance.nowStamina += valueChange;
			return ("스테미너가 " + valueChange + " 만큼 늘었다\n");
		}
		else
		{
			CharacterData.instance.nowStamina -= valueChange;
			return ("스테미너가 " + valueChange + " 만큼 줄었다.\n");
		}
	}
	public string ConditionChange(bool plusminus, int minValue, int maxValue)
	{
		int valueChange = UnityEngine.Random.Range(minValue, maxValue);
		int variation = (plusminus) ? 1 : -1;
		if(CharacterData.instance.condition+valueChange*variation > 100){
			valueChange = valueChange - (CharacterData.instance.condition + valueChange - 100);
		}

		if (plusminus == true)
		{
			CharacterData.instance.condition += valueChange;
			return ("컨디션이 " + valueChange + " 만큼 늘었다\n");
		}
		else
		{
			CharacterData.instance.condition -= valueChange;
			return ("컨디션이 " + valueChange + " 만큼 줄었다.\n");
		}
	}
	public string luckChange(bool plusminus, int minValue, int maxValue)
	{
		int valueChange = UnityEngine.Random.Range(minValue, maxValue);

		int variation = (plusminus) ? 1 : -1;
		if(CharacterData.instance.luck+valueChange*variation > 100){
			valueChange = valueChange - (CharacterData.instance.luck + valueChange - 100);
		}

		if (plusminus == true)
		{
			CharacterData.instance.luck += valueChange;
			return ("운이 " + valueChange + " 만큼 늘었다\n");
		}
		else
		{
			CharacterData.instance.luck -= valueChange;
			return ("운이 " + valueChange + " 만큼 줄었다.\n");
		}
	}

	public string GetString() {
		string returnValue="";
		returnValue = returnValue + "/name:" + name;
		returnValue = returnValue + "/playWeek:" + playWeek;
		returnValue = returnValue + "/characterCreatedTime:" + characterCreatedTime;
		returnValue = returnValue + "/endurance:" + endurance;
		returnValue = returnValue + "/telent:" + telent;
		returnValue = returnValue + "/effort:" + effort;
		returnValue = returnValue + "/crisisControl:" + crisisControl;
		returnValue = returnValue + "/attraction:" + attraction;
		returnValue = returnValue + "/engReading:" + engReading;
		returnValue = returnValue + "/engWriting:" + engListening;
		returnValue = returnValue + "/engVoca:" + engVoca;
		returnValue = returnValue + "/engSpeaking:" + engSpeaking;
		returnValue = returnValue + "/inteliSpeaking:" + inteliSpeaking;
		returnValue = returnValue + "/inteliWriting:" + inteliWriting;
		returnValue = returnValue + "/computerSkill:" + computerSkill;
		returnValue = returnValue + "/jobAbility:" + jobAbility;
		returnValue = returnValue + "/documentWriting:" + documentWriting;
		returnValue = returnValue + "/history:" + history;
		returnValue = returnValue + "/leadership:" + leadership;
		returnValue = returnValue + "/logical:" + logical;
		returnValue = returnValue + "/analytical:" + analytical;
		returnValue = returnValue + "/friendship:" + friendship;
		returnValue = returnValue + "/totalMoney:" + totalMoney;
		returnValue = returnValue + "/nowMoney:" + nowMoney;
		returnValue = returnValue + "/totalStamina:" + totalStamina;
		returnValue = returnValue + "/nowStamina:" + nowStamina;
		returnValue = returnValue + "/condition:" + condition;
		returnValue = returnValue + "/luck:" + luck;
		returnValue = returnValue + "/tryCount:" + tryCount;
		returnValue = returnValue + "/interActivity:" + interActivity;
		returnValue = returnValue + "/contestActivity:" + contestActivity;
		return returnValue;
	}
}
