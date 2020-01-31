using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float minX, maxX, minY, maxY;

    private Rigidbody2D rigidBody;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float horiz = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");

        rigidBody.velocity = new Vector2(horiz, vert) * speed;

        Vector2 currentPosition = rigidBody.position;
        rigidBody.position = new Vector2(
            Mathf.Clamp(currentPosition.x, minX, maxX),
            Mathf.Clamp(currentPosition.y, minY, maxY));
    }
}
