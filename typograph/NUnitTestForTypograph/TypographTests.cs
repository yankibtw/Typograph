using typograph;

namespace NUnitTestForTypograph
{
    public class Tests
    {
        [Test]
        public void ChangePunctuation() {

            var input = "Hello, World !";
            var expectedOutput = "Hello, World!";

            // Act
            var textFormatter = new TextFormatter();
            var result = textFormatter.ChangePunctuation(input);

            // Assert
            Assert.AreEqual(expectedOutput, result);
        }

        [Test]
        public void WhitespChangingTheSpellingOfSpaceace()
        {
            // Arrange
            var textFormatter = new TextFormatter();
            var input = "Hello   World   ";
            var expectedOutput = "Hello World";

            // Act
            var result = textFormatter.WhitespChangingTheSpellingOfSpaceace(input);

            // Assert
            Assert.AreEqual(expectedOutput, result);
        }
    }
}