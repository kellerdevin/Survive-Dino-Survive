using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ScoreKeeper 
{
    private static int score = 0;
    private static int lives = 3;

    public static void AddPoint(int amount)
    {
        score += amount;
    }

    public static void AddLife(int amount)
    {
        lives += amount;
    }
    
    public static void LoseLife(int amount)
    {
        lives -= amount;
    }

    public static string GetScore()
    {
        return score.ToString();
    }

    public static string GetLives()
    {
        return lives.ToString();
    }

    public static void ResetScore()
    {
        score = 0;
        lives = 3;
    }
}
