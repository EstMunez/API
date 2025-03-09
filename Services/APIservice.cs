using APIEstherMM.Models;
using System.Net.Http.Json;

namespace APIEstherMM.Services;

public class Apiservice
{
    private readonly HttpClient _http;
    public Apiservice(HttpClient http)
    {
        _http = http;
    }
    public async Task<List<DataItem>?> GetItemsAsync()
    {
        return await _http.GetFromJsonAsync<List<DataItem>>("https://api.example.com/data");
    }
    
}