using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AutoText : MonoBehaviour {

	const float NORMALSPEED = 0.11f;
	const float FASTSPEED = 0.02f;

	string topText = "20xx년, ㅇㅇ반도...\n\n ‘실업자 100만 명 돌파… 실업률 역대 최고’\n‘취업 포기자도 50만, 체감 실업률 3배’\n‘갈곳이 없어요’ 실업자 IMF 이후 최대\n        \n취업 레이스 속 스펙 경쟁에서\n살아남는 법은 무엇일까요?"; //실업자 100만 명 돌파… 청년실업률 역대 최고\n- 캠퍼스 낭만은 옛말, 취업 준비 나선 새내기\n- 취업준비생 62만명도 사실상 실업자\n- 취업 포기자도 50만…체감 실업률 3배\n- ‘N포세대’ 여가·결혼·연애·꿈·내집·출산 포기";
	string bottomText = "이제, 당신의 1번째\n취업 이야기가 시작됩니다.\n\n이 취준생의 이름은?";
	public Text top_uitxt;
	public Text bottom_uitxt;
	float typingSpeed = NORMALSPEED;
	public bool quickComplete;
	GameObject new_character_bg;
	public GameObject _panel;

	// Use this for initialization
	void Awake () {
		new_character_bg = GameObject.Find("new_character_bg");
        StartCoroutine("AutoType");
	}

	IEnumerator AutoType()
	{  
		yield return new WaitForSeconds(0.5f);

		foreach (char letter in topText.ToCharArray()) {
			top_uitxt.text +=letter;
			yield return new WaitForSeconds(typingSpeed);
		};

		yield return new WaitForSeconds(1);

		new_character_bg.GetComponent<UISprite>().spriteName = "sprite_1";

		yield return new WaitForSeconds(1);

		foreach (char letter in bottomText.ToCharArray()) {
			bottom_uitxt.text +=letter;
			yield return new WaitForSeconds(typingSpeed);
		};

		yield return new WaitForSeconds(0.5f);

		_panel.SetActive(true);
    }
  
    void Update()
    {
		if (quickComplete == true) typingSpeed = FASTSPEED;
		else typingSpeed = NORMALSPEED;

    }
	// Update is called once per frame

}
