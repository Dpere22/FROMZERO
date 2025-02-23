using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerManager>().AddHealth(1);
            Destroy(gameObject);
        }
    }
}
