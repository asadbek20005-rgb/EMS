using EMS.Data.Entities.BaseEntities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMS.Data.Entities;

[Table("employee", Schema = "my")]
public class Employee : BaseCommonEntity
{
    [Column("id")]
    [Key]
    public int Id { get; set; }

    [Column("user_id")]
    [Required]
    public Guid UserId { get; set; }
    [ForeignKey(nameof(UserId))]
    [InverseProperty(nameof(User.Employees))]
    public User? User { get; set; }

    [Column("organization_id")]
    [Required]
    public int OrganizationId { get; set; }
    [ForeignKey(nameof(OrganizationId))]
    [InverseProperty(nameof(Organization.Employees))]
    public Organization? Organization { get; set; }

    [Column("job_type_id")]
    [Required]
    public int JobTypeId { get; set; }
    [ForeignKey(nameof(JobTypeId))]
    [InverseProperty(nameof(JobType.Employees))]
    public JobType? JobType { get; set; }

    [Column("job_level_id")]
    [Required]
    public int JobLevelId { get; set; }

    [ForeignKey(nameof(JobLevelId))]
    [InverseProperty(nameof(JobLevel.Employees))]
    public JobLevel? JobLevel { get; set; }

    [Column("salary_id")]
    [Required]
    public int SalaryId { get; set; }
    [ForeignKey(nameof(SalaryId))]
    [InverseProperty(nameof(Salary.Employees))]
    public Salary? Salary { get; set; }

    [Column("country_id")]
    [Required]
    public int CountryId { get; set; }

    [ForeignKey(nameof(CountryId))]
    public Country? Country { get; set; }

    [Column("city_id")]
    [Required]
    public int CityId { get; set; }
    [ForeignKey(nameof(CityId))]
    [InverseProperty(nameof(City.Employees))]
    public City? City { get; set; }

    [Column("district_id")]
    [Required]
    public int DistrictId { get; set; }
    [ForeignKey(nameof(DistrictId))]
    [InverseProperty(nameof(District.Employees))]
    public District? District { get; set; }

    [Column("created_user_id")]
    [Required]
    public Guid CreatedUserId { get; set; }

    [Column("modified_user_id")]
    public Guid? ModifiedUserId { get; set; }
}
