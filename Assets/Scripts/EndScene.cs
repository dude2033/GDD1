using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScene : MonoBehaviour
{
    public GameObject Good;

    public GameObject Bad;
    private void Awake()
    {
        if (TeleportAutside.isBadFuture == true)
        {
            Bad.SetActive(true);
        }
        if (TeleportAutside.isGoodFuture == true)
        {
            Good.SetActive(true);
        }
    }
}
