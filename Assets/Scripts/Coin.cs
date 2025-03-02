using UnityEngine;

public class Coin : MonoBehaviour
{
    void Update()
    {
        // Rotate the entire Coin GameObject, including the FBX child
        transform.Rotate(Vector3.up, 90 * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.instance.AddScore(1);
            Destroy(gameObject); // Destroys the parent Coin, including the FBX child
        }
    }
}