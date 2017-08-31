using UnityEngine;
using System.Collections;

public class Creating : MonoBehaviour {

	UIGrid grid;

	// Use this for initialization
	void Start () {
		grid = GameObject.Find("menu_grid").GetComponent<UIGrid>();
	}

	public void CreateContents(){
		GameObject target_prefab = Resources.Load ("Prefab/menu_contents_bg") as GameObject;
		GameObject prefab = Instantiate (target_prefab) as GameObject;
		prefab.name = "menu_contents_prefab";
		prefab.transform.parent = this.transform;

		//set position
		grid.Reposition();

		prefab.transform.localScale = new Vector3(1,1,1);
		prefab.GetComponent<BasicOnclickAction> ()._panel = PanelManager.instance.action_confirm_panel;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
