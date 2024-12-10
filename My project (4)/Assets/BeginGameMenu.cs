using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeginGameMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadSceneAsync("Cave_1");
    }
}
