using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.InputSystem;

public class salto : MonoBehaviour
{
    [SerializeField] Rigidbody2D Player;
    [SerializeField] float time_after_jump;
    [SerializeField] bool isJumping;
    [SerializeField] float fuerzadesalto;


    public void Saltoconfuerza(InputAction.CallbackContext Salto)
    {
        time_after_jump = Time.time + 1f;
     

        if (Time.time > time_after_jump)
        {
            isJumping = true;
        }
        if (isJumping)
        {
            Player.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, fuerzadesalto));
            isJumping = false;
        }
    }

    private void Start()
    {
      
        isJumping = true;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Suelo"))
        {
            isJumping = true;
        }
    }
}
