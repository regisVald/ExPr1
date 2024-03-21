using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamenPracticoDS39.Models
{
    public class Products
    {
        //- Attributes
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int QuantityPerUnit { get; set; }
        public double UnitPrice { get; set; }
        public int UnitInStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public int ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
        public int CategoryId { get; set; } 
        public int SupplierId { get; set; } 

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; } 

        [ForeignKey("SupplierId")]
        public virtual Supplier Supplier { get; set; } 



    }
}
