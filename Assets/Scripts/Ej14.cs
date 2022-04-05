using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej14 : MonoBehaviour
{
    //Construir un programa que simule el funcionamiento de una calculadora que puede  realizar las cuatro operaciones aritméticas básicas
    //(suma, resta, producto y división) con valores numéricos enteros.
    //Se debe especificar la operación que se desea realizar ingresando una letra por Inspector
    //(s para la suma, r para la resta, p para el producto y d para la división) y luego,
    //deberán ingresarse dos números enteros para así realizar la operación.Informar el resultado por pantalla.
    //Nota: Se recomienda el empleo de una sentencia switch. 

    public char tipoOperacion = 's';
    public int num1 = 0;
    public int num2 = 0;

    // Start is called before the first frame update
    void Start()
    {
        switch (tipoOperacion)
        {
            case 's':
                Debug.Log("La suma de " + num1 + " y " + num2 + " da " + (num1 + num2));
                break;
            case 'r':
                Debug.Log("La resta de " + num1 + " y " + num2 + " da " + (num1 - num2));
                break;
            case 'p':
                Debug.Log("El producto de " + num1 + " y " + num2 + " da " + (num1 * num2));
                break;
            case 'd':
                Debug.Log("La division de " + num1 + " y " + num2 + " da " + (num1 / num2));
                break;
            default:
                Debug.Log("No es una opcion");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
