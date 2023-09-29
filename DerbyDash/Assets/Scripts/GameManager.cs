using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ParticleSystemJobs;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Text countdownText;
    public int countdownTime;
    public bool gamePlaying { get; private set; }

    private void Awake()
    {
        //NEW
        instance = this;
        Time.timeScale = 1.0f;
    }

    void Start()
    {
        gamePlaying = false;
        Debug.Log("start");
        StartCoroutine(CountdownToStart());
    }
    private void BeginGame()
    {
        gamePlaying = true;
    }
    IEnumerator CountdownToStart()
    {
        while (countdownTime > 0)
        {
            //Debug.Log("HELLO???? Time");
            countdownText.text = countdownTime.ToString();
            yield return new WaitForSeconds(1f);
            countdownTime--;
        }

        BeginGame();

        countdownText.text = "GO!";

        yield return new WaitForSeconds(1f);

        countdownText.gameObject.SetActive(false);
    }
}
