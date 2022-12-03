using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.SocialPlatforms.Impl;
using Random = UnityEngine.Random;

public class Dino : MonoBehaviour
{
    public SpriteRenderer DinoSpriteRenderer;
    
    void Update()
    {
        if (HasGameJustEnded())
            Reset();
    }

    private void Reset()
    {
        ResetPosition();
    }

    private void ResetPosition()
    {
        DinoSpriteRenderer.transform.position = new Vector3(0f, -3.8f, 0f);
        DinoSpriteRenderer.flipX = false;
    }

    private bool HasGameJustEnded()
    {
        if (!Game.IsRunning())
            return true;
        return false;
    }
    
    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Meat")
        {
            ScoreKeeper.AddPoint(1);
        }
        
        else if (col.gameObject.tag == "Heart")
        {
            ScoreKeeper.AddLife(1);
        }
        
        else if (col.gameObject.tag == "Meteor")
        {
            ScoreKeeper.LoseLife(1);
        }
        
        Destroy(col.gameObject);
    }

    public void Move(Vector2 direction)
    {
        FaceCorrectDirection(direction);
        DinoSpriteRenderer.transform.Translate(new Vector3(
            direction.x * GameParameters.DinoMoveAmount, 
            direction.y * GameParameters.DinoMoveAmount, 
            0f));
        KeepOnScreen();
    }

    private void KeepOnScreen()
    {
        DinoSpriteRenderer.transform.position = SpriteTools.ConstrainToScreen(DinoSpriteRenderer);
    }

    private void FaceCorrectDirection(Vector2 direction)
    {
        if (direction.x > 0)
        {
            DinoSpriteRenderer.flipX = false;
        }
        else if (direction.x < 0)
        {
            DinoSpriteRenderer.flipX = true;
        }
    }
}
