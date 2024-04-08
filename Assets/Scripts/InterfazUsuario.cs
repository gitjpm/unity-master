using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfazUsuario : MonoBehaviour
{
    [SerializeField] private Text cantidadRespawns;
    private void OnEnable()
    {
        EventosAlRespawn.ActualizarRespawns += UIActualizarRespawns;
    }

    private void OnDisable()
    {
        EventosAlRespawn.ActualizarRespawns -= UIActualizarRespawns;
    }

    private void UIActualizarRespawns(int cantidadRespawns)
    {
        this.cantidadRespawns.text = $"Respawns: {cantidadRespawns}";
    }
}
