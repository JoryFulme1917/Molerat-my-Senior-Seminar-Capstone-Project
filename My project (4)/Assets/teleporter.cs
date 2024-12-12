using UnityEngine;

public class TeleportOnCollision : MonoBehaviour
{
    public GameObject targetObject;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (targetObject != null)
            {
                collision.transform.position = targetObject.transform.position;
                Debug.Log("Player teleported to " + targetObject.name);
            }
        }
    }
}