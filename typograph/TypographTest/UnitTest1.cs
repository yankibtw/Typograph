using typograph;

namespace TypographTest
{
    public class Tests
    {


        private mainForm form;

        [SetUp]
        public void Setup()
        {
            form = new mainForm();
            // ƒополнительные настройки формы, если необходимо
        }
        [Test]
        public void TypeBtn_Click_TypographyTextCalled()
        {
            // Arrange
            var yourClass = new YourClass(); // замените YourClass на им€ вашего класса
            var mainTextBox = new TextBox(); // замените TextBox на тип вашего текстового пол€
            mainTextBox.Text = "Your test input text"; // установите текст дл€ теста
            var eventArgs = new EventArgs(); // создайте аргументы событи€

            // Act
            yourClass.TypeBtn_Click(mainTextBox, eventArgs);

            // Assert
            // «десь мы провер€ем, что метод TypographyText был вызван с правильным аргументом
            Assert.That(yourClass.TypographyTextCalledWith, Is.EqualTo(mainTextBox.Text));
        }
    }
}