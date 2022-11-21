using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class BaseSteps
    {
        protected static IWebDriver driver;
        [BeforeFeature]
        public static void BeforeFeature()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        [AfterFeature]
        public static void AfterFeature()
        {
            driver.Close();
        }
    }
}
