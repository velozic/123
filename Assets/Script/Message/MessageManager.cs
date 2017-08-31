using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MessageManager : MonoBehaviour {

	public static MessageManager instance;
    
    public List<SMSMessage> messageList = new List<SMSMessage>();

    public UILabel[] message_title_txt;
    public GameObject[] message_prefeb;
    public int count; //creating ref; starting index = 0;
    public int count_for_delete;
    public int temp;
    public GameObject prefab;
    public GameObject target_prefab;
    public UIGrid grid;

	public void Awake(){
		count = -1; //creating ref; starting index = 0;
		count_for_delete = -1;
		temp = 0;
        MessageManager.instance = this;
		//Debug.Log ("MessageManager Awake");
    }

	public MessageManager () {
	}

	// Use this for initialization
	void Start (){
        CheckMessageData();
		grid = PanelManager.instance.mobile_grid.GetComponent<UIGrid>();
	}

	// Update is called once per frame
	void Update () {
	}

    public void SaveMessageData(){
        // messageList JSON 처리
        string tmpMessageListStr = "";
        foreach (var item in MessageManager.instance.messageList)
        {
            tmpMessageListStr = tmpMessageListStr + JsonUtility.ToJson(item) + "|";
        }
        tmpMessageListStr = tmpMessageListStr.Substring(0, tmpMessageListStr.Length - 1);

        ES2.Save(tmpMessageListStr, "chui/CharacterData?tag=messageList&encrypt=true");
    }

    //세이브데이터에서 가져옴
    public void CheckMessageData(){
		//Debug.Log ("load messageData");

        messageList.Clear();
        string tmpMessageListStr = ES2.Load<string>("chui/CharacterData?tag=messageList");
        foreach (var item in tmpMessageListStr.Split('|'))
        {
            messageList.Add(JsonUtility.FromJson<SMSMessage>(item));
        }
    }

    public void RefreshMessageObject(){
        AllDelete();

		//for listing
		messageList.Reverse();

		foreach (var item in messageList){
            UISprite tmp_message_prefab_ui;
            Creating();
            if (item.readFlag){
                tmp_message_prefab_ui = message_prefeb[count + temp].GetComponent<UISprite>();
                tmp_message_prefab_ui.spriteName = "phone_panel_bg";
            }
            message_title_txt = message_prefeb[count + temp].GetComponentsInChildren<UILabel>();
            message_title_txt[0].text = "[" + item.messageTitle + "]";
			message_title_txt[1].text = item.messageContents;
			message_title_txt[2].text = item.messageId+"";
        }

		//for adding
		messageList.Reverse();

        grid.enabled = true;
        count_for_delete += messageList.Count;

		//Debug.Log ("count_for_delete += messageList.Count;" + count_for_delete + "/" + messageList.Count);
        count = -1;
    }

    public void Creating()
    {
        target_prefab = Resources.Load("Prefab/message_bg") as GameObject;
        prefab = Instantiate(target_prefab) as GameObject;
        prefab.name = "message_prefeb";
        prefab.tag = "MessageInstance"; //for delete all
		prefab.transform.parent = PanelManager.instance.mobile_grid.GetComponent<Transform>();

        grid.Reposition();

        prefab.transform.localScale = new Vector3(1, 1, 0);

        count++;

		message_prefeb = GameObject.FindGameObjectsWithTag("MessageInstance");

    }

    public void AllDelete()
    {

		//Debug.Log("BEFORE = temp:"+temp+",count:"+count+",count_for_delete:"+count_for_delete+",AllDelete:"+count_for_delete);

        //for init
        if (count == -1 && count_for_delete == -1) temp = 0;
        else temp = count_for_delete + 1;

		//Debug.Log("END = temp:"+temp+",count:"+count+",count_for_delete:"+count_for_delete+",AllDelete:"+count_for_delete);

        while (count_for_delete > -1)
        {
            //Debug.Log("count_for_delete"+count_for_delete);
            message_prefeb = GameObject.FindGameObjectsWithTag("MessageInstance");
            DestroyObject(message_prefeb[count_for_delete]);
            count_for_delete--;
        }
    }


    public int GetLastestId(){
		int tmpId = 0;
        
		foreach (var item in messageList) {
			if(item.messageId>=tmpId){
				tmpId = item.messageId + 1;
			}
		}
		return tmpId;
	}

	public bool PushMessage(string messageType,string messageTitle,string messageSender,string messageContents){
		SMSMessage message = new SMSMessage ();
		message.messageId = GetLastestId ();
		message.messageType = messageType;
		message.messageTitle = messageTitle;
		message.messageSender = messageSender;
		message.messageContents = messageContents;
		message.receiveDate = CharacterData.instance.playWeek+1;
		message.readFlag = false;
		messageList.Add(message);
		return true;
	}

	public List<SMSMessage> GetMessageList(){
		return messageList;
	}

	public SMSMessage ViewMessage(int messageId){
		foreach (var item in messageList) {
			if(item.messageId==messageId){
				item.readFlag = true;
				return item;
			}
		}
		return null;
	}

	public bool DeleteMessage(int messageId){
		foreach (var item in messageList) {
			if(item.messageId==messageId){
				messageList.Remove (item);
				return true;
			}
		}
		return false;
	}

	public int GetUnreadMessageCount(){
		int tmpCount = 0;

		foreach (var item in messageList) {
			if(item.readFlag==false){
				tmpCount = tmpCount + 1;
			}
		}
		return tmpCount;


	}


}
