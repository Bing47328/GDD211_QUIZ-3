using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flowers : SelectItem
{
    public override void UseItem()
    {
        base.UseItem();
        Debug.Log("Flowers Selected");
    }
}
