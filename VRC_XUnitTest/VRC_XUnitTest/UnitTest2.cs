using System;
using System.Reflection;
using Xunit;
using Moq;
using Autofac.Extras.Moq;
using VRC.Domain;

namespace VRC_XUnitTest
{
    public class UnitTest2
    {
        [Fact]
        public void Test_MCQuestion()
        {
            // Arrange
            RecordCardMultipleChoiceContent x = new RecordCardMultipleChoiceContent();
            x.QuestionMultipleChoice = "Hallo?";

            // Act
            string actual = x.getQuestion();

            // Assert
            Assert.Equal("Hallo?", actual);
        }

        [Fact]
        public void Test_MCRecordcardType()
        {
            // Arrange
            RecordCardMultipleChoiceContent x = new RecordCardMultipleChoiceContent();

            // Act
            string actual = x.getRecordCardType();

            // Assert
            Assert.Equal("Multiple Choice", actual);
        }


        [Fact]
        public void Test_MCQuestions()
        {
            // Arrange
            RecordCardMultipleChoiceContent x = new RecordCardMultipleChoiceContent();
            x.QuestionMultipleChoice = "Frage?";

            // Act
            string actual = x.QuestionMultipleChoice;

            // Assert
            Assert.Equal("Frage?", actual);
        }

        [Fact]
        public void Test_MCAnswers()
        {
            // Arrange
            RecordCardMultipleChoiceContent x = new RecordCardMultipleChoiceContent();
            x.AnswerMultipleChoice = "Antworten!";

            // Act
            string actual = x.AnswerMultipleChoice;

            // Assert
            Assert.Equal("Antworten!", actual);
        }


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
