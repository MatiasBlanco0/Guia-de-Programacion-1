using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej9 : MonoBehaviour
{
    //Realizá un programa que resuelva el siguiente problema:
    //Tres personas aportan diferente capital a una sociedad.Se desea saber qué porcentaje del
    //total aportó cada una (indicando nombre y porcentaje) y cuál es el monto del total aportado
    //por las tres.
    //Ingresar por Inspector el ingreso del capital aportado por cada una de las personas y luego
    //mostrar lo pedido en el siguiente formato:
    //Nombre: capital aportado: $ … , Porcentaje del capital: %.... , Monto total aportado: $ ….

    public string nombre1 = "Jorge";
    public string nombre2 = "Roberto";
    public string nombre3 = "Marcelo";
    public int aporte1 = 10;
    public int aporte2 = 10;
    public int aporte3 = 10;
    int porcentaje1;
    int porcentaje2;
    int porcentaje3;
    int montoT;

    // Start is called before the first frame update
    void Start()
    {
        montoT = aporte1 + aporte2 + aporte3;
        porcentaje1 = (aporte1 / montoT) * 100;
        porcentaje2 = (aporte2 / montoT) * 100;
        porcentaje3 = (aporte3 / montoT) * 100;
        Debug.Log(nombre1 + ": \nCapital aportado: $" + aporte1 + ", Porcentaje del capital: " + porcentaje1 + "%, Monto total aportado: $" + montoT);
        Debug.Log(nombre2 + ": \nCapital aportado: $" + aporte2 + ", Porcentaje del capital: " + porcentaje2 + "%, Monto total aportado: $" + montoT);
        Debug.Log(nombre3 + ": \nCapital aportado: $" + aporte3 + ", Porcentaje del capital: " + porcentaje3 + "%, Monto total aportado: $" + montoT);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
