using UnityEngine;
using System.Collections;

public class MessageCloseButton : MonoBehaviour {

	void OnClick(){
		PanelManager.instance.mobile_scrollview.SetActive (true);
		PanelManager.instance.mobile_detail_panel.SetActive (false);

		PanelManager.instance.mobile_panel.SetActive (false);
		PanelManager.instance.dim_panel.SetActive (false);
	}

}
