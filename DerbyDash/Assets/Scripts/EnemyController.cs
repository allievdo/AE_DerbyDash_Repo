using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Rigidbody2D rb;

    public int maxSpeed;
    public int minSpeed;

    int enemySpeed;


    void Start()
    {
        enemySpeed = Random.Range(minSpeed, maxSpeed);
    }
    void Update()
    {
        if (GameManager.instance.gamePlaying)
        {
            EnemyRun();
        }

        else
        {
            rb.velocity = Vector2.zero;
        }
    }

    void EnemyRun()
    {
        //Debug.Log("Current enemy speed: " + enemySpeed);
        rb.velocity = new Vector2(enemySpeed, 0f);
    }
}
