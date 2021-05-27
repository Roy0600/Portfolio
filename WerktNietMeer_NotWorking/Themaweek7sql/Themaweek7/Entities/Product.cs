using System.ComponentModel.DataAnnotations;

namespace Themaweek7.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public string Naam { get; set; }
        public string CatagoryName { get; set; }
        public float Prijs { get; set; }
        public string Eenheid { get; set; }
        public string Afbeelding { get; set; }
    }
}
