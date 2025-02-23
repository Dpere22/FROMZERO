using UnityEngine;

public class Cheep : Enemy
{
    [SerializeField] Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb.AddForce(new Vector2(10, 0), ForceMode2D.Impulse);
    }
}
