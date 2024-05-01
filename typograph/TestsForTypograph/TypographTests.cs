using typograph;

namespace TestsForTypograph
{
    [TestFixture]
    public class Tests
    {
        private mainForm form;

        [SetUp]
        public void Setup()
        {
            form = new mainForm();
        }

        [Test]
        public void TestChangePunctuation()
        {
            // Arrange
            string input = "Some text there , but with errors . Another-text !";
            string expectedOutput = "Some text there, but with errors. Another - text!";

            // Act
            string result = form.ChangePunctuation(input);

            // Assert
            Assert.AreEqual(expectedOutput, result);
        }
    }
}