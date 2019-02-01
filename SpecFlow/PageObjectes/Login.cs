using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlow.PageObjectes
{
    [Binding]
    public class Login
    {
       static IWebDriver driver;
       [BeforeTestRun]
        public static void launchApplication()
        {
            //driver = new ChromeDriver();
            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability("name", ConfigurationManager.AppSettings["ApplicationName"]);
            capabilities.SetCapability(CapabilityType.BrowserName, ConfigurationManager.AppSettings["browser"]);
            capabilities.SetCapability(CapabilityType.Version, ConfigurationManager.AppSettings["BrowserVersion"]);
            capabilities.SetCapability(CapabilityType.Platform, ConfigurationManager.AppSettings["OS"]);
            capabilities.SetCapability("screen-resolution", ConfigurationManager.AppSettings["ScreenResolution"]);
            capabilities.SetCapability("username", ConfigurationManager.AppSettings["SaucelabsUserName"]);
            capabilities.SetCapability("accessKey", ConfigurationManager.AppSettings["SaucelabsAccessKey"]);
            Uri myUrl = new Uri(ConfigurationManager.AppSettings["SaucelabsURL"]);
            driver = new RemoteWebDriver(myUrl, capabilities);
           // driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://newtours.demoaut.com/");
            Console.WriteLine("Launch Application");
            driver.FindElement(By.Name("userName")).SendKeys("nag022");
            driver.FindElement(By.Name("password")).SendKeys("mar1234");
            driver.FindElement(By.Name("login")).Click();
        }
        [BeforeFeature]
        public static void loginTOApplication()
        {
            Console.WriteLine("Login To Application");
        }
        [BeforeScenario(Order =1)]
        public static void BeforeScenario1()
        {
            Exception err = ScenarioContext.Current.TestError;
            FeatureInfo finfo = FeatureContext.Current.FeatureInfo;
            Console.WriteLine("Feature Tilte :" + finfo.Title);
            Console.WriteLine("Feature Description :" + finfo.Description);
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
