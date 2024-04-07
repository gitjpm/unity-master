using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguimientoEvasionRespawn : MonoBehaviour
{
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

        }else if(distanciaObjetivo < distanciaSeguimiento){
            transform.position = Vector3.MoveTowards(transform.position, objetivo.transform.position, velocidad * Time.deltaTime);
        }
        
    }

   
}
