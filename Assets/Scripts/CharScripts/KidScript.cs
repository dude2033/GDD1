using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KidScript : MainDialgueHandler
{
    // Start is called before the first frame update    public DialogueTrigger DTrigger;
    public Sprite Image;
    public DialogueTrigger DTrigger;

    private bool finished;

    public override void setUpCondition()
    {
     
        if(finished == false) 
        {
            Inventory inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();


            DTrigger.currentDialogue.disableChoice = false;
            for(int i = 0; i < inventory.slots.Length; i++)
                {

                    if(inventory.isFull[i] == true)
                    {
                        if(inventory.slots[i].transform.GetChild(0).GetComponent<Image>().sprite.name == "TeddyBear")
                        {
                            DTrigger.currentDialogue.choiceElement  = 1;
                            break;
                        }
                        
                        
                    }
                
                }
                
        }
        else
            DTrigger.currentDialogue.converstationElement  = 2;

    }

    public override void executeFunction(string choice)
    {

        if(finished == false)
        {
            PickUpScript pickUpScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PickUpScript>();
            //Debug.Log(pickUpScript);
            if(choice == "a")
            {

                DTrigger.currentDialogue.converstationElement  = DTrigger.currentDialogue.converstationElement + 1;
            
                DTrigger.OnMouseDown();            
                DTrigger.currentDialogue.disableChoice = true;
                DTrigger.currentDialogue.converstationElement  = 0;
            }

            else if(choice == "b")
            {
                DTrigger.currentDialogue.converstationElement  = DTrigger.currentDialogue.converstationElement + 2;
                DTrigger.OnMouseDown();        
                DTrigger.currentDialogue.disableChoice = true;    
                Inventory inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();

                for(int i = 0; i < inventory.slots.Length; i++)
                    {

                        if(inventory.isFull[i] == true)
                        {
                            if(inventory.slots[i].transform.GetChild(0).GetComponent<Image>().sprite.name == "TeddyBear")
                            {
                                inventory.slots[i].transform.GetChild(0).GetComponent<Image>().sprite = Image;
                                finished = true;
                                break;
                            }
                            
                            
                        }
                    
                    }

            // pickUpScript.pickUp(Image);
            // DTrigger.currentDialogue.converstationElement  = DTrigger.currentDialogue.converstationElement - 1;   
    
            }
        }

            

        
    }
}
