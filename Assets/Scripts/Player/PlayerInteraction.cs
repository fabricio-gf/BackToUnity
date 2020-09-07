using System;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    private PlayerActions _playerActions;

    private Interactable _closestInteractableObject;
    private Pickuppable _closestPickuppableObject;

    [SerializeField] private Transform holdingToolParent = null;

    [SerializeField] private bool canPickup = true;

    private Pickuppable _currentTool = null;
    
    private void Awake()
    {
        _playerActions = transform.parent.GetComponent<PlayerActions>();
    }

    private void OnEnable()
    {
        _playerActions.onPickup += PickupObject;
        
        foreach (var v in _playerActions.onPickup.GetInvocationList())
        {
            print("Invocation List: " + v);
        }
    }

    private void OnDisable()
    {
        _playerActions.onPickup -= PickupObject;
        
        foreach (var v in _playerActions.onPickup.GetInvocationList())
        {
            print("Invocation List: " + v);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        var interactableComponent = other.GetComponent<Interactable>();
        if (interactableComponent)
        {
            interactableComponent.ApproachPlayer();

            if (_closestInteractableObject == null)
            {
                _closestInteractableObject = interactableComponent;
                _playerActions.onInteract += _closestInteractableObject.Interact;
                
                foreach (var v in _playerActions.onInteract.GetInvocationList())
                {
                    print("Invocation List: " + v);
                }
            }
        }

        if (canPickup)
        {
            var pickuppableComponent = other.GetComponent<Pickuppable>();
            if (pickuppableComponent)
            {
                pickuppableComponent.ApproachPlayer();

                if (_closestPickuppableObject == null)
                {
                    _closestPickuppableObject = pickuppableComponent;
                    _playerActions.onPickup += _closestPickuppableObject.Pickup;
                    
                    foreach (var v in _playerActions.onPickup.GetInvocationList())
                    {
                        print("Invocation List: " + v);
                    }
                }
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        var interactableComponent = other.GetComponent<Interactable>();
        if (interactableComponent)
        {
            interactableComponent.RetreatPlayer();
            
            if (_closestInteractableObject == interactableComponent)
            {
                _playerActions.onInteract -= _closestInteractableObject.Interact;
                _closestInteractableObject = null;
                
                foreach (var v in _playerActions.onInteract.GetInvocationList())
                {
                    print("Invocation List: " + v);
                }
            }
        }

        var pickuppableComponent = other.GetComponent<Pickuppable>();
        if (pickuppableComponent)
        {
            pickuppableComponent.RetreatPlayer();
            
            if (_closestPickuppableObject == pickuppableComponent)
            {
                _playerActions.onPickup -= _closestPickuppableObject.Pickup;
                _closestPickuppableObject = null;
                
                foreach (var v in _playerActions.onPickup.GetInvocationList())
                {
                    print("Invocation List: " + v);
                }
            }
        }
    }

    private void PickupObject()
    {
        print("Pickup object");

        if (_currentTool != null)
        {
            print("Dropping an object now");
            
            _currentTool.transform.SetParent(null, true);
            
            _playerActions.onPickup -= _currentTool.Drop;
            _playerActions.onPickup += _currentTool.Pickup;
            foreach (var v in _playerActions.onPickup.GetInvocationList())
            {
                print("Invocation List: " + v);
            }
        }
        
        if (_closestPickuppableObject != null)
        {
            if (_closestPickuppableObject.canPickup == true)
            {
                print("Holding an object now");
                
                Transform pickupTransform = _closestPickuppableObject.transform;
                pickupTransform.SetParent(holdingToolParent, false);
                pickupTransform.localPosition = Vector2.zero;

                _currentTool = _closestPickuppableObject;
                _playerActions.onPickup -= _currentTool.Pickup;
                _playerActions.onPickup += _currentTool.Drop;
                
                foreach (var v in _playerActions.onPickup.GetInvocationList())
                {
                    print("Invocation List: " + v);
                }
            }
        }
    }
}
