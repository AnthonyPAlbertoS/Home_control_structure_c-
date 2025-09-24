// See https://aka.ms/new-console-template for more information

//Programa de practica
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;

Console.WriteLine("Practica de Parcial");

string opcion = "si";
while (opcion == "si" || opcion == "Si")
{
    Console.WriteLine("Bienvenido al Programa de Calculo O Dias");
    opcion = "";
    Console.WriteLine($"Elija una Opcion: \n1. Calculadora. \n2. Ver Dias. \n3. Ciclos Repetitivos");
    int op = int.Parse(Console.ReadLine());
    if (op == 1)
    {
        Console.WriteLine("Elija una opcion: \n1. Suma \n2. Resta \n3. Multiplicación \n4. Comparar");
        var opcalculo = int.Parse(Console.ReadLine());
        switch (opcalculo)
        {
            case 1:
                Console.WriteLine("Suma de datos entero");
                Console.WriteLine("Ingrese el primer dato para la suma: ");
                int dato1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingese el segundo dato para la suma:");
                var dato2 = int.Parse(Console.ReadLine());

                var result = dato1 + dato2;
                Console.WriteLine($"El resultado de la suma {dato1} + {dato2} fue de: {result} ");
                break;
            case 2:
                Console.WriteLine("Resta");
                Console.WriteLine("Ingrese el primer digito para la resta: ");
                float dato1r = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingese el segundo digito para la resta:");
                float dato2r = float.Parse(Console.ReadLine());

                var resultr = dato1r + dato2r;
                Console.WriteLine($"El resultado de la resta {dato1r} - {dato2r} fue de: {resultr} ");
                break;
            case 3:
                Console.WriteLine("Multiplicacion de datos entero");
                Console.WriteLine("Ingrese el primer dato para la multiplicacion: ");
                int dato1m = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingese el segundo dato para la multiplicacion:");
                var dato2m = int.Parse(Console.ReadLine());

                var resultm = dato1m + dato2m;
                Console.WriteLine($"El resultado de la multiplicacion {dato1m} x {dato2m} fue de: {resultm} ");
                break;
            case 4:
                Console.WriteLine("Comparacion de datos entero");
                Console.WriteLine("Ingrese el primer dato para la comparacion: ");
                int dato1c = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingese el segundo dato para la comparacion:");
                var dato2c = int.Parse(Console.ReadLine());

                //Comparacion de numero mayor y menor
                if (dato1c > dato2c)
                {
                    Console.WriteLine($"El número mayor es: {dato1c}");
                    Console.WriteLine($"El número menor es: {dato2c}");
                }
                else if (dato2c > dato1c)
                {
                    Console.WriteLine($"El número mayor es: {dato2c}");
                    Console.WriteLine($"El número menor es: {dato1c}");
                }
                else
                {
                    Console.WriteLine($"Los números {dato1c} y {dato2c} son iguales");
                }

                //Comparacion si son diferentes
                Console.WriteLine("\nComparacion si son diferentes");
                if (dato2c != dato1c)
                {
                    Console.WriteLine("Son diferentes");
                }
                else
                {
                    Console.WriteLine("Son iguales");
                }
                break;
            default:
                Console.WriteLine("Solo hay 7 dias de la semana");
                break;
        }
    }
    else if (op == 2)
    {
        Console.WriteLine("Ingrese el dia A confirmar: ");
        int dia = 0;
        dia = int.Parse(Console.ReadLine());

        if (dia == 0 || dia < 0)
        {
            Console.WriteLine("Dia no Aceptado");
            return;
        }
        else if (dia > 7)
        {
            Console.WriteLine("Verifique el dia ingresado");
            return;
        }
        switch (dia)
        {
            case 1:
                Console.WriteLine("Lunes");
                break;
            case 2:
                Console.WriteLine("Martes");
                break;
            case 3:
                Console.WriteLine("Miercoles");
                break;
            case 4:
                Console.WriteLine("Jueves");
                break;
            case 5:
                Console.WriteLine("Viernes");
                break;
            case 6:
                Console.WriteLine("Sabado");
                break;
            case 7:
                Console.WriteLine("Domingo");
                break;
            default:
                Console.WriteLine("Solo hay 7 dias de la semana");
                break;
        }
    } 
    else if (op == 3)
    {
        //Uso de ciclos for 
        Console.WriteLine("Ingrese un numero para mostrar una lista: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("Listas de numeros acendentes: "); 
        for(int i = 0; i < num; i++)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("Lista de números descendentes: ");
        for (int l = num - 1; l >= 0; l--)
        {
            Console.WriteLine(l);
        }

        Console.WriteLine("Lista de números de dos en dos ascendentes:");
        for (int k = 0; k < num; k += 2)
        {
            Console.WriteLine(k);
        }

        Console.WriteLine("Lista de números de dos en dos descendentes:");
        for (int m = num - 1; m >= 0; m -= 2)
        {
            Console.WriteLine(m);
        }
    }
    else
    {
        Console.WriteLine("Opcion no valida");
    }

    Console.WriteLine("Desea Volver a usar: ");
    opcion = Console.ReadLine();
}


