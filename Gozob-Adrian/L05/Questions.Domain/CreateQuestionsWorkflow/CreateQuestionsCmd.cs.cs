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
        [Required]
        public string[] Tags { get; private set; }

        public CreateQuestionsCmd(string title, string body, string[] tags)
        {
            if(body.Length > 1001)
            {
                throw new Exception("Invalid body length");
            }
            if(tags.Length < 1 || tags.Length > 3)
            {
                throw new Exception("Invalid tags count");
            }
            Title = title;
            Body = body;
            Tags = tags;
        }
    }
}
