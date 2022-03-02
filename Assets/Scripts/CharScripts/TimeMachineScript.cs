using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeMachineScript : MainDialgueHandler
{
    // Start is called before the first frame update    public DialogueTrigger DTrigger;
    public DialogueTrigger DTrigger;


    public Sprite rock;
    public bool finsihed = false; 
    
    public override void setUpCondition()
    {
        Inventory inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        PickUpScript pickUpScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PickUpScript>();
        FirstRiddleCallScript script = GameObject.FindObjectOfType<FirstRiddleCallScript>();
        DTrigger.currentDialogue.disableChoice = true;

        //pickUpScript.pickUp(rock);

           if(Inventory.rockAcq)
           {
            DTrigger.currentDialogue.converstationElement =  1;
            GameObject  [] test  = GameObject.FindGameObjectsWithTag("Slot");
            //test[3].transform.GetChild(0).gameObject.SetActive(false);    
            Destroy(test[3]);
            script.CustomOnMouseDown();
           }
             


    }
    public override void executeFunction(string choise)
    {
          

        
    }
}
