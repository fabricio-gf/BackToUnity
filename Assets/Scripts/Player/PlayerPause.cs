using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerPause : MonoBehaviour
{
    private GameObject _pauseCanvas;
    private PlayerInput _playerInput;

    private void Awake()
    {
        _pauseCanvas = GameObject.FindGameObjectWithTag("PauseCanvas");
        _playerInput = GetComponent<PlayerInput>();
    }

    public void PauseGame(InputAction.CallbackContext ctx)
    {
        foreach (Transform child in _pauseCanvas.transform)
        {
            child.gameObject.SetActive(true);
        }

        _playerInput.SwitchCurrentActionMap("UI");
        Time.timeScale = 0;
    }

    public void UnpauseGame(InputAction.CallbackContext ctx)
    {
        Time.timeScale = 1;
        foreach (Transform child in _pauseCanvas.transform)
        {
            child.gameObject.SetActive(false);
        }
        _playerInput.SwitchCurrentActionMap("Player");
    }
}
