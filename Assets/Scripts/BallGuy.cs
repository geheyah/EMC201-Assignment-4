using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGuy : MonoBehaviour
{
    public Rigidbody2D Player;
    public float speed = 10.0f;

    private Rigidbody rb;

    // Variables for Sprint
    [SerializeField]
    private float SprintM = 1.25f;

    [SerializeField]
    private bool Sprint = false;
    public float Speed = 10.0f;

    // Variables for Jump and DoubleJump
    public float jumpHeight = 5f;
    public float doubleJumpHeight = 3f;
    private bool canDoubleJump = false;


        void Start()
    {

    }                 

    void Update()
    {
        // Player Movement
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        Vector2 movementInput = new Vector2(horizontal, vertical);

        // Sprint or Move
        Sprint = Input.GetKey(KeyCode.LeftShift);
        Move(movementInput);

        //Jump and Double Jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

    }
    // Function for Jump and Double Jump
    void Jump()
    {
  
    }
    // Function for Sprint or Move
    void Move (Vector2 input)
    {
        float ifSprinting = 1.0f;
        if (Sprint)
        {
            ifSprinting = SprintM;
        }

        var transform1 = transform;
        var position1 = transform1.position;
        Vector3 position = new Vector3(Speed * input.x, Speed * input.y, position1.z);
        position1 = position1 + (position * (Time.deltaTime * ifSprinting));
        transform1.position = position1;
    }


}
