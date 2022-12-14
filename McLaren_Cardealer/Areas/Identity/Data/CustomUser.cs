using Microsoft.AspNetCore.Identity;
using System;

namespace McLaren_Cardealer.Areas.Identity.Data
{
    public class CustomUser :IdentityUser
    {
        [PersonalData]
        public string Naam { get; set; }
        [PersonalData]
        public DateTime Geboortedatum { get; set; }
    }
}
