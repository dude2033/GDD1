using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryEvents : MonoBehaviour
{
    // Start is called before the first frame update

    Inventory inventory;

    public Sprite combindStickch;
    public Sprite chewedGum;

    private void Start() 
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();    
    }

    public void setUpChewStickch()
    {
    

        for(int i = 0; i < inventory.slots.Length; i++)
        {

            if(inventory.isFull[i] == true)
            {
                if(inventory.slots[i].transform.GetChild(0).GetComponent<Image>().sprite.name == "WoodStick")
                {
                    inventory.stickch = true;
                }

                if(inventory.slots[i].transform.GetChild(0).GetComponent<Image>().sprite.name == "Chewing Gum")
                {

                    inventory.slots[i].transform.GetChild(0).GetComponent<Image>().sprite = chewedGum;
                    inventory.isFull[i] = true;
                    inventory.chew = true; 
                }

            }            
        }
        
        if(inventory.chew && inventory.stickch && !inventory.chewStickch)
        {
            for(int i = 0; i < inventory.slots.Length; i++)
            {

                if(inventory.slots[i].transform.GetChild(0).GetComponent<Image>().sprite.name == "WoodStick")
                {

                    inventory.slots[i].transform.GetChild(0).transform.gameObject.SetActive(false);
                    inventory.isFull[i] = false;
                }

                if(inventory.slots[i].transform.GetChild(0).GetComponent<Image>().sprite.name == "ChewedChewingGum")
                {
                    inventory.slots[i].transform.GetChild(0).transform.gameObject.SetActive(false);
                    inventory.isFull[i] = false;
                }
                            
            }
            for(int i = 0; i < inventory.slots.Length; i++)
            {

                if(inventory.isFull[i] == false)
                    {
                        
                        inventory.slots[i].transform.GetChild(0).GetComponent<Image>().sprite = combindStickch;
                        inventory.slots[i].transform.GetChild(0).transform.gameObject.SetActive(true);
                        inventory.isFull[i] = true;
                        inventory.chewStickch = true;
                        break;
                    }  
                                    
            }
            

        }


    }

    public  void inventoryBtnEvent1()
    {
        Debug.Log("Do something and check for condition");
        setUpChewStickch();
      //  gameObject.SetActive(false);
       // inventory.isFull[0] = false;
    }
    public void inventoryBtnEvent2()
    {
        setUpChewStickch();
       // gameObject.SetActive(false);
       // inventory.isFull[1] = false;
    }
    public void inventoryBtnEvent3()
    {
        setUpChewStickch();
        //gameObject.SetActive(false);
       // inventory.isFull[2] = false;
    }
 
}
