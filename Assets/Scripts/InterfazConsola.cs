using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfazConsola : MonoBehaviour
{
    private void OnEnable()
    {
        EventosAlRespawn.ActualizarPosicionRespawns += ConsolaMostrarRespawn;
    }
    private void OnDisable()
    {
        EventosAlRespawn.ActualizarPosicionRespawns -= ConsolaMostrarRespawn;
    }
    private void ConsolaMostrarRespawn(Vector3 posicionRespawn)
    {
        Debug.Log($"Respawn en: {posicionRespawn}");
    }
}
