using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboScript : MonoBehaviour
{
    void OnEnable()
    {
        EventosRaton.AlHacerClic += CambiarColor1;
        EventosRaton.AlLiberarClic += CambiarColor2;
    }

    void OnDisable()
    {
        EventosRaton.AlHacerClic -= CambiarColor1;
        EventosRaton.AlLiberarClic -= CambiarColor2;
    }

    void CambiarColor1()
    {
        GetComponent<Renderer>().material.color = Color.yellow;
    }
    void CambiarColor2()
    {
        GetComponent<Renderer>().material.color = Color.black;
    }
}