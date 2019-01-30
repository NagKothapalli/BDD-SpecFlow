using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlow.Steps
{
    [Binding]
    public class ReplySteps
    {
        [When(@"I Reply To An Mail Without Attachment")]
        public void WhenIReplyToAnMailWithoutAttachment()
        {
            Debug.WriteLine("WhenIReplyToAnMailWithoutAttachment");
            Console.WriteLine("Reply ToAnMail WithoutAttachment");
        }

        [When(@"I Reply To An Email With Attachment")]
        public void WhenIReplyToAnEmailWithAttachment()
        {
            Debug.WriteLine("WhenIReplyToAnEmailWithAttachment");
            Console.WriteLine("Reply ToAnEmail WithAttachment");
        }

    }
}
