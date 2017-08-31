using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionContext : MonoBehaviour {
	UILabel[] menu_contents_title_txt;
	static GameObject[] action_prefeb;
	static int count; //creating ref; starting index = 0;
	static int count_for_delete;
	static int temp;
	GameObject prefab;
	GameObject target_prefab;
    UIGrid grid;

    public void Awake()
    {
		count = -1; //creating ref; starting index = 0;
		count_for_delete = -1;
		temp = 0;
        grid = GameObject.Find("menu_grid").GetComponent<UIGrid>();
    }

    void Creating() {
		target_prefab = Resources.Load("Prefab/menu_contents_bg") as GameObject;
		prefab = Instantiate(target_prefab) as GameObject;
		prefab.name = "menu_content_prefeb";
		prefab.tag = "MenuInstance"; //for delete all
		prefab.transform.parent = GameObject.Find("menu_grid").GetComponent<Transform>();

        grid.Reposition();

		prefab.transform.localScale = new Vector3(1, 1, 0);

		count++;

		action_prefeb = GameObject.FindGameObjectsWithTag("MenuInstance");
	}

	void AllDelete()
	{
		//for init
		if (count == -1 && count_for_delete == -1) temp = 0;
		else temp = count_for_delete + 1;

		while (count_for_delete > -1) {
			action_prefeb = GameObject.FindGameObjectsWithTag("MenuInstance");
			DestroyObject(action_prefeb[count_for_delete]);
			count_for_delete--;
		}
	}

	//메뉴 분류입니다.
	public void Life_bar() {
		PanelManager.instance.CloseAllPanel ();
		PanelManager.instance.menu_panel.SetActive (true);
		AllDelete();
		그냥쉬기();
		국내_여행();
		해외_여행();
		인터넷_서핑();
		count_for_delete = count;
		grid.enabled = true;
		count = -1;
	}
	public void Training_bar() {
		PanelManager.instance.CloseAllPanel ();
		PanelManager.instance.menu_panel.SetActive (true);
		AllDelete();
		개인_운동();
		PT운동();
		달리기();
		count_for_delete = count;
		grid.enabled = true;
		count = -1;
	}

	public void Alba_bar() {
		PanelManager.instance.CloseAllPanel ();
		PanelManager.instance.menu_panel.SetActive (true);
		AllDelete();
		단순알바();
		번역알바();
		사무직_알바();
		생동성_알바();
		콜센터_알바();
		grid.enabled = true;
		count_for_delete = count;
		count = -1;
	}
	public void Event_bar() {
		PanelManager.instance.CloseAllPanel ();
		PanelManager.instance.menu_panel.SetActive (true);
		AllDelete();
		설연휴집가기();
		추석연휴집가기();
		grid.enabled = true;
		count_for_delete = count;
		count = -1;
	}
	public void English_bar() {
		PanelManager.instance.CloseAllPanel ();
		PanelManager.instance.menu_panel.SetActive (true);
		AllDelete();
		영어책();
		영어인강();
		영어_학원();
		회화_학원();
		grid.enabled = true;
		count_for_delete = count;
		count = -1;
	}	
	public void Academy_bar() {
		PanelManager.instance.CloseAllPanel ();
		PanelManager.instance.menu_panel.SetActive (true);
		AllDelete();
		독서();
		문서작성공부();
		한국사공부();
		리더쉽_공부();
		논리력_공부();
		분석능력_공부();
		친화력_공부();
		취업_학원();
		컴퓨터_학원();
		grid.enabled = true;
		count_for_delete = count;
		count = -1;
	}
	public void Employment_preparation() {
		PanelManager.instance.CloseAllPanel ();
		PanelManager.instance.menu_panel.SetActive (true);
		AllDelete();
		// 자소서 작성법 인강, 자소서 컨설팅 학원
		// 사무관련 인강, 사무관련  학원? ncs??
		// 면접 인강, 면접 학원
		
		자소서_작성법_인강();
		자소서_작성법_학원();
		면접_인강();
		면접_학원();

		grid.enabled = true;
		count_for_delete = count;
		count = -1;
	}
	public void Study_bar() {
		PanelManager.instance.CloseAllPanel ();
		PanelManager.instance.menu_panel.SetActive (true);
		AllDelete();

		영어_스터디();
		회화_스터디();
		취업_스터디();

		grid.enabled = true;
		count_for_delete = count;
		count = -1;
	}
	public void interActivity_bar() {
		PanelManager.instance.CloseAllPanel ();
		PanelManager.instance.menu_panel.SetActive (true);
		AllDelete();
		
		어학_연수();
		
		grid.enabled = true;
		count_for_delete = count;
		count = -1;
	}
	public void contestActivity_bar() {
		PanelManager.instance.CloseAllPanel ();
		PanelManager.instance.menu_panel.SetActive (true);
		AllDelete();

		마케팅_공모전();
		IT_공모전();
		사무_공모전();
		경영_공모전();
		영업_공모전();

		grid.enabled = true;
		count_for_delete = count;
		count = -1;
	}

	public void Exam_bar() {
		PanelManager.instance.CloseAllPanel ();
		PanelManager.instance.menu_panel.SetActive (true);
		AllDelete();
		
		토익();
		Opic();
		모의면접();
		전문성_시험1();
		전문성_시험2();
		
		grid.enabled = true;
		count_for_delete = count;
		count = -1;
	}

	public void Employment_bar() {
		PanelManager.instance.CloseAllPanel ();
		PanelManager.instance.menu_panel.SetActive (true);
		AllDelete();
		
		입사지원();
		
		grid.enabled = true;
		count_for_delete = count;
		count = -1;
	}

	//setaction()
	//
	//액션 텍스트 정의입니다.
	void 그냥쉬기() {
		Creating();
		menu_contents_title_txt = action_prefeb[count + temp].GetComponentsInChildren<UILabel>();
		menu_contents_title_txt[0].text = "그냥 쉬기";
		menu_contents_title_txt[1].text = "집에서 쉬면서 스테미나를 채운다.(이불 박근 위헌해..하야..순시려)";
		menu_contents_title_txt[2].text = "스테미나(↑↑↑↑),기분(↑)";
	}
	void 해외_여행() {
		Creating();
		menu_contents_title_txt = action_prefeb[count + temp].GetComponentsInChildren<UILabel>();
		menu_contents_title_txt[0].text = "해외 여행";
		menu_contents_title_txt[1].text = "해외 여행을 간다";
		menu_contents_title_txt[2].text = "스테미나(↑↑↑↑↑), 영어 능력(↑↑), ";
	}
	void 국내_여행() {
		Creating();
		menu_contents_title_txt = action_prefeb[count + temp].GetComponentsInChildren<UILabel>();
		menu_contents_title_txt[0].text = "국내 여행";
		menu_contents_title_txt[1].text = "국내 여행을 간다";
		menu_contents_title_txt[2].text = "스테미나(↑↑↑↑↑)";
	}
	void 인터넷_서핑() {
		Creating();
		menu_contents_title_txt = action_prefeb[count + temp].GetComponentsInChildren<UILabel>();
		menu_contents_title_txt[0].text = "인터넷_서핑";
		menu_contents_title_txt[1].text = "참여가능한 (꿀) 공모전, 스터디, 알바를 알 수 있다.";
		menu_contents_title_txt[2].text = "스테미나(↑), 컴퓨터 활용 능력(↑)";
	}
	void 개인_운동() {
		Creating();
		menu_contents_title_txt = action_prefeb[count + temp].GetComponentsInChildren<UILabel>();
		menu_contents_title_txt[0].text = "개인 운동";
		menu_contents_title_txt[1].text = "초보자의 운동, 운동능률은 좋지 않다";
		menu_contents_title_txt[2].text = "스태미나(최대값↑), 현재값(↓↓) ↓),지구력(↑),매력(↑)";
	}
	void 달리기() {
		Creating();
		menu_contents_title_txt = action_prefeb[count + temp].GetComponentsInChildren<UILabel>();
		menu_contents_title_txt[0].text = "달리기";
		menu_contents_title_txt[1].text = "초보자의 달리기, 운동능률은 좋지 않다";
		menu_contents_title_txt[2].text = "스태미나(최대값↑), 현재값(↓↓) ↓),지구력(↑),매력(↑)";
	}
	void PT운동() {
		Creating();
		menu_contents_title_txt = action_prefeb[count + temp].GetComponentsInChildren<UILabel>();
		menu_contents_title_txt[0].text = "PT운동";
		menu_contents_title_txt[1].text = "돈을 주고 개인 관리를 받는다.";
		menu_contents_title_txt[2].text = "스태미나(최대값↑↑, 현재값 ↓↓), 돈↓, 지구력(↑↑),매력(↑)";
	}
	void 설연휴집가기() {
		Creating();
		menu_contents_title_txt = action_prefeb[count + temp].GetComponentsInChildren<UILabel>();
		menu_contents_title_txt[0].text = "설 연휴 집가기";
		menu_contents_title_txt[1].text = "많이 논다 용돈도 받는다";
		menu_contents_title_txt[2].text = "스태미나(최대값↑↑, 현재값 ↓↓), 돈↓, 지구력(↑↑),매력(↑)";
	}
	void 추석연휴집가기() {
		Creating();
		menu_contents_title_txt = action_prefeb[count + temp].GetComponentsInChildren<UILabel>();
		menu_contents_title_txt[0].text = "추석 연휴 집가기";
		menu_contents_title_txt[1].text = "많이 논다 용돈도 받는다";
		menu_contents_title_txt[2].text = "스태미나(최대값↑↑, 현재값 ↓↓), 돈↓, 지구력(↑↑),매력(↑)";
	}
	void 단순알바()
	{
		Creating();
		menu_contents_title_txt = action_prefeb[count + temp].GetComponentsInChildren<UILabel>();
		menu_contents_title_txt[0].text = "단순알바";
		menu_contents_title_txt[1].text = "단기 알바, 일을해서 돈을 번다.";
		menu_contents_title_txt[2].text = "돈증가(↑), 스태미나 (↓↓↓) 노오력 ↑";
	}
	void 번역알바()
	{
		Creating();
		menu_contents_title_txt = action_prefeb[count+temp].GetComponentsInChildren<UILabel>();
		menu_contents_title_txt[0].text = "번역알바";
		menu_contents_title_txt[1].text = "번역 일을 한다, 영어 능력 필수";
		menu_contents_title_txt[2].text = "돈 증가(↑↑), 스태미나 (↓↓),영어↑";
	}
	void 사무직_알바()
	{
		Creating();
		menu_contents_title_txt = action_prefeb[count + temp].GetComponentsInChildren<UILabel>();
		menu_contents_title_txt[0].text = "사무직 알바";
		menu_contents_title_txt[1].text = "사무직 알바, 컴퓨터 능력 필수";
		menu_contents_title_txt[2].text = "돈 증가(↑↑), 스태미나 (↓↓),컴퓨터(↑)";
	}
	void 생동성_알바()
	{
		Creating();
		menu_contents_title_txt = action_prefeb[count + temp].GetComponentsInChildren<UILabel>();
		menu_contents_title_txt[0].text = "생동성 알바";
		menu_contents_title_txt[1].text = "생동성 알바, ???";
		menu_contents_title_txt[2].text = "돈 증가(↑↑↑↑), 스태미나(↓↓↓)";
	}
	void 콜센터_알바()
	{
		Creating();
		menu_contents_title_txt = action_prefeb[count + temp].GetComponentsInChildren<UILabel>();
		menu_contents_title_txt[0].text = "콜센터 알바";
		menu_contents_title_txt[1].text = "콜센터 알바, ???";
		menu_contents_title_txt[2].text = "돈 증가(↑↑↑), 스태미나(↓↓↓), 매력(↑)";
	}
	void 영어책()
	{
		Creating();
		menu_contents_title_txt = action_prefeb[count + temp].GetComponentsInChildren<UILabel>();
		menu_contents_title_txt[0].text = "영어책";
		menu_contents_title_txt[1].text = "영어 책을 읽는다.";
		menu_contents_title_txt[2].text = "단어,읽기(분배↑),스태미나(↓)";
	}
	void 영어인강() {
		Creating();
		menu_contents_title_txt = action_prefeb[count + temp].GetComponentsInChildren<UILabel>();
		menu_contents_title_txt[0].text = "영어인강";
		menu_contents_title_txt[1].text = "인강을 듣는다.";
		menu_contents_title_txt[2].text = "듣기,읽기(분배↑),스태미나(↓)";
	}
	void 독서()
	{
		Creating();
		menu_contents_title_txt = action_prefeb[count + temp].GetComponentsInChildren<UILabel>();
		menu_contents_title_txt[0].text = "독서";
		menu_contents_title_txt[1].text = "말잘하는 법에 관한 책을 읽는다";
		menu_contents_title_txt[2].text = "화법,글쓰기(분배↑), 스태미나(↓";
	}
	void 문서작성공부() {
		Creating();
		menu_contents_title_txt = action_prefeb[count + temp].GetComponentsInChildren<UILabel>();
		menu_contents_title_txt[0].text = "문서작성공부";
		menu_contents_title_txt[1].text = "문서작성공부를 한다";
		menu_contents_title_txt[2].text = "";
	}
	void 한국사공부() {
		Creating();
		menu_contents_title_txt = action_prefeb[count + temp].GetComponentsInChildren<UILabel>();
		menu_contents_title_txt[0].text = "한국사 공부";
		menu_contents_title_txt[1].text = "";
		menu_contents_title_txt[2].text = "";
	}
	void 리더쉽_공부() {
		Creating();
		menu_contents_title_txt = action_prefeb[count + temp].GetComponentsInChildren<UILabel>();
		menu_contents_title_txt[0].text = "리더쉽 공부";
		menu_contents_title_txt[1].text = "";
		menu_contents_title_txt[2].text = "";
	}
	void 논리력_공부() {
		Creating();
		menu_contents_title_txt = action_prefeb[count + temp].GetComponentsInChildren<UILabel>();
		menu_contents_title_txt[0].text = "논리력 공부";
		menu_contents_title_txt[1].text = "";
		menu_contents_title_txt[2].text = "";
	}
	void 분석능력_공부() {
		Creating();
		menu_contents_title_txt = action_prefeb[count + temp].GetComponentsInChildren<UILabel>();
		menu_contents_title_txt[0].text = "분석능력 공부";
		menu_contents_title_txt[1].text = "";
		menu_contents_title_txt[2].text = "";
	}
	void 친화력_공부() {
		Creating();
		menu_contents_title_txt = action_prefeb[count + temp].GetComponentsInChildren<UILabel>();
		menu_contents_title_txt[0].text = "친화력 공부";
		menu_contents_title_txt[1].text = "";
		menu_contents_title_txt[2].text = "";
	}
	void 자소서_작성법_인강() {
		Creating();
		menu_contents_title_txt = action_prefeb[count + temp].GetComponentsInChildren<UILabel>();
		menu_contents_title_txt[0].text = "자소서 작성법 인강";
		menu_contents_title_txt[1].text = "";
		menu_contents_title_txt[2].text = "";
	}
	void 자소서_작성법_학원() {
		Creating();
		menu_contents_title_txt = action_prefeb[count + temp].GetComponentsInChildren<UILabel>();
		menu_contents_title_txt[0].text = "자소서 작성법 학원";
		menu_contents_title_txt[1].text = "";
		menu_contents_title_txt[2].text = "";
	}
	void 면접_인강() {
		Creating();
		menu_contents_title_txt = action_prefeb[count + temp].GetComponentsInChildren<UILabel>();
		menu_contents_title_txt[0].text = "면접 인강";
		menu_contents_title_txt[1].text = "";
		menu_contents_title_txt[2].text = "";
	}
	void 면접_학원() {
		Creating();
		menu_contents_title_txt = action_prefeb[count + temp].GetComponentsInChildren<UILabel>();
		menu_contents_title_txt[0].text = "면접 학원";
		menu_contents_title_txt[1].text = "";
		menu_contents_title_txt[2].text = "";
	}
	void 영어_스터디() {
		Creating();
		menu_contents_title_txt = action_prefeb[count + temp].GetComponentsInChildren<UILabel>();
		menu_contents_title_txt[0].text = "영어 스터디";
		menu_contents_title_txt[1].text = "";
		menu_contents_title_txt[2].text = "";
	}
	void 회화_스터디() {
		Creating();
		menu_contents_title_txt = action_prefeb[count + temp].GetComponentsInChildren<UILabel>();
		menu_contents_title_txt[0].text = "회화 스터디";
		menu_contents_title_txt[1].text = "";
		menu_contents_title_txt[2].text = "";
	}
	void 취업_스터디() {
		Creating();
		menu_contents_title_txt = action_prefeb[count + temp].GetComponentsInChildren<UILabel>();
		menu_contents_title_txt[0].text = "취업 스터디";
		menu_contents_title_txt[1].text = "";
		menu_contents_title_txt[2].text = "";
	}
	void 영어_학원() {
		Creating();
		menu_contents_title_txt = action_prefeb[count + temp].GetComponentsInChildren<UILabel>();
		menu_contents_title_txt[0].text = "영어 학원";
		menu_contents_title_txt[1].text = "";
		menu_contents_title_txt[2].text = "";
	}
	void 회화_학원() {
		Creating();
		menu_contents_title_txt = action_prefeb[count + temp].GetComponentsInChildren<UILabel>();
		menu_contents_title_txt[0].text = "회화학원";
		menu_contents_title_txt[1].text = "";
		menu_contents_title_txt[2].text = "";
	}

	void 취업_학원() {
		Creating();
		menu_contents_title_txt = action_prefeb[count + temp].GetComponentsInChildren<UILabel>();
		menu_contents_title_txt[0].text = "취업 학원";
		menu_contents_title_txt[1].text = "면접 및 자소서 능력 향상";
		menu_contents_title_txt[2].text = "돈(↓↓),글쓰기,화법(분배↑↑)";
	}
	void 컴퓨터_학원()
	{
		Creating();
		menu_contents_title_txt = action_prefeb[count + temp].GetComponentsInChildren<UILabel>();
		menu_contents_title_txt[0].text = "컴퓨터 학원";
		menu_contents_title_txt[1].text = "컴퓨터 학원을 다닌다";
		menu_contents_title_txt[2].text = "돈(↓↓),컴퓨터능력(↑↑)";
	}
	void 어학_연수()
	{
		Creating();
		menu_contents_title_txt = action_prefeb[count + temp].GetComponentsInChildren<UILabel>();
		menu_contents_title_txt[0].text = "어학 연수";
		menu_contents_title_txt[1].text = "해외로 어학연수를 다녀온다.(9주)";
		menu_contents_title_txt[2].text = "돈(↓↓↓↓↓↓),읽기,단어(↑↑↑↑),듣기,말하기(↑↑↑↑↑↑↑↑↑)";
	}
	void 마케팅_공모전() {
		Creating();
		menu_contents_title_txt = action_prefeb[count + temp].GetComponentsInChildren<UILabel>();
		menu_contents_title_txt[0].text = "마케팅 공모전";
		menu_contents_title_txt[1].text = "마케팅 공모전";
		menu_contents_title_txt[2].text = "돈(),전문성()";
	}
	void IT_공모전() {
		Creating();
		menu_contents_title_txt = action_prefeb[count + temp].GetComponentsInChildren<UILabel>();
		menu_contents_title_txt[0].text = "IT 공모전";
		menu_contents_title_txt[1].text = "집에서 쉬면서 스테미나를 채운다.(이불 박근 위헌해..하야..순시려)";
		menu_contents_title_txt[2].text = "스테미나↑↑↑↑,기분↑";
	}
	void 사무_공모전() {
		Creating();
		menu_contents_title_txt = action_prefeb[count + temp].GetComponentsInChildren<UILabel>();
		menu_contents_title_txt[0].text = "사무 공모전";
		menu_contents_title_txt[1].text = "집에서 쉬면서 스테미나를 채운다.(이불 박근 위헌해..하야..순시려)";
		menu_contents_title_txt[2].text = "스테미나↑↑↑↑,기분↑";
	}
	void 경영_공모전() {
		Creating();
		menu_contents_title_txt = action_prefeb[count + temp].GetComponentsInChildren<UILabel>();
		menu_contents_title_txt[0].text = "경영 공모전";
		menu_contents_title_txt[1].text = "집에서 쉬면서 스테미나를 채운다.(이불 박근 위헌해..하야..순시려)";
		menu_contents_title_txt[2].text = "스테미나↑↑↑↑,기분↑";
	}
	void 영업_공모전() {
		Creating();
		menu_contents_title_txt = action_prefeb[count + temp].GetComponentsInChildren<UILabel>();
		menu_contents_title_txt[0].text = "영업 공모전";
		menu_contents_title_txt[1].text = "집에서 쉬면서 스테미나를 채운다.(이불 박근 위헌해..하야..순시려)";
		menu_contents_title_txt[2].text = "스테미나↑↑↑↑,기분↑";
	}
	void 토익() {
		Creating();
		menu_contents_title_txt = action_prefeb[count + temp].GetComponentsInChildren<UILabel>();
		menu_contents_title_txt[0].text = "토익";
		menu_contents_title_txt[1].text = "시험 탭에서 진행";
		menu_contents_title_txt[2].text = "돈(↓↓)";
	}
	void 모의면접() {
		Creating();
		menu_contents_title_txt = action_prefeb[count + temp].GetComponentsInChildren<UILabel>();
		menu_contents_title_txt[0].text = "모의면접";
		menu_contents_title_txt[1].text = "한국어,영어 면접중 정할 수 있고 위기대처능력, 화법, 매력을 알 수 있다.";
		menu_contents_title_txt[2].text = "돈(↓↓↓)";
	}
	void Opic() {
		Creating();
		menu_contents_title_txt = action_prefeb[count + temp].GetComponentsInChildren<UILabel>();
		menu_contents_title_txt[0].text = "Opic";
		menu_contents_title_txt[1].text = "";
		menu_contents_title_txt[2].text = "돈(↓↓)";
	}
	void 전문성_시험1() {
		Creating();
		menu_contents_title_txt = action_prefeb[count + temp].GetComponentsInChildren<UILabel>();
		menu_contents_title_txt[0].text = "전문성_시험1";
		menu_contents_title_txt[1].text = "";
		menu_contents_title_txt[2].text = "";
	}
	void 전문성_시험2() {
		Creating();
		menu_contents_title_txt = action_prefeb[count + temp].GetComponentsInChildren<UILabel>();
		menu_contents_title_txt[0].text = "전문성_시험2";
		menu_contents_title_txt[1].text = "";
		menu_contents_title_txt[2].text = "";
	}
	void 입사지원() {
		Creating();
		menu_contents_title_txt = action_prefeb[count + temp].GetComponentsInChildren<UILabel>();
		menu_contents_title_txt[0].text = "입사지원";
		menu_contents_title_txt[1].text = "";
		menu_contents_title_txt[2].text = "";
	}
}