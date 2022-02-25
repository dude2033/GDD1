using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotTestScript : MainDialgueHandler
{

    public DialogueTrigger testTrigger;


    public override void executeFunction(string choise)
    {
        if(choise == "a")
        {
            Debug.Log("it works fine though");
            testTrigger.currentDialogue.converstationPosition  = testTrigger.currentDialogue.converstationPosition + 1;
            testTrigger.OnMouseDown();


        }
            

        
    }
}
