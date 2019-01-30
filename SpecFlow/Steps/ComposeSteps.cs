using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlow
{
    [Binding]
    public class ComposeSteps
    {
        [Given(@"I Navigated to Inbox")]
        public void GivenINavigatedToInbox()
        {
            Debug.WriteLine("I Navigated to Inbox");
            Console.WriteLine("Navigate To Inbox");
        }


        [Then(@"I Could see the sent mesage")]
        public void ThenICouldSeeTheSentMesage()
        {
            Debug.WriteLine("I Could see the sent mesage");
            Console.WriteLine("Could see the sent mesage");
        }

       
        [When(@"I Compose And Send Mail Without Attachment")]
        public void WhenIComposeAndSendMailWithoutAttachment()
        {
            Debug.WriteLine("WhenIComposeAndSendMailWithoutAttachment");
            Console.WriteLine("ComposeAndSendMail Without Attachment");
        }

        [When(@"I Compose And Send Mail With Attachment")]
        public void WhenIComposeAndSendMailWithAttachment()
        {
            Debug.WriteLine("WhenIComposeAndSendMailWithAttachment");
            Console.WriteLine("ComposeAndSendMail WithAttachment");
        }


    }
}
