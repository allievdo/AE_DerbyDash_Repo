using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FinishLine : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public Text raceAmountText;

    public GameObject winScreenUI;

    public GameObject loseScreenUI;

    public PlayerController playerController;
    public EnemyController enemyController;

    public int raceAmount = 50;
    public bool isSoundOff = false;
    public static bool isMediumRaceWon = false;
    public static bool isHardRaceWon = false;
    private void Start()
    {
        raceAmountText.text = "$" + PlayerStats.instance.currentMoney.ToString();
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (SceneManager.GetActiveScene().name == "RaceSceneHard")
        {
            if (collision.tag == "Player")
            {
                isHardRaceWon = true;
                winScreenUI.SetActive(true);
                Time.timeScale = 0f;
                GameIsPaused = true;

                //Debug.Log("race amount: " + raceAmount);
                //Debug.Log("GameManager current money: " + PlayerStats.instance.currentMoney);
                PlayerStats.instance.currentMoney += raceAmount;
                //Debug.Log("Your current amount is: " + PlayerStats.instance.GetCurrentMoney());
                //Debug.Log("GameManager current money: " + PlayerStats.instance.currentMoney);

                raceAmountText.text = "$" + PlayerStats.instance.currentMoney.ToString();

                isSoundOff = true;
                playerController.gallop.Stop();
                enemyController.gallop.Stop();
            }
        }

        if (SceneManager.GetActiveScene().name == "RaceSceneMedium")
        {
            if (collision.tag == "Player")
            {
                isMediumRaceWon = true;
                winScreenUI.SetActive(true);
                Time.timeScale = 0f;
                GameIsPaused = true;

                //Debug.Log("race amount: " + raceAmount);
                //Debug.Log("GameManager current money: " + PlayerStats.instance.currentMoney);
                PlayerStats.instance.currentMoney += raceAmount;
                //Debug.Log("Your current amount is: " + PlayerStats.instance.GetCurrentMoney());
                //Debug.Log("GameManager current money: " + PlayerStats.instance.currentMoney);

                raceAmountText.text = "$" + PlayerStats.instance.currentMoney.ToString();

                isSoundOff = true;
                playerController.gallop.Stop();
                enemyController.gallop.Stop();
            }
        }

        if (SceneManager.GetActiveScene().name == "RaceScene")
        {
            if (collision.tag == "Player")
            {
                winScreenUI.SetActive(true);
                Time.timeScale = 0f;
                GameIsPaused = true;

                //Debug.Log("race amount: " + raceAmount);
                //Debug.Log("GameManager current money: " + PlayerStats.instance.currentMoney);
                PlayerStats.instance.currentMoney += raceAmount;
                //Debug.Log("Your current amount is: " + PlayerStats.instance.GetCurrentMoney());
                //Debug.Log("GameManager current money: " + PlayerStats.instance.currentMoney);

                raceAmountText.text = "$" + PlayerStats.instance.currentMoney.ToString();

                isSoundOff = true;
                playerController.gallop.Stop();
                enemyController.gallop.Stop();
            }
        }

        if (collision.tag == "Enemy")
        {
            isSoundOff = true;
            loseScreenUI.SetActive(true);
            Time.timeScale = 0f;

            PlayerStats.instance.currentMoney += 10;
            raceAmountText.text = "$" + PlayerStats.instance.currentMoney.ToString();

            GameIsPaused = true;

            playerController.gallop.Stop();
            enemyController.gallop.Stop();
        } 
    }
}
