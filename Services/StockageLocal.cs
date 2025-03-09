
using APIEstherMM.Models;
using Blazored.LocalStorage;

namespace APIEstherMM.Services;

public class StockageLocal
{
    private readonly ILocalStorageService _localStorage;

    public StockageLocal(ILocalStorageService localStorage)
    {
        _localStorage = localStorage;
    }

    public async Task<List<DataItem>> GetFavoritesAsync()
    {
        return await _localStorage.GetItemAsync<List<DataItem>>("favorites") ?? new List<DataItem>();
    }

    public async Task AddFavoriteAsync(DataItem item)
    {
        var favorites = await GetFavoritesAsync();
        if (!favorites.Any(f => f.Id == item.Id))
        {
            favorites.Add(item);
            await _localStorage.SetItemAsync("favorites", favorites);
        }
    }

    public async Task RemoveFavoriteAsync(int id)
    {
        var favorites = await GetFavoritesAsync();
        favorites.RemoveAll(f => f.Id == id);
        await _localStorage.SetItemAsync("favorites", favorites);
    }
}
