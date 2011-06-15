using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectToTestGithub
{
    public class ClassForTestBranchOnly
    {
        public ClassForTestBranchOnly()
        {
            checkThatSomethingHappens(true);
        }


        private void checkThatSomethingHappens(bool input)
        {
            var a = 0, b = 5;
            string result = "";
            for (a = b; b < 50; b++)
            {
                while (a < b)
                {
                    result += a;
                }
            }
            Console.WriteLine(result);
        }

        
    }
}
