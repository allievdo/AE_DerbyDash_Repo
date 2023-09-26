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

    private int raceAmount = 50;


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("Collided with finish line");
            winScreenUI.SetActive(true);
            Time.timeScale = 0f;
            GameIsPaused = true;

            raceAmountText.text = raceAmount.ToString();
            PlayerStats.playerStats.money += raceAmount;
        }

        if (collision.tag == "Enemy")
        {
            Debug.Log("Collided with finish line");
            loseScreenUI.SetActive(true);
            Time.timeScale = 0f;
            GameIsPaused = true; ;
        } 
    }
}
