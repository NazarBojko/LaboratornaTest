using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace PageObject
{
    public class LoginPage : BasePage
    {
        private static WebDriverWait wait;
        public LoginPage(IWebDriver webDriver) : base(webDriver)
        {
            
        }

        private SelectElement SelectCustomer = new SelectElement(driver.FindElement(By.Id("userSelect")));
        public void ClickSelectCustomer() => SelectCustomer.SelectByIndex(1);

        private IWebElement btnLogin => driver.FindElement(By.XPath("//button[@ng-show=\"custId != ''\"]"));

        public void ClickLogin() => btnLogin.Click();

    }
}
