/*using APIEstherMM.Models;
using Blazored.LocalStorage;
    public class FakeLocalStorageService : ILocalStorageService
    {
        private readonly Dictionary<string, object> _storage = new();

        // Méthode pour ajouter un élément au stockage local
        public Task SetItemAsync<T>(string key, T value)
        {
            _storage[key] = value;
            return Task.CompletedTask;
        }

        // Méthode pour récupérer un élément du stockage local
        public Task<T> GetItemAsync<T>(string key)
        {
            _storage.TryGetValue(key, out var value);
            return Task.FromResult((T)value);
        }

        // Méthode pour supprimer un élément du stockage local
        public Task RemoveItemAsync(string key)
        {
            _storage.Remove(key);
            return Task.CompletedTask;
        }

        // Méthode pour vider le stockage local
        public Task ClearAsync()
        {
            _storage.Clear();
            return Task.CompletedTask;
        }

        // Méthode pour vérifier si un élément existe
        public bool ContainsKey(string key)
        {
            return _storage.ContainsKey(key);
        }
    }
*/