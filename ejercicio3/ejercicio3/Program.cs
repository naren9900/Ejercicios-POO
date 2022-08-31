// See https://aka.ms/new-console-template for more information
using ejercicio3;
using ejercicio3.casas;
using ejercicio3.IServicios;

IServicio Servicio = new Agua();
Casa casaJuan = new Casa(Servicio);
Console.WriteLine(casaJuan.Datos());