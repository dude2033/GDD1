using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParkTreeScript : MainDialgueHandler
{
    public DialogueTrigger DTrigger;
    public Sprite Image;

    public override void setUpCondition()
    {
    }

    public override void executeFunction(string choice)
    {

       PickUpScript pickUpScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PickUpScript>();
        Debug.Log(pickUpScript);
        if(choice == "a")
        {
            Debug.Log("teee here");
        
            Inventory inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();

            bool checkBranch = false;
            for(int i = 0; i < inventory.slots.Length; i++)
            {

                if(inventory.isFull[i] == true)
                {
                    if(inventory.slots[i].transform.GetChild(0).GetComponent<Image>().sprite.name == "WoodStick")
                        checkBranch= true;
                }

               
            }
           
           if(checkBranch != true)
           {
                pickUpScript.pickUp(Image);
                DTrigger.currentDialogue.converstationElement  = DTrigger.currentDialogue.converstationElement + 1;
                DTrigger.currentDialogue.disableChoice = true;
           }
                
            
                
 
        }
            

        
    }
}
