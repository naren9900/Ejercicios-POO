// See https://aka.ms/new-console-template for more information
using Ejercicio1MVC.Control;
using Ejercicio1MVC.Model;
using Ejercicio1MVC.View.Boos;

BossController contollerBoss = new BossController(new CrearBoss());
contollerBoss.Crear("2", "Maria", "546545564", Company.Build("1", "cll 145  cra 7 N21", "Financiero", 20));