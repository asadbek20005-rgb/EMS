using EMS.Data.Entities.BaseEntities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMS.Data.Entities
{
    [Table("info_city", Schema = "info")]

    public class City : BaseInfoEntity
    {
        [Column("code")]
        [MaxLength(10)]
        public string Code { get; set; }

        [Column("country_id")]
        [Required]
        public int InfoCountryId { get; set; }

        [ForeignKey(nameof(InfoCountryId))]
        public Country? Country { get; set; }
        [InverseProperty(nameof(Employee.City))]
        public List<Employee> Employees { get; set; }
    }
}
