using VRC.Domain;
using Xunit;
using VRC.Application;

namespace VRC_XUnitTest
{
    public class UnitTest_5
    {
        [Fact]
        public void Test_PruefmodusPruefeAbfrageEnde()
        {
            // Arrange
            Pruefmodus x = new Pruefmodus();

            // Act
            bool actual = x.PruefeAbfrageEnde();

            // Assert
            Assert.True(actual);
        }

        [Fact]
        public void Test_PruefmodusPruefeFalschBehandelteModus()
        {
            // Arrange
            Pruefmodus x = new Pruefmodus();

            // Act
            bool actual = x.PruefeFalschBehandelteModus();

            // Assert
            Assert.False(actual);
        }

        [Fact]
        public void Test_PruefmodusPruefeRundenEnde()
        {
            // Arrange
            Pruefmodus x = new Pruefmodus();

            // Act
            bool actual = x.PruefeRundenEnde();

            // Assert
            Assert.True(actual);
        }

        [Fact]
        public void Test_PruefmodusErhalteAnzahlRichtiger()
        {
            // Arrange
            Pruefmodus x = new Pruefmodus();

            // Act
            int actual = x.ErhalteAnzahlRichtiger();

            // Assert
            Assert.Equal(0, actual);
        }

        [Fact]
        public void Test_PruefmodusAktuelleKarteikarteNULL()
        {
            // Arrange
            Pruefmodus x = new Pruefmodus();
            //Recordcard vergleich = null;

            // Act
            Recordcard actual = x.AktuelleKarteikarte;

            // Assert
            Assert.Null(actual);
        }
    }
}
