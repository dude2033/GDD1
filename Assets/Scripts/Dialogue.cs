using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue
{    
    public string name;
    public int converstationPosition = 0;


    [System.Serializable]
    public class conversation
    {
        [TextArea(0,4)]
            public string[] sentences;
    }


    public conversation[] Conversation;
    
    [TextArea(1,4)]
    public string[] choises;
    
}

