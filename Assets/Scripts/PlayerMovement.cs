using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private static readonly int Velocity = Animator.StringToHash("velocity");
    [SerializeField] private Rigidbody2D playerRb;
    [SerializeField] private int movementSpeed;
    
    private Animator _animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }
    public void OnMove(InputValue value)
    {
        Vector2 moveVal = value.Get<Vector2>();
        _animator.SetFloat(Velocity, Mathf.Abs(moveVal.x) + Mathf.Abs(moveVal.y));
        playerRb.linearVelocity = moveVal.normalized * movementSpeed;
    }
}
