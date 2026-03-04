using MidtermAPI_MaranataNetsereab.Model;

namespace MidtermAPI_MaranataNetsereab.Service {
    public interface IMNProductService {
        Task<IEnumerable<MNProduct>> GetAllProductsAsync();
        Task AddProductAsync(MNProduct product);
    }
}
