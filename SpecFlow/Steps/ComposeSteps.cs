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

        [Given(@"I Launched Application '(.*)'")]
        public void GivenILaunchedApplication(string URL)
        {
            Console.WriteLine("URL :" + URL);
        }

        [When(@"I Enter UserName '(.*)'")]
        public void WhenIEnterUserName(string UserName)
        {
            Console.WriteLine("UserName :" + UserName);
        }

        [When(@"I Enter PassWord'(.*)'")]
        public void WhenIEnterPassWord(string PassWord)
        {
            Console.WriteLine("PassWord :" + PassWord);
        }

        [Then(@"I Should Login")]
        public void ThenIShouldLogin()
        {
            Console.WriteLine("I Should Login");
        }

        [Given(@"I Called The '(.*)'")]
        public void GivenICalledThe(string URL)
        {
            Console.WriteLine("URL:" + URL);
        }

        [When(@"I Enter The UserName '(.*)'")]
        public void WhenIEnterTheUserName(string UserName)
        {
            Console.WriteLine("UserName:" + UserName);
        }

        [When(@"I Enter The PassWord '(.*)'")]
        public void WhenIEnterThePassWord(string PassWord)
        {
            Console.WriteLine("PassWord:" + PassWord);
        }



    }
}
