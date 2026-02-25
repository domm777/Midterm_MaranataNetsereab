using MidtermAPI_MaranataNetsereab.Model;

namespace MidtermAPI_MaranataNetsereab.Repository {
    public interface MNIProductService {
        List<MNProduct> GetByProductId();
        MNProduct AddProduct(MNProduct product);
    }
}
