using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;

    public float runningForce = 3f;

    void FixedUpdate()
    { 
        rb.velocity = new Vector2(runningForce, 0f);
    }
}
