using typograph;

namespace TypographTests;

    public class UnitTest1
    {
    [TestMethod]
    public void TypeBtn_Click_TypographyTextCalled()
    {
        // Arrange
        var yourClass = new mainForm(); // замените YourClass на имя вашего класса
        var text = new mainTextBox(); // замените TextBox на тип вашего текстового поля
        text.Text = "Your test input text"; // установите текст для теста
        var eventArgs = new EventArgs(); // создайте аргументы события

        // Act
        yourClass.TypeBtn_Click(mainTextBox, eventArgs);

        // Assert
        // Здесь мы проверяем, что метод TypographyText был вызван с правильным аргументом
        Assert.AreEqual(mainTextBox.Text, yourClass.TypographyTextCalledWith);
    }
}
