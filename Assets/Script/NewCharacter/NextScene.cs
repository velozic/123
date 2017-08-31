using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour {

	void OnClick(){

		string name = GameObject.Find ("input_txt").GetComponent<UIInput> ().label.text;

		Debug.Log (name);
		if (name == "눌러서 입력" || name == "") {
			name = "김석구";
		}
		SaveManager.CreateCharacterData (name);

		SceneManager.LoadScene ("MainScene");
		Debug.Log ("next Scene");
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
