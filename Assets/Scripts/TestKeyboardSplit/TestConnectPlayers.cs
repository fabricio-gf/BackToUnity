using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TestConnectPlayers : MonoBehaviour
{
    private ConnectPlayers _connectPlayers;

    [SerializeField] private GameObject playerPrefab = null;
    
    private void Awake()
    {
        _connectPlayers = new ConnectPlayers();

        _connectPlayers.ConnectPlayer.Connect.performed += ConnectPlayer;
        
    }

    private void OnEnable()
    {
        _connectPlayers.ConnectPlayer.Enable();
    }

    private void OnDisable()
    {
        _connectPlayers.ConnectPlayer.Disable();
    }

    void Test()
    {
        print("test");
    }

    void ConnectPlayer(InputAction.CallbackContext ctx)
    {
        print("My device is: " + ctx.action.activeControl);
        
        var deviceString = ctx.action.activeControl.ToString();
        
        if (deviceString.Contains("Keyboard"))
        {
            if(deviceString.Contains("space"))
            {
                PlayerInput.Instantiate(playerPrefab, -1, "KeyboardLeft", 0, Keyboard.current);
            }

            if (deviceString.Contains("enter"))
            {
                PlayerInput.Instantiate(playerPrefab, -1, "KeyboardRight", 0, Keyboard.current);
            }
        }
        if(deviceString.Contains("Gamepad"))
        {
            PlayerInput.Instantiate(playerPrefab, -1, "Gamepad", 0, Gamepad.current);
        }
        
        
    }
}
