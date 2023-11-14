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

    public Animator animator;

    public AudioSource gallop;


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
        rb.velocity = new Vector2(enemySpeed, 0f);
        animator.SetFloat("Speed", enemySpeed);
        gallop.Play();
    }
}
