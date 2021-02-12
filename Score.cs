using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;

public class Score : MonoBehaviour
{
    public RectTransform leftButtonT,rightButtonT;
    public int score;
    public int reverseRoll = 200;
    public int normalRoll = 350;
    public int displayScore;


    public Text scoreGame;
    public Text scoreUI;
    public Text highScore;

    public GameObject normalText;
    public GameObject reverseText;


   void Start() {
       
       score = 2147483647;
       displayScore = 0;

       StartCoroutine(ScoreUpdater());
       normalText.SetActive(true);
       reverseText.SetActive(false);
       
             
   }

   void Update() {
       highScore.text = PlayerPrefs.GetInt("HighScore",0).ToString();

       if(displayScore > PlayerPrefs.GetInt("HighScore",0)) {
           PlayerPrefs.SetInt("HighScore", displayScore);
           highScore.text = displayScore.ToString();
       }
       
       if(reverseRoll == displayScore) {
           Reverse();
           reverseRoll += 200;
       }

       if(normalRoll == displayScore) {
           Normal();
           normalRoll += 200;
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



    public void Reverse(){
            normalText.SetActive(false);
            Debug.Log("Reverse");
            leftButtonT.DOAnchorPos(new Vector2(480,0),0.1f);
            rightButtonT.DOAnchorPos(new Vector2(-480,0),0.1f);
            reverseText.SetActive(true);
    }
    public void Normal() {
           Debug.Log("Normal");
           leftButtonT.DOAnchorPos(new Vector2(-480,0),0.1f);
           rightButtonT.DOAnchorPos(new Vector2(480,0),0.1f);
           reverseText.SetActive(false);
           normalText.SetActive(true);
    }

}
