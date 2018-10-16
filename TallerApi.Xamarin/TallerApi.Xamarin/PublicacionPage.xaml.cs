using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerApi.Xamarin.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net.Http;
using Newtonsoft.Json;




namespace TallerApi.Xamarin
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PublicacionPage : ContentPage
	{
		public PublicacionPage ()
		{
			InitializeComponent ();
            CargarPublicacion();
        }

        private async void CargarPublicacion()
        {
            HttpClient publicacion = new HttpClient();

            //se especifica en sitio al cual se le realizara las peticiones
            publicacion.BaseAddress = new Uri("http://localhost");

            var request = publicacion.GetAsync("/api/Producto").Result;
            if (request.IsSuccessStatusCode)
            {
                var responseJSON = await request.Content.ReadAsStringAsync();
                var respuesta = JsonConvert.DeserializeObject<List<Publicacion>>(responseJSON);
                listPublicacion.ItemsSource = respuesta;
            }

            
        }

        private async void Producto_Selected(object sender, SelectedItemChangedEventArgs e)
        {
            var publicacion = e.SelectedItem as Publicacion;
            var mensaje = string.Format("Usuario: {0}  - MeGusta: {1} ", publicacion.Usuario, publicacion.MeGusta);
            await DisplayAlert("Producto seleccionado", mensaje, "OK");
        }
    }
}