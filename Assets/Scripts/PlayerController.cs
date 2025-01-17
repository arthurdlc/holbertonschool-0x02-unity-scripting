using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 50f;
    public Rigidbody rb;

     private int score = 0;

    void OnTriggerEnter(Collider other)
    {
        // Check if the object is tagged as "Pickup"
        if (other.CompareTag("Pickup"))
        {
            score++;
            Debug.Log("Score: " + score);
            other.gameObject.SetActive(false);
        }
    }
        
    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(horizontalInput, 0, verticalInput);
        rb.AddForce(move * speed);
    }
}
