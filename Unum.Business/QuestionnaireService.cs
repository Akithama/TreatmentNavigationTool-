using System;
using System.Collections;
using System.Collections.Generic;
using Unum.BusinessLogic.Service.Interfaces;
using Unum.Common;
using Unum.Data.Models;
using Unum.DataAccess.Infrastructure.Interfaces;

namespace Unum.Business
{
    public class QuestionnaireService : IQuestionnaireService
    {
        private IUnitOfWork _unitOfWork;

        public QuestionnaireService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<QuestionAnswerDto> PullQuestions()
        {
            List<QuestionAnswerDto> QuestionAnswerList = new List<QuestionAnswerDto>();
            List<Answers> AnswerList = new List<Answers>();

            var questionsMapper = _unitOfWork.QuestionAnswer.GetAll();
            foreach (var item in questionsMapper)
            {
                Answers answer = new Answers()
                {
                    AnswerId = item.AnswerId,
                    AnswerDescription = _unitOfWork.Answer.GetById(item.AnswerId).AnswerDescription,
                    Points = _unitOfWork.Answer.GetById(item.AnswerId).Points                    
                };
                AnswerList.Add(answer);
                QuestionAnswerDto questionAnswerDto = new QuestionAnswerDto()
                {
                    QuestionAnswerMappingId = item.QuestionAnswerMappingId,
                    QuestionId = item.QuestionId,
                    Description = _unitOfWork.Question.GetById(item.QuestionId).Description,
                    Answers = AnswerList
                };

                QuestionAnswerList.Add(questionAnswerDto);
            }
            return QuestionAnswerList;
        }
    }
}
