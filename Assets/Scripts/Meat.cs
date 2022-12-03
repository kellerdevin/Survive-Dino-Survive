using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meat : TimedObjects
{
    public override void Start()
    {
        SecondsOnScreen = GameParameters.MeatSecondsOnScreen;
        base.Start();
    }
}
