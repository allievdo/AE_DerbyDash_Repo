using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenu;

    public PlayerController playerController;

    public EnemyController enemyController;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        playerController.gallop.Play();
        enemyController.gallop.Play();
    }

    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        playerController.gallop.Stop();
        enemyController.gallop.Stop();
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("HomeScene");
    }

    //This here is my pause menu!! So cool! So slay
}
