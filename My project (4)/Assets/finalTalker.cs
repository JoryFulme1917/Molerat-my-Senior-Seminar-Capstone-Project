using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement; // Required for scene management

public class TalkTextAlt : MonoBehaviour
{
    public GameObject AltSpeech;
    public GameObject AltSpeech1;
    public GameObject AltSpeech2;

    void Start()
    {
        AltSpeech.SetActive(false);
        AltSpeech1.SetActive(false);
        AltSpeech2.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            AltSpeech.SetActive(true);
            StartCoroutine(WaitForAltSec());
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            StopAllCoroutines();
            AltSpeech.SetActive(false);
            AltSpeech1.SetActive(false);
            AltSpeech2.SetActive(false);
        }
    }

    IEnumerator WaitForAltSec()
    {
        yield return new WaitForSeconds(3);
        AltSpeech.SetActive(false);
        AltSpeech1.SetActive(true);
        yield return new WaitForSeconds(3);
        AltSpeech1.SetActive(false);
        AltSpeech2.SetActive(true);
        yield return new WaitForSeconds(3);
        AltSpeech2.SetActive(false);

        // Load the alternate final scene
        SceneManager.LoadScene("FinalScreen"); // Replace "AlternateFinalScreen" with the name of your alternate final scene
    }
}
