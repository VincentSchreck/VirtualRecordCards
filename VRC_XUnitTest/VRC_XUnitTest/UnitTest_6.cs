using Xunit;
using VRC.Application;
using VRC.Domain;

namespace VRC_XUnitTest
{
    public class UnitTest_6
    {
        [Fact]
        public void Test_KKEditorAktuelleKK()
        {
            // Arrange
            KarteikartenEditor x = new KarteikartenEditor();

            // Act
            RecordcardSet actual = x.RecordCardSammlung;

            // Assert
            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_KKEditorAktuellerKKIndex()
        {
            // Arrange
            KarteikartenEditor x = new KarteikartenEditor();

            // Act
            int actual = x.AktuellerKarteikartenIndex;

            // Assert
            Assert.Equal(-1, actual);
        }

        [Fact]
        public void Test_KKEditorGetListCount()
        {
            // Arrange
            KarteikartenEditor x = new KarteikartenEditor();

            //x.ListCount = 0;

            // Act
            int actual = x.ListCount;

            // Assert
            Assert.Equal(0, actual);
        }

        [Fact]
        public void Test_KKEditorErhalteFachbezeichnung()
        {
            // Arrange
            KarteikartenEditor x = new KarteikartenEditor();
            x.SetzeFachbezeichnung("Mathematik");

            // Act
            string actual = x.ErhalteFachbezeichnung();

            // Assert
            Assert.Equal("Mathematik", actual);
        }

        [Fact]
        public void Test_KKEditorSetzeFachbezeichnung()
        {
            // Arrange
            KarteikartenEditor x = new KarteikartenEditor();
            x.SetzeKarteikartenIndex(5);

            // Act
            int actual = x.AktuellerKarteikartenIndex;

            // Assert
            Assert.Equal(5, actual);
        }

        [Fact]
        public void Test_KKEditorKKIndexReset()
        {
            // Arrange
            KarteikartenEditor x = new KarteikartenEditor();
            x.KarteikartenIndexReset();

            // Act
            var actual = x.ListCount - 1;

            // Assert
            Assert.Equal(-1, actual);
        }
    }
}
