namespace AerolineaSoft {
    class CalculadorAgencia : Calculador {
        private static CalculadorAgencia instancia;

        private readonly double costoUnitario = 150; 
        private readonly double descuento = 0.15;
        private readonly double tamañoLote = 500;
        private readonly int recompensaLote = 100;

        private CalculadorAgencia() { }
        
        public static CalculadorAgencia ObtenerInstancia() {
            if(instancia == null) {
                instancia = new CalculadorAgencia();
            }
            return instancia;
        }

        public Resultado Calcular(Datos datos) {
            var costo = datos.Kilometros * costoUnitario * (1-descuento);
            var puntos = recompensaLote * (int)(datos.Kilometros / tamañoLote);
            var resultado = new Resultado(costo, puntos);
            return resultado;
        }
    }
}
