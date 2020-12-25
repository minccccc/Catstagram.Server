using Microsoft.AspNetCore.Identity;
using System.Collections;
using System.Collections.Generic;

namespace Catstagram.Server.Data.Models
{
    public class User : IdentityUser
    {
        public IEnumerable<Cat> Cats { get; } = new HashSet<Cat>();
    }
}
