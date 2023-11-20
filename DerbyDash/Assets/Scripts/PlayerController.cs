using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;

    public float runningForce = 3f;
    public float speedBoost = 6f;
    public float speedCooldown;
    public float appleSpeedCooldown;

    public FinishLine finishLine;
    public PauseMenu pauseMenu;

    public bool isSprinting;
    private bool hasStarted = false;

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
            hasStarted = true;

            rb.velocity = new Vector2(runningForce, 0f);
            animator.SetFloat("Speed", 1);

            isSprinting = false;
            if (!gallop.isPlaying && finishLine.isSoundOff == false && pauseMenu.paused == false)
                gallop.Play();
        }

        //NEW
        if (hasStarted == true)
        {
            if (isSprinting == false)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    isSprinting = true;
                    if (PlayerStats.instance.currentApples > 0 && PlayerStats.instance.currentCarrots > 0)
                    {
                        CarrotDown();
                        AppleDown();

                        rb.velocity = new Vector2(speedBoost, 0f);
                        StartCoroutine(AppleSpeedDuration());
                        animator.SetFloat("Speed", speedBoost);
                    }

                    else if (PlayerStats.instance.currentCarrots > 0 && PlayerStats.instance.currentApples <= 0)
                    {
                        CarrotDown();

                        rb.velocity = new Vector2(speedBoost, 0f);
                        StartCoroutine(SpeedDuration());
                        animator.SetFloat("Speed", speedBoost);
                    }
                }

                else
                    animator.SetFloat("Speed", 1);
            }

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
    }

    void CarrotDown()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            PlayerStats.instance.currentCarrots -= 1;//make it go down by one
        }
    }

    void AppleDown()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            PlayerStats.instance.currentApples -= 1;//make apples go down by 1
        }
    }

    IEnumerator SpeedDuration()
    {
        yield return new WaitForSeconds(speedCooldown);
        rb.velocity = new Vector2(runningForce, 0f);
        isSprinting = false;
    }

    IEnumerator AppleSpeedDuration()
    {
        yield return new WaitForSeconds(appleSpeedCooldown);
        rb.velocity = new Vector2(runningForce, 0f);
        isSprinting = false;
    }
  /*  void FixedUpdate()
    {
       rb.velocity = new Vector2(runningForce, 0f);
    } */
}
