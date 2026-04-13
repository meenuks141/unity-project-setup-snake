using UnityEngine;

public class SnakeMovement : MonoBehaviour
{
    public float speed = 5f;
    private Vector2 direction = Vector2.right;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
            direction = Vector2.up;
        if (Input.GetKeyDown(KeyCode.DownArrow))
            direction = Vector2.down;
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            direction = Vector2.left;
        if (Input.GetKeyDown(KeyCode.RightArrow))
            direction = Vector2.right;
    }

    void FixedUpdate()
    {
        transform.Translate(direction * speed * Time.fixedDeltaTime);
    }
}