/*using APIEstherMM.Models;
using APIEstherMM.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace APIEstherMM.Tests
{
    public class StockageLocalTests
    {
        // Test d'ajout de favoris
        [Fact]
        public async Task AddFavoriteAsync_ShouldAddItemToFavorites()
        {
            // Arrange : Créer une instance de FakeLocalStorageService
            var fakeLocalStorageService = new FakeLocalStorageService();
            var stockageLocal = new StockageLocal(fakeLocalStorageService);

            // Créer un DataItem
            var item = new DataItem { Id = 1, Name = "Item 1", Description = "Description de l'article" };

            // Act : Ajouter un favori
            await stockageLocal.AddFavoriteAsync(item);

            // Assert : Vérifier que l'élément est bien ajouté aux favoris
            var favorites = await stockageLocal.GetFavoritesAsync();
            Assert.Contains(favorites, f => f.Id == item.Id && f.Name == item.Name);
        }

        // Test de suppression d'un favori
        [Fact]
        public async Task RemoveFavoriteAsync_ShouldRemoveItemFromFavorites()
        {
            // Arrange
            var fakeLocalStorageService = new FakeLocalStorageService();
            var stockageLocal = new StockageLocal(fakeLocalStorageService);

            var item = new DataItem { Id = 1, Name = "Item 1", Description = "Description de l'article" };
            await stockageLocal.AddFavoriteAsync(item);

            // Act : Supprimer un favori
            await stockageLocal.RemoveFavoriteAsync(item.Id);

            // Assert : Vérifier que l'élément a été supprimé
            var favorites = await stockageLocal.GetFavoritesAsync();
            Assert.DoesNotContain(favorites, f => f.Id == item.Id);
        }

        // Test de la persistance des favoris après un rechargement
        [Fact]
        public async Task GetFavoritesAsync_ShouldPersistFavorites()
        {
            // Arrange
            var fakeLocalStorageService = new FakeLocalStorageService();
            var stockageLocal = new StockageLocal(fakeLocalStorageService);

            var item = new DataItem { Id = 1, Name = "Item 1", Description = "Description de l'article" };
            await stockageLocal.AddFavoriteAsync(item);

            // Simuler un rechargement de page
            var newStockageLocal = new StockageLocal(fakeLocalStorageService);

            // Act : Vérifier que les favoris persistent
            var favorites = await newStockageLocal.GetFavoritesAsync();
            Assert.Contains(favorites, f => f.Id == item.Id);
        }
    }
}*/
