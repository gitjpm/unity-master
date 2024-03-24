using UnityEngine;

public class PyramidScript : MonoBehaviour
{
    public float cubeSize = 5f;
    public float padding = 0.1f;
    public int levels = 5;


    void Start()
    {
        Vector3 position = Vector3.zero;

        float space = cubeSize + padding;
        // for para una linea de piramides en Z
        for (int p = 0; p < 5; p++)
        {
            position = Vector3.zero + new Vector3(0, 0, p * levels * space);

            // for para una linea de piramides en X
            for (int n = 0; n < 5; n++)
            {
                position = Vector3.zero + new Vector3(n * levels * space, 0, p * levels * space);

                // código para pirámides
                for (int y = 0; y < levels; y++)
                {
                    for (int z = 0; z < levels - y; z++)
                    {
                        for (int x = 0; x < levels - y; x++)
                        {
                            GameObject go = GameObject.CreatePrimitive(PrimitiveType.Cube);
                            go.transform.localScale = new Vector3(cubeSize, cubeSize, cubeSize);
                            go.transform.position = position + new Vector3((x * space), (y * space), (z * space));
                            Debug.Log("dibujando un cubo de tamaño " + go.transform.localScale + " en la posición " + go.transform.position);
                        }
                    }
                    position.x += space / 2;
                    position.z += space / 2;
                }
            }
        }

    }


}
