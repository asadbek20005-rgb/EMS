using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EMS.Common.Models;

public class CreateCountryModel
{

    public string Code { get; set; }

    public string ShortName { get; set; }


    public string FullName { get; set; }
}