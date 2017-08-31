using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextProcess : MonoBehaviour {
	public string playType;

	void OnClick(){
		if (playType == "newCharacterScene") {
			SceneManager.LoadScene ("NewCharacterScene");
		} else if(playType == "loadPlayScene") {
			SceneManager.LoadScene ("MainScene");
		}

	}

	// Use this for initialization
	void Start () {
				
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
