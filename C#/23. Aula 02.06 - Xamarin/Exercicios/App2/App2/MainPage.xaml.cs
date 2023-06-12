using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        Entry nomeEntry, idadeEntry, pesoEntry, alturaEntry;
        Label resultadoLabel;
        public MainPage()
        {
            nomeEntry = new Entry { Placeholder = "Nome" };
            idadeEntry = new Entry { Placeholder = "Idade" };
            pesoEntry = new Entry { Placeholder = "Peso em kg" };
            alturaEntry = new Entry { Placeholder = "Altura em metros" };

            Button calcularButton = new Button { Text = "Calcular IMC" };
            calcularButton.Clicked += CalcularButton_Clicked;

            resultadoLabel = new Label();

            this.Content = new StackLayout
            {
                Children =
            {
                nomeEntry,
                idadeEntry,
                pesoEntry,
                alturaEntry,
                calcularButton,
                resultadoLabel
            }
            };
        }

        private void CalcularButton_Clicked(object sender, EventArgs e)
        {
            double peso = Convert.ToDouble(pesoEntry.Text);
            double altura = Convert.ToDouble(alturaEntry.Text);
            double imc = peso / (altura * altura);
            resultadoLabel.Text = $"Olá {nomeEntry.Text}, seu IMC é: {imc}";
        }
    }
}
