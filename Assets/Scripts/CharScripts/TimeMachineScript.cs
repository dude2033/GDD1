using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeMachineScript : MainDialgueHandler
{
    // Start is called before the first frame update    public DialogueTrigger DTrigger;
    public DialogueTrigger DTrigger;
    
    public override void setUpCondition()
    {
        Inventory inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        DTrigger.currentDialogue.disableChoice = true;
        for(int i = 0; i < inventory.slots.Length; i++)
        {

            if(inventory.isFull[i] == true)
            {
                

                if(inventory.slots[i].transform.GetChild(0).GetComponent<Image>().sprite.name == "RadioactiveStone2")
                {
                    FirstRiddleCallScript script = GameObject.FindObjectOfType<FirstRiddleCallScript>();
                    script.CustomOnMouseDown();
                    break;
                }
            
            }
        
        }
           


    }
    public override void executeFunction(string choise)
    {
          

        
    }
}
