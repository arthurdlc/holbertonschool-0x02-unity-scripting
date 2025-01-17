using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 50f;
    public Rigidbody rb;
    public int health = 5;
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
        if (other.CompareTag("Trap"))
        {
            health--;
            Debug.Log("Health: " + health);
            // if (health <= 0)
            // {
            //     Debug.Log("Game Over");
            //     Application.Quit();
            // }
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
