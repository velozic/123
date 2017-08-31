using UnityEngine;
using System.Collections;

public class MainManager : MonoBehaviour {

	public static MainManager instance;

	public void Awake()  
	{  
		MainManager.instance = this;
	}

	public MainManager ()
	{
	}

	public void RefreshSceneObject() {
		GameObject.Find ("date_txt").GetComponent<UILabel> ().text = ((CharacterData.instance.playWeek%48)/4+1)+"월 "+(CharacterData.instance.playWeek%4+1) + "주차";

		GameObject.Find ("money_txt").GetComponent<UILabel> ().text = (CharacterData.instance.nowMoney.ToString("#,#"))+" 원";

		if (CharacterData.instance.condition > 70) {
			GameObject.Find ("condition_txt").GetComponent<UILabel> ().text = "좋음";
		} else if (CharacterData.instance.condition > 30) {
			GameObject.Find ("condition_txt").GetComponent<UILabel> ().text = "보통";
		} else {
			GameObject.Find ("condition_txt").GetComponent<UILabel> ().text = "나쁨";
		}

		if (CharacterData.instance.luck > 70) {
			GameObject.Find ("luck_txt").GetComponent<UILabel> ().text = "좋음";
		} else if (CharacterData.instance.luck > 30) {
			GameObject.Find ("luck_txt").GetComponent<UILabel> ().text = "보통";
		} else {
			GameObject.Find ("luck_txt").GetComponent<UILabel> ().text = "나쁨";
		}

		GameObject.Find ("room_character_txt").GetComponent<UILabel> ().text = "["+(CharacterData.instance.playWeek/48+1)+"년차 취준생]\n"+CharacterData.instance.name;

		//Debug.Log ("GetUnreadMessageCount:"+MessageManager.instance.GetUnreadMessageCount().ToString());
		if (MessageManager.instance.GetUnreadMessageCount () > 0) {
			GameObject.Find ("message_count_txt").GetComponent<UILabel> ().text = MessageManager.instance.GetUnreadMessageCount ().ToString ();
			GameObject.Find("message_icon").GetComponent<UISprite>().spriteName = "icon_phone_simple large";
		} else {
			GameObject.Find ("message_count_txt").GetComponent<UILabel> ().text = "";
			GameObject.Find("message_icon").GetComponent<UISprite>().spriteName = "icon_phone_nobadge_simple large";
		}

		GameObject.Find("docu_txt").GetComponent<UILabel>().text = CharacterData.instance.tryCount+"회";
		GameObject.Find("stamina_filled").GetComponent<UISprite>().fillAmount= (float)CharacterData.instance.nowStamina / CharacterData.instance.totalStamina;
        GameObject.Find("stamina_txt").GetComponent<UILabel>().text = CharacterData.instance.nowStamina + " / " + CharacterData.instance.totalStamina;

		//시험결과(tab1)
		//examResult(1/2)
		string main_tab1_txt_str = "";
		if (CharacterData.instance.examList.Count == 0){
			main_tab1_txt_str = main_tab1_txt_str + "[어학]\n\n어학 기록이 없습니다.\n\n";
		}else{
			string tmpExamListStr = "";
			foreach (var item in CharacterData.instance.examList)
			{
				tmpExamListStr = tmpExamListStr + "[" + item.examName + "] : ";
				if (item.examStatus == 2){
					tmpExamListStr = tmpExamListStr + "결과 발표 전\n";
				}else if(item.examStatus == 3){
					tmpExamListStr = tmpExamListStr + item.examScore + "점\n";
				}
			}
			main_tab1_txt_str = main_tab1_txt_str + "[어학]\n\n"+ tmpExamListStr + "\n\n";
		}
		//qualificationResult(2/2)
		if (CharacterData.instance.qualificationList.Count == 0){
			main_tab1_txt_str = main_tab1_txt_str + "[자격]\n\n자격 기록이 없습니다.\n\n";
		}else{
			string tmpQualificationListStr = "";
			foreach (var item in CharacterData.instance.qualificationList)
			{
				tmpQualificationListStr = tmpQualificationListStr + "[" + item.qualificationName + "] : ";
				if (item.qualificationStatus == 2){
					tmpQualificationListStr = tmpQualificationListStr + "결과 발표 전\n";
				}else if(item.qualificationStatus == 3){
					tmpQualificationListStr = tmpQualificationListStr + "최종 합격 \n";
				}
			}
			main_tab1_txt_str = main_tab1_txt_str + "[자격]\n\n"+ tmpQualificationListStr + "\n";
		}
        GameObject.Find("main_tab1_txt").GetComponent<UILabel>().text = main_tab1_txt_str;

		//(tab2)
		//examResult(1/2)
		string main_tab2_txt_str = "";
		if (CharacterData.instance.winInterActivityList.Count == 0){
			main_tab2_txt_str = main_tab2_txt_str + "[대외활동]\n\n대외활동 기록이 없습니다.\n\n";
		}else{
			string tmpInterActivityListStr = "";
			foreach (var item in CharacterData.instance.winInterActivityList)
			{
				tmpInterActivityListStr = tmpInterActivityListStr + "[" + item.interName + "] : ";
				tmpInterActivityListStr = tmpInterActivityListStr + item.interPrize + " 수상\n";
			}
			main_tab2_txt_str = main_tab2_txt_str + "[대외활동]\n\n"+ tmpInterActivityListStr + "\n\n";
		}
		GameObject.Find("main_tab2_txt").GetComponent<UILabel>().text = main_tab2_txt_str;

		//(tab3)
		//qualificationList
		string main_tab3_txt_str = "";
		if (CharacterData.instance.winContestActivityList.Count == 0){
			main_tab3_txt_str = main_tab3_txt_str + "[공모전]\n\n자격 기록이 없습니다.\n\n";
		}else{
			string tmpWinContestActivityListStr = "";
			foreach (var item in CharacterData.instance.winContestActivityList)
			{
				tmpWinContestActivityListStr = tmpWinContestActivityListStr + "[" + item.contestName + "] : ";
				if (item.contestStatus == 2){
					tmpWinContestActivityListStr = tmpWinContestActivityListStr + "결과 발표 전\n";
				}else if(item.contestStatus == 3){
					tmpWinContestActivityListStr = tmpWinContestActivityListStr + item.contestPrize + "등 수상\n";
				}
			}
			main_tab3_txt_str = main_tab3_txt_str + "[공모전]\n\n"+ tmpWinContestActivityListStr + "\n";
		}
		GameObject.Find("main_tab3_txt").GetComponent<UILabel>().text = main_tab3_txt_str;

	}

