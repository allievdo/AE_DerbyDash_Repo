using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;

    public float runningForce;
    void FixedUpdate()
    {
        rb.velocity = new Vector2(runningForce, 0f);
    }

}
