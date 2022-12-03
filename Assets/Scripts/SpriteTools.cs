﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SpriteTools
{
    public static Vector3 ConstrainToScreen(SpriteRenderer spriteRenderer)
    {
        Vector3 screenPosition = Camera.main.WorldToScreenPoint(spriteRenderer.transform.position);

        // if we're offscreen to the right
        if (SpriteRight(spriteRenderer) > Screen.width)
            screenPosition.x = Screen.width - SpriteTenthWidth(spriteRenderer);

        // if we're offscreen to the left
        if (SpriteLeft(spriteRenderer) < 0)
            screenPosition.x = SpriteTenthWidth(spriteRenderer);
        
        return Camera.main.ScreenToWorldPoint(screenPosition);
    }

    public static Vector3 ConstrainToScreenLame(SpriteRenderer spriteRenderer)
    {
        Vector3 screenPosition = Camera.main.WorldToScreenPoint(spriteRenderer.transform.position);

        // if we're offscreen to the right
        if (screenPosition.x > Screen.width)
            screenPosition.x = Screen.width;

        // if we're offscreen to the left
        if (screenPosition.x < 0)
            screenPosition.x = 0;

        // if we're offscreen to the top
        if (screenPosition.y > Screen.height)
            screenPosition.y = Screen.height;

        // if we're offscreen to the bottom
        if (screenPosition.y < 0)
            screenPosition.y = 0;

        return Camera.main.ScreenToWorldPoint(screenPosition);
    }

    private static float SpriteRight(SpriteRenderer spriteRenderer)
    {
        Vector3 screenPosition = Camera.main.WorldToScreenPoint(spriteRenderer.transform.position);
        return screenPosition.x + SpriteTenthWidth(spriteRenderer);
    }

    private static float SpriteLeft(SpriteRenderer spriteRenderer)
    {
        Vector3 screenPosition = Camera.main.WorldToScreenPoint(spriteRenderer.transform.position);
        return screenPosition.x - SpriteTenthWidth(spriteRenderer);
    }

    private static float SpriteTenthWidth(SpriteRenderer spriteRenderer)
    {
        return spriteRenderer.sprite.rect.width / 10;
    }

    public static Vector3 RandomScreenLocation()
    {
        float randomX = Random.Range(0, Screen.width);

        return new Vector3(randomX, 28, 10);
    }

    public static Vector3 RandomWorldLocation()
    {
        Vector3 randomScreenLocation = RandomScreenLocation();
        return Camera.main.ScreenToWorldPoint(randomScreenLocation);
    }

    public static Vector3 RandomTopOfScreenLocation()
    {
        float randomX = Random.Range(0, Screen.width);
        return new Vector3(randomX, Screen.height, 10);
    }

    public static Vector3 RandomTopOfScreenWorldLocation()
    {
        Vector3 randomTopOfScreenLocation = RandomTopOfScreenLocation();
        return Camera.main.ScreenToWorldPoint(randomTopOfScreenLocation);
    }
}
