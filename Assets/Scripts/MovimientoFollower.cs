using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoFollower : MonoBehaviour
{
    public GameObject objetivo;
    float velocidad = 5f;
    float maxDistance = 10f;
    float minDistance = 5f;

    void Update()
    {
        float distanciaObjetivo = Vector3.Distance(transform.position, objetivo.transform.position);

        if(distanciaObjetivo < minDistance)
        {
            Vector3 direccion = (transform.position - objetivo.transform.position).normalized;
            GetComponent<Renderer>().material.color = Color.blue;
            transform.position += direccion * velocidad * Time.deltaTime;
        }
        else if(distanciaObjetivo < maxDistance)
        {
            Vector3 direccion = (objetivo.transform.position - transform.position).normalized;
            GetComponent<Renderer>().material.color = Color.blue;
            transform.position += direccion * velocidad * Time.deltaTime;
        }
        

    }
}
