using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScript : MonoBehaviour
{
    // Start is called before the first frame update

    private Inventory inventory;
    public GameObject item;

    void Start()
    {
      
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other) 
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        inventory.slots = GameObject.FindGameObjectsWithTag("Slot");
        Debug.Log("here");
        Debug.Log(inventory.slots.Length);

        Debug.Log("Test");
        if(other.CompareTag("Player"))
        {
            for(int i = 0; i < inventory.slots.Length; i++)
            {

                Debug.Log(inventory.slots[i]);
                if(inventory.isFull[i] == false)
                {
                     inventory.isFull[i] = true;

                     Instantiate(item, inventory.slots[i].transform, false);

                     Destroy(gameObject);
                     break;
                }
               
            }
                
        

        }
    }
}
