using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Questions.Domain.CreateQuestionsWorkflow
{
    public static partial class CreateQuestionsResult
    {
        public interface ICreateQuestionsResult { }

        public class QuestionCreated : ICreateQuestionsResult
        {
            public Guid QuestionId { get; private set; }
            public string User { get; private set; }
            public string Question { get; private set; }

            public QuestionCreated(Guid questionId, string user, string question)
            {
                QuestionId = questionId;
                User = user;
                Question = question;
            }
        }

        public class QuestionNotCreated : ICreateQuestionsResult
        {
            public string Reason { get; set; }

            public QuestionNotCreated(string reason)
            {
                Reason = reason;
            }
        }

        public class QuestionValidationFailed : ICreateQuestionsResult
        {
            public IEnumerable<string> ValidationErrors { get; private set; }

            public QuestionValidationFailed(IEnumerable<string> errors)
            {
                ValidationErrors = errors.AsEnumerable();
            }
        }
    }
}
