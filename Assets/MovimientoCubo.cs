using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCubo : MonoBehaviour
{
    public float velocidad = 5f;

    // Update is called once per frame
    void Update()
    {
        float movimiento = velocidad * Time.deltaTime;
        // mueve el cubo de izquierda a derecha y viceversa al llegar a un límite
        transform.position += new Vector3(movimiento, 0, 0);
        if(transform.position.x > 5 || transform.position.x < -5)
        {
            // invertimos la dirección
            velocidad = -velocidad;

            // cambiamos el color del material
            GetComponent<Renderer>().material.color = Random.ColorHSV();
        }

        GetComponent<Renderer>().material.color = transform.position.y switch
        {
            > 5 => Color.green,
            < -5 => Color.red,
            _ => Color.blue,
        };
        
    }
}
