using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEspecial : MonoBehaviour
{
    private Vector3 posicionInicial, posicionActual;
    private const int ARRIBA = 0, ABAJO = 1, IZQUIERDA = 2, DERECHA = 3;
    public float velocidad = 5f;
    public float lado = 5f;
    private int direccion = DERECHA;

    private void Start()
    {
        posicionInicial = transform.position;
    }

    
    void Update()
    {
        Vector3 movimiento = direccion switch
        {
            DERECHA => Vector3.right,
            ARRIBA => Vector3.up,
            IZQUIERDA => Vector3.left,
            ABAJO => Vector3.down,
            _ => Vector3.zero
        };

        transform.position += movimiento * velocidad * Time.deltaTime;
        posicionActual = transform.position;

        if(posicionActual.x > posicionInicial.x + lado && direccion == DERECHA) { direccion = ARRIBA; }
        else if(posicionActual.y > posicionInicial.y + lado && direccion == ARRIBA) { direccion = IZQUIERDA; }
        else if(posicionActual.x < posicionInicial.x && direccion == IZQUIERDA) { direccion = ABAJO; }
        else if(posicionActual.y < posicionInicial.y && direccion == ABAJO) { direccion = DERECHA; }


    }
}
