namespace AerolineaSoft {
    class Resultado {
        public double Costo { get; set; }
        public int PuntosPremia {get; set; }

        public Resultado(double costo, int puntosPremia) {
            Costo = costo;
            PuntosPremia = puntosPremia;
        }
    }
}
