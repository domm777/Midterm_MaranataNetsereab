using MidtermAPI_MaranataNetsereab.Model;

namespace MidtermAPI_MaranataNetsereab.Service {
    public class MNFakeProductHistoryService {
        public MNProduct AddProduct(MNProduct product) {
            product.Id = new Random().Next(1000, 9999);
            return product;
        }

        public List<MNProduct> GetByProductId(int vehicleId) {
            return new List<MNProduct>
            {
                new MNProduct
                {
                    Id = 1,
                    Name = "Laptop"
                },
                new MNProduct
                {
                    Id = 2,
                    Name = "Mouse" 
                },
                new MNProduct {
                    Id = 3,
                    Name = "Keyboard"
                }
            };
        }
    }
}
