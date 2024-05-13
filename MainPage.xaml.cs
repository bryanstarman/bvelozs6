using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace bvelozs6
{
    public partial class MainPage : ContentPage
    {
        private const string Url = "http://127.0.0.1:80/appMovil/post.php";
        private readonly HttpClient cliente = new HttpClient();
        private ObservableCollection<Estudiante> estud;

        public MainPage()
        {

            InitializeComponent();
            Obtener();
        }
        public async void Obtener()
        {
            var content=await cliente.GetStringAsync(Url);
            List<Estudiante> mostrarEst=JsonConvert.DeserializeObject<List<Estudiante>>(content);
            estud= new ObservableCollection<Estudiante>(mostrarEst);
            listaEstudiantes.ItemsSource = estud;
        }

       
    }
}