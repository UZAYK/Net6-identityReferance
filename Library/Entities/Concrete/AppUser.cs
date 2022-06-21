using Piccus.Entities.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piccus.Entities.Concrete
{
    public class AppUser : IdentityUser<int>, IBaseEntity
    {
        //public string Picture { get; set; } = "default.png";

    }
}
