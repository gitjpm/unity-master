using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuntuacionCubo : MonoBehaviour
{
    public Text textoPuntuacion;
    public int puntos;

    // Start is called before the first frame update
    void Start()
    {
        ActualizarPuntuacion();
        textoPuntuacion.text = $"{gameObject.name}: {puntos}";
    }

    public void AumentarPuntuacion(int n)
    {
        puntos += n;
        ActualizarPuntuacion();
        Moneda.ComprobarPuntuacionMaxima(puntos);
    }

    private void ActualizarPuntuacion()
    {
        textoPuntuacion.text = $"{gameObject.name}: {puntos}";
    }
}
