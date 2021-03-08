using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orb : SelectItem
{
    public override void UseItem()
    {
        base.UseItem();
        Debug.Log("Orb Selected");
    }
}
