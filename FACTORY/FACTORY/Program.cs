// See https://aka.ms/new-console-template for more information
using FACTORY.entities;
using FACTORY.fabricas;
IFactory factory1 = new Factory();
factory1.BuildProfesor(1, "20000");
var estudiante = (Estudiante) factory1.BuildEstudiante(1);

