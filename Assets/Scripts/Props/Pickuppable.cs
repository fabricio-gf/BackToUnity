using UnityEngine;
using UnityEngine.Serialization;

public abstract class Pickuppable : MonoBehaviour
{
    public bool canPickup;

    public void SetPickuppable(bool pickuppable)
    {
        canPickup = pickuppable;
    }

    public void ApproachPlayer()
    {
    }

    public void RetreatPlayer()
    {
    }

    public abstract void Pickup();
    
    public abstract void Drop();
}