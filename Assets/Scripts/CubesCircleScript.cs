using UnityEngine;

public class CubesCircleScript : MonoBehaviour
{

    public int numCubos = 100;
    public float radio = 5f;
    void Start()
    {
        for (int i = 0; i < numCubos; i++)
        {
            // posicion angular en radianes
            float angulo = i * 2 * Mathf.PI / numCubos;

            // coordenadas x y z para cada cubo
            float x = Mathf.Cos(angulo) * radio;
            float z = Mathf.Sin(angulo) * radio;

            // crear cubo y posicionarlo
            GameObject cubo = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cubo.transform.position = new Vector3(x, 0, z);
        }
    }

}