	// Use this for initialization
	void Start () {
		SaveManager.CheckCharacterData ();
		MessageManager.instance.CheckMessageData();
		RefreshSceneObject ();
        SaveManager.InitData();

		if (CharacterData.instance.playWeek == 0) {
			PanelManager.instance.AlertPanel ("환영", "환영합니다!", "네 알겠습니다");
		}

    }
	
	// Update is called once per frame
	void Update () {
		
	}

	public void checkExam(){

		foreach (var item in CharacterData.instance.examList) {
			if(item.examStatus == 1){
				item.examStatus = 2;
			}else if (item.examStatus == 2){
				if (item.examPassFlag == true) {
					item.examStatus = 3;
					//
					if (item.examType == "TOEIC") {
						MessageManager.instance.PushMessage ("TOEIC", "토익 시험 결과를 알려드립니다.", "ETS", "안녕하세요, ETS입니다. \n이번 토익시험 결과를 알려드립니다.\n\n이번 토익시험에서 LC "+item.examLCScore+",RC "+item.examRCScore+"으로 총 "+item.examScore+"점");
					}
				} else {
					item.examStatus = 4;
					MessageManager.instance.PushMessage ("contest", "공모전 지원 결과를 알려드립니다.", "마케팅 협회","안녕하세요, 마케팅 협회입니다. \n귀하가 지원하신 \"2016 마케팅 대회\"의 공모전 결과를 알려드립니다.\n\n심사결과, 우수한 작품을 제출해주셨으나 수상작으로 선정되지 못하신 점 아쉽게 생각합니다. 앞으로도 많은 관심 부탁드립니다.");
				}
			}
		}

		CharacterData.instance.winContestActivityList.RemoveAll (delegate(WinContestActivity value) {
			return (value.contestStatus == 4)&&(value.contestWinFlag == false);
		});
	}

