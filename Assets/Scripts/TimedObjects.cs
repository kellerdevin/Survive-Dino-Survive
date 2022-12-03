using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedObjects : MonoBehaviour
{
    public int SecondsOnScreen = 3;
    public virtual void Start()
    {
        StartCoroutine(CountdownTillDeath());
    }

    IEnumerator CountdownTillDeath()
    {
        yield return new WaitForSeconds(SecondsOnScreen);
        Destroy(gameObject);
    }
}
