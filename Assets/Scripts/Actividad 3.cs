using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Actividad3 : MonoBehaviour
{
    public Text textoContador;
    public float tiempoContador = 3f;

    private void Start()
    {
        StartCoroutine(InicioRoutine());
    }
    IEnumerator InicioRoutine()
    {
        int contador = Mathf.CeilToInt(tiempoContador);
        while (contador > 0)
        {
            textoContador.text = contador.ToString();
            yield return new WaitForSeconds(1f);
            contador--;
        }
        textoContador.text = "Comienza el juego";

        yield return new WaitForSeconds(1f);

        gameObject.SetActive(false);
    }

}
