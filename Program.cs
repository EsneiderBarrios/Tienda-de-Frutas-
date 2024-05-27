/* Esneider Calvo Barrios 
 * grupo 125 
 * Ingenieria de sistemas 
 * Codigo Fuente: https://github.com/EsneiderBarrios/Tienda-de-frutas.git
 * */
/*Crear un programa que valide el descuento en un determinado producto*/

using System;
using System.Xml.Serialization;

class Tiendadefrutas
{
    static void Main(string[] args)
    { // Saludo principal

        Console.WriteLine("¡Bienvenido a la tienda de frutas!");
        // variables para precios y cantidades de frutas
        double precioPera = 450;
        double precioManzana = 560;
        double precioCiruela = 30;
        double precioBanano = 80;
        double precioPiña = 1000;

        int cantidadPera = 0;
        int cantidadManzana = 0;  
        int cantidadCiruela = 0;
        int cantidadBanano = 0;
        int cantidadPiña = 0;

        double costoTotal = 0;
        double descuento = 0;
        double costoNeto = 0;


        // Validacion en la cantidad de peras y demas frutas
        bool entradaValida = false;
        while (!entradaValida)
        {
            try
            {
                Console.Write("Ingrese la cantidad de peras: ");
                cantidadPera = int.Parse(Console.ReadLine());
                entradaValida = true;
            }
            // Verificar que sea un numero lo que ingresa 
            catch (FormatException)
            {
                Console.WriteLine("Error. Ingrese un número.");
            }
        }

        entradaValida = false;

        while (!entradaValida)
        {
            try
            {
                Console.Write("Ingrese la cantidad de manzanas: ");
                cantidadManzana = int.Parse(Console.ReadLine());
                entradaValida = true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Error. Ingrese un número.");
            }
        }

        entradaValida = false;

        while (!entradaValida)
        {
            try
            {
                Console.Write("Ingrese la cantidad de ciruelas: ");
                cantidadCiruela = int.Parse(Console.ReadLine());
                entradaValida = true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Error. Ingrese un número.");
            }
        }

        entradaValida = false;

        while (!entradaValida)
        {
            try
            {
                Console.Write("Ingrese la cantidad de banano: ");
                cantidadBanano = int.Parse(Console.ReadLine());
                entradaValida = true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Error. Ingrese un número.");
            }
        }

        entradaValida = false;

        while (!entradaValida)
        {
            try
            {
                Console.Write("Ingrese la cantidad de piña: ");
                cantidadPiña = int.Parse(Console.ReadLine());
                entradaValida = true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Error. Ingrese un número.");
            }
        }

        // Calcular el costo total sin descuento
        costoTotal = (cantidadPera * precioPera) + (cantidadManzana * precioManzana) +
    (cantidadCiruela * precioCiruela) + (cantidadBanano * precioBanano) +
    (cantidadPiña * precioPiña);

        // Verificar si el costo total supera los $20.000
        if (costoTotal > 20000)
        {
            // Aplicar un descuento del 10%
            descuento = costoTotal * 0.1;
            costoNeto = costoTotal - descuento;

            Console.WriteLine("¡Felicidades! Obtiene un 10% de descuento por su compra.");
        }
        else
        {
            costoNeto = costoTotal;
        }

        // Informacion dada al cliente 
        Console.WriteLine("Su costo total antes del descuento: $" + costoTotal);
        Console.WriteLine("Monto del descuento: $" + descuento);
        Console.WriteLine("Su costo neto: $" + costoNeto);

        



    }
}