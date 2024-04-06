using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovesScript : MonoBehaviour
{
    public float posX = 1f, posY = 1f, posZ = 1f;
    public const float MAXCOORD = 10f;
    public const float MINCOORD = -10f;
    public float duration = 5f;
    private Vector3 initialPosition, targetPosition;

    void Start()
    {
        initialPosition = new Vector3(posX, posY, posZ);

        StartCoroutine(Movement(RandomCoordinate(), duration));

    }

    IEnumerator Movement(Vector3 targetPosition, float duration)
    {
        initialPosition = transform.position;
        float elapsedTime = 0;

        while(elapsedTime < duration){
            elapsedTime += Time.deltaTime;
            transform.position += Vector3.Lerp(initialPosition, targetPosition, elapsedTime/duration);
            yield return null;
        }
    }


    private Vector3 RandomCoordinate()
    {
        return new Vector3(Random.Range(MAXCOORD, MINCOORD), Random.Range(MAXCOORD, MINCOORD), Random.Range(MAXCOORD, MINCOORD));
    }

     void BuildCube(float x, float y, float z)
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = new Vector3(x, y, z);
        // cube.AddComponent<>();
    }   

}
