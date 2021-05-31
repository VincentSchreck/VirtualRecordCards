using Xunit;
using VRC.Application;

namespace VRC_XUnitTest
{
    public class UnitTest_8
    {
        [Fact]
        public void Test_PruefEinstellung_AlleKK()
        {
            // Arrange
            PruefEinstellungen x = new PruefEinstellungen();
            x.AlleKarteikarten = true;

            // Act
            bool actual = x.AlleKarteikarten;

            // Assert
            Assert.True(actual);
        }

        [Fact]
        public void Test_PruefEinstellung_AnzahlKK()
        {
            // Arrange
            PruefEinstellungen x = new PruefEinstellungen();
            x.AnzahlGenerellKarteikarten = 12;

            // Act
            uint actual = x.AnzahlGenerellKarteikarten;

            // Assert
            Assert.Equal((uint)12, actual);
        }

        [Fact]
        public void Test_PruefEinstellung_AnzahlWiederholungen()
        {
            // Arrange
            PruefEinstellungen x = new PruefEinstellungen();
            x.AnzahlWiederholungen = 77;

            // Act
            uint actual = x.AnzahlWiederholungen;

            // Assert
            Assert.Equal((uint)77, actual);
        }

        [Fact]
        public void Test_PruefEinstellung_NurFalschBeantwortet()
        {
            // Arrange
            PruefEinstellungen x = new PruefEinstellungen();
            x.NurFalschBeantwortete = true;

            // Act
            bool actual = x.NurFalschBeantwortete;

            // Assert
            Assert.True(actual);
        }

        [Fact]
        public void Test_PruefEinstellung_SpeicherOrt()
        {
            // Arrange
            PruefEinstellungen x = new PruefEinstellungen();
            x.Speicherort = "C:/User/System/Files";

            // Act
            string actual = x.Speicherort;

            // Assert
            Assert.Equal("C:/User/System/Files", actual);
        }

        [Fact]
        public void Test_PruefEinstellung_WiederholungErlauben()
        {
            // Arrange
            PruefEinstellungen x = new PruefEinstellungen();
            x.WiederholungenErlauben = true;

            // Act
            bool actual = x.WiederholungenErlauben;

            // Assert
            Assert.True(actual);
        }

        [Fact]
        public void Test_PruefEinstellung_Zufallsreihenfolge()
        {
            // Arrange
            PruefEinstellungen x = new PruefEinstellungen();
            x.Zufallsreihenfolge = true;

            // Act
            bool actual = x.Zufallsreihenfolge;

            // Assert
            Assert.True(actual);
        }
    }
}
