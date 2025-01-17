using UnityEngine;
using UnityEngine.SceneManagement; // Nécessaire pour recharger une scène

public class PlayerController : MonoBehaviour
{
    public float speed = 50f;
    public Rigidbody rb;
    public int health = 5;
    private int score = 0;

    void Update()
    {
        // Vérifie si la santé est à 0
        if (health <= 0)
        {
            Debug.Log("Game Over!");

            // Recharge la scène actuelle
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // Vérifie si l'objet a le tag "Pickup"
        if (other.CompareTag("Pickup"))
        {
            score++;
            Debug.Log("Score: " + score);
            other.gameObject.SetActive(false);
        }

        // Vérifie si l'objet a le tag "Trap"
        if (other.CompareTag("Trap"))
        {
            health--;
            Debug.Log("Health: " + health);
        }

        // Vérifie si l'objet a le tag "Goal"
        if (other.CompareTag("Goal"))
        {
            Debug.Log("You Win!");
            Application.Quit();
        }
    }

    void FixedUpdate()
    {
        // Gère les entrées pour déplacer le joueur
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(horizontalInput, 0, verticalInput);
        rb.AddForce(move * speed);
    }
}
