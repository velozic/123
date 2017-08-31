using UnityEngine;
using System.Collections;

public class PlayAction : MonoBehaviour {
	int valueChange;
	string actionresult="";
	public string ActionType;
	public void OnClick(){
		PanelManager.instance.CloseAllPanel ();

		PanelManager.instance.action_confirm_panel.SetActive(false);
		PanelManager.instance.menu_panel.SetActive(false);

		PanelManager.instance.dialog_panel.SetActive (true);
		PanelManager.instance.dim_panel.SetActive(true);
        
		switch(ActionType) {
			case "그냥 쉬기":
				if(CharacterData.instance.nowMoney<0) {
					
				}
				그냥_쉬기();
				break;
			case "국내 여행":
				if(CharacterData.instance.nowMoney<0) {
					PanelManager.instance.AlertPanel("ㅜㅜ", "국내여행을 하기 위한 돈이 부족합니다", "ㅜㅜ");
				}
				국내_여행();
				break;
			case "해외 여행":
				if(CharacterData.instance.nowMoney<0) {
					PanelManager.instance.AlertPanel("ㅜㅜ", "해외여행을 하기 위한 돈이 부족합니다", "ㅜㅜ");
				}
				해외_여행();
				break;
			case "인터넷 서핑":
				if(CharacterData.instance.nowMoney<0) {
					
				}
				인터넷_서핑();
				break;
			case "개인 운동":
				if(CharacterData.instance.nowMoney<0) {
					
				}
				개인_운동();
				break;
			case "PT운동":
				if(CharacterData.instance.nowMoney<0) {
					
				}
				PT운동();
				break;
			case "단순알바":
				if(CharacterData.instance.nowMoney<0) {
					
				}
				단순알바();
				break;
			case "번역알바":
				if(CharacterData.instance.nowMoney<0) {
					
				}
				번역알바();
				break;
			case "사무직 알바":
				if(CharacterData.instance.nowMoney<0) {
					
				}
				사무직_알바();
				break;
			case "생동성 알바":
				if(CharacterData.instance.nowMoney<0) {
					
				}
				생동성_알바();
				break;
			case "콜센터 알바":
				if(CharacterData.instance.nowMoney<0) {
					
				}
				콜센터_알바();
				break;
			case "영어책":
				if(CharacterData.instance.nowMoney<0) {
					
				}
				영어책();
				break;
			case "영어인강":
				if(CharacterData.instance.nowMoney<0) {
					
				}
				영어인강();
				break;
			case "영어 학원":
				if(CharacterData.instance.nowMoney<0) {
					
				}
				영어_학원();
				break;
			case "회화 학원":
				if(CharacterData.instance.nowMoney<0) {
					
				}
				회화_학원();
				break;
			case "독서":
				if(CharacterData.instance.nowMoney<0) {
					
				}
				독서();
				break;
			case "문서작성공부":
				if(CharacterData.instance.nowMoney<0) {
					
				}
				문서작성공부();
				break;
			case "한국사공부":
				if(CharacterData.instance.nowMoney<0) {
					
				}
				한국사공부();
				break;
			case "리더쉽 공부":
				if(CharacterData.instance.nowMoney<0) {
					
				}
				리더쉽_공부();
				break;
			case "논리력 공부":
				if(CharacterData.instance.nowMoney<0) {
					
				}
				논리력_공부();
				break;
			case "분석능력 공부":
				if(CharacterData.instance.nowMoney<0) {
					
				}
				분석능력_공부();
				break;
			case "친화력 공부":
				if(CharacterData.instance.nowMoney<0) {
					
				}
				친화력_공부();
				break;
			case "영어 스터디":
				if(CharacterData.instance.nowMoney<0) {
					
				}
			 	영어_스터디();
				break;
			case "회화 스터디":
				if(CharacterData.instance.nowMoney<0) {
					
				}
				회화_스터디();
				break;
			case "취업 스터디":
				if(CharacterData.instance.nowMoney<0) {
					
				}
				취업_스터디();
				break;
			case "취업 학원":
				if(CharacterData.instance.nowMoney<0) {
					
				}
				취업_학원();
				break;
			case "컴퓨터 학원":
				if(CharacterData.instance.nowMoney<0) {
					
				}
				컴퓨터_학원();
				break;
			case "자소서 작성법 인강":
				if(CharacterData.instance.nowMoney<0) {
					
				}
				자소서_작성법_인강();
				break;
			case "자소서 작성법 학원":
				if(CharacterData.instance.nowMoney<0) {
					
				}
				자소서_작성법_학원();
				break;
			case "면접 인강":
				if(CharacterData.instance.nowMoney<0) {
					
				}
				면접_인강();
				break;
			case "면접 학원":
				if(CharacterData.instance.nowMoney<0) {
					
				}
				면접_학원();
				break;	
			case "어학 연수":
				if(CharacterData.instance.nowMoney<0) {
					
				}
				어학_연수();
				break;
			case "마케팅 공모전":
				if(CharacterData.instance.nowMoney<0) {
					
				}
				마케팅_공모전();
				break;
			case "IT 공모전":
				if(CharacterData.instance.nowMoney<0) {
					
				}
				IT_공모전();
				break;
			case "사무 공모전":
				if(CharacterData.instance.nowMoney<0) {
					
				}
				사무_공모전();
				break;
			case "경영 공모전":
				if(CharacterData.instance.nowMoney<0) {
					
				}
				경영_공모전();
				break;
			case "영업 공모전":
				if(CharacterData.instance.nowMoney<0) {
					
				}
				영업_공모전();
				break;
			case "토익":
				if(CharacterData.instance.nowMoney<0) {
					
				}
				토익();
				break;
			case "모의면접":
				if(CharacterData.instance.nowMoney<0) {
					
				}
				모의면접();
				break;
			case "Opic":
				if(CharacterData.instance.nowMoney<0) {
					
				}
				Opic();
				break;
			case "전문성 시험1":
				if(CharacterData.instance.nowMoney<0) {
					
				}
				전문성_시험1();
				break;
			case "전문성 시험2":
				if(CharacterData.instance.nowMoney<0) {
					
				}
				전문성_시험2();
				break;
		}
		SaveManager.instance.SaveCharacterData ();
	}

