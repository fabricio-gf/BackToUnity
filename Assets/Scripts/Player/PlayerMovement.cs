using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;

    [SerializeField] private float speed = 0;
    private Vector2 _move;
    
    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    public void OnMove(InputAction.CallbackContext ctx)
    {
        print("Action " + ctx.action);

        if (!gameObject.scene.IsValid()) return;
        
        if (ctx.started)
        {
            print("Player " + GetComponent<PlayerInput>().playerIndex + " started moving");
        }

        if (ctx.performed)
        {
            _move = ctx.ReadValue<Vector2>() * speed;
            _rigidbody2D.velocity = _move;
        }

        if (ctx.canceled)
        {
            _move = Vector2.zero;
            _rigidbody2D.velocity = _move;
        }
    }

}
