using UnityEngine;

public enum TipoArma
{
    Espada,
    Arco,
    Lanza
}

public struct DatosArma
{
    public string nombre;
    public int danyo;
    public TipoArma tipo;

    public DatosArma(string nombre, int danyo, TipoArma tipo)
    {
        this.nombre = nombre;
        this.danyo = danyo;
        this.tipo = tipo;
    }

    public override string ToString()
    {
        return $"Nombre del arma: {nombre}, Daño: {danyo}, Tipo: {tipo}";
    }
}

public class Armas : MonoBehaviour
{
    DatosArma arma1 = new DatosArma("Cimitarra de la ira", 28, TipoArma.Espada);
    DatosArma arma2 = new DatosArma("Arco de la guardia", 50, TipoArma.Arco);
    DatosArma arma3 = new DatosArma("Tridente de escamas", 22, TipoArma.Lanza);
    void Start()
    {
        Debug.Log(arma1);
        Debug.Log(arma2);
        Debug.Log(arma3);
    }

}
