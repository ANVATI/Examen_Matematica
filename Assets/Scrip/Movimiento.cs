using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movimiento : MonoBehaviour
{
    private Transform _compTransform;
    private float moveInput;
    public float speed;

    void Start()
    {
        _compTransform = GetComponent<Transform>();
    }

    void Update()
    {
        float moveAmount = moveInput * speed * Time.deltaTime;
        _compTransform.Translate(Vector3.right * moveAmount);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<float>();
    }
}
