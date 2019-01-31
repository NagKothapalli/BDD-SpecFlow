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
        [BeforeScenario(Order =1)]
        public static void BeforeScenario1()
        {
            FeatureInfo finfo = FeatureContext.Current.FeatureInfo;
            Console.WriteLine("Feature Tilte :" + finfo.Title);
            ScenarioInfo sinfo = ScenarioContext.Current.ScenarioInfo;
            Console.WriteLine("Scenario Tags :" + sinfo.Tags[0]);
            Console.WriteLine("Scenario Tilte :" + sinfo.Title);
            Console.WriteLine("Scenario Description :" + sinfo.Description);
            Console.WriteLine("Before Scenario 2");
        }
        [BeforeScenario(Order =2)]
        public static void BeforeScenario2()
        {
            Console.WriteLine("Before Scenario 1");
        }
        [BeforeScenarioBlock]
        public static void BeforeBlock()
        {
            Console.WriteLine("Before Scenario Block");
        }
        [BeforeStep]
        public static void BeforeStep()
        {
            Console.WriteLine("Before Scenario Step");
        }
        [AfterStep]
        public static void AfterStep()
        {
            Console.WriteLine("After Scenario Step");
        }
        [AfterScenarioBlock]
        public static void AfterBlock()
        {
            Console.WriteLine("After Scenario Block");
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
