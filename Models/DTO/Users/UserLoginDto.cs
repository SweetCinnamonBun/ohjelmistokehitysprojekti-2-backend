using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ohjelmistokehitysprojekti_2_backend.Models.DTO.Users
{
    public class UserLoginDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}