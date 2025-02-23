using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerManager>().AddHealth(1);
            Destroy(gameObject);
        } 
    }
}
