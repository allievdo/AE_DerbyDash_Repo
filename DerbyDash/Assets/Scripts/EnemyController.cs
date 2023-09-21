using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Rigidbody2D rb;

    public int maxSpeed;
    public int minSpeed;


    void Update()
    {
        int enemySpeed = Random.Range(minSpeed, maxSpeed);
        Debug.Log("Current enemy speed: " + enemySpeed);
        rb.velocity = new Vector2(enemySpeed, 0f);
    }
}
