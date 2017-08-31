using UnityEngine;
using System.Collections;

public class ConfirmButton : MonoBehaviour {

	public ConfirmButton(){
	}


	void OnClick(){
		PanelManager.instance.confirm_panel.SetActive (true);
		string confirm_id = this.transform.Find("confirm_id").GetComponent<UILabel>().text;
		GameObject.Find ("confirm_button_yes_col").transform.Find ("confirm_id").GetComponent<UILabel> ().text = confirm_id;


		PanelManager.instance.dim_panel.SetActive (true);
		if (confirm_id == "test") {
			GameObject.Find ("confirm_contents_txt").GetComponent<UILabel> ().text = "Test Confirm";
			GameObject.Find ("confirm_button_no_txt").GetComponent<UILabel> ().text = "Test no";
			GameObject.Find ("confirm_button_yes_txt").GetComponent<UILabel> ().text = "Test yes";
		} else if (confirm_id == "reset") {
			GameObject.Find ("confirm_contents_txt").GetComponent<UILabel> ().text = "지금까지의 기록을 스코어로 남기고,\n새 취업 준비 생활을 시작합니다.\n누적 스코어는 다음 취준생에게\n영향을 줍니다.\n\n계속 하시겠습니까?";
			GameObject.Find ("confirm_button_no_txt").GetComponent<UILabel> ().text = "아니요";
			GameObject.Find ("confirm_button_yes_txt").GetComponent<UILabel> ().text = "네, 좋아요";
		}
			
	}
}
