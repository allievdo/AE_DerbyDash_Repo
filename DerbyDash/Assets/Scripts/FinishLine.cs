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

    private void Start()
    {
        raceAmountText.text = PlayerStats.instance.currentMoney.ToString();
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("Collided with finish line");
            winScreenUI.SetActive(true);
            Time.timeScale = 0f;
            GameIsPaused = true;

            //Debug.Log("race amount: " + raceAmount);
            //Debug.Log("GameManager current money: " + PlayerStats.instance.currentMoney);
            PlayerStats.instance.currentMoney += raceAmount;
            //Debug.Log("Your current amount is: " + PlayerStats.instance.GetCurrentMoney());
            //Debug.Log("GameManager current money: " + PlayerStats.instance.currentMoney);

            raceAmountText.text = PlayerStats.instance.currentMoney.ToString();
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
