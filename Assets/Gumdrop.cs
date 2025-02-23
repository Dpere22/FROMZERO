using UnityEngine;

public class Gumdrop : Enemy
{
    [SerializeField] private Rigidbody2D rb;

    [SerializeField] private int speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb.linearVelocity = Vector2.down * speed;
    }
}
