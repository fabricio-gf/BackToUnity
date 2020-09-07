// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/TestKeyboardSplit/TestKeyboardSplit.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @ConnectPlayers : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @ConnectPlayers()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""TestKeyboardSplit"",
    ""maps"": [
        {
            ""name"": ""ConnectPlayer"",
            ""id"": ""5f93b95e-b9ef-4337-9b49-641045e35734"",
            ""actions"": [
                {
                    ""name"": ""Connect"",
                    ""type"": ""Button"",
                    ""id"": ""d1223ab2-f037-4540-8bb0-bc50e8c3c393"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""49de0b3e-af22-484d-9ffc-cc6200734846"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBLeft"",
                    ""action"": ""Connect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""22304df8-8265-4dfe-a1de-02f39ba5b16c"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBRight"",
                    ""action"": ""Connect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cb74caa0-6f53-43a9-a204-d9858b87dd6e"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Connect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KBLeft"",
            ""bindingGroup"": ""KBLeft"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""KBRight"",
            ""bindingGroup"": ""KBRight"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Controller"",
            ""bindingGroup"": ""Controller"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // ConnectPlayer
        m_ConnectPlayer = asset.FindActionMap("ConnectPlayer", throwIfNotFound: true);
        m_ConnectPlayer_Connect = m_ConnectPlayer.FindAction("Connect", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // ConnectPlayer
    private readonly InputActionMap m_ConnectPlayer;
    private IConnectPlayerActions m_ConnectPlayerActionsCallbackInterface;
    private readonly InputAction m_ConnectPlayer_Connect;
    public struct ConnectPlayerActions
    {
        private @ConnectPlayers m_Wrapper;
        public ConnectPlayerActions(@ConnectPlayers wrapper) { m_Wrapper = wrapper; }
        public InputAction @Connect => m_Wrapper.m_ConnectPlayer_Connect;
        public InputActionMap Get() { return m_Wrapper.m_ConnectPlayer; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ConnectPlayerActions set) { return set.Get(); }
        public void SetCallbacks(IConnectPlayerActions instance)
        {
            if (m_Wrapper.m_ConnectPlayerActionsCallbackInterface != null)
            {
                @Connect.started -= m_Wrapper.m_ConnectPlayerActionsCallbackInterface.OnConnect;
                @Connect.performed -= m_Wrapper.m_ConnectPlayerActionsCallbackInterface.OnConnect;
                @Connect.canceled -= m_Wrapper.m_ConnectPlayerActionsCallbackInterface.OnConnect;
            }
            m_Wrapper.m_ConnectPlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Connect.started += instance.OnConnect;
                @Connect.performed += instance.OnConnect;
                @Connect.canceled += instance.OnConnect;
            }
        }
    }
    public ConnectPlayerActions @ConnectPlayer => new ConnectPlayerActions(this);
    private int m_KBLeftSchemeIndex = -1;
    public InputControlScheme KBLeftScheme
    {
        get
        {
            if (m_KBLeftSchemeIndex == -1) m_KBLeftSchemeIndex = asset.FindControlSchemeIndex("KBLeft");
            return asset.controlSchemes[m_KBLeftSchemeIndex];
        }
    }
    private int m_KBRightSchemeIndex = -1;
    public InputControlScheme KBRightScheme
    {
        get
        {
            if (m_KBRightSchemeIndex == -1) m_KBRightSchemeIndex = asset.FindControlSchemeIndex("KBRight");
            return asset.controlSchemes[m_KBRightSchemeIndex];
        }
    }
    private int m_ControllerSchemeIndex = -1;
    public InputControlScheme ControllerScheme
    {
        get
        {
            if (m_ControllerSchemeIndex == -1) m_ControllerSchemeIndex = asset.FindControlSchemeIndex("Controller");
            return asset.controlSchemes[m_ControllerSchemeIndex];
        }
    }
    public interface IConnectPlayerActions
    {
        void OnConnect(InputAction.CallbackContext context);
    }
}
