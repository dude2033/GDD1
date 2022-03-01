using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RadioActveScript : MainDialgueHandler
{
    // Start is called before the first frame update

    public DialogueTrigger DTrigger;
    public Sprite rock;
    public override void setUpCondition()
    {

        Inventory inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        PickUpScript pickUpScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PickUpScript>();

        DTrigger.currentDialogue.disableChoice = true;  

        if(!Inventory.rockAcq)
            for(int i = 0; i < inventory.slots.Length; i++)
            {

                if(inventory.isFull[i] == false)
                {
                    pickUpScript.pickUp(rock);
                    
                    Inventory.rockAcq = true;
                    break;
                }
                
            }


    }

    public override void executeFunction(string choice)
    {


    }
}
