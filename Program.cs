//--------------------------------------------------------------------      Encabezado del programa
Console.WriteLine("EJERCICIO_2");                                           //Numero de la practica
Console.WriteLine("CÁLCULO DEL PROMEDIO DE TRES CALIFICACIONES");           //Nombre del ejercicio
Console.WriteLine();                                                        //Instruccion para dejar un espacio en blanco en la consola
//--------------------------------------------------------------------      Entradas 
Console.Write("Ingrese la primera calificación: ");
double calificacion1 = Convert.ToDouble(Console.ReadLine());                //console.ReadLine sirve para leer lo que solicita la consola

Console.Write("Ingrese la segunda calificación: ");
double calificacion2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la tercera calificación: ");
double calificacion3 = Convert.ToDouble(Console.ReadLine());
//--------------------------------------------------------------------      Operaciones
double promedio = (calificacion1 + calificacion2 + calificacion3) / 3.0;    //variable donde guardamos una operación
//--------------------------------------------------------------------      Salidas 
Console.WriteLine();
Console.WriteLine($"El promedio de las tres calificaciones es: {promedio:F2}"); // "$" se usa para unir dos variables, en este caso una cadena de texto y un double

Console.WriteLine();
    if ( promedio>=70)
{
    Console.WriteLine("alumno aprobado");
}
else
{
    Console.WriteLine("alumno reprobado");
}