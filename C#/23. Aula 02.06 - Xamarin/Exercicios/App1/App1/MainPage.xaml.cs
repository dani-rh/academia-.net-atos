using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        Entry nomeEntry, sobrenomeEntry;
        Label emailLabel;
        public MainPage()
        {
            nomeEntry = new Entry { Placeholder = "Digite seu nome:" };
            sobrenomeEntry = new Entry { Placeholder = "Digite seu sobrenome: " };
            Button botaoGerarEmail = new Button { Text = "Gerar email" };
            botaoGerarEmail.Clicked += BotaoGerarEmail_Clicked;
            emailLabel = new Label();

            this.Content = new StackLayout
            {
                Children =
            {
                nomeEntry,
                sobrenomeEntry,
                botaoGerarEmail,
                emailLabel
            }
            };
        }

        private void BotaoGerarEmail_Clicked(object sender, EventArgs e)
        {
            string nome = nomeEntry.Text.Trim();
            string sobrenome = sobrenomeEntry.Text.Trim();

            string email = $"{sobrenome}.{nome}@ufn.edu.br".ToLower();
            emailLabel.Text = $"Seu email é: {email}";
        }
    }
}
