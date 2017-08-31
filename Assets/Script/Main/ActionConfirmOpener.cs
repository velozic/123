using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionConfirmOpener : MonoBehaviour
{
	string actionname;

	void OnClick()
	{
		actionname = GetComponentInChildren<UILabel>().text;
		PanelManager.instance.action_confirm_panel.SetActive(true);
		GameObject.Find("action_confirm_contents_txt").GetComponent<UILabel>().text = actionname+"를 시작하시겠습니까?";
		PanelManager.instance.dialog_panel.GetComponent<PlayAction>().ActionType = actionname;
		PanelManager.instance.dim_panel.SetActive(true);
	}
}