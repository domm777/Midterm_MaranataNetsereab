using MidtermAPI_MaranataNetsereab.Model;

namespace MidtermAPI_MaranataNetsereab.Repository {
    public interface IMNProductRepository {
        Task<IEnumerable<MNProduct>> GetAllProducts();
        Task AddProduct(MNProduct product);
    }
}
