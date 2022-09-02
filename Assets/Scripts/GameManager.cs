using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject GameOverCanvas;
    public GameObject score;
    public GameObject getReadyImg;
    public GameObject pauseBtn;

    public static Vector2 bottomLeft;

    public static bool gameOver;
    public static bool gameHasStarted;
    public static bool gameIsPaused;

    private void Awake()
    {
        bottomLeft = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
    }


    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        gameHasStarted = false;
        gameIsPaused = false;
        
    }

    public void GameHasStarted()
    {
        getReadyImg.SetActive(false);
        gameHasStarted = true;
        score.SetActive(true);
        pauseBtn.SetActive(true);
        
    }

    public void GameOver()
    {
        gameOver = true;
        score.SetActive(false);
        GameOverCanvas.SetActive(true);
        pauseBtn.SetActive(false);

    }

    public void OnOkBtnPressed()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void OnMenuBtnPressed()
    {
        AudioManager.audiomanager.Play("Menu");
        SceneManager.LoadScene("Menu");
        AudioManager.audiomanager.Play("Transition");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
