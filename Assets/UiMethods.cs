using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UiMethods : MonoBehaviour
{
    private string _messageToSend = string.Empty;
    public Text ChatText;
    Scrollbar _scrollBar;
    float _oldSize;
    float _newSize;
    string _currentGroup = string.Empty;
    public bool groupBox = false;
    // Use this for initialization
    void Start()
    {
        _scrollBar = GetComponentInChildren<Scrollbar>(); // FindObjectOfType<Scrollbar>();
        _oldSize = _scrollBar.size;
        _newSize = _oldSize;
        _scrollBar.value = 0;
        if (gameObject.name.Contains("Group"))
        {
            groupBox = true;
        }
        if (!groupBox)
        {
            //Event general
            
        }
        else
        {
            //Event group
            
        }


    }

    private void Instance_ChatMessageGotGroup(string message)
    {
        ChatText.text = string.Concat(ChatText.text, "\n", message);
    }

    private void Instance_ChatMessageGot(string message)
    {
        ChatText.text = string.Concat(ChatText.text, "\n", message);
    }

    public void GrapForGeneralChat(string message)
    {
        _messageToSend = message;
        Debug.Log(message);
    }
    public void InsertToChatBox()
    {

        if (_messageToSend != string.Empty)
        {
            ChatText.text = string.Concat(ChatText.text, "\n", _messageToSend);
            //Send to server general
           
            _messageToSend = string.Empty;
        }
    }

    public void InserToGroupChatBox()
    {
        if (_messageToSend != string.Empty)
        {
            ChatText.text = string.Concat(ChatText.text, "\n", _messageToSend);
            //Send to server group
            
            _messageToSend = string.Empty;
        }
    }
    public void CheckIfNeedToGoDown()
    {
        _newSize = _scrollBar.size;
        if (_newSize != _oldSize)
        {
            _scrollBar.value = 0;
            _oldSize = _newSize;
        }
    }
    public void JoinGroup(string groupName)
    {
        //Leave old group
        
        _currentGroup = groupName;
        //Join new group
        
    }

    //Remove events
}