	public void checkContestActivity(){

		foreach (var item in CharacterData.instance.winContestActivityList) {
			if(item.contestStatus == 1){
				item.contestStatus = 2;
			}else if (item.contestStatus == 2){
				if (item.contestWinFlag == true) {
					item.contestStatus = 3;
					//
					MessageManager.instance.PushMessage ("contest", "공모전 지원 결과를 알려드립니다.", "마케팅 협회", "안녕하세요, 마케팅 협회입니다. \n귀하가 지원하신 \"2016 마케팅 대회\"의 공모전 결과를 알려드립니다.\n\n이번 공모전에서 귀하는 작품의 우수성을 인정받아 1등에 선발되었습니다.\n축하드립니다!\n\n(현금 + 500,000원)");
				} else {
					item.contestStatus = 4;
					MessageManager.instance.PushMessage ("contest", "공모전 지원 결과를 알려드립니다.", "마케팅 협회","안녕하세요, 마케팅 협회입니다. \n귀하가 지원하신 \"2016 마케팅 대회\"의 공모전 결과를 알려드립니다.\n\n심사결과, 우수한 작품을 제출해주셨으나 수상작으로 선정되지 못하신 점 아쉽게 생각합니다. 앞으로도 많은 관심 부탁드립니다.");
				}
			}
		}

		CharacterData.instance.winContestActivityList.RemoveAll (delegate(WinContestActivity value) {
			return (value.contestStatus == 4)&&(value.contestWinFlag == false);
		});
	}



	public void CheckWeekEvent(){
		int playWeek = CharacterData.instance.playWeek;

		if (playWeek == 4) {

			PanelManager.instance.AlertPanel ("무료 컨설팅", "두 달에 한 번, 무료 컨설팅을 받을 수 있습니다.\n컨설팅을 통해 부족한 점을 확인하고, 팁을 얻을 수 있습니다.\n지금 메시지를 확인해보세요!", "네, 좋아요!");

		}

		if (playWeek%8 == 4) {
			string consultingTxt = "안녕하세요, 이달의 무료 컨설팅입니다.\n\n영어 기초실력이 많이 부족한 것으로 판단됩니다.\n아직 공인 영어성적이 없으시군요,\n공인 영어성적에 가산점을 주거나 지원 자격이 있는 기업에 지원하기 위해서 도전해보시는것은 어떠신가요?";
			MessageManager.instance.PushMessage("freecon","이달의 무료 컨설팅","컨설턴트",consultingTxt);
		}

		if (CharacterData.instance.condition <= 30) {
			PanelManager.instance.alert_panel.SetActive (true);
			PanelManager.instance.dim_panel.SetActive (true);
			GameObject.Find ("alert_title_txt").GetComponent<UILabel> ().text = "컨디션 최악";
			GameObject.Find ("alert_contents_txt").GetComponent<UILabel> ().text = "취준생의 컨디션이 좋지 않네요, 낮은 컨디션에서는 학습 능률이 떨어지고\n시험에서도 제 실력을 발휘 할 수 없어요.";
			GameObject.Find ("alert_button_txt").GetComponent<UILabel> ().text = "주의할게요";
		}

		if (CharacterData.instance.nowStamina < 100) {
			PanelManager.instance.alert_panel.SetActive (true);
			PanelManager.instance.dim_panel.SetActive (true);
			GameObject.Find ("alert_title_txt").GetComponent<UILabel> ().text = "힘이 없어요!";
			GameObject.Find ("alert_contents_txt").GetComponent<UILabel> ().text = "취준생의 스테미나가 얼마 남지 않았습니다! 휴식 등을 통해 취준생을 쉬게 해주세요.\n취준생도 사람입니다ㅠㅠ";
			GameObject.Find ("alert_button_txt").GetComponent<UILabel> ().text = "주의할게요";
		}

		//ending check
		if (CharacterData.instance.condition < 0) {
			Ending ("nostamina");
		}
	}

	void Ending(string type){
		if (type == "nostamina") {
			Debug.Log ("END! : NO STAMINA");
		}
	}

}
