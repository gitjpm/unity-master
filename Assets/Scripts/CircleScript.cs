using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CircleScript : MonoBehaviour
{
    public int points = 1000;
    float radius = 2f;
   

    // Start is called before the first frame update
    void Start()
    {
        int n = 0;
        float angle = 0;
        float degreesInterval = getDegreesInterval(points);
        float radians;

        do
        {
            Debug.Log("n = " + n);
            GameObject newCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            Debug.Log("angle = " + angle);
            radians = getDegreesToRadians(angle);
            Debug.Log("radians = " + radians);
            Vector3 position = getCirclePoint(radians);
            Debug.Log("position = " + position);
            newCube.transform.position = position * radius;
            angle += degreesInterval;
            n++;
            radius -= 0.1f;
        } while(n < points);
    }


    float getDegreesToRadians(float degrees)
    {

        return degrees * (Mathf.PI / 180);
    }

    float getDegreesInterval(int points)
    {
        return 360 / points;
    }

    Vector3 getCirclePoint(float radians)
    {
        float x = Mathf.Cos(radians);
        float y = Mathf.Sin(radians);

        return new Vector3 (x, y, 0);
    }
}