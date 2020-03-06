using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float tumble = 200f;

    private Rigidbody2D rigidBody;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.angularVelocity = Random.value * tumble;
    }
}
