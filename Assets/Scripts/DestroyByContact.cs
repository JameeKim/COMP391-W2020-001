using UnityEngine;

public class DestroyByContact : MonoBehaviour
{
    public GameObject explosion;
    public GameObject playerExplosion;

    private void OnCollisionEnter2D(Collision2D other)
    {
        Transform transformCache = transform;
        Instantiate(explosion, transformCache.position, transformCache.rotation);

        if (other.gameObject.CompareTag("Player"))
        {
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
        }

        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
