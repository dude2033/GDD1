using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpScript : MonoBehaviour
{
    // Start is called before the first frame update

    private Inventory inventory;
    private void Start() {
        
    }

   // public GameObject item;
    public void pickUp(Sprite image) 
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        inventory.slots = GameObject.FindGameObjectsWithTag("Slot");
      //  Debug.Log("here");
       // Debug.Log(inventory.slots.Length);
       // Debug.Log("Test");

            for(int i = 0; i < inventory.slots.Length; i++)
            {
            //    Debug.Log(i);
                
              //  Debug.Log(inventory.isFull.Length);
                if(inventory.isFull[i] == false)
                {
                    inventory.isFull[i] = true;
                    inventory.slots[i].transform.GetChild(0).GetComponent<Image>().sprite = image;
                    inventory.slots[i].transform.GetChild(0).GetComponent<Image>().gameObject.SetActive(true);
                     break;
                }
               
            }
                
        

        
    }
}
