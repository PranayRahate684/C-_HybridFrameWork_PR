using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenEMR_MedicalRecordAutomation
{
    public class Login
    {
        public void logintest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(10);

            driver.Navigate().GoToUrl("http://demo.openemr.io/b/openemr/interface/login/login.php?");

          string actualText=  driver.Title;
            Assert.That(actualText, Is.EqualTo("OpenEMR Login"));
                
        }
        [Test]
        public void ApplicationDescriptionTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Navigate().GoToUrl("https://demo.openemr.io/b/openemr");

            //Assert the text --> "The most popular open-source Electronic Health Record and Medical Practice Management solution."
            string descrption = driver.FindElement(By.CssSelector("[class='text-center lead']")).Text;
            string actualDescrption = "The most popular open-source Electronic Health Record and Medical Practice Management solution.";

            Assert.That(descrption, Is.EqualTo(actualDescrption));
            driver.Quit();
        
        }
        
    }
}
