using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryEvents : MonoBehaviour
{
    // Start is called before the first frame update

    Inventory inventory;

    private void Start() 
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();    
    }

    public  void inventoryBtnEvent1()
    {
        Debug.Log("Do something and check for condition");
        gameObject.SetActive(false);
        inventory.isFull[0] = false;
    }
    public void inventoryBtnEvent2()
    {
        gameObject.SetActive(false);
        inventory.isFull[1] = false;
    }
    public void inventoryBtnEvent3()
    {
        gameObject.SetActive(false);
        inventory.isFull[2] = false;
    }
 
}
