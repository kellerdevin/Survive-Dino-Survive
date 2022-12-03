using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraLifePlacer : RandomObjectPlacer
{
    public void Start()
    {
        minimumSecondsToCreation = GameParameters.ExtraLifeMinimumTimeToCreation;
        maximumSecondsToCreation = GameParameters.ExtraLifeMaximumTimeToCreation;
    }
}
