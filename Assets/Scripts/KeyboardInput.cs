using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInput : MonoBehaviour
{
    public Dino Dino;
    void Update()
    {
        if (Game.IsRunning())
        {

            if (Input.GetKey(KeyCode.A))
            {
                Dino.Move(new Vector3(-1f, 0f));
            }

            if (Input.GetKey(KeyCode.D))
            {
                Dino.Move(new Vector2(1f, 0f));
            }
        }
            
    }
}
