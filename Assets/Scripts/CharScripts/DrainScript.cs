using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrainScript : MainDialgueHandler
{
    // Start is called before the first frame update
  public Sprite Image;
    public DialogueTrigger DTrigger;

    private bool finsihed = false;

    public override void setUpCondition()
    {
     

        Inventory inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        DTrigger.currentDialogue.disableChoice = true;
        finsihed = false;
        for(int i = 0; i < inventory.slots.Length; i++)
        {

            if(inventory.isFull[i] == true)
                
            if(inventory.slots[i].transform.GetChild(0).GetComponent<Image>().sprite.name == "Coin")
                {
                    finsihed = true;
                    break;
                }
        }


        for(int i = 0; i < inventory.slots.Length; i++)
            {

                if(inventory.isFull[i] == true)
                {
                    
    
                    if(inventory.slots[i].transform.GetChild(0).GetComponent<Image>().sprite.name == "Coin")
                    {
                        finsihed = true;
                        break;
                    }
                
                    if(inventory.slots[i].transform.GetChild(0).GetComponent<Image>().sprite.name == "WoodStick")
                    {
                        DTrigger.currentDialogue.converstationElement  = 1;
                        break;
                    }

                    if(inventory.slots[i].transform.GetChild(0).GetComponent<Image>().sprite.name == "ChewedChewingGumOnStick")
                    {
                        DTrigger.currentDialogue.converstationElement  = 2;
                        PickUpScript pickUpScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PickUpScript>();
                        if(finsihed == false) 
                        {           
                                Debug.Log("in drain ;)");         
                                pickUpScript.pickUp(Image);
                                finsihed = true;
                        }
                        break;
                    }

                }
            
            }
                        

        

    }

    public override void executeFunction(string choice)
    {
 

          

    }
}
