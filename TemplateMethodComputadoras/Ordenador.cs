using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodComputadoras
{
   abstract class Ordenador
{
    public void Ensamblar()
    {
            Console.Write("Instalando tarjeta madre...");
            Thread.Sleep(2000);
            InstalarTarjetaMadre();

            Console.Write("Instalando procesador...");
            Thread.Sleep(2000);
            InstalarProcesador();

            Console.Write("Instalando memoria RAM...");
            Thread.Sleep(2000);
            InstalarMemoriaRAM();

            Console.Write("Instalando componentes adicionales...");
            Thread.Sleep(2000);
            InstalarComponentesAdicionales();
        }
    public abstract void InstalarTarjetaMadre();
    public abstract void InstalarProcesador();
    public abstract void InstalarMemoriaRAM();
    public abstract void InstalarComponentesAdicionales();
}

class OrdenadorGaming : Ordenador
{
    public override void InstalarTarjetaMadre()
    {
        Console.WriteLine("Tarjeta madre para juegos de alto rendimiento instalada");
    }
    public override void InstalarProcesador()
    {
        Console.WriteLine("Procesador de alta velocidad instalado");
    }
    public override void InstalarMemoriaRAM()
    {
        Console.WriteLine("Memoria RAM DDR4 instalada");
    }
    public override void InstalarComponentesAdicionales()
    {
        Console.WriteLine("Tarjeta gráfica de alto rendimiento instalada");
    }
}

class OrdenadorOficina : Ordenador
{
    public override void InstalarTarjetaMadre()
    {
        Console.WriteLine("Tarjeta madre económica instalada");
    }
    public override void InstalarProcesador()
    {
        Console.WriteLine("Procesador de velocidad media instalado");
    }
    public override void InstalarMemoriaRAM()
    {
    Console.WriteLine("Memoria RAM DDR3 instalada");
    }
    public override void InstalarComponentesAdicionales()
    {
        Console.WriteLine("No se instalaron componentes adicionales");
    }
}

}
