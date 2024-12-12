using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quiter : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("see ya!");
        }
    }
}
