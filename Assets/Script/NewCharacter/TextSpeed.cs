using UnityEngine;
using System.Collections;

public class TextSpeed : MonoBehaviour {
	public AutoText autoText;
	// Use this for initialization
	void Start () {
		autoText = GameObject.Find ("TextManager").GetComponent<AutoText>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnPress(bool isPressed) 
	{ 
		if (isPressed == true) {
			autoText.quickComplete = true;
		} else {
			autoText.quickComplete = false;
		}	
	} 

}
