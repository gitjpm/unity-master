using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
   public float alcanceDelRayo = 100.0f; // alcance máximo del rayo

    // Update is called once per frame
    void Update()
    {
        Ray rayo = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        if(Physics.Raycast(rayo, out hitInfo, alcanceDelRayo))
        {
            ;
        }

    }
}
