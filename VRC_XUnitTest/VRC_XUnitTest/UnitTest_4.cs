using Xunit;
using VRC.Application;

namespace VRC_XUnitTest
{
    public class UnitTest_4
    {
        [Fact]
        public void Test_KKBearbeitenSettingGetSpeicherort()
        {
            // Arrange
            KarteikartenBearbeitenEinstellung x = new KarteikartenBearbeitenEinstellung();
            x.Speicherort = "C:/Users/File.xml";

            // Act
            string actual = x.Speicherort;

            // Assert
            Assert.Equal("C:/Users/File.xml", actual);
        }
    }
}

