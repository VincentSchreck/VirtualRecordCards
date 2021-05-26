using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VRC.Domain;

namespace VRC_UnitTest
{
    [TestClass]
    public class UnitTest1_RecordcardListnameBox
    {
        [TestMethod]
        public void TesteLeerMitText()
        {
            // Arrange
            Recordcard recordcard = new Recordcard();
            //recordcard.KarteikartenTyp = KarteikartenTyp.Text;
            recordcard.Thema = "";
            //recordcard.QuestionText = "";

            // Act
            String result = recordcard.getListboxName();

            // Assert 
            Assert.AreEqual("|", result);
        }

        [TestMethod]
        public void TesteNormalMitText()
        {
            // Arrange
            Recordcard recordcard = new Recordcard();
            //recordcard.KarteikartenTyp = KarteikartenTyp.Text;
            recordcard.Thema = "Hallo";
            //recordcard.QuestionText = "Test";

            // Act
            String result = recordcard.getListboxName();

            // Assert 
            Assert.AreEqual("Hallo|Test", result);
        }

        [TestMethod]
        public void TesteTopicOverflowMitText()
        {
            // Arrange
            Recordcard recordcard = new Recordcard();
            //recordcard.KarteikartenTyp = KarteikartenTyp.Text;
            recordcard.Thema = "HalloHallo";
            //recordcard.QuestionText = "Test";

            // Act
            String result = recordcard.getListboxName();

            // Assert 
            Assert.AreEqual("HalloHa|Test", result);
        }

        [TestMethod]
        public void TesteQuestionOverflowMitText()
        {
            // Arrange
            Recordcard recordcard = new Recordcard();
           // recordcard.KarteikartenTyp = KarteikartenTyp.Text;
            recordcard.Thema = "Hallo";
            //recordcard.QuestionText = "TestTestTest";

            // Act
            String result = recordcard.getListboxName();

            // Assert 
            Assert.AreEqual("Hallo|TestTes", result);
        }

        [TestMethod]
        public void TesteNormalMitAbbildung()
        {
            // Arrange
            Recordcard recordcard = new Recordcard();
            //recordcard.KarteikartenTyp = KarteikartenTyp.Abbildung;
            recordcard.Thema = "Hallo";
            //recordcard.QuestionAbbildung = "Test";

            // Act
            String result = recordcard.getListboxName();

            // Assert 
            Assert.AreEqual("Hallo|Test", result);
        }

        [TestMethod]
        public void TesteNormalMitAufzaehlung()
        {
            // Arrange
            Recordcard recordcard = new Recordcard();
            //recordcard.KarteikartenTyp = KarteikartenTyp.Aufzaehlung;
            recordcard.Thema = "Hallo";
           // recordcard.QuestionAufzaehlung = "Test";

            // Act
            String result = recordcard.getListboxName();

            // Assert 
            Assert.AreEqual("Hallo|Test", result);
        }

        [TestMethod]
        public void TesteNormalMitMultipleChoice()
        {
            // Arrange
            Recordcard recordcard = new Recordcard();
            //recordcard.KarteikartenTyp = KarteikartenTyp.MultipleChoice;
            recordcard.Thema = "Hallo";
           // recordcard.QuestionMultipleChoice = "Test";

            // Act
            String result = recordcard.getListboxName();

            // Assert 
            Assert.AreEqual("Hallo|Test", result);
        }


    }
}
