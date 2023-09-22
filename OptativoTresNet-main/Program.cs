

using Infraestructura.Conexiones;
using Servicios.ContactosService;

CiudadService ciudadService = new CiudadService("Server=localhost;Port=5432;User Id=postgres;Password=Century123456;Database=parcial;");


var ciudad = ciudadService.obtenerCiudad(2);
Console.WriteLine($"Descripcion: {ciudad.descripcion}, nombre corto: {ciudad.nombre_corto}");

ciudad.descripcion = "Mariano Roque Alonso";
ciudadService.modificarCiudad(ciudad);

Console.WriteLine("...");






















