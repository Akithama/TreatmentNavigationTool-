using System;
using System.Collections.Generic;
using System.Text;
using Unum.Data.Infrastructure.Repository;
using Unum.Data.Models;
using Unum.DataAccess.Infrastructure.Interfaces;

namespace Unum.DataAccess.Infrastructure.Repository
{
    public class QuestionAnswerRepository : Repository<QuestionAnswerMapping>, IQuestionAnswer
    {
        public QuestionAnswerRepository(ApplicationDBContext context) : base(context) { }
    }
}
