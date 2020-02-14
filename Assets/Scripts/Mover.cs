using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speed = 10f;

    private Rigidbody2D rigidBody;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.velocity = new Vector2(speed, 0f);
    }
}
