using UnityEngine;
using System.Collections;

public class PanelManager : MonoBehaviour {

	public static PanelManager instance;  

	public GameObject top_bar_panel;
	public GameObject main_button_panel;
	public GameObject menu_panel;
	public GameObject stat_panel;
	public GameObject main_panel;
	public GameObject main_tab_panel;
	public GameObject dim_panel;
	public GameObject alert_panel;
	public GameObject confirm_panel;
	public GameObject action_confirm_panel;
	public GameObject dialog_panel;
	public GameObject option_panel;
	public GameObject mobile_panel;
	public GameObject fade_bg;

	public GameObject mobile_detail_panel;
	public GameObject mobile_scrollview;

	public GameObject mobile_grid;

	public void Awake()  
	{  
		PanelManager.instance = this;  
	}  

	void Start () {

	}

	void Update () {
	
	}

	public void CloseAllPanel(){
		menu_panel.SetActive (false);
		dim_panel.SetActive (false);
		mobile_panel.SetActive (false);
		alert_panel.SetActive (false);
		confirm_panel.SetActive (false);
		action_confirm_panel.SetActive (false);
		dialog_panel.SetActive (false);
		option_panel.SetActive (false);
		fade_bg.SetActive (false);
	}

	public void AlertPanel(string title, string contents, string button){
		PanelManager.instance.alert_panel.SetActive (true);
		PanelManager.instance.dim_panel.SetActive (true);
		GameObject.Find ("alert_title_txt").GetComponent<UILabel> ().text = title;
		GameObject.Find ("alert_contents_txt").GetComponent<UILabel> ().text = contents;
		GameObject.Find ("alert_button_txt").GetComponent<UILabel> ().text = button;
	}
}
