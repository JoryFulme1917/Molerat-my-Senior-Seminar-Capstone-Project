using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GemKey : MonoBehaviour
{

    public GameObject BlockGate;
    public GameObject Message;
    public GameObject CrystalGraphic;
   
    private void Start()
    {
     
        Message.SetActive(false);
        BlockGate.SetActive(true);
        CrystalGraphic.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Player"))
        {
            CrystalGraphic.SetActive(false);
            BlockGate.SetActive(false);
            Message.SetActive(true);
            StartCoroutine(WaitforSec());
        }
      
    }
    IEnumerator WaitforSec()
    {
        yield return new WaitForSeconds(3);
        Destroy(Message);
        Destroy(gameObject);
    }

    

    }
