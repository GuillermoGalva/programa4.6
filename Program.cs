using System;

class Program
{
    static void Main()
    {
        int contador = 0;
        int contadorMayoresOIgualesA7 = 0;
        int contadorMenoresA7 = 0;

        while (contador < 10)
        {
            Console.Write($"Ingresa la nota del alumno {contador + 1}: ");
            double nota = double.Parse(Console.ReadLine());

            if (nota >= 7)
            {
                contadorMayoresOIgualesA7++;
            }
            else
            {
                contadorMenoresA7++;
            }

            contador++;
        }

        Console.WriteLine($"Cantidad de alumnos con notas mayores o iguales a 7: {contadorMayoresOIgualesA7}");
        Console.WriteLine($"Cantidad de alumnos con notas menores a 7: {contadorMenoresA7}");
    }
}
