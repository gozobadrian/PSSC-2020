using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Questions.Domain.CreateQuestionsWorkflow
{
    class CreateQuestionsCmd
    {
        [Required]
        public string Title { get; private set; }
        [Required]
        [EmailAddress]
        public string Body { get; private set; }

        public CreateQuestionsCmd(string title, string body)
        {
            Title = title;
            Body = body;
        }
    }
}
