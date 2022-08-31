using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ejercicio3.espacios;
using ejercicio3.IServicios;

namespace ejercicio3.casas
{
    internal class Casa
    {
        private Lugar Habitacion;
        private Lugar Cocina;
        private Lugar Baño;
        private Lugar Patio;
        private IServicio Servicio;

        public Casa(IServicio servicio)
        {
            Servicio = servicio;
            this.Habitacion = new Habitacion("15m");
            this.Cocina = new Cocina("15m");
            this.Baño = new Baño("6m");
            this.Patio = new Patio("6m");
        }
        public string Datos(){
            var MeHabitacion = "La habitacion tiene " + this.Habitacion.MostrarMetrosCuadrados();
            var MeCocina = "La cocina tiene " + this.Cocina.MostrarMetrosCuadrados();
            var MeBaño = "El baño tiene una " + this.Baño.MostrarMetrosCuadrados();
            return MeHabitacion + "\n" + MeCocina + "\n" + MeBaño;
        }
    }
} 
