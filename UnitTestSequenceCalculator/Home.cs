using System;
using SequenceGenerator.Controllers;
using SequenceGenerator.Models;
using System.Web;
using DAL;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NUnit.Framework;

namespace UnitTestSequenceCalculator
{
    [TestFixture]
    public class Home
    {
        Utility utility;
        [SetUp]
        public void BeforeEachTest()
        {
            Console.WriteLine("Before {0}", TestContext.CurrentContext.Test.Name);
            var sut = new SequenceGenerator.Models.sequenceModel();
        
        }

        [TestCase(5)]
        public void TestNumberSeq(int value)
        {

            var result = utility.getNumbers(5);
            List<int> numbers = new List<int>();
            for (int i = 1; i <= value; i++)
            {
                numbers.Add(i);
            }

            Assert.That(result, Is.EqualTo(numbers));

        }
       [TestCase(5)]
        public void TestOddSeq(int value)
        {

            var result = utility.getOddSequence(5);
            List<int> numbers = new List<int>();
            for (int i = 1; i <= value; i++)
            {
                if ((i % 2) != 0)
                {
                    numbers.Add(i);
                }
            }

            if (numbers.ElementAt(numbers.Count - 1) != value)
                numbers.Add(value);

            Assert.That(result, Is.EqualTo(numbers));

        }
        [TestCase(5)]
        public void TestEvenSeq(int value)
        {

            var result = utility.getEvenSequence(5);
            List<int> numbers = new List<int>();
            for (int i = 1; i <= value; i++)
            {
                if ((i % 2) == 0)
                {
                    numbers.Add(i);
                }
            }

            if (numbers.ElementAt(numbers.Count - 1) != value)
                numbers.Add(value);

            Assert.That(result, Is.EqualTo(numbers));

        }
        [TestCase(5)]
        public void TestReplaceSeq(int value)
        {

            var result = utility.getReplacedSequence(5);
            List<string> numbers = new List<string>();
            for (int i = 1; i <= value; i++)
            {
                if ((i % 3) == 0 && (i % 5) != 0)
                {
                    numbers.Add("C");
                }
                else if ((i % 5) == 0 && (i % 3) != 0)
                {
                    numbers.Add("E");
                }
                else if (((i % 5) == 0) && ((i % 3) == 0))
                {
                    numbers.Add("Z");
                }
                else
                {
                    numbers.Add(Convert.ToString(i));
                }

            }
            //Following is line to include the Entered Number in list as it is mentioned in requirement (Requirment: S3.1.4)
            // And Whenever there is C, E and Z in the last location, Entered number would not be included (Requirement: S3.1.4.1, S3.1.4.2, S3.1.4.3)
            if ((numbers.ElementAt(numbers.Count - 1) != Convert.ToString(value)) && numbers.ElementAt(numbers.Count - 1) != "C" && numbers.ElementAt(numbers.Count - 1) != "E" && numbers.ElementAt(numbers.Count - 1) != "Z")
                numbers.Add(Convert.ToString(value));


            Assert.That(result, Is.EqualTo(numbers));

        }
        [TestCase(5)]
        public void TestFibSeq(int value)
        {

            var result = utility.getFibonacciSequence(5);
            List<int> numbers = new List<int>();
            int a = 0;
            int b = 1;

            if (value > 0)
            {
                int c = a;
                for (int i = 0; c <= value; i++)
                {
                    c = a;
                    a = b;
                    b = b + c;

                    if (c <= value)
                        numbers.Add(c);
                }
            }
            else
            {
                numbers.Add(value);
            }

            if (numbers.ElementAt(numbers.Count - 1) != value)
                numbers.Add(value);

            Assert.That(result, Is.EqualTo(numbers));

        }
        [TearDown]
        public void AfterEachTest()
        {
            Console.WriteLine("After {0}", TestContext.CurrentContext.Test.Name);
          
        }
    }
}
