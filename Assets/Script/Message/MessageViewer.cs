using UnityEngine;
using System.Collections;

public class MessageViewer : MonoBehaviour {
	
	public MessageViewer(){
	}


	void OnClick(){
		ShowSelectedMessage ();
	}

	public void ShowSelectedMessage() {

		int messageId = int.Parse(this.transform.Find("message_id").GetComponent<UILabel>().text);

		PanelManager.instance.mobile_detail_panel.SetActive (true);
		PanelManager.instance.mobile_scrollview.SetActive (false);

		SMSMessage message = MessageManager.instance.ViewMessage (messageId);

		GameObject.Find ("mobile_title_txt").GetComponent<UILabel> ().text = message.messageTitle;
		GameObject.Find ("mobile_sender_txt").GetComponent<UILabel> ().text = message.messageSender;
		GameObject.Find ("mobile_contents_txt").GetComponent<UILabel> ().text = message.messageContents;
        MessageManager.instance.SaveMessageData ();
        MainManager.instance.RefreshSceneObject ();
		
	}



}
