using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actividad1 : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public float spawnInterval = 2.0f;

    private void Start()
    {
        StartCoroutine(SpawnObject());
    }

    private IEnumerator SpawnObject()
    {
        while (true) 
        {
        Instantiate (prefabToSpawn, transform.position, Quaternion.identity);

        yield return new WaitForSeconds (spawnInterval);
        }
    }
}
