using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace SampleApi.Model
{
    public class AuthResponseModel
    {
        [DataMember(Name = "token")]
        public String token { get; set; }
        
    }
}
