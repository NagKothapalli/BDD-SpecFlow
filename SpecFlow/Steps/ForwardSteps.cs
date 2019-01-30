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



    }
}
