using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BodyguardScript : MainDialgueHandler
{
    // Start is called before the first frame update
    public Sprite Image;
    public DialogueTrigger DTrigger;

    public GameObject BodyGuard;
   

    private bool start = true; 
    public override void setUpCondition()
    {
       
         Inventory inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();

        if(start == true)
        {
            start = false;
            DTrigger.currentDialogue.disableChoice = false;
            for(int i = 0; i < inventory.slots.Length; i++)
                {

                    if(inventory.isFull[i] == true)
                    {
                        if(inventory.slots[i].transform.GetChild(0).GetComponent<Image>().sprite.name == "BlueDrink")
                        {
                            DTrigger.currentDialogue.choiceElement  = 1;
                            break;
                        }
                        if(inventory.slots[i].transform.GetChild(0).GetComponent<Image>().sprite.name == "RedDrink")
                        {
                            DTrigger.currentDialogue.choiceElement  = 1;
                            break;
                        }
                        if(inventory.slots[i].transform.GetChild(0).GetComponent<Image>().sprite.name == "GreenDrink")
                        {
                            DTrigger.currentDialogue.choiceElement  = 1;
                            break;
                        }
                        
                        
                    }
                
                }
        }

    }

    public override void executeFunction(string choice)
    {

        PickUpScript pickUpScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PickUpScript>();
        Inventory inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        //Debug.Log(pickUpScript);
        if(choice == "a")
        {
            if(DTrigger.currentDialogue.converstationElement == 0)
            {
                DTrigger.currentDialogue.converstationElement  = DTrigger.currentDialogue.converstationElement + 1;
                DTrigger.currentDialogue.choiceElement =  2;
                DTrigger.OnMouseDown();            
            }
           else  if(DTrigger.currentDialogue.converstationElement == 1)
            {
                DTrigger.currentDialogue.disableChoice = true;
                start = true;
                DTrigger.currentDialogue.converstationElement = 0;
                DTrigger.currentDialogue.choiceElement = 0;
            }
            else if(DTrigger.currentDialogue.converstationElement == 2)
            {
                DTrigger.currentDialogue.disableChoice = true;
                start = true;
                DTrigger.currentDialogue.converstationElement = 0;
                DTrigger.currentDialogue.choiceElement = 0;
            }
            else if(DTrigger.currentDialogue.converstationElement == 3)
            {
                DTrigger.currentDialogue.disableChoice = true;
                start = true;
                DTrigger.currentDialogue.converstationElement = 0;
                DTrigger.currentDialogue.choiceElement = 0;
            }

        }

        else if(choice == "b")
        {

           if(DTrigger.currentDialogue.converstationElement == 0)
            {
                DTrigger.currentDialogue.converstationElement  = DTrigger.currentDialogue.converstationElement + 2;
                DTrigger.currentDialogue.choiceElement =  3;
                DTrigger.OnMouseDown();            
            } 

          
     
              
        // DTrigger.currentDialogue.converstationElement  = DTrigger.currentDialogue.converstationElement - 1;   

        }

        else if (choice == "c")
        {
            if(DTrigger.currentDialogue.converstationElement == 0)
            {
               
                DTrigger.currentDialogue.converstationElement = 3;
                DTrigger.currentDialogue.choiceElement = 4;
                DTrigger.OnMouseDown();
            }           

        }
            
        else if (choice == "d")
        {
            if(DTrigger.currentDialogue.converstationElement == 0)
            {

            for(int i = 0; i < inventory.slots.Length; i++)
                {

                    if(inventory.isFull[i] == true)
                    {
                        if(inventory.slots[i].transform.GetChild(0).GetComponent<Image>().sprite.name == "BlueDrink")
                        {
                            DTrigger.currentDialogue.converstationElement = 5;
                            DTrigger.currentDialogue.disableChoice = true;
                            inventory.slots[i].transform.GetChild(0).transform.gameObject.SetActive(false);
                            inventory.isFull[i] = false;
                            DTrigger.OnMouseDown();
                            start = true;
                            DTrigger.currentDialogue.converstationElement = 0;
                            DTrigger.currentDialogue.choiceElement = 0;
                            break;
                        }
                        if(inventory.slots[i].transform.GetChild(0).GetComponent<Image>().sprite.name == "RedDrink")
                        {
                            DTrigger.currentDialogue.converstationElement = 4;
                            DTrigger.currentDialogue.disableChoice = true;
                            inventory.slots[i].transform.GetChild(0).transform.gameObject.SetActive(false);
                            inventory.isFull[i] = false;
                            DTrigger.OnMouseDown();
                            start = true;
                            DTrigger.currentDialogue.converstationElement = 0;
                            DTrigger.currentDialogue.choiceElement = 0;

                            BodyGuard.GetComponent<NPCMovement>().conditionToMove = true;

                            break;
                        }
                        if(inventory.slots[i].transform.GetChild(0).GetComponent<Image>().sprite.name == "GreenDrink")
                        {
                            DTrigger.currentDialogue.converstationElement = 5;
                            DTrigger.currentDialogue.disableChoice = true;
                            inventory.slots[i].transform.GetChild(0).transform.gameObject.SetActive(false);
                            inventory.isFull[i] = false;
                            DTrigger.OnMouseDown();
                            start = true;
                            DTrigger.currentDialogue.converstationElement = 0;
                            DTrigger.currentDialogue.choiceElement = 0;
                            break;
                        }
                        
                        
                    }
                
                }
               

            }           

        }
        
    }
}
