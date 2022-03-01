﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorScript : MainDialgueHandler
{
    // Start is called before the first frame update
 

    public DialogueTrigger DTrigger;


    SceneManagerScript SceneHandler;

    GameObject SceneObject;
   

 void Awake()
    {
        SceneObject = GameObject.FindGameObjectWithTag("Loader");
        SceneHandler = SceneObject.GetComponent<SceneManagerScript>();
    }
    public override void setUpCondition()
    {
       
        Inventory inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();

        if(inventory.BodyGuard == false)
        {
            DTrigger.currentDialogue.converstationElement = 2;
            DTrigger.currentDialogue.disableChoice = true;
        }
        else 
        {
            DTrigger.currentDialogue.converstationElement = 0;
            DTrigger.currentDialogue.disableChoice = false;
        }


    }

    public override void executeFunction(string choice)
    {

        Inventory inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        if(inventory.BodyGuard == true)
        {
            PickUpScript pickUpScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PickUpScript>();
           
            //Debug.Log(pickUpScript);
            if(choice == "a")
            {
                TeleportAutside.fromPast = true;
                TeleportAutside.isGoodFuture = true;
                TeleportAutside.isBadFuture = false;

            }

            else if(choice == "b")
            {
                TeleportAutside.fromPast = true;
                TeleportAutside.isGoodFuture = false;
                TeleportAutside.isBadFuture = true;
            }

            else if (choice == "c")
            {
                TeleportAutside.fromPast = true;
                 TeleportAutside.isGoodFuture = false;
                TeleportAutside.isBadFuture = true;
            }

            DTrigger.currentDialogue.converstationElement = DTrigger.currentDialogue.converstationElement + 1;
            DTrigger.currentDialogue.disableChoice = true;
            DTrigger.OnMouseDown();

            //TODO subroutine 
            SceneHandler.LoadNewMap("Bunker");
            
        
        }
        
        
    }

}