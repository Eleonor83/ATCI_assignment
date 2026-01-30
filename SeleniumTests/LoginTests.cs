using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTests
{
    public class LoginTests
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test, Ignore("UI-test körs lokalt, ej i CI")]
        public void SuccessfulLogin_ShouldNavigateToInventoryPage()
        {
            driver.FindElement(By.Id("user-name"))
                .SendKeys("standard_user");

            driver.FindElement(By.Id("password"))
                .SendKeys("secret_sauce");

            driver.FindElement(By.Id("login-button"))
                .Click();

            Assert.That(driver.Url, Does.Contain("inventory"));
        }
    }
}
