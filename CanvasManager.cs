using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CanvasManager : MonoBehaviour
{
    public GameObject LevelUI;
    public GameObject MenuUI;
    public Text highScoreText;
    public Text highScoreText2;

    public GameObject level1;
    public GameObject level2;

    public void Start() {
        MenuUI.SetActive(true);
    }
    public void StartGame() {
        MenuUI.SetActive(false);

        highScoreText.text = PlayerPrefs.GetInt("HighScoreTriangle",0).ToString("");
        highScoreText2.text = PlayerPrefs.GetInt("HighScore",0).ToString("");

        LevelUI.SetActive(true);
    }

    public void NextLevel() {
        level1.SetActive(false);
        level2.SetActive(true);
    }
    public void prevLevel() {
        level1.SetActive(true);
        level2.SetActive(false);
    }
 

    public void LevelTriangle() {
        SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void LevelQuad() {
        SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 2);
    }


}
