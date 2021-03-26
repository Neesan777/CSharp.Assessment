using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Question1;

namespace Question1
{
    internal class Person
    {
        internal DateTime DateOfBirth { get; set; }
        internal string Gender { get; set; }
        internal bool isSouthAfricanCitizen { get; set; }
        internal bool isValidIDNumber { get; set; }
    }
}


public interface IBuilder
{
    DateTime GetDOB(string id);
    string GetGender(string id);
    bool IsSouthAfrican(string id);
    bool IsValidID(string id);

}



public class IDBuilder : IBuilder
{
 
    public DateTime GetDOB(string id)
    {
        return _ = DateTime.ParseExact(id.Substring(0, 6),"yyMMdd",CultureInfo.InvariantCulture);
    }

    public string GetGender(string id)
    {
        
        int genderValue = Int32.Parse(id.Substring(6, 4));
        if (genderValue <= 4999)
        {
            return "Female";
        }
        else 
        {
            return "Male";
        }
    }


    public bool IsSouthAfrican (string id)
    {
        int isSAValue = Int32.Parse(id.Substring(10, 1));
        if(isSAValue == 0)
        {
            return true;
        }
        else
        {
            return false;
        }  
    }


    public bool IsValidID(string id)
    {

        string result = id;
        int sum = 0;
        int tempSum = 0;
        int multiplier = 1;

        for (int i = 0; i < id.Length; i++)   //Loop through the lenghth of the ID Number
        {

            tempSum = (int)char.GetNumericValue(id[i]) * multiplier; //Return value at i position and muliply by multiplier

            if (tempSum >9)             // if value retrivied at position i is > 9 , sum the 2 single digits   
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

        if(sum%10 == 0) // if the sum modulus 10 does not return a remainder = vaild ID Number
        {
            return true;
        }
        else
        {
            return false;
        }


    }
  
}
