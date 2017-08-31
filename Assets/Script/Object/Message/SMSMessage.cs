using UnityEngine;
using System;
using System.Collections.Generic;

public class SMSMessage{

	public int messageId;
	public int receiveDate;
	public string messageType;
	public string messageTitle;
	public string messageContents;
	public string messageSender;
	public bool readFlag;

	public SMSMessage() {

	}
    public SMSMessage(int messageId, int receiveDate, string messageType, string messageTitle, string messageContents, string messageSender, bool readFlag) {
        this.messageId = messageId;
        this.receiveDate = receiveDate;
        this.messageType = messageType;
        this.messageTitle = messageTitle;
        this.messageContents = messageContents;
        this.messageSender = messageSender;
        this.readFlag = readFlag;
    }
}

