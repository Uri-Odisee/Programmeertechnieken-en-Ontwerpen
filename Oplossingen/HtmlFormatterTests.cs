using System;
using NUnit.Framework;
using TestNinja.Fundamentals;


namespace TestNinja.UnitTests
{
    [TestFixture]
    class HtmlFormatterTests
    {
        [Test]
        public void FormatAsBold_WhenCalled_ShouldEncloseTheStringWithStrongElement()
        {
            var formatter = new HtmlFormatter();

            var result = formatter.FormatAsBold("abc");

            // specifiek
            //Assert.That(result, Is.EqualTo("<strong>abc</strong>"));

            // general
            Assert.That(result, Does.StartWith("<strong>"));
            Assert.That(result, Does.EndWith("</sTrong>").IgnoreCase);
            Assert.That(result, Does.Contain("abc"));
        }
    }
}
