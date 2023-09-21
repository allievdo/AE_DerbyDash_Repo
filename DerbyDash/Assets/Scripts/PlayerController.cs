using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;

    public float runningForce = 3f;

    public float speedBoost = 6f;

    void Update()
    {

        Debug.Log("Sprint");
        rb.velocity = new Vector2(runningForce, 0f);
        /*if (Input.GetKeyDown(KeyCode.D))
        {
         
        }*/

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(speedBoost, 0f);
        }

        if(Input.GetKeyUp(KeyCode.Space))
        {
            rb.velocity = new Vector2(runningForce, 0f);
        }
    }
    void FixedUpdate()
    {
       // rb.velocity = new Vector2(runningForce, 0f);
    }
}
