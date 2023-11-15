using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actividad2 : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public float tiempoMinimo = 1f;
    public float tiempoMaximo = 5f;

    private void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    IEnumerator SpawnRoutine() 
    {
        while (true)
        {
            Instantiate(prefabToSpawn, transform.position, Quaternion.identity);

            float tiempoEspera = Random.Range(tiempoMinimo, tiempoMaximo);
            yield return new WaitForSeconds(tiempoEspera);
        }
    }
}
