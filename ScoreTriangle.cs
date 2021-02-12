using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreTriangle : MonoBehaviour
{
    public int score;
    public int displayScore;
    public int blackMat = 300;
    public int blueMat = 450;

    public Text scoreGame;
    public Text scoreUI;
    public Text highScore;

    public Material blue;
    public Material black;

   void Start() {
       
       RenderSettings.skybox = blue;
       score = 2147483647;
       displayScore = 0;
       

       StartCoroutine(ScoreUpdater());
       
             
   }

   void Update() {
       highScore.text = PlayerPrefs.GetInt("HighScoreTriangle",0).ToString();

       if(displayScore > PlayerPrefs.GetInt("HighScoreTriangle",0)) {
           PlayerPrefs.SetInt("HighScoreTriangle", displayScore);
           highScore.text = displayScore.ToString();
       }

       if(blackMat == displayScore) {
           BlackMat();
       }
       if(blueMat == displayScore) {
           BlueMat();
       }
       

   }

   private IEnumerator ScoreUpdater() {
       while(true) {
           if(displayScore < score) {
               displayScore ++;
               scoreGame.text = displayScore.ToString();
               scoreUI.text = displayScore.ToString();
           }
           yield return new WaitForSeconds(0.1f);
       }
   }

   private void BlueMat() {
       RenderSettings.skybox = blue;
       blueMat += 250;
   }

   private void BlackMat() {
       RenderSettings.skybox = black;
       blackMat += 250;
   }


}
