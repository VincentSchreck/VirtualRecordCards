using System;
using System.Reflection;
using Xunit;
using Moq;
using Autofac.Extras.Moq;
using VRC.Domain;

namespace VRC_XUnitTest
{
    public class UnitTest_2
    {
        [Fact]
        public void Test_TextQuestion()
        {
            // Arrange
            RecordCardTextContent x = new RecordCardTextContent();
            x.QuestionText = "Fragentext?";

            // Act
            string actual = x.QuestionText;

            // Assert
            Assert.Equal("Fragentext?", actual);
        }

        [Fact]
        public void Test_TextGetRecordCardType()
        {
            // Arrange
            RecordCardTextContent x = new RecordCardTextContent();

            // Act
            string actual = x.getRecordCardType();

            // Assert
            Assert.Equal("Text", actual);
        }

        [Fact]
        public void Test_TextAnswer()
        {
            // Arrange
            RecordCardTextContent x = new RecordCardTextContent();
            x.AnswerText = "Antworttext!";

            // Act
            string actual = x.AnswerText;

            // Assert
            Assert.Equal("Antworttext!", actual);
        }


        [Fact]
        public void Test_TextGetQuestion()
        {
            // Arrange
            RecordCardTextContent x = new RecordCardTextContent();
            x.QuestionText = "Hallo?";

            // Act
            string actual = x.getQuestion();
            
            // Assert
            Assert.Equal("Hallo?", actual);
        }
    }
}
