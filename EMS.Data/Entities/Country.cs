using EMS.Data.Entities.BaseEntities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMS.Data.Entities;

[Table("info_country", Schema = "info")]
public class Country : BaseInfoEntity
{
    [Column("code")]
    [MaxLength(10)]
    public string Code { get; set; }
}
