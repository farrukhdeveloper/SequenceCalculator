using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Utility
    {
        public List<int> getNumbers(int LimitValue)
        {
            
            List<int> sequence = new List<int>();
            for (int i = 1; i <= LimitValue; i++)
            {
                sequence.Add(i);
            }
            //Following is line to include the Entered Number in list as it is mentioned in requirement (Requirment: S3.1.1)
            if (sequence.ElementAt(sequence.Count - 1) != LimitValue)
                sequence.Add(LimitValue);

            return sequence;
        }
        public List<int> getOddSequence(int LimitValue)
        {
            List<int> oddList = new List<int>();
            for (int i = 1; i <= LimitValue; i++)
            {
                if ((i % 2) != 0)
                {
                    oddList.Add(i);
                }
            }
            //Following is line to include the Entered Number in list as it is mentioned in requirement (Requirment: S3.1.2)
            if (oddList.ElementAt(oddList.Count - 1) != LimitValue)
                oddList.Add(LimitValue);

            return oddList;
        }
        public List<int> getEvenSequence(int LimitValue)
        {
            List<int> evenList = new List<int>();
            for (int i = 1; i <= LimitValue; i++)
            {
                if ((i % 2) == 0)
                {
                    evenList.Add(i);
                }
            }
            //Following is line to include the Entered Number in list as it is mentioned in requirement (Requirment: S3.1.3)
            if (evenList.ElementAt(evenList.Count - 1) != LimitValue)
                evenList.Add(LimitValue);

            return evenList;
        }

        public List<string> getReplacedSequence(int LimitValue)
        {
            List<string> replaceList = new List<string>();
            for (int i = 1; i <= LimitValue; i++)
            {
                if ((i % 3) == 0 && (i % 5) != 0)
                {
                    replaceList.Add("C");
                }
                else if ((i % 5) == 0 && (i % 3) != 0)
                {
                    replaceList.Add("E");
                }
                else if (((i % 5) == 0) && ((i % 3) == 0))
                {
                    replaceList.Add("Z");
                }
                else
                {
                    replaceList.Add(Convert.ToString(i));
                }

            }
            //Following is line to include the Entered Number in list as it is mentioned in requirement (Requirment: S3.1.4)
            // And Whenever there is C, E and Z in the last location, Entered number would not be included (Requirement: S3.1.4.1, S3.1.4.2, S3.1.4.3)
            if ((replaceList.ElementAt(replaceList.Count - 1) != Convert.ToString(LimitValue)) && replaceList.ElementAt(replaceList.Count - 1) != "C" && replaceList.ElementAt(replaceList.Count - 1) != "E" && replaceList.ElementAt(replaceList.Count - 1) != "Z")
                replaceList.Add(Convert.ToString(LimitValue));

            return replaceList;
        }

        public List<int> getFibonacciSequence(int LimitValue)
        {
            List<int> fibonacciList = new List<int>();
             int a = 0;
            int b = 1;

            if (LimitValue > 0)
            {
                int c = a;
                for (int i = 0; c <= LimitValue; i++)
                {
                    c = a;
                    a = b;
                    b = b + c;

                    if (c <= LimitValue)
                        fibonacciList.Add(c);  
                }
            }
            else
            {
                fibonacciList.Add(LimitValue);
            }
            //Following is line to include the Entered Number in list as it is mentioned in requirement (Requirment: S3.1.5)
            if (fibonacciList.ElementAt(fibonacciList.Count - 1) != LimitValue)
                fibonacciList.Add(LimitValue);

            return fibonacciList;

        }
    }
}
