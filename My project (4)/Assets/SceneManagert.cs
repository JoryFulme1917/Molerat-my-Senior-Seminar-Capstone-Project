//sampled from:
//https://www.youtube.com/watch?v=E25JWfeCFPA

using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagert : MonoBehaviour
{
    public static SceneManagert instance;

    private void Awake()
    {
        if (instance == null) 
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);    
        }
    }
    public void NextArea()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1); 
    }

    public void LoadScene(string mapName) 
    {
        SceneManager.LoadSceneAsync(mapName);
    }
}
