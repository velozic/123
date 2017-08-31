using UnityEngine;
using System.Collections;

public class FadeEvent : MonoBehaviour {

	private UISprite m_Fade;
	public float m_fStartDuration = 1.5f;

	// Use this for initialization

	public void FadeEventStart() {
		PanelManager.instance.fade_bg.SetActive (true);
		m_Fade = PanelManager.instance.fade_bg.GetComponent<UISprite>();
		StartCoroutine(FadeOut());
	}

	IEnumerator FadeOut()
	{
		// Fade Out
		TweenAlpha.Begin (m_Fade.gameObject, m_fStartDuration, 1f);
		yield return new WaitForSeconds( m_fStartDuration );
		yield return new WaitForSeconds( 0.5f );
		// Fade In
		TweenAlpha.Begin (m_Fade.gameObject, 1.5f, 0.0f);
		yield return new WaitForSeconds( 1.5f );
		PanelManager.instance.fade_bg.SetActive (false);

	}

}