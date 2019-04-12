using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace SampleApi.Model
{
    public class RegisterRequestModel
    {

        [Required]
        [DataMember(Name = "firstName")]
        public string FirstName { get; set; }

        [Required]
        [DataMember(Name = "lastName")]
        public string LastName { get; set; }

        [Required]
        [DataMember(Name = "username")]
        public string Username { get; set; }

        [Required]
        [DataMember(Name = "password")]
        public string Password { get; set; }
        
    }
}
