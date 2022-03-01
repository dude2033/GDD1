using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotTestScript : MainDialgueHandler
{

    public DialogueTrigger DTrigger;

    public override void setUpCondition()
    {
        DTrigger.currentDialogue.disableChoice = true;
    }
    public override void executeFunction(string choise)
    {
        if(choise == "a")
        {
            Debug.Log("it works fine though");
            //DTrigger.currentDialogue.converstationElement  = DTrigger.currentDialogue.converstationElement + 1;
            DTrigger.OnMouseDown();


        }
            

        
    }
}
