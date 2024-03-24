using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZigZagScript : MonoBehaviour
{
    public int lado;
    public float separacion;
    public float intervalo;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CrearCuadradoZigZag());
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
                    cubo.transform.position = new Vector3(x, 0, z);
                    yield return new WaitForSeconds(intervalo);
                }
            }
            else
            {
                for (int x = lado - 1; x >= 0; x--)
                {
                    GameObject cubo = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    cubo.transform.position = new Vector3(x, 0, z);
                    yield return new WaitForSeconds(intervalo);
                }
            }
            izquierdaADerecha = !izquierdaADerecha;
        }
    }

}
