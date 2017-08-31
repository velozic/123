using UnityEngine;
using System.Collections;

public class DialogManager : MonoBehaviour {

	public static DialogManager instance;  

	const float NORMALSPEED = 0.02f;
	const float NEWLINESPEED = 0.50f;
	const float FASTSPEED = 0.01f;

	public bool quickComplete;
    public GameObject dialog_contents_txt;
    public GameObject dialog_button_txt;
    public GameObject dialog_button_col; 

     UILabel dialogLabel;

	float typingSpeed = NORMALSPEED;
	float newlineSpeed = NEWLINESPEED;

	string autoTypeText = "그냥 쉬기를(을) 하는 중...\n컨디션이 10 올랐다!\n스테미너가 20 올랐다!\n기분이 좋아졌다!\n그냥 쉬기를(을) 하는 중...\n컨디션이 10 올랐다!\n스테미너가 20 올랐다!\n기분이 좋아졌다!";//실업자 100만 명 돌파… 청년실업률 역대 최고\n- 캠퍼스 낭만은 옛말, 취업 준비 나선 새내기\n- 취업준비생 62만명도 사실상 실업자\n- 취업 포기자도 50만…체감 실업률 3배\n- ‘N포세대’ 여가·결혼·연애·꿈·내집·출산 포기";

	public void SetAutoType (string inputText) {

		autoTypeText = inputText;
		dialogLabel = dialog_contents_txt.GetComponent<UILabel> ();
		dialogLabel.text = "";

		StartCoroutine("AutoType");
	}

	IEnumerator AutoType()
    {
        dialog_button_txt.GetComponent<UILabel>().text = "액션 중...";
        dialog_button_col.SetActive(false);
        foreach (char letter in autoTypeText.ToCharArray()) {
			dialogLabel.text +=letter;
			if (letter == '\n') { //if next character is newline, more term
				yield return new WaitForSeconds (newlineSpeed);
			} else {
				yield return new WaitForSeconds (typingSpeed);
			}
		};
        dialog_button_txt.GetComponent<UILabel>().text = "다음주로 넘어가기";
        dialog_button_col.SetActive(true);

    }

	public void Awake()	{  
		DialogManager.instance = this;  

	}  
	void Start () {
	}

	void Update()
	{
		if (quickComplete == true) {
			typingSpeed = FASTSPEED;
			newlineSpeed = FASTSPEED;
		} else {
			typingSpeed = NORMALSPEED;
			newlineSpeed = NEWLINESPEED;
		}
	}
	// Update is called once per frame

}
