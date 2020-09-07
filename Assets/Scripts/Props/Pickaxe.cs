using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickaxe : Pickuppable
{
    // Start is called before the first frame update

    public override void Pickup()
    {
        canPickup = false;
        print(name + " was picked up by a player");
        GetComponent<SpriteRenderer>().sortingOrder = 1;
    }

    public override void Drop()
    {
        canPickup = true;
        print(name + " was dropped up by a player");
        GetComponent<SpriteRenderer>().sortingOrder = 0;
    }
}
