using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterFutureBunker : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject Text;

    void Start()
    {
        StartCoroutine(waiter());
    }

    IEnumerator waiter()
    {
        Text.SetActive(true);
        yield return new WaitForSecondsRealtime(2);
        Text.SetActive(false);
        yield return new WaitForSecondsRealtime(1);
        player.SetActive(true);
    }

}
