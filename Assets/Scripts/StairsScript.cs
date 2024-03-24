using UnityEngine;

public class Stairs : MonoBehaviour
{

    public int steps = 20;
    public float stepHeight = 1.0f;
    public float stepLong = 10.0f;
    public float stepDepth = 5.0f;
    public bool randomHeight = false;
    public bool randomDepth = false;


    void Start()
    {
        Vector3 position = new Vector3(0, 0, 0);

        float height = (randomHeight) ? Random.Range(0, 3f) : stepHeight;
        float depth = (randomDepth) ? Random.Range(0, 3f) : stepDepth;

        for (int i = 0; i < steps; i++)
        {
            GameObject newCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            newCube.GetComponent<Renderer>().material.color = Color.red;

            newCube.transform.position = position;

            newCube.transform.localScale = new Vector3(depth, height, stepLong);

            float newHeight = (randomHeight) ? Random.Range(0, 3f) : stepHeight;
            float newDepth = (randomDepth) ? Random.Range(0, 3f) : stepDepth;

            position += new Vector3(depth / 2 + newDepth / 2, height / 2 + newHeight / 2, 0);
            depth = newDepth;
            height = newHeight;
        }
    }


}
