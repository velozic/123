using UnityEngine;
using System.Collections;

public class MessageButton : MonoBehaviour {
	public GameObject _panel;
	public bool openFlag;
	public bool dimFlag;

	void OnClick(){
		if (openFlag == true) {
			_panel.SetActive (true);
			MessageManager.instance.RefreshMessageObject ();
		} else {
			_panel.SetActive (false);
		}

		if (dimFlag == true) {
			PanelManager.instance.dim_panel.SetActive(true);
		} else {
			PanelManager.instance.dim_panel.SetActive (false);
		}
	}
}
