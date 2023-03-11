using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class AnimationController : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator _animator;
    private Rigidbody2D _playerRigidbody;
    private SpriteRenderer _spriteRenderer;
    private static readonly int IsWalking = Animator.StringToHash("IsWalking");
    private static readonly int IsJumping = Animator.StringToHash("IsJumping");
    private static readonly int IsSprinting = Animator.StringToHash("IsSprinting");

    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _playerRigidbody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        _spriteRenderer.flipX = _playerRigidbody.velocity.x < 0;
        
        //checking if animator is working
        Debug.Log("your animator is working");
        
        //walking
        _animator.SetBool(IsWalking, Mathf.Abs(_playerRigidbody.velocity.x) > 0);

        //jumping

        _animator.SetBool(IsJumping, Input.GetKey(KeyCode.W));

        //sprinting

        _animator.SetBool(IsSprinting, Input.GetKey(KeyCode.LeftShift));
    }
}