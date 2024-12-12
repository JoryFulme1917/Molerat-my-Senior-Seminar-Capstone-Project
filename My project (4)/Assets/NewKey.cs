using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewKey : MonoBehaviour
{
    public GameObject NewGate;
    public GameObject NewMessage;
    public GameObject NewCrystal;

    // Start is called before the first frame update
    private void Start()
    {
        NewMessage.SetActive(false);
        NewGate.SetActive(true);
        NewCrystal.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            NewCrystal.SetActive(false);
            NewGate.SetActive(false);
            NewMessage.SetActive(true);
            StartCoroutine(WaitforSec());
        }
    }
    IEnumerator WaitforSec()
    {
        yield return new WaitForSeconds(3);
        Destroy(NewMessage);
        Destroy(gameObject);
    }
}
