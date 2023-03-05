using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pracrica
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
  
    }

    // Clase abstracta para las prendas de vestir
    public abstract class PrendaVestir
    {
        public string TipoPrenda { get; set; }
        public string Diseno { get; set; }
        public List<string> TallasDisponibles { get; set; }

        public PrendaVestir(string tipoPrenda, string diseno, List<string> tallasDisponibles)
        {
            TipoPrenda = tipoPrenda;
            Diseno = diseno;
            TallasDisponibles = tallasDisponibles;
        }

        public abstract void MostrarDetalles();
    }

    // Clase concreta para las prendas de vestir de alta calidad
    public class PrendaAltaCalidad : PrendaVestir
    {
        public string Marca { get; set; }
        public double Precio { get; set; }

        public PrendaAltaCalidad(string tipoPrenda, string diseno, List<string> tallasDisponibles, string marca, double precio)
            : base(tipoPrenda, diseno, tallasDisponibles)
        {
            Marca = marca;
            Precio = precio;
        }

        public override void MostrarDetalles()
        {
            Console.WriteLine($"Tipo de prenda: {TipoPrenda}");
            Console.WriteLine($"Diseño: {Diseno}");
            Console.WriteLine($"Tallas disponibles: {string.Join(",", TallasDisponibles)}");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Precio: {Precio:C}");
        }
    }

   
    public class PrendaBajaCalidad : PrendaVestir
    {
        public string Material { get; set; }
        public double Precio { get; set; }

        public PrendaBajaCalidad(string tipoPrenda, string diseno, List<string> tallasDisponibles, string material, double precio)
            : base(tipoPrenda, diseno, tallasDisponibles)
        {
            Material = material;
            Precio = precio;
        }

        public override void MostrarDetalles()
        {
            Console.WriteLine($"Tipo de prenda: {TipoPrenda}");
            Console.WriteLine($"Diseño: {Diseno}");
            Console.WriteLine($"Tallas disponibles: {string.Join(",", TallasDisponibles)}");
            Console.WriteLine($"Material: {Material}");
            Console.WriteLine($"Precio: {Precio:C}");
        }
    }

   
    class Program
    {
        static void Main(string[] args)
        {
           
            var altaCalidad1 = new PrendaAltaCalidad("Camisa", "Rayas azules", new List<string> { "S", "M", "L" }, "Tommy Hilfiger", 50.00);
            var altaCalidad2 = new PrendaAltaCalidad("Pantalón", "Negro", new List<string> { "32", "34", "36" }, "Calvin Klein", 80.00);

            
            var bajaCalidad1 = new PrendaBajaCalidad("Cam
    



}
