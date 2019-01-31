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
    public class ForwardSteps
    {
        [When(@"I Forward An Mail WithoutAttachment")]
        public void WhenIForwardAnMailWithoutAttachment()
        {
            Debug.WriteLine("WhenIForwardAnMailWithoutAttachment");
            Console.WriteLine("Forward ToAnMail WithoutAttachment");
        }

        [When(@"I Forward An Mail WithAttachment")]
        public void WhenIForwardAnMailWithAttachment()
        {
            Debug.WriteLine("WhenIForwardAnMailWithAttachment");
            Console.WriteLine("Forward ToAnMail WithoutAttachment");
        }

        [Given(@"I Saw The Inbox")]
        public void GivenISawTheInbox()
        {
            Debug.WriteLine("I Saw The Inbox");
            Console.WriteLine("I Saw The Inbox");
        }

        [When(@"I Saw it is correct")]
        public void WhenISawItIsCorrect()
        {
            Debug.WriteLine("I Saw it is correct");
            Console.WriteLine("I Saw it is correct");
        }

        [Then(@"I Saw that it Sent")]
        public void ThenISawThatItSent()
        {
            Debug.WriteLine("I Saw that it Sent");
            Console.WriteLine("I Saw that it Sent");
        }



    }
}
