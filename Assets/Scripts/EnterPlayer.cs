using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject portal;
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
        portal.SetActive(true);
        yield return new WaitForSecondsRealtime(2);
        player.SetActive(true);
        yield return new WaitForSecondsRealtime(1);
        portal.SetActive(false);
    }

}
