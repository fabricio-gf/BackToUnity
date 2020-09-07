using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class PlayerMovement : MonoBehaviour
{
    // private PlayerControls _playerControls;
    private Transform _transform;
    [SerializeField] private float speed, jumpSpeed;

    private void Awake()
    {
        _transform = GetComponent<Transform>();
        // _playerControls = new PlayerControls();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        Debug.Log("test");
        Debug.Log(context.GetType());
        var moveValue = context.ReadValue<Vector2>();
        Debug.Log(moveValue);
        //var stickControl = 
    }
    
    public void OnUse(InputAction.CallbackContext context)
    {
        Debug.Log("test");
        Debug.Log(context.GetType());
        var moveValue = context.ReadValue<Vector2>();
        Debug.Log(moveValue);
        //var stickControl = 
    }

    public void Test(string test)
    {
        Debug.Log(test);
    }

    /*private void OnEnable()
    {
        _playerControls.Enable();
    }

    private void OnDisable()
    {
        _playerControls.Disable();
    }*/

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        /*// Read the movement value
        var leftRightInput = _playerControls.Standard.Move_LeftRight.ReadValue<float>();
        var upDownInput = _playerControls.Standard.Move_UpDown.ReadValue<float>();
        
        // Move the player
        var currentPosition = _transform.position;
        currentPosition.x += leftRightInput * speed * Time.deltaTime;
        currentPosition.y += upDownInput * speed * Time.deltaTime;
        
        _transform.position = currentPosition;*/
    }
}