	/*true는 증가 false는 감소
     밑에서 부터는 액션 입니다. */
	void 그냥_쉬기(){
        CharacterData.instance.playWeek++;
		actionresult = ActionType+" 중 입니다.\n";
		//actionresult = actionresult + CharacterData.instance.NowMoneyChange(true,100,1000);
		actionresult = actionresult + CharacterData.instance.ConditionChange(true, 10, 20);
		actionresult = actionresult + CharacterData.instance.NowStaminaChange(true, 300, 400);
		DialogManager.instance.SetAutoType(actionresult);
	}

	void 국내_여행() {
        CharacterData.instance.playWeek++;
        actionresult = ActionType + "중 입니다.\n";
		actionresult = actionresult + CharacterData.instance.ConditionChange(true, 30, 40);
		actionresult = actionresult + CharacterData.instance.NowStaminaChange(true, 500, 600);
		DialogManager.instance.SetAutoType(actionresult);

	}
	void 해외_여행() {
        CharacterData.instance.playWeek++;
        actionresult = ActionType + "중 입니다.\n";
		actionresult = actionresult + CharacterData.instance.ConditionChange(true, 70, 80);
		actionresult = actionresult + CharacterData.instance.NowStaminaChange(true, 700, 800);
		actionresult = actionresult + CharacterData.instance.EngSpeakingChange(true, 5, 10);
		DialogManager.instance.SetAutoType(actionresult);

	}
	void 인터넷_서핑(){
        CharacterData.instance.playWeek++;
		actionresult = ActionType + "중 입니다.\n";
		actionresult = actionresult + CharacterData.instance.NowStaminaChange(true, 100, 200);
		actionresult = actionresult + CharacterData.instance.ComputerSkillChange(true, 5, 10);
		DialogManager.instance.SetAutoType(actionresult);
	}
	void 개인_운동(){
        CharacterData.instance.playWeek++;
		actionresult = ActionType + "중 입니다.\n";
		actionresult = actionresult + CharacterData.instance.NowStaminaChange(false, 50, 100);
		actionresult = actionresult + CharacterData.instance.TotalStaminaChange(true, 10, 20);
		actionresult = actionresult + CharacterData.instance.EnduranceChange(true, 2, 5);
		actionresult = actionresult + CharacterData.instance.AttractionChange(true, 2, 5);
		DialogManager.instance.SetAutoType(actionresult);
	}
	void PT운동(){
        CharacterData.instance.playWeek++;
		actionresult = ActionType + "중 입니다.\n";
		actionresult = actionresult + CharacterData.instance.NowMoneyChange(false, 30000, 30000);
		actionresult = actionresult + CharacterData.instance.NowStaminaChange(false, 50, 50);
		actionresult = actionresult + CharacterData.instance.TotalStaminaChange(true, 30, 40);
		actionresult = actionresult + CharacterData.instance.EnduranceChange(true, 4, 7);
		actionresult = actionresult + CharacterData.instance.AttractionChange(true, 4, 7);
		DialogManager.instance.SetAutoType (actionresult);
	}
	void 단순알바(){
		actionresult = "";
		actionresult = actionresult + CharacterData.instance.NowStaminaChange(false, 150, 200);
		actionresult = actionresult + CharacterData.instance.NowMoneyChange(true, 350000, 400000);
		actionresult = actionresult + CharacterData.instance.EffortChange(true, 1, 1);
		actionresult = actionresult + CharacterData.instance.ConditionChange(false, 3, 5);
		DialogManager.instance.SetAutoType(actionresult);
	}
	void 번역알바(){
		actionresult = "";
		actionresult = actionresult + CharacterData.instance.NowStaminaChange(false, 200, 250);
		actionresult = actionresult + CharacterData.instance.NowMoneyChange(true, 450000, 500000);
		actionresult = actionresult + CharacterData.instance.EngReadingChange(true, 1, 2);
		actionresult = actionresult + CharacterData.instance.ConditionChange(false, 7, 10);
		DialogManager.instance.SetAutoType(actionresult);
	}
	void 사무직_알바(){
		actionresult = "";
		actionresult = actionresult + CharacterData.instance.NowStaminaChange(false, 200, 250);
		actionresult = actionresult + CharacterData.instance.NowMoneyChange(true, 450000, 500000);
		actionresult = actionresult + CharacterData.instance.ComputerSkillChange(true, 1, 2);
		actionresult = actionresult + CharacterData.instance.ConditionChange(false, 5, 8);
		DialogManager.instance.SetAutoType(actionresult);
	}
	void 생동성_알바(){
		actionresult = "";
		actionresult = actionresult + CharacterData.instance.NowMoneyChange(true, 100, 1000);
		DialogManager.instance.SetAutoType(actionresult);
	}
	void 콜센터_알바(){
		actionresult = "";
		actionresult = actionresult + CharacterData.instance.NowStaminaChange(false, 200, 250);
		actionresult = actionresult + CharacterData.instance.NowMoneyChange(true, 450000, 450000);
		actionresult = actionresult + CharacterData.instance.CrisisControlChange(true, 1, 2);
		actionresult = actionresult + CharacterData.instance.ConditionChange(false, 10, 15);
		DialogManager.instance.SetAutoType(actionresult);
	}
	void 영어책(){
		actionresult = "";
		actionresult = actionresult + CharacterData.instance.NowStaminaChange(false, 50, 100);
		actionresult = actionresult + CharacterData.instance.NowMoneyChange(false, 5000, 5000);
		actionresult = actionresult + CharacterData.instance.EngReadingChange(true, 5, 10);
		actionresult = actionresult + CharacterData.instance.EngVocaChange(true, 5, 10);
		actionresult = actionresult + CharacterData.instance.ConditionChange(false, 2, 4);
		DialogManager.instance.SetAutoType(actionresult);
	}
	void 영어인강(){
		actionresult = "";
		actionresult = actionresult + CharacterData.instance.NowStaminaChange(false, 50, 100);
		actionresult = actionresult + CharacterData.instance.NowMoneyChange(false, 15000, 15000);
		actionresult = actionresult + CharacterData.instance.EngReadingChange(true, 15, 20);
		actionresult = actionresult + CharacterData.instance.EngVocaChange(true, 15, 20);
		actionresult = actionresult + CharacterData.instance.EngLitheningChange(true, 5, 10);
		actionresult = actionresult + CharacterData.instance.ConditionChange(false, 2, 4);
		DialogManager.instance.SetAutoType(actionresult);
	}
	void 독서(){
		actionresult = "";
		actionresult = actionresult + CharacterData.instance.NowStaminaChange(true, 100, 150);
		actionresult = actionresult + CharacterData.instance.InteliWritingChange(true, 1, 3);
		actionresult = actionresult + CharacterData.instance.InteliSpeakingChange(true, 1, 2);
		actionresult = actionresult + CharacterData.instance.ConditionChange(true, 5, 10);
		DialogManager.instance.SetAutoType(actionresult);
	}
	void 문서작성공부(){
		actionresult = "";
		actionresult = actionresult + CharacterData.instance.NowMoneyChange(true, 100, 1000);
		DialogManager.instance.SetAutoType(actionresult);
		//MainManager.instance.RefreshSceneObject();
	}
	void 한국사공부(){
		actionresult = "";
		actionresult = actionresult + CharacterData.instance.NowMoneyChange(true, 100, 1000);
		DialogManager.instance.SetAutoType(actionresult);
		//MainManager.instance.RefreshSceneObject();
	}
	void 리더쉽_공부(){
		actionresult = "";
		actionresult = actionresult + CharacterData.instance.NowMoneyChange(true, 100, 1000);
		DialogManager.instance.SetAutoType(actionresult);
		//MainManager.instance.RefreshSceneObject();
	}
	void 논리력_공부(){
		actionresult = "";
		actionresult = actionresult + CharacterData.instance.NowMoneyChange(true, 100, 1000);
		DialogManager.instance.SetAutoType(actionresult);
		//MainManager.instance.RefreshSceneObject();
	}
	void 분석능력_공부(){
		actionresult = "";
		actionresult = actionresult + CharacterData.instance.NowMoneyChange(true, 100, 1000);
		DialogManager.instance.SetAutoType(actionresult);
		//MainManager.instance.RefreshSceneObject();
	}
	void 친화력_공부(){
		actionresult = "";
		actionresult = actionresult + CharacterData.instance.NowMoneyChange(true, 100, 1000);
		DialogManager.instance.SetAutoType(actionresult);
		//MainManager.instance.RefreshSceneObject();
	}
	void 영어_스터디(){
		actionresult = "";
		actionresult = actionresult + CharacterData.instance.NowMoneyChange(true, 100, 1000);
		DialogManager.instance.SetAutoType(actionresult);
		//MainManager.instance.RefreshSceneObject();
	}
	void 회화_스터디(){
		actionresult = "";
		actionresult = actionresult + CharacterData.instance.NowMoneyChange(true, 100, 1000);
		DialogManager.instance.SetAutoType(actionresult);
		//MainManager.instance.RefreshSceneObject();
	}
	void 취업_스터디(){
		actionresult = "";
		actionresult = actionresult + CharacterData.instance.NowMoneyChange(true, 100, 1000);
		DialogManager.instance.SetAutoType(actionresult);
		//MainManager.instance.RefreshSceneObject();
	}
	void 영어_학원(){
		actionresult = "";
		actionresult = actionresult + CharacterData.instance.NowMoneyChange(true, 100, 1000);
		DialogManager.instance.SetAutoType(actionresult);
		//MainManager.instance.RefreshSceneObject();
	}
	void 회화_학원(){
		actionresult = "";
		actionresult = actionresult + CharacterData.instance.NowMoneyChange(true, 100, 1000);
		DialogManager.instance.SetAutoType(actionresult);
		//MainManager.instance.RefreshSceneObject();
	}

