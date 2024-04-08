using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour
{
    private static int cantidadMonedas = 1;
    
    public float velocidadRotacion;
    public Transform cubo1;
    public Transform cubo2;
    public float distanciaParaRecoger = 1f;

    public int cantidadMaximaMonedas = 5;

    [Range(0,100)]
    public int probabilidadNuevaMoneda;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, velocidadRotacion * Time.deltaTime));
        if(Vector3.Distance(transform.position, cubo1.position) < distanciaParaRecoger)
        {
            Debug.Log($"El cubo: {cubo1.name} ha recogido la moneda");
            MoverMoneda();
        }

         if(Vector3.Distance(transform.position, cubo2.position) < distanciaParaRecoger)
        {
            Debug.Log($"El cubo: {cubo2.name} ha recogido la moneda");
            MoverMoneda();
        }
    }

    private void MoverMoneda()
    {
        Vector3 posicionAleatoria = new Vector3(Random.Range(-10, 11), 0, Random.Range(-10, 11));
        transform.position = posicionAleatoria;

        if(Random.Range(0, 100) < probabilidadNuevaMoneda && cantidadMonedas < cantidadMaximaMonedas){
            posicionAleatoria = new Vector3(Random.Range(-10, 11), 0, Random.Range(-10, 11));
            Quaternion rotacionInicial = Quaternion.Euler(90, 0, 0);
            Instantiate(gameObject, posicionAleatoria, rotacionInicial);
            cantidadMonedas++;
        }
    }
}
