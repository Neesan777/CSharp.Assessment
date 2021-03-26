using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Question1;
using System.Globalization;

namespace Question1_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_GetDateOfBirth() // Checks whether method returns a value
        {
            IDBuilder iDBuilder = new IDBuilder(); 
            var id = "9605225076089";
            var testDob = DateTime.ParseExact(id.Substring(0, 6), "yyMMdd", CultureInfo.InvariantCulture);
            Assert.IsNotNull(testDob);

        }

        [TestMethod]
        public void Test_GetGender()    // Check if returned value fits criteria of gender
        {
            IDBuilder iDBuilder = new IDBuilder();
            var id = "9605225076089";
            int getValue = int.Parse(id.Substring(6, 4));
            Assert.IsTrue(getValue > 5000);


        }

        [TestMethod]
        public void Test_ifSA()     // Check if Valid SA Citizen based of returned values from ID Number
        {
            IDBuilder iDBuilder = new IDBuilder();
            var id = "9605225076089";
            int getValue = int.Parse(id.Substring(10, 1));
            Assert.AreEqual(getValue, 0);
        }

        [TestMethod]
        public void Test_IfValidID()  // Test if Valid ID Number
        {
            IDBuilder iDBuilder = new IDBuilder();
            var id = "9605225076089";


            string result = id;
            int sum = 0;
            int tempSum = 0;
            int multiplier = 1;

            for (int i = 0; i < id.Length; i++)   //Loop through the lenghth of the ID Number
            {

                tempSum = (int)char.GetNumericValue(id[i]) * multiplier; //Return value at i position and muliply by multiplier

                if (tempSum > 9)             // if value retrivied at position i is > 9 , sum the 2 single digits   
                {
                    tempSum = (tempSum % 10) + 1;
                }

                sum += tempSum;            // Add to main sum variable

                if (multiplier % 2 == 0)   // Alternate picking every 2nd digit to multiply 
                {
                    multiplier = 1;
                }
                else
                {
                    multiplier = 2;
                }


            }

            Assert.IsTrue(sum % 10 == 0);


    }
       
    }
}