	void 취업_학원(){
		actionresult = "";
		actionresult = actionresult + CharacterData.instance.NowMoneyChange(true, 100, 1000);
		DialogManager.instance.SetAutoType(actionresult);
		//MainManager.instance.RefreshSceneObject();
	}
	void 컴퓨터_학원(){
		actionresult = "";
		actionresult = actionresult + CharacterData.instance.NowMoneyChange(true, 100, 1000);
		DialogManager.instance.SetAutoType(actionresult);
		//MainManager.instance.RefreshSceneObject();
	}
	void 자소서_작성법_인강() {
		actionresult = "";
		actionresult = actionresult + CharacterData.instance.NowMoneyChange(false, 100, 1000);
		DialogManager.instance.SetAutoType(actionresult);
		//MainManager.instance.RefreshSceneObject();
	}
	void 자소서_작성법_학원() {
		actionresult = "";
		actionresult = actionresult + CharacterData.instance.NowMoneyChange(false, 100, 1000);
		DialogManager.instance.SetAutoType(actionresult);
		//MainManager.instance.RefreshSceneObject();
	}
	void 면접_인강() {
		actionresult = "";
		actionresult = actionresult + CharacterData.instance.NowMoneyChange(false, 100, 1000);
		DialogManager.instance.SetAutoType(actionresult);
		//MainManager.instance.RefreshSceneObject();
	}
	void 면접_학원() {
		actionresult = "";
		actionresult = actionresult + CharacterData.instance.NowMoneyChange(false, 100, 1000);
		DialogManager.instance.SetAutoType(actionresult);
		//MainManager.instance.RefreshSceneObject();
	}	
	void 어학_연수(){

		CharacterData.instance.winInterActivityList.Add (new WinInterActivity ("InterName", 1, CharacterData.instance.playWeek, "abroad", 1));
		//CharacterData.instance.winInterActivityList.Add (new WinInterActivity ("InterName2", 1, CharacterData.instance.playWeek, "inter", 1));

		actionresult = "";
		actionresult = actionresult + CharacterData.instance.NowMoneyChange(true, 100, 1000);
		DialogManager.instance.SetAutoType(actionresult);
		//MainManager.instance.RefreshSceneObject();

	}
	void 마케팅_공모전(){
		CharacterData.instance.winContestActivityList.Add(new WinContestActivity("contestName",2,CharacterData.instance.playWeek,"marketing", 1, false, 2));
		actionresult = "";
		actionresult = actionresult + CharacterData.instance.NowMoneyChange(true, 100, 1000);
		DialogManager.instance.SetAutoType(actionresult);
		//MainManager.instance.RefreshSceneObject();

	}
	void IT_공모전(){
		actionresult = "";
		actionresult = actionresult + CharacterData.instance.NowMoneyChange(true, 100, 1000);
		DialogManager.instance.SetAutoType(actionresult);
		//MainManager.instance.RefreshSceneObject();
	}
	void 사무_공모전(){
		actionresult = "";
		actionresult = actionresult + CharacterData.instance.NowMoneyChange(true, 100, 1000);
		DialogManager.instance.SetAutoType(actionresult);
		//MainManager.instance.RefreshSceneObject();
	}
	void 경영_공모전(){
		actionresult = "";
		actionresult = actionresult + CharacterData.instance.NowMoneyChange(true, 100, 1000);
		DialogManager.instance.SetAutoType(actionresult);
		//MainManager.instance.RefreshSceneObject();
	}
	void 영업_공모전(){
		actionresult = "";
		actionresult = actionresult + CharacterData.instance.NowMoneyChange(true, 100, 1000);
		DialogManager.instance.SetAutoType(actionresult);
		//MainManager.instance.RefreshSceneObject();
	}
	void 토익(){

		int engReading = CharacterData.instance.engReading;
		double engVocaWeight = 0.9+(CharacterData.instance.engVoca*0.002);
		int engListening = CharacterData.instance.engListening;
		int condition = CharacterData.instance.condition;

		//make lc score
		double engLcWeight = 0;
		if(engListening<20){
			engLcWeight =10;
		}else if (engListening < 40) {
			engLcWeight =8;
		}else if (engListening < 80) {
			engLcWeight =5;
		}else if (engListening < 100) {
			engLcWeight =4;
		}else if (engListening < 120) {
			engLcWeight =3.1;
		}else if (engListening < 140) {
			engLcWeight =2.9;
		}
		double lcScore = engListening * engLcWeight * engVocaWeight * (1-(condition*0.0005));
		Debug.Log (engListening);
		Debug.Log (engLcWeight);
		Debug.Log (engVocaWeight);
		Debug.Log (condition);

		//make rc score
		double engRcWeight = 0;
		if(engReading<20){
			engRcWeight =10;
		}else if (engReading < 40) {
			engRcWeight =8;
		}else if (engReading < 80) {
			engRcWeight =5;
		}else if (engReading < 100) {
			engRcWeight =4;
		}else if (engReading < 120) {
			engRcWeight =3.1;
		}else if (engReading < 140) {
			engRcWeight =2.9;
		}
		double rcScore = engReading * engRcWeight * engVocaWeight * (1-(condition*0.0005));
		Debug.Log (engReading);
		Debug.Log (engRcWeight);
		Debug.Log (engVocaWeight);
		Debug.Log (condition);

		double score = rcScore + lcScore;

		CharacterData.instance.examList.Add(new Exam("TOEIC",1,CharacterData.instance.playWeek,"TOEIC",1,(int)score,(int)rcScore,(int)lcScore,true));

		actionresult = "";
		actionresult = actionresult + CharacterData.instance.NowMoneyChange(true, 100, 1000);
		DialogManager.instance.SetAutoType(actionresult);
		//MainManager.instance.RefreshSceneObject();

	}
	void 모의면접(){
		actionresult = "";
		actionresult = actionresult + CharacterData.instance.NowMoneyChange(true, 100, 1000);
		DialogManager.instance.SetAutoType(actionresult);
		//MainManager.instance.RefreshSceneObject();
	}
	void Opic(){
		actionresult = "";
		actionresult = actionresult + CharacterData.instance.NowMoneyChange(true, 100, 1000);
		DialogManager.instance.SetAutoType(actionresult);
		//MainManager.instance.RefreshSceneObject();
	}
	void 전문성_시험1(){
		actionresult = "";
		actionresult = actionresult + CharacterData.instance.NowMoneyChange(true, 100, 1000);
		DialogManager.instance.SetAutoType(actionresult);
		//MainManager.instance.RefreshSceneObject();
	}
	void 전문성_시험2(){
		actionresult = "";
		actionresult = actionresult + CharacterData.instance.NowMoneyChange(true, 100, 1000);
		DialogManager.instance.SetAutoType(actionresult);
		//MainManager.instance.RefreshSceneObject();
	}

}