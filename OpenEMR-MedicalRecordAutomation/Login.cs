using OpenEMR_MedicalRecordAutomation.AutomationWrapperClass;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenEMR_MedicalRecordAutomation.OpenEMR_MedicalRecordAutomation
{
    public class Login : AutomationWrapper
    {
       

        [Test]
        public void logintest()
        {
            string actualText = driver.Title;
            Assert.That(actualText, Is.EqualTo("OpenEMR Login"));

        }
        [Test]
        public void ApplicationDescriptionTest()
        {
            //Assert the text --> "The most popular open-source Electronic Health Record and Medical Practice Management solution."
            string descrption = driver.FindElement(By.CssSelector("[class='text-center lead']")).Text;
            string actualDescrption = "The most popular open-source Electronic Health Record and Medical Practice Management solution.";

            Assert.That(descrption, Is.EqualTo(actualDescrption));


        }

    }
}
