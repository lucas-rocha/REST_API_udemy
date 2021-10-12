using rest_api_udemy.Model.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace rest_api_udemy.Model
{
    [Table("books")]
    public class Book : BaseEntity
    {
        [Column("title")]
        public string Title { get; set; }
        
        [Column("author")]
        public string Author { get; set; }
        
        [Column("price")]
        public decimal Price { get; set; }
        
        [Column("launch_date")]
        public DateTime LauncheDate { get; set; }
    }
}
