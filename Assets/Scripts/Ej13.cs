using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej13 : MonoBehaviour
{
    //Un obrero necesita calcular su salario semanal, el cual se obtiene de la siguiente manera:  
    //• Si trabaja 40 horas o menos se le paga $16 por hora(crear una constante para almacenar el 16)
    //• Si trabaja más de 40 horas se le paga $16 por cada una de las primeras 40 horas y $20  por cada hora extra.
    //(crear una constante para almacenar el 20)
    //Ingresar por Inspector la cantidad de horas trabajadas en la semana, y mostrar por pantalla el salario correspondiente.

    const int salarioHMenos40 = 16;
    const int salarioHMas40 = 20;
    public int horas = 0;
    int salarioTotal = 0;
    // Start is called before the first frame update
    void Start()
    {
        if(horas > 40)
        {
            salarioTotal = (horas - 40) * 20 + 16 * (horas - (horas - 40));
        }
        else
        {
            salarioTotal = horas * 16;
        }
        Debug.Log("Su salario semanal es: " + salarioTotal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
