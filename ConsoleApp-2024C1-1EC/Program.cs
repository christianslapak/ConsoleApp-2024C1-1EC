// See https://aka.ms/new-console-template for more information
using ConsoleApp_2024C1_1EC;

Console.WriteLine("Hola Mundo");
//Console.ReadKey();

Persona p = new Persona();
p.DNI = 23456789;
p.Apellido = "Martinez";
p.Nombre = "Marcela";
Console.WriteLine(p.MostrarDatos());

