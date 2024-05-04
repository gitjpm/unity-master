using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIClicks : MonoBehaviour
{

    public float velocidad = 5.0f;
    public float duracion = 1f;
    private float despHorizontal = 0;
    private float despVertical = 0;
    public Button botonArriba;
    public Button botonAbajo;
    public Button botonIzquierda;
    public Button botonDerecha;
    void Start()
    {
        botonArriba?.onClick.AddListener(Arriba);
        botonAbajo?.onClick.AddListener(Abajo);
        botonIzquierda?.onClick.AddListener(Izquierda);
        botonDerecha?.onClick.AddListener(Derecha);
    }

    private void Arriba()
    {
        despVertical = 1;
        Mover();
    }

    private void Abajo()
    {
        despVertical = -1;
        Mover();
    }

    private void Izquierda()
    {
        despHorizontal = -1;
        Mover();
    }

    private void Derecha()
    {
        despHorizontal = 1;
        Mover();
    }

    private void Mover()
    {
        // calcular el vector desplazamiento
        Vector3 desplazamiento = new Vector3(despHorizontal, 0, despVertical);

        // mover el GameObject
        transform.Translate(desplazamiento * velocidad);

        // reiniciamos el desplazamiento
        despHorizontal = 0;
        despVertical = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
