using Xunit;
using VRC.Domain;

namespace VRC_XUnitTest
{
    public class UnitTest_7
    {
        [Fact]
        public void Test_AufzaehlungAddAnswer()
        {
            // Arrange
            RecordCardAufzaehlungContent x = new RecordCardAufzaehlungContent();
            int firstCount = x.ErhalteAnswerAufzaehlung().Count;
            x.FuegeAntwortHinzu("Neues Item");

            // Act
            int actual = x.ErhalteAnswerAufzaehlung().Count;

            // Assert
            Assert.Equal(firstCount+1, actual);
        }

        [Fact]
        public void Test_AufzaehlungGetQuestion()
        {
            // Arrange
            RecordCardAufzaehlungContent x = new RecordCardAufzaehlungContent();
            x.QuestionAufzaehlung = "Hallo?";

            // Act
            string actual = x.ErhalteQuestion();

            // Assert
            Assert.Equal("Hallo?", actual);
        }

        [Fact]
        public void Test_AufzaehlungRecordcardType()
        {
            // Arrange
            RecordCardAufzaehlungContent x = new RecordCardAufzaehlungContent();

            // Act
            string actual = x.ErhalteRecordCardType();

            // Assert
            Assert.Equal("Aufzaehlung", actual);
        }
    }
}
