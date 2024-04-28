using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventosRaton : MonoBehaviour
{
    
    public delegate void EventoRaton();
    public static event EventoRaton AlHacerClic;
    public static event EventoRaton AlLiberarClic;
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))    AlHacerClic?.Invoke();
        if(Input.GetMouseButtonUp(0))   AlLiberarClic?.Invoke();
    }
}
