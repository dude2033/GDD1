using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] slots;
    public bool[] isFull;

    public bool stickch = false;
    public bool chew = false;

    public bool chewStickch = false;

    public void setGameObjectVisible(int position)
    {
        slots[position].SetActive(true);
    }

}
