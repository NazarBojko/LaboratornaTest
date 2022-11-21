using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using NUnit.Framework;

namespace PageObject
{
    public class CustomerPage : BasePage
    {
        private static WebDriverWait wait;
        public CustomerPage(IWebDriver WebDriver) : base(WebDriver)
        {
          
        }
        private IWebElement btnWithdrawl => driver.FindElement(By.XPath("//button[@ng-click='withdrawl()']"));
        public void ClickWithdrawl() => btnWithdrawl.Click();

        private IWebElement inputAmount => driver.FindElement(By.XPath("//input[@ng-model='amount']"));
        public void ClickAmount() => inputAmount.SendKeys("100");

        private IWebElement btnConfirmWithdrawl => driver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[4]/div/form/button"));
        public void ClickConfirmWithdrawl() => btnConfirmWithdrawl.Click();

        public void Result(string text)
        {
            IWebElement Success = driver.FindElement(By.XPath("//span[@ng-show='message']"));
            string SuccessText = Success.Text;

            StringAssert.AreEqualIgnoringCase(text, SuccessText);
        }
    }
}
