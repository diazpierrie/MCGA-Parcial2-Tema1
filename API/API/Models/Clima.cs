using System;

namespace API.Models
{
    public class Clima
    {
        private readonly Random _rng = new Random();
        public Clima(DateTime fecha, int temperatura, int humedad, string resumen)
        {
            Fecha = fecha;
            Temperatura = temperatura;
            Humedad = humedad;
            Resumen = resumen;
            if (resumen == "Lluvioso")
            {
                Precipitaciones = _rng.NextDouble() * 10;
            }
        }

        public DateTime Fecha { get; set; }

        public int Temperatura { get; set; }

        public int Humedad { get; set; }
        public double Precipitaciones { get; set; }

        public string Resumen { get; set; }
    }
}
