using UnityEngine;

public class CubesTriangleScript : MonoBehaviour
{
    public float lado = 4f;
    public int numCubos = 27;

    void Start()
    {
        float espacio = 3 * lado / numCubos;
        float altura = Mathf.Sqrt(3) * lado / 2;
        for (int i = 0; i < numCubos; i++)
        {
            float posActual = i * espacio;
            Vector3 posCubo = Vector3.zero;

            if (posActual < lado)
            {
                posCubo.x = posActual;

            }
            else if (posActual < 2 * lado)
            {
                posCubo.x = lado - (posActual - lado) * 0.5f;
                posCubo.z = (posActual - lado) * altura / lado;
            }
            else
            {
                posCubo.x = lado - (posActual - lado) * 0.5f;
                posCubo.z = altura - (posActual - 2 * lado) * altura / lado;
            }

            GameObject cubo = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cubo.transform.position = posCubo;
        }

    }

}
