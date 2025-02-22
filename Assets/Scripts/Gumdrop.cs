using UnityEngine;

public class Gumdrop : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerManager>().RemoveHealth(1);
            Destroy(gameObject);
        }
    }
}
