using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class PlayerMovement : MonoBehaviour
{
    private PlayerControls _playerControls;

    private PlayerInput _playerInput;
    
    // private PlayerControls _playerControls;
    private Transform _transform;
    [SerializeField] private float speed;
    
    private Vector2 _move;

    private void Awake()
    {
        _playerInput = GetComponent<PlayerInput>();

        _transform = GetComponent<Transform>();
        _playerControls = new PlayerControls();

        //_playerControls.Gameplay.Move.performed += ctx => _move = ctx.ReadValue<Vector2>();
        //_playerControls.Gameplay.Move.canceled += ctx => _move = Vector2.zero;
        
        _playerInput.onActionTriggered += OnMove;
    }

    private void OnEnable()
    {
        _playerControls.Gameplay.Enable();
    }

    private void OnDisable()
    {
        _playerControls.Gameplay.Disable();
    }

    // Update is called once per frame
    private void Update()
    {
        //var movement = new Vector2(_move.x, _move.y) * (speed * Time.deltaTime);
        //_transform.Translate(movement, Space.World);
    }

    public void OnMove(InputAction.CallbackContext ctx)
    {
        if (!gameObject.scene.IsValid()) return;
        
        if (ctx.started)
        {
            print("Player " + GetComponent<PlayerInput>().playerIndex + " started moving");
        }

        if (ctx.performed)
        {
            print("Player " + GetComponent<PlayerInput>().playerIndex + " performed moving");
        }

        if (ctx.canceled)
        {
            print("Player " + GetComponent<PlayerInput>().playerIndex + " canceled moving");
        }
    }

    public void OnUse(InputAction.CallbackContext ctx)
    {
        if (!gameObject.scene.IsValid()) return;
        
        if (ctx.started)
        {
            print("Player " + GetComponent<PlayerInput>().playerIndex + " started using");
        }

        if (ctx.performed)
        {
            print("Player " + GetComponent<PlayerInput>().playerIndex + " performed using");
        }

        if (ctx.canceled)
        {
            print("Player " + GetComponent<PlayerInput>().playerIndex + " canceled using");
        }
        
    }

}
