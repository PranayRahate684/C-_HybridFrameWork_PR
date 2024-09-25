using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenEMR_MedicalRecordAutomation.AutomationWrapperClass
{
    public class AutomationWrapper
    {

        protected IWebDriver driver;
        [SetUp]
        public void BeforeMethod()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Navigate().GoToUrl("http://demo.openemr.io/b/openemr/interface/login/login.php?");
        }
        [TearDown]
        public void AfterMethod()
        {
            driver.Dispose();
        }
    }
}
