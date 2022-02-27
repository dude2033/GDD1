using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryEvents : MonoBehaviour
{
    // Start is called before the first frame update

    public  void inventoryBtnEvent1()
    {
        Debug.Log("Do something and check for condition");
        Destroy(gameObject);
    }
    public void inventoryBtnEvent2()
    {
        Destroy(gameObject);
    }
    public void inventoryBtnEvent3()
    {
        Destroy(gameObject);
    }
 
}
