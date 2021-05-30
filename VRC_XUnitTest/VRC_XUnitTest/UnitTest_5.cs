using System;
using System.Reflection;
using Moq;
using Autofac.Extras.Moq;
using VRC.Domain;
using Xunit;
using VRC.Application;

namespace VRC_XUnitTest
{
    public class UnitTest_5
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

        [Fact]
        public void Test_KKBearbeitenSettingPruefePfadFALSE()
        {
            // Arrange
            KarteikartenBearbeitenEinstellung x = new KarteikartenBearbeitenEinstellung();

            // Act
            bool actual = x.PruefePfad();

            // Assert
            Assert.Equal(false, actual);
        }

        [Fact]
        public void Test_KKBearbeitenSettingPruefePfadTRUE()
        {
            // Arrange
            KarteikartenBearbeitenEinstellung x = new KarteikartenBearbeitenEinstellung();
            x.Speicherort = "C:/Users/File.xml";

            // Act
            bool actual = x.PruefePfad();

            // Assert
            Assert.Equal(true, actual);
        }
    }
}
