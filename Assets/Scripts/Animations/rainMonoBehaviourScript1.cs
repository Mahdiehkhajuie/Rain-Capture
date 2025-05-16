using UnityEngine;

public class RainDrop : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerHealth player = other.GetComponent<PlayerHealth>();
            if (player != null)
            {
                player.AddHealth(10);
                Destroy(gameObject); 
            }
        }
    }
}
