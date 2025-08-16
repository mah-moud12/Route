using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_04.Overloading
{
    class UserViewModel
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }

        public static explicit operator UserViewModel(User U01)
        {
            string[]? names = U01?.FullName?.Split(" ");
            return new UserViewModel
            {
                Id = U01?.Id??0,
                FirstName = names?[0],
                LastName = names?[1]?.Length > 2 && names.Length>1? names[1] : null,
                Email = U01?.Email
            };
        }

    }
}
