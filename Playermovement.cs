using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewayForce = 500f;

    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        
        if(Input.GetKey("d"))
        {
            rb.AddForce(500 * Time.deltaTime, 0, 0);

        }
        if(Input.GetKey("a"))
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0);
        }
        if(Input.GetKey("w"))
        {
            rb.AddForce(0,0,sidewayForce * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0,0,-sidewayForce * Time.deltaTime);
        }
    }
}
