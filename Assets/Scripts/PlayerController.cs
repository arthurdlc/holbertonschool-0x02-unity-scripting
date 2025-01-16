using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 50f;
    [SerializeField] Rigidbody rb;

    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(horizontalInput, 0, verticalInput);
        rb.AddForce(move * speed);
    }
}
