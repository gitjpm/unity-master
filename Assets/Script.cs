using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Titulo : MonoBehaviour
{

    public Text textoUI;
    public float velocidad = 40f;
    public GameObject cubo1;
    public GameObject cubo2;
    public GameObject cubo3;
    // Start is called before the first frame update
    void Start()
    {
        textoUI.text = "Transformaciones";
    }

    void Update()
    {
        cubo1.transform.Rotate(0, velocidad * Time.deltaTime, 0);
        cubo2.transform.Rotate(0, velocidad * Time.deltaTime, 0);
    }

    void FixedUpdate()
    {
        cubo3.transform.Rotate(0, velocidad * Time.deltaTime, 0);

    }

}
