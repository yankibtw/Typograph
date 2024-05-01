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
            // �������������� ��������� �����, ���� ����������
        }
        [Test]
        public void TypeBtn_Click_TypographyTextCalled()
        {
            // Arrange
            var yourClass = new YourClass(); // �������� YourClass �� ��� ������ ������
            var mainTextBox = new TextBox(); // �������� TextBox �� ��� ������ ���������� ����
            mainTextBox.Text = "Your test input text"; // ���������� ����� ��� �����
            var eventArgs = new EventArgs(); // �������� ��������� �������

            // Act
            yourClass.TypeBtn_Click(mainTextBox, eventArgs);

            // Assert
            // ����� �� ���������, ��� ����� TypographyText ��� ������ � ���������� ����������
            Assert.That(yourClass.TypographyTextCalledWith, Is.EqualTo(mainTextBox.Text));
        }
    }
}