﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookExchange.API.Identity.DTOs
{
     public class LoginIdentityUserDto
     {
          public string Username { get; set; }
          public string Password { get; set; }
     }
}