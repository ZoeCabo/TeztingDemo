using NUnit.Framework;
using System;
using System.Collections;
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
            int n1 = 2;
            int n2 = 5;
            int expectedResult = 7;


            //2 act 

            int result = operations.Add(n1, n2);

            // 3 assert

            Assert.That(result, Is.EqualTo(expectedResult));
            //Assert.That(result,Is.Not.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(10)]
        [TestCase(12)]
        [TestCase(14)]
        public void IsEven_ImputNumber_returnTrue(int number)
        {
            // 1 arrange
            Operations operations = new Operations();

            //int number = 15;

            var result = operations.IsEven(number);
            Assert.That(result, Is.True);
        }

        [Test]
        public void GetEvenNumbers_Inputrange_ReturnEvenNumbers()
        {

            //arrange
            Operations operations = new Operations();
            int start = 0;
            int end = 15;

            //act
            var result = operations.GetEvenNumbers(start, end);

            //assert
            /*Basico hecho por nos*/
            Assert.That(result, Is.Not.Empty);
            Assert.That(result[0], Is.TypeOf<int>());
            Assert.That(result, Is.TypeOf<List<int>>());
            Assert.That(result, Has.Exactly(5).Items);
            Assert.That(result, Is.Ordered);
            Assert.That(result, Has.No.Member(-1));
            Assert.That(result, Does.Contain(0));
            Assert.That(result, Has.Member(0));
            Assert.That(result, Has.Member(10));
            Assert.That(result, Has.Member(6));
            Assert.That(result, Has.No.Member(11));
            Assert.That(result, Has.No.Member(1));
            Assert.That(result, Has.No.Member(5));


        }
        [Test]
        [TestCase(1, 20)]
        [TestCase(100, 1000)]
        public void GetEvenNumbers_SeveralInputrange_ReturnEvenNumbers(int start, int end)
        {
            //arrange

            Operations operations = new();
            int startNumber = start % 2 == 0 ? start : start +1;
            int endNumber = end % 2 == 0 ? start : start - 1;
            int middleNumber = (endNumber + startNumber) / 2;
            middleNumber = middleNumber % 2 == 0 ? middleNumber : middleNumber +1;

            //act
            var result = operations.GetEvenNumbers(start, end);

            //assert
            Assert.That(result, Is.Not.Empty);
            Assert.That(end - start >= 2, Is.True);
            Assert.That(result[0], Is.TypeOf<int>());
            Assert.That(result, Is.TypeOf<List<int>>());
            Assert.That(result, Is.Ordered);
            Assert.That(result,Has.No.All.LessThan(startNumber));
            Assert.That(result,Has.Member(startNumber));
            Assert.That(result, Has.Member(endNumber));
            Assert.That(result, Has.Member(middleNumber));
            Assert.That(result, Has.No.All.GreaterThan(endNumber));
            Assert.That(result, Has.All.InRange(startNumber,endNumber));
            Assert.That(result, Is.Unique);
        }
    }
}
