using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
// ReSharper disable LocalizableElement
namespace UI
{
    public partial class Home : Form
    {
        private static HttpClient client = new HttpClient();
        private readonly BindingList<Clima> _climas = new BindingList<Clima>();
        private int _climasTotales;
        private int _soleadoTotales;
        private int _nubladoTotales;
        private int _lluviosoTotales;
        private int _totalTemperatura;
        private int _totalHumedad;
        private double _totalPrecipitaciones;
        private bool _consumirApi;
        public Home()
        {
            InitializeComponent();
            client.BaseAddress = new Uri("https://localhost:44354/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        private void btnIniciarCaptura_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private async void GetClimas()
        {
            var response = await client.GetAsync("Clima");
            var data = await response.Content.ReadAsAsync<IEnumerable<Clima>>();
            foreach (var clima in data)
            {
                _climas.Add(clima);
            }
            this.gridClima.DataSource = _climas;
            gridClima.Refresh();
        }

        private void btnFinalizarCaptura_Click(object sender, EventArgs e)
        {
            _consumirApi = false; //Detener consumo de API
            timer1.Enabled = false;
            _soleadoTotales = 0;
            _nubladoTotales = 0;
            _lluviosoTotales = 0;
            _totalTemperatura = 0;
            _totalHumedad = 0;
            _totalPrecipitaciones = 0;

            foreach (var clima in _climas)
            {
                switch (clima.Resumen)
                {
                    case "Soleado":
                        _soleadoTotales++;
                        break;
                    case "Nublado":
                        _nubladoTotales++;
                        break;
                    case "Lluvioso":
                        _lluviosoTotales++;
                        break;
                    default:
                        break;
                }

                _totalTemperatura += clima.Temperatura;
                _totalHumedad += clima.Humedad;
                if (clima.Resumen == "Lluvioso")
                {
                    _totalPrecipitaciones += clima.Precipitaciones;
                }
            }

            lblTotales.Text = $"Totales: {_climas.Count}";
            lblTotalSoleado.Text = $"Soleado: {_soleadoTotales}";
            lblTotalNublado.Text = $"Nublado: {_nubladoTotales}";
            lblTotalLluvioso.Text = $"Lluvioso: {_lluviosoTotales}";

            lblPromedioHumedad.Text = $"Promedio Humedad: {_totalHumedad / _climas.Count}%";
            lblPromedioTemperatura.Text = $"Promedio Temperatura: {_totalTemperatura / _climas.Count} C°";
            lblPromedioPrecipitaciones.Text = _lluviosoTotales != 0 ? $"Promedio Precipitaciones: {Math.Truncate((_totalPrecipitaciones / _lluviosoTotales) * 100) / 100} mm" : "No hubieron dias lluviosos";

            if (_soleadoTotales == _nubladoTotales && _nubladoTotales == _lluviosoTotales)
            {
                lblEstadoDeModa.Text = "Todos los estados estan igualmente de moda";
            }
            else if (_soleadoTotales > _nubladoTotales && _soleadoTotales >= _lluviosoTotales)
            {
                lblEstadoDeModa.Text = "El estado Soleado esta de moda";
            }
            else if (_nubladoTotales > _soleadoTotales && _nubladoTotales >= _lluviosoTotales)
            {
                lblEstadoDeModa.Text = "El estado Nublado esta de moda";
            }
            else if (_lluviosoTotales > _soleadoTotales && _lluviosoTotales >= _nubladoTotales)
            {
                lblEstadoDeModa.Text = "El estado Lluvioso esta de moda";
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetClimas();
        }
    }
}
