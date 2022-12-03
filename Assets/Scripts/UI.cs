using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
   public CanvasGroup StartScreenCanvasGroup;
   public CanvasGroup GameOverScreenCanvasGroup;
   public Text ScoreText;
   public Text TimeText;
   public Text LifeText;
   public GameTimer GameTimer;
   public void Update()
   {
      ShowScore(ScoreKeeper.GetScore());
      ShowTime(GameTimer.GetTimeAsString());
      ShowLives(ScoreKeeper.GetLives());
   }
   
   public void ShowStartScreen()
   {
      CanvasGroupDisplayer.Show(StartScreenCanvasGroup);
      CanvasGroupDisplayer.Hide(GameOverScreenCanvasGroup);
   }

   public void ShowGameOverScreen()
   {
      CanvasGroupDisplayer.Show(GameOverScreenCanvasGroup);
      CanvasGroupDisplayer.Hide(StartScreenCanvasGroup);
   }

   public void HideStartAndGameOverScreen()
   {
      CanvasGroupDisplayer.Hide(StartScreenCanvasGroup);
      CanvasGroupDisplayer.Hide(GameOverScreenCanvasGroup);
   }

   public void ShowScore(string score)
   {
      ScoreText.text = "Score: " + score;
   }

   public void ShowTime(string time)
   {
      TimeText.text = "Time: " + time;
   }

   public void ShowLives(string lives)
   {
      LifeText.text = "Lives: " + lives;
   }
}
