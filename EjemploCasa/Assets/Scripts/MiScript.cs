using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiScript : MonoBehaviour
{
    public string mensajeBienvenida;
    public string miNombre1;
    public string miNombre2;
    public int a;
    public int b;
    public bool estaArriba;

    // Start is called before the first frame update
    void Start()
    {
        int total;
            total = a + b;
        Debug.Log("Hola Mundo mi nombre es:" + mensajeBienvenida + miNombre1);
        Debug.Log("El nombre de mi amigo es:" + miNombre2);
        Debug.Log("Mi edad es:" + a);
        Debug.Log("La edad de mi amigo es:" + b);
        Debug.Log("Y la suma de nuestras edades es:" + total);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Onjump()
    {
    }
}
