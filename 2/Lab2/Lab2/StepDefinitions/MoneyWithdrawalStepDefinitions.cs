using PageObject;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class MoneyWithdrawalStepDefinitions:BaseSteps
    {
        private HomePage homePage;
        private LoginPage loginPage;
        private CustomerPage customerPage;
        [Given(@"open the XYZ Bank page")]
        public void GivenOpenTheXYZBankPage()
        {
            driver.Url = "https://www.globalsqa.com/angularJs-protractor/BankingProject/";
            homePage = new HomePage(driver);
        }

        [When(@"click on the Customer Login button")]
        public void WhenClickOnTheCustomerLoginButton()
        {
            homePage.Click—ustomerLogin();
        }

        [When(@"select the Customer Name")]
        public void WhenSelectTheCustomerName()
        {
            loginPage = new LoginPage(driver);
            loginPage.ClickSelectCustomer();
            
        }

        [When(@"click on the Login button")]
        public void WhenClickOnTheLoginButton()
        {
            loginPage.ClickLogin();
        }

        [When(@"click on the Withdrawl button")]
        public void WhenClickOnTheWithdrawlButton()
        {
            customerPage = new CustomerPage(driver);
            customerPage.ClickWithdrawl();
        }

        [When(@"enter an amount to be Withdrawn")]
        public void WhenEnterAnAmountToBeWithdrawn()
        {
            customerPage.ClickAmount();
        }

        [When(@"click on the Withdraw button")]
        public void WhenClickOnTheWithdrawButton()
        {
            customerPage.ClickConfirmWithdrawl();
        }

        [Then(@"the result should be a successful withdrawal")]
        public void ThenTheResultShouldBeASuccessfulWithdrawal()
        {
            customerPage.Result("Transaction successful");

        }
    }
}
