using MidtermAPI_MaranataNetsereab.Model;
using MidtermAPI_MaranataNetsereab.Repository;

namespace MidtermAPI_MaranataNetsereab.Service {
    public class MNProductRepository : IMNProductRepository {
        private readonly List<MNProduct> _products = new();

        public MNProductRepository() {
            // Requirement: Start with at least 3 products
            _products.Add(new MNProduct { Id = 1, Name = "Laptop", Quantity = 10 });
            _products.Add(new MNProduct { Id = 2, Name = "Mouse", Quantity = 50 });
            _products.Add(new MNProduct { Id = 3, Name = "Keyboard", Quantity = 20 });
        }

        public List<MNProduct> GetAllProducts() => _products;

        public void AddProduct(MNProduct product) {
            // Simple ID auto-increment simulation
            product.Id = _products.Max(p => p.Id) + 1;
            _products.Add(product);
        }

        Task<IEnumerable<MNProduct>> IMNProductRepository.GetAllProducts() {
            throw new NotImplementedException();
        }

        Task IMNProductRepository.AddProduct(MNProduct product) {
            throw new NotImplementedException();
        }
    }
}
