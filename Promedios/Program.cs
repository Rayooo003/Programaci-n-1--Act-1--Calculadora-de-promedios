
//Es una colección de clases e interfaces fundamentales de C#
using System;

//Clase para crear objetos y definir el tipo de datos y las operaciones disponibles.
class Program
{
    //Static void es un método que no devuelve ningún valor, Main es el punto de entradada del programa
    static void Main()
    {
        //Se imprime en la consola una orden al usuario de ingresar 
        Console.Write("Ingresa la cantidad de calificaciones: ");

        //Se lee la línea que el usuario ingresa en la consola, convierte esa línea de texto (que es una cadena de caracteres) en un número entero (int)
        //y lo almacena en la variable cantidad
        int cantidad = Convert.ToInt32(Console.ReadLine());

        //Aquí se declaran tres variables de tipo double, que pueden almacenar números con decimales. suma y calificacion se inicializan en 0
        //La variable promedio se declarará más adelante para almacenar el promedio de las calificaciones
        double suma = 0, calificacion = 0, promedio;

        //Es un bucle for que comienza con i igual a 1 y continúa ejecutándose mientras i sea menor o igual a cantidad
        //En cada iteración del bucle, i se incrementa en 1, este bucle permite repetir un bloque de código varias veces
        for (int i = 1; i <= cantidad; i++)
        {
            //Se imprime en consola una orden al usuari ingresar una a una cada calificación
            Console.Write($"Ingresa la calificación número {i}: ");

            //Se lee la calificación del usuario y se convierte de texto a double para poder realizar operaciones matemáticas con ella.
            calificacion = Convert.ToDouble(Console.ReadLine());

            //Se suma la calificación ingresada a la variable suma, el operador += es una forma abreviada de escribir suma = suma + calificacion
            suma += calificacion;
        }

        //Se calcula el promedio dividiendo la suma total de las calificaciones por la cantidad de calificaciones ingresadas
        promedio = suma / cantidad;

        //Se imprime en consola el promedio de todas las calificaciones ingresadas
        Console.WriteLine($"El promedio de las calificaciones es: {promedio}");
    }
}