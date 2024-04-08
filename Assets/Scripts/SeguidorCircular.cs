using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class SeguidorCircular : MonoBehaviour
{
    public Transform objetivo;
    public float velocidad = 5.0f;
    public float radio = 10.0f;
    public int cantidadPuntosCirculo = 10;
    public float distanciaSeguimiento = 5.0f;
    public float distanciaEvasion = 2.0f;

    private Vector3 puntoCentral;
    private Vector3 puntoActualCirculo;
    private Vector3[] puntosCirculo;
    private int indice = 0;

    void Start()
    {
        puntoCentral = transform.position;
        puntosCirculo = new Vector3[cantidadPuntosCirculo];
        // creamos el array de puntos para el circulo
        for (int i = 0; i < cantidadPuntosCirculo; i++)
        {
            // 2*PI radianes = 360 grados
            // luego, en cada punto del circulo se gastan estos radianes
            float angulo = i * 2 * Mathf.PI / cantidadPuntosCirculo;
            float x = Mathf.Cos(angulo) * radio;
            float z = Mathf.Sin(angulo) * radio;
            puntosCirculo[i] = new Vector3(puntoCentral.x + x, transform.position.y, puntoCentral.z + z);
        }
        puntoActualCirculo = puntosCirculo[indice];
    }

    void Update()
    {
        float distanciaObjetivo = Vector3.Distance(transform.position, objetivo.transform.position);
        Vector3 pos = transform.position;

        //respawn
        if (distanciaObjetivo < distanciaEvasion) // evitar al objetivo
        {
            Vector3 direccion = (transform.position - objetivo.transform.position).normalized;
            transform.position += direccion * velocidad * Time.deltaTime;
            GetComponent<Renderer>().material.color = Color.blue;
        }
        else if (distanciaObjetivo < distanciaSeguimiento) // acercarse al objetivo
        {
            transform.position = Vector3.MoveTowards(transform.position, objetivo.transform.position, velocidad * Time.deltaTime);
            GetComponent<Renderer>().material.color = Color.red;
        }
        else // volver al ultimo punto de seguimiento y seguir el patron circular
        {
            if (Vector3.Distance(pos, puntoActualCirculo) > 0.1f)
            {
                transform.position = Vector3.MoveTowards(pos, puntoActualCirculo, velocidad * Time.deltaTime);
                GetComponent<Renderer>().material.color = Color.yellow;
            }
            else
            {
                indice = ++indice % cantidadPuntosCirculo;
                puntoActualCirculo = puntosCirculo[indice];
            }
        }

    }


}
