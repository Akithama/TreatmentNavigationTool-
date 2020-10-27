using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Unum.Data.Modelss;

namespace Unum.Data.Models
{
    public class Answers
    {
        //public Answers()
        //{
        //    QuestionAnswerMapping = new HashSet<QuestionAnswerMapping>();
        //    UserResponse = new HashSet<UserResponse>();
        //}

        [Key]
        public int AnswerId { get; set; }
        public string AnswerDescription { get; set; }
        public int? Points { get; set; }
        public bool? IsValid { get; set; }

        public ICollection<QuestionAnswerMapping> QuestionAnswerMapping { get; set; }
        public ICollection<UserResponse> UserResponse { get; set; }
    }
}
