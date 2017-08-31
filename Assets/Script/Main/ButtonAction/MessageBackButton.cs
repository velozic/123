using UnityEngine;
using System.Collections;

public class MessageBackButton : MonoBehaviour {
	void OnClick(){
		PanelManager.instance.mobile_scrollview.SetActive (true);
		PanelManager.instance.mobile_detail_panel.SetActive (false);

		MessageManager.instance.RefreshMessageObject();
	}

}
