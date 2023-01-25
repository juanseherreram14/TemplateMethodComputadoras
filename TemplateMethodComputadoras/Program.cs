using TemplateMethodComputadoras;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Seleccione el tipo de ordenador que desea ensamblar:");
            Console.WriteLine("1. Computadora Gamer");
            Console.WriteLine("2. Computadora de Oficina");
            Console.WriteLine("3. Salir");

            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    OrdenadorGaming ordenadorGaming = new OrdenadorGaming();
                    ordenadorGaming.Ensamblar();
                    break;
                case 2:
                    OrdenadorOficina ordenadorOficina = new OrdenadorOficina();
                    ordenadorOficina.Ensamblar();
                    break;
                case 3:
                    return;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
    }
}
