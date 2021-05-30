using System;
using System.Reflection;
using Xunit;
using Moq;
using Autofac.Extras.Moq;
using VRC.Domain;

namespace VRC_XUnitTest
{
    public class UnitTest_3
    {
        [Fact]
        public void Test_AbbildungGetContentPath()
        {
            // Arrange
            RecordCardAbbildungContent x = new RecordCardAbbildungContent();
            x.ImagePath = "C:/Users/File.xml";

            // Act
            string actual = x.ImagePath;

            // Assert
            Assert.Equal("C:/Users/File.xml", actual);
        }

        [Fact]
        public void Test_AbbildungQuestionAbbildung()
        {
            // Arrange
            RecordCardAbbildungContent x = new RecordCardAbbildungContent();
            x.QuestionAbbildung = "Frage zum Bild?";

            // Act
            string actual = x.QuestionAbbildung;

            // Assert
            Assert.Equal("Frage zum Bild?", actual);
        }


        [Fact]
        public void Test_AbbildungGetQuestion()
        {
            // Arrange
            RecordCardAbbildungContent x = new RecordCardAbbildungContent();
            x.QuestionAbbildung = "Fragestellung?";

            // Act
            string actual = x.getQuestion();

            // Assert
            Assert.Equal("Fragestellung?", actual);
        }


        [Fact]
        public void Test_AbbildungGetRecordCardType()
        {
            // Arrange
            RecordCardAbbildungContent x = new RecordCardAbbildungContent();

            // Act
            string actual = x.getRecordCardType();

            // Assert
            Assert.Equal("Abbildung", actual);
        }
    }
}
