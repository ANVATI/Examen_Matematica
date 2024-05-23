using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class salto : MonoBehaviour
{
    [SerializeField] Rigidbody2D Player;
    
    [SerializeField] bool isJumping;
    [SerializeField] float fuerzadesalto;
    [SerializeField] bool aumentarsalto;


    public void Saltoconfuerza(InputAction.CallbackContext Salto)
    {
      
        
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

    public  void aceleracion(InputAction.CallbackContext aumentarfuerzasalto)
    {
        fuerzadesalto =+100f;
    }
}
