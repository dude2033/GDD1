using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryMenu : MonoBehaviour
{
    // Start is called before the first frame update

   public GameObject test;
    private void Start() {
        
        test = GameObject.FindGameObjectWithTag("Inventory");

        for(int i = 0 ; i < test.transform.childCount; i++)
            test.transform.GetChild(i).gameObject.SetActive(true);

    }

    

    // Update is called once per frame

}
