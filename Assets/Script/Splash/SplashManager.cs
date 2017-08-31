using UnityEngine;
using System.Collections;

public class SplashManager : MonoBehaviour {

	UISprite splash_bg;
	UILabel splash_guide_uitxt;
	int bgStatus = 0;

	// Use this for initialization
	void Start() {


		splash_guide_uitxt = GameObject.Find ("splash_guide_uitxt").GetComponent<UILabel>();

		splash_bg = GameObject.Find("splash_bg").GetComponent<UISprite>();

		StartCoroutine(Example());

		SaveManager.CheckGlobalData ();

		NextProcess nextProcess = GameObject.Find("splash_bg").GetComponent<NextProcess>();
		if (SaveManager.CheckCharacterData () == false) {
			nextProcess.playType="newCharacterScene";
		} else {
			nextProcess.playType="loadPlayScene";
		}

	}

	IEnumerator Example() {
		while(true){
			splash_bg.spriteName = "sprite_"+bgStatus;
			if (bgStatus == 0) {
				splash_guide_uitxt.color = new Color (1, 1, 1);
				bgStatus = 1;
			} else {
				splash_guide_uitxt.color = new Color (0, 0, 0);
				bgStatus = 0;
			}
			yield return new WaitForSeconds(0.7f);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

}
