using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Unum.Data.Modelss;

namespace Unum.Data.Models
{
    public class User
    {
        //public User()
        //{
        //    UserResponse = new HashSet<UserResponse>();
        //}

        [Key]
        public int UserId { get; set; }
        public string Email { get; set; }

        public ICollection<UserResponse> UserResponse { get; set; }
    }
}
