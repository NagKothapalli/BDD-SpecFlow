using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlow.PageObjectes
{
    [Binding]
    public class Login
    {
       [BeforeTestRun]
        public static void launchApplication()
        {
            Console.WriteLine("Launch Application");
        }
        [BeforeFeature]
        public static void loginTOApplication()
        {
            Console.WriteLine("Login To Application");
        }
        [BeforeScenario]
        public static void BeforeScenario()
        {
            Console.WriteLine("Before Scenario Method");
        }
        [AfterScenario]
        public static void AfterScenario()
        {
            Console.WriteLine("After Scenario Method");
        }
        [AfterFeature]
        public static void logoutFromApplication()
        {
            Console.WriteLine("Logout From Application");
        }
        [AfterTestRun]
        public static void CloseApplication()
        {
            Console.WriteLine("Close Application");
        }
    
    }
}
