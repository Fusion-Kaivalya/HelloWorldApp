namespace HelloWorldApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test_HelloWorld_Output()
        {
            // Arrange
            var expected = "Hello, World!";

            // Act
            var output = Program.GetHelloWorld();

            // Assert
            Assert.Equal(expected, output);
        }

       
    }
}