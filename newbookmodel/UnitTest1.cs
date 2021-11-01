using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using OpenQA.Selenium.Support.UI;
using Keys = OpenQA.Selenium.Keys;

namespace newbookmodel
{
    public class Tests
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://newbookmodels.com/");
        }

        [Test]
        public void Registration()
        {
            IWebElement buttonSignUp = driver.FindElement(By.CssSelector("[class='Navbar__signUp--12ZDV']"));
            buttonSignUp.Click();
            IWebElement buttonFirstName = driver.FindElement(By.CssSelector("[name = 'first_name']"));
            buttonFirstName.SendKeys("Di");
            IWebElement buttonLasttName = driver.FindElement(By.CssSelector("[name = 'last_name']"));
            buttonLasttName.SendKeys("Di");

            DateTime dataTime = new DateTime();
            dataTime = DateTime.Now;
            string name = dataTime.ToString();
            name = name.Replace(".", "");
            name = name.Replace(" ", "");
            name = name.Replace(":", "");
            name = "newMail" + name + "@test.com";
            IWebElement buttonEmail = driver.FindElement(By.CssSelector("[name='email']"));
            buttonEmail.SendKeys(name);
            IWebElement buttonPassword = driver.FindElement(By.CssSelector("[name='password']"));
            buttonPassword.SendKeys("1234567890Qe_d");
            IWebElement buttonConfirmPassword = driver.FindElement(By.CssSelector("[name='password_confirm']"));
            //buttonConfirmPassword.Clear();
            buttonConfirmPassword.SendKeys("1234567890Qe_d");
            IWebElement buttonPhone = driver.FindElement(By.CssSelector("[name='phone_number']"));
            buttonPhone.SendKeys("1234123123");
            IWebElement buttonNext = driver.FindElement(By.CssSelector("[type='submit']"));
            buttonNext.Click();
            IWebElement buttonCompanyName = driver.FindElement(By.CssSelector("[name='company_name']"));
            buttonCompanyName.SendKeys("MyComp");
            IWebElement buttonCompanyWedSite = driver.FindElement(By.CssSelector("[name='company_website']"));
            buttonCompanyWedSite.SendKeys("mynewcomp.com");
            IWebElement buttonAdress = driver.FindElement(By.CssSelector("[name='location']"));
            //buttonAdress.Click();
            buttonAdress.SendKeys("2453 Hancock Street, Alameda, CA, USA");

            IWebElement buttonIndustry = driver.FindElement(By.CssSelector("[name='industry']"));
            buttonIndustry.Click();

            IWebElement buttonIndustryChose = driver.FindElement(By.XPath("/html/body/nb-app/nb-signup-company/common-react-bridge/div/div[2]/div/section/section/div/form/section/section/div/div[2]/section/div/section/div[3]/div[1]/div/div[1]/div[2]/div[1]/span"));
            buttonIndustryChose.Click();           
            IWebElement element = driver.FindElement(By.ClassName("tp-select-input")); 
            driver.FindElement(By.XPath("/html/body/nb-app/nb-signup-company/common-react-bridge/div/div[2]/div/section/section/div/form/section/section/div/div[2]/section/div/section/div[3]/div[1]/div/div[1]/div[2]/div[1]/span[text()='Advertising']"));
            buttonIndustry.SendKeys(OpenQA.Selenium.Keys.Down);
            buttonIndustry.SendKeys(OpenQA.Selenium.Keys.Return);
            buttonAdress.Click();
            buttonAdress.SendKeys(Keys.Down);

            Assert.Pass();
        }

        [TearDown]
        public void After()
        {
            //driver.Quit();
        }
    }
}