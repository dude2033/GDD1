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

    public bool ChoiseIsSet = false;
    public string choise = "";

    public MainDialgueHandler script; 


   
    private void Update() 
    {

        if(DialoagIsActive && ChoiseIsSet)
        {
            script.executeFunction(choise);
            choise = "";
            
           // test.testFunction();
            //TODO: set script event here

        }
    }


    public void  OnMouseDown() 
    {
        DialoagIsActive = true;
        Debug.Log("TEST");
        FindObjectOfType<DialogueManager>().StartDialogue(currentDialogue, this);
        
    }

}
