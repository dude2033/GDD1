using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogueTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public Dialogue currentDialogue;
    public bool StartDialogueBool;


    
    
    private void Update() 
    {
        		if(StartDialogueBool)
                    StartDialogue();
    }

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
    public void StartDialogue()
    {
        StartDialogueBool = false;
        Debug.Log("TEST");
        FindObjectOfType<DialogueManager>().StartDialogue(currentDialogue);
        
    }





}
