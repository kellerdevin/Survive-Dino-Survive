using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : TimedObjects
{
    public override void Start()
    {
        SecondsOnScreen = GameParameters.MeteorSecondsOnScreen;
        base.Start();
    }
}
