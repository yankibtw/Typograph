using typograph;

namespace TestProject1
{
    public class Tests
    {
        [Test]
        public void ChangePunctuation_Test()
        {

            var input = "Hello, World !";
            var expectedOutput = "Hello, World!";

            // Act
            var textFormatter = new TextFormatter();
            var result = textFormatter.ChangePunctuation(input);

            // Assert
            Assert.AreEqual(expectedOutput, result);
        }

        [Test]
        public void WhitespChangingTheSpellingOfSpaceace_Test()
        {
            // Arrange
            var textFormatter = new TextFormatter();
            var input = "Hello   World   ";
            var expectedOutput = "Hello World ";

            // Act
            var result = textFormatter.WhitespChangingTheSpellingOfSpaceace(input);

            // Assert
            Assert.AreEqual(expectedOutput, result);
        }

        [Test]
        public void ChangingQuotes_Test()
        {
            // Arrange
            var textFormatter = new TextFormatter();
            string input = "She said, \"Hello, World!\"";
            string expectedOutput = "She said, «Hello, World!»";

            // Act
            string result = textFormatter.ChangingQuotes(input);

            // Assert
            Assert.AreEqual(expectedOutput, result);
        }

        [Test]
        public void ReplacingTheSignApproximately_Testl()
        {
            // Arrange
            var textFormatter = new TextFormatter();
            string input = "The temperature is 20+-2°C";
            string expectedOutput = "The temperature is 20 ± 2°C";

            // Act
            string result = textFormatter.ReplacingTheSignApproximately(input);

            // Assert
            Assert.AreEqual(expectedOutput, result);
        }

        [Test]
        public void ReplaceEllipsis_Test()
        {
            // Arrange
            var textFormatter = new TextFormatter();
            string input = "Let's meet...";
            string expectedOutput = "Let's meet…";

            // Act
            string result = textFormatter.ReplaceEllipsis(input);

            // Assert
            Assert.AreEqual(expectedOutput, result);
        }

        [Test]
        public void ReplaceExclamationMark_Test()
        {
            // Arrange
            var textFormatter = new TextFormatter();
            string input = "Hello! world!";
            string expectedOutput = "Hello! World!";

            // Act
            string result = textFormatter.ReplaceExclamationMark(input);

            // Assert
            Assert.AreEqual(expectedOutput, result);
        }

        [Test]
        public void ReverseSentences_Test()
        {
            // Arrange
            var textFormatter = new TextFormatter();
            string input = "This is a sentence.";
            string expectedOutput = ".ecnetnes a si sihT";

            // Act
            string result = textFormatter.ReverseSentences(input);

            // Assert
            Assert.AreEqual(expectedOutput, result);
        }

        [Test]
        public void ReverseString_Test()
        {
            // Arrange
            var textFormatter = new TextFormatter();
            string input = "hello";
            string expectedOutput = "olleh";

            // Act
            string result = textFormatter.ReverseString(input);

            // Assert
            Assert.AreEqual(expectedOutput, result);
        }

        [Test]
        public void TypographyText_WithValidInput_ReturnsCorrectlyFormattedText()
        {
            // Arrange
            var textFormatter = new TextFormatter();
            string inputText = "Hello, World! Some-this";
            string expectedOutput = "!dlroW ,olleH siht - emoS";

            // Act
            string result = textFormatter.TypographyText(inputText);

            // Assert
            Assert.AreEqual(expectedOutput, result);
        }

        [Test]
        public void TypographyText_WithNullOrEmptyInput_ReturnsEmptyString()
        {
            // Arrange
            var textFormatter = new TextFormatter();
            string inputText = "";

            // Act
            string result = textFormatter.TypographyText(inputText);

            // Assert
            Assert.AreEqual(string.Empty, result);
        }
    }
}