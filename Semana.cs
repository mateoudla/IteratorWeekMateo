using System;
namespace IteratorWeekMateo
{
    class Semana
    {
        //Lista privada de string que contiene los dias de la semana.
        public string[] diasSemana = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };

        //Variable privada de tipo entero que lleva el control del día actual.
        private int indiceActual = -1;

        //Método público que devuelve una nueva instancia de la clase IteradorDias.
        public IEnumerator ObtenerIterador()
        {
            return new IteradorDias(this);
        }
    }
}

