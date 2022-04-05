using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej12 : MonoBehaviour
{
    //En un casino de juegos se desea mostrar los mensajes respectivos por el puntaje 
    //obtenido en el lanzamiento de tres dados de un cliente, de acuerdo a los siguientes  resultados:  
    //• Si los tres dados son seis, mostrar el mensaje “Excelente” 
    //• Si dos dados son seis, mostrar el mensaje “Muy bien”  
    //• Si un dado es seis, mostrar el mensaje “Regular”  
    //• Si ningún dado se obtiene seis, mostrar el mensaje “Insuficiente” 

    public int num1 = 0;
    public int num2 = 0;
    public int num3 = 0;
    bool num1Es6;
    bool num2Es6;
    bool num3Es6;

    // Start is called before the first frame update
    void Start()
    {
        if(num1 == 6)
        {
            num1Es6 = true; 
        }
        if(num2 == 6)
        {
            num2Es6 = true;
        }
        if(num3 == 6)
        {
            num3Es6 = true;
        }

        if (num1Es6 && num2Es6 && num3Es6)
        {
            Debug.Log("Excelente");
        }
        else if (num1Es6 && num2Es6 || num2Es6 && num3Es6 || num3Es6 && num1Es6)
        {
            Debug.Log("Muy Bien");
        }
        else if(num1Es6 || num2Es6 || num3Es6)
        {
            Debug.Log("Regular");
        }
        else
        {
            Debug.Log("Insuficiente");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
