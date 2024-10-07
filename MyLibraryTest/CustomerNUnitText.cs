

using NUnit.Framework;

namespace MyLibrary
{
    [TestFixture]
   public class CustomerNUnitText
    {
        [Test]

       public void FullName_ReturnEmpty()
        {
            //1.arrange
            Customer customer = new Customer();
            //2.act 
            string result= customer.FullName;
            //3.Assert
            Assert.That(result,Is.WhiteSpace);
        }

        [Test]

        public void FullName_ReturnFullName()
        {
            //1.arrange
            Customer customer = new Customer()
            {
                FirstName = "jhon", LastName="Doe"
            };
            //2.act 
            string result = customer.FullName;
            //3.Assert
            Assert.That(result, Is.Not.WhiteSpace);
            Assert.That(result,Does.Contain(" "));
            Assert.That(result, Does.Contain("jhon"));
            Assert.That(result, Does.Contain("Doe"));
            Assert.That(result, Does.StartWith("jhon"));
            Assert.That(result, Does.EndWith("Doe"));
            Assert.That(result, Is.EqualTo("jhon Doe"));
            Assert.That(result, Is.EqualTo("Jhon doe").IgnoreCase);
        }

    }
}
