using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZigZagScript : MonoBehaviour
{
    public int lado;
    public float separacion;
    public float intervalo;

    public enum direccion
    {
        IZQUIERDA,
        ARRIBA,
        DERECHA,
        ABAJO
    };

    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(CrearCuadradoZigZag());
        StartCoroutine(CrearCuboEspiral());
    }

    IEnumerator CrearCuadradoZigZag()
    {
        bool izquierdaADerecha = true;
        for (int z = 0; z < lado; z++)
        {
            if (izquierdaADerecha)
            {
                for (int x = 0; x < lado; x++)
                {
                    GameObject cubo = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    cubo.transform.position = new Vector3(x * separacion, 0, z * separacion);
                    yield return new WaitForSeconds(intervalo);
                }
            }
            else
            {
                for (int x = lado - 1; x >= 0; x--)
                {
                    GameObject cubo = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    cubo.transform.position = new Vector3(x * separacion, 0, z * separacion);
                    yield return new WaitForSeconds(intervalo);
                }
            }
            izquierdaADerecha = !izquierdaADerecha;
        }
    }

    IEnumerator CrearCuboEspiral()
    {

        int x = 0, z = 0;
        int capas = (lado + 1) / 2;

        for (int i = 0; i < capas; i++)
        {
            // derecha
            for (int j = 0; j < lado - (i * 2); j++)
            {
                CrearCubo(x, 0, z);
                yield return new WaitForSeconds(intervalo);
                if (j < lado - (i * 2) - 1)
                {
                    x++;
                }
            }

            // arriba
            for (int j = 0; j < lado - (i * 2) - 1; j++)
            {
                z++;
                CrearCubo(x, 0, z);
                yield return new WaitForSeconds(intervalo);
            }

            // izquierda
            for (int j = 0; j < lado - (i * 2) - 1; j++)
            {
                x--;
                CrearCubo(x, 0, z);
                yield return new WaitForSeconds(intervalo);
            }

            // abajo
            for (int j = 0; j < lado - (i * 2) - 2; j++)
            {
                z--;
                CrearCubo(x, 0, z);
                yield return new WaitForSeconds(intervalo);
            }
            x++;
        }



    }

    void CrearCubo(float x, float y, float z)
    {
        GameObject cubo = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cubo.transform.position = new Vector3(x * separacion, y * separacion, z * separacion);
    }

}
