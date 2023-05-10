using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : GeneralAnimation
{
    Rigidbody2D rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        StatSetting(100, 10, 7, 4, 50);
    }

    void Update()
    {
        rb.velocity = new Vector3(Input.GetAxis("Horizontal") * Stats.MoveSpeed, rb.velocity.y, 0);
        if(Input.GetAxis("Horizontal") !=0)
        {
            StateUpdate(CharacterStates.Run);
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            StateUpdate(CharacterStates.Jump);
            rb.velocity = Vector2.up * Stats.JumpForce;
        }
        if(!Input.anyKey&&rb.velocity == Vector2.zero)
        {
            StateUpdate(CharacterStates.Idle);
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            StateUpdate(CharacterStates.Ladder);
            
        }
    }
}
