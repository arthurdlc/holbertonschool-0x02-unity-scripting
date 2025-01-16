using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 50f;
    public Rigidbody rb;
        
    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(horizontalInput, 0, verticalInput);
        rb.AddForce(move * speed);
    }
}
