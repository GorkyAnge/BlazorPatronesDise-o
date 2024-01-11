namespace EjemploTiendaMuebles.Service
{
    public class APIService : IAPIService
    {

        private readonly HttpClient _httpClient;
        private readonly string _baseUrl = "http://apiservicios.ecuasolmovsa.com:3009";


        public APIService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(_baseUrl);
        }


        public async Task GetImg(string TipoMueble)
        {
            string img;
        }
    }
}
