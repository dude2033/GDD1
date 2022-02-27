using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] slots;


    public void setGameObjectVisible(int position)
    {
        slots[position].SetActive(true);
    }

}
