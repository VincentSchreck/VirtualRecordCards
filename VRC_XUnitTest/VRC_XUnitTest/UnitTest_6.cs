using System;
using System.Reflection;
using Xunit;
using Moq;
using Autofac.Extras.Moq;
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
            //x.AktuelleKarteikarte = "";

            // Act
            string actual = null;

            // Assert
            Assert.Equal(null, actual);
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
        public void Test_KKEditorGetFilePath()
        {
            // Arrange
            KarteikartenEditor x = new KarteikartenEditor();
            x.FilePath = "C:/Users/File.xml";

            // Act
            string actual = x.FilePath;

            // Assert
            Assert.Equal("C:/Users/File.xml", actual);
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

        //[Fact]
        //public void Test_MCQuestions()
        //{
        //    // Arrange
        //    RecordCardMultipleChoiceContent x = new RecordCardMultipleChoiceContent();
        //    x.QuestionMultipleChoice = "Frage?";

        //    // Act
        //    string actual = x.QuestionMultipleChoice;

        //    // Assert
        //    Assert.Equal("Frage?", actual);
        //}

        //[Fact]
        //public void Test_MCAnswers()
        //{
        //    // Arrange
        //    RecordCardMultipleChoiceContent x = new RecordCardMultipleChoiceContent();
        //    x.AnswerMultipleChoice = "Antworten!";

        //    // Act
        //    string actual = x.AnswerMultipleChoice;

        //    // Assert
        //    Assert.Equal("Antworten!", actual);
        //}
    }
}
