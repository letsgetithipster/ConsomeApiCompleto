using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Consumindo_WebApiUsuarios
{
    public static class ConsomeApi
    {
        public static async Task<List<Usuario>> GetUsuarios(string uri)
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(uri))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var usuarioJsonString = await response.Content.ReadAsStringAsync();
                        return JsonConvert.DeserializeObject<Usuario[]>(usuarioJsonString).ToList();
                    }
                    else
                    {
                        throw new Exception($"Não foi possível obter o usuário: {response.StatusCode}");
                    }
                }
            }
        }

        public static async Task<Usuario> GetUsuariosById(string uri)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage responseMessage = await client.GetAsync(uri);

                if (responseMessage.IsSuccessStatusCode)
                {
                    var usuarioJsonString = await responseMessage.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<Usuario>(usuarioJsonString);
                }
                else
                {
                    throw new Exception($"Falha ao obter o usuário: {responseMessage.StatusCode}");
                }
            }
        }

        public static async void UpdateUsuario(string uri, Usuario usuario)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage responseMessage = await client.PutAsJsonAsync(uri, usuario);
                if (!responseMessage.IsSuccessStatusCode)
                {
                    throw new Exception("Falha ao atualizar o usuário : " + responseMessage.StatusCode);
                }
            }
        }

        public static async void AddUsuario(string uri, Usuario usuario)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var usuarioSerializado = JsonConvert.SerializeObject(usuario);
                    var content = new StringContent(usuarioSerializado, Encoding.UTF8, "application/json");

                    var result = await client.PostAsync(uri, content);
                }                
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static async void DeleteUsuario(string uri, int codigoUsuario)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(uri);
                HttpResponseMessage responseMessage = await client.DeleteAsync($"{uri}/{codigoUsuario}");

                if (!responseMessage.IsSuccessStatusCode)
                {
                    throw new Exception("Falha ao excluir o usuário  : " + responseMessage.StatusCode);
                }
            }
        }
    }
}
