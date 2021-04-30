using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Validate
    {
        public string CheckInput(string reporter, string info)
        {
            string output = "";

            Regex regex = new Regex("^([a-zA-Z]{2,}\\s[a-zA-Z]{1,}'?-?[a-zA-Z]{2,}\\s?([a-zA-Z]{1,})?)");

            if (info.Length < 25)
            {
                output += "Please enter more information about the issue" + Environment.NewLine;
            }

            if (reporter.Length < 3)
            {
                output += "Please enter a name" + Environment.NewLine;
            }

            if (!regex.IsMatch(reporter))
            {
                output += "Please enter a valid name" + Environment.NewLine;
            }

            return output;
        }
    }
}
