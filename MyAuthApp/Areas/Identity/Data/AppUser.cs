using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace MyAuthApp.Areas.Identity.Data;

// Add profile data for application users by adding properties to the AppUser class
public class AppUser : IdentityUser
{
    [PersonalData]
    [Column(TypeName ="varchar(50)")]
    public string? FirstName { get; set; }

    [PersonalData]
    [Column(TypeName = "varchar(50)")]
    public string? LastName { get; set; }

    [PersonalData]
    [Column(TypeName = "varchar(20)")]
    public string? MobileNumber  { get; set; }
}

