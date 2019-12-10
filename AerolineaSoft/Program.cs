using System;
using System.Collections.Generic;

namespace AerolineaSoft
{
    class Program
    {

        private static string CASUAL = "Casual";
        private static string PREMIUM = "Premium";
        private static string AGENCIA = "Agencia";

        static void Main(string[] args)
        {
            var calculadores = new ListaCalculadores();
            calculadores.Agregar(CASUAL, CalculadorCasual.ObtenerInstancia());
            calculadores.Agregar(PREMIUM, CalculadorPremium.ObtenerInstancia());
            calculadores.Agregar(AGENCIA, CalculadorAgencia.ObtenerInstancia());
            
            var datos = Leer();

            var resultados = calculadores.Calcular(datos);
        
            Imprimir(datos, resultados);
        
        }

        static Datos Leer() { 
            double kilometros;
            string entrada;
            bool conversionExitosa;
            do {
                Console.WriteLine("Ingresa la cantidad de kilometros");
                entrada = Console.ReadLine();
                conversionExitosa = Double.TryParse(entrada, out kilometros);
                if(!conversionExitosa) {
                    Console.WriteLine("Error de formato, el kilometraje debe ser un número");
                } else if(kilometros < 0) {
                    Console.WriteLine("Error de valor, el kilometraje debe ser no-negativo");
                    conversionExitosa = false;
                }
            } while(!conversionExitosa);
            var datos = new Datos(kilometros);
            return datos;
        }

        static void Imprimir(Datos datos, Dictionary<string, Resultado> resultados) {
            Console.WriteLine("Kilometros: {0}", datos.Kilometros);
            Console.WriteLine("Usuario\tCosto\tPuntos");

            foreach(var kv in resultados) {
                var identificador = kv.Key;
                var resultado = kv.Value;
                var costo = resultado.Costo;
                var puntos = resultado.PuntosPremia;
                Console.WriteLine("{0}\t{1}\t{2}", identificador, costo, puntos);
            }
        }
    }
}
