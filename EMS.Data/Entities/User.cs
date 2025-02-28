using EMS.Data.Entities.BaseEntities;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMS.Data.Entities;

[Table("sys_user", Schema = "my")]
[Index(nameof(Username), IsUnique = true)]
public class User : BaseCommonEntity
{
    [Column("id")]
    [Key]
    public Guid Id { get; set; }

    [Column("first_name")]
    [MaxLength(30)]
    [Required]
    public string FirstName { get; set; }

    [Column("last_name")]
    [MaxLength(30)]
    [Required]
    public string LastName { get; set; }

    [Column("full_name")]
    [MaxLength(30)]
    [Required]
    public string FullName { get; set; }

    [Column("username")]
    [MaxLength(32)]
    [Required]
    // The property will be made unique in OnModelCreating method configuration
    public string Username { get; set; }

    [Column("password_hash")]
    [Required]
    public string PasswordHash { get; set; }

    [Column("phone_number")]
    [MaxLength(15)]
    public string? PhoneNumber { get; set; }

    [Column("date_of_birth")]
    public DateTime? DateOfBirth { get; set; }

    [Column("created_user_id")]
    [Required]
    public Guid CreatedUserId { get; set; }

    [Column("modified_user_id")]
    public Guid? ModifiedUserId { get; set; }

    [Column("role_id")]
    [Required]
    public int RoleId { get; set; }
    [ForeignKey(nameof(RoleId))]
    [InverseProperty(nameof(Role.Users))]
    public Role? Role { get; set; }

    [Column("gender_id")]
    [Required]
    public int GenderId { get; set; }
    [ForeignKey(nameof(GenderId))]
    public Gender? Gender { get; set; }

    [Column("content_id")]
    public int? ContentId { get; set; }
    [ForeignKey(nameof(ContentId))]
    public InfoContent? Content { get; set; }


    [Column("state_id")]
    public int StateId { get; set; }

    [ForeignKey(nameof(StateId))]
    public State? State { get; set; }


    [InverseProperty(nameof(Employee.User))]
    public List<Employee>? Employees { get; set; }
}