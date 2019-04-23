using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Player))]

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Transform m_Cam;
    [SerializeField] private Vector3 m_CamForward;
    [SerializeField] private Vector3 m_Move;

    private bool pressedJump;

    private Player m_Player;

    // Start is called before the first frame update
    void Start()
    {
        m_Player = GetComponent<Player>();
        // 获取MainCamera用来作为参考控制Player
        if(Camera.main != null)
        {
            m_Cam = Camera.main.transform;
        }else
        {
            Debug.Log("No main camera(Tagged as MainCamera) in use, controller will use world coordinate");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(!pressedJump)
            pressedJump = Input.GetKeyDown(KeyCode.Space);
        
    }

    private void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        if(m_Cam != null)
        {
            m_CamForward = Vector3.ProjectOnPlane(m_Cam.forward, new Vector3(0, 1, 0));
            m_Move = m_CamForward * v + m_Cam.right * h;
        }
        else
        {
            m_Move = Vector3.forward * v + Vector3.right * h;
        }
        m_Player.Move(m_Move, pressedJump);
        pressedJump = false;
    }
}
