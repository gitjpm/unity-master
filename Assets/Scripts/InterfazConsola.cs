using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfazConsola : MonoBehaviour
{
    private void OnEnable()
    {
        EventosSeguimientoEvasionRespawn.ActualizarPosicionRespawns += MostrarRespawn;
    }
    private void OnDisable()
    {
        EventosSeguimientoEvasionRespawn.ActualizarPosicionRespawns -= MostrarRespawn;
    }
    private void MostrarRespawn(Vector3 posicionRespawn)
    {
        Debug.Log($"Respawn en: {posicionRespawn}");
    }
}
