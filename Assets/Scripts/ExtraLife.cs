using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraLife : TimedObjects
{
    public override void Start()
    {
        SecondsOnScreen = GameParameters.ExtraLifeSecondsOnScreen;
        base.Start();
    }
}


