﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace SheElevate.Areas.Identity.Data;

// Add profile data for application users by adding properties to the SheElevateUser class
public class SheElevateUser : IdentityUser
{
    [PersonalData] public string? UserFullName { get; set; }
    [PersonalData] public int UserAge { get; set; }
    [PersonalData] public string? UserAddress { get; set; }
    [PersonalData] public DateTime UserDOB { get; set; }
    [PersonalData] public string? userrole { get; set; }

}

