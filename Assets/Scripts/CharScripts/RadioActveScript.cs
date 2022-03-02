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

        GameObject [] slots = GameObject.FindGameObjectsWithTag("Slot");
        Inventory inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        PickUpScript pickUpScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PickUpScript>();

        DTrigger.currentDialogue.disableChoice = true;  

        if(!Inventory.rockAcq)
        {
            slots[slots.Length-1].transform.GetChild(0).GetComponent<Image>().sprite = rock;
            slots[slots.Length-1].transform.GetChild(0).GetComponent<Image>().gameObject.SetActive(true);
            Inventory.rockAcq = true;
        }
         /*   for(int i = 0; i < inventory.slots.Length; i++)
            {

                if(inventory.isFull[i] == false)
                {
                    pickUpScript.pickUp(rock);
                    
                    Inventory.rockAcq = true;
                    break;
                }
                
            }*/


    }

    public override void executeFunction(string choice)
    {


    }
}
