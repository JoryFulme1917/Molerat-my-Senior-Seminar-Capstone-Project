using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkText : MonoBehaviour
{
    public GameObject Speech;
    public GameObject Speech1;
    public GameObject Speech2;

    void Start()
    {
        Speech.SetActive(false);
        Speech1.SetActive(false);
        Speech2.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Speech.SetActive(true);
            StartCoroutine(WaitForSec());
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            StopAllCoroutines();
            Speech.SetActive(false);
            Speech1.SetActive(false);
            Speech2.SetActive(false);
        }
    }

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(3);
        Speech.SetActive(false);
        Speech1.SetActive(true);
        yield return new WaitForSeconds(3);
        Speech1.SetActive(false);
        Speech2.SetActive(true);
        yield return new WaitForSeconds(3);
        Speech2.SetActive(false);
    }
}