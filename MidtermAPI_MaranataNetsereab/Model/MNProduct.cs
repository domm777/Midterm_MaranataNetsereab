using System.ComponentModel.DataAnnotations;

namespace MidtermAPI_MaranataNetsereab.Model {
    //public class MNProduct {
    //    public int Id { get; set; }
    //    [Required]
    //    [StringLength(25)]
    //    public string Name { get; set; }
    //    public int Quantity { get; set; } = 0;

    //    public MNProduct() { }

    //    public MNProduct(int id, string name, int quantity) {
    //        Id = id; Name = name; Quantity = quantity;
    //    }
    //}
    
    // !!! ai
    public class MNProduct {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name cannot be empty")]
        [StringLength(25, MinimumLength = 1, ErrorMessage = "Name must be between 1 and 25 characters")]
        public string Name { get; set; } = string.Empty;

        [Range(0, int.MaxValue, ErrorMessage = "Quantity must be zero or greater")]
        public int Quantity { get; set; }
    }
}
