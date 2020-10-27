using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Unum.Data.Modelss;

namespace Unum.Data.Models
{
    public class Survey
    {
        //public Survey()
        //{
        //    UserResponse = new HashSet<UserResponse>();
        //}

        [Key]
        public int SurveyId { get; set; }
        public string SurvayName { get; set; }
        public bool? IsValid { get; set; }

        public ICollection<UserResponse> UserResponse { get; set; }
    }
}
