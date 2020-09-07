using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerActions : MonoBehaviour
{
    public delegate void InteractDelegate();
    public InteractDelegate onInteract;

    public delegate void PickupDelegate();
    public PickupDelegate onPickup;

    public void OnUse(InputAction.CallbackContext ctx)
    {
        if (!gameObject.scene.IsValid()) return;
        
        print("This action is " + ctx.action);
        
        if (ctx.started)
        {
            print("Player " + GetComponent<PlayerInput>().playerIndex + " started using");
            onInteract?.Invoke();
            onPickup?.Invoke();
            
        }

        if (ctx.performed)
        {
            //print("Player " + GetComponent<PlayerInput>().playerIndex + " performed using");
        }

        if (ctx.canceled)
        {
            //print("Player " + GetComponent<PlayerInput>().playerIndex + " canceled using");
        }
    }
}
