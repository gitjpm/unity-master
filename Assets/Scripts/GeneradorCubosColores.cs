using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoopScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 10; i++)
        {
            Vector3 posicionNueva = new Vector3(i * 1.2f, 0, 0);
            GameObject nuevoCubo = GameObject.CreatePrimitive(PrimitiveType.Cube);
            nuevoCubo.transform.position = posicionNueva;
        }

        
        int j = 0;
        Color color = Color.red;
        while(j < 10)
        {
            Vector3 posicionNueva = new Vector3(j * 1.2f, 0, 5);
            GameObject nuevoCubo = GameObject.CreatePrimitive(PrimitiveType.Cube);
            nuevoCubo.transform.position = posicionNueva;
            nuevoCubo.GetComponent<Renderer>().material.color = (j % 2 == 0) ? Color.red : Color.blue;
            j++;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
