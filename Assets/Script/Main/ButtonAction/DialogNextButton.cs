using UnityEngine;
using System.Collections;

public class DialogNextButton : MonoBehaviour {
	void OnClick(){
		PanelManager.instance.dialog_panel.SetActive (false);
		PanelManager.instance.fade_bg.GetComponent<FadeEvent>().FadeEventStart();
		GameObject.Find("fade_week_txt").GetComponent<UILabel>().text = "취업준비 "+(CharacterData.instance.playWeek/48+1)+"년차\n"+((CharacterData.instance.playWeek%48)/4+1)+"월 "+(CharacterData.instance.playWeek%4+1) + "주차";
		PanelManager.instance.dim_panel.SetActive (false);

		MainManager.instance.checkExam ();
		MainManager.instance.checkContestActivity ();
		MainManager.instance.CheckWeekEvent ();
		MainManager.instance.RefreshSceneObject();
	}

}
