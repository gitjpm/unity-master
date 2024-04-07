using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosArrays : MonoBehaviour
{

    public Vector3[] puntos;
    public float duracion;
    void Start()
    {
        StartCoroutine(MoverEntrePuntos(puntos, duracion));
    }

    IEnumerator MoverEntrePuntos(Vector3[] puntos, float duracion)
    {
        if (puntos.Length < 2) yield break;
        int indiceSiguientePunto = 0;
        Vector3 inicio = transform.position;
        float tiempoTranscurrido = 0f;
        while (true)
        {
            Vector3 destino = puntos[indiceSiguientePunto];
            tiempoTranscurrido += Time.deltaTime;
            float progreso = tiempoTranscurrido / duracion;
            transform.position = Vector3.Lerp(inicio, destino, progreso);
            if (progreso >= 1f) // si llegamos al punto de destino
            {
                transform.position = destino;
                inicio = destino;
                tiempoTranscurrido = 0;
                indiceSiguientePunto = ++indiceSiguientePunto % puntos.Length;
            }
            yield return null;
        }
    }
}
