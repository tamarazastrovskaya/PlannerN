using System.ComponentModel.DataAnnotations.Schema;

namespace PlannerN.Entity
{
    [Table("categories")]
    class Category
    {
        [Column("id")]
        public int id { get; set; }
        [Column("Name")]
        public string Name { get; set; }
        [Column("Discription")]
        public string Discription { get; set; }
    }
}
