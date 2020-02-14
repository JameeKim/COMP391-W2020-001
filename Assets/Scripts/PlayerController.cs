using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float minX, maxX, minY, maxY;
    public Transform laserSpawn;
    public GameObject laser;
    public float fireInterval = 0.25f;

    private Rigidbody2D rigidBody;
    private float timer = 0f;

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

    private void Update()
    {
        if (Input.GetAxis("Fire1") > 0f && timer > fireInterval)
        {
            GameObject obj = Instantiate(laser, laserSpawn.position, laserSpawn.rotation);
            obj.transform.Rotate(0f, 0f, -90f);
            timer = 0f;
        }

        timer += Time.deltaTime;
    }
}
