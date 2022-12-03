using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorPlacer : RandomObjectPlacer
{
    public void Start()
    {
        minimumSecondsToCreation = GameParameters.MeteorMinimumTimeToCreation;
        maximumSecondsToCreation = GameParameters.MeteorMaximumTimeToCreation;
    }
    
    public override void Place()
    {
        Instantiate(ObjectPrefab, SpriteTools.RandomTopOfScreenWorldLocation(), Quaternion.identity); 
    }
}
