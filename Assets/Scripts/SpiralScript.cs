using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiralScript : MonoBehaviour
{
    public float radio = 2.0f;
    public int vueltas = 3;
    public int puntosPorVuelta = 100;
   

    void Start()
    {
        int i = 0;
        do
        {
            float angulo = Mathf.PI * 2 * i / puntosPorVuelta;
            float x = radio * Mathf.Cos(angulo);
            float z = radio * Mathf.Sin(angulo);
            float y = i * 0.1f;

            GameObject nuevoCubo = GameObject.CreatePrimitive(PrimitiveType.Cube);
            nuevoCubo.transform.position = new Vector3(x, y, z);

            radio += 0.05f;
            i++;    
        }while(i < vueltas * puntosPorVuelta);
        
    }


}
