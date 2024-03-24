using UnityEngine;

public class Transformaciones : MonoBehaviour
{

    

    // Start is called before the first frame update
    void Start()
    {
        /*
        transform.rotation = Quaternion.Euler(0, 45, 0);
        transform.rotation *= Quaternion.Euler(0, 0, 15);
        transform.rotation = Quaternion.identity;
        */
        transform.localScale = new Vector3(2, 2, 2);
        transform.localScale += new Vector3(1, 1, 1);
        //transform.localScale *= 2;
        //transform.localScale += new Vector3(0, 0.5f, 0);
        //transform.localScale = Vector3.one;

    }

    void Update()
    {

    }


}
