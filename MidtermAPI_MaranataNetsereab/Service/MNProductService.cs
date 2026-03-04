using MidtermAPI_MaranataNetsereab.Model;
using MidtermAPI_MaranataNetsereab.Repository;

namespace MidtermAPI_MaranataNetsereab.Service {
    public class MNProductService : IMNProductService {
        private readonly IMNProductRepository _repository;
        public MNProductService(IMNProductRepository repository) {
            _repository = repository;
        }

        public async Task AddProductAsync(MNProduct product) => await _repository.AddProduct(product);

        public async Task<IEnumerable<MNProduct>> GetAllProductsAsync() => await _repository.GetAllProducts();
    }
}
