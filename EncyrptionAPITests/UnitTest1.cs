namespace EncyrptionAPITests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
                // Arrange
                var originalText = "ABC";
                var expected = "DEF";

                // Act
                var result = new string(originalText.Select(c => (char)(c + 3)).ToArray());

                // Assert
                Assert.Equal(expected, result);
        }
    }
}
