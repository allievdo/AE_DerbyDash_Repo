using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;

    public float runningForce = 3f;
    public float speedBoost = 6f;
    public float speedCooldown;

    public bool isSprinting;

    public Animator animator;

    public AudioSource gallop;

    void Update()
    {
        if(GameManager.instance.gamePlaying)
        {
            PlayerRun();
        }

        else
        {
            rb.velocity = Vector2.zero;
        }
    }

    void PlayerRun()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.velocity = new Vector2(runningForce, 0f);
            animator.SetFloat("Speed", 1);

            isSprinting = false;
            gallop.Play();
        }

        //NEW
        if (isSprinting == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                isSprinting = true;
                if (PlayerStats.instance.currentCarrots > 0)
                {
                    CarrotDown();

                    rb.velocity = new Vector2(speedBoost, 0f);
                    StartCoroutine(SpeedDuration());
                    animator.SetFloat("Speed", speedBoost);
                }
            }
        }

        else
            animator.SetFloat("Speed", 1);

        //FOR TESTING PURPOSES:
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(speedBoost, 0f);
        } */

        /* if (Input.GetKeyUp(KeyCode.Space))
        {
            rb.velocity = new Vector2(runningForce, 0f);
        } */
    }

    void CarrotDown()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            PlayerStats.instance.currentCarrots -= 1;//make it go down by one
        }
    }

    IEnumerator SpeedDuration()
    {
        yield return new WaitForSeconds(speedCooldown);
        rb.velocity = new Vector2(runningForce, 0f);
        isSprinting = false;
    }
  /*  void FixedUpdate()
    {
       rb.velocity = new Vector2(runningForce, 0f);
    } */
}
