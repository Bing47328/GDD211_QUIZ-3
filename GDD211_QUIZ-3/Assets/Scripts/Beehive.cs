using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beehive : SelectItem
{
    public override void UseItem()
    {
        base.UseItem();
        Debug.Log("Beehive Selected");
    }
}
