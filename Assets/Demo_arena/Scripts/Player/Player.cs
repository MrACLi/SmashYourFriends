using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class Player : MonoBehaviour
{
    private Rigidbody m_Rigidbody;
    private bool isGrounded;
    [SerializeField]private float checkDistance;

    public float jumpPower = 10.0f;
    public float moveSpeed = 7.0f;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();

    }

    void Update()
    {
        
    }

    public void Move(Vector3 move, bool jump)
    {
        if (move.magnitude > 1) move.Normalize();
        CheckIsGrounded();
        if (isGrounded)
        {
            HandleSurfaceMove(move, jump);
        }
        else
        {
            HandleMidairMove();
        }

    }

    private void CheckIsGrounded()
    {
        // RaycastHit hitinfo;
        if(Physics.Raycast(transform.position, Vector3.down, checkDistance))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
    }

    private void HandleMidairMove()
    {
        m_Rigidbody.AddForce(Physics.gravity);
    }

    private void HandleSurfaceMove(Vector3 move, bool jump)
    {
        if (jump)
        {
            m_Rigidbody.velocity = new Vector3(m_Rigidbody.velocity.x, jumpPower, m_Rigidbody.velocity.z);
        }
        else
        {
            m_Rigidbody.velocity = move * moveSpeed;
        }
    }

}
