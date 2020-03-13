using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameController : MonoBehaviour
{
    /**
     * Hazard that is spawned
     */
    [Header("Hazard Wave Settings")]
    public GameObject hazard;

    /**
     * Where the hazards are spawned
     */
    public Vector2 spawnValue;

    /**
     * How many hazards are spawned per wave
     */
    public int hazardCount;

    /**
     * How long to wait before the first wave
     */
    [Header("Hazard Wave Time Settings")]
    public float startWait;

    /**
     * How long to wait between the spawned hazards
     */
    public float spawnWait;

    /**
     * How long to wait between the waves
     */
    public float waveWait;

    private void Start()
    {
        StartCoroutine(SpawnWaves());
    }

    /**
     * Coroutine to spawn waves of hazards
     */
    private IEnumerator SpawnWaves()
    {
        //Initial delay before the first wave
        yield return new WaitForSeconds(startWait);

        // Start spawning waves of hazards
        while (true)
        {
            // Spawn the hazards
            for (int i = 0; i < hazardCount; i++)
            {
                // Spawn a single hazard
                Vector2 spawnPosition = new Vector2(spawnValue.x, Random.Range(-spawnValue.y, spawnValue.y));
                Instantiate(hazard, spawnPosition, Quaternion.identity);

                // Wait for the next hazard spawn
                yield return new WaitForSeconds(spawnWait);
            }

            // Wait for the next wave
            yield return new WaitForSeconds(waveWait);
        }
    }
}
