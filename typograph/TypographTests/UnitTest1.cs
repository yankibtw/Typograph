using typograph;

namespace TypographTests;

    public class UnitTest1
    {
    [TestMethod]
    public void TypeBtn_Click_TypographyTextCalled()
    {
        // Arrange
        var yourClass = new mainForm(); // �������� YourClass �� ��� ������ ������
        var text = new mainTextBox(); // �������� TextBox �� ��� ������ ���������� ����
        text.Text = "Your test input text"; // ���������� ����� ��� �����
        var eventArgs = new EventArgs(); // �������� ��������� �������

        // Act
        yourClass.TypeBtn_Click(mainTextBox, eventArgs);

        // Assert
        // ����� �� ���������, ��� ����� TypographyText ��� ������ � ���������� ����������
        Assert.AreEqual(mainTextBox.Text, yourClass.TypographyTextCalledWith);
    }
}
