using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Lev.Portable;

namespace Lev.Droid
{
    [Activity(Label = "Lev.Droid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

		Button botonCalcula;
		EditText palabra1;
		EditText palabra2;
		TextView labelResultado;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

			botonCalcula = FindViewById<Button> (Resource.Id.botonCalcula);
			palabra1 = FindViewById<EditText> (Resource.Id.palabra1);
			palabra2 = FindViewById<EditText> (Resource.Id.palabra2);
			labelResultado = FindViewById<TextView> (Resource.Id.labelResultado);

			botonCalcula.Click += (sender,  e) => {
				string p1 = palabra1.Text;
				string p2 = palabra2.Text;

				int resultado = AlgoritmoPortable.Compute(p1,p2);

				labelResultado.Text = resultado.ToString();
			};

        }
    }
}

