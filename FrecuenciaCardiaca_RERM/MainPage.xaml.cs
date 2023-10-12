using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FrecuenciaCardiaca_RERM
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void btnCalcular(object sender, EventArgs e, int pulsacionesMin)
        {
            var PulsacionesMin = int.Parse(pulsacionesMin.text);
            var calcularFCN = PulsacionesMin * 4;
            PulsacionesFin.Text = PulsacionesFin.ToString();
            string resultado = "";
            
                if (PulsacionesMin < 60)
                {
                    resultado = "baja";
                }
                else if (PulsacionesMin > 60 && PulsacionesMin < 100)
                {
                    resultado = "bien";
                }
                else
                {
                    resultado = "alta";
                }
            
            DisplayAlert("Resultado", resultado, "OK");
        }
        private void CalcularFCN(int PulsacionesMin)
        {
            int calcularFCN = PulsacionesMin * 4;
        }
    }
    
}
