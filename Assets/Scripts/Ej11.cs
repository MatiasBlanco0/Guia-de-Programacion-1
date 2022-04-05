using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej11 : MonoBehaviour
{
    //Realizá un programa que resuelva el siguiente problema:  
    //Deberá ingresarse por Inspector una fecha de compra(String en el siguiente formato:  YYYYMMDD),
    //un nombre de comprador, un nombre de producto y una cantidad y precio del producto comprado.
    //Mostrá a modo de ticket, la información ingresada y el monto a pagar.Modelo de Ticket:  
    //Fecha de Compra: YYYYMMDD
    //Nombre del Comprador: xxxxx xxxxx
    //Producto solicitado: xxxxx
    //Cantidad solicitada: xx
    //Precio Unitario: $xxx
    //Total a Pagar: $xxxxx

    public string fechaCompra = "20220101";
    public string nombreComprador = "Manuel";
    public string nombreProducto = "microondas";
    public int cantidadProducto = 1;
    public int precioProducto = 2000;
    int total = 0;

    // Start is called before the first frame update
    void Start()
    {
        total = cantidadProducto * precioProducto;
        Debug.Log("Fecha de Compra: " + fechaCompra);
        Debug.Log("\nNombre del Comprador: " + nombreComprador);
        Debug.Log("\nProducto solicitado: " + nombreProducto);
        Debug.Log("\nCantidad solicitada: " + cantidadProducto);
        Debug.Log("\nPrecio Unitario: $" + precioProducto);
        Debug.Log("\nTotal a Pagar: $" + total);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
