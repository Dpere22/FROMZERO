using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private static readonly int Velocity = Animator.StringToHash("velocity");
    [SerializeField] private Rigidbody2D playerRb;
    [SerializeField] private int movementSpeed;
    [SerializeField] private float dashForce;
    private bool _isDashing;
    
    
    private Animator _animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }
    public void OnMove(InputValue value)
    {
        if (_isDashing) return;
        Vector2 moveVal = value.Get<Vector2>();
        _animator.SetFloat(Velocity, Mathf.Abs(moveVal.x) + Mathf.Abs(moveVal.y));
        playerRb.linearVelocity = moveVal.normalized * movementSpeed;
    }

    public void OnJump(InputValue value)
    {
        if (_isDashing) return;
        StartCoroutine(Dash());
    }

    private IEnumerator Dash()
    {
        _isDashing = true;
        Vector2 currVelocity = playerRb.linearVelocity;
        Vector2 dashDir = playerRb.linearVelocity.normalized * dashForce;
        playerRb.linearVelocity = new Vector2(currVelocity.x, currVelocity.y) + dashDir;
        yield return new WaitForSeconds(0.1f);
        playerRb.linearVelocity = new Vector2(currVelocity.x, currVelocity.y);
        _isDashing = false;
    }
    
}
