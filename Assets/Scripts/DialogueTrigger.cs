using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public Dialogue currentDialogue;
    
    public void TriggerDialogue()
    {
        Debug.Log("TEST");
        FindObjectOfType<DialogueManager>().StartDialogue(currentDialogue);
        
    }


        public void  OnMouseDown() 
    {
        Debug.Log("TEST");
        FindObjectOfType<DialogueManager>().StartDialogue(currentDialogue);
        
    }
}
