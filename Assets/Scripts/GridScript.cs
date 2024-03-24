using UnityEngine;

public class GridScript : MonoBehaviour
{

    public float size = 5f;
    public float padding = 1f;
    public int limitY = 5;
    public int limitX = 5;
    public int limitZ = 5;

    void Start()
    {
        Vector3 initialPosition = Vector3.zero;

        float space = size + padding;
        for (int z = 0; z < limitZ; z++)
        {
            for (int y = 0; y < limitY; y++)
            {
                for (int x = 0; x < limitX; x++)
                {
                    GameObject go = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    go.transform.localScale = new Vector3(size, size, size);
                    go.transform.position = new Vector3(x * space, y * space, z * space);
                }
            }
        }
    }

}
