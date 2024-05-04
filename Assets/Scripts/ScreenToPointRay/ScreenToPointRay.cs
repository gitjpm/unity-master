using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenToPointRay : MonoBehaviour
{

    public bool multipleRayCast = true;

    void Update()
    {
        float longitudRayo = 10f;

        if (Input.GetMouseButton(0))
        {
            Ray rayo = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (multipleRayCast)
            {
                //lanzamos un raycast que detecte todos los colliders en la dirección del rayo
                RaycastHit[] impactos = Physics.RaycastAll(rayo, Mathf.Infinity);

                // ordenamos de menor a mayor distancia
                System.Array.Sort(impactos, (impacto1, impacto2) => impacto1.distance.CompareTo(impacto2.distance));
                foreach (RaycastHit impacto in impactos)
                {
                    GameObject obj = impacto.collider.gameObject;
                    Debug.Log($"El rayo impactó en: {obj.name}, distancia: {impacto.distance}");
                }
            }
            else
            {
                // raycast simple
                RaycastHit hitInfo;

                if (Physics.Raycast(rayo, out hitInfo))
                {
                    GameObject obj = hitInfo.collider.gameObject;
                    if (obj != null)
                    {
                        Debug.Log($"Has hecho click en: {obj.name}");
                        Debug.DrawRay(rayo.origin, rayo.direction * longitudRayo, Color.red);

                        Vector3 posicionRaton = Input.mousePosition;
                        posicionRaton.z = Camera.main.nearClipPlane;

                        Vector3 posicionCamaraSubida = Camera.main.transform.position + new Vector3(0, 0.1f, 0);
                        Vector3 direccion = (Camera.main.ScreenToWorldPoint(posicionRaton) - Camera.main.transform.position).normalized;
                        Debug.DrawRay(posicionCamaraSubida, direccion * longitudRayo, Color.green);
                    }
                }
            }
        }
    }
}
