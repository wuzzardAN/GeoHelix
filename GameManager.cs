using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;

public class GameManager : MonoBehaviour
{

    public RectTransform gameOverUI;
    public Button ContinueButton;
    public GameObject StartUI;

    bool gameHasEnded = false;
    public float restartDelay = 0.35f;
    public void EndGame() {
        if(gameHasEnded == false) {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
            gameOverUI.DOAnchorPos(new Vector2(0,420),0.35f);
            FindObjectOfType<PlayerController>().SpeedZero();
            FindObjectOfType<PlayerControllerTriangle>().SpeedZero();
            
            
            
        }
    }
    void Start() {
        Time.timeScale = 0;
        StartUI.SetActive(true);
        
    }

    public void StartGame() {
        StartUI.SetActive(false);
        Time.timeScale = 1;
    }



    void Restart() {
        Time.timeScale = 0;
        
        
    }
    public void RestartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }

    public void ContinueGame() {
        if(gameHasEnded == true) {
            gameHasEnded = false;
            Time.timeScale = 1;
            gameOverUI.DOAnchorPos(new Vector2(0,-3800),0.35f);
            ContinueButton.interactable = false;
            FindObjectOfType<PlayerController>().SpeedOne();
            FindObjectOfType<PlayerControllerTriangle>().SpeedOne();
            
        }
        
        

    }

    public void MainMenu() {
        SceneManager.LoadScene("Menu");
    }


}
