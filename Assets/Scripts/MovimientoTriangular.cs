using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoTriangular : MonoBehaviour
{
    private Vector3 posicionInicial, posicionActual, direccionArriba, direccionAbajo;
    private const int ARRIBA = 0, ABAJO = 1, DERECHA = 2;
    public float velocidad = 5f;
    public float lado = 5f;
    private int direccion = DERECHA;
    private double altura;

    void Start()
    {
        posicionInicial = transform.position;
        altura = alturaTrianguloEquilatero(lado);
        Debug.Log("altura = " + altura);
        
        direccionArriba = (new Vector3((lado / 2), (float)altura, 0) - new Vector3(lado, 0, 0)).normalized;
        Debug.Log("direccionArriba = " + direccionArriba);

        direccionAbajo = (posicionInicial - new Vector3((lado / 2), (float)altura, 0)).normalized;
        Debug.Log("direccionAbajo = " + direccionAbajo);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movimiento = direccion switch
        {
            DERECHA => new Vector3(1, 0, 0),
            ARRIBA => direccionArriba,
            ABAJO => direccionAbajo,
            _ => Vector3.zero
        };

        transform.position += movimiento * velocidad * Time.deltaTime;
        posicionActual = transform.position;        

        if (posicionActual.x >= posicionInicial.x + lado && direccion == DERECHA) { direccion = ARRIBA; }
        else if (posicionActual.y >= posicionInicial.y + altura && direccion == ARRIBA) { direccion = ABAJO; }
        else if (posicionActual.y <= posicionInicial.y && direccion == ABAJO) { direccion = DERECHA;  }     
    }

    float alturaTrianguloEquilatero(float lado)
    {
        double altura = System.Math.Sqrt(System.Math.Pow(lado, 2) - System.Math.Pow(lado / 2, 2));

        return (float)altura;
    }
}
