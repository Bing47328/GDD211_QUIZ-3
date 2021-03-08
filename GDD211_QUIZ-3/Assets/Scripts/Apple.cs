using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : SelectItem
{
    public override void UseItem()
    {
        base.UseItem();
        Debug.Log("Apple Selected");
    }
}
