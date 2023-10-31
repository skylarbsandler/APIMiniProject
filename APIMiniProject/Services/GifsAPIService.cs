using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using System.Text;
using APIMiniProject.Interfaces;
using APIMiniProject.Models;
using System.Text.Json;

namespace APIMiniProject.Services
{
    public class GifsAPIService : IGifsAPIService
    {
        private readonly HttpClient _client;

        public GifsAPIService()
        {
            _client = new HttpClient() { BaseAddress = new Uri("https://localhost:7094") };
        }

        public async Task<List<GifModel>> GetGifs()
        {
            var url = "/gifs";
            var result = new List<GifModel>();
            var response = await _client.GetAsync(url);

            if(response.IsSuccessStatusCode)
            {
                var stringResponse = await response.Content.ReadAsStringAsync();
                result = JsonSerializer.Deserialize<List<GifModel>>(stringResponse,
                   new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
            }
            else
            {
                throw new HttpRequestException(response.ReasonPhrase);
            }
            return result;
        }
    }
}
