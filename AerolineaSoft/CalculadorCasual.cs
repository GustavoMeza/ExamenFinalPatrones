namespace AerolineaSoft {
    class CalculadorCasual : Calculador {
        private static CalculadorCasual instancia;

        private readonly double costoUnitario = 150; 

        private CalculadorCasual() { }
        
        public static CalculadorCasual ObtenerInstancia() {
            if(instancia == null) {
                instancia = new CalculadorCasual();
            }
            return instancia;
        }

        public Resultado Calcular(Datos datos) {
            var costo = datos.Kilometros * costoUnitario;
            var puntos = 0;
            var resultado = new Resultado(costo, puntos);
            return resultado;
        }
    }
}
