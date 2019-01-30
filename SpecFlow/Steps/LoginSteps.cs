using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlow
{
    [Binding]
    public  class LoginSteps
    {
       
        [Given(@"I Called Application URL")]
        public void GivenICalledApplicationURL()
        {
            Console.WriteLine("Called Application URL");
        }

        [Then(@"Application Should be Launched")]
        public void ThenApplicationShouldBeLaunched()
        {
            Console.WriteLine("Application Launched");
        }

        [Given(@"I have Application Opened")]
        public void GivenIHaveApplicationOpened()
        {
            Console.WriteLine("Application Opened");
        }

        [When(@"I Enter User Credentials")]
        public void WhenIEnterUserCredentials()
        {
            Console.WriteLine("Enter User Credentials");
        }

        [Then(@"I Could able to Login To the Application")]
        public void ThenICouldAbleToLoginToTheApplication()
        {
            Console.WriteLine("Login To the Application");
        }

        [Given(@"I Called Logut")]
        public void GivenICalledLogut()
        {
            Console.WriteLine("Call Logout ");
        }

        [Then(@"Application Should be LoggedOut")]
        public void ThenApplicationShouldBeLoggedOut()
        {
            Console.WriteLine("Logged Out from Application");
        }

        [Given(@"I have Close Application")]
        public void GivenIHaveCloseApplication()
        {
            Console.WriteLine("Closed the Application");
        }

        [Then(@"Application should be Closed")]
        public void ThenApplicationShouldBeClosed()
        {
            Console.WriteLine("Application Closed");
        }


    }
}
