using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenEMR_MedicalRecordAutomation.Utilities
{
    internal class DataSource
    {
        public static object[] ValidateLoginTest()

        {
            object[] dataset1 = new string[3];
            dataset1[0] = "admin";
            dataset1[1] = "pass";
            dataset1[2] = "OpenEMR";


            object[] dataset2 = new string[3];
            dataset1[0] = "accountant";
            dataset1[1] = "accountant";
            dataset1[2] = "OpenEMR";

            object[] finaldata = new object[2];
            finaldata[0] = dataset1;
            finaldata[1] = dataset2;

            return finaldata;
        }
    }
}
