using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObjectGenerator : MonoBehaviour
{
    public GameObject[] models; // Array mit allen Modellen, aus denen zufällig ausgewählt werden soll
    public int numberOfObjects = 10; // Anzahl der zufällig generierten Objekte
    public float range = 10f; // Bereich, in dem die Objekte platziert werden
    public Transform[] spawnPoints; // Array mit den Transform-Objekten, an denen die Objekte platziert werden sollen
    public float spawnInterval = 1f; // Zeitintervall zwischen den Spawns
    public float spawnIntervalReduction = 0.1f; // Reduktion des Zeitintervalls pro Spawn
    public float minSpawnInterval = 0.1f; // Minimales Zeitintervall zwischen den Spawns

    private float currentSpawnInterval; // Aktuelles Zeitintervall zwischen den Spawns
    private int objectsSpawned; // Anzahl der bereits generierten Objekte

    void Start()
    {
        currentSpawnInterval = spawnInterval;
        objectsSpawned = 0;

        StartCoroutine(SpawnObjects());
    }

    IEnumerator SpawnObjects()
    {
        while (objectsSpawned < numberOfObjects)
        {
            // Zufälliges Modell auswählen und instanziieren
            int randomModelIndex = Random.Range(0, models.Length);
            GameObject randomModel = Instantiate(models[randomModelIndex]);

            // Zufälligen Spawn-Point auswählen und Position des Gameobjects setzen
            int randomSpawnIndex = Random.Range(0, spawnPoints.Length);
            Vector3 randomPosition = new Vector3(Random.Range(-range, range), 0, Random.Range(-range, range));
            randomModel.transform.position = spawnPoints[randomSpawnIndex].position + randomPosition;

            // Zufällige Rotation des Gameobjects setzen
            randomModel.transform.rotation = Quaternion.Euler(0, Random.Range(0, 360), 0);

            // Zeitintervall zwischen den Spawns reduzieren
            currentSpawnInterval -= spawnIntervalReduction;
            if (currentSpawnInterval < minSpawnInterval)
            {
                currentSpawnInterval = minSpawnInterval;
            }

            // Auf die nächste Spawn-Runde warten
            objectsSpawned++;
            yield return new WaitForSeconds(currentSpawnInterval);
        }
    }
}
