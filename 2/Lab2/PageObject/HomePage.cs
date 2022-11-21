using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace PageObject
{
    public class HomePage : BasePage
    {
        private static WebDriverWait wait;
        public HomePage(IWebDriver webDriver) : base(webDriver)
        {
            
        }
        private IWebElement btnСustomerLogin => driver.FindElement(By.XPath("//button[@ng-click=\"customer()\"]"));
        public void ClickСustomerLogin() => btnСustomerLogin.Click();
    }
}
