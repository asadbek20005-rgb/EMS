namespace EMS.Common.Dtos;

public class EmployeeDto
{
    public int Id { get; set; }

    public Guid UserId { get; set; }
    public UserDto? User { get; set; }

    /*
    public int OrganizationId { get; set; }
    public Organization? Organization { get; set; }

    public int JobTypeId { get; set; }
    public JobType? JobType { get; set; }
    
    public int JobLevelId { get; set; }

    public JobLevel? JobLevel { get; set; }

    public int SalaryId { get; set; }
    public Salary? Salary { get; set; }
    
    public int CountryId { get; set; }
    
    public InfoCountry? Country { get; set; }

    public int CityId { get; set; }
    public InfoCity? City { get; set; }

    public int DistrictId { get; set; }
    public InfoDistrict? District { get; set; }*/
}