using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue
{    
    public string name;
    public int converstationElement = 0;

    


    [System.Serializable]
    public class conversation
    {
        [TextArea(0,4)]
            public string[] sentences;
    }

    [System.Serializable]
    public class conversationChoices
    {
        [TextArea(1,4)]
            public string[] choices;
    }


    public conversation[] Conversation;
    

    public bool disableChoice;
    public int choiceElement = 0;
    public conversationChoices[] Choices;
    
}

