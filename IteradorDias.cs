using System;

namespace IteratorWeekMateo
{
    class IteradorDias : IEnumerator
    {
        //Variable privada de tipo Semana
        private Semana semana;
        private int indiceActual = -1;

        //Constructor que recibe una instancia de Semana
        public IteradorDias(Semana semana)
        {
            this.semana = semana;
        }

        //Método que reinicia el indiceActual a -1
        public void Reset()
        {
            indiceActual = -1;
        }

        //Método que mueve el indiceActual al siguiente día de la semana
        public bool MoveNext()
        {
            //Si el indiceActual es menor al tamaño de la lista de diasSemana-1
            if (indiceActual < semana.diasSemana.Length - 1)
            {
                indiceActual++;
                return true;
            }
            return false;
        }

        //Método que devuelve el día actual en la lista diasSemana
        public object Current
        {
            get { return semana.diasSemana[indiceActual]; }
        }
    }

}
