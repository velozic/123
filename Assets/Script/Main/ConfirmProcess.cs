using UnityEngine;
using System.Collections;

public class ConfirmProcess : MonoBehaviour {

	public void NextConfirmProcess(){
		string confirm_id = GameObject.Find("confirm_button_yes_col").transform.Find("confirm_id").GetComponent<UILabel>().text;

		PanelManager.instance.dim_panel.SetActive (false);
		PanelManager.instance.confirm_panel.SetActive (false);

		if (confirm_id == "reset") {
			OptionManager.instance.ResetCharacter ();
		} else if(confirm_id == "test") {
			test ();
		}
	}

	void test(){
		Debug.Log ("TEST");
	}

}
