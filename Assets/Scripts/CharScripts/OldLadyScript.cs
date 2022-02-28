using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OldLadyScript : MainDialgueHandler
{
    // Start is called before the first frame update
    public Sprite Image;
    public DialogueTrigger DTrigger;
    Inventory inventory;

    public bool teddyGone; 
    public override void setUpCondition()
    {
       
        if(teddyGone)
            DTrigger.currentDialogue.converstationElement  =  5;
        else
            DTrigger.currentDialogue.disableChoice = false;  
    }

    public override void executeFunction(string choice)
    {

        PickUpScript pickUpScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PickUpScript>();
        //Debug.Log(pickUpScript);
        if(choice == "a")
        {
            if(DTrigger.currentDialogue.converstationElement == 0)
            {
                DTrigger.currentDialogue.converstationElement  = DTrigger.currentDialogue.converstationElement + 1;
                DTrigger.currentDialogue.choiceElement = DTrigger.currentDialogue.choiceElement + 1;
                DTrigger.OnMouseDown();            
            }

            else if(DTrigger.currentDialogue.converstationElement == 1)
            {
                DTrigger.currentDialogue.converstationElement  = DTrigger.currentDialogue.converstationElement + 1;
                DTrigger.currentDialogue.choiceElement = DTrigger.currentDialogue.choiceElement + 1;
                DTrigger.OnMouseDown();
            }

            else if(DTrigger.currentDialogue.converstationElement == 2)
            {
                DTrigger.currentDialogue.converstationElement  = DTrigger.currentDialogue.converstationElement + 1;
                  
                
                DTrigger.OnMouseDown();
                DTrigger.currentDialogue.disableChoice = true; 
                teddyGone = true;
                pickUpScript.pickUp(Image);
                //TODO: TEDDY
            }

        }

        else if(choice == "b")
        {

           if(DTrigger.currentDialogue.converstationElement == 0)
            {
                DTrigger.currentDialogue.converstationElement  = DTrigger.currentDialogue.converstationElement + 2;
                DTrigger.currentDialogue.choiceElement = DTrigger.currentDialogue.choiceElement + 2;
                DTrigger.OnMouseDown();            
            } 

            else if(DTrigger.currentDialogue.converstationElement == 1)
            {
                DTrigger.currentDialogue.disableChoice = true;   
                DTrigger.currentDialogue.converstationElement = 0;
                DTrigger.currentDialogue.choiceElement = 0;

            }

            else if(DTrigger.currentDialogue.converstationElement == 2)
            {
                DTrigger.currentDialogue.converstationElement  = DTrigger.currentDialogue.converstationElement + 2;
                DTrigger.OnMouseDown();

                DTrigger.currentDialogue.disableChoice = true;  
                teddyGone = true;
                pickUpScript.pickUp(Image);
            }
     
              
        // DTrigger.currentDialogue.converstationElement  = DTrigger.currentDialogue.converstationElement - 1;   

        }

        else if (choice == "c")
        {
            if(DTrigger.currentDialogue.converstationElement == 0)
            {
                DTrigger.currentDialogue.disableChoice = true;
                DTrigger.currentDialogue.converstationElement = 0;
                DTrigger.currentDialogue.choiceElement = 0;
            }
                 
            else if(DTrigger.currentDialogue.converstationElement == 2)
            {
                DTrigger.currentDialogue.converstationElement  = DTrigger.currentDialogue.converstationElement + 1;
   
                DTrigger.OnMouseDown();
                DTrigger.currentDialogue.disableChoice = true;  
                teddyGone = true;
                pickUpScript.pickUp(Image);
                //TODO: TEDDY
            }

            
                
            

        }
            

        
    }

}
