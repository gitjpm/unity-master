using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfazUsuario : MonoBehaviour
{
    [SerializeField] private Text cantidadRespawns;
    private void OnEnable()
    {
        EventosSeguimientoEvasionRespawn.ActualizarCantidadRespawns += ActualizarRespawns;
    }

    private void OnDisable()
    {
        EventosSeguimientoEvasionRespawn.ActualizarCantidadRespawns -= ActualizarRespawns;
    }

    private void ActualizarRespawns(int cantidadRespawns)
    {
        this.cantidadRespawns.text = $"Respawns: {cantidadRespawns}";
    }
}
