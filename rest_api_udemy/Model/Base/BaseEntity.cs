using System.ComponentModel.DataAnnotations.Schema;

namespace rest_api_udemy.Model.Base
{
    public class BaseEntity
     {
        [Column("id")]
        public long Id { get; set; }
    }
}
