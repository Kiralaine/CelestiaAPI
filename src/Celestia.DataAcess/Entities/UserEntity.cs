﻿
namespace Celestia.DataAccess.Entities
{
    public  class UserEntity
    {
        public long UserId { get; set; }
        public string Username { get; set; }
        public string  FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Salt { get; set; }

        public string Password { get; set; }
    }
}
