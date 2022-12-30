using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace McLaren_Cardealer.Areas.Identity.Data
{
    public class CustomUser : IdentityUser
    {
        [PersonalData]
        public string Naam { get; set; }
        //[PersonalData]
        //[DataType(DataType.Password)]
        //public string Password { get; set; }
    }
}
