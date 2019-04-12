using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace SampleApi.Model
{
    public class AuthRequestModel
    {

        [Required]
        [DataMember(Name = "username")]
        public String Username { get; set; }

        [Required]
        [DataMember(Name = "password")]
        public String Password { get; set; }
        
    }
}
