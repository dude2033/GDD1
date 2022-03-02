using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VendingMachineScript : MainDialgueHandler
{
    // Start is called before the first frame update
    public DialogueTrigger DTrigger;
    public Sprite ImageA;
    public Sprite ImageB;
    public Sprite ImageC;
    public Sprite Coin;
    Inventory inventory;

    private bool finsihed = false;
    public override void setUpCondition()
    {

        Inventory inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        PickUpScript pickUpScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PickUpScript>();
       // pickUpScript.pickUp(Coin);

        if(finsihed == false)
        {
           
           
            for(int i = 0; i < inventory.slots.Length; i++)
            {

                if(inventory.isFull[i] == true)
                {
                    if(inventory.slots[i].transform.GetChild(0).GetComponent<Image>().sprite.name == "Coin")
                    {
                            DTrigger.currentDialogue.converstationElement  = 1;
                            DTrigger.currentDialogue.disableChoice = false;
                            
                    }
                        
                        
                }
                
            }
        }
 
                        

    }

    public override void executeFunction(string choice)
    {

         PickUpScript pickUpScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PickUpScript>();
        //Debug.Log(pickUpScript);
  
        Inventory inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();

        Debug.Log("testestst");
        for(int i = 0; i < inventory.slots.Length; i++)
        {

            if(inventory.isFull[i] == true)
            {
                if(inventory.slots[i].transform.GetChild(0).GetComponent<Image>().sprite.name == "Coin")
                {
                        inventory.slots[i].transform.GetChild(0).transform.gameObject.SetActive(false);
                        inventory.isFull[i] = false;

                        if(choice == "a")
                            pickUpScript.pickUp(ImageA);
                        if(choice == "b")
                            pickUpScript.pickUp(ImageB);
                        if(choice == "c")
                            pickUpScript.pickUp(ImageC);
    
                }
            
            } 

        }
           
            
    }
    
    
}
