using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ExamenPracticoDS39.Models
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }
       public string CategoryName { get; set; }
       public string CategoryDescription { get; set; }
       public string PictureUr { get; set; }
    }
}
    