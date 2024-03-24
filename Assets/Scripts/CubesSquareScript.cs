using UnityEngine;

public class CubesSquareScript : MonoBehaviour
{

    public float lado = 10f;
    public int numCubos = 20;

    // Start is called before the first frame update
    void Start()
    {
        float perimetro = 4 * lado;
        float espacio = perimetro / numCubos;

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
                posCubo.x = lado;
                posCubo.z = posActual - lado;
            }
            else if (posActual < 3 * lado)
            {
                posCubo.x = 3 * lado - posActual;
                posCubo.z = lado;
            }
            else
            {
                posCubo.z = 4 * lado - posActual;
            }
            GameObject cubo = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cubo.transform.position = posCubo;

        }
    }


}
