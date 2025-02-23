using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Notify.DamageTaken?.Invoke();
            collision.gameObject.GetComponent<PlayerManager>().RemoveHealth(1);
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Notify.DamageTaken?.Invoke();
            collision.gameObject.GetComponent<PlayerManager>().RemoveHealth(1);
            Destroy(gameObject);
        }
    }
}
