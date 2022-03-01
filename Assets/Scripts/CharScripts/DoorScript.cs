using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorScript : MainDialgueHandler
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
            
        }

    }

    public override void executeFunction(string choice)
    {

        PickUpScript pickUpScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PickUpScript>();
        Inventory inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        //Debug.Log(pickUpScript);
        if(choice == "a")
        {
           

        }

        else if(choice == "b")
        {


        }

        else if (choice == "c")
        {
            
        }
            
      
        
        
    }
}
