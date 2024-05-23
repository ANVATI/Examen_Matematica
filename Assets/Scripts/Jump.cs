using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.InputSystem;

public class Jump : MonoBehaviour
{
    Rigidbody2D myRBD2D;
    public float m_Thrust = 0.1f;
    private bool isStarted = true;
    private bool isJump = false;
    void Start()
    {
        myRBD2D = GetComponent<Rigidbody2D>();
    }
    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.started && isStarted)
        {
            StartCoroutine(JumpCorroutine());
        }
        if (context.canceled)
        {
            myRBD2D.AddForce(transform.up *  -m_Thrust * 0.2f, ForceMode2D.Impulse);
        }
    }
    IEnumerator JumpCorroutine()
    {
        myRBD2D.AddForce(transform.up * m_Thrust, ForceMode2D.Impulse);
        isStarted = false;                       
        yield return new WaitForSeconds(1.5f);
        isStarted = true;
    }
}
