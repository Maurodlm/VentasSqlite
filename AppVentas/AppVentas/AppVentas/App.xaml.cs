using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppVentas.View;
using AppVentas.ViewModel;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace AppVentas
{
    public partial class App : Application
    {
        public App(string filename)
        {
            InitializeComponent();
            VentasViewModel.Inicializador(filename);
            MainPage = new VentasView();
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
