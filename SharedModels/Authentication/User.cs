using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedModels;

namespace SharedServices.Authentication
{
    public class User : IEntityBase<int>
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
