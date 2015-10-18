using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Lev.Forms
{
    public class App : Application
    {
        Button botonCalcula;
        Entry palabra1;
        Entry palabra2;
        Label labelResultado;

        public App()
        {
            StackLayout layout= new StackLayout();

            palabra1 = new Entry();
            palabra1.Placeholder = "Primer palabra";
            layout.Children.Add(palabra1);

            palabra2 = new Entry();
            palabra2.Placeholder = "Segunda palabra";
            layout.Children.Add(palabra2);

            botonCalcula = new Button();
            botonCalcula.Text = "Calcula";
            botonCalcula.Clicked += BotonCalcula_Click;
            layout.Children.Add(botonCalcula);

            labelResultado = new Label();
            labelResultado.Text = "0";
            layout.Children.Add(labelResultado);

            MainPage = layout;

        }

        private void BotonCalcula_Click(object sender, EventArgs e)
        {
            string p1 = palabra1.Text;
            string p2 = palabra2.Text;

            int resultado = AlgoritmoPortable.Compute(p1, p2);

            labelResultado.Text = resultado.ToString();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
