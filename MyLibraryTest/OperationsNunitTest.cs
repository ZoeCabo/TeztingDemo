using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    [TestFixture]
    public class OperationsNunitTest
    {
        [Test]
        public void add_imputNumbers_returnNumber()
        {
            // 1 Arrange

            Operations operations = new Operations();
            int n1 =2; 
            int n2 =5;
            int expectedResult = 7;


            //2 act 

            int result= operations.Add(n1,n2);

            // 3 assert

            Assert.That(result, Is.EqualTo(expectedResult));
            Assert.That(result,Is.Not.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(10)]
        [TestCase(12)]
        [TestCase(14)]
        public void IsEven_ImputNumber_returnTrue( int number)
        {
            // 1 arrange
            Operations operations=new Operations();

            //int number = 10;

            var result = operations.IsEven(number);
            Assert.That(result, Is.True);
        }
    }
}
