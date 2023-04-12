using System.ComponentModel.DataAnnotations.Schema;

namespace APIBookList.Models.Base;

public class BaseEntity
{
    [Column("id")]
    public long Id { get; set; }
}
