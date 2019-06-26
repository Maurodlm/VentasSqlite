using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppVentas.ViewModel;
using AppVentas.Model;

namespace AppVentas.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VentasView : ContentPage
    {
        public VentasView()
        {
            InitializeComponent();
        }

        private void BInsert_Clicked(object sender, EventArgs e)
        {
            StatusMessage.Text = string.Empty;
            VentasViewModel.Instance.AddNew(dProducto.Text, Int32.Parse(dCantidad.Text), DatePicker.Date);
            StatusMessage.Text = VentasViewModel.Instance.EstadoMensaje;
        }

        private void BListar_Clicked(object sender, EventArgs e)
        {
            var allVentas = VentasViewModel.Instance.GetAll();
            listaventas.ItemsSource = allVentas;
            StatusMessage.Text = VentasViewModel.Instance.EstadoMensaje;

        }
    }
}