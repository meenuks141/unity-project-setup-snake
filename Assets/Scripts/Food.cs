using UnityEngine;

public class Food : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            transform.position = new Vector2(
                Random.Range(-8, 8),
                Random.Range(-4, 4)
            );
        }
    }
}