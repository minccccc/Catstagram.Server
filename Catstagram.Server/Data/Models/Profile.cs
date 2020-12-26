using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catstagram.Server.Data.Models
{
    public class Profile
    {
        public string Name { get; set; }

        public string ProfilePhotoUrl { get; set; }

        public string WebSite { get; set; }

        public string Biography { get; set; }

        public bool IsPrivate { get; set; }

    }
}
