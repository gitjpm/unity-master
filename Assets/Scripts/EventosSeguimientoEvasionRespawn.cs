using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventosSeguimientoEvasionRespawn : MonoBehaviour
{
    // eventos para actualizar la cantidad de respawns y la posicion de respawn
    public delegate void EventoCantidadRespawn(int n);
    public static event EventoCantidadRespawn ActualizarCantidadRespawns;
    public delegate void EventoPosicionRespawn(Vector3 v);
    public static event EventoPosicionRespawn ActualizarPosicionRespawns;
    private int cantidadRespawns = 0;



    public Transform objetivo;
    public float distanciaSeguimiento = 5.0f;
    public float distanciaRespawn = 0.5f;
    public Vector3[] posicionesRespawn;
    public float velocidad = 3f;
    void Update()
    {
        float distanciaObjetivo = Vector3.Distance(transform.position, objetivo.transform.position);
        
        //respawn
        if(distanciaObjetivo < distanciaRespawn)
        {
            transform.position = posicionesRespawn[Random.Range(0, posicionesRespawn.Length)];
            // lanzamos los eventos al actualizar la cantidad de respawns
            ActualizarCantidadRespawns?.Invoke(++cantidadRespawns);
            ActualizarPosicionRespawns?.Invoke(transform.position);

        }else if(distanciaObjetivo < distanciaSeguimiento){
            transform.position = Vector3.MoveTowards(transform.position, objetivo.transform.position, velocidad * Time.deltaTime);
        }
        
    }

   
}
