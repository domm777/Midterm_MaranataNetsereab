using System.ComponentModel.DataAnnotations;

namespace MidtermAPI_MaranataNetsereab.Model {
    public class MNProduct {
        public int Id { get; set; }
        [Required]
        [StringLength(25)]
        public string Name { get; set; }
        public int Quantity { get; set; } = 0;

        public MNProduct() { }

        public MNProduct(int id, string name, int quantity) {
            Id = id; Name = name; Quantity = quantity;
        }
    }
}
