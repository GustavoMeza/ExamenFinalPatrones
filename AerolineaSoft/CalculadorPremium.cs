namespace AerolineaSoft {
    class CalculadorPremium : Calculador {
        private static CalculadorPremium instancia;

        private readonly double costoUnitario = 150; 
        private readonly double descuento = 0.10;
        private readonly double tamañoLote = 500;
        private readonly int recompensaLote = 50;

        private CalculadorPremium() { }
        
        public static CalculadorPremium ObtenerInstancia() {
            if(instancia == null) {
                instancia = new CalculadorPremium();
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
