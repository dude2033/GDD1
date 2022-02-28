using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogueTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public Dialogue currentDialogue;
    public bool StartDialogueBool;


    public bool DialoagIsActive;

    public bool ChoiceIsSet = false;
    public string choice = "";

    public MainDialgueHandler script; 


   
    private void Update() 
    {

        if(DialoagIsActive && ChoiceIsSet)
        {
            script.executeFunction(choice);
            choice = "";
            
           // test.testFunction();
            //TODO: set script event here

        }
    }


    public void  OnMouseDown() 
    {
        DialoagIsActive = true;
        //Debug.Log("TEST");
        script.setUpCondition();
        FindObjectOfType<DialogueManager>().StartDialogue(currentDialogue, this);
        
    }

}
