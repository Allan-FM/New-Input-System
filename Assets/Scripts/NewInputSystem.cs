using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewInputSystem : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    private Rigidbody2D rb;
    private PlayerInputActions inputActions;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        inputActions = new PlayerInputActions();
        inputActions.PlayerControls.Enable();
    }
    private void Update()
    {
        Vector2 moveInput = inputActions.PlayerControls.Moviment.ReadValue<Vector2>();
        rb.velocity = moveInput * speed * Time.deltaTime;
    }
}
