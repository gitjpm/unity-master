using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class MoverConFlechasPersonalizado : MonoBehaviour
{
    private const int VELOCIDAD_POR_DEFECTO = 10;
    public float velocidad = 5.0f;
    public KeyCode arriba;
    public KeyCode abajo;
    public KeyCode izquierda;
    public KeyCode derecha;
    private Coroutine corutinaActual;

    // Update is called once per frame
    void Update()
    {
        float despHorizontal = 0;
        float despVertical = 0;
        if (Input.GetKey(arriba)) despVertical = 1;
        if (Input.GetKey(abajo)) despVertical = -1;
        if (Input.GetKey(izquierda)) despHorizontal = -1;
        if (Input.GetKey(derecha)) despHorizontal = 1;

        // calcular el vector desplazamiento
        Vector3 desplazamiento = new Vector3(despHorizontal, 0, despVertical);

        // mover el gameobject
        transform.Translate(desplazamiento * velocidad * Time.deltaTime);
    }

    public void RalentizarCubo()
    {
        if (corutinaActual != null)
        {
            StopCoroutine(corutinaActual);
        }
        corutinaActual = StartCoroutine(Ralentizar());
    }

    private IEnumerator Ralentizar()
    {
        velocidad /= 2;
        yield return new WaitForSeconds(5);

        velocidad = VELOCIDAD_POR_DEFECTO;
    }
}
