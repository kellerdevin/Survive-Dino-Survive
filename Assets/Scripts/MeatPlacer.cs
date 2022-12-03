using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeatPlacer : RandomObjectPlacer
{
    public void Start()
    {
        minimumSecondsToCreation = GameParameters.MeatMinimumTimeToCreation;
        maximumSecondsToCreation = GameParameters.MeatMaximumTimeToCreation;
    }
}
