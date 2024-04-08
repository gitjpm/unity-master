using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class MoverConFlechas : MonoBehaviour
{
    public float velocidad = 5.0f;

    // Update is called once per frame
    void Update()
    {
        float despHorizontal = 0;
        float despVertical = 0;
        if (Input.GetKey(KeyCode.UpArrow)) despVertical = 1;
        if (Input.GetKey(KeyCode.DownArrow)) despVertical = -1;
        if (Input.GetKey(KeyCode.LeftArrow)) despHorizontal = -1;
        if (Input.GetKey(KeyCode.RightArrow)) despHorizontal = 1;

        // calcular el vector desplazamiento
        Vector3 desplazamiento = new Vector3(despHorizontal, 0, despVertical);

        // mover el gameobject
        transform.Translate(desplazamiento * velocidad * Time.deltaTime);
    }
}
