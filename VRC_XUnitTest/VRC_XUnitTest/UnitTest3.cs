using System;
using System.Reflection;
using Xunit;
using Moq;
using Autofac.Extras.Moq;
using VRC.Domain;

namespace VRC_XUnitTest
{
    public class UnitTest3
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
            string actual = x.ErhalteQuestion();

            // Assert
            Assert.Equal("Hallo?", actual);
        }

        

        [Fact]
        public void Test_TextGetRecordCardType()
        {
            // Arrange
            RecordCardTextContent x = new RecordCardTextContent();

            // Act
            string actual = x.ErhalteRecordCardType();

            // Assert
            Assert.Equal("Text", actual);
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


        //[Fact]
        //public void Test_RecordcardGetListboxNameLangerName()
        //{
        //    using (var mock = AutoMock.GetStrict())
        //    {
        //        mock.Mock<RecordCardContent>()
        //            .Setup(x => x.getQuestion())
        //            .Returns("FrageFrage");

        //        mock.Mock<RecordCardContent>()
        //            .Setup(x => x.getRecordCardType())
        //            .Returns("Typ");

        //        var cls = mock.Create<Recordcard>();
        //        cls.Thema = "Thema";
        //        var actual = cls.getListboxName();

        //        mock.Mock<RecordCardContent>()
        //            .Verify(x => x.getQuestion());

        //        mock.Mock<RecordCardContent>()
        //            .Verify(x => x.getRecordCardType());

        //        Assert.Equal("Typ|Thema|FrageFr", actual);
        //    }
        //}
    }
}
