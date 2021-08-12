using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;

namespace DemoAsync2
{
    class Program
    {
        static readonly HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            // Console.WriteLine("Digite o seu CEP: ");
            // var cep = Console.ReadLine();
            // try
            // {
            //     string uri = $"https://viacep.com.br/ws/{cep}/json/";
            //     var resposta = await client.GetAsync(uri);
            //     Console.WriteLine(resposta.StatusCode);
            //     Console.WriteLine(resposta.IsSuccessStatusCode);
            //     Console.WriteLine(await resposta.Content.ReadAsStringAsync());
            // }
            // catch (Exception ex)
            // {
            //     Console.WriteLine(ex.Message);
            // }

            Console.WriteLine("Digite o seu CEP: ");
            var cep = Console.ReadLine();
            try 
            {
                string uri = $"https://viacep.com.br/ws/{cep}/json/";
                var resposta = await client.GetFromJsonAsync<ViaCep>(uri);
                Console.WriteLine(resposta.Localidade);
                Console.WriteLine(resposta.Bairro);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
