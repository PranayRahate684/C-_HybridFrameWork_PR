using OpenEMR_MedicalRecordAutomation.AutomationWrapperClass;
using OpenEMR_MedicalRecordAutomation.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenEMR_MedicalRecordAutomation
{
    public class UserLoginTest : AutomationWrapper
    {


        [Test]
        [TestCaseSource(typeof(DataSource),nameof(DataSource.ValidaLoginTestExcel))]
        public void LoginUserTest(string username, string password, string expectedTitle)
        {
            driver.FindElement(By.Name("authUser")).SendKeys(username);
            driver.FindElement(By.Id("clearPass")).SendKeys(password);
            driver.FindElement(By.Id("login-button")).Click();
          
            //Validate Title
            Assert.That(driver.Title, Is.EqualTo(expectedTitle));
        }

        [Test]
        //[TestCase("saul", "saul234", "Invalid username or password")]

        [TestCaseSource(typeof(DataSource), nameof(DataSource.InvalidLoginTestExcel))]
        public void InvalidUserLogin(string username, string password, string expectedError)
        {
            driver.FindElement(By.Name("authUser")).SendKeys(username);
            driver.FindElement(By.Id("clearPass")).SendKeys(password);
            driver.FindElement(By.Id("login-button")).Click();
            string error = driver.FindElement(By.XPath("//p[contains(text(),'Invalid')]")).Text;
            //Validate Error message
            Assert.That(error, Is.EqualTo(expectedError));

            //Assert using Contains
            Assert.That(error.Contains(expectedError), "Printing message if assertion fails");

        }
    }
}
