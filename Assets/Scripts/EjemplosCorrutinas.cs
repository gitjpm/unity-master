using System.Collections;
using UnityEngine;

public class EjemplosCorrutinas : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Coroutine c1 = StartCoroutine(CambiarColor(1));
        Coroutine c2 = StartCoroutine(MoverEnTiempoLerp(new Vector3(3, 3, 3), 3));


    }

    IEnumerator MiCorrutina()
    {
        Debug.Log("Visita aulaenlanube.com");
        yield return new WaitForSeconds(2);
        Debug.Log("... han pasado 2 segundos");
    }

    IEnumerator Parar(Coroutine c, float t)
    {
        yield return new WaitForSeconds(t);
        StopCoroutine(c);
    }

    IEnumerator CambiarColor(float n)
    {
        Renderer rend = GetComponent<Renderer>();
        while (true)
        {
            rend.material.color = Color.red;
            yield return new WaitForSeconds(n);
            rend.material.color = Color.green;
            yield return new WaitForSeconds(n);
            rend.material.color = Color.blue;
            yield return new WaitForSeconds(n);
        }
    }

    IEnumerator MoverEnTiempo(Vector3 posicionObjetivo, float duracion)
    {
        Vector3 posicionInicial = transform.position;
        float tiempoTranscurrido = 0.0f;
        while (tiempoTranscurrido < duracion)
        {
            tiempoTranscurrido += Time.deltaTime;
            float t = tiempoTranscurrido / duracion;
            // calcular las nuevas coordenadas para cada eje
            float xNueva = posicionInicial.x + (posicionObjetivo.x - posicionInicial.x) * t;
            float yNueva = posicionInicial.y + (posicionObjetivo.y - posicionInicial.y) * t;
            float zNueva = posicionInicial.z + (posicionObjetivo.z - posicionInicial.z) * t;

            // actualizar la posicion del objeto
            transform.position = new Vector3(xNueva, yNueva, zNueva);
            yield return null;
        }

        transform.position = posicionObjetivo;
    }

    IEnumerator MoverEnTiempoLerp(Vector3 posicionObjetivo, float duracion)
    {
        Vector3 posicionInicial = transform.position;
        float tiempoTranscurrido = 0.0f;
        while (tiempoTranscurrido < duracion)
        {
            tiempoTranscurrido += Time.deltaTime;
            transform.position = Vector3.Lerp(posicionInicial, posicionObjetivo, tiempoTranscurrido / duracion);
            yield return null;
        }

        transform.position = posicionObjetivo;
    }


}
