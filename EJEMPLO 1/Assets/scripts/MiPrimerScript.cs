using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiPrimerScript : MonoBehaviour
{
    //vARIABLES
    //EL TIPO DE DATO     NOMBRE
    int numeroDeSaltos = 0;

    public int primerLogrosSaltos = 5;
    public int segundoLogrosSaltos = 10;
    public int terceroLogrosSaltos = 15;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        numeroDeSaltos = numeroDeSaltos + 1;

       /* Debug.Log("Ha chocado con " + collision.gameObject.name);

        Debug.Log("Veces que ha colisionado: " + mivariable + "" + gameObject.name);*/


        if(numeroDeSaltos == primerLogrosSaltos || numeroDeSaltos ==  segundoLogrosSaltos || numeroDeSaltos == terceroLogrosSaltos)
        {
            Debug.Log(gameObject.name + "ha chocado " + numeroDeSaltos + " veces");
        }
    }
}
