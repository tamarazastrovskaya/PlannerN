using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlannerN.Entity
{
    [Table("categories")]
    class Category
    {
        [Key, Column("id")]
        public int Id { get; set; }

        [Column("createdate")]
        public DateTime CreateDate { get; set; }

        [Column("expdate")]
        public DateTime ExpDate { get; set; }


        [Column("description")]
        public string Description { get; set; }


        [Column("status")]
        public string Status { get; set; }

    }
}
