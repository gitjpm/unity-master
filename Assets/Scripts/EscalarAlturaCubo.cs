using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscalarAlturaCubo : MonoBehaviour
{

    public float duracion = 1f, escalaMinima = 1f, escalaMaxima = 3f;
    private Vector3 escalaInicial, escalaObjetivo;

    // Start is called before the first frame update
    void Start()
    {
        escalaInicial = new Vector3(1, 1, 1);
        StartCoroutine(AlterarEscala());
    }

    // Update is called once per frame
    private IEnumerator AlterarEscala()
    {
        escalaInicial = new Vector3(1, 1, 1);
        while (true)
        {
            float escalaYObjetivo = Random.Range(escalaMinima, escalaMaxima);
            escalaObjetivo = new Vector3(1, escalaYObjetivo, 1);
            yield return CambiarEscala(escalaInicial, escalaObjetivo);
            yield return CambiarEscala(escalaObjetivo, escalaInicial);

        }
    }

    private IEnumerator CambiarEscala(Vector3 desde, Vector3 hasta)
    {
        float tiempoTranscurrido = 0f;
        while (tiempoTranscurrido < duracion)
        {
            tiempoTranscurrido += Time.deltaTime;
            float progreso = tiempoTranscurrido / duracion;
            float escalaY = Mathf.Lerp(desde.y, hasta.y, progreso);
            transform.localScale = new Vector3(1, escalaY, 1);

            transform.position = new Vector3(transform.position.x, escalaY / 2, transform.position.z);
            yield return null;
        }
    }
}
