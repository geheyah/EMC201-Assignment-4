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
    private Enemy enemy;
    private static readonly int IsWalking = Animator.StringToHash("IsWalking");
    private static readonly int IsJumping = Animator.StringToHash("IsJumping");
    private static readonly int IsSprinting = Animator.StringToHash("IsSprinting");

    void Start()
    {
        enemy = GetComponent<EnemyAI>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _playerRigidbody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        _spriteRenderer.flipX = !(enemy.xInput < 0);
        
        //checking if animator is working
        Debug.Log(Mathf.Abs(enemy.xInput));
        
        //walking
        _animator.SetBool(EnemyWalking, Mathf.Abs(enemy.xInput) > 0);

        //jumping

        _animator.SetBool(IsJumping, Input.GetKey(KeyCode.W));

        //sprinting

        _animator.SetBool(IsSprinting, Input.GetKey(KeyCode.LeftShift));
    }
}