using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguimientoCamara : MonoBehaviour
{
    public Transform objectivo;
    public float distancia = 10.0f;
    public Vector3 offset = new Vector3(0, 0, 0);

    // Update is called once per frame
    void Update()
    {
        if (objectivo != null)
        {
            // calcular nueva posicion
            transform.position = objectivo.position - (objectivo.forward * distancia) + offset;
        }
    }
}
