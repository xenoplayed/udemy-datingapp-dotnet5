using System;
using System.Collections.Generic;

namespace API.Dtos
{
    public class MemberDto
    {
        public int Id { get; set; }
        public string Username { get; set; } // reconizes UserName in AppUser 
        public string PhotoUrl { get; set; } // Main photo
        public int Age { get; set; } // Get value automatically from GetAge() in AppUser
        public string KnownAs { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        public string Gender { get; set; }
        public string Introduction { get; set; }
        public string LookingFor { get; set; }
        public string Interests { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public ICollection<PhotoDto> Photos { get; set; }
    }
}