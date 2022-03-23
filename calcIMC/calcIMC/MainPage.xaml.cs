using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace calcIMC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            double altura = Convert.ToDouble(altura_txt.Text);
            double peso = Convert.ToDouble(peso_txt.Text);

            double imc = (peso / (altura * altura)) ;

            if (imc < 18.5)
            {
                await DisplayAlert("RESULTADO: ", "Seu IMC é: " + imc.ToString("0.00") + " Sua classificação é MAGREZA", "OK");
                zerar();
            }
            if (imc > 18.5 && imc < 24.9)
            {
                await DisplayAlert("RESULTADO: ", "Seu IMC é: " + imc.ToString("0.00") + " Sua classificação é NORMAL", "OK");
                zerar();
            }
            if (imc > 25.0 && imc < 29.9)
            {
                await DisplayAlert("RESULTADO: ", "Seu IMC é: " + imc.ToString("0.00") + " Sua classificação é SOBREPESO", "OK");
                zerar();
            }
            if (imc > 30.0 && imc < 39.9)
            {
                await DisplayAlert("RESULTADO: ", "Seu IMC é: " + imc.ToString("0.00") + " Sua classificação é OBESIDADE", "OK");
                zerar();
            }
            if (imc > 40.0)
            {
                await DisplayAlert("RESULTADO: ", "Seu IMC é: " + imc.ToString("0.00") + " Sua classificação é OBESIDADE GRAVE", "OK");
                zerar();
            }

            void zerar()
            {
                peso_txt.Text = "";
                altura_txt.Text = "";
            }
        }
    }
}
