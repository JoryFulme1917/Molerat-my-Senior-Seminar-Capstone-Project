//sampled from:
//https://www.youtube.com/watch?v=E25JWfeCFPA
using UnityEngine;

public class ChangeArea : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SceneManagert.instance.NextArea();
        }
    }
}
