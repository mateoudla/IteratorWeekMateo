using IteratorWeekMateo;

class Program
{
    static void Main(string[] args)
    {
        //Creamos una instancia de Semana
        Semana miSemana = new Semana();
        //Obtenemos el iterador de la instancia de Semana
        IEnumerator iteradorDias = miSemana.ObtenerIterador();
        //Ciclo que recorre los dias de la semana y los imprime
        while (iteradorDias.MoveNext())
        {
            Console.WriteLine(iteradorDias.Current);
        }
        Console.ReadLine();
    }
}


