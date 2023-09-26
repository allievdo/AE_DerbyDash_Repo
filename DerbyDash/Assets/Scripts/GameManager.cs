using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Text countdownText;
    public int countdownTime;
    public bool gamePlaying { get; private set; }

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        gamePlaying = false;

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
