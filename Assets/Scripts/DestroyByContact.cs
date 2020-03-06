using UnityEngine;

public class DestroyByContact : MonoBehaviour
{
    public GameObject explosion;

    private void OnCollisionEnter2D(Collision2D other)
    {
        Transform transformCache = transform;
        Instantiate(explosion, transformCache.position, transformCache.rotation);

        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
