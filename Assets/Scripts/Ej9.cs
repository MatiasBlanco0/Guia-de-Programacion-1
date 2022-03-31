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

    public string nombre1;
    public string nombre2;
    public string nombre3;
    public int aporte1;
    public int aporte2;
    public int aporte3;
    float porcentaje1 = 0;
    float porcentaje2 = 0;
    float porcentaje3 = 0;
    int montoT = 0;

    // Start is called before the first frame update
    void Start()
    {
        montoT = aporte1 + aporte2 + aporte3;
        porcentaje1 = montoT / 100 * aporte1;
        porcentaje2 = montoT / 100 * aporte2;
        porcentaje3 = montoT / 100 * aporte3;
        Debug.Log(nombre1 + ": \nCapital aportado: $" + aporte1 + ", \nPorcentaje del capital: " + porcentaje1 + "%, Monto total aportado: $" + montoT);
        Debug.Log(nombre2 + ": \nCapital aportado: $" + aporte2 + ", \nPorcentaje del capital: " + porcentaje2 + "%, Monto total aportado: $" + montoT);
        Debug.Log(nombre3 + ": \nCapital aportado: $" + aporte3 + ", \nPorcentaje del capital: " + porcentaje3 + "%, Monto total aportado: $" + montoT);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
