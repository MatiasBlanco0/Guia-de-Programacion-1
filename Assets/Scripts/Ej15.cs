using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej15 : MonoBehaviour
{
    //Existen dos reglas que identifican dos conjuntos de valores:
    //- El número es de un solo dígito.
    //- El número es impar.   
    //A partir de estas reglas, creá un algoritmo que asigne a las variables booleanas estaEnA,
    //estaEnB, estaEnAmbos y noEstaEnNinguno el valor verdadero o falso, según corresponda,
    //para indicar si el valor ingresado pertenece al primer conjunto, al segundo, a ambos o a
    //ninguno, respectivamente.Definí un lote de prueba de varios números y probá el algoritmo,
    //escribiendo los resultados.

    public int num = 0;
    bool estaEnA = false;
    bool estaEnB = false;
    bool estaEnAmbos = false;
    bool estaEnNinguno = false;
    
    // Start is called before the first frame update
    void Start()
    {
        if(num < 10 && num > -10)
        {
            estaEnA = true;
        }
        if(num % 2 != 0)
        {
            estaEnB = true;
        }
        if(estaEnB && estaEnA)
        {
            estaEnAmbos = true;
        }
        if (!estaEnB && !estaEnA)
        {
            estaEnNinguno = true;
        }

        if (estaEnAmbos)
        {
            Debug.Log("El numero " + num + " esta en los dos conjuntos");
        }
        else if (estaEnA)
        {
            Debug.Log("El numero " + num + " esta en el conjunto A");
        }
        else if (estaEnB)
        {
            Debug.Log("El numero " + num + " esta en el conjunto B");
        }
        else
        {
            Debug.Log("El numero " + num + " no esta en ningun conjunto");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
