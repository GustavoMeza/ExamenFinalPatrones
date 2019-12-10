using System.Collections.Generic;

namespace AerolineaSoft {
    class ListaCalculadores {
        private readonly Dictionary<string, Calculador> calculadores = new Dictionary<string, Calculador>();

        public void Agregar(string identificador, Calculador calculador) {
            calculadores.Add(identificador, calculador);
        }

        public Dictionary<string, Resultado> Calcular(Datos datos) {
            var resultados = new Dictionary<string, Resultado>(); 
            foreach(var kv in calculadores) {
                string identificador = kv.Key;
                Calculador calculador = kv.Value;
                var resultado = calculador.Calcular(datos);
                resultados.Add(identificador, resultado);
            }
            return resultados;
        }
    }
}
