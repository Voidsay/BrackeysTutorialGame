using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public Rigidbody rb; //referende to rigidbody

    public float forwardForce=2000f; //to eddit inside Unity (inspector) mark as "public"
    public float sidewaysForce=100f;

    // use "FixedUpdate" instead of "Update" when using physics
    void FixedUpdate()
    {
    //add force forward Force on z-axis
        rb.AddForce(0,0,forwardForce*Time.deltaTime); // "Time.deltaTime" used to compensate Framerate vairation

        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if(Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }

        if(rb.position.y<-1)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
